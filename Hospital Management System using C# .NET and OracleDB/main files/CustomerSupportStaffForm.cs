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
    public partial class CustomerSupportStaffForm : Form
    {
        public CustomerSupportStaffForm()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            this.Text = "Customer Support Staff Form";
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.LightGray; // Set background color

            // Dashboard Title
            Label lblDashboardTitle = new Label();
            lblDashboardTitle.Text = "Customer Support Staff Dashboard";
            lblDashboardTitle.Font = new Font(lblDashboardTitle.Font.FontFamily, 20, FontStyle.Bold);
            lblDashboardTitle.AutoSize = true;
            lblDashboardTitle.Location = new Point(300, 20);
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

            Button btnViewFeedback = CreateSidebarButton("View Feedback", 100);
            btnViewFeedback.Click += BtnViewFeedback_Click;
            sidebarPanel.Controls.Add(btnViewFeedback);

            Button btnResolveIssues = CreateSidebarButton("Resolve Issues", 150);
            btnResolveIssues.Click += BtnResolveIssues_Click;
            sidebarPanel.Controls.Add(btnResolveIssues);

            Button btnGenerateReports = CreateSidebarButton("Generate Reports", 200);
            btnGenerateReports.Click += BtnGenerateReports_Click;
            sidebarPanel.Controls.Add(btnGenerateReports);

            // Tables or lists for displaying customer feedback, issues, reports, etc.
            // Example: DataGridView or ListView controls

            // Forms for resolving customer issues, generating reports, etc.
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

        private void BtnViewFeedback_Click(object sender, EventArgs e)
        {
            // Open form or dialog for viewing feedback
            MessageBox.Show("Open form for viewing feedback");
        }

        private void BtnResolveIssues_Click(object sender, EventArgs e)
        {
            // Open form or dialog for resolving issues
            MessageBox.Show("Open form for resolving issues");
        }

        private void BtnGenerateReports_Click(object sender, EventArgs e)
        {
            // Open form or dialog for generating reports
            MessageBox.Show("Open form for generating reports");
        }

        private void CustomerSupportStaffForm_Load(object sender, EventArgs e)
        {

        }
    }
}
