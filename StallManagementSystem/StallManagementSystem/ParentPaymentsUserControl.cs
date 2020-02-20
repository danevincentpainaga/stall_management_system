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
    public partial class ParentPaymentsUserControl : UserControl
    {
        public static ParentPaymentsUserControl _instance;
        private paymentsClass _cc;

        public static ParentPaymentsUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ParentPaymentsUserControl();
                }
                return _instance;
            }
        }


        public ParentPaymentsUserControl()
        {
            InitializeComponent();
        }

        private void duePaymentBtn_Click(object sender, EventArgs e)
        {
            if (!paymentPanelHolder.Controls.Contains(PaymentsUserControl.Instance))
            {
                paymentPanelHolder.Controls.Add(PaymentsUserControl.Instance);
                PaymentsUserControl.Instance.BringToFront();
            }
            else
                PaymentsUserControl.Instance.BringToFront();
        }

        private void advancePaymentBtn_Click(object sender, EventArgs e)
        {
            if (!paymentPanelHolder.Controls.Contains(AdvancePaymentUserControl.Instance))
            {
                paymentPanelHolder.Controls.Add(AdvancePaymentUserControl.Instance);
                AdvancePaymentUserControl.Instance.BringToFront();
            }
            else
                AdvancePaymentUserControl.Instance.BringToFront();
        }

        private void ambulantBtn_Click(object sender, EventArgs e)
        {
            if (!paymentPanelHolder.Controls.Contains(AmbulantUserControl.Instance))
            {
                paymentPanelHolder.Controls.Add(AmbulantUserControl.Instance);
                AmbulantUserControl.Instance.BringToFront();
            }
            else
                AmbulantUserControl.Instance.BringToFront();
        }
    }
}
