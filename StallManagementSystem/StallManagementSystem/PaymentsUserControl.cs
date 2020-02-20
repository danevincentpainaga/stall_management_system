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
    public partial class PaymentsUserControl : UserControl
    {
        public static PaymentsUserControl _instance;
        private paymentsClass _cc;

        public static PaymentsUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PaymentsUserControl();
                }
                return _instance;
            }
        }

        public PaymentsUserControl()
        {
            InitializeComponent();
            _cc = new paymentsClass();
        }

        private void PaymentsUserControl_Load(object sender, EventArgs e)
        {
            displayLessees();
        }

        private void displayLessees()
        {
            contractLesseesflowLayoutPanel.Controls.Clear();
            int sp = 3;
            int ep = 3;

            try
            {
                _cc.getLesseePaymentDetails();
                foreach (DataRow row in _cc.QueryExe().Rows)
                {
                    Button b = new Button();
                    b.Name = row["lessee_id"].ToString();
                    b.Text = row["l_lastname"].ToString() + " ," + row["l_firstname"].ToString();
                    b.Location = new Point(sp, ep);
                    b.Height = 41;
                    b.Width = 204;
                    b.FlatStyle = FlatStyle.Popup;
                    b.BackColor = SystemColors.Control;
                    contractLesseesflowLayoutPanel.Controls.Add(b);
                    ep += 10;
                    b.Click += delegate (object sender, EventArgs evt) { btn_Click(sender, evt, row); };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void btn_Click(object sender, EventArgs e, DataRow row)
        {
            if (!contractDetailsHolderPanel.Controls.Contains(lesseesRentedStallsUserControl.Instance))
            {
                lesseesRentedStallsUserControl.cpanel = contractDetailsHolderPanel;
                lesseesRentedStallsUserControl.lesseeId = row["lesseeId"].ToString();
                lesseesRentedStallsUserControl.lessee = row["l_lastname"].ToString()+", "+row["l_firstname"].ToString()+" "+ row["l_middlename"].ToString();
                contractDetailsHolderPanel.Controls.Add(lesseesRentedStallsUserControl.Instance);
                LessesStallNumbersUserControl.Instance.BringToFront();
            }
            else
                lesseesRentedStallsUserControl.lesseeId = row["lesseeId"].ToString();
                lesseesRentedStallsUserControl.lessee = row["l_lastname"].ToString() + ", " + row["l_firstname"].ToString() + " " + row["l_middlename"].ToString();
                lesseesRentedStallsUserControl.Instance.clearPanelAndLoad();
                lesseesRentedStallsUserControl.Instance.BringToFront();
        }

        private void refreshpictureBox_Click(object sender, EventArgs e)
        {
            displayLessees();
        }

        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {
            contractLesseesflowLayoutPanel.Controls.Clear();
            int sp = 3;
            int ep = 3;

            try
            {
                _cc.searchLesseePaymentDetails(searchTxtBox.Text);
                foreach (DataRow row in _cc.QueryExe().Rows)
                {
                    Button b = new Button();
                    b.Name = row["lessee_id"].ToString();
                    b.Text = row["l_firstname"].ToString();
                    b.Location = new Point(sp, ep);
                    b.Height = 41;
                    b.Width = 204;
                    b.FlatStyle = FlatStyle.Popup;
                    b.BackColor = SystemColors.Control;
                    contractLesseesflowLayoutPanel.Controls.Add(b);
                    ep += 10;
                    b.Click += delegate (object s, EventArgs evt) { btn_Click(s, evt, row); };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
