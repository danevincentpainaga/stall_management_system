using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace StallManagementSystem
{
    public partial class RecieptForm : Form
    {
        //ReportDocument crypt = new ReportDocument();
        private string _lessee, _totalamount;

        public RecieptForm(string lessee, string amount)
        {
            InitializeComponent();
            _lessee = lessee;
            _totalamount = amount;
        }

        private void RecieptForm_Load(object sender, EventArgs e)
        {
            RecieptCrystalReport r = new RecieptCrystalReport();
            r.SetParameterValue("payor", _lessee);
            r.SetParameterValue("total_amount", _totalamount);
            recieptcrystalReportViewer.ReportSource = r;
        }
    }
}
