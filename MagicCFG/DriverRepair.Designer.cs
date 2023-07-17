namespace MagicCFG
{
    partial class DriverRepair
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
            this.portBtn = new Guna.UI2.WinForms.Guna2Button();
            this.RepairDFU = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // portBtn
            // 
            this.portBtn.BorderRadius = 10;
            this.portBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.portBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.portBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.portBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.portBtn.FillColor = System.Drawing.Color.Silver;
            this.portBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.portBtn.ForeColor = System.Drawing.Color.White;
            this.portBtn.Location = new System.Drawing.Point(12, 42);
            this.portBtn.Name = "portBtn";
            this.portBtn.Size = new System.Drawing.Size(270, 41);
            this.portBtn.TabIndex = 0;
            this.portBtn.Text = "Repair Port Driver";
            this.portBtn.Click += new System.EventHandler(this.portBtn_Click);
            // 
            // RepairDFU
            // 
            this.RepairDFU.BorderRadius = 10;
            this.RepairDFU.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RepairDFU.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RepairDFU.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RepairDFU.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RepairDFU.FillColor = System.Drawing.Color.Silver;
            this.RepairDFU.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RepairDFU.ForeColor = System.Drawing.Color.White;
            this.RepairDFU.Location = new System.Drawing.Point(12, 89);
            this.RepairDFU.Name = "RepairDFU";
            this.RepairDFU.Size = new System.Drawing.Size(270, 41);
            this.RepairDFU.TabIndex = 1;
            this.RepairDFU.Text = "Repair DFU Driver";
            this.RepairDFU.Click += new System.EventHandler(this.RepairDFU_Click);
            // 
            // DriverRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 197);
            this.Controls.Add(this.RepairDFU);
            this.Controls.Add(this.portBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DriverRepair";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DriverRepair";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button portBtn;
        private Guna.UI2.WinForms.Guna2Button RepairDFU;
    }
}