
namespace EasyPOS.Forms.Software.TrnPOS
{
    partial class TrnPOSDefectiveDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrnPOSDefectiveDetailForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.buttonDefectiveLineListPageListFirst = new System.Windows.Forms.Button();
            this.buttonDefectiveLineListPageListPrevious = new System.Windows.Forms.Button();
            this.buttonDefectiveLineListPageListNext = new System.Windows.Forms.Button();
            this.buttonDefectiveLineListPageListLast = new System.Windows.Forms.Button();
            this.textBoxDefectiveLineListPageNumber = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxWarrantyCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxInvoiceNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxPreparedBy = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerDefectiveDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxDefectiveNumber = new System.Windows.Forms.TextBox();
            this.dataGridViewDefectiveLineList = new System.Windows.Forms.DataGridView();
            this.ColumnDefectiveLineButtonEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnDefectiveLineButtonDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnDefectiveLineId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDefectiveLineItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDefectiveLineItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDefectiveLineQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDefectiveLineAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel15.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefectiveLineList)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1095, 62);
            this.panel1.TabIndex = 7;
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
            this.buttonEdit.Location = new System.Drawing.Point(808, 11);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(135, 40);
            this.buttonEdit.TabIndex = 8;
            this.buttonEdit.TabStop = false;
            this.buttonEdit.Text = "Edit";
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
            this.buttonSave.Location = new System.Drawing.Point(669, 11);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(135, 40);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.TabStop = false;
            this.buttonSave.Text = "Save";
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
            this.label1.Size = new System.Drawing.Size(128, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Defective";
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
            this.buttonClose.Location = new System.Drawing.Point(947, 12);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(136, 40);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.TabStop = false;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.White;
            this.panel15.Controls.Add(this.buttonDefectiveLineListPageListFirst);
            this.panel15.Controls.Add(this.buttonDefectiveLineListPageListPrevious);
            this.panel15.Controls.Add(this.buttonDefectiveLineListPageListNext);
            this.panel15.Controls.Add(this.buttonDefectiveLineListPageListLast);
            this.panel15.Controls.Add(this.textBoxDefectiveLineListPageNumber);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel15.Location = new System.Drawing.Point(0, 480);
            this.panel15.Margin = new System.Windows.Forms.Padding(2);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(1095, 52);
            this.panel15.TabIndex = 28;
            // 
            // buttonDefectiveLineListPageListFirst
            // 
            this.buttonDefectiveLineListPageListFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDefectiveLineListPageListFirst.Enabled = false;
            this.buttonDefectiveLineListPageListFirst.FlatAppearance.BorderSize = 0;
            this.buttonDefectiveLineListPageListFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDefectiveLineListPageListFirst.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonDefectiveLineListPageListFirst.Location = new System.Drawing.Point(12, 9);
            this.buttonDefectiveLineListPageListFirst.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDefectiveLineListPageListFirst.Name = "buttonDefectiveLineListPageListFirst";
            this.buttonDefectiveLineListPageListFirst.Size = new System.Drawing.Size(82, 32);
            this.buttonDefectiveLineListPageListFirst.TabIndex = 13;
            this.buttonDefectiveLineListPageListFirst.Text = "First";
            this.buttonDefectiveLineListPageListFirst.UseVisualStyleBackColor = false;
            this.buttonDefectiveLineListPageListFirst.Click += new System.EventHandler(this.buttonDefectiveLineListPageListFirst_Click);
            // 
            // buttonDefectiveLineListPageListPrevious
            // 
            this.buttonDefectiveLineListPageListPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDefectiveLineListPageListPrevious.Enabled = false;
            this.buttonDefectiveLineListPageListPrevious.FlatAppearance.BorderSize = 0;
            this.buttonDefectiveLineListPageListPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDefectiveLineListPageListPrevious.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonDefectiveLineListPageListPrevious.Location = new System.Drawing.Point(100, 9);
            this.buttonDefectiveLineListPageListPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDefectiveLineListPageListPrevious.Name = "buttonDefectiveLineListPageListPrevious";
            this.buttonDefectiveLineListPageListPrevious.Size = new System.Drawing.Size(82, 32);
            this.buttonDefectiveLineListPageListPrevious.TabIndex = 14;
            this.buttonDefectiveLineListPageListPrevious.Text = "Previous";
            this.buttonDefectiveLineListPageListPrevious.UseVisualStyleBackColor = false;
            this.buttonDefectiveLineListPageListPrevious.Click += new System.EventHandler(this.buttonDefectiveLineListPageListPrevious_Click);
            // 
            // buttonDefectiveLineListPageListNext
            // 
            this.buttonDefectiveLineListPageListNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDefectiveLineListPageListNext.FlatAppearance.BorderSize = 0;
            this.buttonDefectiveLineListPageListNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDefectiveLineListPageListNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonDefectiveLineListPageListNext.Location = new System.Drawing.Point(262, 9);
            this.buttonDefectiveLineListPageListNext.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDefectiveLineListPageListNext.Name = "buttonDefectiveLineListPageListNext";
            this.buttonDefectiveLineListPageListNext.Size = new System.Drawing.Size(82, 32);
            this.buttonDefectiveLineListPageListNext.TabIndex = 15;
            this.buttonDefectiveLineListPageListNext.Text = "Next";
            this.buttonDefectiveLineListPageListNext.UseVisualStyleBackColor = false;
            this.buttonDefectiveLineListPageListNext.Click += new System.EventHandler(this.buttonDefectiveLineListPageListNext_Click);
            // 
            // buttonDefectiveLineListPageListLast
            // 
            this.buttonDefectiveLineListPageListLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDefectiveLineListPageListLast.FlatAppearance.BorderSize = 0;
            this.buttonDefectiveLineListPageListLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDefectiveLineListPageListLast.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonDefectiveLineListPageListLast.Location = new System.Drawing.Point(348, 9);
            this.buttonDefectiveLineListPageListLast.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDefectiveLineListPageListLast.Name = "buttonDefectiveLineListPageListLast";
            this.buttonDefectiveLineListPageListLast.Size = new System.Drawing.Size(82, 32);
            this.buttonDefectiveLineListPageListLast.TabIndex = 16;
            this.buttonDefectiveLineListPageListLast.Text = "Last";
            this.buttonDefectiveLineListPageListLast.UseVisualStyleBackColor = false;
            // 
            // textBoxDefectiveLineListPageNumber
            // 
            this.textBoxDefectiveLineListPageNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxDefectiveLineListPageNumber.BackColor = System.Drawing.Color.White;
            this.textBoxDefectiveLineListPageNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDefectiveLineListPageNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxDefectiveLineListPageNumber.Location = new System.Drawing.Point(188, 14);
            this.textBoxDefectiveLineListPageNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDefectiveLineListPageNumber.Name = "textBoxDefectiveLineListPageNumber";
            this.textBoxDefectiveLineListPageNumber.ReadOnly = true;
            this.textBoxDefectiveLineListPageNumber.Size = new System.Drawing.Size(69, 20);
            this.textBoxDefectiveLineListPageNumber.TabIndex = 17;
            this.textBoxDefectiveLineListPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.buttonAdd);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBoxWarrantyCode);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBoxCustomerName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBoxInvoiceNo);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.comboBoxPreparedBy);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dateTimePickerDefectiveDate);
            this.panel2.Controls.Add(this.textBoxDefectiveNumber);
            this.panel2.Controls.Add(this.dataGridViewDefectiveLineList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1095, 418);
            this.panel2.TabIndex = 29;
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
            this.buttonAdd.Location = new System.Drawing.Point(947, 143);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(135, 40);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.TabStop = false;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label6.Location = new System.Drawing.Point(27, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 23);
            this.label6.TabIndex = 41;
            this.label6.Text = "Warranty Code :";
            // 
            // textBoxWarrantyCode
            // 
            this.textBoxWarrantyCode.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.textBoxWarrantyCode.Location = new System.Drawing.Point(188, 91);
            this.textBoxWarrantyCode.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxWarrantyCode.Name = "textBoxWarrantyCode";
            this.textBoxWarrantyCode.Size = new System.Drawing.Size(194, 30);
            this.textBoxWarrantyCode.TabIndex = 40;
            this.textBoxWarrantyCode.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label5.Location = new System.Drawing.Point(407, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 23);
            this.label5.TabIndex = 39;
            this.label5.Text = "Customer Name :";
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Enabled = false;
            this.textBoxCustomerName.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.textBoxCustomerName.Location = new System.Drawing.Point(589, 94);
            this.textBoxCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(494, 30);
            this.textBoxCustomerName.TabIndex = 38;
            this.textBoxCustomerName.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label3.Location = new System.Drawing.Point(27, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 23);
            this.label3.TabIndex = 37;
            this.label3.Text = "Invoice Number :";
            // 
            // textBoxInvoiceNo
            // 
            this.textBoxInvoiceNo.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.textBoxInvoiceNo.Location = new System.Drawing.Point(188, 49);
            this.textBoxInvoiceNo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxInvoiceNo.Name = "textBoxInvoiceNo";
            this.textBoxInvoiceNo.Size = new System.Drawing.Size(194, 30);
            this.textBoxInvoiceNo.TabIndex = 36;
            this.textBoxInvoiceNo.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label11.Location = new System.Drawing.Point(445, 55);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 23);
            this.label11.TabIndex = 35;
            this.label11.Text = "Prepared by:";
            // 
            // comboBoxPreparedBy
            // 
            this.comboBoxPreparedBy.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.comboBoxPreparedBy.FormattingEnabled = true;
            this.comboBoxPreparedBy.Location = new System.Drawing.Point(589, 49);
            this.comboBoxPreparedBy.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPreparedBy.Name = "comboBoxPreparedBy";
            this.comboBoxPreparedBy.Size = new System.Drawing.Size(288, 31);
            this.comboBoxPreparedBy.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label4.Location = new System.Drawing.Point(421, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 23);
            this.label4.TabIndex = 34;
            this.label4.Text = "Defective Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label2.Location = new System.Drawing.Point(11, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 23);
            this.label2.TabIndex = 32;
            this.label2.Text = "Defective Number :";
            // 
            // dateTimePickerDefectiveDate
            // 
            this.dateTimePickerDefectiveDate.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.dateTimePickerDefectiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDefectiveDate.Location = new System.Drawing.Point(589, 10);
            this.dateTimePickerDefectiveDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerDefectiveDate.Name = "dateTimePickerDefectiveDate";
            this.dateTimePickerDefectiveDate.Size = new System.Drawing.Size(208, 30);
            this.dateTimePickerDefectiveDate.TabIndex = 31;
            // 
            // textBoxDefectiveNumber
            // 
            this.textBoxDefectiveNumber.Enabled = false;
            this.textBoxDefectiveNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.textBoxDefectiveNumber.Location = new System.Drawing.Point(188, 9);
            this.textBoxDefectiveNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDefectiveNumber.Name = "textBoxDefectiveNumber";
            this.textBoxDefectiveNumber.Size = new System.Drawing.Size(194, 30);
            this.textBoxDefectiveNumber.TabIndex = 30;
            this.textBoxDefectiveNumber.TabStop = false;
            // 
            // dataGridViewDefectiveLineList
            // 
            this.dataGridViewDefectiveLineList.AllowUserToAddRows = false;
            this.dataGridViewDefectiveLineList.AllowUserToDeleteRows = false;
            this.dataGridViewDefectiveLineList.AllowUserToResizeRows = false;
            this.dataGridViewDefectiveLineList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDefectiveLineList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDefectiveLineList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDefectiveLineList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDefectiveLineList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDefectiveLineButtonEdit,
            this.ColumnDefectiveLineButtonDelete,
            this.ColumnDefectiveLineId,
            this.ColumnDefectiveLineItemId,
            this.ColumnDefectiveLineItemDescription,
            this.ColumnDefectiveLineQuantity,
            this.ColumnDefectiveLineAmount});
            this.dataGridViewDefectiveLineList.Location = new System.Drawing.Point(11, 187);
            this.dataGridViewDefectiveLineList.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDefectiveLineList.MultiSelect = false;
            this.dataGridViewDefectiveLineList.Name = "dataGridViewDefectiveLineList";
            this.dataGridViewDefectiveLineList.ReadOnly = true;
            this.dataGridViewDefectiveLineList.RowHeadersVisible = false;
            this.dataGridViewDefectiveLineList.RowHeadersWidth = 51;
            this.dataGridViewDefectiveLineList.RowTemplate.Height = 24;
            this.dataGridViewDefectiveLineList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDefectiveLineList.Size = new System.Drawing.Size(1072, 227);
            this.dataGridViewDefectiveLineList.TabIndex = 29;
            // 
            // ColumnDefectiveLineButtonEdit
            // 
            this.ColumnDefectiveLineButtonEdit.DataPropertyName = "ColumnDefectiveLineButtonEdit";
            this.ColumnDefectiveLineButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnDefectiveLineButtonEdit.Frozen = true;
            this.ColumnDefectiveLineButtonEdit.HeaderText = "";
            this.ColumnDefectiveLineButtonEdit.MinimumWidth = 6;
            this.ColumnDefectiveLineButtonEdit.Name = "ColumnDefectiveLineButtonEdit";
            this.ColumnDefectiveLineButtonEdit.ReadOnly = true;
            this.ColumnDefectiveLineButtonEdit.Width = 70;
            // 
            // ColumnDefectiveLineButtonDelete
            // 
            this.ColumnDefectiveLineButtonDelete.DataPropertyName = "ColumnDefectiveLineButtonDelete";
            this.ColumnDefectiveLineButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnDefectiveLineButtonDelete.Frozen = true;
            this.ColumnDefectiveLineButtonDelete.HeaderText = "";
            this.ColumnDefectiveLineButtonDelete.MinimumWidth = 6;
            this.ColumnDefectiveLineButtonDelete.Name = "ColumnDefectiveLineButtonDelete";
            this.ColumnDefectiveLineButtonDelete.ReadOnly = true;
            this.ColumnDefectiveLineButtonDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnDefectiveLineButtonDelete.Width = 70;
            // 
            // ColumnDefectiveLineId
            // 
            this.ColumnDefectiveLineId.DataPropertyName = "ColumnDefectiveLineId";
            this.ColumnDefectiveLineId.HeaderText = "Id";
            this.ColumnDefectiveLineId.MinimumWidth = 6;
            this.ColumnDefectiveLineId.Name = "ColumnDefectiveLineId";
            this.ColumnDefectiveLineId.ReadOnly = true;
            this.ColumnDefectiveLineId.Visible = false;
            this.ColumnDefectiveLineId.Width = 125;
            // 
            // ColumnDefectiveLineItemId
            // 
            this.ColumnDefectiveLineItemId.DataPropertyName = "ColumnDefectiveLineItemId";
            this.ColumnDefectiveLineItemId.HeaderText = "ItemId";
            this.ColumnDefectiveLineItemId.MinimumWidth = 6;
            this.ColumnDefectiveLineItemId.Name = "ColumnDefectiveLineItemId";
            this.ColumnDefectiveLineItemId.ReadOnly = true;
            this.ColumnDefectiveLineItemId.Visible = false;
            this.ColumnDefectiveLineItemId.Width = 125;
            // 
            // ColumnDefectiveLineItemDescription
            // 
            this.ColumnDefectiveLineItemDescription.DataPropertyName = "ColumnDefectiveLineItemDescription";
            this.ColumnDefectiveLineItemDescription.HeaderText = "Item Description";
            this.ColumnDefectiveLineItemDescription.MinimumWidth = 6;
            this.ColumnDefectiveLineItemDescription.Name = "ColumnDefectiveLineItemDescription";
            this.ColumnDefectiveLineItemDescription.ReadOnly = true;
            this.ColumnDefectiveLineItemDescription.Width = 200;
            // 
            // ColumnDefectiveLineQuantity
            // 
            this.ColumnDefectiveLineQuantity.DataPropertyName = "ColumnDefectiveLineQuantity";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnDefectiveLineQuantity.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnDefectiveLineQuantity.HeaderText = "Quantity";
            this.ColumnDefectiveLineQuantity.MinimumWidth = 6;
            this.ColumnDefectiveLineQuantity.Name = "ColumnDefectiveLineQuantity";
            this.ColumnDefectiveLineQuantity.ReadOnly = true;
            this.ColumnDefectiveLineQuantity.Width = 125;
            // 
            // ColumnDefectiveLineAmount
            // 
            this.ColumnDefectiveLineAmount.DataPropertyName = "ColumnDefectiveLineAmount";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnDefectiveLineAmount.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnDefectiveLineAmount.HeaderText = "Amount";
            this.ColumnDefectiveLineAmount.MinimumWidth = 6;
            this.ColumnDefectiveLineAmount.Name = "ColumnDefectiveLineAmount";
            this.ColumnDefectiveLineAmount.ReadOnly = true;
            this.ColumnDefectiveLineAmount.Width = 125;
            // 
            // TrnPOSDefectiveDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 532);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrnPOSDefectiveDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Defective";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefectiveLineList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button buttonDefectiveLineListPageListFirst;
        private System.Windows.Forms.Button buttonDefectiveLineListPageListPrevious;
        private System.Windows.Forms.Button buttonDefectiveLineListPageListNext;
        private System.Windows.Forms.Button buttonDefectiveLineListPageListLast;
        private System.Windows.Forms.TextBox textBoxDefectiveLineListPageNumber;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView dataGridViewDefectiveLineList;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxPreparedBy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDefectiveDate;
        private System.Windows.Forms.TextBox textBoxDefectiveNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxWarrantyCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxInvoiceNo;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDefectiveLineButtonEdit;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDefectiveLineButtonDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDefectiveLineId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDefectiveLineItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDefectiveLineItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDefectiveLineQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDefectiveLineAmount;
        private System.Windows.Forms.Button buttonEdit;
    }
}