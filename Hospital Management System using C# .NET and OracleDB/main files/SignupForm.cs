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
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            this.Text = "Signup - Patient";
            this.Size = new Size(400, 300);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.LightBlue; // Set background color

            // Labels
            Label lblTitle = new Label();
            lblTitle.Text = "Patient Signup";
            lblTitle.Font = new Font(lblTitle.Font.FontFamily, 16, FontStyle.Bold);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point((this.Width - lblTitle.Width) / 2, 20);
            this.Controls.Add(lblTitle);

            Label lblName = new Label();
            lblName.Text = "Name:";
            lblName.AutoSize = true;
            lblName.Location = new Point(50, 70);
            this.Controls.Add(lblName);

            Label lblEmail = new Label();
            lblEmail.Text = "Email:";
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(50, 100);
            this.Controls.Add(lblEmail);

            Label lblPassword = new Label();
            lblPassword.Text = "Password:";
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(50, 130);
            this.Controls.Add(lblPassword);

            Label lblPhone = new Label();
            lblPhone.Text = "Phone Number:";
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(50, 160);
            this.Controls.Add(lblPhone);

            Label lblIdProof = new Label();
            lblIdProof.Text = "ID Proof:";
            lblIdProof.AutoSize = true;
            lblIdProof.Location = new Point(50, 190);
            this.Controls.Add(lblIdProof);

            // Textboxes
            TextBox txtName = new TextBox();
            txtName.Size = new Size(200, 20);
            txtName.Location = new Point(150, 70);
            this.Controls.Add(txtName);

            TextBox txtEmail = new TextBox();
            txtEmail.Size = new Size(200, 20);
            txtEmail.Location = new Point(150, 100);
            this.Controls.Add(txtEmail);

            TextBox txtPassword = new TextBox();
            txtPassword.Size = new Size(200, 20);
            txtPassword.Location = new Point(150, 130);
            txtPassword.PasswordChar = '*';
            this.Controls.Add(txtPassword);

            TextBox txtPhone = new TextBox();
            txtPhone.Size = new Size(200, 20);
            txtPhone.Location = new Point(150, 160);
            this.Controls.Add(txtPhone);

            TextBox txtIdProof = new TextBox();
            txtIdProof.Size = new Size(200, 20);
            txtIdProof.Location = new Point(150, 190);
            this.Controls.Add(txtIdProof);

            // Registration Button
            Button btnRegister = new Button();
            btnRegister.Text = "Register";
            btnRegister.Size = new Size(100, 30);
            btnRegister.Location = new Point((this.Width - btnRegister.Width) / 2, 230);
            btnRegister.BackColor = Color.Green;
            btnRegister.ForeColor = Color.White;
            this.Controls.Add(btnRegister);

            // Event handler for registration button
            btnRegister.Click += BtnRegister_Click;
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            // Add your registration logic here
            MessageBox.Show("Registration Successful!");
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {

        }
    }
}

