namespace StallManagementSystem
{
    partial class ClearanceViewerForm
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
            this.ClearanceCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ClearanceCrystalReportViewer
            // 
            this.ClearanceCrystalReportViewer.ActiveViewIndex = -1;
            this.ClearanceCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClearanceCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ClearanceCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClearanceCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.ClearanceCrystalReportViewer.Name = "ClearanceCrystalReportViewer";
            this.ClearanceCrystalReportViewer.ShowGroupTreeButton = false;
            this.ClearanceCrystalReportViewer.ShowRefreshButton = false;
            this.ClearanceCrystalReportViewer.ShowTextSearchButton = false;
            this.ClearanceCrystalReportViewer.Size = new System.Drawing.Size(963, 599);
            this.ClearanceCrystalReportViewer.TabIndex = 0;
            this.ClearanceCrystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ClearanceViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 599);
            this.Controls.Add(this.ClearanceCrystalReportViewer);
            this.Name = "ClearanceViewerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClearanceViewerForm";
            this.Load += new System.EventHandler(this.ClearanceViewerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ClearanceCrystalReportViewer;
    }
}