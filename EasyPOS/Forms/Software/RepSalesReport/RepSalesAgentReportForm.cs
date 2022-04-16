using PagedList;
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

namespace EasyPOS.Forms.Software.RepSalesReport
{
    public partial class RepSalesAgentReportForm : Form
    {
        public List<Entities.DgvRepSalesReportSalesAgentReportListEntity> salesAgentList;
        public BindingSource dataSalesAgentListSource = new BindingSource();
        public PagedList<Entities.DgvRepSalesReportSalesAgentReportListEntity> pageList;
        public Int32 pageNumber = 1;
        public Int32 pageSize = 50;

        public DateTime dateStart;
        public DateTime dateEnd;
        public Int32 filterSalesAgentId;

        public RepSalesAgentReportForm(DateTime startDate, DateTime endDate,Int32 SalesAgentId)
        {
            InitializeComponent();

            dateStart = startDate;
            dateEnd = endDate;
            filterSalesAgentId = SalesAgentId;

            GetSalesAgentListDataSource();
            GetSalesAgentListDataGridSource();
        }
        public void GetSalesAgentListDataSource()
        {
            salesAgentList = GetSalesAgentListData(dateStart, dateEnd, filterSalesAgentId);
            if (salesAgentList.Any())
            {

                pageList = new PagedList<Entities.DgvRepSalesReportSalesAgentReportListEntity>(salesAgentList, pageNumber, pageSize);

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
                dataSalesAgentListSource.DataSource = pageList;
            }
            else
            {
                buttonPageListFirst.Enabled = false;
                buttonPageListPrevious.Enabled = false;
                buttonPageListNext.Enabled = false;
                buttonPageListLast.Enabled = false;

                dataSalesAgentListSource.Clear();
                textBoxPageNumber.Text = "0 / 0";
            }
        }
        public List<Entities.DgvRepSalesReportSalesAgentReportListEntity> GetSalesAgentListData(DateTime startDate, DateTime endDate, Int32 SalesAgentId)
        {
            List<Entities.DgvRepSalesReportSalesAgentReportListEntity> rowList = new List<Entities.DgvRepSalesReportSalesAgentReportListEntity>();

            Controllers.RepSalesReportController repSalesAgentReportController = new Controllers.RepSalesReportController();

            var salesAgentList = repSalesAgentReportController.SalesAgentReport(startDate, endDate, SalesAgentId);
            if (salesAgentList.OrderByDescending(d => d.EntryDateTime).Any())
            {
                Decimal totalAmount = 0;

                var row = from d in salesAgentList
                          select new Entities.DgvRepSalesReportSalesAgentReportListEntity
                          {
                              ColumnSalesAgent = d.SalesAgent,
                              ColumnEntryDateTime = d.EntryDateTime.ToString(),
                              ColumnQuantity = d.Quantity.ToString("#,##0.00"),
                              ColumnBarCode = d.BarCode,
                              ColumnItemDescription = d.ItemDescription,
                              ColumnPrice = d.Price.ToString("#,##0.00"),
                              ColumnDiscountAmount = d.DiscountAmount.ToString("#,##0.00"),
                              ColumnAmount = d.Amount.ToString("#,##0.00"),
                          };

                totalAmount = salesAgentList.Sum(d => d.Amount);

                textBoxTotalAmount.Text = totalAmount.ToString("#,##0.00");

                rowList = row.ToList();

            }
            return rowList;
        }
        public void GetSalesAgentListDataGridSource()
        {
            dataGridViewSalesAgentReport.DataSource = dataSalesAgentListSource;

        }

        private void buttonPageListFirst_Click(object sender, EventArgs e)
        {
            pageList = new PagedList<Entities.DgvRepSalesReportSalesAgentReportListEntity>(salesAgentList, 1, pageSize);
            dataSalesAgentListSource.DataSource = pageList;

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
                pageList = new PagedList<Entities.DgvRepSalesReportSalesAgentReportListEntity>(salesAgentList, --pageNumber, pageSize);
                dataSalesAgentListSource.DataSource = pageList;
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
                pageList = new PagedList<Entities.DgvRepSalesReportSalesAgentReportListEntity>(salesAgentList, ++pageNumber, pageSize);
                dataSalesAgentListSource.DataSource = pageList;
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
            pageList = new PagedList<Entities.DgvRepSalesReportSalesAgentReportListEntity>(salesAgentList, pageList.PageCount, pageSize);
            dataSalesAgentListSource.DataSource = pageList;

            buttonPageListFirst.Enabled = true;
            buttonPageListPrevious.Enabled = true;
            buttonPageListNext.Enabled = false;
            buttonPageListLast.Enabled = false;

            pageNumber = pageList.PageCount;
            textBoxPageNumber.Text = pageNumber + " / " + pageList.PageCount;
        }

        private void buttonGenerateCSV_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = folderBrowserDialogGenerateCSV.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    DateTime startDate = dateStart;
                    DateTime endDate = dateEnd;

                    StringBuilder csv = new StringBuilder();
                    String[] header = {  "Sales Agent", "Time", "Quantity", "Barcode", "Item Description", "Price","Discount",  "Amount" };
                    csv.AppendLine(String.Join(",", header));

                    if (salesAgentList.Any())
                    {
                        foreach (var salesDetail in salesAgentList)
                        {
                            String[] data = {
                                salesDetail.ColumnSalesAgent.Replace("," , ""),
                                salesDetail.ColumnEntryDateTime.Replace("," , ""),
                                salesDetail.ColumnQuantity.Replace("," , ""),
                                salesDetail.ColumnBarCode.Replace("," , ""),
                                salesDetail.ColumnItemDescription.Replace("," , ""),
                                salesDetail.ColumnPrice.Replace("," , ""),
                                salesDetail.ColumnDiscountAmount.Replace("," , ""),
                                salesDetail.ColumnAmount.Replace("," , ""),
                            };
                            csv.AppendLine(String.Join(",", data));
                        }
                    }

                    String executingUser = WindowsIdentity.GetCurrent().Name;

                    DirectorySecurity securityRules = new DirectorySecurity();
                    securityRules.AddAccessRule(new FileSystemAccessRule(executingUser, FileSystemRights.Read, AccessControlType.Allow));
                    securityRules.AddAccessRule(new FileSystemAccessRule(executingUser, FileSystemRights.FullControl, AccessControlType.Allow));

                    DirectoryInfo createDirectorySTCSV = Directory.CreateDirectory(folderBrowserDialogGenerateCSV.SelectedPath, securityRules);
                    File.WriteAllText(createDirectorySTCSV.FullName + "\\SalesAgentReport_" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".csv", csv.ToString(), Encoding.GetEncoding("utf-8"));

                    MessageBox.Show("Generate CSV Successful!", "Generate CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            new RepSalesAgentReportPDFForm(dateStart, dateEnd, filterSalesAgentId);
        }
    }
}
