
namespace EasyPOS.Forms.Software.TrnPOS
{
    partial class TrnPOSTradeInDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrnPOSTradeInDetailForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxRemarks = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxPreparedBy = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerTradeInDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxTradeInNumber = new System.Windows.Forms.TextBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.buttonTradeInLineListPageListFirst = new System.Windows.Forms.Button();
            this.buttonTradeInLineListPageListPrevious = new System.Windows.Forms.Button();
            this.buttonTradeInLineListPageListNext = new System.Windows.Forms.Button();
            this.buttonTradeInLineListPageListLast = new System.Windows.Forms.Button();
            this.textBoxTradeInLineListPageNumber = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewTradeInLineList = new System.Windows.Forms.DataGridView();
            this.ColumnTradeInLineListButtonEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnTradeInLineListButtonDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnTradeInLineListId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTradeInLineListTradeInId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTradeInLineListItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTradeInLineListItemSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTradeInLineListItemBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTradeInLineListItemWarrantyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTradeInLineListQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTradeInLineListAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTradeInLineList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1245, 62);
            this.panel1.TabIndex = 43;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(958, 11);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(135, 40);
            this.buttonEdit.TabIndex = 8;
            this.buttonEdit.TabStop = false;
            this.buttonEdit.Text = "Unlock";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
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
            this.buttonSave.Location = new System.Drawing.Point(819, 11);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(135, 40);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.TabStop = false;
            this.buttonSave.Text = "Lock";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
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
            this.label1.Size = new System.Drawing.Size(203, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Trade - In Detail";
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
            this.buttonClose.Location = new System.Drawing.Point(1097, 12);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(136, 40);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.TabStop = false;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "Remarks";
            // 
            // textBoxRemarks
            // 
            this.textBoxRemarks.Enabled = false;
            this.textBoxRemarks.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.textBoxRemarks.Location = new System.Drawing.Point(19, 165);
            this.textBoxRemarks.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRemarks.Name = "textBoxRemarks";
            this.textBoxRemarks.Size = new System.Drawing.Size(1214, 30);
            this.textBoxRemarks.TabIndex = 51;
            this.textBoxRemarks.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(455, 75);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 20);
            this.label11.TabIndex = 50;
            this.label11.Text = "Prepared by";
            // 
            // comboBoxPreparedBy
            // 
            this.comboBoxPreparedBy.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.comboBoxPreparedBy.FormattingEnabled = true;
            this.comboBoxPreparedBy.Location = new System.Drawing.Point(459, 100);
            this.comboBoxPreparedBy.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPreparedBy.Name = "comboBoxPreparedBy";
            this.comboBoxPreparedBy.Size = new System.Drawing.Size(288, 31);
            this.comboBoxPreparedBy.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(225, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Trade - In Number";
            // 
            // dateTimePickerTradeInDate
            // 
            this.dateTimePickerTradeInDate.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.dateTimePickerTradeInDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTradeInDate.Location = new System.Drawing.Point(229, 100);
            this.dateTimePickerTradeInDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerTradeInDate.Name = "dateTimePickerTradeInDate";
            this.dateTimePickerTradeInDate.Size = new System.Drawing.Size(208, 30);
            this.dateTimePickerTradeInDate.TabIndex = 46;
            // 
            // textBoxTradeInNumber
            // 
            this.textBoxTradeInNumber.Enabled = false;
            this.textBoxTradeInNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.textBoxTradeInNumber.Location = new System.Drawing.Point(19, 100);
            this.textBoxTradeInNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTradeInNumber.Name = "textBoxTradeInNumber";
            this.textBoxTradeInNumber.Size = new System.Drawing.Size(194, 30);
            this.textBoxTradeInNumber.TabIndex = 45;
            this.textBoxTradeInNumber.TabStop = false;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.White;
            this.panel15.Controls.Add(this.buttonTradeInLineListPageListFirst);
            this.panel15.Controls.Add(this.buttonTradeInLineListPageListPrevious);
            this.panel15.Controls.Add(this.buttonTradeInLineListPageListNext);
            this.panel15.Controls.Add(this.buttonTradeInLineListPageListLast);
            this.panel15.Controls.Add(this.textBoxTradeInLineListPageNumber);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel15.Location = new System.Drawing.Point(0, 658);
            this.panel15.Margin = new System.Windows.Forms.Padding(2);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(1245, 52);
            this.panel15.TabIndex = 55;
            // 
            // buttonTradeInLineListPageListFirst
            // 
            this.buttonTradeInLineListPageListFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonTradeInLineListPageListFirst.Enabled = false;
            this.buttonTradeInLineListPageListFirst.FlatAppearance.BorderSize = 0;
            this.buttonTradeInLineListPageListFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTradeInLineListPageListFirst.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonTradeInLineListPageListFirst.Location = new System.Drawing.Point(12, 9);
            this.buttonTradeInLineListPageListFirst.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTradeInLineListPageListFirst.Name = "buttonTradeInLineListPageListFirst";
            this.buttonTradeInLineListPageListFirst.Size = new System.Drawing.Size(82, 32);
            this.buttonTradeInLineListPageListFirst.TabIndex = 13;
            this.buttonTradeInLineListPageListFirst.Text = "First";
            this.buttonTradeInLineListPageListFirst.UseVisualStyleBackColor = false;
            this.buttonTradeInLineListPageListFirst.Click += new System.EventHandler(this.buttonTradeInLineListPageListFirst_Click);
            // 
            // buttonTradeInLineListPageListPrevious
            // 
            this.buttonTradeInLineListPageListPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonTradeInLineListPageListPrevious.Enabled = false;
            this.buttonTradeInLineListPageListPrevious.FlatAppearance.BorderSize = 0;
            this.buttonTradeInLineListPageListPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTradeInLineListPageListPrevious.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonTradeInLineListPageListPrevious.Location = new System.Drawing.Point(100, 9);
            this.buttonTradeInLineListPageListPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTradeInLineListPageListPrevious.Name = "buttonTradeInLineListPageListPrevious";
            this.buttonTradeInLineListPageListPrevious.Size = new System.Drawing.Size(82, 32);
            this.buttonTradeInLineListPageListPrevious.TabIndex = 14;
            this.buttonTradeInLineListPageListPrevious.Text = "Previous";
            this.buttonTradeInLineListPageListPrevious.UseVisualStyleBackColor = false;
            this.buttonTradeInLineListPageListPrevious.Click += new System.EventHandler(this.buttonTradeInLineListPageListPrevious_Click);
            // 
            // buttonTradeInLineListPageListNext
            // 
            this.buttonTradeInLineListPageListNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonTradeInLineListPageListNext.FlatAppearance.BorderSize = 0;
            this.buttonTradeInLineListPageListNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTradeInLineListPageListNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonTradeInLineListPageListNext.Location = new System.Drawing.Point(262, 9);
            this.buttonTradeInLineListPageListNext.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTradeInLineListPageListNext.Name = "buttonTradeInLineListPageListNext";
            this.buttonTradeInLineListPageListNext.Size = new System.Drawing.Size(82, 32);
            this.buttonTradeInLineListPageListNext.TabIndex = 15;
            this.buttonTradeInLineListPageListNext.Text = "Next";
            this.buttonTradeInLineListPageListNext.UseVisualStyleBackColor = false;
            this.buttonTradeInLineListPageListNext.Click += new System.EventHandler(this.buttonTradeInLineListPageListNext_Click);
            // 
            // buttonTradeInLineListPageListLast
            // 
            this.buttonTradeInLineListPageListLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonTradeInLineListPageListLast.FlatAppearance.BorderSize = 0;
            this.buttonTradeInLineListPageListLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTradeInLineListPageListLast.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonTradeInLineListPageListLast.Location = new System.Drawing.Point(348, 9);
            this.buttonTradeInLineListPageListLast.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTradeInLineListPageListLast.Name = "buttonTradeInLineListPageListLast";
            this.buttonTradeInLineListPageListLast.Size = new System.Drawing.Size(82, 32);
            this.buttonTradeInLineListPageListLast.TabIndex = 16;
            this.buttonTradeInLineListPageListLast.Text = "Last";
            this.buttonTradeInLineListPageListLast.UseVisualStyleBackColor = false;
            this.buttonTradeInLineListPageListLast.Click += new System.EventHandler(this.buttonCustomerListPageListLast_Click);
            // 
            // textBoxTradeInLineListPageNumber
            // 
            this.textBoxTradeInLineListPageNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxTradeInLineListPageNumber.BackColor = System.Drawing.Color.White;
            this.textBoxTradeInLineListPageNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTradeInLineListPageNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxTradeInLineListPageNumber.Location = new System.Drawing.Point(189, 14);
            this.textBoxTradeInLineListPageNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTradeInLineListPageNumber.Name = "textBoxTradeInLineListPageNumber";
            this.textBoxTradeInLineListPageNumber.ReadOnly = true;
            this.textBoxTradeInLineListPageNumber.Size = new System.Drawing.Size(69, 20);
            this.textBoxTradeInLineListPageNumber.TabIndex = 17;
            this.textBoxTradeInLineListPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.buttonAdd.Location = new System.Drawing.Point(1082, 208);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(152, 40);
            this.buttonAdd.TabIndex = 53;
            this.buttonAdd.TabStop = false;
            this.buttonAdd.Text = "Add Item";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewTradeInLineList
            // 
            this.dataGridViewTradeInLineList.AllowUserToAddRows = false;
            this.dataGridViewTradeInLineList.AllowUserToDeleteRows = false;
            this.dataGridViewTradeInLineList.AllowUserToResizeRows = false;
            this.dataGridViewTradeInLineList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTradeInLineList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTradeInLineList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTradeInLineList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTradeInLineList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTradeInLineListButtonEdit,
            this.ColumnTradeInLineListButtonDelete,
            this.ColumnTradeInLineListId,
            this.ColumnTradeInLineListTradeInId,
            this.ColumnTradeInLineListItemId,
            this.ColumnTradeInLineListItemSize,
            this.ColumnTradeInLineListItemBrand,
            this.ColumnTradeInLineListItemWarrantyCode,
            this.ColumnTradeInLineListQuantity,
            this.ColumnTradeInLineListAmount});
            this.dataGridViewTradeInLineList.Location = new System.Drawing.Point(0, 260);
            this.dataGridViewTradeInLineList.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewTradeInLineList.MultiSelect = false;
            this.dataGridViewTradeInLineList.Name = "dataGridViewTradeInLineList";
            this.dataGridViewTradeInLineList.ReadOnly = true;
            this.dataGridViewTradeInLineList.RowHeadersVisible = false;
            this.dataGridViewTradeInLineList.RowHeadersWidth = 51;
            this.dataGridViewTradeInLineList.RowTemplate.Height = 24;
            this.dataGridViewTradeInLineList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTradeInLineList.Size = new System.Drawing.Size(1245, 394);
            this.dataGridViewTradeInLineList.TabIndex = 54;
            this.dataGridViewTradeInLineList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTradeInLineList_CellClick);
            // 
            // ColumnTradeInLineListButtonEdit
            // 
            this.ColumnTradeInLineListButtonEdit.DataPropertyName = "ColumnTradeInLineListButtonEdit";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColumnTradeInLineListButtonEdit.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnTradeInLineListButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnTradeInLineListButtonEdit.Frozen = true;
            this.ColumnTradeInLineListButtonEdit.HeaderText = "";
            this.ColumnTradeInLineListButtonEdit.MinimumWidth = 6;
            this.ColumnTradeInLineListButtonEdit.Name = "ColumnTradeInLineListButtonEdit";
            this.ColumnTradeInLineListButtonEdit.ReadOnly = true;
            this.ColumnTradeInLineListButtonEdit.Width = 70;
            // 
            // ColumnTradeInLineListButtonDelete
            // 
            this.ColumnTradeInLineListButtonDelete.DataPropertyName = "ColumnTradeInLineListButtonDelete";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.ColumnTradeInLineListButtonDelete.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnTradeInLineListButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnTradeInLineListButtonDelete.Frozen = true;
            this.ColumnTradeInLineListButtonDelete.HeaderText = "";
            this.ColumnTradeInLineListButtonDelete.MinimumWidth = 6;
            this.ColumnTradeInLineListButtonDelete.Name = "ColumnTradeInLineListButtonDelete";
            this.ColumnTradeInLineListButtonDelete.ReadOnly = true;
            this.ColumnTradeInLineListButtonDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnTradeInLineListButtonDelete.Width = 70;
            // 
            // ColumnTradeInLineListId
            // 
            this.ColumnTradeInLineListId.DataPropertyName = "ColumnTradeInLineListId";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.ColumnTradeInLineListId.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnTradeInLineListId.HeaderText = "Id";
            this.ColumnTradeInLineListId.MinimumWidth = 6;
            this.ColumnTradeInLineListId.Name = "ColumnTradeInLineListId";
            this.ColumnTradeInLineListId.ReadOnly = true;
            this.ColumnTradeInLineListId.Visible = false;
            this.ColumnTradeInLineListId.Width = 125;
            // 
            // ColumnTradeInLineListTradeInId
            // 
            this.ColumnTradeInLineListTradeInId.DataPropertyName = "ColumnTradeInLineListTradeInId";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.ColumnTradeInLineListTradeInId.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnTradeInLineListTradeInId.HeaderText = "TradeInId";
            this.ColumnTradeInLineListTradeInId.MinimumWidth = 6;
            this.ColumnTradeInLineListTradeInId.Name = "ColumnTradeInLineListTradeInId";
            this.ColumnTradeInLineListTradeInId.ReadOnly = true;
            this.ColumnTradeInLineListTradeInId.Visible = false;
            this.ColumnTradeInLineListTradeInId.Width = 125;
            // 
            // ColumnTradeInLineListItemId
            // 
            this.ColumnTradeInLineListItemId.DataPropertyName = "ColumnTradeInLineListItemId";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.ColumnTradeInLineListItemId.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColumnTradeInLineListItemId.HeaderText = "ItemId";
            this.ColumnTradeInLineListItemId.MinimumWidth = 6;
            this.ColumnTradeInLineListItemId.Name = "ColumnTradeInLineListItemId";
            this.ColumnTradeInLineListItemId.ReadOnly = true;
            this.ColumnTradeInLineListItemId.Visible = false;
            this.ColumnTradeInLineListItemId.Width = 125;
            // 
            // ColumnTradeInLineListItemSize
            // 
            this.ColumnTradeInLineListItemSize.DataPropertyName = "ColumnTradeInLineListItemSize";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.ColumnTradeInLineListItemSize.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColumnTradeInLineListItemSize.HeaderText = "Size";
            this.ColumnTradeInLineListItemSize.MinimumWidth = 6;
            this.ColumnTradeInLineListItemSize.Name = "ColumnTradeInLineListItemSize";
            this.ColumnTradeInLineListItemSize.ReadOnly = true;
            this.ColumnTradeInLineListItemSize.Width = 150;
            // 
            // ColumnTradeInLineListItemBrand
            // 
            this.ColumnTradeInLineListItemBrand.DataPropertyName = "ColumnTradeInLineListItemBrand";
            this.ColumnTradeInLineListItemBrand.HeaderText = "Brand";
            this.ColumnTradeInLineListItemBrand.MinimumWidth = 6;
            this.ColumnTradeInLineListItemBrand.Name = "ColumnTradeInLineListItemBrand";
            this.ColumnTradeInLineListItemBrand.ReadOnly = true;
            this.ColumnTradeInLineListItemBrand.Width = 150;
            // 
            // ColumnTradeInLineListItemWarrantyCode
            // 
            this.ColumnTradeInLineListItemWarrantyCode.DataPropertyName = "ColumnTradeInLineListItemWarrantyCode";
            this.ColumnTradeInLineListItemWarrantyCode.HeaderText = "Warranty Code";
            this.ColumnTradeInLineListItemWarrantyCode.MinimumWidth = 6;
            this.ColumnTradeInLineListItemWarrantyCode.Name = "ColumnTradeInLineListItemWarrantyCode";
            this.ColumnTradeInLineListItemWarrantyCode.ReadOnly = true;
            this.ColumnTradeInLineListItemWarrantyCode.Width = 200;
            // 
            // ColumnTradeInLineListQuantity
            // 
            this.ColumnTradeInLineListQuantity.DataPropertyName = "ColumnTradeInLineListQuantity";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.ColumnTradeInLineListQuantity.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColumnTradeInLineListQuantity.HeaderText = "Quantity";
            this.ColumnTradeInLineListQuantity.MinimumWidth = 6;
            this.ColumnTradeInLineListQuantity.Name = "ColumnTradeInLineListQuantity";
            this.ColumnTradeInLineListQuantity.ReadOnly = true;
            this.ColumnTradeInLineListQuantity.Width = 125;
            // 
            // ColumnTradeInLineListAmount
            // 
            this.ColumnTradeInLineListAmount.DataPropertyName = "ColumnTradeInLineListAmount";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.ColumnTradeInLineListAmount.DefaultCellStyle = dataGridViewCellStyle9;
            this.ColumnTradeInLineListAmount.HeaderText = "Amount";
            this.ColumnTradeInLineListAmount.MinimumWidth = 6;
            this.ColumnTradeInLineListAmount.Name = "ColumnTradeInLineListAmount";
            this.ColumnTradeInLineListAmount.ReadOnly = true;
            this.ColumnTradeInLineListAmount.Width = 125;
            // 
            // TrnPOSTradeInDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1245, 710);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewTradeInLineList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxRemarks);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBoxPreparedBy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerTradeInDate);
            this.Controls.Add(this.textBoxTradeInNumber);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TrnPOSTradeInDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trade - In Detail";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTradeInLineList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRemarks;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxPreparedBy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerTradeInDate;
        private System.Windows.Forms.TextBox textBoxTradeInNumber;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button buttonTradeInLineListPageListFirst;
        private System.Windows.Forms.Button buttonTradeInLineListPageListPrevious;
        private System.Windows.Forms.Button buttonTradeInLineListPageListNext;
        private System.Windows.Forms.Button buttonTradeInLineListPageListLast;
        private System.Windows.Forms.TextBox textBoxTradeInLineListPageNumber;
        private System.Windows.Forms.Button buttonAdd;
        public System.Windows.Forms.DataGridView dataGridViewTradeInLineList;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnTradeInLineListButtonEdit;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnTradeInLineListButtonDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTradeInLineListId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTradeInLineListTradeInId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTradeInLineListItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTradeInLineListItemSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTradeInLineListItemBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTradeInLineListItemWarrantyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTradeInLineListQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTradeInLineListAmount;
    }
}