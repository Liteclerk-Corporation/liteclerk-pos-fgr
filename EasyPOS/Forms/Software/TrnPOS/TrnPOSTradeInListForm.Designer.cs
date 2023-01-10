
namespace EasyPOS.Forms.Software.TrnPOS
{
    partial class TrnPOSTradeInListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrnPOSTradeInListForm));
            this.dateTimePickerDefectveListFilter = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonTradeInListPageListFirst = new System.Windows.Forms.Button();
            this.buttonTradeInListPageListPrevious = new System.Windows.Forms.Button();
            this.buttonTradeInListPageListNext = new System.Windows.Forms.Button();
            this.buttonTradeInListPageListLast = new System.Windows.Forms.Button();
            this.textBoxTradeInListPageNumber = new System.Windows.Forms.TextBox();
            this.dataGridViewTradeInList = new System.Windows.Forms.DataGridView();
            this.ColumnTradeInListButtonEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnTradeInListButtonDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnTradeInListId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTradeInListTradeInNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTradeInListTradeInDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTradeInListRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDefectiveListIsLocked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dateTimePickerTradeInListFilter = new System.Windows.Forms.DateTimePicker();
            this.textBoxTradeInListFilter = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTradeInList)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerDefectveListFilter
            // 
            this.dateTimePickerDefectveListFilter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDefectveListFilter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDefectveListFilter.Location = new System.Drawing.Point(-210, 80);
            this.dateTimePickerDefectveListFilter.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerDefectveListFilter.Name = "dateTimePickerDefectveListFilter";
            this.dateTimePickerDefectveListFilter.Size = new System.Drawing.Size(159, 30);
            this.dateTimePickerDefectveListFilter.TabIndex = 32;
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
            this.panel1.Size = new System.Drawing.Size(1092, 76);
            this.panel1.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EasyPOS.Properties.Resources.Stock_In;
            this.pictureBox1.Location = new System.Drawing.Point(14, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(70, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Trade - In List";
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
            this.buttonClose.Location = new System.Drawing.Point(980, 14);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(99, 47);
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
            this.buttonAdd.Location = new System.Drawing.Point(874, 14);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(99, 47);
            this.buttonAdd.TabIndex = 20;
            this.buttonAdd.TabStop = false;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.buttonTradeInListPageListFirst);
            this.panel3.Controls.Add(this.buttonTradeInListPageListPrevious);
            this.panel3.Controls.Add(this.buttonTradeInListPageListNext);
            this.panel3.Controls.Add(this.buttonTradeInListPageListLast);
            this.panel3.Controls.Add(this.textBoxTradeInListPageNumber);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 500);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1092, 54);
            this.panel3.TabIndex = 31;
            // 
            // buttonTradeInListPageListFirst
            // 
            this.buttonTradeInListPageListFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonTradeInListPageListFirst.Enabled = false;
            this.buttonTradeInListPageListFirst.FlatAppearance.BorderSize = 0;
            this.buttonTradeInListPageListFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTradeInListPageListFirst.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonTradeInListPageListFirst.Location = new System.Drawing.Point(14, 9);
            this.buttonTradeInListPageListFirst.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTradeInListPageListFirst.Name = "buttonTradeInListPageListFirst";
            this.buttonTradeInListPageListFirst.Size = new System.Drawing.Size(92, 37);
            this.buttonTradeInListPageListFirst.TabIndex = 13;
            this.buttonTradeInListPageListFirst.Text = "First";
            this.buttonTradeInListPageListFirst.UseVisualStyleBackColor = false;
            this.buttonTradeInListPageListFirst.Click += new System.EventHandler(this.buttonTradeInListPageListFirst_Click);
            // 
            // buttonTradeInListPageListPrevious
            // 
            this.buttonTradeInListPageListPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonTradeInListPageListPrevious.Enabled = false;
            this.buttonTradeInListPageListPrevious.FlatAppearance.BorderSize = 0;
            this.buttonTradeInListPageListPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTradeInListPageListPrevious.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonTradeInListPageListPrevious.Location = new System.Drawing.Point(112, 9);
            this.buttonTradeInListPageListPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTradeInListPageListPrevious.Name = "buttonTradeInListPageListPrevious";
            this.buttonTradeInListPageListPrevious.Size = new System.Drawing.Size(92, 37);
            this.buttonTradeInListPageListPrevious.TabIndex = 14;
            this.buttonTradeInListPageListPrevious.Text = "Previous";
            this.buttonTradeInListPageListPrevious.UseVisualStyleBackColor = false;
            this.buttonTradeInListPageListPrevious.Click += new System.EventHandler(this.buttonTradeInListPageListPrevious_Click);
            // 
            // buttonTradeInListPageListNext
            // 
            this.buttonTradeInListPageListNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonTradeInListPageListNext.FlatAppearance.BorderSize = 0;
            this.buttonTradeInListPageListNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTradeInListPageListNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonTradeInListPageListNext.Location = new System.Drawing.Point(295, 9);
            this.buttonTradeInListPageListNext.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTradeInListPageListNext.Name = "buttonTradeInListPageListNext";
            this.buttonTradeInListPageListNext.Size = new System.Drawing.Size(92, 37);
            this.buttonTradeInListPageListNext.TabIndex = 15;
            this.buttonTradeInListPageListNext.Text = "Next";
            this.buttonTradeInListPageListNext.UseVisualStyleBackColor = false;
            this.buttonTradeInListPageListNext.Click += new System.EventHandler(this.buttonTradeInListPageListNext_Click);
            // 
            // buttonTradeInListPageListLast
            // 
            this.buttonTradeInListPageListLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonTradeInListPageListLast.FlatAppearance.BorderSize = 0;
            this.buttonTradeInListPageListLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTradeInListPageListLast.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonTradeInListPageListLast.Location = new System.Drawing.Point(392, 9);
            this.buttonTradeInListPageListLast.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTradeInListPageListLast.Name = "buttonTradeInListPageListLast";
            this.buttonTradeInListPageListLast.Size = new System.Drawing.Size(92, 37);
            this.buttonTradeInListPageListLast.TabIndex = 16;
            this.buttonTradeInListPageListLast.Text = "Last";
            this.buttonTradeInListPageListLast.UseVisualStyleBackColor = false;
            this.buttonTradeInListPageListLast.Click += new System.EventHandler(this.buttonTradeInListPageListLast_Click);
            // 
            // textBoxTradeInListPageNumber
            // 
            this.textBoxTradeInListPageNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxTradeInListPageNumber.BackColor = System.Drawing.Color.White;
            this.textBoxTradeInListPageNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTradeInListPageNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxTradeInListPageNumber.Location = new System.Drawing.Point(218, 18);
            this.textBoxTradeInListPageNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTradeInListPageNumber.Name = "textBoxTradeInListPageNumber";
            this.textBoxTradeInListPageNumber.ReadOnly = true;
            this.textBoxTradeInListPageNumber.Size = new System.Drawing.Size(78, 20);
            this.textBoxTradeInListPageNumber.TabIndex = 17;
            this.textBoxTradeInListPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridViewTradeInList
            // 
            this.dataGridViewTradeInList.AllowUserToAddRows = false;
            this.dataGridViewTradeInList.AllowUserToDeleteRows = false;
            this.dataGridViewTradeInList.AllowUserToResizeRows = false;
            this.dataGridViewTradeInList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTradeInList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTradeInList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTradeInList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTradeInListButtonEdit,
            this.ColumnTradeInListButtonDelete,
            this.ColumnTradeInListId,
            this.ColumnTradeInListTradeInNo,
            this.ColumnTradeInListTradeInDate,
            this.ColumnTradeInListRemarks,
            this.ColumnDefectiveListIsLocked});
            this.dataGridViewTradeInList.Location = new System.Drawing.Point(1, 114);
            this.dataGridViewTradeInList.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewTradeInList.MultiSelect = false;
            this.dataGridViewTradeInList.Name = "dataGridViewTradeInList";
            this.dataGridViewTradeInList.ReadOnly = true;
            this.dataGridViewTradeInList.RowHeadersWidth = 51;
            this.dataGridViewTradeInList.RowTemplate.Height = 24;
            this.dataGridViewTradeInList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTradeInList.Size = new System.Drawing.Size(1091, 382);
            this.dataGridViewTradeInList.TabIndex = 30;
            this.dataGridViewTradeInList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTradeInList_CellClick);
            // 
            // ColumnTradeInListButtonEdit
            // 
            this.ColumnTradeInListButtonEdit.DataPropertyName = "ColumnTradeInListButtonEdit";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColumnTradeInListButtonEdit.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnTradeInListButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnTradeInListButtonEdit.HeaderText = "";
            this.ColumnTradeInListButtonEdit.MinimumWidth = 6;
            this.ColumnTradeInListButtonEdit.Name = "ColumnTradeInListButtonEdit";
            this.ColumnTradeInListButtonEdit.ReadOnly = true;
            this.ColumnTradeInListButtonEdit.Width = 70;
            // 
            // ColumnTradeInListButtonDelete
            // 
            this.ColumnTradeInListButtonDelete.DataPropertyName = "ColumnTradeInListButtonDelete";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.ColumnTradeInListButtonDelete.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnTradeInListButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnTradeInListButtonDelete.HeaderText = "";
            this.ColumnTradeInListButtonDelete.MinimumWidth = 6;
            this.ColumnTradeInListButtonDelete.Name = "ColumnTradeInListButtonDelete";
            this.ColumnTradeInListButtonDelete.ReadOnly = true;
            this.ColumnTradeInListButtonDelete.Width = 70;
            // 
            // ColumnTradeInListId
            // 
            this.ColumnTradeInListId.DataPropertyName = "ColumnTradeInListId";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.ColumnTradeInListId.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnTradeInListId.HeaderText = "Id";
            this.ColumnTradeInListId.MinimumWidth = 6;
            this.ColumnTradeInListId.Name = "ColumnTradeInListId";
            this.ColumnTradeInListId.ReadOnly = true;
            this.ColumnTradeInListId.Visible = false;
            this.ColumnTradeInListId.Width = 125;
            // 
            // ColumnTradeInListTradeInNo
            // 
            this.ColumnTradeInListTradeInNo.DataPropertyName = "ColumnTradeInListTradeInNo";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.ColumnTradeInListTradeInNo.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnTradeInListTradeInNo.HeaderText = "Trade - In No.";
            this.ColumnTradeInListTradeInNo.MinimumWidth = 6;
            this.ColumnTradeInListTradeInNo.Name = "ColumnTradeInListTradeInNo";
            this.ColumnTradeInListTradeInNo.ReadOnly = true;
            this.ColumnTradeInListTradeInNo.Width = 150;
            // 
            // ColumnTradeInListTradeInDate
            // 
            this.ColumnTradeInListTradeInDate.DataPropertyName = "ColumnTradeInListTradeInDate";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.ColumnTradeInListTradeInDate.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnTradeInListTradeInDate.HeaderText = "Date";
            this.ColumnTradeInListTradeInDate.MinimumWidth = 6;
            this.ColumnTradeInListTradeInDate.Name = "ColumnTradeInListTradeInDate";
            this.ColumnTradeInListTradeInDate.ReadOnly = true;
            this.ColumnTradeInListTradeInDate.Width = 150;
            // 
            // ColumnTradeInListRemarks
            // 
            this.ColumnTradeInListRemarks.DataPropertyName = "ColumnTradeInListRemarks";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.ColumnTradeInListRemarks.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColumnTradeInListRemarks.HeaderText = "Remarks";
            this.ColumnTradeInListRemarks.MinimumWidth = 6;
            this.ColumnTradeInListRemarks.Name = "ColumnTradeInListRemarks";
            this.ColumnTradeInListRemarks.ReadOnly = true;
            this.ColumnTradeInListRemarks.Width = 300;
            // 
            // ColumnDefectiveListIsLocked
            // 
            this.ColumnDefectiveListIsLocked.DataPropertyName = "ColumnTradeInListIsLocked";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            dataGridViewCellStyle7.NullValue = false;
            this.ColumnDefectiveListIsLocked.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColumnDefectiveListIsLocked.HeaderText = "L";
            this.ColumnDefectiveListIsLocked.MinimumWidth = 6;
            this.ColumnDefectiveListIsLocked.Name = "ColumnDefectiveListIsLocked";
            this.ColumnDefectiveListIsLocked.ReadOnly = true;
            this.ColumnDefectiveListIsLocked.Width = 35;
            // 
            // dateTimePickerTradeInListFilter
            // 
            this.dateTimePickerTradeInListFilter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTradeInListFilter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTradeInListFilter.Location = new System.Drawing.Point(7, 80);
            this.dateTimePickerTradeInListFilter.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerTradeInListFilter.Name = "dateTimePickerTradeInListFilter";
            this.dateTimePickerTradeInListFilter.Size = new System.Drawing.Size(159, 30);
            this.dateTimePickerTradeInListFilter.TabIndex = 33;
            this.dateTimePickerTradeInListFilter.ValueChanged += new System.EventHandler(this.dateTimePickerTradeInListFilter_ValueChanged);
            // 
            // textBoxTradeInListFilter
            // 
            this.textBoxTradeInListFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTradeInListFilter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTradeInListFilter.Location = new System.Drawing.Point(175, 80);
            this.textBoxTradeInListFilter.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTradeInListFilter.Name = "textBoxTradeInListFilter";
            this.textBoxTradeInListFilter.Size = new System.Drawing.Size(906, 30);
            this.textBoxTradeInListFilter.TabIndex = 34;
            this.textBoxTradeInListFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTradeInListFilter_KeyDown);
            // 
            // TrnPOSTradeInListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1092, 554);
            this.Controls.Add(this.dateTimePickerTradeInListFilter);
            this.Controls.Add(this.textBoxTradeInListFilter);
            this.Controls.Add(this.dateTimePickerDefectveListFilter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridViewTradeInList);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TrnPOSTradeInListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trade - In";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTradeInList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerDefectveListFilter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonTradeInListPageListFirst;
        private System.Windows.Forms.Button buttonTradeInListPageListPrevious;
        private System.Windows.Forms.Button buttonTradeInListPageListNext;
        private System.Windows.Forms.Button buttonTradeInListPageListLast;
        private System.Windows.Forms.TextBox textBoxTradeInListPageNumber;
        private System.Windows.Forms.DataGridView dataGridViewTradeInList;
        private System.Windows.Forms.DateTimePicker dateTimePickerTradeInListFilter;
        private System.Windows.Forms.TextBox textBoxTradeInListFilter;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnTradeInListButtonEdit;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnTradeInListButtonDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTradeInListId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTradeInListTradeInNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTradeInListTradeInDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTradeInListRemarks;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnDefectiveListIsLocked;
    }
}