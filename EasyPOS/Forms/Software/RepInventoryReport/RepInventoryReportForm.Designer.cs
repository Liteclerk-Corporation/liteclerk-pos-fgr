﻿namespace EasyPOS.Forms.Software.RepInventoryReport
{
    partial class RepInventoryReportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepInventoryReportForm));
            this.buttonPageListNext = new System.Windows.Forms.Button();
            this.buttonPageListPrevious = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxTotalAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPageListFirst = new System.Windows.Forms.Button();
            this.buttonPageListLast = new System.Windows.Forms.Button();
            this.textBoxPageNumber = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.dataGridViewInventoryReport = new System.Windows.Forms.DataGridView();
            this.buttonGenerateCSV = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.folderBrowserDialogGenerateCSV = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTotalSellingAmount = new System.Windows.Forms.TextBox();
            this.ColumnItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBegQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOutQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEndingQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStockCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVariance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSellingAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventoryReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPageListNext
            // 
            this.buttonPageListNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPageListNext.FlatAppearance.BorderSize = 0;
            this.buttonPageListNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPageListNext.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.buttonPageListNext.Location = new System.Drawing.Point(247, 7);
            this.buttonPageListNext.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPageListNext.Name = "buttonPageListNext";
            this.buttonPageListNext.Size = new System.Drawing.Size(66, 26);
            this.buttonPageListNext.TabIndex = 10;
            this.buttonPageListNext.Text = "Next";
            this.buttonPageListNext.UseVisualStyleBackColor = false;
            this.buttonPageListNext.Click += new System.EventHandler(this.buttonPageListNext_Click);
            // 
            // buttonPageListPrevious
            // 
            this.buttonPageListPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPageListPrevious.Enabled = false;
            this.buttonPageListPrevious.FlatAppearance.BorderSize = 0;
            this.buttonPageListPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPageListPrevious.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.buttonPageListPrevious.Location = new System.Drawing.Point(68, 7);
            this.buttonPageListPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPageListPrevious.Name = "buttonPageListPrevious";
            this.buttonPageListPrevious.Size = new System.Drawing.Size(76, 26);
            this.buttonPageListPrevious.TabIndex = 9;
            this.buttonPageListPrevious.Text = "Previous";
            this.buttonPageListPrevious.UseVisualStyleBackColor = false;
            this.buttonPageListPrevious.Click += new System.EventHandler(this.buttonPageListPrevious_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.textBoxTotalSellingAmount);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.textBoxTotalAmount);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.buttonPageListFirst);
            this.panel4.Controls.Add(this.buttonPageListNext);
            this.panel4.Controls.Add(this.buttonPageListLast);
            this.panel4.Controls.Add(this.buttonPageListPrevious);
            this.panel4.Controls.Add(this.textBoxPageNumber);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 430);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1235, 42);
            this.panel4.TabIndex = 20;
            // 
            // textBoxTotalAmount
            // 
            this.textBoxTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotalAmount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalAmount.Location = new System.Drawing.Point(651, 11);
            this.textBoxTotalAmount.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTotalAmount.Name = "textBoxTotalAmount";
            this.textBoxTotalAmount.Size = new System.Drawing.Size(209, 19);
            this.textBoxTotalAmount.TabIndex = 15;
            this.textBoxTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxTotalAmount.WordWrap = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(510, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Total Cost Amount :";
            // 
            // buttonPageListFirst
            // 
            this.buttonPageListFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPageListFirst.Enabled = false;
            this.buttonPageListFirst.FlatAppearance.BorderSize = 0;
            this.buttonPageListFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPageListFirst.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.buttonPageListFirst.Location = new System.Drawing.Point(10, 7);
            this.buttonPageListFirst.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPageListFirst.Name = "buttonPageListFirst";
            this.buttonPageListFirst.Size = new System.Drawing.Size(55, 26);
            this.buttonPageListFirst.TabIndex = 8;
            this.buttonPageListFirst.Text = "First";
            this.buttonPageListFirst.UseVisualStyleBackColor = false;
            this.buttonPageListFirst.Click += new System.EventHandler(this.buttonPageListFirst_Click);
            // 
            // buttonPageListLast
            // 
            this.buttonPageListLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPageListLast.FlatAppearance.BorderSize = 0;
            this.buttonPageListLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPageListLast.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.buttonPageListLast.Location = new System.Drawing.Point(313, 7);
            this.buttonPageListLast.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPageListLast.Name = "buttonPageListLast";
            this.buttonPageListLast.Size = new System.Drawing.Size(66, 26);
            this.buttonPageListLast.TabIndex = 11;
            this.buttonPageListLast.Text = "Last";
            this.buttonPageListLast.UseVisualStyleBackColor = false;
            this.buttonPageListLast.Click += new System.EventHandler(this.buttonPageListLast_Click);
            // 
            // textBoxPageNumber
            // 
            this.textBoxPageNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxPageNumber.BackColor = System.Drawing.Color.White;
            this.textBoxPageNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPageNumber.Location = new System.Drawing.Point(171, 11);
            this.textBoxPageNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPageNumber.Name = "textBoxPageNumber";
            this.textBoxPageNumber.ReadOnly = true;
            this.textBoxPageNumber.Size = new System.Drawing.Size(55, 19);
            this.textBoxPageNumber.TabIndex = 12;
            this.textBoxPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxFilter);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.dataGridViewInventoryReport);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1235, 472);
            this.panel2.TabIndex = 17;
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilter.Location = new System.Drawing.Point(10, 6);
            this.textBoxFilter.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(1215, 26);
            this.textBoxFilter.TabIndex = 21;
            this.textBoxFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFilter_KeyDown);
            // 
            // dataGridViewInventoryReport
            // 
            this.dataGridViewInventoryReport.AllowUserToAddRows = false;
            this.dataGridViewInventoryReport.AllowUserToDeleteRows = false;
            this.dataGridViewInventoryReport.AllowUserToResizeRows = false;
            this.dataGridViewInventoryReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewInventoryReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewInventoryReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventoryReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnItemCode,
            this.ColumnBarCode,
            this.ColumnItemDescription,
            this.ColumnUnit,
            this.ColumnBegQuantity,
            this.ColumnInQuantity,
            this.ColumnOutQuantity,
            this.ColumnEndingQuantity,
            this.ColumnStockCount,
            this.ColumnVariance,
            this.ColumnCost,
            this.ColumnItemPrice,
            this.ColumnAmount,
            this.ColumnSellingAmount});
            this.dataGridViewInventoryReport.Location = new System.Drawing.Point(10, 34);
            this.dataGridViewInventoryReport.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewInventoryReport.MultiSelect = false;
            this.dataGridViewInventoryReport.Name = "dataGridViewInventoryReport";
            this.dataGridViewInventoryReport.ReadOnly = true;
            this.dataGridViewInventoryReport.RowTemplate.Height = 24;
            this.dataGridViewInventoryReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInventoryReport.ShowEditingIcon = false;
            this.dataGridViewInventoryReport.Size = new System.Drawing.Size(1215, 390);
            this.dataGridViewInventoryReport.TabIndex = 0;
            // 
            // buttonGenerateCSV
            // 
            this.buttonGenerateCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenerateCSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonGenerateCSV.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonGenerateCSV.FlatAppearance.BorderSize = 0;
            this.buttonGenerateCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerateCSV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerateCSV.ForeColor = System.Drawing.Color.White;
            this.buttonGenerateCSV.Location = new System.Drawing.Point(1079, 9);
            this.buttonGenerateCSV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonGenerateCSV.Name = "buttonGenerateCSV";
            this.buttonGenerateCSV.Size = new System.Drawing.Size(70, 32);
            this.buttonGenerateCSV.TabIndex = 5;
            this.buttonGenerateCSV.TabStop = false;
            this.buttonGenerateCSV.Text = "CSV";
            this.buttonGenerateCSV.UseVisualStyleBackColor = false;
            this.buttonGenerateCSV.Click += new System.EventHandler(this.buttonGenerateCSV_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EasyPOS.Properties.Resources.Reports;
            this.pictureBox1.Location = new System.Drawing.Point(11, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(57, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inventory Report";
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
            this.buttonClose.Location = new System.Drawing.Point(1154, 9);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(70, 32);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_OnClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonPrint);
            this.panel1.Controls.Add(this.buttonGenerateCSV);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1235, 50);
            this.panel1.TabIndex = 16;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonPrint.FlatAppearance.BorderSize = 0;
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrint.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.ForeColor = System.Drawing.Color.White;
            this.buttonPrint.Location = new System.Drawing.Point(1005, 9);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(70, 32);
            this.buttonPrint.TabIndex = 26;
            this.buttonPrint.TabStop = false;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(877, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Total Selling Amount :";
            // 
            // textBoxTotalSellingAmount
            // 
            this.textBoxTotalSellingAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTotalSellingAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotalSellingAmount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalSellingAmount.Location = new System.Drawing.Point(1037, 11);
            this.textBoxTotalSellingAmount.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTotalSellingAmount.Name = "textBoxTotalSellingAmount";
            this.textBoxTotalSellingAmount.Size = new System.Drawing.Size(188, 19);
            this.textBoxTotalSellingAmount.TabIndex = 15;
            this.textBoxTotalSellingAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxTotalSellingAmount.WordWrap = false;
            // 
            // ColumnItemCode
            // 
            this.ColumnItemCode.DataPropertyName = "ColumnItemCode";
            this.ColumnItemCode.HeaderText = "Item Code";
            this.ColumnItemCode.Name = "ColumnItemCode";
            this.ColumnItemCode.ReadOnly = true;
            // 
            // ColumnBarCode
            // 
            this.ColumnBarCode.DataPropertyName = "ColumnBarCode";
            this.ColumnBarCode.HeaderText = "BarCode";
            this.ColumnBarCode.Name = "ColumnBarCode";
            this.ColumnBarCode.ReadOnly = true;
            // 
            // ColumnItemDescription
            // 
            this.ColumnItemDescription.DataPropertyName = "ColumnItemDescription";
            this.ColumnItemDescription.HeaderText = "Item Description";
            this.ColumnItemDescription.Name = "ColumnItemDescription";
            this.ColumnItemDescription.ReadOnly = true;
            this.ColumnItemDescription.Width = 200;
            // 
            // ColumnUnit
            // 
            this.ColumnUnit.DataPropertyName = "ColumnUnit";
            this.ColumnUnit.HeaderText = "Unit";
            this.ColumnUnit.Name = "ColumnUnit";
            this.ColumnUnit.ReadOnly = true;
            // 
            // ColumnBegQuantity
            // 
            this.ColumnBegQuantity.DataPropertyName = "ColumnBegQuantity";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnBegQuantity.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnBegQuantity.HeaderText = "Beg. Qty.";
            this.ColumnBegQuantity.Name = "ColumnBegQuantity";
            this.ColumnBegQuantity.ReadOnly = true;
            this.ColumnBegQuantity.Width = 120;
            // 
            // ColumnInQuantity
            // 
            this.ColumnInQuantity.DataPropertyName = "ColumnInQuantity";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnInQuantity.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnInQuantity.HeaderText = "In Qty.";
            this.ColumnInQuantity.Name = "ColumnInQuantity";
            this.ColumnInQuantity.ReadOnly = true;
            this.ColumnInQuantity.Width = 120;
            // 
            // ColumnOutQuantity
            // 
            this.ColumnOutQuantity.DataPropertyName = "ColumnOutQuantity";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnOutQuantity.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnOutQuantity.HeaderText = "Out Qty.";
            this.ColumnOutQuantity.Name = "ColumnOutQuantity";
            this.ColumnOutQuantity.ReadOnly = true;
            this.ColumnOutQuantity.Width = 120;
            // 
            // ColumnEndingQuantity
            // 
            this.ColumnEndingQuantity.DataPropertyName = "ColumnEndingQuantity";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnEndingQuantity.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnEndingQuantity.HeaderText = "Ending Qty.";
            this.ColumnEndingQuantity.Name = "ColumnEndingQuantity";
            this.ColumnEndingQuantity.ReadOnly = true;
            this.ColumnEndingQuantity.Width = 120;
            // 
            // ColumnStockCount
            // 
            this.ColumnStockCount.DataPropertyName = "ColumnStockCount";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnStockCount.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnStockCount.HeaderText = "Count";
            this.ColumnStockCount.Name = "ColumnStockCount";
            this.ColumnStockCount.ReadOnly = true;
            this.ColumnStockCount.Width = 120;
            // 
            // ColumnVariance
            // 
            this.ColumnVariance.DataPropertyName = "ColumnVariance";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnVariance.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColumnVariance.HeaderText = "Variance";
            this.ColumnVariance.Name = "ColumnVariance";
            this.ColumnVariance.ReadOnly = true;
            this.ColumnVariance.Width = 120;
            // 
            // ColumnCost
            // 
            this.ColumnCost.DataPropertyName = "ColumnCost";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnCost.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColumnCost.HeaderText = "Cost";
            this.ColumnCost.Name = "ColumnCost";
            this.ColumnCost.ReadOnly = true;
            this.ColumnCost.Width = 120;
            // 
            // ColumnItemPrice
            // 
            this.ColumnItemPrice.DataPropertyName = "ColumnItemPrice";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnItemPrice.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColumnItemPrice.HeaderText = "Price";
            this.ColumnItemPrice.Name = "ColumnItemPrice";
            this.ColumnItemPrice.ReadOnly = true;
            // 
            // ColumnAmount
            // 
            this.ColumnAmount.DataPropertyName = "ColumnAmount";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnAmount.DefaultCellStyle = dataGridViewCellStyle9;
            this.ColumnAmount.HeaderText = "Cost Amount";
            this.ColumnAmount.Name = "ColumnAmount";
            this.ColumnAmount.ReadOnly = true;
            this.ColumnAmount.Width = 140;
            // 
            // ColumnSellingAmount
            // 
            this.ColumnSellingAmount.DataPropertyName = "ColumnSellingAmount";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnSellingAmount.DefaultCellStyle = dataGridViewCellStyle10;
            this.ColumnSellingAmount.HeaderText = "Selling Amount";
            this.ColumnSellingAmount.Name = "ColumnSellingAmount";
            this.ColumnSellingAmount.ReadOnly = true;
            this.ColumnSellingAmount.Width = 130;
            // 
            // RepInventoryReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1235, 522);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "RepInventoryReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Report";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventoryReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPageListNext;
        private System.Windows.Forms.Button buttonPageListPrevious;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxTotalAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPageListFirst;
        private System.Windows.Forms.Button buttonPageListLast;
        private System.Windows.Forms.TextBox textBoxPageNumber;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewInventoryReport;
        private System.Windows.Forms.Button buttonGenerateCSV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogGenerateCSV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.TextBox textBoxTotalSellingAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBarCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBegQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOutQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEndingQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStockCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVariance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSellingAmount;
    }
}