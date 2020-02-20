namespace StallManagementSystem
{
    partial class ContractUserControl
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
            this.activeContractBtn = new System.Windows.Forms.Button();
            this.approvalsBtn = new System.Windows.Forms.Button();
            this.contractsStatusHolderPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.terminatedBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.allContractsBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // activeContractBtn
            // 
            this.activeContractBtn.BackColor = System.Drawing.SystemColors.Control;
            this.activeContractBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.activeContractBtn.ForeColor = System.Drawing.Color.Black;
            this.activeContractBtn.Location = new System.Drawing.Point(3, 3);
            this.activeContractBtn.Name = "activeContractBtn";
            this.activeContractBtn.Size = new System.Drawing.Size(107, 25);
            this.activeContractBtn.TabIndex = 0;
            this.activeContractBtn.Text = "ACTIVE CONTRACTS";
            this.activeContractBtn.UseVisualStyleBackColor = false;
            this.activeContractBtn.Click += new System.EventHandler(this.activeContractBtn_Click);
            // 
            // approvalsBtn
            // 
            this.approvalsBtn.BackColor = System.Drawing.SystemColors.Control;
            this.approvalsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.approvalsBtn.ForeColor = System.Drawing.Color.Black;
            this.approvalsBtn.Location = new System.Drawing.Point(116, 3);
            this.approvalsBtn.Name = "approvalsBtn";
            this.approvalsBtn.Size = new System.Drawing.Size(107, 25);
            this.approvalsBtn.TabIndex = 1;
            this.approvalsBtn.Text = "APPROVALS";
            this.approvalsBtn.UseVisualStyleBackColor = false;
            this.approvalsBtn.Click += new System.EventHandler(this.approvalsBtn_Click);
            // 
            // contractsStatusHolderPanel
            // 
            this.contractsStatusHolderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contractsStatusHolderPanel.Location = new System.Drawing.Point(0, 31);
            this.contractsStatusHolderPanel.Name = "contractsStatusHolderPanel";
            this.contractsStatusHolderPanel.Size = new System.Drawing.Size(1302, 504);
            this.contractsStatusHolderPanel.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.activeContractBtn);
            this.flowLayoutPanel1.Controls.Add(this.approvalsBtn);
            this.flowLayoutPanel1.Controls.Add(this.terminatedBtn);
            this.flowLayoutPanel1.Controls.Add(this.allContractsBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1302, 31);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // terminatedBtn
            // 
            this.terminatedBtn.BackColor = System.Drawing.SystemColors.Control;
            this.terminatedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.terminatedBtn.ForeColor = System.Drawing.Color.Black;
            this.terminatedBtn.Location = new System.Drawing.Point(229, 3);
            this.terminatedBtn.Name = "terminatedBtn";
            this.terminatedBtn.Size = new System.Drawing.Size(107, 25);
            this.terminatedBtn.TabIndex = 2;
            this.terminatedBtn.Text = "TERMINATED";
            this.terminatedBtn.UseVisualStyleBackColor = false;
            this.terminatedBtn.Click += new System.EventHandler(this.terminatedBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.contractsStatusHolderPanel);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1302, 535);
            this.panel1.TabIndex = 3;
            // 
            // allContractsBtn
            // 
            this.allContractsBtn.BackColor = System.Drawing.SystemColors.Control;
            this.allContractsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.allContractsBtn.ForeColor = System.Drawing.Color.Black;
            this.allContractsBtn.Location = new System.Drawing.Point(342, 3);
            this.allContractsBtn.Name = "allContractsBtn";
            this.allContractsBtn.Size = new System.Drawing.Size(163, 25);
            this.allContractsBtn.TabIndex = 2;
            this.allContractsBtn.Text = "LIST OF ALL CONTRACTS";
            this.allContractsBtn.UseVisualStyleBackColor = false;
            this.allContractsBtn.Click += new System.EventHandler(this.allContractsBtn_Click);
            // 
            // ContractUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Name = "ContractUserControl";
            this.Size = new System.Drawing.Size(1302, 535);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button activeContractBtn;
        private System.Windows.Forms.Button approvalsBtn;
        private System.Windows.Forms.Panel contractsStatusHolderPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button terminatedBtn;
        private System.Windows.Forms.Button allContractsBtn;
    }
}
