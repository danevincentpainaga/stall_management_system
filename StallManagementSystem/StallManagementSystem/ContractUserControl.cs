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
    public partial class ContractUserControl : UserControl
    {
        public static ContractUserControl _instance;

        public static ContractUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ContractUserControl();
                }
                return _instance;
            }
        }

        public ContractUserControl()
        {
            InitializeComponent();
        }

        private void activeContractBtn_Click(object sender, EventArgs e)
        {
            if (!contractsStatusHolderPanel.Controls.Contains(ActiveContractsUserControl.Instance))
            {
                contractsStatusHolderPanel.Controls.Add(ActiveContractsUserControl.Instance);
                ActiveContractsUserControl.Instance.BringToFront();
            }
            else
                ActiveContractsUserControl.Instance.BringToFront();
        }

        private void approvalsBtn_Click(object sender, EventArgs e)
        {
            if (!contractsStatusHolderPanel.Controls.Contains(PendingContractsUserControl.Instance))
            {
                contractsStatusHolderPanel.Controls.Add(PendingContractsUserControl.Instance);
                PendingContractsUserControl.Instance.BringToFront();
            }
            else
                PendingContractsUserControl.Instance.BringToFront();
        }

        private void terminatedBtn_Click(object sender, EventArgs e)
        {
            if (!contractsStatusHolderPanel.Controls.Contains(TerminatedListUserControl.Instance))
            {
                contractsStatusHolderPanel.Controls.Add(TerminatedListUserControl.Instance);
                TerminatedListUserControl.Instance.BringToFront();
            }
            else
                TerminatedListUserControl.Instance.BringToFront();
        }

        private void allContractsBtn_Click(object sender, EventArgs e)
        {
            if (!contractsStatusHolderPanel.Controls.Contains(AllContractsUserControl.Instance))
            {
                contractsStatusHolderPanel.Controls.Add(AllContractsUserControl.Instance);
                AllContractsUserControl.Instance.BringToFront();
            }
            else
                AllContractsUserControl.Instance.BringToFront();
        }
    }
}
