namespace StallManagementSystem
{
    partial class ReportsUserControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.reportsCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.stallsListflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ambulantListBtn = new System.Windows.Forms.Button();
            this.lesseesListBtn = new System.Windows.Forms.Button();
            this.duePaymentsBtn = new System.Windows.Forms.Button();
            this.availableStallsBtn = new System.Windows.Forms.Button();
            this.rentedStallsBtn = new System.Windows.Forms.Button();
            this.reservedStallsBtn = new System.Windows.Forms.Button();
            this.lesseeMonthlyReportBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.ambulantMonthlyReportBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.stallsListflowLayoutPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.stallsListflowLayoutPanel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1304, 535);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.reportsCrystalReportViewer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(180, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1124, 505);
            this.panel3.TabIndex = 3;
            // 
            // reportsCrystalReportViewer
            // 
            this.reportsCrystalReportViewer.ActiveViewIndex = -1;
            this.reportsCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportsCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.reportsCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportsCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportsCrystalReportViewer.Name = "reportsCrystalReportViewer";
            this.reportsCrystalReportViewer.Size = new System.Drawing.Size(1124, 505);
            this.reportsCrystalReportViewer.TabIndex = 0;
            this.reportsCrystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // stallsListflowLayoutPanel
            // 
            this.stallsListflowLayoutPanel.AutoScroll = true;
            this.stallsListflowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.stallsListflowLayoutPanel.Controls.Add(this.ambulantListBtn);
            this.stallsListflowLayoutPanel.Controls.Add(this.lesseesListBtn);
            this.stallsListflowLayoutPanel.Controls.Add(this.duePaymentsBtn);
            this.stallsListflowLayoutPanel.Controls.Add(this.availableStallsBtn);
            this.stallsListflowLayoutPanel.Controls.Add(this.rentedStallsBtn);
            this.stallsListflowLayoutPanel.Controls.Add(this.reservedStallsBtn);
            this.stallsListflowLayoutPanel.Controls.Add(this.lesseeMonthlyReportBtn);
            this.stallsListflowLayoutPanel.Controls.Add(this.ambulantMonthlyReportBtn);
            this.stallsListflowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.stallsListflowLayoutPanel.Location = new System.Drawing.Point(0, 30);
            this.stallsListflowLayoutPanel.Name = "stallsListflowLayoutPanel";
            this.stallsListflowLayoutPanel.Size = new System.Drawing.Size(180, 505);
            this.stallsListflowLayoutPanel.TabIndex = 2;
            // 
            // ambulantListBtn
            // 
            this.ambulantListBtn.BackColor = System.Drawing.SystemColors.Control;
            this.ambulantListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ambulantListBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ambulantListBtn.Location = new System.Drawing.Point(3, 3);
            this.ambulantListBtn.Name = "ambulantListBtn";
            this.ambulantListBtn.Size = new System.Drawing.Size(171, 30);
            this.ambulantListBtn.TabIndex = 1;
            this.ambulantListBtn.Text = "Ambulant List";
            this.ambulantListBtn.UseVisualStyleBackColor = false;
            this.ambulantListBtn.Click += new System.EventHandler(this.ambulantListBtn_Click);
            // 
            // lesseesListBtn
            // 
            this.lesseesListBtn.BackColor = System.Drawing.SystemColors.Control;
            this.lesseesListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lesseesListBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lesseesListBtn.Location = new System.Drawing.Point(3, 39);
            this.lesseesListBtn.Name = "lesseesListBtn";
            this.lesseesListBtn.Size = new System.Drawing.Size(171, 30);
            this.lesseesListBtn.TabIndex = 1;
            this.lesseesListBtn.Text = "Lessees List";
            this.lesseesListBtn.UseVisualStyleBackColor = false;
            this.lesseesListBtn.Click += new System.EventHandler(this.lesseesListBtn_Click);
            // 
            // duePaymentsBtn
            // 
            this.duePaymentsBtn.BackColor = System.Drawing.SystemColors.Control;
            this.duePaymentsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.duePaymentsBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duePaymentsBtn.Location = new System.Drawing.Point(3, 75);
            this.duePaymentsBtn.Name = "duePaymentsBtn";
            this.duePaymentsBtn.Size = new System.Drawing.Size(171, 30);
            this.duePaymentsBtn.TabIndex = 1;
            this.duePaymentsBtn.Text = "Due Payment List";
            this.duePaymentsBtn.UseVisualStyleBackColor = false;
            this.duePaymentsBtn.Click += new System.EventHandler(this.duePaymentsBtn_Click);
            // 
            // availableStallsBtn
            // 
            this.availableStallsBtn.BackColor = System.Drawing.SystemColors.Control;
            this.availableStallsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.availableStallsBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableStallsBtn.Location = new System.Drawing.Point(3, 111);
            this.availableStallsBtn.Name = "availableStallsBtn";
            this.availableStallsBtn.Size = new System.Drawing.Size(171, 30);
            this.availableStallsBtn.TabIndex = 2;
            this.availableStallsBtn.Text = "Available Stalls";
            this.availableStallsBtn.UseVisualStyleBackColor = false;
            this.availableStallsBtn.Click += new System.EventHandler(this.availableStallsBtn_Click);
            // 
            // rentedStallsBtn
            // 
            this.rentedStallsBtn.BackColor = System.Drawing.SystemColors.Control;
            this.rentedStallsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rentedStallsBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentedStallsBtn.Location = new System.Drawing.Point(3, 147);
            this.rentedStallsBtn.Name = "rentedStallsBtn";
            this.rentedStallsBtn.Size = new System.Drawing.Size(171, 30);
            this.rentedStallsBtn.TabIndex = 3;
            this.rentedStallsBtn.Text = "Rented Stalls";
            this.rentedStallsBtn.UseVisualStyleBackColor = false;
            this.rentedStallsBtn.Click += new System.EventHandler(this.rentedStallsBtn_Click);
            // 
            // reservedStallsBtn
            // 
            this.reservedStallsBtn.BackColor = System.Drawing.SystemColors.Control;
            this.reservedStallsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reservedStallsBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservedStallsBtn.Location = new System.Drawing.Point(3, 183);
            this.reservedStallsBtn.Name = "reservedStallsBtn";
            this.reservedStallsBtn.Size = new System.Drawing.Size(171, 30);
            this.reservedStallsBtn.TabIndex = 4;
            this.reservedStallsBtn.Text = "Reserved Stalls";
            this.reservedStallsBtn.UseVisualStyleBackColor = false;
            this.reservedStallsBtn.Click += new System.EventHandler(this.reservedStallsBtn_Click);
            // 
            // lesseeMonthlyReportBtn
            // 
            this.lesseeMonthlyReportBtn.BackColor = System.Drawing.SystemColors.Control;
            this.lesseeMonthlyReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lesseeMonthlyReportBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lesseeMonthlyReportBtn.Location = new System.Drawing.Point(3, 219);
            this.lesseeMonthlyReportBtn.Name = "lesseeMonthlyReportBtn";
            this.lesseeMonthlyReportBtn.Size = new System.Drawing.Size(171, 30);
            this.lesseeMonthlyReportBtn.TabIndex = 5;
            this.lesseeMonthlyReportBtn.Text = "Lessees Monthly Report";
            this.lesseeMonthlyReportBtn.UseVisualStyleBackColor = false;
            this.lesseeMonthlyReportBtn.Click += new System.EventHandler(this.monthlyReportBtn_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label17);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1304, 30);
            this.panel2.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(56, 8);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "REPORTS";
            // 
            // ambulantMonthlyReportBtn
            // 
            this.ambulantMonthlyReportBtn.BackColor = System.Drawing.SystemColors.Control;
            this.ambulantMonthlyReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ambulantMonthlyReportBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ambulantMonthlyReportBtn.Location = new System.Drawing.Point(3, 255);
            this.ambulantMonthlyReportBtn.Name = "ambulantMonthlyReportBtn";
            this.ambulantMonthlyReportBtn.Size = new System.Drawing.Size(171, 30);
            this.ambulantMonthlyReportBtn.TabIndex = 6;
            this.ambulantMonthlyReportBtn.Text = "Ambulants Monthly Report";
            this.ambulantMonthlyReportBtn.UseVisualStyleBackColor = false;
            this.ambulantMonthlyReportBtn.Click += new System.EventHandler(this.ambulantMonthlyReportBtn_Click);
            // 
            // ReportsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Name = "ReportsUserControl";
            this.Size = new System.Drawing.Size(1304, 535);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.stallsListflowLayoutPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.FlowLayoutPanel stallsListflowLayoutPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ambulantListBtn;
        private System.Windows.Forms.Button lesseesListBtn;
        private System.Windows.Forms.Button duePaymentsBtn;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer reportsCrystalReportViewer;
        private System.Windows.Forms.Button availableStallsBtn;
        private System.Windows.Forms.Button rentedStallsBtn;
        private System.Windows.Forms.Button reservedStallsBtn;
        private System.Windows.Forms.Button lesseeMonthlyReportBtn;
        private System.Windows.Forms.Button ambulantMonthlyReportBtn;
    }
}
