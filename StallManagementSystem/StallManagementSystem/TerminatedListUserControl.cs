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
    public partial class TerminatedListUserControl : UserControl
    {
        public static TerminatedListUserControl _instance;
        private contractsClass _cc;
        private static string search_status;

        public static TerminatedListUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TerminatedListUserControl();
                }
                return _instance;
            }
        }

        public TerminatedListUserControl()
        {
            InitializeComponent();
            _cc = new contractsClass();
        }

        private void TerminatedListUserControl_Load(object sender, EventArgs e)
        {
            displayTermidatedContracts();
        }

        private void refreshpictureBox_Click(object sender, EventArgs e)
        {
            displayTermidatedContracts();
        }

        private void displayTermidatedContracts()
        {
            _cc.terminatedContracts();
            terminatedListDataGridView.DataSource = _cc.QueryExe();
            terminatedListDataGridView.Columns[0].Width = 250;
            terminatedListDataGridView.Columns[1].Width = 250;
            terminatedListDataGridView.Columns[2].Width = 250;
            terminatedListDataGridView.Columns[4].Width = 200;
            terminatedListDataGridView.Columns[9].Width = 200;
        }

        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {
            search_status = searchTxtBox.Text;
            try
            {
                _cc.searchTerminatedContracts(search_status);
                terminatedListDataGridView.DataSource = _cc.QueryExe();
                terminatedListDataGridView.Columns[0].Width = 250;
                terminatedListDataGridView.Columns[1].Width = 250;
                terminatedListDataGridView.Columns[2].Width = 250;
                terminatedListDataGridView.Columns[4].Width = 200;
                terminatedListDataGridView.Columns[9].Width = 200;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
