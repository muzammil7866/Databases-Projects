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
    public partial class AdminManageAppointmentsForm : Form
    {
        public AdminManageAppointmentsForm()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            this.Text = "Admin - Manage Appointments";
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.LightGray; // Set background color

            // Dashboard Title
            Label lblDashboardTitle = new Label();
            lblDashboardTitle.Text = "Manage Appointments Dashboard";
            lblDashboardTitle.Font = new Font(lblDashboardTitle.Font.FontFamily, 20, FontStyle.Bold);
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
            Button btnAddAppointment = CreateSidebarButton("Add Appointment", 50);
            btnAddAppointment.Click += BtnAddAppointment_Click;
            sidebarPanel.Controls.Add(btnAddAppointment);

            Button btnUpdateAppointment = CreateSidebarButton("Update Appointment", 100);
            btnUpdateAppointment.Click += BtnUpdateAppointment_Click;
            sidebarPanel.Controls.Add(btnUpdateAppointment);

            Button btnCancelAppointment = CreateSidebarButton("Cancel Appointment", 150);
            btnCancelAppointment.Click += BtnCancelAppointment_Click;
            sidebarPanel.Controls.Add(btnCancelAppointment);

            // Tables or lists for displaying appointment details
            // Example: DataGridView or ListView controls

            // Forms for adding, updating, cancelling appointments
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

        private void BtnAddAppointment_Click(object sender, EventArgs e)
        {
            // Open form or dialog for adding appointment
            MessageBox.Show("Open form for adding appointment");
        }

        private void BtnUpdateAppointment_Click(object sender, EventArgs e)
        {
            // Open form or dialog for updating appointment
            MessageBox.Show("Open form for updating appointment");
        }

        private void BtnCancelAppointment_Click(object sender, EventArgs e)
        {
            // Open form or dialog for cancelling appointment
            MessageBox.Show("Open form for cancelling appointment");
        }

        private void AdminManageAppointmentsForm_Load(object sender, EventArgs e)
        {

        }
    }
}

