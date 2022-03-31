namespace EasyPOS.Forms.Software.TrnPOS
{
    partial class TrnPOSItemPriceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrnPOSItemPriceForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.buttonItemPriceListPageListFirst = new System.Windows.Forms.Button();
            this.buttonItemPriceListPageListPrevious = new System.Windows.Forms.Button();
            this.buttonItemPriceListPageListNext = new System.Windows.Forms.Button();
            this.buttonItemPriceListPageListLast = new System.Windows.Forms.Button();
            this.textBoxItemPriceListPageNumber = new System.Windows.Forms.TextBox();
            this.dataGridViewItemPriceList = new System.Windows.Forms.DataGridView();
            this.ColumnItemPriceListButtonPick = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnItemPriceListPriceDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnItemPriceListPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxItemDescription = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemPriceList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 62);
            this.panel1.TabIndex = 6;
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
            this.label1.Size = new System.Drawing.Size(183, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item Price List";
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
            this.buttonClose.Location = new System.Drawing.Point(528, 12);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(136, 40);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.TabStop = false;
            this.buttonClose.Text = "Esc - Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.panel15);
            this.panel2.Controls.Add(this.dataGridViewItemPriceList);
            this.panel2.Controls.Add(this.textBoxItemDescription);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(675, 314);
            this.panel2.TabIndex = 7;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.White;
            this.panel15.Controls.Add(this.buttonItemPriceListPageListFirst);
            this.panel15.Controls.Add(this.buttonItemPriceListPageListPrevious);
            this.panel15.Controls.Add(this.buttonItemPriceListPageListNext);
            this.panel15.Controls.Add(this.buttonItemPriceListPageListLast);
            this.panel15.Controls.Add(this.textBoxItemPriceListPageNumber);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel15.Location = new System.Drawing.Point(0, 262);
            this.panel15.Margin = new System.Windows.Forms.Padding(2);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(675, 52);
            this.panel15.TabIndex = 26;
            // 
            // buttonItemPriceListPageListFirst
            // 
            this.buttonItemPriceListPageListFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonItemPriceListPageListFirst.Enabled = false;
            this.buttonItemPriceListPageListFirst.FlatAppearance.BorderSize = 0;
            this.buttonItemPriceListPageListFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonItemPriceListPageListFirst.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonItemPriceListPageListFirst.Location = new System.Drawing.Point(12, 9);
            this.buttonItemPriceListPageListFirst.Margin = new System.Windows.Forms.Padding(2);
            this.buttonItemPriceListPageListFirst.Name = "buttonItemPriceListPageListFirst";
            this.buttonItemPriceListPageListFirst.Size = new System.Drawing.Size(82, 32);
            this.buttonItemPriceListPageListFirst.TabIndex = 13;
            this.buttonItemPriceListPageListFirst.Text = "First";
            this.buttonItemPriceListPageListFirst.UseVisualStyleBackColor = false;
            // 
            // buttonItemPriceListPageListPrevious
            // 
            this.buttonItemPriceListPageListPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonItemPriceListPageListPrevious.Enabled = false;
            this.buttonItemPriceListPageListPrevious.FlatAppearance.BorderSize = 0;
            this.buttonItemPriceListPageListPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonItemPriceListPageListPrevious.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonItemPriceListPageListPrevious.Location = new System.Drawing.Point(100, 9);
            this.buttonItemPriceListPageListPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.buttonItemPriceListPageListPrevious.Name = "buttonItemPriceListPageListPrevious";
            this.buttonItemPriceListPageListPrevious.Size = new System.Drawing.Size(82, 32);
            this.buttonItemPriceListPageListPrevious.TabIndex = 14;
            this.buttonItemPriceListPageListPrevious.Text = "Previous";
            this.buttonItemPriceListPageListPrevious.UseVisualStyleBackColor = false;
            // 
            // buttonItemPriceListPageListNext
            // 
            this.buttonItemPriceListPageListNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonItemPriceListPageListNext.FlatAppearance.BorderSize = 0;
            this.buttonItemPriceListPageListNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonItemPriceListPageListNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonItemPriceListPageListNext.Location = new System.Drawing.Point(262, 9);
            this.buttonItemPriceListPageListNext.Margin = new System.Windows.Forms.Padding(2);
            this.buttonItemPriceListPageListNext.Name = "buttonItemPriceListPageListNext";
            this.buttonItemPriceListPageListNext.Size = new System.Drawing.Size(82, 32);
            this.buttonItemPriceListPageListNext.TabIndex = 15;
            this.buttonItemPriceListPageListNext.Text = "Next";
            this.buttonItemPriceListPageListNext.UseVisualStyleBackColor = false;
            // 
            // buttonItemPriceListPageListLast
            // 
            this.buttonItemPriceListPageListLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonItemPriceListPageListLast.FlatAppearance.BorderSize = 0;
            this.buttonItemPriceListPageListLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonItemPriceListPageListLast.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonItemPriceListPageListLast.Location = new System.Drawing.Point(348, 9);
            this.buttonItemPriceListPageListLast.Margin = new System.Windows.Forms.Padding(2);
            this.buttonItemPriceListPageListLast.Name = "buttonItemPriceListPageListLast";
            this.buttonItemPriceListPageListLast.Size = new System.Drawing.Size(82, 32);
            this.buttonItemPriceListPageListLast.TabIndex = 16;
            this.buttonItemPriceListPageListLast.Text = "Last";
            this.buttonItemPriceListPageListLast.UseVisualStyleBackColor = false;
            // 
            // textBoxItemPriceListPageNumber
            // 
            this.textBoxItemPriceListPageNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxItemPriceListPageNumber.BackColor = System.Drawing.Color.White;
            this.textBoxItemPriceListPageNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxItemPriceListPageNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxItemPriceListPageNumber.Location = new System.Drawing.Point(188, 14);
            this.textBoxItemPriceListPageNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxItemPriceListPageNumber.Name = "textBoxItemPriceListPageNumber";
            this.textBoxItemPriceListPageNumber.ReadOnly = true;
            this.textBoxItemPriceListPageNumber.Size = new System.Drawing.Size(69, 20);
            this.textBoxItemPriceListPageNumber.TabIndex = 17;
            this.textBoxItemPriceListPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridViewItemPriceList
            // 
            this.dataGridViewItemPriceList.AllowUserToAddRows = false;
            this.dataGridViewItemPriceList.AllowUserToDeleteRows = false;
            this.dataGridViewItemPriceList.AllowUserToResizeRows = false;
            this.dataGridViewItemPriceList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewItemPriceList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewItemPriceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItemPriceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnItemPriceListButtonPick,
            this.ColumnItemPriceListPriceDescription,
            this.ColumnItemPriceListPrice});
            this.dataGridViewItemPriceList.Location = new System.Drawing.Point(12, 44);
            this.dataGridViewItemPriceList.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewItemPriceList.MultiSelect = false;
            this.dataGridViewItemPriceList.Name = "dataGridViewItemPriceList";
            this.dataGridViewItemPriceList.ReadOnly = true;
            this.dataGridViewItemPriceList.RowHeadersWidth = 51;
            this.dataGridViewItemPriceList.RowTemplate.Height = 24;
            this.dataGridViewItemPriceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItemPriceList.Size = new System.Drawing.Size(651, 211);
            this.dataGridViewItemPriceList.TabIndex = 0;
            this.dataGridViewItemPriceList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItemPriceList_CellClick);
            this.dataGridViewItemPriceList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewItemPriceList_KeyDown);
            // 
            // ColumnItemPriceListButtonPick
            // 
            this.ColumnItemPriceListButtonPick.DataPropertyName = "ColumnItemPriceListButtonPick";
            this.ColumnItemPriceListButtonPick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnItemPriceListButtonPick.HeaderText = "";
            this.ColumnItemPriceListButtonPick.MinimumWidth = 6;
            this.ColumnItemPriceListButtonPick.Name = "ColumnItemPriceListButtonPick";
            this.ColumnItemPriceListButtonPick.ReadOnly = true;
            this.ColumnItemPriceListButtonPick.Width = 70;
            // 
            // ColumnItemPriceListPriceDescription
            // 
            this.ColumnItemPriceListPriceDescription.DataPropertyName = "ColumnItemPriceListPriceDescription";
            this.ColumnItemPriceListPriceDescription.HeaderText = "Price Description";
            this.ColumnItemPriceListPriceDescription.MinimumWidth = 6;
            this.ColumnItemPriceListPriceDescription.Name = "ColumnItemPriceListPriceDescription";
            this.ColumnItemPriceListPriceDescription.ReadOnly = true;
            this.ColumnItemPriceListPriceDescription.Width = 250;
            // 
            // ColumnItemPriceListPrice
            // 
            this.ColumnItemPriceListPrice.DataPropertyName = "ColumnItemPriceListPrice";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnItemPriceListPrice.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnItemPriceListPrice.HeaderText = "Price";
            this.ColumnItemPriceListPrice.MinimumWidth = 6;
            this.ColumnItemPriceListPrice.Name = "ColumnItemPriceListPrice";
            this.ColumnItemPriceListPrice.ReadOnly = true;
            this.ColumnItemPriceListPrice.Width = 150;
            // 
            // textBoxItemDescription
            // 
            this.textBoxItemDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxItemDescription.BackColor = System.Drawing.Color.White;
            this.textBoxItemDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxItemDescription.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxItemDescription.Location = new System.Drawing.Point(12, 6);
            this.textBoxItemDescription.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxItemDescription.Name = "textBoxItemDescription";
            this.textBoxItemDescription.ReadOnly = true;
            this.textBoxItemDescription.Size = new System.Drawing.Size(651, 32);
            this.textBoxItemDescription.TabIndex = 7;
            this.textBoxItemDescription.TabStop = false;
            this.textBoxItemDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TrnPOSItemPriceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(675, 376);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "TrnPOSItemPriceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Price";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemPriceList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxItemDescription;
        private System.Windows.Forms.DataGridView dataGridViewItemPriceList;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button buttonItemPriceListPageListFirst;
        private System.Windows.Forms.Button buttonItemPriceListPageListPrevious;
        private System.Windows.Forms.Button buttonItemPriceListPageListNext;
        private System.Windows.Forms.Button buttonItemPriceListPageListLast;
        private System.Windows.Forms.TextBox textBoxItemPriceListPageNumber;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnItemPriceListButtonPick;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemPriceListPriceDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemPriceListPrice;
    }
}