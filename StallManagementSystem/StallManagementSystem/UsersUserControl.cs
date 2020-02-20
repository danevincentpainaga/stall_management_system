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
    public partial class UsersUserControl : UserControl
    {
        public static UsersUserControl _instance;
        private usersClass _uc;
        AddUserControl1 auc;
        UserInfoUserControl _ui;
        private static DataGridViewRow _row;

        public static UsersUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UsersUserControl();
                }
                return _instance;
            }
        }

        public UsersUserControl()
        {
            InitializeComponent();
            _uc = new usersClass();
        }

        private void UsersUserControl_Load(object sender, EventArgs e)
        {
            displayUsers();
        }

        public void displayUsers()
        {
            usersflowLayoutPanel.Controls.Clear();

            int sp = 3;
            int ep = 3;

            _uc.getUsers();
            foreach (DataRow row in _uc.QueryExe().Rows)
            {
                Button b = new Button();
                b.Name = row["user_id"].ToString();
                b.Text = row["lastname"].ToString() + ", " + row["firstname"].ToString();
                b.Location = new Point(sp, ep);
                b.Height = 41;
                b.Width = 220;
                b.FlatStyle = FlatStyle.Popup;
                b.BackColor = SystemColors.Control;
                b.TextAlign = ContentAlignment.MiddleCenter;
                usersflowLayoutPanel.Controls.Add(b);
                ep += 10;
                b.Click += delegate (object sender, EventArgs evt) { btn_Click(sender, evt, row); };
            }
        }

        private void formatDataGrid(DataGridView datagrid, bool value)
        {
            for (int i = 0; i < datagrid.Columns.Count; i++)
            {
                datagrid.Columns[i].MinimumWidth = 200;
            }
            datagrid.AllowUserToAddRows = value;
            datagrid.DefaultCellStyle.SelectionBackColor = Color.Lavender;
            datagrid.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        void btn_Click(object sender, EventArgs e, DataRow _row)
        {
            if (!user_panel.Controls.Contains(UserInfoUserControl.Instance))
            {
                UserInfoUserControl._row = _row;
                user_panel.Controls.Add(UserInfoUserControl.Instance);
                UserInfoUserControl.Instance.BringToFront();
            }
            else
                UserInfoUserControl.Instance.reload(_row);
                UserInfoUserControl.Instance.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!user_panel.Controls.Contains(AddUserControl1.Instance))
            {
                user_panel.Controls.Add(AddUserControl1.Instance);
                AddUserControl1.Instance.BringToFront();
            }
            else
                AddUserControl1.Instance.BringToFront();
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            auc.SendToBack();
        }

        private void refreshpictureBox_Click(object sender, EventArgs e)
        {
            displayUsers();
        }

        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {
            usersflowLayoutPanel.Controls.Clear();

            int sp = 3;
            int ep = 3;

            _uc.searchUsers(searchTxtBox.Text);
            foreach (DataRow row in _uc.QueryExe().Rows)
            {
                Button b = new Button();
                b.Name = row["user_id"].ToString();
                b.Text = row["lastname"].ToString() + ", " + row["firstname"].ToString();
                b.Location = new Point(sp, ep);
                b.Height = 41;
                b.Width = 220;
                b.FlatStyle = FlatStyle.Popup;
                b.BackColor = SystemColors.Control;
                b.TextAlign = ContentAlignment.MiddleCenter;
                usersflowLayoutPanel.Controls.Add(b);
                ep += 10;
                b.Click += delegate (object s, EventArgs evt) { btn_Click(s, evt, row); };
            }
        }
    }
}
