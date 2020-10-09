using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public partial class Employees : Form
    {
        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        string connectionString = @"Data Source=DESKTOP-HDUACAM; User ID='sa'; Password='sa';Initial Catalog=employeesdb;Integrated Security=True";
        string sql = "SELECT * FROM Employees";

        public Employees()
        {
            InitializeComponent();

            EmpTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EmpTable.AllowUserToAddRows = false;
            EmpTable.AllowUserToDeleteRows = false;
            EmpTable.AllowUserToOrderColumns = false;
            EmpTable.AllowUserToResizeRows = false;
            EmpTable.AllowUserToResizeColumns = true;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                adapter = new SqlDataAdapter(sql, connection);
                ds = new DataSet();

                adapter.Fill(ds);
                EmpTable.DataSource = ds.Tables[0];
                EmpTable.Columns["ID"].ReadOnly = true;
                EmpTable.AutoGenerateColumns = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var dateOfBirth = new DateTime();
            double salary;

            if (!(String.IsNullOrEmpty(FirstNameTextBox.Text) ||
                String.IsNullOrEmpty(LastNameTextBox.Text) ||
                String.IsNullOrEmpty(DateOfBirthTextBox.Text) ||
                String.IsNullOrEmpty(PositionTextBox.Text) ||
                String.IsNullOrEmpty(SalaryTextBox.Text)) &&
                DateTime.TryParse(DateOfBirthTextBox.Text, out dateOfBirth) &&
                Double.TryParse(SalaryTextBox.Text, out salary))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    adapter = new SqlDataAdapter(sql, connection);

                    var row = ds.Tables[0].NewRow();
                    row["ID"] = Guid.NewGuid().ToString();
                    row["FirstName"] = FirstNameTextBox.Text;
                    row["LastName"] = LastNameTextBox.Text;
                    row["DateOfBirth"] = dateOfBirth;
                    row["Position"] = PositionTextBox.Text;
                    row["Salary"] = salary;
                    
                    ds.Tables[0].Rows.Add(row);

                    commandBuilder = new SqlCommandBuilder(adapter);
                    adapter.Update(ds);
                    ds.Clear();
                    adapter.Fill(ds);
                }
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (EmpTable.Rows.Count != 0)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    adapter = new SqlDataAdapter(sql, connection);

                    foreach (DataGridViewRow row in EmpTable.SelectedRows)
                    {
                        EmpTable.Rows.Remove(row);
                    }

                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                    adapter.Update(ds);
                    ds.Clear();
                    adapter.Fill(ds);
                }
            }
        }
    }
}
