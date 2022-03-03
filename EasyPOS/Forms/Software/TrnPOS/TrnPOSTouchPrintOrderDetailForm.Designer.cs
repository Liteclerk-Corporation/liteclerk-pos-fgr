
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrnPOSTouchPrintOrderDetailForm));
            this.dataGridViewPrintOrderSalesLineList = new System.Windows.Forms.DataGridView();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.printDialogSelectPrinter = new System.Windows.Forms.PrintDialog();
            this.buttonClose = new System.Windows.Forms.Button();
            this.ColumnSalesLineListPrintOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSalesLineListPrintOrderSalesId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSalesLineListPrintOrderItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSalesLineListPrintOrderPrinted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnSalesLineListItemPrintOrderDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSalesLineListPrintOrderPreparation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrintOrderSalesLineList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPrintOrderSalesLineList
            // 
            this.dataGridViewPrintOrderSalesLineList.AllowUserToAddRows = false;
            this.dataGridViewPrintOrderSalesLineList.AllowUserToDeleteRows = false;
            this.dataGridViewPrintOrderSalesLineList.AllowUserToResizeRows = false;
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
            this.ColumnSalesLineListPrintOrderId,
            this.ColumnSalesLineListPrintOrderSalesId,
            this.ColumnSalesLineListPrintOrderItemId,
            this.ColumnSalesLineListPrintOrderPrinted,
            this.ColumnSalesLineListItemPrintOrderDescription,
            this.ColumnSalesLineListPrintOrderPreparation});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPrintOrderSalesLineList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPrintOrderSalesLineList.Location = new System.Drawing.Point(0, 46);
            this.dataGridViewPrintOrderSalesLineList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewPrintOrderSalesLineList.Name = "dataGridViewPrintOrderSalesLineList";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPrintOrderSalesLineList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewPrintOrderSalesLineList.RowHeadersVisible = false;
            this.dataGridViewPrintOrderSalesLineList.RowHeadersWidth = 51;
            this.dataGridViewPrintOrderSalesLineList.RowTemplate.Height = 24;
            this.dataGridViewPrintOrderSalesLineList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPrintOrderSalesLineList.Size = new System.Drawing.Size(1057, 474);
            this.dataGridViewPrintOrderSalesLineList.TabIndex = 28;
            this.dataGridViewPrintOrderSalesLineList.TabStop = false;
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
            this.buttonPrint.Location = new System.Drawing.Point(867, 2);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(93, 39);
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
            this.buttonClose.Location = new System.Drawing.Point(964, 2);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(93, 39);
            this.buttonClose.TabIndex = 30;
            this.buttonClose.TabStop = false;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.NullValue = false;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnSalesLineListPrintOrderPrinted.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnSalesLineListPrintOrderPrinted.FalseValue = "false";
            this.ColumnSalesLineListPrintOrderPrinted.HeaderText = "Printed";
            this.ColumnSalesLineListPrintOrderPrinted.MinimumWidth = 6;
            this.ColumnSalesLineListPrintOrderPrinted.Name = "ColumnSalesLineListPrintOrderPrinted";
            this.ColumnSalesLineListPrintOrderPrinted.TrueValue = "";
            this.ColumnSalesLineListPrintOrderPrinted.Width = 125;
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
            this.ColumnSalesLineListPrintOrderPreparation.Width = 350;
            // 
            // TrnPOSTouchPrintOrderDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 514);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.dataGridViewPrintOrderSalesLineList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "TrnPOSTouchPrintOrderDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS Touch Print Order Detail Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrintOrderSalesLineList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPrintOrderSalesLineList;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.PrintDialog printDialogSelectPrinter;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalesLineListPrintOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalesLineListPrintOrderSalesId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalesLineListPrintOrderItemId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnSalesLineListPrintOrderPrinted;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalesLineListItemPrintOrderDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalesLineListPrintOrderPreparation;
    }
}