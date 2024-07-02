namespace Employee_Management
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            comboBoxPerformTask = new ComboBox();
            comboBoxSalary = new ComboBox();
            buttonaaaADDTask = new Button();
            label17 = new Label();
            label14 = new Label();
            textBoxEmployeeName = new TextBox();
            labelEmployeeId = new Label();
            label15 = new Label();
            comboBoxGender = new ComboBox();
            comboBoxDepartment = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label11 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxEmail = new TextBox();
            textBoxPhoneNumber = new TextBox();
            textBoxAddress = new TextBox();
            textBoxLastName = new TextBox();
            textBoxFirstName = new TextBox();
            label1 = new Label();
            textBoxMiddleName = new TextBox();
            tabPage2 = new TabPage();
            dataGridViewHistory = new DataGridView();
            panel1 = new Panel();
            textBoxSearch = new TextBox();
            label13 = new Label();
            dataGridViewtask = new DataGridView();
            buttonADD = new Button();
            buttonUpdate = new Button();
            dataGridViewEmployeesList = new DataGridView();
            buttonDelete = new Button();
            buttonSearch = new Button();
            label10 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewtask).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployeesList).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.Location = new Point(36, 41);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1054, 613);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Indigo;
            tabPage1.BorderStyle = BorderStyle.FixedSingle;
            tabPage1.Controls.Add(comboBoxPerformTask);
            tabPage1.Controls.Add(comboBoxSalary);
            tabPage1.Controls.Add(buttonaaaADDTask);
            tabPage1.Controls.Add(label17);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(textBoxEmployeeName);
            tabPage1.Controls.Add(labelEmployeeId);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(comboBoxGender);
            tabPage1.Controls.Add(comboBoxDepartment);
            tabPage1.Controls.Add(dateTimePicker1);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(textBoxEmail);
            tabPage1.Controls.Add(textBoxPhoneNumber);
            tabPage1.Controls.Add(textBoxAddress);
            tabPage1.Controls.Add(textBoxLastName);
            tabPage1.Controls.Add(textBoxFirstName);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textBoxMiddleName);
            tabPage1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 27);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1046, 582);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Input:";
            // 
            // comboBoxPerformTask
            // 
            comboBoxPerformTask.FlatStyle = FlatStyle.Flat;
            comboBoxPerformTask.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxPerformTask.FormattingEnabled = true;
            comboBoxPerformTask.Location = new Point(800, 219);
            comboBoxPerformTask.Name = "comboBoxPerformTask";
            comboBoxPerformTask.Size = new Size(173, 28);
            comboBoxPerformTask.TabIndex = 35;
            // 
            // comboBoxSalary
            // 
            comboBoxSalary.FlatStyle = FlatStyle.Flat;
            comboBoxSalary.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSalary.FormattingEnabled = true;
            comboBoxSalary.Location = new Point(49, 525);
            comboBoxSalary.Name = "comboBoxSalary";
            comboBoxSalary.Size = new Size(160, 28);
            comboBoxSalary.TabIndex = 34;
            // 
            // buttonaaaADDTask
            // 
            buttonaaaADDTask.BackColor = Color.RoyalBlue;
            buttonaaaADDTask.ForeColor = Color.White;
            buttonaaaADDTask.Location = new Point(798, 299);
            buttonaaaADDTask.Margin = new Padding(3, 4, 3, 4);
            buttonaaaADDTask.Name = "buttonaaaADDTask";
            buttonaaaADDTask.Size = new Size(175, 57);
            buttonaaaADDTask.TabIndex = 33;
            buttonaaaADDTask.Text = "ADD";
            buttonaaaADDTask.UseVisualStyleBackColor = false;
            buttonaaaADDTask.Click += buttonaaaADDTask_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Indigo;
            label17.ForeColor = Color.Transparent;
            label17.Location = new Point(659, 223);
            label17.Name = "label17";
            label17.Size = new Size(99, 18);
            label17.TabIndex = 32;
            label17.Text = "PerformTask:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Indigo;
            label14.ForeColor = Color.Transparent;
            label14.Location = new Point(659, 174);
            label14.Name = "label14";
            label14.Size = new Size(136, 18);
            label14.TabIndex = 31;
            label14.Text = "Employee Name:";
            // 
            // textBoxEmployeeName
            // 
            textBoxEmployeeName.BorderStyle = BorderStyle.None;
            textBoxEmployeeName.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmployeeName.Location = new Point(808, 173);
            textBoxEmployeeName.Name = "textBoxEmployeeName";
            textBoxEmployeeName.Size = new Size(165, 19);
            textBoxEmployeeName.TabIndex = 28;
            textBoxEmployeeName.TextAlign = HorizontalAlignment.Center;
            // 
            // labelEmployeeId
            // 
            labelEmployeeId.AutoSize = true;
            labelEmployeeId.BackColor = Color.Indigo;
            labelEmployeeId.ForeColor = Color.Transparent;
            labelEmployeeId.Location = new Point(808, 132);
            labelEmployeeId.Name = "labelEmployeeId";
            labelEmployeeId.Size = new Size(115, 18);
            labelEmployeeId.TabIndex = 27;
            labelEmployeeId.Text = "*Employee Id*";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Indigo;
            label15.ForeColor = Color.Transparent;
            label15.Location = new Point(659, 132);
            label15.Name = "label15";
            label15.Size = new Size(106, 18);
            label15.TabIndex = 26;
            label15.Text = "Employee ID:";
            // 
            // comboBoxGender
            // 
            comboBoxGender.FlatStyle = FlatStyle.Flat;
            comboBoxGender.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Male", "Female" });
            comboBoxGender.Location = new Point(297, 389);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(173, 28);
            comboBoxGender.TabIndex = 25;
            // 
            // comboBoxDepartment
            // 
            comboBoxDepartment.FlatStyle = FlatStyle.Flat;
            comboBoxDepartment.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxDepartment.FormattingEnabled = true;
            comboBoxDepartment.Location = new Point(49, 388);
            comboBoxDepartment.Name = "comboBoxDepartment";
            comboBoxDepartment.Size = new Size(160, 28);
            comboBoxDepartment.TabIndex = 24;
            comboBoxDepartment.SelectedIndexChanged += comboBoxDepartment_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(297, 83);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(173, 26);
            dateTimePicker1.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Transparent;
            label11.Location = new Point(49, 504);
            label11.Name = "label11";
            label11.Size = new Size(69, 18);
            label11.TabIndex = 22;
            label11.Text = "*Salary :";
            label11.Click += label11_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Transparent;
            label9.Location = new Point(297, 439);
            label9.Name = "label9";
            label9.Size = new Size(59, 18);
            label9.TabIndex = 20;
            label9.Text = "*Email:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Transparent;
            label8.Location = new Point(49, 439);
            label8.Name = "label8";
            label8.Size = new Size(128, 18);
            label8.TabIndex = 19;
            label8.Text = "*PhoneNumber :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(315, 367);
            label7.Name = "label7";
            label7.Size = new Size(80, 18);
            label7.TabIndex = 18;
            label7.Text = "*Gender :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(49, 367);
            label6.Name = "label6";
            label6.Size = new Size(106, 18);
            label6.TabIndex = 17;
            label6.Text = "*Department:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(49, 197);
            label5.Name = "label5";
            label5.Size = new Size(81, 18);
            label5.TabIndex = 16;
            label5.Text = "*Address :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(297, 131);
            label4.Name = "label4";
            label4.Size = new Size(99, 18);
            label4.TabIndex = 15;
            label4.Text = "*Last Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(297, 57);
            label3.Name = "label3";
            label3.Size = new Size(103, 18);
            label3.TabIndex = 14;
            label3.Text = "*Date of Birth";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(49, 55);
            label2.Name = "label2";
            label2.Size = new Size(90, 18);
            label2.TabIndex = 13;
            label2.Text = "*FirstName:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(297, 460);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(173, 19);
            textBoxEmail.TabIndex = 7;
            textBoxEmail.TextAlign = HorizontalAlignment.Center;
            textBoxEmail.TextChanged += textBoxEmail_TextChanged;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.BorderStyle = BorderStyle.None;
            textBoxPhoneNumber.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPhoneNumber.Location = new Point(49, 460);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(160, 19);
            textBoxPhoneNumber.TabIndex = 6;
            textBoxPhoneNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxAddress
            // 
            textBoxAddress.BorderStyle = BorderStyle.None;
            textBoxAddress.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAddress.Location = new Point(49, 219);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(421, 123);
            textBoxAddress.TabIndex = 5;
            // 
            // textBoxLastName
            // 
            textBoxLastName.BorderStyle = BorderStyle.None;
            textBoxLastName.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLastName.Location = new Point(297, 152);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(165, 19);
            textBoxLastName.TabIndex = 4;
            textBoxLastName.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.BorderStyle = BorderStyle.None;
            textBoxFirstName.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFirstName.Location = new Point(49, 76);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(160, 19);
            textBoxFirstName.TabIndex = 2;
            textBoxFirstName.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(49, 131);
            label1.Name = "label1";
            label1.Size = new Size(116, 18);
            label1.TabIndex = 1;
            label1.Text = "*MiddleName:";
            // 
            // textBoxMiddleName
            // 
            textBoxMiddleName.BorderStyle = BorderStyle.None;
            textBoxMiddleName.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMiddleName.Location = new Point(49, 152);
            textBoxMiddleName.Name = "textBoxMiddleName";
            textBoxMiddleName.Size = new Size(160, 19);
            textBoxMiddleName.TabIndex = 0;
            textBoxMiddleName.TextAlign = HorizontalAlignment.Center;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.ScrollBar;
            tabPage2.Controls.Add(dataGridViewHistory);
            tabPage2.Controls.Add(panel1);
            tabPage2.Controls.Add(textBoxSearch);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(dataGridViewtask);
            tabPage2.Controls.Add(buttonADD);
            tabPage2.Controls.Add(buttonUpdate);
            tabPage2.Controls.Add(dataGridViewEmployeesList);
            tabPage2.Controls.Add(buttonDelete);
            tabPage2.Controls.Add(buttonSearch);
            tabPage2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage2.ForeColor = Color.Black;
            tabPage2.Location = new Point(4, 27);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1046, 582);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Employees List:";
            // 
            // dataGridViewHistory
            // 
            dataGridViewHistory.AllowUserToAddRows = false;
            dataGridViewHistory.BackgroundColor = Color.FromArgb(192, 255, 255);
            dataGridViewHistory.BorderStyle = BorderStyle.None;
            dataGridViewHistory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHistory.GridColor = Color.Black;
            dataGridViewHistory.Location = new Point(529, 375);
            dataGridViewHistory.Name = "dataGridViewHistory";
            dataGridViewHistory.RowHeadersWidth = 51;
            dataGridViewHistory.RowTemplate.Height = 29;
            dataGridViewHistory.Size = new Size(486, 191);
            dataGridViewHistory.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(25, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 2);
            panel1.TabIndex = 10;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BackColor = SystemColors.ScrollBar;
            textBoxSearch.BorderStyle = BorderStyle.None;
            textBoxSearch.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearch.ForeColor = Color.Transparent;
            textBoxSearch.Location = new Point(128, 83);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(234, 21);
            textBoxSearch.TabIndex = 9;
            textBoxSearch.TextAlign = HorizontalAlignment.Center;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.LawnGreen;
            label13.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(181, 326);
            label13.Name = "label13";
            label13.Size = new Size(225, 23);
            label13.TabIndex = 8;
            label13.Text = "EmployeesTaskList";
            // 
            // dataGridViewtask
            // 
            dataGridViewtask.AllowUserToAddRows = false;
            dataGridViewtask.BackgroundColor = Color.FromArgb(192, 255, 255);
            dataGridViewtask.BorderStyle = BorderStyle.None;
            dataGridViewtask.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewtask.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewtask.GridColor = Color.Black;
            dataGridViewtask.Location = new Point(23, 375);
            dataGridViewtask.Name = "dataGridViewtask";
            dataGridViewtask.RowHeadersWidth = 51;
            dataGridViewtask.RowTemplate.Height = 29;
            dataGridViewtask.Size = new Size(486, 191);
            dataGridViewtask.TabIndex = 7;
            dataGridViewtask.CellContentClick += dataGridView1_CellContentClick;
            dataGridViewtask.KeyDown += dataGridViewtask_KeyDown;
            // 
            // buttonADD
            // 
            buttonADD.BackColor = Color.Blue;
            buttonADD.FlatStyle = FlatStyle.Popup;
            buttonADD.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonADD.ForeColor = Color.Cyan;
            buttonADD.Location = new Point(453, 59);
            buttonADD.Name = "buttonADD";
            buttonADD.Size = new Size(150, 47);
            buttonADD.TabIndex = 5;
            buttonADD.Text = "ADD";
            buttonADD.UseVisualStyleBackColor = false;
            buttonADD.Click += buttonADD_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.Blue;
            buttonUpdate.FlatStyle = FlatStyle.Popup;
            buttonUpdate.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUpdate.ForeColor = Color.Lime;
            buttonUpdate.Location = new Point(680, 59);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(134, 47);
            buttonUpdate.TabIndex = 4;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // dataGridViewEmployeesList
            // 
            dataGridViewEmployeesList.AllowUserToAddRows = false;
            dataGridViewEmployeesList.BackgroundColor = Color.FromArgb(192, 255, 255);
            dataGridViewEmployeesList.BorderStyle = BorderStyle.None;
            dataGridViewEmployeesList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewEmployeesList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployeesList.GridColor = Color.Black;
            dataGridViewEmployeesList.Location = new Point(23, 107);
            dataGridViewEmployeesList.Name = "dataGridViewEmployeesList";
            dataGridViewEmployeesList.RowHeadersWidth = 51;
            dataGridViewEmployeesList.RowTemplate.Height = 29;
            dataGridViewEmployeesList.Size = new Size(1001, 191);
            dataGridViewEmployeesList.TabIndex = 3;
            dataGridViewEmployeesList.CellClick += dataGridViewEmployeesList_CellClick;
            dataGridViewEmployeesList.CellContentClick += dataGridViewEmployeesList_CellContentClick;
            dataGridViewEmployeesList.CellDoubleClick += dataGridViewEmployeesList_CellDoubleClick;
            dataGridViewEmployeesList.KeyDown += dataGridViewEmployeesList_KeyDown;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Blue;
            buttonDelete.FlatStyle = FlatStyle.Popup;
            buttonDelete.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDelete.ForeColor = Color.Red;
            buttonDelete.Location = new Point(881, 59);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(134, 47);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.White;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSearch.ForeColor = Color.LightGray;
            buttonSearch.Location = new Point(24, 60);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(103, 47);
            buttonSearch.TabIndex = 1;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(320, 9);
            label10.Name = "label10";
            label10.Size = new Size(447, 46);
            label10.TabIndex = 1;
            label10.Text = "EMPLOYEE MANAGEMENT";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1143, 712);
            Controls.Add(label10);
            Controls.Add(tabControl1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewtask).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployeesList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private TextBox textBoxEmail;
        private TextBox textBoxPhoneNumber;
        private TextBox textBoxAddress;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
        private Label label1;
        private TextBox textBoxMiddleName;
        private Label label11;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox8;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button buttonSearch;
        private Label label10;
        private DateTimePicker dateTimePicker1;
        private Button buttonDelete;
        private DataGridView dataGridViewEmployeesList;
        private ComboBox comboBoxDepartment;
        private ComboBox comboBoxGender;
        private DataGridView dataGridViewtask;
        private Button buttonADD;
        private Button buttonUpdate;
        private Label label13;
        private TextBox textBoxSearch;
        private Label label17;
        private Label label14;
        private TextBox textBoxEmployeeName;
        private Label labelEmployeeId;
        private Label label15;
        private DataGridViewTextBoxColumn ColumnFirstName;
        private Button buttonaaaADDTask;
        private ComboBox comboBoxSalary;
        private Panel panel1;
        private ComboBox comboBoxPerformTask;
        private DataGridView dataGridViewHistory;
    }
}