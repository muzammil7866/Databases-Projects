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
    public partial class AdminGenerateReportsForm : Form
    {
        public AdminGenerateReportsForm()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            this.Text = "Admin - Generate Reports";
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.LightGray; // Set background color

            // Dashboard Title
            Label lblDashboardTitle = new Label();
            lblDashboardTitle.Text = "Generate Reports Dashboard";
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
            Button btnGenerateDailyReport = CreateSidebarButton("Generate Daily Report", 50);
            btnGenerateDailyReport.Click += BtnGenerateDailyReport_Click;
            sidebarPanel.Controls.Add(btnGenerateDailyReport);

            Button btnGenerateWeeklyReport = CreateSidebarButton("Generate Weekly Report", 100);
            btnGenerateWeeklyReport.Click += BtnGenerateWeeklyReport_Click;
            sidebarPanel.Controls.Add(btnGenerateWeeklyReport);

            Button btnGenerateMonthlyReport = CreateSidebarButton("Generate Monthly Report", 150);
            btnGenerateMonthlyReport.Click += BtnGenerateMonthlyReport_Click;
            sidebarPanel.Controls.Add(btnGenerateMonthlyReport);

            // Forms for generating reports
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

        private void BtnGenerateDailyReport_Click(object sender, EventArgs e)
        {
            // Open form or dialog for generating daily report
            MessageBox.Show("Open form for generating daily report");
        }

        private void BtnGenerateWeeklyReport_Click(object sender, EventArgs e)
        {
            // Open form or dialog for generating weekly report
            MessageBox.Show("Open form for generating weekly report");
        }

        private void BtnGenerateMonthlyReport_Click(object sender, EventArgs e)
        {
            // Open form or dialog for generating monthly report
            MessageBox.Show("Open form for generating monthly report");
        }

        private void AdminGenerateReportsForm_Load(object sender, EventArgs e)
        {

        }
    }
}

