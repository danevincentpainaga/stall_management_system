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
    public partial class AdvancePaymentUserControl : UserControl
    {
        public static AdvancePaymentUserControl _instance;
        private paymentsClass _cc;

        public static AdvancePaymentUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AdvancePaymentUserControl();
                }
                return _instance;
            }
        }

        public AdvancePaymentUserControl()
        {
            InitializeComponent();
            _cc = new paymentsClass();
        }

        private void AdcancePaymentUserControl_Load(object sender, EventArgs e)
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
                _cc.getFullyPaidLessees();
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
            if (!contractDetailsHolderPanel.Controls.Contains(AdvancePaymentStallsUserControl.Instance))
            {
                AdvancePaymentStallsUserControl.cpanel = contractDetailsHolderPanel;
                AdvancePaymentStallsUserControl.lesseeId = row["lesseeId"].ToString();
                contractDetailsHolderPanel.Controls.Add(AdvancePaymentStallsUserControl.Instance);
                LessesStallNumbersUserControl.Instance.BringToFront();
            }
            else
                AdvancePaymentStallsUserControl.lesseeId = row["lesseeId"].ToString();
                AdvancePaymentStallsUserControl.Instance.clearPanelAndLoad();
                AdvancePaymentStallsUserControl.Instance.BringToFront();
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
                _cc.searchFullyPaidLessees(searchTxtBox.Text);
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
