namespace StallManagementSystem
{
    partial class ApplicationUserControl
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.applicationHolderPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1354, 540);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.applicationHolderPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1354, 540);
            this.panel2.TabIndex = 0;
            // 
            // applicationHolderPanel
            // 
            this.applicationHolderPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.applicationHolderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.applicationHolderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.applicationHolderPanel.Location = new System.Drawing.Point(0, 0);
            this.applicationHolderPanel.Name = "applicationHolderPanel";
            this.applicationHolderPanel.Size = new System.Drawing.Size(1354, 540);
            this.applicationHolderPanel.TabIndex = 1;
            // 
            // ApplicationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ApplicationUserControl";
            this.Size = new System.Drawing.Size(1354, 540);
            this.Load += new System.EventHandler(this.ApplicationUserControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel applicationHolderPanel;
    }
}
