using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Employee_Management
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBoxusername.Text;
            string password = textBoxpassword.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            // Check the username and password against the expected values
            if (textBoxusername.Text == "admin" && textBoxpassword.Text == "admin123")
            {
                MessageBox.Show("Login successful!");
                // Close the login form and open Form1
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {


            if (checkBox2.Checked)
            {
                textBoxpassword.UseSystemPasswordChar = false;
            }

            else
            {
                textBoxpassword.UseSystemPasswordChar = true;
            }

        }

        private void textBoxpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
