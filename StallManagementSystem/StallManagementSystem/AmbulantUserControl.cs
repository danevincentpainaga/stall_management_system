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
    public partial class AmbulantUserControl : UserControl
    {
        public static AmbulantUserControl _instance;
        private ambulantClass _a;
        private string lesseeId;

        public static AmbulantUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AmbulantUserControl();
                }
                return _instance;
            }
        }


        public AmbulantUserControl()
        {
            InitializeComponent();
            _a = new ambulantClass();
        }

        private void AmbulantUserControl_Load(object sender, EventArgs e)
        {
            displayAmbulants();
            displayAmbulatSales();
        }

        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _a.searchAmbulants(searchTxtBox.Text);
                ambulantdataGridView.DataSource = _a.QueryExe();
                ambulantdataGridView.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ambulantdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = ambulantdataGridView.Rows[e.RowIndex];
                    lesseeId = row.Cells["lessee_id"].Value.ToString();
                    lastnameTxtBox.Text = row.Cells["l_lastname"].Value.ToString();
                    firstnameTxtBox.Text = row.Cells["l_firstname"].Value.ToString();
                    middlenameTxtBox.Text = row.Cells["l_middlename"].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lesseeId))
            {
                new paymentsClass().payAmbulantTickets(lesseeId, amountTxtBox.Text);
                displayAmbulatSales();
                lastnameTxtBox.Clear();
                firstnameTxtBox.Clear();
                middlenameTxtBox.Clear();
                amountTxtBox.Clear();
            }
        }

        private void displayAmbulants()
        {
            try
            {
                _a.searchAmbulants(searchTxtBox.Text);
                ambulantdataGridView.DataSource = _a.QueryExe();
                ambulantdataGridView.Columns[0].Visible = false;
                ambulantdataGridView.Columns[1].Width = 200;
                ambulantdataGridView.Columns[2].Width = 200;
                ambulantdataGridView.Columns[3].Width = 200;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void displayAmbulatSales()
        {
            try
            {
                _a.getAmbulantSales();
                ambulantSalesDataGridView.DataSource = _a.QueryExe();
                ambulantSalesDataGridView.Columns[0].Visible = false;
                ambulantSalesDataGridView.Columns[0].Width = 200;
                ambulantSalesDataGridView.Columns[1].Width = 200;
                ambulantSalesDataGridView.Columns[2].Width = 200;
                ambulantSalesDataGridView.Columns[3].Width = 200;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void amountTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            byte letter = (byte)e.KeyChar;
            bool isNumber = letter >= 48 && letter <= 57;
            bool isBackSpace = letter == 8;
            e.Handled = !(isNumber || isBackSpace);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            lastnameTxtBox.Clear();
            firstnameTxtBox.Clear();
            middlenameTxtBox.Clear();
            amountTxtBox.Clear();
        }

        private void searchAmbulantPayments_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _a.searchAmbulantPayments(searchAmbulantPayments.Text);
                ambulantSalesDataGridView.DataSource = _a.QueryExe();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refreshpictureBox_Click(object sender, EventArgs e)
        {
            displayAmbulants();
        }
    }
}
