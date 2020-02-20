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
    public partial class ClearanceViewerForm : Form
    {
        private string _image;
        private string domainName = @"C:\Users\" + Environment.UserName + @"\Documents\Visual Studio 2015\Projects\StallManagementSystem\StallManagementSystem\images\";

        public ClearanceViewerForm(string img)
        {
            InitializeComponent();
            _image = img;
        }

        private void ClearanceViewerForm_Load(object sender, EventArgs e)
        {
            ViewClearanceCrystalReport c = new ViewClearanceCrystalReport();
            c.SetParameterValue("imageUrl", domainName + _image);
            ClearanceCrystalReportViewer.ReportSource = c;
        }
    }
}
