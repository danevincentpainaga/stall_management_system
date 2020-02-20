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
    public partial class PendingContractDetailsUserControl : UserControl
    {
        public static PendingContractDetailsUserControl _instance;
        public static DataRow _row;
        private contractsClass _cc;
        private string stall_contract_id;

        public static PendingContractDetailsUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PendingContractDetailsUserControl();
                }
                return _instance;
            }
        }

        public PendingContractDetailsUserControl()
        {
            InitializeComponent();
            _cc = new contractsClass();
        }

        private void PendingContractDetailsUserControl_Load(object sender, EventArgs e)
        {
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

        private void closeBtn_Click(object sender, EventArgs e)
        {
            if (!PendingLesseesStallContractsUserControl.cpanel.Controls.Contains(PendingLesseesStallContractsUserControl.Instance))
            {
                PendingLesseesStallContractsUserControl.cpanel.Controls.Add(PendingLesseesStallContractsUserControl.Instance);
                PendingLesseesStallContractsUserControl.Instance.BringToFront();
            }
            else
                PendingLesseesStallContractsUserControl.Instance.BringToFront();
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

        private void closeBtn_Click_1(object sender, EventArgs e)
        {
            if (!PendingLesseesStallContractsUserControl.cpanel.Controls.Contains(PendingLesseesStallContractsUserControl.Instance))
            {
                PendingLesseesStallContractsUserControl.cpanel.Controls.Add(PendingLesseesStallContractsUserControl.Instance);
                PendingLesseesStallContractsUserControl.Instance.BringToFront();
            }
            else
                PendingLesseesStallContractsUserControl.Instance.BringToFront();
        }

        private void approveContractBtn_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Approve Contract?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (msg == DialogResult.Yes)
            {
                _cc.approvedContracts(stall_contract_id, _row["stall_id"].ToString());
                PendingLesseesStallContractsUserControl.cpanel.Controls.Clear();
                PendingContractsUserControl.Instance.loadPendingCotracts();
                ActiveContractsUserControl.Instance.loadActiveContracts();
            }
        }

        private void declineBtn_Click(object sender, EventArgs e)
        {
           var msg = MessageBox.Show("Decline Contract?","", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (msg == DialogResult.Yes)
            {
                _cc.declineContracts(stall_contract_id);
                PendingLesseesStallContractsUserControl.Instance.clearPanelAndLoad();
                PendingContractsUserControl.Instance.loadPendingCotracts();
                PendingLesseesStallContractsUserControl.cpanel.Controls.Clear();
            }
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
