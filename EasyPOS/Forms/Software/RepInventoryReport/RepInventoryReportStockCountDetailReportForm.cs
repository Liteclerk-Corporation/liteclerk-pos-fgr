﻿using PagedList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPOS.Forms.Software.RepInventoryReport
{
    public partial class RepInventoryReportStockCountDetailReportForm : Form
    {
        public List<Entities.DgvInventoryReportStockCountDetailReportEntity> stockCountDetailReportList;
        public BindingSource dataStockCountDetailReportListSource = new BindingSource();
        public PagedList<Entities.DgvInventoryReportStockCountDetailReportEntity> pageList;
        public Int32 pageNumber = 1;
        public Int32 pageSize = 50;

        public DateTime startDate;
        public DateTime endDate;
        public RepInventoryReportStockCountDetailReportForm(DateTime dateStart, DateTime dateEnd)
        {
            InitializeComponent();

            startDate = dateStart;
            endDate = dateEnd;

            GetStockCountDetailDataSource();
            GetDataGridViewStockCountDetailSource();

        }

        public List<Entities.DgvInventoryReportStockCountDetailReportEntity> GetStockCountDetailReportListData(DateTime startDate, DateTime endDate)
        {
            List<Entities.DgvInventoryReportStockCountDetailReportEntity> rowList = new List<Entities.DgvInventoryReportStockCountDetailReportEntity>();

            Controllers.RepInventoryReportController repInvetoryReportController = new Controllers.RepInventoryReportController();

            var stockCountDetailReportList = repInvetoryReportController.StockCountDetailReport(startDate, endDate);
            if (stockCountDetailReportList.OrderByDescending(d => d.Id).Any())
            {
                Decimal totalAmount = 0;
                var row = from d in stockCountDetailReportList
                          select new Entities.DgvInventoryReportStockCountDetailReportEntity
                          {
                              ColumnStockCountDate = d.StockCountDate,
                              ColumnStockCountNumber = d.StockCountNumber,
                              ColumnRemarks = d.Remarks,
                              ColumnItem = d.Item,
                              ColumnUnit = d.Unit,
                              ColumnQuantity = d.Quantity.ToString("#,##0.00"),
                              ColumnCost = d.Cost.ToString("#,##0.00"),
                              ColumnAmount = d.Amount.ToString("#,##0.00")
                          };
                totalAmount = stockCountDetailReportList.Sum(d => d.Amount);

                textBoxTotalAmount.Text = totalAmount.ToString("#,##0.00");

                rowList = row.ToList();
            }
            return rowList;
        }

        public void GetStockCountDetailDataSource()
        {
            stockCountDetailReportList = GetStockCountDetailReportListData(startDate, endDate);
            if (stockCountDetailReportList.Any())
            {
                pageList = new PagedList<Entities.DgvInventoryReportStockCountDetailReportEntity>(stockCountDetailReportList, pageNumber, pageSize);

                if (pageList.PageCount == 1)
                {
                    buttonPageListFirst.Enabled = false;
                    buttonPageListPrevious.Enabled = false;
                    buttonPageListNext.Enabled = false;
                    buttonPageListLast.Enabled = false;
                }
                else if (pageNumber == 1)
                {
                    buttonPageListFirst.Enabled = false;
                    buttonPageListPrevious.Enabled = false;
                    buttonPageListNext.Enabled = true;
                    buttonPageListLast.Enabled = true;
                }
                else if (pageNumber == pageList.PageCount)
                {
                    buttonPageListFirst.Enabled = true;
                    buttonPageListPrevious.Enabled = true;
                    buttonPageListNext.Enabled = false;
                    buttonPageListLast.Enabled = false;
                }
                else
                {
                    buttonPageListFirst.Enabled = true;
                    buttonPageListPrevious.Enabled = true;
                    buttonPageListNext.Enabled = true;
                    buttonPageListLast.Enabled = true;
                }

                textBoxPageNumber.Text = pageNumber + " / " + pageList.PageCount;
                dataStockCountDetailReportListSource.DataSource = pageList;
            }
            else
            {
                buttonPageListFirst.Enabled = false;
                buttonPageListPrevious.Enabled = false;
                buttonPageListNext.Enabled = false;
                buttonPageListLast.Enabled = false;

                dataStockCountDetailReportListSource.Clear();
                textBoxPageNumber.Text = "0 / 0";
            }
        }

        private void GetDataGridViewStockCountDetailSource()
        {
            dataGridViewStockCountDetailReport.DataSource = dataStockCountDetailReportListSource;
        }

        private void buttonPageListFirst_Click(object sender, EventArgs e)
        {
            pageList = new PagedList<Entities.DgvInventoryReportStockCountDetailReportEntity>(stockCountDetailReportList, 1, pageSize);
            dataStockCountDetailReportListSource.DataSource = pageList;

            buttonPageListFirst.Enabled = false;
            buttonPageListPrevious.Enabled = false;
            buttonPageListNext.Enabled = true;
            buttonPageListLast.Enabled = true;

            pageNumber = 1;
            textBoxPageNumber.Text = pageNumber + " / " + pageList.PageCount;
        }

        private void buttonPageListPrevious_Click(object sender, EventArgs e)
        {
            if (pageList.HasPreviousPage == true)
            {
                pageList = new PagedList<Entities.DgvInventoryReportStockCountDetailReportEntity>(stockCountDetailReportList, --pageNumber, pageSize);
                dataStockCountDetailReportListSource.DataSource = pageList;
            }

            buttonPageListNext.Enabled = true;
            buttonPageListLast.Enabled = true;

            if (pageNumber == 1)
            {
                buttonPageListFirst.Enabled = false;
                buttonPageListPrevious.Enabled = false;
            }

            textBoxPageNumber.Text = pageNumber + " / " + pageList.PageCount;
        }

        private void buttonPageListNext_Click(object sender, EventArgs e)
        {
            if (pageList.HasNextPage == true)
            {
                pageList = new PagedList<Entities.DgvInventoryReportStockCountDetailReportEntity>(stockCountDetailReportList, ++pageNumber, pageSize);
                dataStockCountDetailReportListSource.DataSource = pageList;
            }

            buttonPageListFirst.Enabled = true;
            buttonPageListPrevious.Enabled = true;

            if (pageNumber == pageList.PageCount)
            {
                buttonPageListNext.Enabled = false;
                buttonPageListLast.Enabled = false;
            }

            textBoxPageNumber.Text = pageNumber + " / " + pageList.PageCount;
        }

        private void buttonPageListLast_Click(object sender, EventArgs e)
        {
            pageList = new PagedList<Entities.DgvInventoryReportStockCountDetailReportEntity>(stockCountDetailReportList, pageList.PageCount, pageSize);
            dataStockCountDetailReportListSource.DataSource = pageList;

            buttonPageListFirst.Enabled = true;
            buttonPageListPrevious.Enabled = true;
            buttonPageListNext.Enabled = false;
            buttonPageListLast.Enabled = false;

            pageNumber = pageList.PageCount;
            textBoxPageNumber.Text = pageNumber + " / " + pageList.PageCount;
        }

        private void buttonClose_OnClick(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonGenerateCSV_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = folderBrowserDialogGenerateCSV.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    StringBuilder csv = new StringBuilder();
                    String[] header = { "StockCountDate", "StockCountNumber", "Remarks", "Item", "Unit", "Quantity", "Cost", "Amount" };
                    csv.AppendLine(String.Join(",", header));

                    if (stockCountDetailReportList.Any())
                    {
                        foreach (var stockCountDetail in stockCountDetailReportList)
                        {
                            String[] data = {stockCountDetail.ColumnStockCountDate,
                              stockCountDetail.ColumnStockCountNumber,
                              stockCountDetail.ColumnRemarks,
                              stockCountDetail.ColumnItem,
                              stockCountDetail.ColumnUnit,
                              stockCountDetail.ColumnQuantity,
                              stockCountDetail.ColumnCost,
                              stockCountDetail.ColumnAmount
                            };

                            csv.AppendLine(String.Join(",", data));
                        }
                    }

                    String executingUser = WindowsIdentity.GetCurrent().Name;

                    DirectorySecurity securityRules = new DirectorySecurity();
                    securityRules.AddAccessRule(new FileSystemAccessRule(executingUser, FileSystemRights.Read, AccessControlType.Allow));
                    securityRules.AddAccessRule(new FileSystemAccessRule(executingUser, FileSystemRights.FullControl, AccessControlType.Allow));

                    DirectoryInfo createDirectorySTCSV = Directory.CreateDirectory(folderBrowserDialogGenerateCSV.SelectedPath, securityRules);
                    File.WriteAllText(createDirectorySTCSV.FullName + "\\StockCountDetailReport_" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".csv", csv.ToString(), Encoding.GetEncoding("iso-8859-1"));

                    MessageBox.Show("Generate CSV Successful!", "Generate CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
