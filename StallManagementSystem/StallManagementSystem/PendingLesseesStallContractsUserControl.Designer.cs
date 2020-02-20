namespace StallManagementSystem
{
    partial class PendingLesseesStallContractsUserControl
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
            this.stallNumberDetailsHolderPanel = new System.Windows.Forms.Panel();
            this.stallNumberPanel = new System.Windows.Forms.Panel();
            this.stallNumberflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.stallNumberDetailsHolderPanel.SuspendLayout();
            this.stallNumberPanel.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // stallNumberDetailsHolderPanel
            // 
            this.stallNumberDetailsHolderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stallNumberDetailsHolderPanel.Controls.Add(this.stallNumberPanel);
            this.stallNumberDetailsHolderPanel.Controls.Add(this.panel11);
            this.stallNumberDetailsHolderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stallNumberDetailsHolderPanel.Location = new System.Drawing.Point(0, 0);
            this.stallNumberDetailsHolderPanel.Name = "stallNumberDetailsHolderPanel";
            this.stallNumberDetailsHolderPanel.Padding = new System.Windows.Forms.Padding(5);
            this.stallNumberDetailsHolderPanel.Size = new System.Drawing.Size(1081, 511);
            this.stallNumberDetailsHolderPanel.TabIndex = 4;
            // 
            // stallNumberPanel
            // 
            this.stallNumberPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stallNumberPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stallNumberPanel.Controls.Add(this.stallNumberflowLayoutPanel);
            this.stallNumberPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stallNumberPanel.Location = new System.Drawing.Point(5, 48);
            this.stallNumberPanel.Name = "stallNumberPanel";
            this.stallNumberPanel.Size = new System.Drawing.Size(1069, 456);
            this.stallNumberPanel.TabIndex = 1;
            // 
            // stallNumberflowLayoutPanel
            // 
            this.stallNumberflowLayoutPanel.AutoScroll = true;
            this.stallNumberflowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stallNumberflowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.stallNumberflowLayoutPanel.Name = "stallNumberflowLayoutPanel";
            this.stallNumberflowLayoutPanel.Size = new System.Drawing.Size(1067, 454);
            this.stallNumberflowLayoutPanel.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.DarkCyan;
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.label4);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(5, 5);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1069, 43);
            this.panel11.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Requested Stalls";
            // 
            // PendingLesseesStallContractsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.stallNumberDetailsHolderPanel);
            this.Name = "PendingLesseesStallContractsUserControl";
            this.Size = new System.Drawing.Size(1081, 511);
            this.Load += new System.EventHandler(this.PendingLesseesStallContractsUserControl_Load);
            this.stallNumberDetailsHolderPanel.ResumeLayout(false);
            this.stallNumberPanel.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel stallNumberDetailsHolderPanel;
        private System.Windows.Forms.Panel stallNumberPanel;
        private System.Windows.Forms.FlowLayoutPanel stallNumberflowLayoutPanel;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label4;
    }
}
