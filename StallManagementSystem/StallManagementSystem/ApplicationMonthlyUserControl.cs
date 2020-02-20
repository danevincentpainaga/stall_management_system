using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace StallManagementSystem
{
    public partial class ApplicationMonthlyUserControl : UserControl
    {
        public static ApplicationMonthlyUserControl _instance;
        private stallClass _sc;
        private string filelocation = @"C:\Users\DanePC\Documents\Visual Studio 2015\Projects\StallManagementSystem\StallManagementSystem\images";
        private string _businessfilename, _firefilename, _policefilename, _nbifilename;
        private string _stallId, _lesseeId;
        private static int num;

        public static ApplicationMonthlyUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ApplicationMonthlyUserControl();
                }
                return _instance;
            }
        }

        public ApplicationMonthlyUserControl()
        {
            InitializeComponent();
            _sc = new stallClass();
        }

        private void ApplicationMonthlyUserControl_Load(object sender, EventArgs e)
        {
            numberOfMonthsTxtBox.Text = "0";
            totalContractAmountTxtBox.Text = "0";
            displayStalls();
        }

        public void displayStalls()
        {
            stallsListflowLayoutPanel.Controls.Clear();

            int sp = 11;
            int ep = 17;

            try
            {
                _sc.getAvailableStalls();
                foreach (DataRow row in _sc.QueryExe().Rows)
                {
                    Button b = new Button();
                    b.Name = row["stall_id"].ToString();
                    b.Text = row["stall_number"].ToString();
                    b.Location = new Point(sp, ep);
                    b.Height = 40;
                    b.Width = 155;
                    b.FlatStyle = FlatStyle.Popup;
                    b.BackColor = SystemColors.Control;
                    stallsListflowLayoutPanel.Controls.Add(b);
                    ep += 10;
                    b.Click += delegate (object sender, EventArgs evt) { stallsbtn_Click(sender, evt, row); };
                }
                _sc.closeConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void numberOfMonthsTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            byte letter = (byte)e.KeyChar;
            bool isNumber = letter >= 48 && letter <= 57;
            bool isBackSpace = letter == 8;
            e.Handled = !(isNumber || isBackSpace);
        }

        private void numberOfMonthsTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(numberOfMonthsTxtBox.Text) && !string.IsNullOrEmpty(rateTxtBox.Text))
            {
                DateTime newdate = Convert.ToDateTime(startdateTimePicker.Text);
                
                int rate = Convert.ToInt32(rateTxtBox.Text);
                num = Convert.ToInt32(numberOfMonthsTxtBox.Text);
                endDateTxtBox.Text = newdate.AddMonths(num).ToString("dd/MM/yyyy");
                int total = num * rate;
                totalContractAmountTxtBox.Text = total.ToString();
                submitApprovalBtn.Enabled = true;
            }
            else
            {
                totalContractAmountTxtBox.Text = "0";
                submitApprovalBtn.Enabled = false;
            }
        }

        private void startdateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime newdate = Convert.ToDateTime(startdateTimePicker.Text);
            endDateTxtBox.Text = newdate.AddMonths(num).ToString("dd/MM/yyyy");
        }

        private void policeClearanceBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _policefilename = Regex.Replace(DateTime.Now.ToString("MMddyyyyHHmmss") + ofd.SafeFileName, @"[ _-]+", "");
                    policeClearanceTxtBox.Text = ofd.FileName;
                }
            }
        }

        private void nbiClearanceBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _nbifilename = Regex.Replace(DateTime.Now.ToString("MMddyyyyHHmmss") + ofd.SafeFileName, @"[ _-]+", "");
                    nbiClearanceTxtBox.Text = ofd.FileName;
                }
            }
        }

        private void fireClearanceBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _firefilename = Regex.Replace(DateTime.Now.ToString("MMddyyyyHHmmss") + ofd.SafeFileName, @"[ _-]+", "");
                    fireClearanceTxtBox.Text = ofd.FileName;
                }
            }
        }

        private void businessPermitBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _businessfilename = Regex.Replace(DateTime.Now.ToString("MMddyyyyHHmmss") + ofd.SafeFileName, @"[ _-]+", "");
                    businessPermitTxtBox.Text = ofd.FileName;
                }
            }
        }

        void lesseesbtn_Click(object sender, EventArgs e, DataRow row)
        {
            _lesseeId = row["lessee_id"].ToString();
            lesseeTxtBox.Text = row["l_lastname"].ToString() + " " + row["l_firstname"].ToString();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            _stallId = null;
            clearInputs();
        }

        void stallsbtn_Click(object sender, EventArgs e, DataRow row)
        {
            _stallId = row["stall_id"].ToString();
            lesseesflowLayoutPanel.Controls.Clear();
            stallNUmberTxtBox.Text = row["stall_number"].ToString();
            rateTxtBox.Text = row["rate"].ToString();
            sizeBfeetTxtBox.Text = row["stall_floor_blength"].ToString();
            sizeAfeetTxtBox.Text = row["stall_floor_alength"].ToString();
            displayLessees();
        }

        private void refreshpictureBox_Click(object sender, EventArgs e)
        {
            displayStalls();
        }

        private void searchLesseeTxtbox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_stallId))
            {
                lesseesflowLayoutPanel.Controls.Clear();
                int sp = 11;
                int ep = 17;

                try
                {
                    _sc.searchLessee(searchLesseeTxtbox.Text);
                    foreach (DataRow row in _sc.QueryExe().Rows)
                    {
                        Button b = new Button();
                        b.Name = row["lessee_id"].ToString();
                        b.Text = row["l_lastname"].ToString() + " " + row["l_firstname"].ToString();
                        b.Location = new Point(sp, ep);
                        b.Height = 40;
                        b.Width = 220;
                        b.FlatStyle = FlatStyle.Popup; b.BackColor = SystemColors.Control;
                        lesseesflowLayoutPanel.Controls.Add(b);
                        ep += 10;
                        b.Click += delegate (object s, EventArgs evt) { lesseesbtn_Click(s, evt, row); };
                    }
                    _sc.closeConn();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void submitApprovalBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> row = new Dictionary<string, string>();
            row.Add("lesseeId", _lesseeId);
            row.Add("stallId", _stallId);
            row.Add("start_date", startdateTimePicker.Text);
            row.Add("due_date", endDateTxtBox.Text);
            row.Add("date_created", DateTime.Now.ToShortDateString());
            row.Add("business_permit", _businessfilename);
            row.Add("fire_clearance", _firefilename);
            row.Add("police_clearance", _policefilename);
            row.Add("nbi_clearance", _nbifilename);
            row.Add("total_contract", totalContractAmountTxtBox.Text);

            string[] files = new string[]{ _nbifilename, _policefilename, _firefilename, _businessfilename };
            string[] filepath = new string[] { nbiClearanceTxtBox.Text, policeClearanceTxtBox.Text, fireClearanceTxtBox.Text, businessPermitTxtBox.Text };

            for (int i = 0; i < files.Length; i++)
            {
                Image img = Image.FromFile(filepath[i]);
                img.Save(filelocation + "\\" + files[i]);
            }

            applicationClass _c = new applicationClass();
            _c.addPendingContract(row);

            PendingContractsUserControl.Instance.loadPendingCotracts();
            displayStalls();
            clearInputs();
            _stallId = null;
        }

        private byte[] convertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();   
            }
        }

        private void displayLessees()
        {
            int sp = 11;
            int ep = 17;

            try
            {
                _sc.getLessees();
                foreach (DataRow row in _sc.QueryExe().Rows)
                {
                    Button b = new Button();
                    b.Name = row["lessee_id"].ToString();
                    b.Text = row["l_lastname"].ToString() + " " + row["l_firstname"].ToString();
                    b.Location = new Point(sp, ep);
                    b.Height = 40;
                    b.Width = 220;
                    b.FlatStyle = FlatStyle.Popup;
                    //b.BackColor = Color.FromArgb(224, 224, 224); 
                    b.BackColor = SystemColors.Control;
                    lesseesflowLayoutPanel.Controls.Add(b);
                    ep += 10;
                    b.Click += delegate (object sender, EventArgs evt) { lesseesbtn_Click(sender, evt, row); };
                }
                _sc.closeConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearInputs()
        {
            lesseesflowLayoutPanel.Controls.Clear();
            stallNUmberTxtBox.Clear();
            rateTxtBox.Clear();
            sizeAfeetTxtBox.Clear();
            sizeBfeetTxtBox.Clear();
            lesseeTxtBox.Clear();
            numberOfMonthsTxtBox.Clear();
            startdateTimePicker.Text = DateTime.Now.ToShortDateString();
            endDateTxtBox.Clear();
            totalContractAmountTxtBox.Clear();
            businessPermitTxtBox.Clear();
            fireClearanceTxtBox.Clear();
            policeClearanceTxtBox.Clear();
            nbiClearanceTxtBox.Clear();
        }
    }
}
