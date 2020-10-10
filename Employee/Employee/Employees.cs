using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace Employee
{
    public partial class Employees : Form
    {
        DataSet ds;
        SqlDataAdapter adapter;
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
            EmpTable.Visible = true;
            EmpTable.AutoGenerateColumns = true;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                adapter = new SqlDataAdapter(sql, connection);
                ds = new DataSet();

                adapter.Fill(ds);
                EmpTable.DataSource = ds.Tables[0];
                EmpTable.Columns["ID"].Visible = false;
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
                    row[0] = Guid.NewGuid().ToString();
                    row[1] = FirstNameTextBox.Text;
                    row[2] = LastNameTextBox.Text;
                    row[3] = dateOfBirth;
                    row[4] = PositionTextBox.Text;
                    row[5] = salary;

                    FirstNameTextBox.Clear();
                    LastNameTextBox.Clear();
                    DateOfBirthTextBox.Clear();
                    PositionTextBox.Clear();
                    SalaryTextBox.Clear();

                    ds.Tables[0].Rows.Add(row);

                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
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

        private void FilterButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                adapter = new SqlDataAdapter(sql, connection);
                ds = new DataSet();

                adapter.Fill(ds);
                EmpTable.DataSource = ds.Tables[0];
                EmpTable.CurrentCell = null;

                if (!string.IsNullOrEmpty(Filter.Text))
                { 
                    for (int i = 0; i < EmpTable.Rows.Count; i++)
                    {
                        EmpTable.Rows[i].Visible = EmpTable[4, i].Value.ToString() == Filter.Text;
                    }
                }

                EmpTable.Columns["ID"].ReadOnly = true;
                EmpTable.AutoGenerateColumns = true;
            }
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            var ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            ExcelApp.Application.Workbooks.Add(Type.Missing);

            for (int i = 0; i < EmpTable.ColumnCount; i++)
            {
                for (int j = 0; j < EmpTable.RowCount; j++)
                {
                    ExcelApp.Cells[j + 2, i + 1] = EmpTable[i, j].Value.ToString();
                }
            }

            ExcelApp.Visible = true;
        }
    }
}
