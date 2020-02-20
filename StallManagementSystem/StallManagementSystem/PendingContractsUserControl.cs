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
    public partial class PendingContractsUserControl : UserControl
    {
        public static PendingContractsUserControl _instance;
        private contractsClass _cc;

        public static PendingContractsUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PendingContractsUserControl();
                }
                return _instance;
            }
        }

        public PendingContractsUserControl()
        {
            InitializeComponent();
            _cc = new contractsClass();
        }

        private void PendingContractsUserControl_Load(object sender, EventArgs e)
        {
            loadPendingCotracts();
        }

        public void loadPendingCotracts()
        {
            contractLesseesflowLayoutPanel.Controls.Clear();

            int sp = 3;
            int ep = 3;

            try
            {
                _cc.getPendingContracts();
                foreach (DataRow row in _cc.QueryExe().Rows)
                {
                    Button b = new Button();
                    b.Name = row["lessee_id"].ToString();
                    b.Text = row["l_lastname"].ToString() + ", " + row["l_firstname"].ToString();
                    b.Location = new Point(sp, ep);
                    b.Height = 41;
                    b.Width = 210;
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
            if (!contractDetailsHolderPanel.Controls.Contains(PendingLesseesStallContractsUserControl.Instance))
            {
                PendingLesseesStallContractsUserControl.cpanel = contractDetailsHolderPanel;
                PendingLesseesStallContractsUserControl.lesseeId = row["lesseeId"].ToString();
                contractDetailsHolderPanel.Controls.Add(PendingLesseesStallContractsUserControl.Instance);
                PendingLesseesStallContractsUserControl.Instance.BringToFront();
            }
            else
                PendingLesseesStallContractsUserControl.lesseeId = row["lesseeId"].ToString();
                PendingLesseesStallContractsUserControl.Instance.clearPanelAndLoad();
                PendingLesseesStallContractsUserControl.Instance.BringToFront();
        }

        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {
            contractLesseesflowLayoutPanel.Controls.Clear();

            int sp = 3;
            int ep = 3;

            try
            {
                _cc.searchPendingContracts(searchTxtBox.Text);
                foreach (DataRow row in _cc.QueryExe().Rows)
                {
                    Button b = new Button();
                    b.Name = row["lessee_id"].ToString();
                    b.Text = row["l_firstname"].ToString();
                    b.Location = new Point(sp, ep);
                    b.Height = 41;
                    b.Width = 210;
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
