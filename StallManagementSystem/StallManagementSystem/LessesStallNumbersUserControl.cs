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
    public partial class LessesStallNumbersUserControl : UserControl
    {
        public static LessesStallNumbersUserControl _instance;
        private contractsClass _cc;
        public static string lesseeId;
        public static Panel cpanel;


        //public delegate void dataLoggedEventHandler();
        //public event dataLoggedEventHandler messageLogged;

        public static LessesStallNumbersUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LessesStallNumbersUserControl();
                }
                return _instance;
            }
        }

        public LessesStallNumbersUserControl()
        {
            InitializeComponent();
            _cc = new contractsClass();
        }

        private void LessesStallNumbersUserControl_Load(object sender, EventArgs e)
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
                _cc.getLesseeRentedStalls(lesseeId);
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
            if (!cpanel.Controls.Contains(ContractDetailsUserControl.Instance))
            {
                ContractDetailsUserControl._row = row;
                cpanel.Controls.Add(ContractDetailsUserControl.Instance);
                ContractDetailsUserControl.Instance.BringToFront();
            }
            else
                ContractDetailsUserControl.Instance.reload(row);
                ContractDetailsUserControl.Instance.BringToFront();
        }




        //public void onMessageLogged()
        //{
        //    if (messageLogged != null)
        //    {
        //        ContractDetailsUserControl.Instance.reload();
        //    }
        //}
    }
}
