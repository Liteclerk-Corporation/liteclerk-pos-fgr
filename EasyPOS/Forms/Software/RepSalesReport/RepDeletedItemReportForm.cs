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
    public partial class RepDeletedItemReportForm : Form
    {
        public List<Entities.DgvRepDeletedItemEntity> deletedItemList;
        public BindingSource dataDeletedItemListSource = new BindingSource();
        public PagedList<Entities.DgvRepDeletedItemEntity> pageList;
        public Int32 pageNumber = 1;
        public Int32 pageSize = 50;

        public DateTime dateStart;
        public DateTime dateEnd;

        public RepDeletedItemReportForm(DateTime startDate, DateTime endDate)
        {
            InitializeComponent();
            dateStart = startDate;
            dateEnd = endDate;

            GetDeletedItemListDataSource();
            GetDgvCollectionSource();
        }
        public List<Entities.DgvRepDeletedItemEntity> GetDeletedItemListData(DateTime startDate, DateTime endDate)
        {
            List<Entities.DgvRepDeletedItemEntity> rowList = new List<Entities.DgvRepDeletedItemEntity>();

            Controllers.TrnSalesLineDeletedController trnSalesLineDeletedController = new Controllers.TrnSalesLineDeletedController();

            var deletedItemList = trnSalesLineDeletedController.ListSalesLineDeletedItems(startDate, endDate);
            if (deletedItemList.Any())
            {
                Decimal totalDeletedItem = 0;
                var row = from d in deletedItemList

                          select new Entities.DgvRepDeletedItemEntity
                          {
                              ColumnDeletedItemSalesNumber = d.SalesNumber,
                              ColumnDeletedItemItemDescription = d.ItemDescription,
                              ColumnDeletedItemPreparation = d.Preparation,
                              ColumnDeletedItemQuantity = d.Quantity.ToString("#,##0.00"),
                              ColumnDeletedItemUnit = d.Unit,
                              ColumnDeletedItemPrice = d.Price.ToString("#,##0.00"),
                              ColumnDeletedItemUserName = d.UserName,
                              ColumnDeletedItemDeletedDateTime = d.DeletedDate
                          };

                totalDeletedItem =+ deletedItemList.Count();

                textBoxTotalDeletedItem.Text = totalDeletedItem.ToString("#,##0.00");

                rowList = row.ToList();
            }
            return rowList;
        }

        public void GetDeletedItemListDataSource()
        {
            deletedItemList = GetDeletedItemListData(dateStart, dateEnd);
            if (deletedItemList.Any())
            {

                pageList = new PagedList<Entities.DgvRepDeletedItemEntity>(deletedItemList, pageNumber, pageSize);

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
                dataDeletedItemListSource.DataSource = pageList;
            }
            else
            {
                buttonPageListFirst.Enabled = false;
                buttonPageListPrevious.Enabled = false;
                buttonPageListNext.Enabled = false;
                buttonPageListLast.Enabled = false;

                dataDeletedItemListSource.Clear();
                textBoxPageNumber.Text = "0 / 0";
            }
        }

        public void GetDgvCollectionSource()
        {
            dataGridViewDeletedItemReport.DataSource = dataDeletedItemListSource;
        }

        private void buttoncollectionListPageListFirst_Click(object sender, EventArgs e)
        {
            pageList = new PagedList<Entities.DgvRepDeletedItemEntity>(deletedItemList, 1, pageSize);
            dataDeletedItemListSource.DataSource = pageList;

            buttonPageListFirst.Enabled = false;
            buttonPageListPrevious.Enabled = false;
            buttonPageListNext.Enabled = true;
            buttonPageListLast.Enabled = true;

            pageNumber = 1;
            textBoxPageNumber.Text = pageNumber + " / " + pageList.PageCount;
        }

        private void buttoncollectionListPageListPrevious_Click(object sender, EventArgs e)
        {
            if (pageList.HasPreviousPage == true)
            {
                pageList = new PagedList<Entities.DgvRepDeletedItemEntity>(deletedItemList, --pageNumber, pageSize);
                dataDeletedItemListSource.DataSource = pageList;
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

        private void buttoncollectionListPageListNext_Click(object sender, EventArgs e)
        {
            if (pageList.HasNextPage == true)
            {
                pageList = new PagedList<Entities.DgvRepDeletedItemEntity>(deletedItemList, ++pageNumber, pageSize);
                dataDeletedItemListSource.DataSource = pageList;
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

        private void buttoncollectionListPageListLast_Click(object sender, EventArgs e)
        {
            pageList = new PagedList<Entities.DgvRepDeletedItemEntity>(deletedItemList, pageList.PageCount, pageSize);
            dataDeletedItemListSource.DataSource = pageList;

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
                    DateTime startDate = dateStart;
                    DateTime endDate = dateEnd;

                    StringBuilder csv = new StringBuilder();
                    String[] header = { "Sales No.", "Item Description", "Preparation", "Quantity", "Unit", "Price", "Deleted By", "Deleted Date Time" };
                    csv.AppendLine(String.Join(",", header));

                    if (deletedItemList.Any())
                    {
                        foreach (var deletedItem in deletedItemList)
                        {
                            String[] data = {deletedItem.ColumnDeletedItemSalesNumber,
                                        deletedItem.ColumnDeletedItemItemDescription,
                                        deletedItem.ColumnDeletedItemPreparation?.Replace(",", String.Empty).Replace("\n", String.Empty).Replace("\t", String.Empty).Replace("\r", String.Empty),
                                        deletedItem.ColumnDeletedItemQuantity,
                                        deletedItem.ColumnDeletedItemUnit,
                                        deletedItem.ColumnDeletedItemPrice,
                                        deletedItem.ColumnDeletedItemUserName,
                                        deletedItem.ColumnDeletedItemDeletedDateTime.ToString("MM/dd/yyyy hh:mm:tt"),
                            };

                            csv.AppendLine(String.Join(",", data));
                        }
                    }

                    String executingUser = WindowsIdentity.GetCurrent().Name;

                    DirectorySecurity securityRules = new DirectorySecurity();
                    securityRules.AddAccessRule(new FileSystemAccessRule(executingUser, FileSystemRights.Read, AccessControlType.Allow));
                    securityRules.AddAccessRule(new FileSystemAccessRule(executingUser, FileSystemRights.FullControl, AccessControlType.Allow));

                    DirectoryInfo createDirectorySTCSV = Directory.CreateDirectory(folderBrowserDialogGenerateCSV.SelectedPath, securityRules);
                    File.WriteAllText(createDirectorySTCSV.FullName + "\\DeletedItemReport_" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".csv", csv.ToString(), Encoding.GetEncoding("utf-8"));

                    MessageBox.Show("Generate CSV Successful!", "Generate CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            new RepDeletedItemReportPDFForm(dateStart, dateEnd);
        }
    }
}
