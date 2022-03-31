namespace EasyPOS.Forms.Software.TrnPOS
{
    partial class TrnPOSTenderEasypayInformationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrnPOSTenderEasypayInformationForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonPay = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBoxTappedCardNumber = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelConnectionStatus = new System.Windows.Forms.Label();
            this.textBoxEndingBalance = new System.Windows.Forms.TextBox();
            this.textBoxAmountCharge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBeginningBalance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCustomer = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxTotalSalesAmount = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.buttonPay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 62);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EasyPOS.Properties.Resources.POS;
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
            this.label1.Size = new System.Drawing.Size(255, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Easypay Information";
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
            this.buttonClose.Location = new System.Drawing.Point(558, 12);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(136, 40);
            this.buttonClose.TabIndex = 21;
            this.buttonClose.TabStop = false;
            this.buttonClose.Text = "Esc - Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonPay
            // 
            this.buttonPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonPay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonPay.FlatAppearance.BorderSize = 0;
            this.buttonPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPay.ForeColor = System.Drawing.Color.White;
            this.buttonPay.Location = new System.Drawing.Point(412, 12);
            this.buttonPay.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(140, 40);
            this.buttonPay.TabIndex = 20;
            this.buttonPay.TabStop = false;
            this.buttonPay.Text = "Ent - Pay";
            this.buttonPay.UseVisualStyleBackColor = false;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.textBoxEndingBalance);
            this.panel2.Controls.Add(this.textBoxAmountCharge);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBoxBeginningBalance);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxCustomer);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(706, 377);
            this.panel2.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.textBoxTappedCardNumber);
            this.panel5.Location = new System.Drawing.Point(0, 89);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(706, 48);
            this.panel5.TabIndex = 41;
            // 
            // textBoxTappedCardNumber
            // 
            this.textBoxTappedCardNumber.BackColor = System.Drawing.Color.White;
            this.textBoxTappedCardNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTappedCardNumber.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxTappedCardNumber.Location = new System.Drawing.Point(12, 10);
            this.textBoxTappedCardNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTappedCardNumber.Name = "textBoxTappedCardNumber";
            this.textBoxTappedCardNumber.PasswordChar = '•';
            this.textBoxTappedCardNumber.Size = new System.Drawing.Size(581, 27);
            this.textBoxTappedCardNumber.TabIndex = 0;
            this.textBoxTappedCardNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTappedCardNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTappedCardAmount_KeyDown);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.labelConnectionStatus);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 312);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(706, 65);
            this.panel4.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Connection Status:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EasyPOS.Properties.Resources.easypay;
            this.pictureBox2.Location = new System.Drawing.Point(584, 8);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(110, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // labelConnectionStatus
            // 
            this.labelConnectionStatus.AutoSize = true;
            this.labelConnectionStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelConnectionStatus.ForeColor = System.Drawing.Color.Lime;
            this.labelConnectionStatus.Location = new System.Drawing.Point(8, 31);
            this.labelConnectionStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelConnectionStatus.Name = "labelConnectionStatus";
            this.labelConnectionStatus.Size = new System.Drawing.Size(93, 23);
            this.labelConnectionStatus.TabIndex = 0;
            this.labelConnectionStatus.Text = "Connected";
            // 
            // textBoxEndingBalance
            // 
            this.textBoxEndingBalance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxEndingBalance.Location = new System.Drawing.Point(188, 265);
            this.textBoxEndingBalance.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEndingBalance.Name = "textBoxEndingBalance";
            this.textBoxEndingBalance.ReadOnly = true;
            this.textBoxEndingBalance.Size = new System.Drawing.Size(505, 34);
            this.textBoxEndingBalance.TabIndex = 39;
            this.textBoxEndingBalance.TabStop = false;
            this.textBoxEndingBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxAmountCharge
            // 
            this.textBoxAmountCharge.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxAmountCharge.Location = new System.Drawing.Point(188, 225);
            this.textBoxAmountCharge.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAmountCharge.Name = "textBoxAmountCharge";
            this.textBoxAmountCharge.ReadOnly = true;
            this.textBoxAmountCharge.Size = new System.Drawing.Size(505, 34);
            this.textBoxAmountCharge.TabIndex = 38;
            this.textBoxAmountCharge.TabStop = false;
            this.textBoxAmountCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(34, 269);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 28);
            this.label4.TabIndex = 37;
            this.label4.Text = "Ending Balance:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(28, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 28);
            this.label3.TabIndex = 36;
            this.label3.Text = "Amount Charge:";
            // 
            // textBoxBeginningBalance
            // 
            this.textBoxBeginningBalance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxBeginningBalance.Location = new System.Drawing.Point(188, 185);
            this.textBoxBeginningBalance.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBeginningBalance.Name = "textBoxBeginningBalance";
            this.textBoxBeginningBalance.ReadOnly = true;
            this.textBoxBeginningBalance.Size = new System.Drawing.Size(505, 34);
            this.textBoxBeginningBalance.TabIndex = 35;
            this.textBoxBeginningBalance.TabStop = false;
            this.textBoxBeginningBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(8, 189);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 28);
            this.label2.TabIndex = 34;
            this.label2.Text = "Beginning Balance:";
            // 
            // textBoxCustomer
            // 
            this.textBoxCustomer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxCustomer.Location = new System.Drawing.Point(188, 145);
            this.textBoxCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCustomer.Name = "textBoxCustomer";
            this.textBoxCustomer.ReadOnly = true;
            this.textBoxCustomer.Size = new System.Drawing.Size(505, 34);
            this.textBoxCustomer.TabIndex = 33;
            this.textBoxCustomer.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label13.Location = new System.Drawing.Point(82, 149);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 28);
            this.label13.TabIndex = 32;
            this.label13.Text = "Customer:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.textBoxTotalSalesAmount);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(706, 82);
            this.panel3.TabIndex = 8;
            // 
            // textBoxTotalSalesAmount
            // 
            this.textBoxTotalSalesAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTotalSalesAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxTotalSalesAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotalSalesAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Bold);
            this.textBoxTotalSalesAmount.ForeColor = System.Drawing.Color.White;
            this.textBoxTotalSalesAmount.Location = new System.Drawing.Point(89, 6);
            this.textBoxTotalSalesAmount.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTotalSalesAmount.Name = "textBoxTotalSalesAmount";
            this.textBoxTotalSalesAmount.ReadOnly = true;
            this.textBoxTotalSalesAmount.Size = new System.Drawing.Size(606, 67);
            this.textBoxTotalSalesAmount.TabIndex = 1;
            this.textBoxTotalSalesAmount.TabStop = false;
            this.textBoxTotalSalesAmount.Text = "0.00";
            this.textBoxTotalSalesAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TrnPOSTenderEasypayInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(706, 439);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "TrnPOSTenderEasypayInformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easypay Information";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxTotalSalesAmount;
        private System.Windows.Forms.TextBox textBoxEndingBalance;
        private System.Windows.Forms.TextBox textBoxAmountCharge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBeginningBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCustomer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelConnectionStatus;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBoxTappedCardNumber;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
    }
}