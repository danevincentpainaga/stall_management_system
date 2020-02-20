namespace StallManagementSystem
{
    partial class ParentPaymentsUserControl
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.advancePaymentBtn = new System.Windows.Forms.Button();
            this.duePaymentBtn = new System.Windows.Forms.Button();
            this.ambulantBtn = new System.Windows.Forms.Button();
            this.paymentPanelHolder = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.advancePaymentBtn);
            this.flowLayoutPanel1.Controls.Add(this.duePaymentBtn);
            this.flowLayoutPanel1.Controls.Add(this.ambulantBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1304, 33);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // advancePaymentBtn
            // 
            this.advancePaymentBtn.BackColor = System.Drawing.SystemColors.Control;
            this.advancePaymentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.advancePaymentBtn.ForeColor = System.Drawing.Color.Black;
            this.advancePaymentBtn.Location = new System.Drawing.Point(3, 3);
            this.advancePaymentBtn.Name = "advancePaymentBtn";
            this.advancePaymentBtn.Size = new System.Drawing.Size(130, 25);
            this.advancePaymentBtn.TabIndex = 0;
            this.advancePaymentBtn.Text = "ADVANCE PAYMENT";
            this.advancePaymentBtn.UseVisualStyleBackColor = false;
            this.advancePaymentBtn.Click += new System.EventHandler(this.advancePaymentBtn_Click);
            // 
            // duePaymentBtn
            // 
            this.duePaymentBtn.BackColor = System.Drawing.SystemColors.Control;
            this.duePaymentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.duePaymentBtn.ForeColor = System.Drawing.Color.Black;
            this.duePaymentBtn.Location = new System.Drawing.Point(139, 3);
            this.duePaymentBtn.Name = "duePaymentBtn";
            this.duePaymentBtn.Size = new System.Drawing.Size(130, 25);
            this.duePaymentBtn.TabIndex = 1;
            this.duePaymentBtn.Text = "DUE PAYMENTS";
            this.duePaymentBtn.UseVisualStyleBackColor = false;
            this.duePaymentBtn.Click += new System.EventHandler(this.duePaymentBtn_Click);
            // 
            // ambulantBtn
            // 
            this.ambulantBtn.BackColor = System.Drawing.SystemColors.Control;
            this.ambulantBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ambulantBtn.ForeColor = System.Drawing.Color.Black;
            this.ambulantBtn.Location = new System.Drawing.Point(275, 3);
            this.ambulantBtn.Name = "ambulantBtn";
            this.ambulantBtn.Size = new System.Drawing.Size(130, 25);
            this.ambulantBtn.TabIndex = 2;
            this.ambulantBtn.Text = "AMBULANT";
            this.ambulantBtn.UseVisualStyleBackColor = false;
            this.ambulantBtn.Click += new System.EventHandler(this.ambulantBtn_Click);
            // 
            // paymentPanelHolder
            // 
            this.paymentPanelHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentPanelHolder.Location = new System.Drawing.Point(0, 33);
            this.paymentPanelHolder.Name = "paymentPanelHolder";
            this.paymentPanelHolder.Size = new System.Drawing.Size(1304, 502);
            this.paymentPanelHolder.TabIndex = 1;
            // 
            // ParentPaymentsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.paymentPanelHolder);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ParentPaymentsUserControl";
            this.Size = new System.Drawing.Size(1304, 535);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button advancePaymentBtn;
        private System.Windows.Forms.Panel paymentPanelHolder;
        private System.Windows.Forms.Button duePaymentBtn;
        private System.Windows.Forms.Button ambulantBtn;
    }
}
