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
    public partial class PendingLesseesStallContractsUserControl : UserControl
    {
        public static PendingLesseesStallContractsUserControl _instance;
        private contractsClass _cc;
        public static string lesseeId;
        public static Panel cpanel;

        public static PendingLesseesStallContractsUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PendingLesseesStallContractsUserControl();
                }
                return _instance;
            }
        }


        public PendingLesseesStallContractsUserControl()
        {
            InitializeComponent();
            _cc = new contractsClass();
        }

        private void PendingLesseesStallContractsUserControl_Load(object sender, EventArgs e)
        {
            clearPanelAndLoad();
        }

        public void clearPanelAndLoad()
        {
            stallNumberflowLayoutPanel.Controls.Clear();
            int sp = 11;
            int ep = 17;
            try
            {
                _cc.getPendingLesseeRentedStalls(lesseeId);
                foreach (DataRow row in _cc.QueryExe().Rows)
                {
                    Button b = new Button();
                    b.Name = row["stallId"].ToString();
                    b.Text = row["stall_number"].ToString();
                    b.Location = new Point(sp, ep);
                    b.Height = 50;
                    b.Width = 90;
                    stallNumberflowLayoutPanel.Controls.Add(b);
                    ep += 10;
                    b.Click += delegate (object s, EventArgs evt) { btn_Click(s, evt, row); };
                }
                _cc.closeConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void btn_Click(object sender, EventArgs e, DataRow row)
        {
            if (!cpanel.Controls.Contains(PendingContractDetailsUserControl.Instance))
            {
                PendingContractDetailsUserControl._row = row;
                cpanel.Controls.Add(PendingContractDetailsUserControl.Instance);
                PendingContractDetailsUserControl.Instance.BringToFront();
            }
            else
                PendingContractDetailsUserControl.Instance.reload(row);
                PendingContractDetailsUserControl.Instance.BringToFront();
        }
    }
}
