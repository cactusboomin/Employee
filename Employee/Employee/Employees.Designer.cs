namespace Employee
{
    partial class Employees
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReportButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SalaryTextBox = new System.Windows.Forms.TextBox();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.PositionTextBox = new System.Windows.Forms.TextBox();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.DateOfBirthTextBox = new System.Windows.Forms.TextBox();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.Filter = new System.Windows.Forms.TextBox();
            this.FilterButton = new System.Windows.Forms.Button();
            this.EmpTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.EmpTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportButton
            // 
            this.ReportButton.Location = new System.Drawing.Point(564, 415);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(224, 23);
            this.ReportButton.TabIndex = 12;
            this.ReportButton.Text = "Отчёт";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(564, 386);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(224, 23);
            this.DeleteButton.TabIndex = 13;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(564, 256);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(224, 56);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Location = new System.Drawing.Point(564, 229);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(224, 20);
            this.SalaryTextBox.TabIndex = 11;
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.AutoSize = true;
            this.SalaryLabel.Location = new System.Drawing.Point(561, 213);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(58, 13);
            this.SalaryLabel.TabIndex = 10;
            this.SalaryLabel.Text = "Зарплата:";
            // 
            // PositionTextBox
            // 
            this.PositionTextBox.Location = new System.Drawing.Point(564, 190);
            this.PositionTextBox.Name = "PositionTextBox";
            this.PositionTextBox.Size = new System.Drawing.Size(224, 20);
            this.PositionTextBox.TabIndex = 9;
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Location = new System.Drawing.Point(561, 174);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(71, 13);
            this.PositionLabel.TabIndex = 8;
            this.PositionLabel.Text = "Должность: ";
            // 
            // DateOfBirthTextBox
            // 
            this.DateOfBirthTextBox.Location = new System.Drawing.Point(564, 151);
            this.DateOfBirthTextBox.Name = "DateOfBirthTextBox";
            this.DateOfBirthTextBox.Size = new System.Drawing.Size(224, 20);
            this.DateOfBirthTextBox.TabIndex = 7;
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(561, 135);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(89, 13);
            this.DateOfBirthLabel.TabIndex = 6;
            this.DateOfBirthLabel.Text = "Дата рождения:";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(564, 112);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(224, 20);
            this.LastNameTextBox.TabIndex = 5;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(561, 96);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(59, 13);
            this.LastNameLabel.TabIndex = 4;
            this.LastNameLabel.Text = "Фамилия:";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(561, 57);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(32, 13);
            this.FirstNameLabel.TabIndex = 2;
            this.FirstNameLabel.Text = "Имя:";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(564, 73);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(224, 20);
            this.FirstNameTextBox.TabIndex = 3;
            // 
            // Filter
            // 
            this.Filter.Location = new System.Drawing.Point(12, 12);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(442, 20);
            this.Filter.TabIndex = 15;
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(460, 12);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(95, 20);
            this.FilterButton.TabIndex = 16;
            this.FilterButton.Text = "Отфильтровать";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // EmpTable
            // 
            this.EmpTable.AllowUserToAddRows = false;
            this.EmpTable.AllowUserToDeleteRows = false;
            this.EmpTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpTable.Location = new System.Drawing.Point(13, 39);
            this.EmpTable.Name = "EmpTable";
            this.EmpTable.ReadOnly = true;
            this.EmpTable.Size = new System.Drawing.Size(545, 399);
            this.EmpTable.TabIndex = 17;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EmpTable);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.SalaryTextBox);
            this.Controls.Add(this.SalaryLabel);
            this.Controls.Add(this.PositionTextBox);
            this.Controls.Add(this.PositionLabel);
            this.Controls.Add(this.DateOfBirthTextBox);
            this.Controls.Add(this.DateOfBirthLabel);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.FirstNameLabel);
            this.Name = "Employees";
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox SalaryTextBox;
        private System.Windows.Forms.Label SalaryLabel;
        private System.Windows.Forms.TextBox PositionTextBox;
        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.TextBox DateOfBirthTextBox;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox Filter;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.DataGridView EmpTable;
    }
}

