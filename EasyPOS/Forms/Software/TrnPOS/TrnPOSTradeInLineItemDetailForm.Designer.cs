
namespace EasyPOS.Forms.Software.TrnPOS
{
    partial class TrnPOSTradeInLineItemDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrnPOSTradeInLineItemDetailForm));
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTradeInLineAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTradeInLineQuantity = new System.Windows.Forms.TextBox();
            this.comboBoxItemDescription = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label3.Location = new System.Drawing.Point(38, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Amount:";
            // 
            // textBoxTradeInLineAmount
            // 
            this.textBoxTradeInLineAmount.AcceptsTab = true;
            this.textBoxTradeInLineAmount.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.textBoxTradeInLineAmount.HideSelection = false;
            this.textBoxTradeInLineAmount.Location = new System.Drawing.Point(122, 188);
            this.textBoxTradeInLineAmount.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTradeInLineAmount.Name = "textBoxTradeInLineAmount";
            this.textBoxTradeInLineAmount.Size = new System.Drawing.Size(176, 30);
            this.textBoxTradeInLineAmount.TabIndex = 23;
            this.textBoxTradeInLineAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxTradeInLineAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTradeInineAmount_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label2.Location = new System.Drawing.Point(38, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Quantity:";
            // 
            // textBoxTradeInLineQuantity
            // 
            this.textBoxTradeInLineQuantity.AcceptsTab = true;
            this.textBoxTradeInLineQuantity.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.textBoxTradeInLineQuantity.HideSelection = false;
            this.textBoxTradeInLineQuantity.Location = new System.Drawing.Point(122, 142);
            this.textBoxTradeInLineQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTradeInLineQuantity.Name = "textBoxTradeInLineQuantity";
            this.textBoxTradeInLineQuantity.Size = new System.Drawing.Size(176, 30);
            this.textBoxTradeInLineQuantity.TabIndex = 21;
            this.textBoxTradeInLineQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxTradeInLineQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTradeInLineQuantity_KeyPress);
            // 
            // comboBoxItemDescription
            // 
            this.comboBoxItemDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxItemDescription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxItemDescription.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.comboBoxItemDescription.FormattingEnabled = true;
            this.comboBoxItemDescription.IntegralHeight = false;
            this.comboBoxItemDescription.ItemHeight = 23;
            this.comboBoxItemDescription.Location = new System.Drawing.Point(122, 100);
            this.comboBoxItemDescription.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxItemDescription.MaxDropDownItems = 10;
            this.comboBoxItemDescription.Name = "comboBoxItemDescription";
            this.comboBoxItemDescription.Size = new System.Drawing.Size(431, 31);
            this.comboBoxItemDescription.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label6.Location = new System.Drawing.Point(38, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "Item:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 62);
            this.panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EasyPOS.Properties.Resources.Stock_In;
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
            this.label1.Size = new System.Drawing.Size(189, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Trade - In Item";
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
            this.buttonClose.Location = new System.Drawing.Point(495, 12);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(88, 40);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(401, 12);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(88, 40);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // TrnPOSTradeInLineItemDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 263);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTradeInLineAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTradeInLineQuantity);
            this.Controls.Add(this.comboBoxItemDescription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrnPOSTradeInLineItemDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trade - In Detail Item";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTradeInLineAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTradeInLineQuantity;
        private System.Windows.Forms.ComboBox comboBoxItemDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSave;
    }
}