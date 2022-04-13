
namespace EasyPOS.Forms.Software.RepSalesReport
{
    partial class RepCostOfSaleReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepCostOfSaleReportForm));
            this.dataGridViewCostOfSalesReport = new System.Windows.Forms.DataGridView();
            this.ColumnTerminal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSalesNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCostAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCostSellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCostProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxTotalCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPageListFirst = new System.Windows.Forms.Button();
            this.buttonPageListNext = new System.Windows.Forms.Button();
            this.buttonPageListLast = new System.Windows.Forms.Button();
            this.buttonPageListPrevious = new System.Windows.Forms.Button();
            this.textBoxPageNumber = new System.Windows.Forms.TextBox();
            this.folderBrowserDialogGenerateCSV = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxTotalProfit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCostOfSalesReport)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCostOfSalesReport
            // 
            this.dataGridViewCostOfSalesReport.AllowUserToAddRows = false;
            this.dataGridViewCostOfSalesReport.AllowUserToDeleteRows = false;
            this.dataGridViewCostOfSalesReport.AllowUserToResizeRows = false;
            this.dataGridViewCostOfSalesReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCostOfSalesReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCostOfSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCostOfSalesReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTerminal,
            this.ColumnDate,
            this.ColumnSalesNumber,
            this.ColumnBarCode,
            this.ColumnItemDescription,
            this.ColumnQuantity,
            this.ColumnCost,
            this.ColumnCostAmount,
            this.ColumnCostSellingPrice,
            this.ColumnCostProfit});
            this.dataGridViewCostOfSalesReport.Location = new System.Drawing.Point(0, 50);
            this.dataGridViewCostOfSalesReport.MultiSelect = false;
            this.dataGridViewCostOfSalesReport.Name = "dataGridViewCostOfSalesReport";
            this.dataGridViewCostOfSalesReport.ReadOnly = true;
            this.dataGridViewCostOfSalesReport.RowHeadersWidth = 51;
            this.dataGridViewCostOfSalesReport.RowTemplate.Height = 24;
            this.dataGridViewCostOfSalesReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCostOfSalesReport.ShowEditingIcon = false;
            this.dataGridViewCostOfSalesReport.Size = new System.Drawing.Size(1096, 433);
            this.dataGridViewCostOfSalesReport.TabIndex = 12;
            // 
            // ColumnTerminal
            // 
            this.ColumnTerminal.DataPropertyName = "ColumnTerminal";
            this.ColumnTerminal.HeaderText = "Terminal";
            this.ColumnTerminal.MinimumWidth = 6;
            this.ColumnTerminal.Name = "ColumnTerminal";
            this.ColumnTerminal.ReadOnly = true;
            this.ColumnTerminal.Width = 125;
            // 
            // ColumnDate
            // 
            this.ColumnDate.DataPropertyName = "ColumnDate";
            this.ColumnDate.HeaderText = "Sales Date";
            this.ColumnDate.MinimumWidth = 6;
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.ReadOnly = true;
            this.ColumnDate.Width = 120;
            // 
            // ColumnSalesNumber
            // 
            this.ColumnSalesNumber.DataPropertyName = "ColumnSalesNumber";
            this.ColumnSalesNumber.HeaderText = "Sales No.";
            this.ColumnSalesNumber.MinimumWidth = 6;
            this.ColumnSalesNumber.Name = "ColumnSalesNumber";
            this.ColumnSalesNumber.ReadOnly = true;
            this.ColumnSalesNumber.Width = 120;
            // 
            // ColumnBarCode
            // 
            this.ColumnBarCode.DataPropertyName = "ColumnBarCode";
            this.ColumnBarCode.HeaderText = "Barcode";
            this.ColumnBarCode.MinimumWidth = 6;
            this.ColumnBarCode.Name = "ColumnBarCode";
            this.ColumnBarCode.ReadOnly = true;
            this.ColumnBarCode.Width = 125;
            // 
            // ColumnItemDescription
            // 
            this.ColumnItemDescription.DataPropertyName = "ColumnItemDescription";
            this.ColumnItemDescription.HeaderText = "Item Description";
            this.ColumnItemDescription.MinimumWidth = 6;
            this.ColumnItemDescription.Name = "ColumnItemDescription";
            this.ColumnItemDescription.ReadOnly = true;
            this.ColumnItemDescription.Width = 200;
            // 
            // ColumnQuantity
            // 
            this.ColumnQuantity.DataPropertyName = "ColumnQuantity";
            this.ColumnQuantity.HeaderText = "Quantity";
            this.ColumnQuantity.MinimumWidth = 6;
            this.ColumnQuantity.Name = "ColumnQuantity";
            this.ColumnQuantity.ReadOnly = true;
            this.ColumnQuantity.Width = 120;
            // 
            // ColumnCost
            // 
            this.ColumnCost.DataPropertyName = "ColumnCost";
            this.ColumnCost.HeaderText = "Cost";
            this.ColumnCost.MinimumWidth = 6;
            this.ColumnCost.Name = "ColumnCost";
            this.ColumnCost.ReadOnly = true;
            this.ColumnCost.Width = 125;
            // 
            // ColumnCostAmount
            // 
            this.ColumnCostAmount.DataPropertyName = "ColumnCostAmount";
            this.ColumnCostAmount.HeaderText = "Cost Amount";
            this.ColumnCostAmount.MinimumWidth = 6;
            this.ColumnCostAmount.Name = "ColumnCostAmount";
            this.ColumnCostAmount.ReadOnly = true;
            this.ColumnCostAmount.Width = 125;
            // 
            // ColumnCostSellingPrice
            // 
            this.ColumnCostSellingPrice.DataPropertyName = "ColumnCostSellingPrice";
            this.ColumnCostSellingPrice.HeaderText = "Selling Price";
            this.ColumnCostSellingPrice.MinimumWidth = 6;
            this.ColumnCostSellingPrice.Name = "ColumnCostSellingPrice";
            this.ColumnCostSellingPrice.ReadOnly = true;
            this.ColumnCostSellingPrice.Width = 125;
            // 
            // ColumnCostProfit
            // 
            this.ColumnCostProfit.DataPropertyName = "ColumnCostProfit";
            this.ColumnCostProfit.HeaderText = "Profit";
            this.ColumnCostProfit.MinimumWidth = 6;
            this.ColumnCostProfit.Name = "ColumnCostProfit";
            this.ColumnCostProfit.ReadOnly = true;
            this.ColumnCostProfit.Width = 125;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1096, 50);
            this.panel2.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(79)))), ((int)(((byte)(28)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(79)))), ((int)(((byte)(28)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1014, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 32);
            this.button1.TabIndex = 6;
            this.button1.TabStop = false;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(940, 9);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 32);
            this.button2.TabIndex = 5;
            this.button2.TabStop = false;
            this.button2.Text = "CSV";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttonGenerateCSV_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EasyPOS.Properties.Resources.Reports;
            this.pictureBox2.Location = new System.Drawing.Point(11, 6);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(57, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cost of Sales Report";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.textBoxTotalProfit);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.textBoxTotalCost);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.buttonPageListFirst);
            this.panel4.Controls.Add(this.buttonPageListNext);
            this.panel4.Controls.Add(this.buttonPageListLast);
            this.panel4.Controls.Add(this.buttonPageListPrevious);
            this.panel4.Controls.Add(this.textBoxPageNumber);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 480);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1096, 42);
            this.panel4.TabIndex = 23;
            // 
            // textBoxTotalCost
            // 
            this.textBoxTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotalCost.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalCost.Location = new System.Drawing.Point(687, 10);
            this.textBoxTotalCost.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTotalCost.Name = "textBoxTotalCost";
            this.textBoxTotalCost.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxTotalCost.Size = new System.Drawing.Size(115, 23);
            this.textBoxTotalCost.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(575, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Total Cost:";
            // 
            // buttonPageListFirst
            // 
            this.buttonPageListFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPageListFirst.Enabled = false;
            this.buttonPageListFirst.FlatAppearance.BorderSize = 0;
            this.buttonPageListFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPageListFirst.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.buttonPageListFirst.Location = new System.Drawing.Point(10, 8);
            this.buttonPageListFirst.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPageListFirst.Name = "buttonPageListFirst";
            this.buttonPageListFirst.Size = new System.Drawing.Size(66, 26);
            this.buttonPageListFirst.TabIndex = 8;
            this.buttonPageListFirst.TabStop = false;
            this.buttonPageListFirst.Text = "First";
            this.buttonPageListFirst.UseVisualStyleBackColor = false;
            this.buttonPageListFirst.Click += new System.EventHandler(this.buttonSalesListPageListFirst_Click);
            // 
            // buttonPageListNext
            // 
            this.buttonPageListNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPageListNext.FlatAppearance.BorderSize = 0;
            this.buttonPageListNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPageListNext.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.buttonPageListNext.Location = new System.Drawing.Point(270, 8);
            this.buttonPageListNext.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPageListNext.Name = "buttonPageListNext";
            this.buttonPageListNext.Size = new System.Drawing.Size(66, 26);
            this.buttonPageListNext.TabIndex = 10;
            this.buttonPageListNext.TabStop = false;
            this.buttonPageListNext.Text = "Next";
            this.buttonPageListNext.UseVisualStyleBackColor = false;
            this.buttonPageListNext.Click += new System.EventHandler(this.buttonSalesListPageListNext_Click);
            // 
            // buttonPageListLast
            // 
            this.buttonPageListLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPageListLast.FlatAppearance.BorderSize = 0;
            this.buttonPageListLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPageListLast.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.buttonPageListLast.Location = new System.Drawing.Point(338, 8);
            this.buttonPageListLast.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPageListLast.Name = "buttonPageListLast";
            this.buttonPageListLast.Size = new System.Drawing.Size(66, 26);
            this.buttonPageListLast.TabIndex = 11;
            this.buttonPageListLast.TabStop = false;
            this.buttonPageListLast.Text = "Last";
            this.buttonPageListLast.UseVisualStyleBackColor = false;
            this.buttonPageListLast.Click += new System.EventHandler(this.buttonSalesListPageListLast_Click);
            // 
            // buttonPageListPrevious
            // 
            this.buttonPageListPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPageListPrevious.Enabled = false;
            this.buttonPageListPrevious.FlatAppearance.BorderSize = 0;
            this.buttonPageListPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPageListPrevious.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.buttonPageListPrevious.Location = new System.Drawing.Point(80, 8);
            this.buttonPageListPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPageListPrevious.Name = "buttonPageListPrevious";
            this.buttonPageListPrevious.Size = new System.Drawing.Size(70, 26);
            this.buttonPageListPrevious.TabIndex = 9;
            this.buttonPageListPrevious.TabStop = false;
            this.buttonPageListPrevious.Text = "Previous";
            this.buttonPageListPrevious.UseVisualStyleBackColor = false;
            this.buttonPageListPrevious.Click += new System.EventHandler(this.buttonSalesListPageListPrevious_Click);
            // 
            // textBoxPageNumber
            // 
            this.textBoxPageNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxPageNumber.BackColor = System.Drawing.Color.White;
            this.textBoxPageNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPageNumber.Location = new System.Drawing.Point(185, 12);
            this.textBoxPageNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPageNumber.Name = "textBoxPageNumber";
            this.textBoxPageNumber.ReadOnly = true;
            this.textBoxPageNumber.Size = new System.Drawing.Size(55, 23);
            this.textBoxPageNumber.TabIndex = 12;
            this.textBoxPageNumber.TabStop = false;
            this.textBoxPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxTotalProfit
            // 
            this.textBoxTotalProfit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTotalProfit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotalProfit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalProfit.Location = new System.Drawing.Point(953, 10);
            this.textBoxTotalProfit.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTotalProfit.Name = "textBoxTotalProfit";
            this.textBoxTotalProfit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxTotalProfit.Size = new System.Drawing.Size(115, 23);
            this.textBoxTotalProfit.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(841, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Total Profit:";
            // 
            // RepCostOfSaleReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 522);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewCostOfSalesReport);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RepCostOfSaleReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cost Of Sales Report";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCostOfSalesReport)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewCostOfSalesReport;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxTotalCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPageListFirst;
        private System.Windows.Forms.Button buttonPageListNext;
        private System.Windows.Forms.Button buttonPageListLast;
        private System.Windows.Forms.Button buttonPageListPrevious;
        private System.Windows.Forms.TextBox textBoxPageNumber;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogGenerateCSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTerminal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalesNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBarCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCostAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCostSellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCostProfit;
        private System.Windows.Forms.TextBox textBoxTotalProfit;
        private System.Windows.Forms.Label label1;
    }
}