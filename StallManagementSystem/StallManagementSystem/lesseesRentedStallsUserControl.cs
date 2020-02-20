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
    public partial class lesseesRentedStallsUserControl : UserControl
    {
        public static lesseesRentedStallsUserControl _instance;
        private paymentsClass _pc;
        public static string lesseeId;
        public static string lessee;
        public static Panel cpanel;
        static int numofpayments = 0;
        static int total = 0;
        static string contract_id;
        List<string> dates = new List<string>();

        public static lesseesRentedStallsUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new lesseesRentedStallsUserControl();
                }
                return _instance;
            }
        }

        public lesseesRentedStallsUserControl()
        {
            InitializeComponent();
            _pc = new paymentsClass();
        }

        private void lesseesRentedStallsUserControl_Load(object sender, EventArgs e)
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
                _pc.getLesseeNotFullPaymentRentedStalls(lesseeId);
                foreach (DataRow row in _pc.QueryExe().Rows)
                {
                    Button b = new Button();
                    b.Name = row["stallId"].ToString();
                    b.Text = row["stall_number"].ToString();
                    b.Location = new Point(sp, ep);
                    b.Height = 40;
                    b.Width = 155;
                    b.FlatStyle = FlatStyle.Popup;
                    b.BackColor = SystemColors.Control;
                    stallNumberflowLayoutPanel.Controls.Add(b);
                    ep += 10;
                    b.Click += delegate (object sender, EventArgs evt) { btn_Click(sender, evt, row); };
                }
                _pc.closeConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void btn_Click(object sender, EventArgs e, DataRow row)
        {
            contract_id = row["stall_contract_id"].ToString();
            displayUnpaidPayments(row["stall_contract_id"].ToString());
        }

        private void displayUnpaidPayments(string stallContractId)
        {
            numberOfPaymentsComboBox.Items.Clear();
            int totalAmount = 0;
            numofpayments = 0;
            _pc.getLesseeUnpaidPayments(stallContractId);
            paymentsListDataGridView.DataSource = _pc.QueryExe();
            _pc.closeConn();

            paymentsListDataGridView.Columns["stall_contractId"].Visible = false;
            paymentsListDataGridView.Columns["billings_id"].Visible = false;

            paymentsListDataGridView.Columns[2].Width = 150;
            paymentsListDataGridView.Columns[3].Width = 150;
            paymentsListDataGridView.Columns[4].Width = 150;
            paymentsListDataGridView.Columns[5].Width = 150;
            paymentsListDataGridView.Columns[6].Width = 150;
            paymentsListDataGridView.Columns[7].Width = 150;
            paymentsListDataGridView.Columns[8].Width = 150;

            foreach (DataRow dr in _pc.QueryExe().Rows)
            {
                numofpayments += 1;
                numberOfPaymentsComboBox.Items.Add(numofpayments.ToString());
                totalAmount += Convert.ToInt32(dr["total_amount"]) + Convert.ToInt32(dr["interest"]);
            }

            totalAmountTextBox.Text = totalAmount.ToString();
        }

        private void numberOfPaymentsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            total = 0;
            dates.Clear();
            int rc = Convert.ToInt32(numberOfPaymentsComboBox.SelectedItem);
            for (int i = 0; i < rc; i++)
            {
                DataGridViewRow row = paymentsListDataGridView.Rows[i];
                dates.Add(row.Cells["until_date"].Value.ToString());
                total += Convert.ToInt32(row.Cells["total_amount"].Value) + Convert.ToInt32(row.Cells["interest"].Value);
            }
            amountTextBox.Text = total.ToString();
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            _pc.payMonthlyBills(dates, contract_id, amountTextBox.Text, lessee);
            displayUnpaidPayments(contract_id);
            clearPanelAndLoad();
            amountTextBox.Clear();
        }

        private void cashTenderedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(amountTextBox.Text))
            {
                int cashTendered = 0;
                bool isNumeric = int.TryParse(cashTenderedTextBox.Text, out cashTendered);
                if (isNumeric == true)
                {
                    changeTxtBox.Text = Convert.ToString(Convert.ToInt32(cashTenderedTextBox.Text) - Convert.ToInt32(amountTextBox.Text));
                }
                else
                {
                    changeTxtBox.Text = "0";
                }
            }
        }
    }
}
