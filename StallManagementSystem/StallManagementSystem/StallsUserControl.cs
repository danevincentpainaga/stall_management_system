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
    public partial class StallsUserControl : UserControl
    {

        public static StallsUserControl _instance;

        private stallClass _sc;

        private string stall_id;
        Dictionary<string, string> stall;

        public static StallsUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new StallsUserControl();
                }
                return _instance;
            }
        }

        public StallsUserControl()
        {
            InitializeComponent();
            _sc = new stallClass();
        }

        private void StallsUserControl_Load(object sender, EventArgs e)
        {
            displayStalls();
        }

        void btn_Click(object sender, EventArgs e, DataRow row)
        {
            saveBtn.Text = "UPDATE";
            stall_id = row["stall_id"].ToString();
            stallNumtextBox.Text = row["stall_number"].ToString();
            ratetextBox.Text = row["rate"].ToString();
            lengthtextBox.Text = row["stall_floor_blength"].ToString();
            widthtextBox.Text = row["stall_floor_alength"].ToString();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            saveBtn.Text = "SAVE";
            clearInputs();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            stall = new Dictionary<string, string>();
            stall.Add("stall_id", stall_id);
            stall.Add("stall_number", stallNumtextBox.Text);
            stall.Add("rate", ratetextBox.Text);
            stall.Add("stall_floor_alength", lengthtextBox.Text);
            stall.Add("stall_floor_blength", widthtextBox.Text);

            if (saveBtn.Text == "SAVE")
            {
                if (
                    !string.IsNullOrEmpty(stallNumtextBox.Text) &&
                    !string.IsNullOrEmpty(ratetextBox.Text) &&
                    !string.IsNullOrEmpty(lengthtextBox.Text) &&
                    !string.IsNullOrEmpty(widthtextBox.Text)
                    )
                {
                    _sc.saveNewStall(stall, this);
                    clearInputs();
                }
            }
            else
            {
                _sc.updateStall(stall);
                 displayStalls();
            }
        }
        public void displayStalls()
        {
            stallListflowLayoutPanel.Controls.Clear();
            int sp = 3;
            int ep = 3;

            try
            {
                _sc.getStalls();
                foreach (DataRow row in _sc.QueryExe().Rows)
                {
                    Button b = new Button();
                    b.Name = row["stall_number"].ToString();
                    b.Text = row["stall_number"].ToString();
                    b.Location = new Point(sp, ep);
                    b.Height = 40;
                    b.Width = 155;
                    b.FlatStyle = FlatStyle.Popup;
                    b.BackColor = SystemColors.Control;
                    b.TextAlign = ContentAlignment.MiddleCenter;
                    stallListflowLayoutPanel.Controls.Add(b);
                    ep += 10;
                    b.Click += delegate (object sender, EventArgs evt) { btn_Click(sender, evt, row); };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearInputs()
        {
            stallNumtextBox.Clear();
            ratetextBox.Clear();
            lengthtextBox.Clear();
            widthtextBox.Clear();
        }

        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {
            stallListflowLayoutPanel.Controls.Clear();
            int sp = 3;
            int ep = 3;

            try
            {
                _sc.searchStalls(searchTxtBox.Text);
                foreach (DataRow row in _sc.QueryExe().Rows)
                {
                    Button b = new Button();
                    b.Name = row["stall_number"].ToString();
                    b.Text = row["stall_number"].ToString();
                    b.Location = new Point(sp, ep);
                    b.Height = 40;
                    b.Width = 155;
                    b.FlatStyle = FlatStyle.Popup;
                    b.BackColor = SystemColors.Control;
                    b.TextAlign = ContentAlignment.MiddleCenter;
                    stallListflowLayoutPanel.Controls.Add(b);
                    ep += 10;
                    b.Click += delegate (object s, EventArgs evt) { btn_Click(s, evt, row); };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
