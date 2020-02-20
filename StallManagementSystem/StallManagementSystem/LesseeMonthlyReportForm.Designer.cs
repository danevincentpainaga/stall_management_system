namespace StallManagementSystem
{
    partial class LesseeMonthlyReportForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.monthlycrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.yearMaskedTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.monthtlyCbx = new System.Windows.Forms.ComboBox();
            this.submitFilterBTn = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1084, 581);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.monthlycrystalReportViewer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1084, 530);
            this.panel2.TabIndex = 1;
            // 
            // monthlycrystalReportViewer
            // 
            this.monthlycrystalReportViewer.ActiveViewIndex = -1;
            this.monthlycrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monthlycrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.monthlycrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthlycrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.monthlycrystalReportViewer.Name = "monthlycrystalReportViewer";
            this.monthlycrystalReportViewer.ShowGroupTreeButton = false;
            this.monthlycrystalReportViewer.Size = new System.Drawing.Size(1084, 530);
            this.monthlycrystalReportViewer.TabIndex = 0;
            this.monthlycrystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.yearMaskedTxtBox);
            this.panel1.Controls.Add(this.monthtlyCbx);
            this.panel1.Controls.Add(this.submitFilterBTn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 51);
            this.panel1.TabIndex = 0;
            // 
            // yearMaskedTxtBox
            // 
            this.yearMaskedTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearMaskedTxtBox.Location = new System.Drawing.Point(175, 12);
            this.yearMaskedTxtBox.Mask = "0000";
            this.yearMaskedTxtBox.Name = "yearMaskedTxtBox";
            this.yearMaskedTxtBox.Size = new System.Drawing.Size(92, 23);
            this.yearMaskedTxtBox.TabIndex = 1;
            this.yearMaskedTxtBox.ValidatingType = typeof(int);
            // 
            // monthtlyCbx
            // 
            this.monthtlyCbx.Font = new System.Drawing.Font("Century Gothic", 7.75F);
            this.monthtlyCbx.FormattingEnabled = true;
            this.monthtlyCbx.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthtlyCbx.Location = new System.Drawing.Point(14, 13);
            this.monthtlyCbx.Name = "monthtlyCbx";
            this.monthtlyCbx.Size = new System.Drawing.Size(155, 23);
            this.monthtlyCbx.TabIndex = 0;
            this.monthtlyCbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.monthtlyCbx_KeyPress);
            // 
            // submitFilterBTn
            // 
            this.submitFilterBTn.BackColor = System.Drawing.SystemColors.Control;
            this.submitFilterBTn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitFilterBTn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitFilterBTn.Location = new System.Drawing.Point(273, 12);
            this.submitFilterBTn.Name = "submitFilterBTn";
            this.submitFilterBTn.Size = new System.Drawing.Size(72, 23);
            this.submitFilterBTn.TabIndex = 2;
            this.submitFilterBTn.Text = "SUBMIT";
            this.submitFilterBTn.UseVisualStyleBackColor = false;
            this.submitFilterBTn.Click += new System.EventHandler(this.submitFilterBTn_Click);
            // 
            // LesseeMonthlyReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 581);
            this.Controls.Add(this.panel3);
            this.Name = "LesseeMonthlyReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lessee Monthly Reports";
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer monthlycrystalReportViewer;
        private System.Windows.Forms.Button submitFilterBTn;
        private System.Windows.Forms.ComboBox monthtlyCbx;
        private System.Windows.Forms.MaskedTextBox yearMaskedTxtBox;
    }
}