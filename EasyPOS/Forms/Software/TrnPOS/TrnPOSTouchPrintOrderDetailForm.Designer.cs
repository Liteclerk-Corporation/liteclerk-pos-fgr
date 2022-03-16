
namespace EasyPOS.Forms.Software.TrnPOS
{
    partial class TrnPOSTouchPrintOrderDetailForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrnPOSTouchPrintOrderDetailForm));
            this.dataGridViewPrintOrderSalesLineList = new System.Windows.Forms.DataGridView();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.printDialogSelectPrinter = new System.Windows.Forms.PrintDialog();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ColumnSalesLineListPrintOrderSelect = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnSalesLineListPrintOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSalesLineListPrintOrderSalesId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSalesLineListPrintOrderItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSalesLineListPrintOrderPrinted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnSalesLineListItemPrintOrderDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSalesLineListPrintOrderPreparation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrintOrderSalesLineList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPrintOrderSalesLineList
            // 
            this.dataGridViewPrintOrderSalesLineList.AllowUserToAddRows = false;
            this.dataGridViewPrintOrderSalesLineList.AllowUserToDeleteRows = false;
            this.dataGridViewPrintOrderSalesLineList.AllowUserToResizeRows = false;
            this.dataGridViewPrintOrderSalesLineList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPrintOrderSalesLineList.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewPrintOrderSalesLineList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPrintOrderSalesLineList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPrintOrderSalesLineList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrintOrderSalesLineList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSalesLineListPrintOrderSelect,
            this.ColumnSalesLineListPrintOrderId,
            this.ColumnSalesLineListPrintOrderSalesId,
            this.ColumnSalesLineListPrintOrderItemId,
            this.ColumnSalesLineListPrintOrderPrinted,
            this.ColumnSalesLineListItemPrintOrderDescription,
            this.ColumnSalesLineListPrintOrderPreparation});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPrintOrderSalesLineList.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewPrintOrderSalesLineList.Location = new System.Drawing.Point(0, 37);
            this.dataGridViewPrintOrderSalesLineList.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewPrintOrderSalesLineList.Name = "dataGridViewPrintOrderSalesLineList";
            this.dataGridViewPrintOrderSalesLineList.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPrintOrderSalesLineList.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewPrintOrderSalesLineList.RowHeadersVisible = false;
            this.dataGridViewPrintOrderSalesLineList.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewPrintOrderSalesLineList.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewPrintOrderSalesLineList.RowTemplate.Height = 30;
            this.dataGridViewPrintOrderSalesLineList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewPrintOrderSalesLineList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPrintOrderSalesLineList.Size = new System.Drawing.Size(891, 385);
            this.dataGridViewPrintOrderSalesLineList.TabIndex = 28;
            this.dataGridViewPrintOrderSalesLineList.TabStop = false;
            this.dataGridViewPrintOrderSalesLineList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPrintOrderSalesLineList_CellClick);
            this.dataGridViewPrintOrderSalesLineList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewPrintOrderSalesLineList_CellFormatting);
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
            this.buttonPrint.Location = new System.Drawing.Point(744, 0);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(70, 32);
            this.buttonPrint.TabIndex = 29;
            this.buttonPrint.TabStop = false;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // printDialogSelectPrinter
            // 
            this.printDialogSelectPrinter.UseEXDialog = true;
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
            this.buttonClose.Location = new System.Drawing.Point(817, 0);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(70, 32);
            this.buttonClose.TabIndex = 30;
            this.buttonClose.TabStop = false;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.buttonPrint);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 32);
            this.panel1.TabIndex = 31;
            // 
            // ColumnSalesLineListPrintOrderSelect
            // 
            this.ColumnSalesLineListPrintOrderSelect.DataPropertyName = "ColumnSalesLineListPrintOrderSelect";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.ColumnSalesLineListPrintOrderSelect.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnSalesLineListPrintOrderSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnSalesLineListPrintOrderSelect.HeaderText = "";
            this.ColumnSalesLineListPrintOrderSelect.Name = "ColumnSalesLineListPrintOrderSelect";
            this.ColumnSalesLineListPrintOrderSelect.ReadOnly = true;
            // 
            // ColumnSalesLineListPrintOrderId
            // 
            this.ColumnSalesLineListPrintOrderId.DataPropertyName = "ColumnSalesLineListPrintOrderId";
            this.ColumnSalesLineListPrintOrderId.HeaderText = "Id";
            this.ColumnSalesLineListPrintOrderId.MinimumWidth = 6;
            this.ColumnSalesLineListPrintOrderId.Name = "ColumnSalesLineListPrintOrderId";
            this.ColumnSalesLineListPrintOrderId.ReadOnly = true;
            this.ColumnSalesLineListPrintOrderId.Visible = false;
            this.ColumnSalesLineListPrintOrderId.Width = 125;
            // 
            // ColumnSalesLineListPrintOrderSalesId
            // 
            this.ColumnSalesLineListPrintOrderSalesId.DataPropertyName = "ColumnSalesLineListPrintOrderSalesId";
            this.ColumnSalesLineListPrintOrderSalesId.HeaderText = "SalesId";
            this.ColumnSalesLineListPrintOrderSalesId.MinimumWidth = 6;
            this.ColumnSalesLineListPrintOrderSalesId.Name = "ColumnSalesLineListPrintOrderSalesId";
            this.ColumnSalesLineListPrintOrderSalesId.ReadOnly = true;
            this.ColumnSalesLineListPrintOrderSalesId.Visible = false;
            this.ColumnSalesLineListPrintOrderSalesId.Width = 125;
            // 
            // ColumnSalesLineListPrintOrderItemId
            // 
            this.ColumnSalesLineListPrintOrderItemId.DataPropertyName = "ColumnSalesLineListPrintOrderItemId";
            this.ColumnSalesLineListPrintOrderItemId.HeaderText = "ItemId";
            this.ColumnSalesLineListPrintOrderItemId.MinimumWidth = 6;
            this.ColumnSalesLineListPrintOrderItemId.Name = "ColumnSalesLineListPrintOrderItemId";
            this.ColumnSalesLineListPrintOrderItemId.ReadOnly = true;
            this.ColumnSalesLineListPrintOrderItemId.Visible = false;
            this.ColumnSalesLineListPrintOrderItemId.Width = 125;
            // 
            // ColumnSalesLineListPrintOrderPrinted
            // 
            this.ColumnSalesLineListPrintOrderPrinted.DataPropertyName = "ColumnSalesLineListPrintOrderPrinted";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.NullValue = false;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnSalesLineListPrintOrderPrinted.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnSalesLineListPrintOrderPrinted.FalseValue = "false";
            this.ColumnSalesLineListPrintOrderPrinted.HeaderText = "Printed";
            this.ColumnSalesLineListPrintOrderPrinted.MinimumWidth = 6;
            this.ColumnSalesLineListPrintOrderPrinted.Name = "ColumnSalesLineListPrintOrderPrinted";
            this.ColumnSalesLineListPrintOrderPrinted.ReadOnly = true;
            this.ColumnSalesLineListPrintOrderPrinted.TrueValue = "";
            this.ColumnSalesLineListPrintOrderPrinted.Width = 75;
            // 
            // ColumnSalesLineListItemPrintOrderDescription
            // 
            this.ColumnSalesLineListItemPrintOrderDescription.DataPropertyName = "ColumnSalesLineListItemPrintOrderDescription";
            this.ColumnSalesLineListItemPrintOrderDescription.HeaderText = "Item Description";
            this.ColumnSalesLineListItemPrintOrderDescription.MinimumWidth = 6;
            this.ColumnSalesLineListItemPrintOrderDescription.Name = "ColumnSalesLineListItemPrintOrderDescription";
            this.ColumnSalesLineListItemPrintOrderDescription.ReadOnly = true;
            this.ColumnSalesLineListItemPrintOrderDescription.Width = 350;
            // 
            // ColumnSalesLineListPrintOrderPreparation
            // 
            this.ColumnSalesLineListPrintOrderPreparation.DataPropertyName = "ColumnSalesLineListPrintOrderPreparation";
            this.ColumnSalesLineListPrintOrderPreparation.HeaderText = "Preparation";
            this.ColumnSalesLineListPrintOrderPreparation.MinimumWidth = 6;
            this.ColumnSalesLineListPrintOrderPreparation.Name = "ColumnSalesLineListPrintOrderPreparation";
            this.ColumnSalesLineListPrintOrderPreparation.ReadOnly = true;
            this.ColumnSalesLineListPrintOrderPreparation.Width = 350;
            // 
            // TrnPOSTouchPrintOrderDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 425);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewPrintOrderSalesLineList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TrnPOSTouchPrintOrderDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS Touch Print Order Detail Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrintOrderSalesLineList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPrintOrderSalesLineList;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.PrintDialog printDialogSelectPrinter;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnSalesLineListPrintOrderSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalesLineListPrintOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalesLineListPrintOrderSalesId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalesLineListPrintOrderItemId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnSalesLineListPrintOrderPrinted;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalesLineListItemPrintOrderDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalesLineListPrintOrderPreparation;
    }
}