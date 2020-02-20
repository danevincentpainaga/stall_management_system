namespace StallManagementSystem
{
    partial class ManagementUserControl
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelManagementHolder = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.userBtn = new System.Windows.Forms.Button();
            this.lesseesBtn = new System.Windows.Forms.Button();
            this.stallsBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1304, 535);
            this.panel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelManagementHolder);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1304, 535);
            this.panel1.TabIndex = 6;
            // 
            // panelManagementHolder
            // 
            this.panelManagementHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelManagementHolder.Location = new System.Drawing.Point(167, 0);
            this.panelManagementHolder.Name = "panelManagementHolder";
            this.panelManagementHolder.Size = new System.Drawing.Size(1137, 535);
            this.panelManagementHolder.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(167, 535);
            this.panel3.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.userBtn);
            this.panel6.Controls.Add(this.lesseesBtn);
            this.panel6.Controls.Add(this.stallsBtn);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 32);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(167, 503);
            this.panel6.TabIndex = 0;
            // 
            // userBtn
            // 
            this.userBtn.BackColor = System.Drawing.SystemColors.Control;
            this.userBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.userBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBtn.ForeColor = System.Drawing.Color.Black;
            this.userBtn.Location = new System.Drawing.Point(5, 122);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(156, 53);
            this.userBtn.TabIndex = 5;
            this.userBtn.Text = "Users";
            this.userBtn.UseVisualStyleBackColor = false;
            this.userBtn.Click += new System.EventHandler(this.userBtn_Click);
            // 
            // lesseesBtn
            // 
            this.lesseesBtn.BackColor = System.Drawing.SystemColors.Control;
            this.lesseesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lesseesBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lesseesBtn.ForeColor = System.Drawing.Color.Black;
            this.lesseesBtn.Location = new System.Drawing.Point(5, 4);
            this.lesseesBtn.Name = "lesseesBtn";
            this.lesseesBtn.Size = new System.Drawing.Size(156, 53);
            this.lesseesBtn.TabIndex = 5;
            this.lesseesBtn.Text = "Lessees\r\n";
            this.lesseesBtn.UseVisualStyleBackColor = false;
            this.lesseesBtn.Click += new System.EventHandler(this.lesseesBtn_Click);
            // 
            // stallsBtn
            // 
            this.stallsBtn.BackColor = System.Drawing.SystemColors.Control;
            this.stallsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stallsBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stallsBtn.ForeColor = System.Drawing.Color.Black;
            this.stallsBtn.Location = new System.Drawing.Point(5, 63);
            this.stallsBtn.Name = "stallsBtn";
            this.stallsBtn.Size = new System.Drawing.Size(156, 53);
            this.stallsBtn.TabIndex = 5;
            this.stallsBtn.Text = "Stalls";
            this.stallsBtn.UseVisualStyleBackColor = false;
            this.stallsBtn.Click += new System.EventHandler(this.stallsBtn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(167, 32);
            this.panel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGEMENT";
            // 
            // ManagementUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel2);
            this.Name = "ManagementUserControl";
            this.Size = new System.Drawing.Size(1304, 535);
            this.Load += new System.EventHandler(this.ManagementUserControl_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button userBtn;
        private System.Windows.Forms.Button stallsBtn;
        private System.Windows.Forms.Button lesseesBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelManagementHolder;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
    }
}
