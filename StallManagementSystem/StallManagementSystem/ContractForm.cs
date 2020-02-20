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
using System.Globalization;

namespace StallManagementSystem
{
    public partial class ContractForm : Form
    {
        private DataRow _row;
        public ContractForm(DataRow row)
        {
            InitializeComponent();
            _row = row;
        }

        private void ContractForm_Load(object sender, EventArgs e)
        {
            string contractDate = DateTime.Now.ToString("dd", CultureInfo.InvariantCulture) + " of " + DateTime.Now.ToString("MMMM", CultureInfo.InvariantCulture) + ",  " + DateTime.Now.ToString("yyyy", CultureInfo.InvariantCulture);

            ContractCrystalReport c = new ContractCrystalReport();
            c.SetParameterValue("firstParagraph", "DARELL B. DELA FLOR");
            c.SetParameterValue("lessor", _row["l_firstname"].ToString().ToUpper() + " " + _row["l_middlename"].ToString().ToUpper()+ " "+ _row["l_lastname"].ToString().ToUpper());
            c.SetParameterValue("lessorName", _row["l_firstname"].ToString().ToUpper() + " " + _row["l_middlename"].ToString().ToUpper() + " " + _row["l_lastname"].ToString().ToUpper() + " ");
            c.SetParameterValue("mayorName", "DARELL B. DELA FLOR");
            c.SetParameterValue("stallsize", _row["stall_floor_alength"].ToString()+" feet, by "+ _row["stall_floor_blength"].ToString()+" feet");
            c.SetParameterValue("startdate_enddate", _row["start_date"].ToString()+ " and renewable upon expiry on   "+ _row["due_date"].ToString()+";");
            c.SetParameterValue("stallrate", "One Thousand Two Hundred Pesos(P1,200.00)");
            c.SetParameterValue("contractDate", contractDate);
            c.SetParameterValue("footer", "<b>"+ _row["l_firstname"].ToString().ToUpper() + " " + _row["l_middlename"].ToString().ToUpper() + " " + _row["l_lastname"].ToString().ToUpper() + "</b>, and <b>DARELL B. DELA FLOR</b>");
            ContractCrystalReportViewer.ReportSource = c;
        }
    }
}
