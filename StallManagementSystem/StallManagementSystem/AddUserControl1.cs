using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StallManagementSystem
{
    public partial class AddUserControl1 : UserControl
    {
        public static AddUserControl1 _instance;

        public static AddUserControl1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AddUserControl1();
                }
                return _instance;
            }
        }

        private void AddUserControl1_Load(object sender, EventArgs e)
        {
            usertypecomboBox.Items.Add("admin");
            usertypecomboBox.Items.Add("user");
            statuscomboBox.Items.Add("Activated");
            statuscomboBox.Items.Add("De-Activated");
        }

        public AddUserControl1()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void statuscomboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void usertypecomboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (
                !String.IsNullOrEmpty( usernametextBox.Text) &&
                !String.IsNullOrEmpty(passwordtextBox.Text) &&
                !String.IsNullOrEmpty(firstnametextBox.Text) &&
                !String.IsNullOrEmpty(middlenametextBox.Text) &&
                !String.IsNullOrEmpty(lastnametextBox.Text) &&
                !String.IsNullOrEmpty(usertypecomboBox.Text) &&
                !String.IsNullOrEmpty(statuscomboBox.Text)
            )
            { 
                new addUserClass().addUsers(
                                                usernametextBox.Text,
                                                passwordtextBox.Text,
                                                firstnametextBox.Text,
                                                middlenametextBox.Text,
                                                lastnametextBox.Text,
                                                usertypecomboBox.Text,
                                                statuscomboBox.Text
                                            );
            }
        }
    }
}
