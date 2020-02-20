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
    public partial class ApplicationUserControl : UserControl
    {
        public static ApplicationUserControl _instance;

        public static ApplicationUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ApplicationUserControl();
                }
                return _instance;
            }
        }

        public ApplicationUserControl()
        {
            InitializeComponent();
        }

        private void ApplicationUserControl_Load(object sender, EventArgs e)
        {
            applicationHolderPanel.Controls.Add(ApplicationMonthlyUserControl.Instance);
        }
    }
}
