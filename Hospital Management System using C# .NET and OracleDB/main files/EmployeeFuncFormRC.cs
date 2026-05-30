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
    public partial class EmployeeFuncFormRC : Form
    {
        public EmployeeFuncFormRC()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            this.Text = "Employee Functionality - Receptionist/Cashier";
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.LightGray; // Set background color

            // Dashboard Title
            Label lblDashboardTitle = new Label();
            lblDashboardTitle.Text = "Receptionist/Cashier Dashboard";
            lblDashboardTitle.Font = new Font(lblDashboardTitle.Font.FontFamily, 16, FontStyle.Bold);
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

            Button btnViewSalary = CreateSidebarButton("View Salary", 100);
            btnViewSalary.Click += BtnViewSalary_Click;
            sidebarPanel.Controls.Add(btnViewSalary);

            Button btnManageTasks = CreateSidebarButton("Manage Tasks", 150);
            btnManageTasks.Click += BtnManageTasks_Click;
            sidebarPanel.Controls.Add(btnManageTasks);

            Button btnCustomerSupport = CreateSidebarButton("Customer Support", 200);
            btnCustomerSupport.Click += BtnCustomerSupport_Click;
            sidebarPanel.Controls.Add(btnCustomerSupport);

            // Tables or lists for displaying tasks, salary details, feedback, etc.
            // Example: DataGridView or ListView controls

            // Forms for managing appointments, marking tasks complete, handling customer affairs, etc.
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

        private void BtnViewSalary_Click(object sender, EventArgs e)
        {
            // Open form or dialog for viewing salary
            MessageBox.Show("Open form for viewing salary");
        }

        private void BtnManageTasks_Click(object sender, EventArgs e)
        {
            // Open form or dialog for managing tasks
            MessageBox.Show("Open form for managing tasks");
        }

        private void BtnCustomerSupport_Click(object sender, EventArgs e)
        {
            // Open form or dialog for customer support
            MessageBox.Show("Open form for customer support");
        }

        private void EmployeeFuncFormRC_Load(object sender, EventArgs e)
        {

        }
    }
}
