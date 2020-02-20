using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace StallManagementSystem
{
    public partial class ReportsUserControl : UserControl
    {
        ReportDocument crypt = new ReportDocument();
        public static ReportsUserControl _instance;
        private string domainName = @"C:\Users\"+Environment.UserName+@"\Documents\Visual Studio 2015\Projects\StallManagementSystem\StallManagementSystem\";


        public static ReportsUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ReportsUserControl();
                }
                return _instance;
            }
        }

        public ReportsUserControl()
        {
            InitializeComponent();
        }

        private void lesseesListBtn_Click(object sender, EventArgs e)
        {
            try
            {
                lesseesClass l = new lesseesClass();
                l.getIsNotAmbulantLessees();
                crypt.Load(domainName+"LesseesListCrystalReport.rpt");
                crypt.SetDataSource(l.datasetQuery("lessees_tbl"));
                crypt.SetParameterValue("title", "List of Lessees");
                reportsCrystalReportViewer.ReportSource = crypt;
                reportsCrystalReportViewer.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ambulantListBtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                lesseesClass l = new lesseesClass();
                l.getIsAmbulantLessees();
                crypt.Load(domainName+"LesseesListCrystalReport.rpt");
                crypt.SetDataSource(l.datasetQuery("lessees_tbl"));
                crypt.SetParameterValue("title", "List of Ambulants");
                reportsCrystalReportViewer.ReportSource = crypt;
                reportsCrystalReportViewer.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void duePaymentsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                paymentsClass p = new paymentsClass();
                p.getLesseePaymentDetails();
                crypt.Load(domainName+"duePaymentsCrystalReport.rpt");
                crypt.SetDataSource(p.datasetQuery("stall_contract"));
                reportsCrystalReportViewer.ReportSource = crypt;
                reportsCrystalReportViewer.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void availableStallsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                stallClass u = new stallClass();
                u.getAvailableStalls();
                crypt.Load(domainName + "stallsCrystalReport.rpt");
                crypt.SetDataSource(u.datasetQuery("stalls_tbl"));
                crypt.SetParameterValue("stall_title", "List of Available stalls");
                reportsCrystalReportViewer.ReportSource = crypt;
                reportsCrystalReportViewer.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rentedStallsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                stallClass u = new stallClass();
                u.getRentedStalls();
                crypt.Load(domainName + "stallsCrystalReport.rpt");
                crypt.SetDataSource(u.datasetQuery("stalls_tbl"));
                crypt.SetParameterValue("stall_title", "List of Rented stalls");
                reportsCrystalReportViewer.ReportSource = crypt;
                reportsCrystalReportViewer.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void reservedStallsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                stallClass u = new stallClass();
                u.getReservedStalls();
                crypt.Load(domainName + "stallsCrystalReport.rpt");
                crypt.SetDataSource(u.datasetQuery("stalls_tbl"));
                crypt.SetParameterValue("stall_title", "List of Reserved stalls");
                reportsCrystalReportViewer.ReportSource = crypt;
                reportsCrystalReportViewer.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void monthlyReportBtn_Click(object sender, EventArgs e)
        {
            new LesseeMonthlyReportForm().ShowDialog();
        }

        private void monthlyReportBtn_Click_1(object sender, EventArgs e)
        {
            new LesseeMonthlyReportForm().ShowDialog();
        }

        private void ambulantMonthlyReportBtn_Click(object sender, EventArgs e)
        {
            new AmbulantMonthlyReportForm().ShowDialog();
        }
    }
}
