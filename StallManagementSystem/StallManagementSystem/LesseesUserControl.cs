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
    public partial class LesseesUserControl : UserControl
    {
        public static LesseesUserControl _instance;
        private lesseesClass _lc;
        private string lessee_id;

        public static LesseesUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LesseesUserControl();
                }
                return _instance;
            }
        }

        public LesseesUserControl()
        {
            InitializeComponent();
            _lc = new lesseesClass(this);
        }

        private void LesseesUserControl_Load(object sender, EventArgs e)
        {
            displayLessees();
        }

        public void displayLessees()
        {
            lesseesflowLayoutPanel.Controls.Clear();

            int sp = 3;
            int ep = 3;

            try
            {
                _lc.getLessees();
                foreach (DataRow row in _lc.QueryExe().Rows)
                {
                    Button b = new Button();
                    b.Name = row["lessee_id"].ToString();
                    b.Text = row["l_lastname"].ToString() + ", " + row["l_firstname"].ToString();
                    b.Location = new Point(sp, ep);
                    b.Height = 41;
                    b.Width = 201;
                    b.FlatStyle = FlatStyle.Popup;
                    b.BackColor = SystemColors.Control;
                    b.TextAlign = ContentAlignment.MiddleCenter;
                    lesseesflowLayoutPanel.Controls.Add(b);
                    ep += 10;
                    b.Click += delegate (object sender, EventArgs evt) { btn_Click(sender, evt, row); };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void btn_Click(object sender, EventArgs e, DataRow row)
        {
            saveLesseeBtn.Text = "UPDATE";
            lessee_id = row["lessee_id"].ToString();
            firstnameTxtBox.Text = row["l_firstname"].ToString();
            lastnameTxtBox.Text = row["l_lastname"].ToString();
            middlenameTxtBox.Text = row["l_middlename"].ToString();
            genderCbx.SelectedIndex = genderCbx.FindStringExact(row["gender"].ToString());
            contactNoTxtBox.Text = row["contact_no"].ToString();
            emailTxtBox.Text = row["email_add"].ToString();
            lesseeTypeCbx.SelectedIndex = lesseeTypeCbx.FindStringExact(row["lessee_type"].ToString());
            addressRichTxtBox.Text = row["address"].ToString();
            emergencyTxtBox.Text = row["emergency_contact"].ToString();
        }

        private void saveLesseeBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> l = new Dictionary<string, string>();
            l.Add("l_firstname", firstnameTxtBox.Text);
            l.Add("l_lastname", lastnameTxtBox.Text);
            l.Add("l_middlename", middlenameTxtBox.Text);
            l.Add("gender", genderCbx.Text);
            l.Add("contact_no", contactNoTxtBox.Text);
            l.Add("email_add", emailTxtBox.Text);
            l.Add("lessee_type", lesseeTypeCbx.Text);
            l.Add("address", addressRichTxtBox.Text);
            l.Add("emergency_contact", emergencyTxtBox.Text);
            l.Add("lessee_id", lessee_id);
            if (
                    !string.IsNullOrEmpty(firstnameTxtBox.Text) &&
                    !string.IsNullOrEmpty(lastnameTxtBox.Text) &&
                    !string.IsNullOrEmpty(middlenameTxtBox.Text) &&
                    !string.IsNullOrEmpty(genderCbx.Text) &&
                    !string.IsNullOrEmpty(contactNoTxtBox.Text) &&
                    !string.IsNullOrEmpty(emailTxtBox.Text) &&
                    !string.IsNullOrEmpty(lesseeTypeCbx.Text) &&
                    !string.IsNullOrEmpty(addressRichTxtBox.Text) &&
                    !string.IsNullOrEmpty(emergencyTxtBox.Text) 
               )
            {
                if (saveLesseeBtn.Text == "UPDATE")
                {
                    _lc.updateLessee(l);
                    saveLesseeBtn.Text = "SAVE";
                }
                else
                {
                    _lc.saveLessee(l);
                }
            }

        }

        private void refreshPictureBox_Click(object sender, EventArgs e)
        {
            displayLessees();
        }

        public void clearInputs()
        {
            lessee_id = null;
            firstnameTxtBox.Clear();
            lastnameTxtBox.Clear();
            middlenameTxtBox.Clear();
            genderCbx.SelectedIndex = -1;
            contactNoTxtBox.Clear();
            emailTxtBox.Clear();
            lesseeTypeCbx.SelectedIndex = -1;
            addressRichTxtBox.Clear();
            emergencyTxtBox.Clear();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearInputs();
        }

        private void contactNoTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            numberOnly(e);
        }

        private void emergencyTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            numberOnly(e);
        }

        private void numberOnly(KeyPressEventArgs e)
        {
            byte letter = (byte)e.KeyChar;
            bool isNumber = letter >= 48 && letter <= 57;
            bool isBackSpace = letter == 8;
            e.Handled = !(isNumber || isBackSpace);
        }

        private void genderCbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void lesseeTypeCbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {
            lesseesflowLayoutPanel.Controls.Clear();

            int sp = 3;
            int ep = 3;
            try
            {
                _lc.searchLessee(searchTxtBox.Text);
                foreach (DataRow row in _lc.QueryExe().Rows)
                {
                    Button b = new Button();
                    b.Name = row["lessee_id"].ToString();
                    b.Text = row["l_lastname"].ToString() + ", " + row["l_firstname"].ToString();
                    b.Location = new Point(sp, ep);
                    b.Height = 41;
                    b.Width = 201;
                    b.FlatStyle = FlatStyle.Popup;
                    b.BackColor = SystemColors.Control;
                    b.TextAlign = ContentAlignment.MiddleCenter;
                    lesseesflowLayoutPanel.Controls.Add(b);
                    ep += 10;
                    b.Click += delegate (object s, EventArgs evt) { btn_Click(s, evt, row); };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void filterLesseeTypeCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            lesseesflowLayoutPanel.Controls.Clear();

            int sp = 3;
            int ep = 3;
            try
            {
                _lc.filterLesseeType(filterLesseeTypeCbx.Text);
                foreach (DataRow row in _lc.QueryExe().Rows)
                {
                    Button b = new Button();
                    b.Name = row["lessee_id"].ToString();
                    b.Text = row["l_lastname"].ToString() + ", " + row["l_firstname"].ToString();
                    b.Location = new Point(sp, ep);
                    b.Height = 41;
                    b.Width = 201;
                    b.FlatStyle = FlatStyle.Popup;
                    b.BackColor = SystemColors.Control;
                    b.TextAlign = ContentAlignment.MiddleCenter;
                    lesseesflowLayoutPanel.Controls.Add(b);
                    ep += 10;
                    b.Click += delegate (object s, EventArgs evt) { btn_Click(s, evt, row); };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void filterLesseeTypeCbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
