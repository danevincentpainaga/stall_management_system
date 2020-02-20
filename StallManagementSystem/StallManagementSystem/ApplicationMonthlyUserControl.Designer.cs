namespace StallManagementSystem
{
    partial class ApplicationMonthlyUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationMonthlyUserControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.refreshpictureBox = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.startdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.nbiClearanceBtn = new System.Windows.Forms.Button();
            this.policeClearanceBtn = new System.Windows.Forms.Button();
            this.fireClearanceBtn = new System.Windows.Forms.Button();
            this.businessPermitBtn = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.nbiClearanceTxtBox = new System.Windows.Forms.TextBox();
            this.policeClearanceTxtBox = new System.Windows.Forms.TextBox();
            this.fireClearanceTxtBox = new System.Windows.Forms.TextBox();
            this.businessPermitTxtBox = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.lesseesflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.clearBtn = new System.Windows.Forms.Button();
            this.submitApprovalBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.totalContractAmountTxtBox = new System.Windows.Forms.TextBox();
            this.endDateTxtBox = new System.Windows.Forms.TextBox();
            this.numberOfMonthsTxtBox = new System.Windows.Forms.TextBox();
            this.searchLesseeTxtbox = new System.Windows.Forms.TextBox();
            this.lesseeTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rateTxtBox = new System.Windows.Forms.TextBox();
            this.sizeBfeetTxtBox = new System.Windows.Forms.TextBox();
            this.sizeAfeetTxtBox = new System.Windows.Forms.TextBox();
            this.stallNUmberTxtBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.stallsListflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshpictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.refreshpictureBox);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1302, 30);
            this.panel1.TabIndex = 0;
            // 
            // refreshpictureBox
            // 
            this.refreshpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("refreshpictureBox.Image")));
            this.refreshpictureBox.Location = new System.Drawing.Point(1274, 2);
            this.refreshpictureBox.Name = "refreshpictureBox";
            this.refreshpictureBox.Size = new System.Drawing.Size(25, 26);
            this.refreshpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refreshpictureBox.TabIndex = 5;
            this.refreshpictureBox.TabStop = false;
            this.refreshpictureBox.Click += new System.EventHandler(this.refreshpictureBox_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(5, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "STALL RENTALS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.stallsListflowLayoutPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1302, 507);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.startdateTimePicker);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.lesseesflowLayoutPanel);
            this.panel3.Controls.Add(this.clearBtn);
            this.panel3.Controls.Add(this.submitApprovalBtn);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.totalContractAmountTxtBox);
            this.panel3.Controls.Add(this.endDateTxtBox);
            this.panel3.Controls.Add(this.numberOfMonthsTxtBox);
            this.panel3.Controls.Add(this.searchLesseeTxtbox);
            this.panel3.Controls.Add(this.lesseeTxtBox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.rateTxtBox);
            this.panel3.Controls.Add(this.sizeBfeetTxtBox);
            this.panel3.Controls.Add(this.sizeAfeetTxtBox);
            this.panel3.Controls.Add(this.stallNUmberTxtBox);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(180, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1122, 507);
            this.panel3.TabIndex = 1;
            // 
            // startdateTimePicker
            // 
            this.startdateTimePicker.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startdateTimePicker.Location = new System.Drawing.Point(413, 173);
            this.startdateTimePicker.Name = "startdateTimePicker";
            this.startdateTimePicker.Size = new System.Drawing.Size(226, 23);
            this.startdateTimePicker.TabIndex = 6;
            this.startdateTimePicker.ValueChanged += new System.EventHandler(this.startdateTimePicker_ValueChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(282, 256);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(462, 184);
            this.panel5.TabIndex = 23;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.nbiClearanceBtn);
            this.panel7.Controls.Add(this.policeClearanceBtn);
            this.panel7.Controls.Add(this.fireClearanceBtn);
            this.panel7.Controls.Add(this.businessPermitBtn);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.nbiClearanceTxtBox);
            this.panel7.Controls.Add(this.policeClearanceTxtBox);
            this.panel7.Controls.Add(this.fireClearanceTxtBox);
            this.panel7.Controls.Add(this.businessPermitTxtBox);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 28);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(462, 156);
            this.panel7.TabIndex = 1;
            // 
            // nbiClearanceBtn
            // 
            this.nbiClearanceBtn.Location = new System.Drawing.Point(400, 101);
            this.nbiClearanceBtn.Name = "nbiClearanceBtn";
            this.nbiClearanceBtn.Size = new System.Drawing.Size(48, 23);
            this.nbiClearanceBtn.TabIndex = 3;
            this.nbiClearanceBtn.Text = "SET";
            this.nbiClearanceBtn.UseVisualStyleBackColor = true;
            this.nbiClearanceBtn.Click += new System.EventHandler(this.nbiClearanceBtn_Click);
            // 
            // policeClearanceBtn
            // 
            this.policeClearanceBtn.Location = new System.Drawing.Point(400, 72);
            this.policeClearanceBtn.Name = "policeClearanceBtn";
            this.policeClearanceBtn.Size = new System.Drawing.Size(48, 23);
            this.policeClearanceBtn.TabIndex = 2;
            this.policeClearanceBtn.Text = "SET";
            this.policeClearanceBtn.UseVisualStyleBackColor = true;
            this.policeClearanceBtn.Click += new System.EventHandler(this.policeClearanceBtn_Click);
            // 
            // fireClearanceBtn
            // 
            this.fireClearanceBtn.Location = new System.Drawing.Point(400, 43);
            this.fireClearanceBtn.Name = "fireClearanceBtn";
            this.fireClearanceBtn.Size = new System.Drawing.Size(48, 23);
            this.fireClearanceBtn.TabIndex = 1;
            this.fireClearanceBtn.Text = "SET";
            this.fireClearanceBtn.UseVisualStyleBackColor = true;
            this.fireClearanceBtn.Click += new System.EventHandler(this.fireClearanceBtn_Click);
            // 
            // businessPermitBtn
            // 
            this.businessPermitBtn.Location = new System.Drawing.Point(400, 12);
            this.businessPermitBtn.Name = "businessPermitBtn";
            this.businessPermitBtn.Size = new System.Drawing.Size(48, 23);
            this.businessPermitBtn.TabIndex = 0;
            this.businessPermitBtn.Text = "SET";
            this.businessPermitBtn.UseVisualStyleBackColor = true;
            this.businessPermitBtn.Click += new System.EventHandler(this.businessPermitBtn_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 106);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 16);
            this.label16.TabIndex = 19;
            this.label16.Text = "NBI Clearance";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 16);
            this.label15.TabIndex = 19;
            this.label15.Text = "Police Clearance";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 16);
            this.label14.TabIndex = 19;
            this.label14.Text = "Fire Clearance";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 16);
            this.label13.TabIndex = 19;
            this.label13.Text = "Business Permit";
            // 
            // nbiClearanceTxtBox
            // 
            this.nbiClearanceTxtBox.BackColor = System.Drawing.Color.White;
            this.nbiClearanceTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbiClearanceTxtBox.Location = new System.Drawing.Point(109, 101);
            this.nbiClearanceTxtBox.Name = "nbiClearanceTxtBox";
            this.nbiClearanceTxtBox.ReadOnly = true;
            this.nbiClearanceTxtBox.Size = new System.Drawing.Size(288, 23);
            this.nbiClearanceTxtBox.TabIndex = 14;
            // 
            // policeClearanceTxtBox
            // 
            this.policeClearanceTxtBox.BackColor = System.Drawing.Color.White;
            this.policeClearanceTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.policeClearanceTxtBox.Location = new System.Drawing.Point(109, 72);
            this.policeClearanceTxtBox.Name = "policeClearanceTxtBox";
            this.policeClearanceTxtBox.ReadOnly = true;
            this.policeClearanceTxtBox.Size = new System.Drawing.Size(288, 23);
            this.policeClearanceTxtBox.TabIndex = 14;
            // 
            // fireClearanceTxtBox
            // 
            this.fireClearanceTxtBox.BackColor = System.Drawing.Color.White;
            this.fireClearanceTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fireClearanceTxtBox.Location = new System.Drawing.Point(109, 43);
            this.fireClearanceTxtBox.Name = "fireClearanceTxtBox";
            this.fireClearanceTxtBox.ReadOnly = true;
            this.fireClearanceTxtBox.Size = new System.Drawing.Size(288, 23);
            this.fireClearanceTxtBox.TabIndex = 14;
            // 
            // businessPermitTxtBox
            // 
            this.businessPermitTxtBox.BackColor = System.Drawing.Color.White;
            this.businessPermitTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.businessPermitTxtBox.Location = new System.Drawing.Point(109, 12);
            this.businessPermitTxtBox.Name = "businessPermitTxtBox";
            this.businessPermitTxtBox.ReadOnly = true;
            this.businessPermitTxtBox.Size = new System.Drawing.Size(288, 23);
            this.businessPermitTxtBox.TabIndex = 14;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label12);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(462, 28);
            this.panel6.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(3, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "DOCUMENTS";
            // 
            // lesseesflowLayoutPanel
            // 
            this.lesseesflowLayoutPanel.AutoScroll = true;
            this.lesseesflowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.lesseesflowLayoutPanel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lesseesflowLayoutPanel.Location = new System.Drawing.Point(15, 188);
            this.lesseesflowLayoutPanel.Name = "lesseesflowLayoutPanel";
            this.lesseesflowLayoutPanel.Size = new System.Drawing.Size(245, 292);
            this.lesseesflowLayoutPanel.TabIndex = 20;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.SystemColors.Control;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(438, 446);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(150, 30);
            this.clearBtn.TabIndex = 10;
            this.clearBtn.Text = "CLEAR";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // submitApprovalBtn
            // 
            this.submitApprovalBtn.BackColor = System.Drawing.SystemColors.Control;
            this.submitApprovalBtn.Enabled = false;
            this.submitApprovalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitApprovalBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitApprovalBtn.Location = new System.Drawing.Point(594, 446);
            this.submitApprovalBtn.Name = "submitApprovalBtn";
            this.submitApprovalBtn.Size = new System.Drawing.Size(150, 30);
            this.submitApprovalBtn.TabIndex = 9;
            this.submitApprovalBtn.Text = "SUBMIT APPROVAL";
            this.submitApprovalBtn.UseVisualStyleBackColor = false;
            this.submitApprovalBtn.Click += new System.EventHandler(this.submitApprovalBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(279, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Total Contract Amount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(279, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "End Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(279, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Start Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(279, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Number of Months";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "Lessee";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(279, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Lessee";
            // 
            // totalContractAmountTxtBox
            // 
            this.totalContractAmountTxtBox.BackColor = System.Drawing.Color.White;
            this.totalContractAmountTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalContractAmountTxtBox.Location = new System.Drawing.Point(413, 224);
            this.totalContractAmountTxtBox.Name = "totalContractAmountTxtBox";
            this.totalContractAmountTxtBox.ReadOnly = true;
            this.totalContractAmountTxtBox.Size = new System.Drawing.Size(226, 23);
            this.totalContractAmountTxtBox.TabIndex = 8;
            // 
            // endDateTxtBox
            // 
            this.endDateTxtBox.BackColor = System.Drawing.Color.White;
            this.endDateTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateTxtBox.Location = new System.Drawing.Point(413, 198);
            this.endDateTxtBox.Name = "endDateTxtBox";
            this.endDateTxtBox.ReadOnly = true;
            this.endDateTxtBox.Size = new System.Drawing.Size(226, 23);
            this.endDateTxtBox.TabIndex = 7;
            // 
            // numberOfMonthsTxtBox
            // 
            this.numberOfMonthsTxtBox.BackColor = System.Drawing.Color.White;
            this.numberOfMonthsTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfMonthsTxtBox.Location = new System.Drawing.Point(413, 146);
            this.numberOfMonthsTxtBox.Name = "numberOfMonthsTxtBox";
            this.numberOfMonthsTxtBox.Size = new System.Drawing.Size(226, 23);
            this.numberOfMonthsTxtBox.TabIndex = 5;
            this.numberOfMonthsTxtBox.TextChanged += new System.EventHandler(this.numberOfMonthsTxtBox_TextChanged);
            this.numberOfMonthsTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberOfMonthsTxtBox_KeyPress);
            // 
            // searchLesseeTxtbox
            // 
            this.searchLesseeTxtbox.BackColor = System.Drawing.Color.White;
            this.searchLesseeTxtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLesseeTxtbox.Location = new System.Drawing.Point(15, 164);
            this.searchLesseeTxtbox.Name = "searchLesseeTxtbox";
            this.searchLesseeTxtbox.Size = new System.Drawing.Size(245, 23);
            this.searchLesseeTxtbox.TabIndex = 11;
            this.searchLesseeTxtbox.TextChanged += new System.EventHandler(this.searchLesseeTxtbox_TextChanged);
            // 
            // lesseeTxtBox
            // 
            this.lesseeTxtBox.BackColor = System.Drawing.Color.White;
            this.lesseeTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lesseeTxtBox.Location = new System.Drawing.Point(413, 120);
            this.lesseeTxtBox.Name = "lesseeTxtBox";
            this.lesseeTxtBox.ReadOnly = true;
            this.lesseeTxtBox.Size = new System.Drawing.Size(226, 23);
            this.lesseeTxtBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(431, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(431, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Size B(Feet)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Size A(Feet)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Stall Number";
            // 
            // rateTxtBox
            // 
            this.rateTxtBox.BackColor = System.Drawing.Color.White;
            this.rateTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateTxtBox.Location = new System.Drawing.Point(510, 40);
            this.rateTxtBox.Name = "rateTxtBox";
            this.rateTxtBox.ReadOnly = true;
            this.rateTxtBox.Size = new System.Drawing.Size(267, 23);
            this.rateTxtBox.TabIndex = 2;
            // 
            // sizeBfeetTxtBox
            // 
            this.sizeBfeetTxtBox.BackColor = System.Drawing.Color.White;
            this.sizeBfeetTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeBfeetTxtBox.Location = new System.Drawing.Point(510, 69);
            this.sizeBfeetTxtBox.Name = "sizeBfeetTxtBox";
            this.sizeBfeetTxtBox.ReadOnly = true;
            this.sizeBfeetTxtBox.Size = new System.Drawing.Size(267, 23);
            this.sizeBfeetTxtBox.TabIndex = 3;
            // 
            // sizeAfeetTxtBox
            // 
            this.sizeAfeetTxtBox.BackColor = System.Drawing.Color.White;
            this.sizeAfeetTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeAfeetTxtBox.Location = new System.Drawing.Point(146, 66);
            this.sizeAfeetTxtBox.Name = "sizeAfeetTxtBox";
            this.sizeAfeetTxtBox.ReadOnly = true;
            this.sizeAfeetTxtBox.Size = new System.Drawing.Size(267, 23);
            this.sizeAfeetTxtBox.TabIndex = 1;
            // 
            // stallNUmberTxtBox
            // 
            this.stallNUmberTxtBox.BackColor = System.Drawing.Color.White;
            this.stallNUmberTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stallNUmberTxtBox.Location = new System.Drawing.Point(146, 40);
            this.stallNUmberTxtBox.Name = "stallNUmberTxtBox";
            this.stallNUmberTxtBox.ReadOnly = true;
            this.stallNUmberTxtBox.Size = new System.Drawing.Size(267, 23);
            this.stallNUmberTxtBox.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1118, 30);
            this.panel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "STALL RENTAL";
            // 
            // stallsListflowLayoutPanel
            // 
            this.stallsListflowLayoutPanel.AutoScroll = true;
            this.stallsListflowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.stallsListflowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.stallsListflowLayoutPanel.Name = "stallsListflowLayoutPanel";
            this.stallsListflowLayoutPanel.Size = new System.Drawing.Size(180, 507);
            this.stallsListflowLayoutPanel.TabIndex = 0;
            // 
            // ApplicationMonthlyUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ApplicationMonthlyUserControl";
            this.Size = new System.Drawing.Size(1302, 537);
            this.Load += new System.EventHandler(this.ApplicationMonthlyUserControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshpictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel stallsListflowLayoutPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rateTxtBox;
        private System.Windows.Forms.TextBox sizeBfeetTxtBox;
        private System.Windows.Forms.TextBox sizeAfeetTxtBox;
        private System.Windows.Forms.TextBox stallNUmberTxtBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox totalContractAmountTxtBox;
        private System.Windows.Forms.TextBox endDateTxtBox;
        private System.Windows.Forms.TextBox numberOfMonthsTxtBox;
        private System.Windows.Forms.TextBox lesseeTxtBox;
        private System.Windows.Forms.FlowLayoutPanel lesseesflowLayoutPanel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox searchLesseeTxtbox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button businessPermitBtn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox businessPermitTxtBox;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox nbiClearanceTxtBox;
        private System.Windows.Forms.TextBox policeClearanceTxtBox;
        private System.Windows.Forms.TextBox fireClearanceTxtBox;
        private System.Windows.Forms.Button nbiClearanceBtn;
        private System.Windows.Forms.Button policeClearanceBtn;
        private System.Windows.Forms.Button fireClearanceBtn;
        private System.Windows.Forms.DateTimePicker startdateTimePicker;
        private System.Windows.Forms.Button submitApprovalBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.PictureBox refreshpictureBox;
    }
}
