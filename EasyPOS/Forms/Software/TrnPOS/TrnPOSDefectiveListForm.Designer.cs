
namespace EasyPOS.Forms.Software.TrnPOS
{
    partial class TrnPOSDefectiveListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrnPOSDefectiveListForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dateTimePickerStockInListFilter = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonDefectiveListPageListFirst = new System.Windows.Forms.Button();
            this.buttonDefectiveListPageListPrevious = new System.Windows.Forms.Button();
            this.buttonDefectiveListPageListNext = new System.Windows.Forms.Button();
            this.buttonDefectiveListPageListLast = new System.Windows.Forms.Button();
            this.textBoxDefectiveListPageNumber = new System.Windows.Forms.TextBox();
            this.dataGridViewDefectiveList = new System.Windows.Forms.DataGridView();
            this.textBoxStockInListFilter = new System.Windows.Forms.TextBox();
            this.dateTimePickerDefectveListFilter = new System.Windows.Forms.DateTimePicker();
            this.textBoxDefectiveListFilter = new System.Windows.Forms.TextBox();
            this.ColumnDefectiveListButtonEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnDefectiveListButtonDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnDefectiveListId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDefectiveListSalesId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDefectiveListDefectiveNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDefectiveListDefectiveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDefectiveListInvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDefectiveListCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDefectiveListWarrantyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDefectiveListPreparedById = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDefectiveListIsLocked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefectiveList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1396, 62);
            this.panel1.TabIndex = 24;
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
            this.label1.Size = new System.Drawing.Size(176, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Defective List";
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
            this.buttonClose.Location = new System.Drawing.Point(1296, 12);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(88, 40);
            this.buttonClose.TabIndex = 21;
            this.buttonClose.TabStop = false;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(1202, 12);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(88, 40);
            this.buttonAdd.TabIndex = 20;
            this.buttonAdd.TabStop = false;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dateTimePickerStockInListFilter
            // 
            this.dateTimePickerStockInListFilter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStockInListFilter.Location = new System.Drawing.Point(-125, 6);
            this.dateTimePickerStockInListFilter.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerStockInListFilter.Name = "dateTimePickerStockInListFilter";
            this.dateTimePickerStockInListFilter.Size = new System.Drawing.Size(142, 22);
            this.dateTimePickerStockInListFilter.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.buttonDefectiveListPageListFirst);
            this.panel3.Controls.Add(this.buttonDefectiveListPageListPrevious);
            this.panel3.Controls.Add(this.buttonDefectiveListPageListNext);
            this.panel3.Controls.Add(this.buttonDefectiveListPageListLast);
            this.panel3.Controls.Add(this.textBoxDefectiveListPageNumber);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 566);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1396, 52);
            this.panel3.TabIndex = 26;
            // 
            // buttonDefectiveListPageListFirst
            // 
            this.buttonDefectiveListPageListFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDefectiveListPageListFirst.Enabled = false;
            this.buttonDefectiveListPageListFirst.FlatAppearance.BorderSize = 0;
            this.buttonDefectiveListPageListFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDefectiveListPageListFirst.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonDefectiveListPageListFirst.Location = new System.Drawing.Point(12, 11);
            this.buttonDefectiveListPageListFirst.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDefectiveListPageListFirst.Name = "buttonDefectiveListPageListFirst";
            this.buttonDefectiveListPageListFirst.Size = new System.Drawing.Size(82, 32);
            this.buttonDefectiveListPageListFirst.TabIndex = 13;
            this.buttonDefectiveListPageListFirst.Text = "First";
            this.buttonDefectiveListPageListFirst.UseVisualStyleBackColor = false;
            this.buttonDefectiveListPageListFirst.Click += new System.EventHandler(this.buttonDefectiveListPageListFirst_Click);
            // 
            // buttonDefectiveListPageListPrevious
            // 
            this.buttonDefectiveListPageListPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDefectiveListPageListPrevious.Enabled = false;
            this.buttonDefectiveListPageListPrevious.FlatAppearance.BorderSize = 0;
            this.buttonDefectiveListPageListPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDefectiveListPageListPrevious.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonDefectiveListPageListPrevious.Location = new System.Drawing.Point(100, 11);
            this.buttonDefectiveListPageListPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDefectiveListPageListPrevious.Name = "buttonDefectiveListPageListPrevious";
            this.buttonDefectiveListPageListPrevious.Size = new System.Drawing.Size(82, 32);
            this.buttonDefectiveListPageListPrevious.TabIndex = 14;
            this.buttonDefectiveListPageListPrevious.Text = "Previous";
            this.buttonDefectiveListPageListPrevious.UseVisualStyleBackColor = false;
            this.buttonDefectiveListPageListPrevious.Click += new System.EventHandler(this.buttonDefectiveListPageListPrevious_Click);
            // 
            // buttonDefectiveListPageListNext
            // 
            this.buttonDefectiveListPageListNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDefectiveListPageListNext.FlatAppearance.BorderSize = 0;
            this.buttonDefectiveListPageListNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDefectiveListPageListNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonDefectiveListPageListNext.Location = new System.Drawing.Point(262, 11);
            this.buttonDefectiveListPageListNext.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDefectiveListPageListNext.Name = "buttonDefectiveListPageListNext";
            this.buttonDefectiveListPageListNext.Size = new System.Drawing.Size(82, 32);
            this.buttonDefectiveListPageListNext.TabIndex = 15;
            this.buttonDefectiveListPageListNext.Text = "Next";
            this.buttonDefectiveListPageListNext.UseVisualStyleBackColor = false;
            this.buttonDefectiveListPageListNext.Click += new System.EventHandler(this.buttonDefectiveListPageListNext_Click);
            // 
            // buttonDefectiveListPageListLast
            // 
            this.buttonDefectiveListPageListLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDefectiveListPageListLast.FlatAppearance.BorderSize = 0;
            this.buttonDefectiveListPageListLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDefectiveListPageListLast.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonDefectiveListPageListLast.Location = new System.Drawing.Point(348, 11);
            this.buttonDefectiveListPageListLast.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDefectiveListPageListLast.Name = "buttonDefectiveListPageListLast";
            this.buttonDefectiveListPageListLast.Size = new System.Drawing.Size(82, 32);
            this.buttonDefectiveListPageListLast.TabIndex = 16;
            this.buttonDefectiveListPageListLast.Text = "Last";
            this.buttonDefectiveListPageListLast.UseVisualStyleBackColor = false;
            this.buttonDefectiveListPageListLast.Click += new System.EventHandler(this.buttonDefectiveListPageListLast_Click);
            // 
            // textBoxDefectiveListPageNumber
            // 
            this.textBoxDefectiveListPageNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxDefectiveListPageNumber.BackColor = System.Drawing.Color.White;
            this.textBoxDefectiveListPageNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDefectiveListPageNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxDefectiveListPageNumber.Location = new System.Drawing.Point(188, 16);
            this.textBoxDefectiveListPageNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDefectiveListPageNumber.Name = "textBoxDefectiveListPageNumber";
            this.textBoxDefectiveListPageNumber.ReadOnly = true;
            this.textBoxDefectiveListPageNumber.Size = new System.Drawing.Size(69, 20);
            this.textBoxDefectiveListPageNumber.TabIndex = 17;
            this.textBoxDefectiveListPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridViewDefectiveList
            // 
            this.dataGridViewDefectiveList.AllowUserToAddRows = false;
            this.dataGridViewDefectiveList.AllowUserToDeleteRows = false;
            this.dataGridViewDefectiveList.AllowUserToResizeRows = false;
            this.dataGridViewDefectiveList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDefectiveList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDefectiveList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDefectiveList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDefectiveList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDefectiveListButtonEdit,
            this.ColumnDefectiveListButtonDelete,
            this.ColumnDefectiveListId,
            this.ColumnDefectiveListSalesId,
            this.ColumnDefectiveListDefectiveNo,
            this.ColumnDefectiveListDefectiveDate,
            this.ColumnDefectiveListInvoiceNo,
            this.ColumnDefectiveListCustomerName,
            this.ColumnDefectiveListWarrantyCode,
            this.ColumnDefectiveListPreparedById,
            this.ColumnDefectiveListIsLocked});
            this.dataGridViewDefectiveList.Location = new System.Drawing.Point(11, 100);
            this.dataGridViewDefectiveList.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDefectiveList.MultiSelect = false;
            this.dataGridViewDefectiveList.Name = "dataGridViewDefectiveList";
            this.dataGridViewDefectiveList.ReadOnly = true;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDefectiveList.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewDefectiveList.RowHeadersWidth = 51;
            this.dataGridViewDefectiveList.RowTemplate.Height = 24;
            this.dataGridViewDefectiveList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDefectiveList.Size = new System.Drawing.Size(1374, 462);
            this.dataGridViewDefectiveList.TabIndex = 25;
            this.dataGridViewDefectiveList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDefectiveList_CellClick);
            // 
            // textBoxStockInListFilter
            // 
            this.textBoxStockInListFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStockInListFilter.Location = new System.Drawing.Point(22, 6);
            this.textBoxStockInListFilter.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStockInListFilter.Name = "textBoxStockInListFilter";
            this.textBoxStockInListFilter.Size = new System.Drawing.Size(1510, 22);
            this.textBoxStockInListFilter.TabIndex = 23;
            // 
            // dateTimePickerDefectveListFilter
            // 
            this.dateTimePickerDefectveListFilter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDefectveListFilter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDefectveListFilter.Location = new System.Drawing.Point(9, 66);
            this.dateTimePickerDefectveListFilter.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerDefectveListFilter.Name = "dateTimePickerDefectveListFilter";
            this.dateTimePickerDefectveListFilter.Size = new System.Drawing.Size(142, 30);
            this.dateTimePickerDefectveListFilter.TabIndex = 27;
            this.dateTimePickerDefectveListFilter.ValueChanged += new System.EventHandler(this.dateTimePickerDefectveListFilter_ValueChanged);
            // 
            // textBoxDefectiveListFilter
            // 
            this.textBoxDefectiveListFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefectiveListFilter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDefectiveListFilter.Location = new System.Drawing.Point(156, 66);
            this.textBoxDefectiveListFilter.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDefectiveListFilter.Name = "textBoxDefectiveListFilter";
            this.textBoxDefectiveListFilter.Size = new System.Drawing.Size(1229, 30);
            this.textBoxDefectiveListFilter.TabIndex = 28;
            this.textBoxDefectiveListFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxDefectiveListFilter_KeyDown);
            // 
            // ColumnDefectiveListButtonEdit
            // 
            this.ColumnDefectiveListButtonEdit.DataPropertyName = "ColumnDefectiveListButtonEdit";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColumnDefectiveListButtonEdit.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnDefectiveListButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnDefectiveListButtonEdit.HeaderText = "";
            this.ColumnDefectiveListButtonEdit.MinimumWidth = 6;
            this.ColumnDefectiveListButtonEdit.Name = "ColumnDefectiveListButtonEdit";
            this.ColumnDefectiveListButtonEdit.ReadOnly = true;
            this.ColumnDefectiveListButtonEdit.Width = 70;
            // 
            // ColumnDefectiveListButtonDelete
            // 
            this.ColumnDefectiveListButtonDelete.DataPropertyName = "ColumnDefectiveListButtonDelete";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.ColumnDefectiveListButtonDelete.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnDefectiveListButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnDefectiveListButtonDelete.HeaderText = "";
            this.ColumnDefectiveListButtonDelete.MinimumWidth = 6;
            this.ColumnDefectiveListButtonDelete.Name = "ColumnDefectiveListButtonDelete";
            this.ColumnDefectiveListButtonDelete.ReadOnly = true;
            this.ColumnDefectiveListButtonDelete.Width = 70;
            // 
            // ColumnDefectiveListId
            // 
            this.ColumnDefectiveListId.DataPropertyName = "ColumnDefectiveListId";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.ColumnDefectiveListId.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnDefectiveListId.HeaderText = "Id";
            this.ColumnDefectiveListId.MinimumWidth = 6;
            this.ColumnDefectiveListId.Name = "ColumnDefectiveListId";
            this.ColumnDefectiveListId.ReadOnly = true;
            this.ColumnDefectiveListId.Visible = false;
            this.ColumnDefectiveListId.Width = 125;
            // 
            // ColumnDefectiveListSalesId
            // 
            this.ColumnDefectiveListSalesId.DataPropertyName = "ColumnDefectiveListSalesId";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.ColumnDefectiveListSalesId.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnDefectiveListSalesId.HeaderText = "Sales Id";
            this.ColumnDefectiveListSalesId.MinimumWidth = 6;
            this.ColumnDefectiveListSalesId.Name = "ColumnDefectiveListSalesId";
            this.ColumnDefectiveListSalesId.ReadOnly = true;
            this.ColumnDefectiveListSalesId.Visible = false;
            this.ColumnDefectiveListSalesId.Width = 125;
            // 
            // ColumnDefectiveListDefectiveNo
            // 
            this.ColumnDefectiveListDefectiveNo.DataPropertyName = "ColumnDefectiveListDefectiveNo";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.ColumnDefectiveListDefectiveNo.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColumnDefectiveListDefectiveNo.HeaderText = "Defective No.";
            this.ColumnDefectiveListDefectiveNo.MinimumWidth = 6;
            this.ColumnDefectiveListDefectiveNo.Name = "ColumnDefectiveListDefectiveNo";
            this.ColumnDefectiveListDefectiveNo.ReadOnly = true;
            this.ColumnDefectiveListDefectiveNo.Width = 150;
            // 
            // ColumnDefectiveListDefectiveDate
            // 
            this.ColumnDefectiveListDefectiveDate.DataPropertyName = "ColumnDefectiveListDefectiveDate";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.ColumnDefectiveListDefectiveDate.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColumnDefectiveListDefectiveDate.HeaderText = "Defective Date";
            this.ColumnDefectiveListDefectiveDate.MinimumWidth = 6;
            this.ColumnDefectiveListDefectiveDate.Name = "ColumnDefectiveListDefectiveDate";
            this.ColumnDefectiveListDefectiveDate.ReadOnly = true;
            this.ColumnDefectiveListDefectiveDate.Width = 150;
            // 
            // ColumnDefectiveListInvoiceNo
            // 
            this.ColumnDefectiveListInvoiceNo.DataPropertyName = "ColumnDefectiveListInvoiceNo";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.ColumnDefectiveListInvoiceNo.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColumnDefectiveListInvoiceNo.HeaderText = "Invoice No.";
            this.ColumnDefectiveListInvoiceNo.MinimumWidth = 6;
            this.ColumnDefectiveListInvoiceNo.Name = "ColumnDefectiveListInvoiceNo";
            this.ColumnDefectiveListInvoiceNo.ReadOnly = true;
            this.ColumnDefectiveListInvoiceNo.Width = 150;
            // 
            // ColumnDefectiveListCustomerName
            // 
            this.ColumnDefectiveListCustomerName.DataPropertyName = "ColumnDefectiveListCustomerName";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.ColumnDefectiveListCustomerName.DefaultCellStyle = dataGridViewCellStyle9;
            this.ColumnDefectiveListCustomerName.HeaderText = "Customer Name";
            this.ColumnDefectiveListCustomerName.MinimumWidth = 6;
            this.ColumnDefectiveListCustomerName.Name = "ColumnDefectiveListCustomerName";
            this.ColumnDefectiveListCustomerName.ReadOnly = true;
            this.ColumnDefectiveListCustomerName.Width = 170;
            // 
            // ColumnDefectiveListWarrantyCode
            // 
            this.ColumnDefectiveListWarrantyCode.DataPropertyName = "ColumnDefectiveListWarrantyCode";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.ColumnDefectiveListWarrantyCode.DefaultCellStyle = dataGridViewCellStyle10;
            this.ColumnDefectiveListWarrantyCode.HeaderText = "Warranty Code";
            this.ColumnDefectiveListWarrantyCode.MinimumWidth = 6;
            this.ColumnDefectiveListWarrantyCode.Name = "ColumnDefectiveListWarrantyCode";
            this.ColumnDefectiveListWarrantyCode.ReadOnly = true;
            this.ColumnDefectiveListWarrantyCode.Width = 150;
            // 
            // ColumnDefectiveListPreparedById
            // 
            this.ColumnDefectiveListPreparedById.DataPropertyName = "ColumnDefectiveListPreparedById";
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.ColumnDefectiveListPreparedById.DefaultCellStyle = dataGridViewCellStyle11;
            this.ColumnDefectiveListPreparedById.HeaderText = "PreparedById";
            this.ColumnDefectiveListPreparedById.MinimumWidth = 6;
            this.ColumnDefectiveListPreparedById.Name = "ColumnDefectiveListPreparedById";
            this.ColumnDefectiveListPreparedById.ReadOnly = true;
            this.ColumnDefectiveListPreparedById.Visible = false;
            this.ColumnDefectiveListPreparedById.Width = 125;
            // 
            // ColumnDefectiveListIsLocked
            // 
            this.ColumnDefectiveListIsLocked.DataPropertyName = "ColumnDefectiveListIsLocked";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            dataGridViewCellStyle12.NullValue = false;
            this.ColumnDefectiveListIsLocked.DefaultCellStyle = dataGridViewCellStyle12;
            this.ColumnDefectiveListIsLocked.HeaderText = "L";
            this.ColumnDefectiveListIsLocked.MinimumWidth = 6;
            this.ColumnDefectiveListIsLocked.Name = "ColumnDefectiveListIsLocked";
            this.ColumnDefectiveListIsLocked.ReadOnly = true;
            this.ColumnDefectiveListIsLocked.Width = 35;
            // 
            // TrnPOSDefectiveListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 618);
            this.Controls.Add(this.dateTimePickerDefectveListFilter);
            this.Controls.Add(this.textBoxDefectiveListFilter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePickerStockInListFilter);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridViewDefectiveList);
            this.Controls.Add(this.textBoxStockInListFilter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrnPOSDefectiveListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Defective";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefectiveList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStockInListFilter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonDefectiveListPageListFirst;
        private System.Windows.Forms.Button buttonDefectiveListPageListPrevious;
        private System.Windows.Forms.Button buttonDefectiveListPageListNext;
        private System.Windows.Forms.Button buttonDefectiveListPageListLast;
        private System.Windows.Forms.TextBox textBoxDefectiveListPageNumber;
        private System.Windows.Forms.DataGridView dataGridViewDefectiveList;
        private System.Windows.Forms.TextBox textBoxStockInListFilter;
        private System.Windows.Forms.DateTimePicker dateTimePickerDefectveListFilter;
        private System.Windows.Forms.TextBox textBoxDefectiveListFilter;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDefectiveListButtonEdit;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDefectiveListButtonDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDefectiveListId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDefectiveListSalesId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDefectiveListDefectiveNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDefectiveListDefectiveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDefectiveListInvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDefectiveListCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDefectiveListWarrantyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDefectiveListPreparedById;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnDefectiveListIsLocked;
    }
}