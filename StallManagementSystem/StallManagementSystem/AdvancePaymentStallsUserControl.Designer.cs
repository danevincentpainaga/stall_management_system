namespace StallManagementSystem
{
    partial class AdvancePaymentStallsUserControl
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
            this.stallNumberflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // stallNumberflowLayoutPanel
            // 
            this.stallNumberflowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stallNumberflowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.stallNumberflowLayoutPanel.Name = "stallNumberflowLayoutPanel";
            this.stallNumberflowLayoutPanel.Size = new System.Drawing.Size(1081, 473);
            this.stallNumberflowLayoutPanel.TabIndex = 0;
            // 
            // AdvancePaymentStallsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.stallNumberflowLayoutPanel);
            this.Name = "AdvancePaymentStallsUserControl";
            this.Size = new System.Drawing.Size(1081, 473);
            this.Load += new System.EventHandler(this.AdvancePaymentStallsUserControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel stallNumberflowLayoutPanel;
    }
}
