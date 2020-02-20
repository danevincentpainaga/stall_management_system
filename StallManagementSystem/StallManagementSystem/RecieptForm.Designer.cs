namespace StallManagementSystem
{
    partial class RecieptForm
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
            this.recieptcrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // recieptcrystalReportViewer
            // 
            this.recieptcrystalReportViewer.ActiveViewIndex = -1;
            this.recieptcrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.recieptcrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.recieptcrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recieptcrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.recieptcrystalReportViewer.Name = "recieptcrystalReportViewer";
            this.recieptcrystalReportViewer.Size = new System.Drawing.Size(457, 595);
            this.recieptcrystalReportViewer.TabIndex = 0;
            this.recieptcrystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // RecieptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 595);
            this.Controls.Add(this.recieptcrystalReportViewer);
            this.Name = "RecieptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecieptForm";
            this.Load += new System.EventHandler(this.RecieptForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer recieptcrystalReportViewer;
    }
}