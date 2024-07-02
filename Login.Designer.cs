namespace Employee_Management
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBoxusername = new TextBox();
            textBoxpassword = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            checkBox2 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(223, 44);
            label1.Name = "label1";
            label1.Size = new Size(78, 27);
            label1.TabIndex = 0;
            label1.Text = "Log In";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(147, 156);
            label2.Name = "label2";
            label2.Size = new Size(99, 19);
            label2.TabIndex = 3;
            label2.Text = "UserName:";
            // 
            // textBoxusername
            // 
            textBoxusername.BorderStyle = BorderStyle.None;
            textBoxusername.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxusername.ForeColor = SystemColors.WindowText;
            textBoxusername.Location = new Point(148, 189);
            textBoxusername.Name = "textBoxusername";
            textBoxusername.Size = new Size(240, 19);
            textBoxusername.TabIndex = 5;
            textBoxusername.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxpassword
            // 
            textBoxpassword.BorderStyle = BorderStyle.None;
            textBoxpassword.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxpassword.Location = new Point(148, 259);
            textBoxpassword.Name = "textBoxpassword";
            textBoxpassword.PasswordChar = '*';
            textBoxpassword.Size = new Size(240, 19);
            textBoxpassword.TabIndex = 6;
            textBoxpassword.TextAlign = HorizontalAlignment.Center;
            textBoxpassword.TextChanged += textBoxpassword_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(148, 228);
            label3.Name = "label3";
            label3.Size = new Size(92, 19);
            label3.TabIndex = 4;
            label3.Text = "Password:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.ForeColor = Color.Indigo;
            panel1.Location = new Point(148, 207);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 2);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Indigo;
            panel2.ForeColor = Color.Indigo;
            panel2.Location = new Point(148, 276);
            panel2.Name = "panel2";
            panel2.Size = new Size(240, 2);
            panel2.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.Indigo;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(171, 343);
            button1.Name = "button1";
            button1.Size = new Size(194, 54);
            button1.TabIndex = 10;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.FlatStyle = FlatStyle.Flat;
            checkBox2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox2.Location = new Point(261, 279);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(136, 22);
            checkBox2.TabIndex = 11;
            checkBox2.Text = "Show Password";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(550, 510);
            Controls.Add(checkBox2);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(textBoxpassword);
            Controls.Add(textBoxusername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxusername;
        private TextBox textBoxpassword;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private CheckBox checkBox2;
    }
}