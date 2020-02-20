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
    public partial class billingUserControl : UserControl
    {
        public static billingUserControl _instance;
        private billingClass _bc;

        public static billingUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new billingUserControl();
                }
                return _instance;
            }
        }

        public billingUserControl()
        {
            InitializeComponent();
            _bc = new billingClass();
        }

        private void billingUserControl_Load(object sender, EventArgs e)
        {
            _bc.getHasRemainingBalanceLessees();
            billingdataGridView.DataSource = _bc.QueryExe();
        }
    }
}
