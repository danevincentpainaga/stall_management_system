namespace StallManagementSystem
{
    partial class ContractForm
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
            this.ContractCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ContractCrystalReportViewer
            // 
            this.ContractCrystalReportViewer.ActiveViewIndex = -1;
            this.ContractCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContractCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ContractCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContractCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.ContractCrystalReportViewer.Name = "ContractCrystalReportViewer";
            this.ContractCrystalReportViewer.ShowGroupTreeButton = false;
            this.ContractCrystalReportViewer.Size = new System.Drawing.Size(1092, 561);
            this.ContractCrystalReportViewer.TabIndex = 0;
            this.ContractCrystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 561);
            this.Controls.Add(this.ContractCrystalReportViewer);
            this.Name = "ContractForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contract_Form";
            this.Load += new System.EventHandler(this.ContractForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ContractCrystalReportViewer;
    }
}