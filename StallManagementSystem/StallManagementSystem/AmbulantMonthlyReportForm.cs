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
    public partial class AmbulantMonthlyReportForm : Form
    {
        ReportDocument crypt = new ReportDocument();
        private string domainName = @"C:\Users\" + Environment.UserName + @"\Documents\Visual Studio 2015\Projects\StallManagementSystem\StallManagementSystem\";

        public AmbulantMonthlyReportForm()
        {
            InitializeComponent();
        }

        private void monthtlyCbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void submitFilterBTn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(monthtlyCbx.SelectedItem.ToString()) && !string.IsNullOrEmpty(yearMaskedTxtBox.Text))
            {
                try
                {
                    reportClass r = new reportClass();
                    r.getAmbulantMonthlyReports(monthtlyCbx.SelectedItem.ToString(), yearMaskedTxtBox.Text);
                    crypt.Load(domainName + "AmbulantMonthlyCrystalReport.rpt");
                    crypt.SetDataSource(r.datasetQuery("ambulant_sales"));
                    monthlycrystalReportViewer.ReportSource = crypt;
                    monthlycrystalReportViewer.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
