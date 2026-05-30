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
    public partial class AdminFuncForm : Form
    {
        public AdminFuncForm()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            this.Text = "Admin Functionality";
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.LightGray; // Set background color

            // Dashboard Title
            Label lblDashboardTitle = new Label();
            lblDashboardTitle.Text = "Admin Dashboard";
            lblDashboardTitle.Font = new Font(lblDashboardTitle.Font.FontFamily, 14,FontStyle.Bold);
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
            Button btnManageEmployees = CreateSidebarButton("Manage Employees", 80);
            btnManageEmployees.Click += BtnManageEmployees_Click;
            sidebarPanel.Controls.Add(btnManageEmployees);

            Button btnManageAppointments = CreateSidebarButton("Manage Appointments", 130);
            btnManageAppointments.Click += BtnManageAppointments_Click;
            sidebarPanel.Controls.Add(btnManageAppointments);

            Button btnGenerateReports = CreateSidebarButton("Generate Reports", 180);
            btnGenerateReports.Click += BtnGenerateReports_Click;
            sidebarPanel.Controls.Add(btnGenerateReports);

            // Employee Details Table/List
            DataGridView dgvEmployeeDetails = new DataGridView();
            dgvEmployeeDetails.Size = new Size(500, 300);
            dgvEmployeeDetails.Location = new Point(250, 100);
            // Add columns and data to the DataGridView
            // Example: dgvEmployeeDetails.DataSource = yourDataSource;
            this.Controls.Add(dgvEmployeeDetails);

            // Additional modules, tables, or lists can be added similarly

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

        private void BtnManageEmployees_Click(object sender, EventArgs e)
        {
            // Handle Manage Employees functionality
            MessageBox.Show("Manage Employees clicked");
        }

        private void BtnManageAppointments_Click(object sender, EventArgs e)
        {
            // Handle Manage Appointments functionality
            MessageBox.Show("Manage Appointments clicked");
        }

        private void BtnGenerateReports_Click(object sender, EventArgs e)
        {
            // Handle Generate Reports functionality
            MessageBox.Show("Generate Reports clicked");
        }

        private void AdminFuncForm_Load(object sender, EventArgs e)
        {

        }
    }
}

