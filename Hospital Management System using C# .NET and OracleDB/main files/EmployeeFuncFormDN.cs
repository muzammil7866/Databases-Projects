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
    public partial class EmployeeFuncFormDN : Form
    {
        public EmployeeFuncFormDN()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            this.Text = "Employee Functionality - Medical Staff (Doctor/Nurse)";
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.LightGray; // Set background color

            // Dashboard Title
            Label lblDashboardTitle = new Label();
            lblDashboardTitle.Text = "Medical Staff Dashboard";
            lblDashboardTitle.Font = new Font(lblDashboardTitle.Font.FontFamily, 20, FontStyle.Bold);
            lblDashboardTitle.AutoSize = true;
            lblDashboardTitle.Location = new Point(400, 20);
            this.Controls.Add(lblDashboardTitle);

            // Navigation Menu/Sidebar
            Panel sidebarPanel = new Panel();
            sidebarPanel.BackColor = Color.DarkGray;
            sidebarPanel.Size = new Size(200, this.Height);
            sidebarPanel.Location = new Point(0, 0);
            this.Controls.Add(sidebarPanel);

            // Modules
            Button btnCheckProfile = CreateSidebarButton("Check Profile", 50);
            btnCheckProfile.Click += BtnCheckProfile_Click;
            sidebarPanel.Controls.Add(btnCheckProfile);

            Button btnViewPatientRecords = CreateSidebarButton("View Patient Records", 100);
            btnViewPatientRecords.Click += BtnViewPatientRecords_Click;
            sidebarPanel.Controls.Add(btnViewPatientRecords);

            Button btnManageAppointments = CreateSidebarButton("Manage Appointments", 150);
            btnManageAppointments.Click += BtnManageAppointments_Click;
            sidebarPanel.Controls.Add(btnManageAppointments);

            Button btnGeneratePrescriptions = CreateSidebarButton("Generate Prescriptions", 200);
            btnGeneratePrescriptions.Click += BtnGeneratePrescriptions_Click;
            sidebarPanel.Controls.Add(btnGeneratePrescriptions);

            // Forms for generating prescriptions, updating medical records, managing appointments, etc.
            // Example: Dialog forms or user controls
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

        private void BtnCheckProfile_Click(object sender, EventArgs e)
        {
            // Open form or dialog for checking profile
            MessageBox.Show("Open form for checking profile");
        }

        private void BtnViewPatientRecords_Click(object sender, EventArgs e)
        {
            // Open form or dialog for viewing patient records
            MessageBox.Show("Open form for viewing patient records");
        }

        private void BtnManageAppointments_Click(object sender, EventArgs e)
        {
            // Open form or dialog for managing appointments
            MessageBox.Show("Open form for managing appointments");
        }

        private void BtnGeneratePrescriptions_Click(object sender, EventArgs e)
        {
            // Open form or dialog for generating prescriptions
            MessageBox.Show("Open form for generating prescriptions");
        }

        private void EmployeeFuncFormDN_Load(object sender, EventArgs e)
        {

        }
    }
}

