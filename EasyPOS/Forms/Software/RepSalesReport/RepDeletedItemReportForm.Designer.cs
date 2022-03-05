
namespace EasyPOS.Forms.Software.RepSalesReport
{
    partial class RepDeletedItemReportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepDeletedItemReportForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonGenerateCSV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewDeletedItemReport = new System.Windows.Forms.DataGridView();
            this.textBoxTotalDeletedItem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPageListFirst = new System.Windows.Forms.Button();
            this.buttonPageListNext = new System.Windows.Forms.Button();
            this.buttonPageListLast = new System.Windows.Forms.Button();
            this.buttonPageListPrevious = new System.Windows.Forms.Button();
            this.textBoxPageNumber = new System.Windows.Forms.TextBox();
            this.folderBrowserDialogGenerateCSV = new System.Windows.Forms.FolderBrowserDialog();
            this.ColumnDeletedItemSalesNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDeletedItemItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDeletedItemPreparation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDeletedItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDeletedItemUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDeletedItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDeletedItemUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDeletedItemDeletedDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeletedItemReport)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 62);
            this.panel1.TabIndex = 13;
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
            this.buttonPrint.Location = new System.Drawing.Point(723, 11);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(88, 40);
            this.buttonPrint.TabIndex = 27;
            this.buttonPrint.TabStop = false;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
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
            this.buttonGenerateCSV.Location = new System.Drawing.Point(818, 11);
            this.buttonGenerateCSV.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.buttonGenerateCSV.Name = "buttonGenerateCSV";
            this.buttonGenerateCSV.Size = new System.Drawing.Size(88, 40);
            this.buttonGenerateCSV.TabIndex = 5;
            this.buttonGenerateCSV.TabStop = false;
            this.buttonGenerateCSV.Text = "CSV";
            this.buttonGenerateCSV.UseVisualStyleBackColor = false;
            this.buttonGenerateCSV.Click += new System.EventHandler(this.buttonGenerateCSV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(71, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Deleted Item Report";
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
            this.buttonClose.Location = new System.Drawing.Point(912, 11);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(88, 40);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.TabStop = false;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_OnClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EasyPOS.Properties.Resources.Reports;
            this.pictureBox1.Location = new System.Drawing.Point(14, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewDeletedItemReport
            // 
            this.dataGridViewDeletedItemReport.AllowUserToAddRows = false;
            this.dataGridViewDeletedItemReport.AllowUserToDeleteRows = false;
            this.dataGridViewDeletedItemReport.AllowUserToResizeRows = false;
            this.dataGridViewDeletedItemReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDeletedItemReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDeletedItemReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDeletedItemReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeletedItemReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDeletedItemSalesNumber,
            this.ColumnDeletedItemItemDescription,
            this.ColumnDeletedItemPreparation,
            this.ColumnDeletedItemQuantity,
            this.ColumnDeletedItemUnit,
            this.ColumnDeletedItemPrice,
            this.ColumnDeletedItemUserName,
            this.ColumnDeletedItemDeletedDateTime});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDeletedItemReport.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewDeletedItemReport.Location = new System.Drawing.Point(13, 64);
            this.dataGridViewDeletedItemReport.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDeletedItemReport.MultiSelect = false;
            this.dataGridViewDeletedItemReport.Name = "dataGridViewDeletedItemReport";
            this.dataGridViewDeletedItemReport.ReadOnly = true;
            this.dataGridViewDeletedItemReport.RowHeadersWidth = 51;
            this.dataGridViewDeletedItemReport.RowTemplate.Height = 24;
            this.dataGridViewDeletedItemReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDeletedItemReport.ShowEditingIcon = false;
            this.dataGridViewDeletedItemReport.Size = new System.Drawing.Size(987, 418);
            this.dataGridViewDeletedItemReport.TabIndex = 14;
            // 
            // textBoxTotalDeletedItem
            // 
            this.textBoxTotalDeletedItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTotalDeletedItem.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxTotalDeletedItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotalDeletedItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalDeletedItem.Location = new System.Drawing.Point(818, 505);
            this.textBoxTotalDeletedItem.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTotalDeletedItem.Name = "textBoxTotalDeletedItem";
            this.textBoxTotalDeletedItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxTotalDeletedItem.Size = new System.Drawing.Size(177, 23);
            this.textBoxTotalDeletedItem.TabIndex = 17;
            this.textBoxTotalDeletedItem.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(629, 505);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Total Deleted Item:";
            // 
            // buttonPageListFirst
            // 
            this.buttonPageListFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPageListFirst.Enabled = false;
            this.buttonPageListFirst.FlatAppearance.BorderSize = 0;
            this.buttonPageListFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPageListFirst.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.buttonPageListFirst.Location = new System.Drawing.Point(21, 500);
            this.buttonPageListFirst.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPageListFirst.Name = "buttonPageListFirst";
            this.buttonPageListFirst.Size = new System.Drawing.Size(82, 32);
            this.buttonPageListFirst.TabIndex = 18;
            this.buttonPageListFirst.TabStop = false;
            this.buttonPageListFirst.Text = "First";
            this.buttonPageListFirst.UseVisualStyleBackColor = false;
            // 
            // buttonPageListNext
            // 
            this.buttonPageListNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPageListNext.FlatAppearance.BorderSize = 0;
            this.buttonPageListNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPageListNext.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.buttonPageListNext.Location = new System.Drawing.Point(347, 500);
            this.buttonPageListNext.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPageListNext.Name = "buttonPageListNext";
            this.buttonPageListNext.Size = new System.Drawing.Size(82, 32);
            this.buttonPageListNext.TabIndex = 20;
            this.buttonPageListNext.TabStop = false;
            this.buttonPageListNext.Text = "Next";
            this.buttonPageListNext.UseVisualStyleBackColor = false;
            // 
            // buttonPageListLast
            // 
            this.buttonPageListLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPageListLast.FlatAppearance.BorderSize = 0;
            this.buttonPageListLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPageListLast.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.buttonPageListLast.Location = new System.Drawing.Point(431, 500);
            this.buttonPageListLast.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPageListLast.Name = "buttonPageListLast";
            this.buttonPageListLast.Size = new System.Drawing.Size(82, 32);
            this.buttonPageListLast.TabIndex = 21;
            this.buttonPageListLast.TabStop = false;
            this.buttonPageListLast.Text = "Last";
            this.buttonPageListLast.UseVisualStyleBackColor = false;
            // 
            // buttonPageListPrevious
            // 
            this.buttonPageListPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPageListPrevious.Enabled = false;
            this.buttonPageListPrevious.FlatAppearance.BorderSize = 0;
            this.buttonPageListPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPageListPrevious.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.buttonPageListPrevious.Location = new System.Drawing.Point(109, 500);
            this.buttonPageListPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPageListPrevious.Name = "buttonPageListPrevious";
            this.buttonPageListPrevious.Size = new System.Drawing.Size(82, 32);
            this.buttonPageListPrevious.TabIndex = 19;
            this.buttonPageListPrevious.TabStop = false;
            this.buttonPageListPrevious.Text = "Previous";
            this.buttonPageListPrevious.UseVisualStyleBackColor = false;
            // 
            // textBoxPageNumber
            // 
            this.textBoxPageNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxPageNumber.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxPageNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPageNumber.Location = new System.Drawing.Point(240, 505);
            this.textBoxPageNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPageNumber.Name = "textBoxPageNumber";
            this.textBoxPageNumber.ReadOnly = true;
            this.textBoxPageNumber.Size = new System.Drawing.Size(69, 15);
            this.textBoxPageNumber.TabIndex = 22;
            this.textBoxPageNumber.TabStop = false;
            this.textBoxPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ColumnDeletedItemSalesNumber
            // 
            this.ColumnDeletedItemSalesNumber.DataPropertyName = "ColumnDeletedItemSalesNumber";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColumnDeletedItemSalesNumber.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnDeletedItemSalesNumber.HeaderText = "Sales No.";
            this.ColumnDeletedItemSalesNumber.MinimumWidth = 6;
            this.ColumnDeletedItemSalesNumber.Name = "ColumnDeletedItemSalesNumber";
            this.ColumnDeletedItemSalesNumber.ReadOnly = true;
            this.ColumnDeletedItemSalesNumber.Width = 150;
            // 
            // ColumnDeletedItemItemDescription
            // 
            this.ColumnDeletedItemItemDescription.DataPropertyName = "ColumnDeletedItemItemDescription";
            this.ColumnDeletedItemItemDescription.HeaderText = "Item Description";
            this.ColumnDeletedItemItemDescription.MinimumWidth = 6;
            this.ColumnDeletedItemItemDescription.Name = "ColumnDeletedItemItemDescription";
            this.ColumnDeletedItemItemDescription.ReadOnly = true;
            this.ColumnDeletedItemItemDescription.Width = 300;
            // 
            // ColumnDeletedItemPreparation
            // 
            this.ColumnDeletedItemPreparation.DataPropertyName = "ColumnDeletedItemPreparation";
            this.ColumnDeletedItemPreparation.HeaderText = "Preparation";
            this.ColumnDeletedItemPreparation.MinimumWidth = 6;
            this.ColumnDeletedItemPreparation.Name = "ColumnDeletedItemPreparation";
            this.ColumnDeletedItemPreparation.ReadOnly = true;
            this.ColumnDeletedItemPreparation.Width = 150;
            // 
            // ColumnDeletedItemQuantity
            // 
            this.ColumnDeletedItemQuantity.DataPropertyName = "ColumnDeletedItemQuantity";
            this.ColumnDeletedItemQuantity.HeaderText = "Quantity";
            this.ColumnDeletedItemQuantity.MinimumWidth = 6;
            this.ColumnDeletedItemQuantity.Name = "ColumnDeletedItemQuantity";
            this.ColumnDeletedItemQuantity.ReadOnly = true;
            this.ColumnDeletedItemQuantity.Width = 125;
            // 
            // ColumnDeletedItemUnit
            // 
            this.ColumnDeletedItemUnit.DataPropertyName = "ColumnDeletedItemUnit";
            this.ColumnDeletedItemUnit.HeaderText = "Unit";
            this.ColumnDeletedItemUnit.MinimumWidth = 6;
            this.ColumnDeletedItemUnit.Name = "ColumnDeletedItemUnit";
            this.ColumnDeletedItemUnit.ReadOnly = true;
            this.ColumnDeletedItemUnit.Width = 80;
            // 
            // ColumnDeletedItemPrice
            // 
            this.ColumnDeletedItemPrice.DataPropertyName = "ColumnDeletedItemPrice";
            this.ColumnDeletedItemPrice.HeaderText = "Price";
            this.ColumnDeletedItemPrice.MinimumWidth = 6;
            this.ColumnDeletedItemPrice.Name = "ColumnDeletedItemPrice";
            this.ColumnDeletedItemPrice.ReadOnly = true;
            this.ColumnDeletedItemPrice.Width = 125;
            // 
            // ColumnDeletedItemUserName
            // 
            this.ColumnDeletedItemUserName.DataPropertyName = "ColumnDeletedItemUserName";
            this.ColumnDeletedItemUserName.HeaderText = "Deleted by";
            this.ColumnDeletedItemUserName.MinimumWidth = 6;
            this.ColumnDeletedItemUserName.Name = "ColumnDeletedItemUserName";
            this.ColumnDeletedItemUserName.ReadOnly = true;
            this.ColumnDeletedItemUserName.Width = 150;
            // 
            // ColumnDeletedItemDeletedDateTime
            // 
            this.ColumnDeletedItemDeletedDateTime.DataPropertyName = "ColumnDeletedItemDeletedDateTime";
            this.ColumnDeletedItemDeletedDateTime.HeaderText = "Deleted Date Time";
            this.ColumnDeletedItemDeletedDateTime.MinimumWidth = 6;
            this.ColumnDeletedItemDeletedDateTime.Name = "ColumnDeletedItemDeletedDateTime";
            this.ColumnDeletedItemDeletedDateTime.ReadOnly = true;
            this.ColumnDeletedItemDeletedDateTime.Width = 150;
            // 
            // RepDeletedItemReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 546);
            this.Controls.Add(this.buttonPageListFirst);
            this.Controls.Add(this.buttonPageListNext);
            this.Controls.Add(this.buttonPageListLast);
            this.Controls.Add(this.buttonPageListPrevious);
            this.Controls.Add(this.textBoxPageNumber);
            this.Controls.Add(this.textBoxTotalDeletedItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewDeletedItemReport);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RepDeletedItemReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deleted Item Report Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeletedItemReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonGenerateCSV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DataGridView dataGridViewDeletedItemReport;
        private System.Windows.Forms.TextBox textBoxTotalDeletedItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPageListFirst;
        private System.Windows.Forms.Button buttonPageListNext;
        private System.Windows.Forms.Button buttonPageListLast;
        private System.Windows.Forms.Button buttonPageListPrevious;
        private System.Windows.Forms.TextBox textBoxPageNumber;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogGenerateCSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDeletedItemSalesNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDeletedItemItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDeletedItemPreparation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDeletedItemQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDeletedItemUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDeletedItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDeletedItemUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDeletedItemDeletedDateTime;
    }
}