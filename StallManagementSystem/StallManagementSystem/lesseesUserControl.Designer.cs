namespace StallManagementSystem
{
    partial class LesseesUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LesseesUserControl));
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.filterLesseeTypeCbx = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.genderCbx = new System.Windows.Forms.ComboBox();
            this.lesseeTypeCbx = new System.Windows.Forms.ComboBox();
            this.saveLesseeBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.addressRichTxtBox = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.emailTxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.middlenameTxtBox = new System.Windows.Forms.TextBox();
            this.contactNoTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lastnameTxtBox = new System.Windows.Forms.TextBox();
            this.emergencyTxtBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.firstnameTxtBox = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.addNewBtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.refreshPictureBox = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lesseesflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxtBox.Location = new System.Drawing.Point(10, 8);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(207, 23);
            this.searchTxtBox.TabIndex = 0;
            this.searchTxtBox.TextChanged += new System.EventHandler(this.searchTxtBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Filter By:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.filterLesseeTypeCbx);
            this.panel2.Controls.Add(this.searchTxtBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 67);
            this.panel2.TabIndex = 0;
            // 
            // filterLesseeTypeCbx
            // 
            this.filterLesseeTypeCbx.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterLesseeTypeCbx.FormattingEnabled = true;
            this.filterLesseeTypeCbx.Items.AddRange(new object[] {
            "",
            "ambulant",
            "lessee"});
            this.filterLesseeTypeCbx.Location = new System.Drawing.Point(67, 36);
            this.filterLesseeTypeCbx.Name = "filterLesseeTypeCbx";
            this.filterLesseeTypeCbx.Size = new System.Drawing.Size(150, 25);
            this.filterLesseeTypeCbx.TabIndex = 1;
            this.filterLesseeTypeCbx.SelectedIndexChanged += new System.EventHandler(this.filterLesseeTypeCbx_SelectedIndexChanged);
            this.filterLesseeTypeCbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filterLesseeTypeCbx_KeyPress);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel7.Controls.Add(this.lesseesflowLayoutPanel);
            this.panel7.Controls.Add(this.panel2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(224, 506);
            this.panel7.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1137, 506);
            this.panel1.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1137, 506);
            this.panel4.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(224, 0);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(5);
            this.panel8.Size = new System.Drawing.Size(913, 506);
            this.panel8.TabIndex = 4;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.genderCbx);
            this.panel10.Controls.Add(this.lesseeTypeCbx);
            this.panel10.Controls.Add(this.saveLesseeBtn);
            this.panel10.Controls.Add(this.clearBtn);
            this.panel10.Controls.Add(this.addressRichTxtBox);
            this.panel10.Controls.Add(this.label11);
            this.panel10.Controls.Add(this.emailTxtBox);
            this.panel10.Controls.Add(this.label7);
            this.panel10.Controls.Add(this.label6);
            this.panel10.Controls.Add(this.label9);
            this.panel10.Controls.Add(this.middlenameTxtBox);
            this.panel10.Controls.Add(this.contactNoTxtBox);
            this.panel10.Controls.Add(this.label5);
            this.panel10.Controls.Add(this.label14);
            this.panel10.Controls.Add(this.label8);
            this.panel10.Controls.Add(this.lastnameTxtBox);
            this.panel10.Controls.Add(this.emergencyTxtBox);
            this.panel10.Controls.Add(this.label12);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Controls.Add(this.firstnameTxtBox);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(5, 48);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(901, 451);
            this.panel10.TabIndex = 1;
            // 
            // genderCbx
            // 
            this.genderCbx.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.genderCbx.FormattingEnabled = true;
            this.genderCbx.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderCbx.Location = new System.Drawing.Point(158, 121);
            this.genderCbx.Name = "genderCbx";
            this.genderCbx.Size = new System.Drawing.Size(226, 25);
            this.genderCbx.TabIndex = 3;
            this.genderCbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.genderCbx_KeyPress);
            // 
            // lesseeTypeCbx
            // 
            this.lesseeTypeCbx.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lesseeTypeCbx.FormattingEnabled = true;
            this.lesseeTypeCbx.Items.AddRange(new object[] {
            "lessee",
            "ambulant"});
            this.lesseeTypeCbx.Location = new System.Drawing.Point(158, 210);
            this.lesseeTypeCbx.Name = "lesseeTypeCbx";
            this.lesseeTypeCbx.Size = new System.Drawing.Size(226, 25);
            this.lesseeTypeCbx.TabIndex = 6;
            this.lesseeTypeCbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lesseeTypeCbx_KeyPress);
            // 
            // saveLesseeBtn
            // 
            this.saveLesseeBtn.BackColor = System.Drawing.SystemColors.Control;
            this.saveLesseeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveLesseeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveLesseeBtn.Location = new System.Drawing.Point(675, 200);
            this.saveLesseeBtn.Name = "saveLesseeBtn";
            this.saveLesseeBtn.Size = new System.Drawing.Size(91, 35);
            this.saveLesseeBtn.TabIndex = 10;
            this.saveLesseeBtn.Text = "SAVE";
            this.saveLesseeBtn.UseVisualStyleBackColor = false;
            this.saveLesseeBtn.Click += new System.EventHandler(this.saveLesseeBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.SystemColors.Control;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(772, 200);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(91, 35);
            this.clearBtn.TabIndex = 11;
            this.clearBtn.Text = "CLEAR";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // addressRichTxtBox
            // 
            this.addressRichTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressRichTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressRichTxtBox.Location = new System.Drawing.Point(571, 35);
            this.addressRichTxtBox.Multiline = false;
            this.addressRichTxtBox.Name = "addressRichTxtBox";
            this.addressRichTxtBox.Size = new System.Drawing.Size(292, 51);
            this.addressRichTxtBox.TabIndex = 7;
            this.addressRichTxtBox.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(22, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Email Address";
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxtBox.Location = new System.Drawing.Point(158, 180);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(226, 23);
            this.emailTxtBox.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Lessee Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Middle Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Contact Number";
            // 
            // middlenameTxtBox
            // 
            this.middlenameTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middlenameTxtBox.Location = new System.Drawing.Point(158, 94);
            this.middlenameTxtBox.Name = "middlenameTxtBox";
            this.middlenameTxtBox.Size = new System.Drawing.Size(226, 23);
            this.middlenameTxtBox.TabIndex = 2;
            // 
            // contactNoTxtBox
            // 
            this.contactNoTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNoTxtBox.Location = new System.Drawing.Point(158, 152);
            this.contactNoTxtBox.Name = "contactNoTxtBox";
            this.contactNoTxtBox.Size = new System.Drawing.Size(226, 23);
            this.contactNoTxtBox.TabIndex = 4;
            this.contactNoTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contactNoTxtBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Lastname:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(423, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Emergency Contact";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Gender:";
            // 
            // lastnameTxtBox
            // 
            this.lastnameTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnameTxtBox.Location = new System.Drawing.Point(158, 64);
            this.lastnameTxtBox.Name = "lastnameTxtBox";
            this.lastnameTxtBox.Size = new System.Drawing.Size(226, 23);
            this.lastnameTxtBox.TabIndex = 1;
            // 
            // emergencyTxtBox
            // 
            this.emergencyTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emergencyTxtBox.Location = new System.Drawing.Point(571, 110);
            this.emergencyTxtBox.Name = "emergencyTxtBox";
            this.emergencyTxtBox.Size = new System.Drawing.Size(226, 23);
            this.emergencyTxtBox.TabIndex = 8;
            this.emergencyTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.emergencyTxtBox_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(423, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Firstname:";
            // 
            // firstnameTxtBox
            // 
            this.firstnameTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnameTxtBox.Location = new System.Drawing.Point(158, 35);
            this.firstnameTxtBox.Name = "firstnameTxtBox";
            this.firstnameTxtBox.Size = new System.Drawing.Size(226, 23);
            this.firstnameTxtBox.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DarkCyan;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.label2);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(5, 5);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(901, 43);
            this.panel9.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "LESSEE INFORMATION";
            // 
            // addNewBtn
            // 
            this.addNewBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addNewBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addNewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewBtn.Location = new System.Drawing.Point(1263, 8);
            this.addNewBtn.Name = "addNewBtn";
            this.addNewBtn.Size = new System.Drawing.Size(84, 35);
            this.addNewBtn.TabIndex = 1;
            this.addNewBtn.Text = "ADD NEW";
            this.addNewBtn.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.refreshPictureBox);
            this.panel5.Controls.Add(this.addNewBtn);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1137, 29);
            this.panel5.TabIndex = 0;
            // 
            // refreshPictureBox
            // 
            this.refreshPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("refreshPictureBox.Image")));
            this.refreshPictureBox.Location = new System.Drawing.Point(1106, 1);
            this.refreshPictureBox.Name = "refreshPictureBox";
            this.refreshPictureBox.Size = new System.Drawing.Size(25, 26);
            this.refreshPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refreshPictureBox.TabIndex = 1;
            this.refreshPictureBox.TabStop = false;
            this.refreshPictureBox.Click += new System.EventHandler(this.refreshPictureBox_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Teal;
            this.label17.Location = new System.Drawing.Point(8, 7);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(128, 16);
            this.label17.TabIndex = 0;
            this.label17.Text = "SELECT LESSEE";
            // 
            // lesseesflowLayoutPanel
            // 
            this.lesseesflowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.lesseesflowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lesseesflowLayoutPanel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lesseesflowLayoutPanel.Location = new System.Drawing.Point(0, 67);
            this.lesseesflowLayoutPanel.Name = "lesseesflowLayoutPanel";
            this.lesseesflowLayoutPanel.Size = new System.Drawing.Size(224, 439);
            this.lesseesflowLayoutPanel.TabIndex = 0;
            // 
            // LesseesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Name = "LesseesUserControl";
            this.Size = new System.Drawing.Size(1137, 535);
            this.Load += new System.EventHandler(this.LesseesUserControl_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox filterLesseeTypeCbx;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button addNewBtn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.RichTextBox addressRichTxtBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox emailTxtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox middlenameTxtBox;
        private System.Windows.Forms.TextBox contactNoTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox lastnameTxtBox;
        private System.Windows.Forms.TextBox emergencyTxtBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firstnameTxtBox;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox lesseeTypeCbx;
        private System.Windows.Forms.Button saveLesseeBtn;
        private System.Windows.Forms.PictureBox refreshPictureBox;
        private System.Windows.Forms.ComboBox genderCbx;
        private System.Windows.Forms.FlowLayoutPanel lesseesflowLayoutPanel;
    }
}
