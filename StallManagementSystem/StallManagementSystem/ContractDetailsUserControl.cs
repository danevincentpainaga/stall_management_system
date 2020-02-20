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
    public partial class ContractDetailsUserControl : UserControl
    {
        public static ContractDetailsUserControl _instance;
        public static DataRow _row;
        private contractsClass _cc;
        private string stall_contract_id;

        public static ContractDetailsUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ContractDetailsUserControl();
                }
                return _instance;
            }
        }

        public ContractDetailsUserControl()
        {
            InitializeComponent();
            _cc = new contractsClass();
        }

        private void ContractDetailsUserControl_Load(object sender, EventArgs e)
        {
            stall_contract_id = _row["stall_contract_id"].ToString();
            stallNUmberTxtBox.Text = _row["stall_number"].ToString();
            rateTxtBox.Text = _row["rate"].ToString();
            sizeBfeetTxtBox.Text = _row["stall_floor_blength"].ToString();
            sizeAfeetTxtBox.Text = _row["stall_floor_alength"].ToString();
            lesseeTxtBox.Text = _row["l_lastname"].ToString()+" "+_row["l_firstname"].ToString();
            startDateTxtBox.Text = _row["start_date"].ToString();
            endDateTxtBox.Text = _row["due_date"].ToString();
            totalContractAmountTxtBox.Text = _row["total_contract"].ToString();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            if (!LessesStallNumbersUserControl.cpanel.Controls.Contains(LessesStallNumbersUserControl.Instance))
            {
                LessesStallNumbersUserControl.cpanel.Controls.Add(LessesStallNumbersUserControl.Instance);
                LessesStallNumbersUserControl.Instance.BringToFront();
            }
            else
                LessesStallNumbersUserControl.Instance.BringToFront();
        }

        public void reload(DataRow row)
        {
            _row = row;
            stall_contract_id = _row["stall_contract_id"].ToString();
            stallNUmberTxtBox.Text = _row["stall_number"].ToString();
            rateTxtBox.Text = _row["rate"].ToString();
            sizeBfeetTxtBox.Text = _row["stall_floor_blength"].ToString();
            sizeAfeetTxtBox.Text = _row["stall_floor_alength"].ToString();
            lesseeTxtBox.Text = _row["l_lastname"].ToString() + " " + _row["l_firstname"].ToString();
            startDateTxtBox.Text = _row["start_date"].ToString();
            endDateTxtBox.Text = _row["due_date"].ToString();
            totalContractAmountTxtBox.Text = _row["total_contract"].ToString();
        }

        private void terminateBtn_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Terminate Contract?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (msg == DialogResult.Yes)
            {
                _cc.terminateContracts(stall_contract_id, _row["stall_id"].ToString());
                LessesStallNumbersUserControl.cpanel.Controls.Clear();
                ActiveContractsUserControl.Instance.loadActiveContracts();
            }
        }

        private void printContractBtn_Click(object sender, EventArgs e)
        {
            new ContractForm(_row).ShowDialog();
        }

        private void viewBusinessBtn_Click(object sender, EventArgs e)
        {
            new ClearanceViewerForm(_row["business_permit"].ToString()).ShowDialog();
        }

        private void viewFireClearanceBtn_Click(object sender, EventArgs e)
        {
            new ClearanceViewerForm(_row["fire_clearance"].ToString()).ShowDialog();
        }

        private void viewPoliceClearanceBtn_Click(object sender, EventArgs e)
        {
            new ClearanceViewerForm(_row["police_clearance"].ToString()).ShowDialog();
        }

        private void viewNbiClearanceBtn_Click(object sender, EventArgs e)
        {
            new ClearanceViewerForm(_row["nbi_clearance"].ToString()).ShowDialog();
        }
    }
}
