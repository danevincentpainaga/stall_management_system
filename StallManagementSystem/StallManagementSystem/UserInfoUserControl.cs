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
    public partial class UserInfoUserControl : UserControl
    {
        public static UserInfoUserControl _instance;
        public static DataRow _row;
        private string _userid;

        public static UserInfoUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserInfoUserControl();
                }
                return _instance;
            }
        }

        public UserInfoUserControl()
        {
            InitializeComponent();
        }

        private void UserInfoUserControl_Load(object sender, EventArgs e)
        {
            usertypecomboBox.Items.Add("admin");
            usertypecomboBox.Items.Add("user");
            statuscomboBox.Items.Add("Activated");
            statuscomboBox.Items.Add("De-Activated");


            _userid = _row["user_id"].ToString();
            firstnametextBox.Text = _row["firstname"].ToString();
            lastnametextBox.Text = _row["lastname"].ToString();
            middlenametextBox.Text = _row["middlename"].ToString();
            usernametextBox.Text = _row["username"].ToString();
            passwordtextBox.Text = _row["password"].ToString();
            usertypecomboBox.SelectedIndex = usertypecomboBox.FindStringExact(_row["usertype"].ToString());
            statuscomboBox.SelectedIndex = statuscomboBox.FindStringExact(_row["status"].ToString());
        }

        public void reload(DataRow row)
        {
            _row = row;
            _userid = _row["user_id"].ToString();
            firstnametextBox.Text = _row["firstname"].ToString();
            lastnametextBox.Text = _row["lastname"].ToString();
            middlenametextBox.Text = _row["middlename"].ToString();
            usernametextBox.Text = _row["username"].ToString();
            passwordtextBox.Text = _row["password"].ToString();
            usertypecomboBox.SelectedIndex = usertypecomboBox.FindStringExact(_row["usertype"].ToString());
            statuscomboBox.SelectedIndex = statuscomboBox.FindStringExact(_row["status"].ToString());
        }

        private void statuscomboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void usertypecomboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            new usersClass().updateUsers(
                                usernametextBox.Text,
                                passwordtextBox.Text,
                                firstnametextBox.Text,
                                middlenametextBox.Text,
                                lastnametextBox.Text,
                                usertypecomboBox.Text,
                                statuscomboBox.Text,
                                _userid
                            );
        }
    }
}
