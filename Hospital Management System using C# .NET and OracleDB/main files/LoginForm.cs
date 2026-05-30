using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            this.Text = "Hospital Management System - Login";
            this.Size = new Size(400, 250);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.LightBlue; // Set background color

            // Adjusting font size for all labels and buttons
            Font largeFont = new Font(Font.FontFamily, 14, FontStyle.Bold);

            Label lblTitle = new Label();
            lblTitle.Text = "Login Form";
            lblTitle.Font = largeFont;
            lblTitle.AutoSize = true; // Adjusting label size to fit text
            lblTitle.Location = new Point((this.Width - lblTitle.Width) / 2, 20);
            this.Controls.Add(lblTitle);

            Label lblUsername = new Label();
            lblUsername.Text = "Username:";
            lblUsername.Font = largeFont;
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point((this.Width - lblUsername.Width) / 2 - 100, 70); // Centering label
            this.Controls.Add(lblUsername);

            TextBox txtUsername = new TextBox();
            txtUsername.Size = new Size(200, 20);
            txtUsername.Location = new Point((this.Width - txtUsername.Width) / 2 + 100, 70); // Centering textbox
            this.Controls.Add(txtUsername);

            Label lblPassword = new Label();
            lblPassword.Text = "Password:";
            lblPassword.Font = largeFont;
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point((this.Width - lblPassword.Width) / 2 - 100, 100);
            this.Controls.Add(lblPassword);

            TextBox txtPassword = new TextBox();
            txtPassword.Size = new Size(200, 20);
            txtPassword.Location = new Point((this.Width - txtPassword.Width) / 2 + 100, 100);
            txtPassword.PasswordChar = '*'; // Mask password characters
            this.Controls.Add(txtPassword);

            Button btnPatientLogin = new Button();
            btnPatientLogin.Text = "Patient Login";
            btnPatientLogin.Font = largeFont;
            btnPatientLogin.AutoSize = true; // Adjusting button size to fit text
            btnPatientLogin.Location = new Point((this.Width - btnPatientLogin.Width) / 2 - 150, 150); // Centering button
            btnPatientLogin.BackColor = Color.Green; // Set button color
            btnPatientLogin.ForeColor = Color.White; // Set text color
            this.Controls.Add(btnPatientLogin);

            Button btnAdminLogin = new Button();
            btnAdminLogin.Text = "Admin Login";
            btnAdminLogin.Font = largeFont;
            btnAdminLogin.AutoSize = true;
            btnAdminLogin.Location = new Point((this.Width - btnAdminLogin.Width) / 2, 150);
            btnAdminLogin.BackColor = Color.Blue; // Set button color
            btnAdminLogin.ForeColor = Color.White; // Set text color
            this.Controls.Add(btnAdminLogin);

            Button btnEmployeeLogin = new Button();
            btnEmployeeLogin.Text = "Employee Login";
            btnEmployeeLogin.Font = largeFont;
            btnEmployeeLogin.AutoSize = true;
            btnEmployeeLogin.Location = new Point((this.Width - btnEmployeeLogin.Width) / 2 + 150, 150);
            btnEmployeeLogin.BackColor = Color.Orange; // Set button color
            btnEmployeeLogin.ForeColor = Color.White; // Set text color
            this.Controls.Add(btnEmployeeLogin);

            // Event handlers for login buttons
            btnPatientLogin.Click += BtnPatientLogin_Click;
            btnAdminLogin.Click += BtnAdminLogin_Click;
            btnEmployeeLogin.Click += BtnEmployeeLogin_Click;
        }


        private void BtnPatientLogin_Click(object sender, EventArgs e)
        {
            // Handle patient login
            MessageBox.Show("Patient Login clicked");
        }

        private void BtnAdminLogin_Click(object sender, EventArgs e)
        {
            // Handle admin login
            MessageBox.Show("Admin Login clicked");
        }

        private void BtnEmployeeLogin_Click(object sender, EventArgs e)
        {
            // Handle employee login
            MessageBox.Show("Employee Login clicked");
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }


}
