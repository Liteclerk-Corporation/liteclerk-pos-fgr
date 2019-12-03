﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagedList;

namespace EasyPOS.Forms.Software.TrnPOS
{
    public partial class TrnSalesListForm : Form
    {
        public SysSoftwareForm sysSoftwareForm;
        private Modules.SysUserRightsModule sysUserRights;

        public List<Entities.DgvSalesListSalesEntity> salesList;
        public BindingSource dataSalesListSource = new BindingSource();
        public PagedList<Entities.DgvSalesListSalesEntity> pageList;
        public Int32 pageNumber = 1;
        public Int32 pageSize = 50;
        public Boolean isAutoRefresh = false;

        public SerialPort serialPort = null;

        public TrnSalesListForm(SysSoftwareForm softwareForm)
        {
            InitializeComponent();
            sysSoftwareForm = softwareForm;

            sysUserRights = new Modules.SysUserRightsModule("TrnSales");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (sysUserRights.GetUserRights().CanAdd == false)
                {
                    buttonSales.Enabled = false;
                }

                if (sysUserRights.GetUserRights().CanTender == false)
                {
                    buttonTender.Enabled = false;
                }

                if (sysUserRights.GetUserRights().CanPrint == false)
                {
                    buttonReprint.Enabled = false;
                }

                if (sysUserRights.GetUserRights().CanCancel == false)
                {
                    buttonCancel.Enabled = false;
                }

                if (sysUserRights.GetUserRights().CanEdit == false)
                {
                    dataGridViewSalesList.Columns[0].Visible = false;
                }

                if (sysUserRights.GetUserRights().CanDelete == false)
                {
                    dataGridViewSalesList.Columns[1].Visible = false;
                }

                GetTerminalList();
                timerRefreshSalesListGrid.Start();
            }

