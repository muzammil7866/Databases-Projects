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
    public partial class AdminManageEmployeeForm : Form
    {
        public AdminManageEmployeeForm()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            this.Text = "Admin - Manage Employees";
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.LightGray; // Set background color

            // Dashboard Title
            Label lblDashboardTitle = new Label();
            lblDashboardTitle.Text = "Manage Employees Dashboard";
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
            Button btnAddEmployee = CreateSidebarButton("Add Employee", 50);
            btnAddEmployee.Click += BtnAddEmployee_Click;
            sidebarPanel.Controls.Add(btnAddEmployee);

            Button btnRemoveEmployee = CreateSidebarButton("Remove Employee", 100);
            btnRemoveEmployee.Click += BtnRemoveEmployee_Click;
            sidebarPanel.Controls.Add(btnRemoveEmployee);

            Button btnUpdateEmployee = CreateSidebarButton("Update Employee", 150);
            btnUpdateEmployee.Click += BtnUpdateEmployee_Click;
            sidebarPanel.Controls.Add(btnUpdateEmployee);

            // Tables or lists for displaying employee details
            // Example: DataGridView or ListView controls

            // Forms for adding, removing, updating employees
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

        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            // Open form or dialog for adding employee
            MessageBox.Show("Open form for adding employee");
        }

        private void BtnRemoveEmployee_Click(object sender, EventArgs e)
        {
            // Open form or dialog for removing employee
            MessageBox.Show("Open form for removing employee");
        }

        private void BtnUpdateEmployee_Click(object sender, EventArgs e)
        {
            // Open form or dialog for updating employee
            MessageBox.Show("Open form for updating employee");
        }

        private void AdminManageEmployeeForm_Load(object sender, EventArgs e)
        {

        }
    }
}

