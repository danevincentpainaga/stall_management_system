namespace StallManagementSystem
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.billingBtn = new System.Windows.Forms.Button();
            this.reportsBtn = new System.Windows.Forms.Button();
            this.applicationBtn = new System.Windows.Forms.Button();
            this.contractsBtn = new System.Windows.Forms.Button();
            this.paymentsBtn = new System.Windows.Forms.Button();
            this.managementBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.userparentPanelHolder = new System.Windows.Forms.Panel();
            this.userControlPanelHolder = new System.Windows.Forms.Panel();
            this.headerPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.userparentPanelHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.headerPanel.Controls.Add(this.label2);
            this.headerPanel.Controls.Add(this.logoutBtn);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1354, 30);
            this.headerPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(5, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "BPM STALL MANAGEMENT SYSTEM";
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.White;
            this.logoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutBtn.Image")));
            this.logoutBtn.Location = new System.Drawing.Point(1319, 1);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(32, 30);
            this.logoutBtn.TabIndex = 0;
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // billingBtn
            // 
            this.billingBtn.BackColor = System.Drawing.Color.Purple;
            this.billingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.billingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billingBtn.ForeColor = System.Drawing.Color.White;
            this.billingBtn.Location = new System.Drawing.Point(905, 35);
            this.billingBtn.Name = "billingBtn";
            this.billingBtn.Size = new System.Drawing.Size(160, 62);
            this.billingBtn.TabIndex = 5;
            this.billingBtn.Text = "Billing";
            this.billingBtn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.billingBtn.UseVisualStyleBackColor = false;
            this.billingBtn.Click += new System.EventHandler(this.billingBtn_Click);
            // 
            // reportsBtn
            // 
            this.reportsBtn.BackColor = System.Drawing.Color.Green;
            this.reportsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsBtn.ForeColor = System.Drawing.Color.White;
            this.reportsBtn.Location = new System.Drawing.Point(728, 35);
            this.reportsBtn.Name = "reportsBtn";
            this.reportsBtn.Size = new System.Drawing.Size(160, 62);
            this.reportsBtn.TabIndex = 4;
            this.reportsBtn.Text = "Reports";
            this.reportsBtn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.reportsBtn.UseVisualStyleBackColor = false;
            this.reportsBtn.Click += new System.EventHandler(this.reportsBtn_Click);
            // 
            // applicationBtn
            // 
            this.applicationBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.applicationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applicationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationBtn.ForeColor = System.Drawing.Color.White;
            this.applicationBtn.Location = new System.Drawing.Point(552, 35);
            this.applicationBtn.Name = "applicationBtn";
            this.applicationBtn.Size = new System.Drawing.Size(160, 62);
            this.applicationBtn.TabIndex = 3;
            this.applicationBtn.Text = "Application";
            this.applicationBtn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.applicationBtn.UseVisualStyleBackColor = false;
            this.applicationBtn.Click += new System.EventHandler(this.applicationBtn_Click);
            // 
            // contractsBtn
            // 
            this.contractsBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.contractsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contractsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractsBtn.ForeColor = System.Drawing.Color.White;
            this.contractsBtn.Location = new System.Drawing.Point(375, 35);
            this.contractsBtn.Name = "contractsBtn";
            this.contractsBtn.Size = new System.Drawing.Size(160, 62);
            this.contractsBtn.TabIndex = 2;
            this.contractsBtn.Text = "Contracts";
            this.contractsBtn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.contractsBtn.UseVisualStyleBackColor = false;
            this.contractsBtn.Click += new System.EventHandler(this.contractsBtn_Click);
            // 
            // paymentsBtn
            // 
            this.paymentsBtn.BackColor = System.Drawing.Color.DimGray;
            this.paymentsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paymentsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentsBtn.ForeColor = System.Drawing.Color.White;
            this.paymentsBtn.Location = new System.Drawing.Point(199, 35);
            this.paymentsBtn.Name = "paymentsBtn";
            this.paymentsBtn.Size = new System.Drawing.Size(160, 62);
            this.paymentsBtn.TabIndex = 1;
            this.paymentsBtn.Text = "Payments";
            this.paymentsBtn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.paymentsBtn.UseVisualStyleBackColor = false;
            this.paymentsBtn.Click += new System.EventHandler(this.paymentsBtn_Click);
            // 
            // managementBtn
            // 
            this.managementBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.managementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.managementBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managementBtn.ForeColor = System.Drawing.Color.White;
            this.managementBtn.Location = new System.Drawing.Point(24, 35);
            this.managementBtn.Name = "managementBtn";
            this.managementBtn.Size = new System.Drawing.Size(160, 62);
            this.managementBtn.TabIndex = 0;
            this.managementBtn.Text = "Management";
            this.managementBtn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.managementBtn.UseVisualStyleBackColor = false;
            this.managementBtn.Click += new System.EventHandler(this.managementBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.billingBtn);
            this.panel1.Controls.Add(this.managementBtn);
            this.panel1.Controls.Add(this.reportsBtn);
            this.panel1.Controls.Add(this.paymentsBtn);
            this.panel1.Controls.Add(this.applicationBtn);
            this.panel1.Controls.Add(this.contractsBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1354, 111);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENU";
            // 
            // userparentPanelHolder
            // 
            this.userparentPanelHolder.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.userparentPanelHolder.Controls.Add(this.userControlPanelHolder);
            this.userparentPanelHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userparentPanelHolder.Location = new System.Drawing.Point(0, 141);
            this.userparentPanelHolder.Name = "userparentPanelHolder";
            this.userparentPanelHolder.Padding = new System.Windows.Forms.Padding(25, 3, 25, 0);
            this.userparentPanelHolder.Size = new System.Drawing.Size(1354, 542);
            this.userparentPanelHolder.TabIndex = 4;
            // 
            // userControlPanelHolder
            // 
            this.userControlPanelHolder.BackColor = System.Drawing.SystemColors.Control;
            this.userControlPanelHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlPanelHolder.Location = new System.Drawing.Point(25, 3);
            this.userControlPanelHolder.Name = "userControlPanelHolder";
            this.userControlPanelHolder.Size = new System.Drawing.Size(1304, 539);
            this.userControlPanelHolder.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 683);
            this.Controls.Add(this.userparentPanelHolder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.userparentPanelHolder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button managementBtn;
        private System.Windows.Forms.Button paymentsBtn;
        private System.Windows.Forms.Button applicationBtn;
        private System.Windows.Forms.Button contractsBtn;
        private System.Windows.Forms.Button billingBtn;
        private System.Windows.Forms.Button reportsBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel userparentPanelHolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel userControlPanelHolder;
    }
}