            Controllers.TrnSalesController trnPOSSalesController = new Controllers.TrnSalesController();
            textBoxLastChange.Text = trnPOSSalesController.GetLastChange(Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().TerminalId)).ToString("#,##0.00");
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            sysSoftwareForm.RemoveTabPage();
        }

        private void buttonSales_Click(object sender, EventArgs e)
        {
            newSales();
        }

        public void newSales()
        {
            Controllers.TrnSalesController trnPOSSalesController = new Controllers.TrnSalesController();
            String[] addSales = trnPOSSalesController.AddSales();
            if (addSales[1].Equals("0") == false)
            {
                sysSoftwareForm.AddTabPagePOSSalesDetail(this, trnPOSSalesController.DetailSales(Convert.ToInt32(addSales[1])));
                UpdateSalesListGridDataSource();
            }
            else
            {
                MessageBox.Show(addSales[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePickerSalesDate_ValueChanged(object sender, EventArgs e)
        {
            pageNumber = 1;
            UpdateSalesListGridDataSource();
        }

        public void GetTerminalList()
        {
            Controllers.TrnSalesController trnPOSSalesController = new Controllers.TrnSalesController();
            if (trnPOSSalesController.DropdownListTerminal().Any())
            {
                comboBoxTerminal.DataSource = trnPOSSalesController.DropdownListTerminal();
                comboBoxTerminal.ValueMember = "Id";
                comboBoxTerminal.DisplayMember = "Terminal";

                comboBoxTerminal.SelectedValue = Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().TerminalId);

                UpdateSalesListGridDataSource();
                CreateSalesListDataGrid();
            }
        }

        private void comboBoxTerminal_SelectedIndexChanged(object sender, EventArgs e)
        {
            pageNumber = 1;
            UpdateSalesListGridDataSource();
        }

        private void textBoxSalesListFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UpdateSalesListGridDataSource();
            }
        }

        public void UpdateSalesListGridDataSource()
        {
            DateTime salesDate = dateTimePickerSalesDate.Value.Date;
            Int32 terminalId = Convert.ToInt32(comboBoxTerminal.SelectedValue);
            String filter = textBoxSalesListFilter.Text;

            GetSalesListDataAsync(salesDate, terminalId, filter);

            Controllers.TrnSalesController trnPOSSalesController = new Controllers.TrnSalesController();
            textBoxLastChange.Text = trnPOSSalesController.GetLastChange(Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().TerminalId)).ToString("#,##0.00");
        }

        public async void GetSalesListDataAsync(DateTime salesDate, Int32 terminalId, String filter)
        {
            salesList = await GetSalesListDataTask(salesDate, terminalId, filter);
            if (salesList.Any())
            {
                dataGridViewSalesList.BeginInvoke((MethodInvoker)delegate ()
                {
                    pageList = new PagedList<Entities.DgvSalesListSalesEntity>(salesList, pageNumber, pageSize);

                    if (pageList.PageCount == 1)
                    {
                        buttonSalesListPageListFirst.Enabled = false;
                        buttonSalesListPageListPrevious.Enabled = false;
                        buttonSalesListPageListNext.Enabled = false;
                        buttonSalesListPageListLast.Enabled = false;
                    }
                    else if (pageNumber == 1)
                    {
                        buttonSalesListPageListFirst.Enabled = false;
                        buttonSalesListPageListPrevious.Enabled = false;
                        buttonSalesListPageListNext.Enabled = true;
                        buttonSalesListPageListLast.Enabled = true;
                    }
                    else if (pageNumber == pageList.PageCount)
                    {
                        buttonSalesListPageListFirst.Enabled = true;
                        buttonSalesListPageListPrevious.Enabled = true;
                        buttonSalesListPageListNext.Enabled = false;
                        buttonSalesListPageListLast.Enabled = false;
                    }
                    else
                    {
                        buttonSalesListPageListFirst.Enabled = true;
                        buttonSalesListPageListPrevious.Enabled = true;
                        buttonSalesListPageListNext.Enabled = true;
                        buttonSalesListPageListLast.Enabled = true;
                    }

                    textBoxPageNumber.Text = pageNumber + " / " + pageList.PageCount;
                    dataSalesListSource.DataSource = pageList;

                    CurrentSelectedCell(dataGridViewSalesList.CurrentCell.RowIndex);
                });
            }
            else
            {
                buttonSalesListPageListFirst.Enabled = false;
                buttonSalesListPageListPrevious.Enabled = false;
                buttonSalesListPageListNext.Enabled = false;
                buttonSalesListPageListLast.Enabled = false;

                dataSalesListSource.Clear();
                textBoxPageNumber.Text = "0 / 0";

                CurrentSelectedCell(-1);
            }
        }

        public async Task<List<Entities.DgvSalesListSalesEntity>> GetSalesListDataTask(DateTime salesDate, Int32 terminalId, String filter)
        {
            return await Task.Factory.StartNew(() =>
            {
                List<Entities.DgvSalesListSalesEntity> rowList = new List<Entities.DgvSalesListSalesEntity>();

                Controllers.TrnSalesController trnPOSSalesController = new Controllers.TrnSalesController();
                var salesList = trnPOSSalesController.ListSales(salesDate, terminalId, filter);
                if (salesList.Any())
                {
                    var row = from d in salesList
                              select new Entities.DgvSalesListSalesEntity
                              {
                                  ColumnEdit = "Edit",
                                  ColumnDelete = "Delete",
                                  ColumnId = d.Id,
                                  ColumnTerminal = d.Terminal,
                                  ColumnSalesDate = d.SalesDate,
                                  ColumnSalesNumber = d.SalesNumber,
                                  ColumnCustomer = d.Customer,
                                  ColumnSalesAgent = d.SalesAgentUserName,
                                  ColumnAmount = d.Amount.ToString("#,##0.00"),
                                  ColumnIsLocked = d.IsLocked,
                                  ColumnIsTendered = d.IsTendered,
                                  ColumnIsCancelled = d.IsCancelled
                              };

                    rowList = row.ToList();
                }

                return rowList;
            });
        }

        public void CreateSalesListDataGrid()
        {
            dataGridViewSalesList.Columns[0].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#01A6F0");
            dataGridViewSalesList.Columns[0].DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#01A6F0");
            dataGridViewSalesList.Columns[0].DefaultCellStyle.ForeColor = Color.White;

            dataGridViewSalesList.Columns[1].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F34F1C");
            dataGridViewSalesList.Columns[1].DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#F34F1C");
            dataGridViewSalesList.Columns[1].DefaultCellStyle.ForeColor = Color.White;

            dataGridViewSalesList.DataSource = dataSalesListSource;
        }

        private void dataGridViewSalesList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                CurrentSelectedCell(e.RowIndex);
            }

            if (e.RowIndex > -1 && dataGridViewSalesList.CurrentCell.ColumnIndex == dataGridViewSalesList.Columns["ColumnEdit"].Index)
            {
                Boolean isLocked = Convert.ToBoolean(dataGridViewSalesList.Rows[e.RowIndex].Cells[9].Value);
                Boolean isTendered = Convert.ToBoolean(dataGridViewSalesList.Rows[e.RowIndex].Cells[10].Value);

                if (isLocked == true)
                {
                    MessageBox.Show("Already locked.", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (isTendered == true)
                {
                    MessageBox.Show("Already tendered.", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Controllers.TrnSalesController trnPOSSalesController = new Controllers.TrnSalesController();
                    if (trnPOSSalesController.IsSalesTendered(Convert.ToInt32(dataGridViewSalesList.Rows[e.RowIndex].Cells[2].Value)) == true)
                    {
                        MessageBox.Show("Already tendered.", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        sysSoftwareForm.AddTabPagePOSSalesDetail(this, trnPOSSalesController.DetailSales(Convert.ToInt32(dataGridViewSalesList.Rows[e.RowIndex].Cells[2].Value)));
                    }
                }
            }

            if (e.RowIndex > -1 && dataGridViewSalesList.CurrentCell.ColumnIndex == dataGridViewSalesList.Columns["ColumnDelete"].Index)
            {
                Boolean isLocked = Convert.ToBoolean(dataGridViewSalesList.Rows[e.RowIndex].Cells[9].Value);
                Boolean isTendered = Convert.ToBoolean(dataGridViewSalesList.Rows[e.RowIndex].Cells[10].Value);

                if (isLocked == true)
                {
                    MessageBox.Show("Already locked.", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (isTendered == true)
                {
                    MessageBox.Show("Already tendered.", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Controllers.TrnSalesController trnPOSSalesController = new Controllers.TrnSalesController();
                    if (trnPOSSalesController.IsSalesTendered(Convert.ToInt32(dataGridViewSalesList.Rows[e.RowIndex].Cells[2].Value)) == true)
                    {
                        MessageBox.Show("Already tendered.", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DialogResult deleteDialogResult = MessageBox.Show("Delete Sales?", "Easy POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (deleteDialogResult == DialogResult.Yes)
                        {
                            String[] deleteSales = trnPOSSalesController.DeleteSales(Convert.ToInt32(dataGridViewSalesList.Rows[e.RowIndex].Cells[2].Value));
                            if (deleteSales[1].Equals("0") == false)
                            {
                                pageNumber = 1;
                                UpdateSalesListGridDataSource();
                            }
                            else
                            {
                                MessageBox.Show(deleteSales[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        public void CurrentSelectedCell(Int32 rowIndex)
        {
            dataGridViewSalesLineItemDisplay.Rows.Clear();
            dataGridViewSalesLineItemDisplay.Refresh();

            if (rowIndex == -1)
            {
                labelInvoiceNumber.Text = "";
                labelTerminal.Text = "";
                labelPreparedBy.Text = "";
                labelTransactionDate.Text = "";
            }
            else
            {
                labelInvoiceNumber.Text = dataGridViewSalesList.Rows[rowIndex].Cells[5].Value.ToString();
                labelTerminal.Text = dataGridViewSalesList.Rows[rowIndex].Cells[3].Value.ToString();
                labelPreparedBy.Text = dataGridViewSalesList.Rows[rowIndex].Cells[7].Value.ToString();
                labelTransactionDate.Text = dataGridViewSalesList.Rows[rowIndex].Cells[4].Value.ToString();

                Controllers.TrnSalesLineController trnPOSSalesLineController = new Controllers.TrnSalesLineController();
                if (trnPOSSalesLineController.ListSalesLine(Convert.ToInt32(dataGridViewSalesList.Rows[rowIndex].Cells[2].Value)).Any())
                {
                    var groupedSalesLineItems = from d in trnPOSSalesLineController.ListSalesLine(Convert.ToInt32(dataGridViewSalesList.Rows[rowIndex].Cells[2].Value))
                                                group d by new
                                                {
                                                    d.ItemDescription,
                                                    d.Unit,
                                                    d.Price,
                                                    d.Tax
                                                } into g
                                                select new
                                                {
                                                    g.Key.ItemDescription,
                                                    g.Key.Unit,
                                                    g.Key.Price,
                                                    g.Key.Tax,
                                                    Quantity = g.Sum(s => s.Quantity),
                                                    DiscountAmount = g.Sum(s => s.DiscountAmount),
                                                    Amount = g.Sum(s => s.Amount)
                                                };

                    var salesLineItemList = groupedSalesLineItems.ToList();
                    if (salesLineItemList.Any())
                    {
                        foreach (var salesLineItem in salesLineItemList)
                        {
                            dataGridViewSalesLineItemDisplay.Rows.Add(
                                salesLineItem.Quantity.ToString("#,##0.00"),
                                salesLineItem.ItemDescription + "   " + salesLineItem.Unit + Environment.NewLine + " @P" + salesLineItem.Price.ToString("#,##0.00") + " Less: " + salesLineItem.DiscountAmount.ToString("#,##0.00") + " - " + salesLineItem.Tax,
                                salesLineItem.Amount.ToString("#,##0.00")
                            );
                        }
                    }
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (dataGridViewSalesList.Rows.Count > 1)
            {
                if (dataGridViewSalesList.CurrentCell.RowIndex != -1)
                {
                    DialogResult cancelDialogResult = MessageBox.Show("Cancel Transaction? ", "Easy POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (cancelDialogResult == DialogResult.Yes)
                    {
                        Controllers.TrnSalesController trnPOSSalesController = new Controllers.TrnSalesController();

                        String[] cancelSales = trnPOSSalesController.CancelSales(Convert.ToInt32(dataGridViewSalesList.Rows[dataGridViewSalesList.CurrentCell.RowIndex].Cells[2].Value));
                        if (cancelSales[1].Equals("0") == false)
                        {
                            UpdateSalesListGridDataSource();
                        }
                        else
                        {
                            MessageBox.Show(cancelSales[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select sales.", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Sales empty.", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonTender_Click(object sender, EventArgs e)
        {
            if (dataGridViewSalesList.Rows.Count > 1)
            {
                if (dataGridViewSalesList.CurrentCell.RowIndex != -1)
                {
                    Boolean isLocked = Convert.ToBoolean(dataGridViewSalesList.Rows[dataGridViewSalesList.CurrentCell.RowIndex].Cells[9].Value);
                    Boolean isTendered = Convert.ToBoolean(dataGridViewSalesList.Rows[dataGridViewSalesList.CurrentCell.RowIndex].Cells[10].Value);

                    if (isTendered == true)
                    {
                        MessageBox.Show("Already tendered.", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (isLocked == true)
                    {
                        MessageBox.Show("Already locked.", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Controllers.TrnSalesController trnPOSSalesController = new Controllers.TrnSalesController();
                        if (trnPOSSalesController.IsSalesTendered(Convert.ToInt32(dataGridViewSalesList.Rows[dataGridViewSalesList.CurrentCell.RowIndex].Cells[2].Value)) == true)
                        {
                            MessageBox.Show("Already tendered.", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            Modules.SysSerialPortModule.OpenSerialPort();

                            Entities.TrnSalesEntity newSalesEntity = new Entities.TrnSalesEntity
                            {
                                Id = Convert.ToInt32(dataGridViewSalesList.Rows[dataGridViewSalesList.CurrentCell.RowIndex].Cells[2].Value),
                                Amount = Convert.ToDecimal(dataGridViewSalesList.Rows[dataGridViewSalesList.CurrentCell.RowIndex].Cells[8].Value),
                                SalesNumber = dataGridViewSalesList.Rows[dataGridViewSalesList.CurrentCell.RowIndex].Cells[5].Value.ToString(),
                                SalesDate = dataGridViewSalesList.Rows[dataGridViewSalesList.CurrentCell.RowIndex].Cells[4].Value.ToString(),
                                Customer = dataGridViewSalesList.Rows[dataGridViewSalesList.CurrentCell.RowIndex].Cells[6].Value.ToString()
                            };

                            String line1 = Modules.SysCurrentModule.GetCurrentSettings().CustomerDisplayFirstLineMessage;
                            String line2 = "P " + newSalesEntity.Amount.ToString("#,##0.00");

                            if (newSalesEntity.Amount > 0)
                            {
                                line1 = "TOTAL:";
                            }

                            Modules.SysSerialPortModule.WriteSeralPortMessage(line1, line2);

                            TrnSalesDetailTenderForm trnSalesDetailTenderForm = new TrnSalesDetailTenderForm(sysSoftwareForm, this, null, newSalesEntity);
                            trnSalesDetailTenderForm.ShowDialog();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select sales.", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Sales empty.", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonReprint_Click(object sender, EventArgs e)
        {
            if (dataGridViewSalesList.Rows.Count > 1)
            {
                if (dataGridViewSalesList.CurrentCell.RowIndex != -1)
                {
                    Boolean isLocked = Convert.ToBoolean(dataGridViewSalesList.Rows[dataGridViewSalesList.CurrentCell.RowIndex].Cells[9].Value);
                    Boolean isTendered = Convert.ToBoolean(dataGridViewSalesList.Rows[dataGridViewSalesList.CurrentCell.RowIndex].Cells[10].Value);

                    if (isTendered != true)
                    {
                        MessageBox.Show("Not tendered.", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (isLocked != true)
                    {
                        MessageBox.Show("Not locked.", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DialogResult cancelDialogResult = MessageBox.Show("Reprint Sales?", "Easy POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (cancelDialogResult == DialogResult.Yes)
                        {
                            Int32 salesId = Convert.ToInt32(dataGridViewSalesList.Rows[dataGridViewSalesList.CurrentCell.RowIndex].Cells[2].Value);

                            Controllers.TrnSalesController trnPOSSalesController = new Controllers.TrnSalesController();
                            Int32 collectionId = trnPOSSalesController.GetCollectionId(Convert.ToInt32(dataGridViewSalesList.Rows[dataGridViewSalesList.CurrentCell.RowIndex].Cells[2].Value));
                            if (collectionId != 0)
                            {
                                if (Modules.SysCurrentModule.GetCurrentSettings().CollectionReport == "Official Receipt")
                                {
                                    new Reports.RepOfficialReceiptReportForm(salesId, collectionId, false);
                                }
                                else if (Modules.SysCurrentModule.GetCurrentSettings().CollectionReport == "Delivery Receipt")
                                {
                                    new Reports.RepDeliveryReceiptReportForm(salesId, collectionId, false);
                                }
                                else
                                {

                                }
                            }
                            else
                            {
                                MessageBox.Show("No collection.", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select sales.", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Sales empty.", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSalesListPageListFirst_Click(object sender, EventArgs e)
        {
            pageList = new PagedList<Entities.DgvSalesListSalesEntity>(salesList, 1, pageSize);
            dataSalesListSource.DataSource = pageList;

            buttonSalesListPageListFirst.Enabled = false;
            buttonSalesListPageListPrevious.Enabled = false;
            buttonSalesListPageListNext.Enabled = true;
            buttonSalesListPageListLast.Enabled = true;

            pageNumber = 1;
            textBoxPageNumber.Text = pageNumber + " / " + pageList.PageCount;
        }

        private void buttonSalesListPageListPrevious_Click(object sender, EventArgs e)
        {
            if (pageList.HasPreviousPage == true)
            {
                pageList = new PagedList<Entities.DgvSalesListSalesEntity>(salesList, --pageNumber, pageSize);
                dataSalesListSource.DataSource = pageList;
            }

            buttonSalesListPageListNext.Enabled = true;
            buttonSalesListPageListLast.Enabled = true;

            if (pageNumber == 1)
            {
                buttonSalesListPageListFirst.Enabled = false;
                buttonSalesListPageListPrevious.Enabled = false;
            }

            textBoxPageNumber.Text = pageNumber + " / " + pageList.PageCount;
        }

        private void buttonSalesListPageListNext_Click(object sender, EventArgs e)
        {
            if (pageList.HasNextPage == true)
            {
                pageList = new PagedList<Entities.DgvSalesListSalesEntity>(salesList, ++pageNumber, pageSize);
                dataSalesListSource.DataSource = pageList;
            }

            buttonSalesListPageListFirst.Enabled = true;
            buttonSalesListPageListPrevious.Enabled = true;

            if (pageNumber == pageList.PageCount)
            {
                buttonSalesListPageListNext.Enabled = false;
                buttonSalesListPageListLast.Enabled = false;
            }

            textBoxPageNumber.Text = pageNumber + " / " + pageList.PageCount;
        }

        private void buttonSalesListPageListLast_Click(object sender, EventArgs e)
        {
            pageList = new PagedList<Entities.DgvSalesListSalesEntity>(salesList, pageList.PageCount, pageSize);
            dataSalesListSource.DataSource = pageList;

            buttonSalesListPageListFirst.Enabled = true;
            buttonSalesListPageListPrevious.Enabled = true;
            buttonSalesListPageListNext.Enabled = false;
            buttonSalesListPageListLast.Enabled = false;

            pageNumber = pageList.PageCount;
            textBoxPageNumber.Text = pageNumber + " / " + pageList.PageCount;
        }

        private void timerRefreshSalesListGrid_Tick(object sender, EventArgs e)
        {
            if (isAutoRefresh == true)
            {
                UpdateSalesListGridDataSource();
            }
        }

        private void buttonAutoRefresh_Click(object sender, EventArgs e)
        {
            if (isAutoRefresh == true)
            {
                isAutoRefresh = false;

                buttonAutoRefresh.Text = "Start";
                buttonAutoRefresh.BackColor = ColorTranslator.FromHtml("#7FBC00");
                buttonAutoRefresh.ForeColor = Color.White;
            }
            else
            {
                isAutoRefresh = true;

                buttonAutoRefresh.Text = "Stop";
                buttonAutoRefresh.BackColor = ColorTranslator.FromHtml("#F34F1C");
                buttonAutoRefresh.ForeColor = Color.White;
            }
        }
    }
}
