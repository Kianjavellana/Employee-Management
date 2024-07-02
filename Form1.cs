using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;
using System.Data.Common;
using Employee_Management.models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data;
using System.ComponentModel;

namespace Employee_Management
{
    public partial class Form1 : Form
    {
        private BindingList<Employee> employees;
        private List<EmployeeTask> employeeTasks = new List<EmployeeTask>();
        private List<EmployeeTask> employeeTasksHistory = new List<EmployeeTask>();

        public Form1()
        {
            InitializeComponent();
            dataGridViewEmployeesList.CellDoubleClick += new DataGridViewCellEventHandler(dataGridViewEmployeesList_CellDoubleClick);
            employees = new BindingList<Employee>();
            dataGridViewEmployeesList.DataSource = employees;
            // Populate the department options in comboBoxDepartment
            comboBoxDepartment.Items.Add("Sales");
            comboBoxDepartment.Items.Add("HR");
            comboBoxDepartment.Items.Add("IT");
            comboBoxDepartment.Items.Add("Marketing");
            comboBoxDepartment.Items.Add("Finance");


        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployeesList.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridViewEmployeesList.SelectedRows[0];

                // Display a confirmation dialog
                DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    // Get the selected employee object
                    Employee selectedEmployee = selectedRow.DataBoundItem as Employee;

                    // Remove the selected employee from the data source
                    employees.Remove(selectedEmployee);
                }
            }
        }
        private void buttonADD_Click(object sender, EventArgs e)
        {
            // Create a new Employee object with the input values
            Employee employee = new Employee()
            {
                ID = Guid.NewGuid(),
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLastName.Text,
                MiddleName = textBoxMiddleName.Text,
                Gender = comboBoxGender.Text,
                DateOfBirth = dateTimePicker1.Value,
                PhoneNumber = textBoxPhoneNumber.Text,
                Email = textBoxEmail.Text,
                Address = textBoxAddress.Text,
                Department = comboBoxDepartment.Text,
            };

            // Parse the salary value from the combo box
            double salary;
            if (Double.TryParse(comboBoxSalary.Text, out salary))
            {
                employee.Salary = salary;
            }

            // Check if the first name, last name, and middle name already exist
            if (employees.Any(emp => emp.ID != employee.ID &&
                          emp.FirstName == employee.FirstName &&
                          emp.LastName == employee.LastName &&
                          emp.MiddleName == employee.MiddleName))
            {
                MessageBox.Show("Employee with the same name and ID already exists");
                return;
            }

            // Add the new employee to the list of employees
            employees.Add(employee);

            // Refresh the data grid view to show the updated employee list
            dataGridViewEmployeesList.DataSource = null;
            dataGridViewEmployeesList.DataSource = employees;
            // Create an EmployeeTask object and add it to the list of employee tasks

            // Clear the input fields
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxMiddleName.Text = "";
            comboBoxGender.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            textBoxPhoneNumber.Text = "";
            textBoxEmail.Text = "";
            textBoxAddress.Text = "";
            comboBoxDepartment.SelectedIndex = -1;
            comboBoxSalary.Text = "";
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch.Text;
            bool found = false;
            // Clear the input fields
            textBoxSearch.Text = "";

            foreach (DataGridViewRow row in dataGridViewEmployeesList.Rows)
            {
                if (row.Cells["FirstName"].Value != null && row.Cells["FirstName"].Value.ToString().Equals(searchTerm, StringComparison.OrdinalIgnoreCase))
                {
                    row.Selected = true;
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show("Select an employee.");
            }
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // Check if a row is currently being edited
            if (dataGridViewEmployeesList.IsCurrentRowDirty)
            {
                // Commit the changes to stop editing the current cell
                dataGridViewEmployeesList.CommitEdit(DataGridViewDataErrorContexts.Commit);

                // Get the selected row
                DataGridViewRow selectedRow = dataGridViewEmployeesList.SelectedRows[0];

                // Get the selected employee object
                Employee selectedEmployee = selectedRow.DataBoundItem as Employee;

                // Update the selected employee with the new values from the edited row
                selectedEmployee.FirstName = selectedRow.Cells["FirstName"].Value.ToString();
                selectedEmployee.LastName = selectedRow.Cells["LastName"].Value.ToString();
                selectedEmployee.MiddleName = selectedRow.Cells["MiddleName"].Value.ToString();
                selectedEmployee.Gender = selectedRow.Cells["Gender"].Value.ToString();
                selectedEmployee.DateOfBirth = Convert.ToDateTime(selectedRow.Cells["DateOfBirth"].Value);
                selectedEmployee.PhoneNumber = selectedRow.Cells["PhoneNumber"].Value.ToString();
                selectedEmployee.Email = selectedRow.Cells["Email"].Value.ToString();
                selectedEmployee.Address = selectedRow.Cells["Address"].Value.ToString();
                selectedEmployee.Department = selectedRow.Cells["Department"].Value.ToString();

                // Parse the salary value from the combo box
                double salary;
                if (Double.TryParse(selectedRow.Cells["Salary"].Value.ToString(), out salary))
                {
                    selectedEmployee.Salary = salary;
                }

                // Refresh the data grid view to reflect the changes
                dataGridViewEmployeesList.Refresh();

                // Refresh the data grid view for tasks
                RefreshTaskGridView();
            }
        }

        private void RefreshTaskGridView()
        {
            // Get the selected employee's ID and name from the grid view
            if (dataGridViewEmployeesList.SelectedRows.Count > 0)
            {
                string id = dataGridViewEmployeesList.SelectedRows[0].Cells["ID"].Value.ToString();
                string name = dataGridViewEmployeesList.SelectedRows[0].Cells["FirstName"].Value.ToString() + " " + dataGridViewEmployeesList.SelectedRows[0].Cells["LastName"].Value.ToString();

                // Update the task list with the updated employee information
                foreach (EmployeeTask task in employeeTasks)
                {
                    if (task.EmployeeName == name)
                    {
                        task.PerformTask = task.PerformTask.Replace(GetSalaryFromTask(task.PerformTask), GetSelectedSalary());
                    }
                }

                // Refresh the data grid view to show the updated task list
                dataGridViewtask.Refresh();

            }
        }

        private string GetSalaryFromTask(string task)
        {
            int startIndex = task.LastIndexOf("(Salary: ") + "(Salary: ".Length;
            int endIndex = task.IndexOf(")", startIndex);
            if (startIndex >= 0 && endIndex >= 0)
            {
                return task.Substring(startIndex, endIndex - startIndex);
            }
            return "";
        }

        private void dataGridViewEmployeesList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewEmployeesList.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < dataGridViewEmployeesList.Columns.Count && dataGridViewEmployeesList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                // Get the selected employee's name from the cell value
                string name = dataGridViewEmployeesList.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();

                // Update the textBoxFirstName.Text with the selected employee's name
                textBoxEmployeeName.Text = name;

                // Set the labelEmployeeId.Text with the ID value from the selected row
                if (dataGridViewEmployeesList.Rows[e.RowIndex].Cells["ID"].Value != null)
                {
                    string id = dataGridViewEmployeesList.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                    labelEmployeeId.Text = id;
                }
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonaaaADDTask_Click(object sender, EventArgs e)
        { // Check if an employee is selected
            if (dataGridViewEmployeesList.SelectedRows.Count > 0)
            {
                // Get the selected employee's ID and name from the dataGridViewEmployeesList
                string id = dataGridViewEmployeesList.SelectedRows[0].Cells["ID"].Value.ToString();
                string name = dataGridViewEmployeesList.SelectedRows[0].Cells["FirstName"].Value.ToString() + " " + dataGridViewEmployeesList.SelectedRows[0].Cells["LastName"].Value.ToString();

                // Get the selected task from the comboBoxPerformTask
                string task = comboBoxPerformTask.SelectedItem?.ToString();

                // Determine the department of the selected employee
                string department = dataGridViewEmployeesList.SelectedRows[0].Cells["Department"].Value.ToString();

                // Set the available tasks based on the department
                List<string> tasks = new List<string>();
                if (department == "Sales")
                {
                    tasks.AddRange(new string[] { "Generate Sales Reports", "Follow up with Leads", "Attend Sales Meetings", "Negotiate Deals", "Build Customer Relationships" });
                }
                else if (department == "HR")
                {
                    tasks.AddRange(new string[] { "Manage Employee Onboarding", "Conduct Interviews", "Handle Employee Benefits", "Develop Training Programs", "Resolve Employee Conflicts" });
                }
                else if (department == "IT")
                {
                    tasks.AddRange(new string[] { "Troubleshoot Technical Issues", "Maintain Servers", "Develop Software", "Implement Security Measures", "Upgrade System Infrastructure" });
                }
                else if (department == "Marketing")
                {
                    tasks.AddRange(new string[] { "Develop Marketing Campaign", "Run Social Media Ads", "Analyze Market Trends", "Create Content Strategy", "Manage Marketing Budget" });
                }
                else if (department == "Finance")
                {
                    tasks.AddRange(new string[] { "Prepare Financial Statements", "Budget Planning", "Monitor Expenses", "Perform Financial Analysis", "Manage Cash Flow" });
                }
                // Add more conditions for other departments if needed

                // Set the task options in the ComboBox
                comboBoxPerformTask.Items.Clear();
                comboBoxPerformTask.Items.AddRange(tasks.ToArray());

                // Check if the task is selected and not null
                if (!string.IsNullOrEmpty(task))
                {
                    // Check if the task already exists in the employeeTasks list
                    bool taskExists = employeeTasks.Any(t => t.EmployeeName == name && t.PerformTask == task);

                    if (!taskExists)
                    {
                        // Create a new task object
                        EmployeeTask employeeTask = new EmployeeTask()
                        {
                            ID = Guid.NewGuid(),
                            EmployeeName = name,
                            PerformTask = task,
                        };

                        // Add the task to the list
                        employeeTasks.Add(employeeTask);

                        // Refresh the dataGridViewtask to show the updated task list for the selected employee
                       
                        dataGridViewtask.DataSource = employeeTasks.Where(t => t.EmployeeName == name).ToList();
                        // Add the task to the history list
                        employeeTasksHistory.Add(employeeTask);

                        // Refresh the dataGridViewHistory to show all employees with their tasks
                        dataGridViewHistory.DataSource = null;
                        dataGridViewHistory.DataSource = employeeTasksHistory;
                    }
                    else
                    {
                        MessageBox.Show("The task already exists for this employee.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a task.");
                }
            }
            else
            {
                MessageBox.Show("Please select an employee.");
            }
        }

        private string GetSelectedSalary()
        {
            if (comboBoxSalary.SelectedIndex >= 0)
            {
                return comboBoxSalary.SelectedItem.ToString();
            }
            return "";
        }

        private void comboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected department from the comboBoxDepartment
            string selectedDepartment = comboBoxDepartment.Text;

            // Clear the existing items in the comboBoxSalary
            comboBoxSalary.Items.Clear();

            // Check the selected department and populate the salary collection accordingly
            List<double> salaryCollection = new List<double>();

            if (selectedDepartment == "Sales")
            {
                salaryCollection.Add(1000.00);
                salaryCollection.Add(2000.00);
                salaryCollection.Add(5000.00);
            }
            else if (selectedDepartment == "HR")
            {
                salaryCollection.Add(1500.00);
                salaryCollection.Add(2500.00);
                salaryCollection.Add(4000.00);
            }
            else if (selectedDepartment == "IT")
            {
                salaryCollection.Add(1200.00);
                salaryCollection.Add(2200.00);
                salaryCollection.Add(3500.00);
            }
            else if (selectedDepartment == "Marketing")
            {
                salaryCollection.Add(1800.00);
                salaryCollection.Add(3000.00);
                salaryCollection.Add(4500.00);
            }
            else if (selectedDepartment == "Finance")
            {
                salaryCollection.Add(2000.00);
                salaryCollection.Add(3500.00);
                salaryCollection.Add(6000.00);
            }
            // Add more conditions for other departments if needed

            // Add the salary values to the comboBoxSalary
            foreach (double salary in salaryCollection)
            {
                comboBoxSalary.Items.Add(salary.ToString("0.00")); // Convert salary to string with 2 decimal places
            }
        }

        private void dataGridViewEmployeesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void DeleteSelectedRow(DataGridView dataGridView, List<Employee> dataSource)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                // Display a confirmation dialog
                DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    // Remove the row from the DataGridView
                    dataGridView.Rows.Remove(selectedRow);

                    // Get the selected employee object
                    Employee selectedEmployee = selectedRow.DataBoundItem as Employee;

                    // Remove the selected employee from the data source
                    dataSource.Remove(selectedEmployee);
                }
            }
        }


        private void DeleteSelectedRow(DataGridView dataGridView)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Get the selected row index
                int rowIndex = dataGridView.SelectedRows[0].Index;

                // Remove the row from the DataGridView
                dataGridView.Rows.RemoveAt(rowIndex);
            }
        }
        private void dataGridViewEmployeesList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                // Delete the selected row from dataGridViewEmployeesList
                DeleteSelectedRow(dataGridViewEmployeesList);
            }
        }

        private void dataGridViewtask_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                // Delete the selected row from dataGridViewtask
                DeleteSelectedRow(dataGridViewtask);
            }
        }

        private void dataGridViewEmployeesList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a row is clicked
            if (e.RowIndex >= 0)
            {
                // Get the selected employee's name from the cell value
                string name = dataGridViewEmployeesList.Rows[e.RowIndex].Cells["FirstName"].Value.ToString() + " " + dataGridViewEmployeesList.Rows[e.RowIndex].Cells["LastName"].Value.ToString();

                // Filter the employeeTasks list based on the selected employee's name
                List<EmployeeTask> selectedEmployeeTasks = employeeTasks.Where(t => t.EmployeeName == name).ToList();

                // Bind the filtered tasks to the dataGridViewtask
                dataGridViewtask.DataSource = selectedEmployeeTasks;
            }
        }
    }
}