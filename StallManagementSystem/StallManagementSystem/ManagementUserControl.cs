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
    public partial class ManagementUserControl : UserControl
    {

        public static ManagementUserControl _instance;

        public static ManagementUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ManagementUserControl();
                }
                return _instance;
            }
        }


        public ManagementUserControl()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ManagementUserControl_Load(object sender, EventArgs e)
        {
            if (loginClass.user_type != "admin")
            {
                userBtn.Hide();
                stallsBtn.Hide();
            }
        }

        private void lesseesBtn_Click(object sender, EventArgs e)
        {
            if (!panelManagementHolder.Controls.Contains(LesseesUserControl.Instance))
            {
                panelManagementHolder.Controls.Add(LesseesUserControl.Instance);
                LesseesUserControl.Instance.BringToFront();
            }
            else
                LesseesUserControl.Instance.BringToFront();
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            if (!panelManagementHolder.Controls.Contains(UsersUserControl.Instance))
            {
                panelManagementHolder.Controls.Add(UsersUserControl.Instance);
                UsersUserControl.Instance.BringToFront();
            }
            else
                UsersUserControl.Instance.BringToFront();
        }

        private void stallsBtn_Click(object sender, EventArgs e)
        {
            if (!panelManagementHolder.Controls.Contains(StallsUserControl.Instance))
            {
                panelManagementHolder.Controls.Add(StallsUserControl.Instance);
                StallsUserControl.Instance.BringToFront();
            }
            else
                StallsUserControl.Instance.BringToFront();
        }
    }
}
