using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace StallManagementSystem
{
    public partial class MainForm : Form
    {
        public static bool _logout = false;

        public MainForm(LoginForm login)
        {
            try
            {
                Thread splash = new Thread(new ThreadStart(startSplashForm));
                splash.IsBackground = true;
                splash.Start();
                login.Hide();
                Thread.Sleep(2000);
                InitializeComponent();
                splash.Abort();
            }
            catch (ThreadAbortException ex)
            {
                Thread.ResetAbort();
            }
        }

        public void startSplashForm()
        {
            Application.Run(new SplashForm());
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ManagementUserControl mc = new ManagementUserControl();
            userControlPanelHolder.Controls.Add(mc);
            new dueDateClass();

            billingBtn.Hide();
        }

        private void contractsBtn_Click(object sender, EventArgs e)
        {
            if (loginClass.user_type != "admin")
            {
                MessageBox.Show("Module Restricted", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!userControlPanelHolder.Controls.Contains(ContractUserControl.Instance))
                {
                    userControlPanelHolder.Controls.Add(ContractUserControl.Instance);
                    ContractUserControl.Instance.BringToFront();
                }
                else
                    ContractUserControl.Instance.BringToFront();
            }

        }

        private void managementBtn_Click(object sender, EventArgs e)
        {
            if (!userControlPanelHolder.Controls.Contains(ManagementUserControl.Instance))
            {
                userControlPanelHolder.Controls.Add(ManagementUserControl.Instance);
                ManagementUserControl.Instance.BringToFront();
            }
            else
                ManagementUserControl.Instance.BringToFront();
        }

        private void applicationBtn_Click(object sender, EventArgs e)
        {
            if (!userControlPanelHolder.Controls.Contains(ApplicationUserControl.Instance))
            {
                userControlPanelHolder.Controls.Add(ApplicationUserControl.Instance);
                ApplicationUserControl.Instance.BringToFront();
            }
            else
                ApplicationUserControl.Instance.BringToFront();
        }

        private void paymentsBtn_Click(object sender, EventArgs e)
        {
            if (!userControlPanelHolder.Controls.Contains(ParentPaymentsUserControl.Instance))
            {
                userControlPanelHolder.Controls.Add(ParentPaymentsUserControl.Instance);
                ParentPaymentsUserControl.Instance.BringToFront();
            }
            else
                ParentPaymentsUserControl.Instance.BringToFront();
        }

        private void billingBtn_Click(object sender, EventArgs e)
        {
            if (!userControlPanelHolder.Controls.Contains(billingUserControl.Instance))
            {
                userControlPanelHolder.Controls.Add(billingUserControl.Instance);
                billingUserControl.Instance.BringToFront();
            }
            else
                billingUserControl.Instance.BringToFront();
        }

        private void reportsBtn_Click(object sender, EventArgs e)
        {
            if (!userControlPanelHolder.Controls.Contains(ReportsUserControl.Instance))
            {
                userControlPanelHolder.Controls.Add(ReportsUserControl.Instance);
                ReportsUserControl.Instance.BringToFront();
            }
            else
                ReportsUserControl.Instance.BringToFront();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Logout User?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                new LoginForm().Show();
                _logout = true;
            }
        }
    }
}
