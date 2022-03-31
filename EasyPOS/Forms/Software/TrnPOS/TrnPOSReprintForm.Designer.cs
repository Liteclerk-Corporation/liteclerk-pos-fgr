namespace EasyPOS.Forms.Software.TrnPOS
{
    partial class TrnPOSReprintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrnPOSReprintForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonOfficialReceipt = new System.Windows.Forms.Button();
            this.buttonDeliveryReceipt = new System.Windows.Forms.Button();
            this.buttonWithdrawalSlip = new System.Windows.Forms.Button();
            this.printDialogReprint = new System.Windows.Forms.PrintDialog();
            this.folderBrowserDialogReprint = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 62);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EasyPOS.Properties.Resources.Reports;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(62, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reprint";
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(79)))), ((int)(((byte)(28)))));
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(79)))), ((int)(((byte)(28)))));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(282, 12);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(136, 40);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.TabStop = false;
            this.buttonClose.Text = "Esc - Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonOfficialReceipt
            // 
            this.buttonOfficialReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOfficialReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonOfficialReceipt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonOfficialReceipt.FlatAppearance.BorderSize = 0;
            this.buttonOfficialReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOfficialReceipt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOfficialReceipt.ForeColor = System.Drawing.Color.White;
            this.buttonOfficialReceipt.Location = new System.Drawing.Point(12, 69);
            this.buttonOfficialReceipt.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOfficialReceipt.Name = "buttonOfficialReceipt";
            this.buttonOfficialReceipt.Size = new System.Drawing.Size(406, 40);
            this.buttonOfficialReceipt.TabIndex = 1;
            this.buttonOfficialReceipt.TabStop = false;
            this.buttonOfficialReceipt.Text = "F2 - Official Receipt";
            this.buttonOfficialReceipt.UseVisualStyleBackColor = false;
            this.buttonOfficialReceipt.Click += new System.EventHandler(this.buttonOfficialReceipt_Click);
            // 
            // buttonDeliveryReceipt
            // 
            this.buttonDeliveryReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeliveryReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonDeliveryReceipt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonDeliveryReceipt.FlatAppearance.BorderSize = 0;
            this.buttonDeliveryReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeliveryReceipt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeliveryReceipt.ForeColor = System.Drawing.Color.White;
            this.buttonDeliveryReceipt.Location = new System.Drawing.Point(12, 114);
            this.buttonDeliveryReceipt.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeliveryReceipt.Name = "buttonDeliveryReceipt";
            this.buttonDeliveryReceipt.Size = new System.Drawing.Size(406, 40);
            this.buttonDeliveryReceipt.TabIndex = 6;
            this.buttonDeliveryReceipt.TabStop = false;
            this.buttonDeliveryReceipt.Text = "F3 - Delivery Receipt";
            this.buttonDeliveryReceipt.UseVisualStyleBackColor = false;
            this.buttonDeliveryReceipt.Click += new System.EventHandler(this.buttonDeliveryReceipt_Click);
            // 
            // buttonWithdrawalSlip
            // 
            this.buttonWithdrawalSlip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWithdrawalSlip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonWithdrawalSlip.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonWithdrawalSlip.FlatAppearance.BorderSize = 0;
            this.buttonWithdrawalSlip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWithdrawalSlip.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWithdrawalSlip.ForeColor = System.Drawing.Color.White;
            this.buttonWithdrawalSlip.Location = new System.Drawing.Point(12, 160);
            this.buttonWithdrawalSlip.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWithdrawalSlip.Name = "buttonWithdrawalSlip";
            this.buttonWithdrawalSlip.Size = new System.Drawing.Size(406, 40);
            this.buttonWithdrawalSlip.TabIndex = 7;
            this.buttonWithdrawalSlip.TabStop = false;
            this.buttonWithdrawalSlip.Text = "F4 - Withdrawal Slip";
            this.buttonWithdrawalSlip.UseVisualStyleBackColor = false;
            this.buttonWithdrawalSlip.Click += new System.EventHandler(this.buttonWithdrawalSlip_Click);
            // 
            // printDialogReprint
            // 
            this.printDialogReprint.UseEXDialog = true;
            // 
            // TrnPOSReprintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(430, 209);
            this.Controls.Add(this.buttonWithdrawalSlip);
            this.Controls.Add(this.buttonDeliveryReceipt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonOfficialReceipt);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.Name = "TrnPOSReprintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reprint";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonOfficialReceipt;
        private System.Windows.Forms.Button buttonDeliveryReceipt;
        private System.Windows.Forms.Button buttonWithdrawalSlip;
        private System.Windows.Forms.PrintDialog printDialogReprint;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogReprint;
    }
}