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
    public partial class PatientFuncForm: Form
    {
        public PatientFuncForm()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            this.Text = "Patient Functionality";
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.LightGray; // Set background color

            // Dashboard Title
            Label lblDashboardTitle = new Label();
            lblDashboardTitle.Text = "Patient Dashboard";
            lblDashboardTitle.Font = new Font(lblDashboardTitle.Font.FontFamily, 13, FontStyle.Bold);
            lblDashboardTitle.AutoSize = true;
            lblDashboardTitle.Location = new Point(20, 20);
            this.Controls.Add(lblDashboardTitle);

            // Navigation Menu/Sidebar
            Panel sidebarPanel = new Panel();
            sidebarPanel.BackColor = Color.DarkGray;
            sidebarPanel.Size = new Size(200, this.Height);
            sidebarPanel.Location = new Point(0, 0);
            this.Controls.Add(sidebarPanel);

            // Modules
            Button btnBookAppointment = CreateSidebarButton("Book Appointment", 50);
            btnBookAppointment.Click += BtnBookAppointment_Click;
            sidebarPanel.Controls.Add(btnBookAppointment);

            Button btnPreviousAppointments = CreateSidebarButton("Previous Appointments", 100);
            btnPreviousAppointments.Click += BtnPreviousAppointments_Click;
            sidebarPanel.Controls.Add(btnPreviousAppointments);

            Button btnCustomerSupport = CreateSidebarButton("Customer Support", 150);
            btnCustomerSupport.Click += BtnCustomerSupport_Click;
            sidebarPanel.Controls.Add(btnCustomerSupport);

            Button btnProfileManagement = CreateSidebarButton("Profile Management", 200);
            btnProfileManagement.Click += BtnProfileManagement_Click;
            sidebarPanel.Controls.Add(btnProfileManagement);

            // Feedback section for customer support
            Label lblFeedbackTitle = new Label();
            lblFeedbackTitle.Text = "Feedback Section";
            lblFeedbackTitle.Font = new Font(lblFeedbackTitle.Font.FontFamily, 16, FontStyle.Bold);
            lblFeedbackTitle.AutoSize = true;
            lblFeedbackTitle.Location = new Point(250, 50);
            this.Controls.Add(lblFeedbackTitle);

            TextBox txtFeedback = new TextBox();
            txtFeedback.Multiline = true;
            txtFeedback.Size = new Size(500, 200);
            txtFeedback.Location = new Point(250, 100);
            this.Controls.Add(txtFeedback);

            Button btnSubmitFeedback = new Button();
            btnSubmitFeedback.Text = "Submit Feedback";
            btnSubmitFeedback.Size = new Size(150, 30);
            btnSubmitFeedback.Location = new Point(500, 320);
            btnSubmitFeedback.BackColor = Color.Green;
            btnSubmitFeedback.ForeColor = Color.White;
            btnSubmitFeedback.Click += BtnSubmitFeedback_Click;
            this.Controls.Add(btnSubmitFeedback);
        }

        private Button CreateSidebarButton(string text, int top)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.Size = new Size(180, 30);
            btn.Location = new Point(10, top);
            btn.BackColor = Color.Gray;
            btn.ForeColor = Color.White;
            return btn;
        }

        private void BtnBookAppointment_Click(object sender, EventArgs e)
        {
            // Open form or dialog for booking appointment
            MessageBox.Show("Open form for booking appointment");
        }

        private void BtnPreviousAppointments_Click(object sender, EventArgs e)
        {
            // Open form or dialog for viewing previous appointments
            MessageBox.Show("Open form for viewing previous appointments");
        }

        private void BtnCustomerSupport_Click(object sender, EventArgs e)
        {
            // Open form or dialog for customer support
            MessageBox.Show("Open form for customer support");
        }

        private void BtnProfileManagement_Click(object sender, EventArgs e)
        {
            // Open form or dialog for profile management
            MessageBox.Show("Open form for profile management");
        }

        private void BtnSubmitFeedback_Click(object sender, EventArgs e)
        {
            // Submit feedback logic
            MessageBox.Show("Feedback submitted successfully!");
        }

        private void PatientFuncForm_Load(object sender, EventArgs e)
        {

        }
    }
}
