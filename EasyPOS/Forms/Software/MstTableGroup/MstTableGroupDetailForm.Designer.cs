namespace EasyPOS.Forms.Software.MstTableGroup
{
    partial class MstTableGroupDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MstTableGroupDetailForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonAddTable = new System.Windows.Forms.Button();
            this.dataGridViewTableList = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonTableListPageListFirst = new System.Windows.Forms.Button();
            this.buttonTableListPageListPrevious = new System.Windows.Forms.Button();
            this.buttonTableListPageListNext = new System.Windows.Forms.Button();
            this.buttonTableListPageListLast = new System.Windows.Forms.Button();
            this.textBoxTableListPageNumber = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTableGroup = new System.Windows.Forms.TextBox();
            this.buttonLock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonUnlock = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ColumnTableListButtonEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnTableListButtonDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnTableListId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTableListTableCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTableListSortNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTableListTableGroupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTableList)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 638);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1370, 638);
            this.panel3.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.buttonAddTable);
            this.panel5.Controls.Add(this.dataGridViewTableList);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 61);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1370, 525);
            this.panel5.TabIndex = 30;
            // 
            // buttonAddTable
            // 
            this.buttonAddTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonAddTable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(34)))), ((int)(((byte)(116)))));
            this.buttonAddTable.FlatAppearance.BorderSize = 0;
            this.buttonAddTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTable.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonAddTable.ForeColor = System.Drawing.Color.White;
            this.buttonAddTable.Location = new System.Drawing.Point(1270, 6);
            this.buttonAddTable.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddTable.Name = "buttonAddTable";
            this.buttonAddTable.Size = new System.Drawing.Size(88, 40);
            this.buttonAddTable.TabIndex = 25;
            this.buttonAddTable.TabStop = false;
            this.buttonAddTable.Text = "Add";
            this.buttonAddTable.UseVisualStyleBackColor = false;
            this.buttonAddTable.Click += new System.EventHandler(this.buttonAddTable_Click);
            // 
            // dataGridViewTableList
            // 
            this.dataGridViewTableList.AllowUserToAddRows = false;
            this.dataGridViewTableList.AllowUserToDeleteRows = false;
            this.dataGridViewTableList.AllowUserToResizeRows = false;
            this.dataGridViewTableList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTableList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTableList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTableList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTableList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTableListButtonEdit,
            this.ColumnTableListButtonDelete,
            this.ColumnTableListId,
            this.ColumnTableListTableCode,
            this.ColumnTableListSortNumber,
            this.ColumnTableListTableGroupId});
            this.dataGridViewTableList.Location = new System.Drawing.Point(12, 52);
            this.dataGridViewTableList.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewTableList.MultiSelect = false;
            this.dataGridViewTableList.Name = "dataGridViewTableList";
            this.dataGridViewTableList.ReadOnly = true;
            this.dataGridViewTableList.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.dataGridViewTableList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTableList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.dataGridViewTableList.RowTemplate.Height = 24;
            this.dataGridViewTableList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTableList.Size = new System.Drawing.Size(1346, 467);
            this.dataGridViewTableList.TabIndex = 1;
            this.dataGridViewTableList.TabStop = false;
            this.dataGridViewTableList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTableList_CellClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.buttonTableListPageListFirst);
            this.panel4.Controls.Add(this.buttonTableListPageListPrevious);
            this.panel4.Controls.Add(this.buttonTableListPageListNext);
            this.panel4.Controls.Add(this.buttonTableListPageListLast);
            this.panel4.Controls.Add(this.textBoxTableListPageNumber);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 586);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1370, 52);
            this.panel4.TabIndex = 25;
            // 
            // buttonTableListPageListFirst
            // 
            this.buttonTableListPageListFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonTableListPageListFirst.Enabled = false;
            this.buttonTableListPageListFirst.FlatAppearance.BorderSize = 0;
            this.buttonTableListPageListFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTableListPageListFirst.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonTableListPageListFirst.Location = new System.Drawing.Point(12, 11);
            this.buttonTableListPageListFirst.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTableListPageListFirst.Name = "buttonTableListPageListFirst";
            this.buttonTableListPageListFirst.Size = new System.Drawing.Size(82, 32);
            this.buttonTableListPageListFirst.TabIndex = 23;
            this.buttonTableListPageListFirst.TabStop = false;
            this.buttonTableListPageListFirst.Text = "First";
            this.buttonTableListPageListFirst.UseVisualStyleBackColor = false;
            this.buttonTableListPageListFirst.Click += new System.EventHandler(this.buttonTableListPageListFirst_Click);
            // 
            // buttonTableListPageListPrevious
            // 
            this.buttonTableListPageListPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonTableListPageListPrevious.Enabled = false;
            this.buttonTableListPageListPrevious.FlatAppearance.BorderSize = 0;
            this.buttonTableListPageListPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTableListPageListPrevious.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonTableListPageListPrevious.Location = new System.Drawing.Point(100, 11);
            this.buttonTableListPageListPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTableListPageListPrevious.Name = "buttonTableListPageListPrevious";
            this.buttonTableListPageListPrevious.Size = new System.Drawing.Size(82, 32);
            this.buttonTableListPageListPrevious.TabIndex = 24;
            this.buttonTableListPageListPrevious.TabStop = false;
            this.buttonTableListPageListPrevious.Text = "Previous";
            this.buttonTableListPageListPrevious.UseVisualStyleBackColor = false;
            this.buttonTableListPageListPrevious.Click += new System.EventHandler(this.buttonTableListPageListPrevious_Click);
            // 
            // buttonTableListPageListNext
            // 
            this.buttonTableListPageListNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonTableListPageListNext.FlatAppearance.BorderSize = 0;
            this.buttonTableListPageListNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTableListPageListNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonTableListPageListNext.Location = new System.Drawing.Point(262, 11);
            this.buttonTableListPageListNext.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTableListPageListNext.Name = "buttonTableListPageListNext";
            this.buttonTableListPageListNext.Size = new System.Drawing.Size(82, 32);
            this.buttonTableListPageListNext.TabIndex = 26;
            this.buttonTableListPageListNext.TabStop = false;
            this.buttonTableListPageListNext.Text = "Next";
            this.buttonTableListPageListNext.UseVisualStyleBackColor = false;
            this.buttonTableListPageListNext.Click += new System.EventHandler(this.buttonTableListPageListNext_Click);
            // 
            // buttonTableListPageListLast
            // 
            this.buttonTableListPageListLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonTableListPageListLast.FlatAppearance.BorderSize = 0;
            this.buttonTableListPageListLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTableListPageListLast.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonTableListPageListLast.Location = new System.Drawing.Point(348, 11);
            this.buttonTableListPageListLast.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTableListPageListLast.Name = "buttonTableListPageListLast";
            this.buttonTableListPageListLast.Size = new System.Drawing.Size(82, 32);
            this.buttonTableListPageListLast.TabIndex = 26;
            this.buttonTableListPageListLast.TabStop = false;
            this.buttonTableListPageListLast.Text = "Last";
            this.buttonTableListPageListLast.UseVisualStyleBackColor = false;
            this.buttonTableListPageListLast.Click += new System.EventHandler(this.buttonTableListPageListLast_Click);
            // 
            // textBoxTableListPageNumber
            // 
            this.textBoxTableListPageNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxTableListPageNumber.BackColor = System.Drawing.Color.White;
            this.textBoxTableListPageNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTableListPageNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxTableListPageNumber.Location = new System.Drawing.Point(188, 16);
            this.textBoxTableListPageNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTableListPageNumber.Name = "textBoxTableListPageNumber";
            this.textBoxTableListPageNumber.ReadOnly = true;
            this.textBoxTableListPageNumber.Size = new System.Drawing.Size(69, 20);
            this.textBoxTableListPageNumber.TabIndex = 25;
            this.textBoxTableListPageNumber.TabStop = false;
            this.textBoxTableListPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.textBoxTableGroup);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.panel7.Size = new System.Drawing.Size(1370, 61);
            this.panel7.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label2.Location = new System.Drawing.Point(14, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Table Group:";
            // 
            // textBoxTableGroup
            // 
            this.textBoxTableGroup.AcceptsTab = true;
            this.textBoxTableGroup.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.textBoxTableGroup.HideSelection = false;
            this.textBoxTableGroup.Location = new System.Drawing.Point(122, 11);
            this.textBoxTableGroup.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTableGroup.Name = "textBoxTableGroup";
            this.textBoxTableGroup.Size = new System.Drawing.Size(276, 30);
            this.textBoxTableGroup.TabIndex = 0;
            // 
            // buttonLock
            // 
            this.buttonLock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonLock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonLock.FlatAppearance.BorderSize = 0;
            this.buttonLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLock.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLock.ForeColor = System.Drawing.Color.White;
            this.buttonLock.Location = new System.Drawing.Point(1082, 12);
            this.buttonLock.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLock.Name = "buttonLock";
            this.buttonLock.Size = new System.Drawing.Size(88, 40);
            this.buttonLock.TabIndex = 20;
            this.buttonLock.TabStop = false;
            this.buttonLock.Text = "Lock";
            this.buttonLock.UseVisualStyleBackColor = false;
            this.buttonLock.Click += new System.EventHandler(this.buttonLock_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(62, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Table Group Detail";
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
            this.buttonClose.Location = new System.Drawing.Point(1270, 12);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(88, 40);
            this.buttonClose.TabIndex = 22;
            this.buttonClose.TabStop = false;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonUnlock
            // 
            this.buttonUnlock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUnlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonUnlock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonUnlock.FlatAppearance.BorderSize = 0;
            this.buttonUnlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUnlock.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnlock.ForeColor = System.Drawing.Color.White;
            this.buttonUnlock.Location = new System.Drawing.Point(1176, 12);
            this.buttonUnlock.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUnlock.Name = "buttonUnlock";
            this.buttonUnlock.Size = new System.Drawing.Size(88, 40);
            this.buttonUnlock.TabIndex = 21;
            this.buttonUnlock.TabStop = false;
            this.buttonUnlock.Text = "Unlock";
            this.buttonUnlock.UseVisualStyleBackColor = false;
            this.buttonUnlock.Click += new System.EventHandler(this.buttonUnlock_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonLock);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.buttonUnlock);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 62);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ColumnTableListButtonEdit
            // 
            this.ColumnTableListButtonEdit.DataPropertyName = "ColumnTableListButtonEdit";
            this.ColumnTableListButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnTableListButtonEdit.HeaderText = "";
            this.ColumnTableListButtonEdit.MinimumWidth = 6;
            this.ColumnTableListButtonEdit.Name = "ColumnTableListButtonEdit";
            this.ColumnTableListButtonEdit.ReadOnly = true;
            this.ColumnTableListButtonEdit.Width = 70;
            // 
            // ColumnTableListButtonDelete
            // 
            this.ColumnTableListButtonDelete.DataPropertyName = "ColumnTableListButtonDelete";
            this.ColumnTableListButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnTableListButtonDelete.HeaderText = "";
            this.ColumnTableListButtonDelete.MinimumWidth = 6;
            this.ColumnTableListButtonDelete.Name = "ColumnTableListButtonDelete";
            this.ColumnTableListButtonDelete.ReadOnly = true;
            this.ColumnTableListButtonDelete.Width = 70;
            // 
            // ColumnTableListId
            // 
            this.ColumnTableListId.DataPropertyName = "ColumnTableListId";
            this.ColumnTableListId.HeaderText = "Id";
            this.ColumnTableListId.MinimumWidth = 6;
            this.ColumnTableListId.Name = "ColumnTableListId";
            this.ColumnTableListId.ReadOnly = true;
            this.ColumnTableListId.Visible = false;
            this.ColumnTableListId.Width = 125;
            // 
            // ColumnTableListTableCode
            // 
            this.ColumnTableListTableCode.DataPropertyName = "ColumnTableListTableCode";
            this.ColumnTableListTableCode.HeaderText = "Table Code";
            this.ColumnTableListTableCode.MinimumWidth = 6;
            this.ColumnTableListTableCode.Name = "ColumnTableListTableCode";
            this.ColumnTableListTableCode.ReadOnly = true;
            this.ColumnTableListTableCode.Width = 300;
            // 
            // ColumnTableListSortNumber
            // 
            this.ColumnTableListSortNumber.DataPropertyName = "ColumnTableListSortNumber";
            this.ColumnTableListSortNumber.HeaderText = "Sort Number";
            this.ColumnTableListSortNumber.MinimumWidth = 6;
            this.ColumnTableListSortNumber.Name = "ColumnTableListSortNumber";
            this.ColumnTableListSortNumber.ReadOnly = true;
            this.ColumnTableListSortNumber.Width = 150;
            // 
            // ColumnTableListTableGroupId
            // 
            this.ColumnTableListTableGroupId.DataPropertyName = "ColumnTableListTableGroupId";
            this.ColumnTableListTableGroupId.HeaderText = "Table Group Id";
            this.ColumnTableListTableGroupId.MinimumWidth = 6;
            this.ColumnTableListTableGroupId.Name = "ColumnTableListTableGroupId";
            this.ColumnTableListTableGroupId.ReadOnly = true;
            this.ColumnTableListTableGroupId.Visible = false;
            this.ColumnTableListTableGroupId.Width = 125;
            // 
            // MstTableGroupDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1370, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "MstTableGroupDetailForm";
            this.Text = "MstTableDetailForm";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTableList)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonLock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonUnlock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonTableListPageListFirst;
        private System.Windows.Forms.Button buttonTableListPageListPrevious;
        private System.Windows.Forms.Button buttonTableListPageListNext;
        private System.Windows.Forms.Button buttonTableListPageListLast;
        private System.Windows.Forms.TextBox textBoxTableListPageNumber;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTableGroup;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridViewTableList;
        private System.Windows.Forms.Button buttonAddTable;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnTableListButtonEdit;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnTableListButtonDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTableListId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTableListTableCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTableListSortNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTableListTableGroupId;
    }
}