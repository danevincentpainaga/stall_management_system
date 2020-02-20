using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StallManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            loginClass lc = new loginClass();
            int valid = lc.validate(usernameTxtBox.Text, passwordTxtBox.Text);
            if (usernameTxtBox.Text == "" && passwordTxtBox.Text == "")
            {

                MessageBox.Show("Please enter username and password!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTxtBox.Focus();
                return;
            }
            if (usernameTxtBox.Text == "")
            {
                MessageBox.Show("Please enter username!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTxtBox.Focus();
                return;
            }
            if (passwordTxtBox.Text == "")
            {
                MessageBox.Show("Please enter password!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordTxtBox.Focus();
                return;
            }

            if (valid == 1)
            {
                MainForm main = new MainForm(this);
                main.Show();
            }
            else
            {
                MessageBox.Show("Username/Password Incorrect!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTxtBox.Focus();
            }
        }

        private void closepictureBox_Click(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }
    }
}
