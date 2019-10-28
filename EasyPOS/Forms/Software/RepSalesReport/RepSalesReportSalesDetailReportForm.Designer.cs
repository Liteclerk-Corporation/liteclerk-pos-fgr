﻿namespace EasyPOS.Forms.Software.RepSalesReport
{
    partial class RepSalesReportSalesDetailReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepSalesReportSalesDetailReportForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewSalesDetailReport = new System.Windows.Forms.DataGridView();
            this.ColumnTerminal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSalesNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnItemCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDiscountRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDiscountAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNetPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTaxRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTaxAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonView = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxTotalAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPageListFirst = new System.Windows.Forms.Button();
            this.buttonPageListNext = new System.Windows.Forms.Button();
            this.buttonPageListLast = new System.Windows.Forms.Button();
            this.buttonPageListPrevious = new System.Windows.Forms.Button();
            this.textBoxPageNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesDetailReport)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EasyPOS.Properties.Resources.Reports;
            this.pictureBox1.Location = new System.Drawing.Point(14, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewSalesDetailReport
            // 
            this.dataGridViewSalesDetailReport.AllowUserToAddRows = false;
            this.dataGridViewSalesDetailReport.AllowUserToDeleteRows = false;
            this.dataGridViewSalesDetailReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSalesDetailReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSalesDetailReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalesDetailReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTerminal,
            this.ColumnDate,
            this.ColumnSalesNumber,
            this.ColumnCustomer,
            this.ColumnItemDescription,
            this.ColumnItemCode,
            this.ColumnItemCategory,
            this.ColumnUnit,
            this.ColumnPrice,
            this.ColumnDiscount,
            this.ColumnDiscountRate,
            this.ColumnDiscountAmount,
            this.ColumnNetPrice,
            this.ColumnQuantity,
            this.ColumnAmount,
            this.ColumnTax,
            this.ColumnTaxRate,
            this.ColumnTaxAmount,
            this.ColumnUser,
            this.ColumnTimeStamp});
            this.dataGridViewSalesDetailReport.Location = new System.Drawing.Point(0, 63);
            this.dataGridViewSalesDetailReport.Name = "dataGridViewSalesDetailReport";
            this.dataGridViewSalesDetailReport.ReadOnly = true;
            this.dataGridViewSalesDetailReport.RowHeadersVisible = false;
            this.dataGridViewSalesDetailReport.RowTemplate.Height = 24;
            this.dataGridViewSalesDetailReport.ShowEditingIcon = false;
            this.dataGridViewSalesDetailReport.Size = new System.Drawing.Size(1479, 610);
            this.dataGridViewSalesDetailReport.TabIndex = 0;
            // 
            // ColumnTerminal
            // 
            this.ColumnTerminal.DataPropertyName = "ColumnTerminal";
            this.ColumnTerminal.HeaderText = "Terminal";
            this.ColumnTerminal.Name = "ColumnTerminal";
            this.ColumnTerminal.ReadOnly = true;
            // 
            // ColumnDate
            // 
            this.ColumnDate.DataPropertyName = "ColumnDate";
            this.ColumnDate.HeaderText = "Date";
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.ReadOnly = true;
            // 
            // ColumnSalesNumber
            // 
            this.ColumnSalesNumber.DataPropertyName = "ColumnSalesNumber";
            this.ColumnSalesNumber.HeaderText = "SalesNumber";
            this.ColumnSalesNumber.Name = "ColumnSalesNumber";
            this.ColumnSalesNumber.ReadOnly = true;
            // 
            // ColumnCustomer
            // 
            this.ColumnCustomer.DataPropertyName = "ColumnCustomer";
            this.ColumnCustomer.HeaderText = "Customer";
            this.ColumnCustomer.Name = "ColumnCustomer";
            this.ColumnCustomer.ReadOnly = true;
            // 
            // ColumnItemDescription
            // 
            this.ColumnItemDescription.DataPropertyName = "ColumnItemDescription";
            this.ColumnItemDescription.HeaderText = "ItemDescription";
            this.ColumnItemDescription.Name = "ColumnItemDescription";
            this.ColumnItemDescription.ReadOnly = true;
            // 
            // ColumnItemCode
            // 
            this.ColumnItemCode.DataPropertyName = "ColumnItemCode";
            this.ColumnItemCode.HeaderText = "ItemCode";
            this.ColumnItemCode.Name = "ColumnItemCode";
            this.ColumnItemCode.ReadOnly = true;
            // 
            // ColumnItemCategory
            // 
            this.ColumnItemCategory.DataPropertyName = "ColumnItemCategory";
            this.ColumnItemCategory.HeaderText = "ItemCategory";
            this.ColumnItemCategory.Name = "ColumnItemCategory";
            this.ColumnItemCategory.ReadOnly = true;
            // 
            // ColumnUnit
            // 
            this.ColumnUnit.DataPropertyName = "ColumnUnit";
            this.ColumnUnit.HeaderText = "Unit";
            this.ColumnUnit.Name = "ColumnUnit";
            this.ColumnUnit.ReadOnly = true;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.DataPropertyName = "ColumnPrice";
            this.ColumnPrice.HeaderText = "Price";
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.ReadOnly = true;
            // 
            // ColumnDiscount
            // 
            this.ColumnDiscount.DataPropertyName = "ColumnDiscount";
            this.ColumnDiscount.HeaderText = "Discount";
            this.ColumnDiscount.Name = "ColumnDiscount";
            this.ColumnDiscount.ReadOnly = true;
            // 
            // ColumnDiscountRate
            // 
            this.ColumnDiscountRate.DataPropertyName = "ColumnDiscountRate";
            this.ColumnDiscountRate.HeaderText = "DiscountRate";
            this.ColumnDiscountRate.Name = "ColumnDiscountRate";
            this.ColumnDiscountRate.ReadOnly = true;
            // 
            // ColumnDiscountAmount
            // 
            this.ColumnDiscountAmount.DataPropertyName = "ColumnDiscountAmount";
            this.ColumnDiscountAmount.HeaderText = "DiscountAmount";
            this.ColumnDiscountAmount.Name = "ColumnDiscountAmount";
            this.ColumnDiscountAmount.ReadOnly = true;
            // 
            // ColumnNetPrice
            // 
            this.ColumnNetPrice.DataPropertyName = "ColumnNetPrice";
            this.ColumnNetPrice.HeaderText = "NetPrice";
            this.ColumnNetPrice.Name = "ColumnNetPrice";
            this.ColumnNetPrice.ReadOnly = true;
            // 
            // ColumnQuantity
            // 
            this.ColumnQuantity.DataPropertyName = "ColumnQuantity";
            this.ColumnQuantity.HeaderText = "Quantity";
            this.ColumnQuantity.Name = "ColumnQuantity";
            this.ColumnQuantity.ReadOnly = true;
            // 
            // ColumnAmount
            // 
            this.ColumnAmount.DataPropertyName = "ColumnAmount";
            this.ColumnAmount.HeaderText = "Amount";
            this.ColumnAmount.Name = "ColumnAmount";
            this.ColumnAmount.ReadOnly = true;
            // 
            // ColumnTax
            // 
            this.ColumnTax.DataPropertyName = "ColumnTax";
            this.ColumnTax.HeaderText = "Tax";
            this.ColumnTax.Name = "ColumnTax";
            this.ColumnTax.ReadOnly = true;
            // 
            // ColumnTaxRate
            // 
            this.ColumnTaxRate.DataPropertyName = "ColumnTaxRate";
            this.ColumnTaxRate.HeaderText = "TaxRate";
            this.ColumnTaxRate.Name = "ColumnTaxRate";
            this.ColumnTaxRate.ReadOnly = true;
            // 
            // ColumnTaxAmount
            // 
            this.ColumnTaxAmount.DataPropertyName = "ColumnTaxAmount";
            this.ColumnTaxAmount.HeaderText = "TaxAmount";
            this.ColumnTaxAmount.Name = "ColumnTaxAmount";
            this.ColumnTaxAmount.ReadOnly = true;
            // 
            // ColumnUser
            // 
            this.ColumnUser.DataPropertyName = "ColumnUser";
            this.ColumnUser.HeaderText = "User";
            this.ColumnUser.Name = "ColumnUser";
            this.ColumnUser.ReadOnly = true;
            // 
            // ColumnTimeStamp
            // 
            this.ColumnTimeStamp.DataPropertyName = "ColumnTimeStamp";
            this.ColumnTimeStamp.HeaderText = "TimeStamp";
            this.ColumnTimeStamp.Name = "ColumnTimeStamp";
            this.ColumnTimeStamp.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonView);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1482, 63);
            this.panel1.TabIndex = 10;
            // 
            // buttonView
            // 
            this.buttonView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonView.FlatAppearance.BorderSize = 0;
            this.buttonView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonView.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonView.ForeColor = System.Drawing.Color.White;
            this.buttonView.Location = new System.Drawing.Point(1287, 11);
            this.buttonView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(88, 40);
            this.buttonView.TabIndex = 5;
            this.buttonView.TabStop = false;
            this.buttonView.Text = "CSV";
            this.buttonView.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(71, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sales Detail Report";
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
            this.buttonClose.Location = new System.Drawing.Point(1381, 11);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(88, 40);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_OnClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.dataGridViewSalesDetailReport);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1482, 732);
            this.panel2.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.textBoxTotalAmount);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.buttonPageListFirst);
            this.panel4.Controls.Add(this.buttonPageListNext);
            this.panel4.Controls.Add(this.buttonPageListLast);
            this.panel4.Controls.Add(this.buttonPageListPrevious);
            this.panel4.Controls.Add(this.textBoxPageNumber);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 679);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1482, 53);
            this.panel4.TabIndex = 20;
            // 
            // textBoxTotalAmount
            // 
            this.textBoxTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotalAmount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalAmount.Location = new System.Drawing.Point(1112, 14);
            this.textBoxTotalAmount.Name = "textBoxTotalAmount";
            this.textBoxTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxTotalAmount.Size = new System.Drawing.Size(308, 23);
            this.textBoxTotalAmount.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(973, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Total Amount:";
            // 
            // buttonPageListFirst
            // 
            this.buttonPageListFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPageListFirst.Enabled = false;
            this.buttonPageListFirst.FlatAppearance.BorderSize = 0;
            this.buttonPageListFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPageListFirst.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.buttonPageListFirst.Location = new System.Drawing.Point(12, 9);
            this.buttonPageListFirst.Name = "buttonPageListFirst";
            this.buttonPageListFirst.Size = new System.Drawing.Size(82, 32);
            this.buttonPageListFirst.TabIndex = 8;
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
            this.buttonPageListNext.Location = new System.Drawing.Point(263, 9);
            this.buttonPageListNext.Name = "buttonPageListNext";
            this.buttonPageListNext.Size = new System.Drawing.Size(82, 32);
            this.buttonPageListNext.TabIndex = 10;
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
            this.buttonPageListLast.Location = new System.Drawing.Point(348, 9);
            this.buttonPageListLast.Name = "buttonPageListLast";
            this.buttonPageListLast.Size = new System.Drawing.Size(82, 32);
            this.buttonPageListLast.TabIndex = 11;
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
            this.buttonPageListPrevious.Location = new System.Drawing.Point(100, 9);
            this.buttonPageListPrevious.Name = "buttonPageListPrevious";
            this.buttonPageListPrevious.Size = new System.Drawing.Size(82, 32);
            this.buttonPageListPrevious.TabIndex = 9;
            this.buttonPageListPrevious.Text = "Previous";
            this.buttonPageListPrevious.UseVisualStyleBackColor = false;
            this.buttonPageListPrevious.Click += new System.EventHandler(this.buttonSalesListPageListPrevious_Click);
            // 
            // textBoxPageNumber
            // 
            this.textBoxPageNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxPageNumber.BackColor = System.Drawing.Color.White;
            this.textBoxPageNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPageNumber.Location = new System.Drawing.Point(188, 14);
            this.textBoxPageNumber.Name = "textBoxPageNumber";
            this.textBoxPageNumber.ReadOnly = true;
            this.textBoxPageNumber.Size = new System.Drawing.Size(69, 23);
            this.textBoxPageNumber.TabIndex = 12;
            this.textBoxPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RepSalesReportSalesDetailReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1482, 732);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RepSalesReportSalesDetailReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Detail Report";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesDetailReport)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewSalesDetailReport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxTotalAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPageListFirst;
        private System.Windows.Forms.Button buttonPageListNext;
        private System.Windows.Forms.Button buttonPageListLast;
        private System.Windows.Forms.Button buttonPageListPrevious;
        private System.Windows.Forms.TextBox textBoxPageNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTerminal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalesNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiscountRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiscountAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNetPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTaxRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTaxAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTimeStamp;
        private System.Windows.Forms.Button buttonClose;
    }
}