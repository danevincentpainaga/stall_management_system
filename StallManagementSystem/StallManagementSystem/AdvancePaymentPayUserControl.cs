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
    public partial class AdvancePaymentPayUserControl : UserControl
    {
        public static AdvancePaymentPayUserControl _instance;
        public static DataRow _row;
        private contractsClass _cc;

        public static AdvancePaymentPayUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AdvancePaymentPayUserControl();
                }
                return _instance;
            }
        }

        public AdvancePaymentPayUserControl()
        {
            InitializeComponent();
        }

        private void AdvancePaymentPayUserControl_Load(object sender, EventArgs e)
        {
            stallNUmberTxtBox.Text = _row["stall_number"].ToString();
            stallAmountTxtBox.Text = _row["rate"].ToString();
            lesseeNameTxtBox.Text = _row["l_lastname"].ToString() + ", " + _row["l_firstname"].ToString() + " " + _row["l_middlename"].ToString();
            fromDateTxtBox.Text = _row["due_date"].ToString();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            totalAmountTxtbox.Clear();
            untilDateTxtBox.Clear();
            cashTxtBox.Clear();
            monthsTxtBox.Clear();
            changeTxtBox.Clear();

            if (!AdvancePaymentStallsUserControl.cpanel.Controls.Contains(AdvancePaymentStallsUserControl.Instance))
            {
                AdvancePaymentStallsUserControl.cpanel.Controls.Add(AdvancePaymentStallsUserControl.Instance);
                AdvancePaymentStallsUserControl.Instance.BringToFront();
            }
            else
                AdvancePaymentStallsUserControl.Instance.BringToFront();
        }

        public void reload(DataRow row)
        {
            _row = row;
            stallNUmberTxtBox.Text = row["stall_number"].ToString();
            lesseeNameTxtBox.Text = _row["l_lastname"].ToString() + ", " + _row["l_firstname"].ToString() + " " + _row["l_middlename"].ToString();
        }

        private void monthsTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(monthsTxtBox.Text))
            {
                totalAmountTxtbox.Text = Convert.ToString(Convert.ToInt32(stallAmountTxtBox.Text) * Convert.ToInt32(monthsTxtBox.Text));
                DateTime date = Convert.ToDateTime(fromDateTxtBox.Text);
                untilDateTxtBox.Text = date.AddMonths(Convert.ToInt32(monthsTxtBox.Text)).ToShortDateString();
                calculateChange();
            }
            else
            {
                totalAmountTxtbox.Clear();
            }
        }

        private void monthsTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            byte letter = (byte)e.KeyChar;
            bool isNumber = letter >= 48 && letter <= 57;
            bool isBackSpace = letter == 8;
            e.Handled = !(isNumber || isBackSpace);
        }

        private void cashTxtBox_TextChanged(object sender, EventArgs e)
        {
            calculateChange();
        }

        private void calculateChange()
        {
            int cashTendered = 0;
            bool isNumeric = int.TryParse(cashTxtBox.Text, out cashTendered);
            if (isNumeric == true)
            {
                changeTxtBox.Text = Convert.ToString(Convert.ToInt32(cashTxtBox.Text) - Convert.ToInt32(totalAmountTxtbox.Text));
            }
            else
            {
                changeTxtBox.Text = "0";
            }
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            paymentsClass pc = new paymentsClass();
            pc.advancePayment(totalAmountTxtbox.Text, _row["stall_contract_id"].ToString(), untilDateTxtBox.Text, fromDateTxtBox.Text, lesseeNameTxtBox.Text);
            totalAmountTxtbox.Clear();
            untilDateTxtBox.Clear();
            cashTxtBox.Clear();
            monthsTxtBox.Clear();
            changeTxtBox.Clear();
        }
    }
}
