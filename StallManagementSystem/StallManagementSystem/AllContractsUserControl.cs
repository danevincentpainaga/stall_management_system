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
    public partial class AllContractsUserControl : UserControl
    {
        public static AllContractsUserControl _instance;
        private contractsClass _cc;
        private stallClass _sc;
        private static string _status;

        public static AllContractsUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AllContractsUserControl();
                }
                return _instance;
            }
        }

        public AllContractsUserControl()
        {
            InitializeComponent();
            _cc = new contractsClass();
            _sc = new stallClass();
        }

        private void AllContractsUserControl_Load(object sender, EventArgs e)
        {
            displayStalls();
            displayContracts(_status);
        }

        private void displayContracts(string status)
        {
            stallNumberCbx.SelectedIndex = -1;
            _status = status;
            _cc.getContracts(_status);
            contractListDataGridView.DataSource = _cc.QueryExe();
            contractListDataGridView.Columns[0].Width = 150;
            contractListDataGridView.Columns[1].Width = 150;
            contractListDataGridView.Columns[2].Width = 250;
            contractListDataGridView.Columns[3].Width = 250;
            contractListDataGridView.Columns[4].Width = 200;
            contractListDataGridView.Columns[9].Width = 200;
            contractListDataGridView.Columns[10].Width = 250;
        }

        private void displayStalls()
        {
            _sc.getStalls();
            stallNumberCbx.DataSource = _sc.QueryExe();
            stallNumberCbx.ValueMember = "stall_id";
            stallNumberCbx.DisplayMember = "stall_number";
            stallNumberCbx.SelectedIndex = -1;
        }

        private void statusCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayContracts(statusCbx.Text);
        }

        private void statusCbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void stallNumberCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (stallNumberCbx.SelectedIndex != -1)
            {
                _cc.getContractsByStallNumber(_status, stallNumberCbx.SelectedValue.ToString());
                contractListDataGridView.DataSource = _cc.QueryExe();
                contractListDataGridView.Columns[0].Width = 150;
                contractListDataGridView.Columns[1].Width = 150;
                contractListDataGridView.Columns[2].Width = 250;
                contractListDataGridView.Columns[3].Width = 250;
                contractListDataGridView.Columns[4].Width = 200;
                contractListDataGridView.Columns[9].Width = 200;
            }
        }

        private void stallNumberCbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
