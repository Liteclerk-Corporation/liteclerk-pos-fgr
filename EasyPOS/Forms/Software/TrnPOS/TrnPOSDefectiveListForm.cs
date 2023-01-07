using PagedList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPOS.Forms.Software.TrnPOS
{
    public partial class TrnPOSDefectiveListForm : Form
    {
        public static List<Entities.DgvTrnDefectiveListEntity> itemListData = new List<Entities.DgvTrnDefectiveListEntity>();
        public static Int32 pageNumber = 1;
        public static Int32 pageSize = 50;
        public PagedList<Entities.DgvTrnDefectiveListEntity> itemListPageList = new PagedList<Entities.DgvTrnDefectiveListEntity>(itemListData, pageNumber, pageSize);
        public BindingSource itemListDataSource = new BindingSource();

        public Entities.TrnSalesEntity trnSalesEntity;
        public TrnPOSDefectiveListForm()
        {
            InitializeComponent();

            CreateDefectiveListDataGridView();
        }
        public void UpdateDefectiveListDataSource()
        {
            SetDefectiveListDataSourceAsync();
        }

        public async void SetDefectiveListDataSourceAsync()
        {
            List<Entities.DgvTrnDefectiveListEntity> getDefectiveListData = await GetDefectiveListDataTask();
            if (getDefectiveListData.Any())
            {
                itemListData = getDefectiveListData;
                itemListPageList = new PagedList<Entities.DgvTrnDefectiveListEntity>(itemListData, pageNumber, pageSize);

                if (itemListPageList.PageCount == 1)
                {
                    buttonDefectiveListPageListFirst.Enabled = false;
                    buttonDefectiveListPageListPrevious.Enabled = false;
                    buttonDefectiveListPageListNext.Enabled = false;
                    buttonDefectiveListPageListLast.Enabled = false;
                }
                else if (pageNumber == 1)
                {
                    buttonDefectiveListPageListFirst.Enabled = false;
                    buttonDefectiveListPageListPrevious.Enabled = false;
                    buttonDefectiveListPageListNext.Enabled = true;
                    buttonDefectiveListPageListLast.Enabled = true;
                }
                else if (pageNumber == itemListPageList.PageCount)
                {
                    buttonDefectiveListPageListFirst.Enabled = true;
                    buttonDefectiveListPageListPrevious.Enabled = true;
                    buttonDefectiveListPageListNext.Enabled = false;
                    buttonDefectiveListPageListLast.Enabled = false;
                }
                else
                {
                    buttonDefectiveListPageListFirst.Enabled = true;
                    buttonDefectiveListPageListPrevious.Enabled = true;
                    buttonDefectiveListPageListNext.Enabled = true;
                    buttonDefectiveListPageListLast.Enabled = true;
                }

                textBoxDefectiveListPageNumber.Text = pageNumber + " / " + itemListPageList.PageCount;
                itemListDataSource.DataSource = itemListPageList;
            }
            else
            {
                buttonDefectiveListPageListFirst.Enabled = false;
                buttonDefectiveListPageListPrevious.Enabled = false;
                buttonDefectiveListPageListNext.Enabled = false;
                buttonDefectiveListPageListLast.Enabled = false;

                pageNumber = 1;

                itemListData = new List<Entities.DgvTrnDefectiveListEntity>();
                itemListDataSource.Clear();
                textBoxDefectiveListPageNumber.Text = "1 / 1";
            }
        }

        public Task<List<Entities.DgvTrnDefectiveListEntity>> GetDefectiveListDataTask()
        {
            string gridEdit = "Edit";
            string gridDelete = "Delete";
            var language = Modules.SysCurrentModule.GetCurrentSettings().Language;
            if (language != "English")
            {
                gridEdit = "编辑";
                gridDelete = "删除";
            }
            else
            {
                gridEdit = "Edit";
                gridDelete = "Delete";
            }

            DateTime dateFilter = dateTimePickerDefectveListFilter.Value.Date;
            String filter = textBoxDefectiveListFilter.Text;
            Controllers.TrnDefectiveController trnDefectiveController = new Controllers.TrnDefectiveController();

            List<Entities.TrnDefectiveEntity> listDefective = trnDefectiveController.ListDefective(dateFilter, filter);
            if (listDefective.Any())
            {
                var items = from d in listDefective
                            select new Entities.DgvTrnDefectiveListEntity
                            {
                                ColumnDefectiveListButtonEdit = gridEdit,
                                ColumnDefectiveListButtonDelete = gridDelete,
                                ColumnDefectiveListId = d.Id,
                                ColumnDefectiveListDefectiveNo = d.DefectiveNo,
                                ColumnDefectiveListDefectiveDate = d.DefectiveDate,
                                ColumnDefectiveListPurchasedDate = d.PurchasedDate,
                                ColumnDefectiveListInvoiceNo = d.InvoiceNo,
                                ColumnDefectiveListCustomerName = d.CustomerName,
                                ColumnDefectiveListReplacementDate = d.ReplacementDate,
                                ColumnDefectiveListReplacementInvoiceNo = d.ReplacementInvoiceNo,
                                ColumnDefectiveListPreparedById = d.PreparedById,
                                ColumnDefectiveListIsLocked = d.IsLocked
                            };

                return Task.FromResult(items.ToList());
            }
            else
            {
                return Task.FromResult(new List<Entities.DgvTrnDefectiveListEntity>());
            }
        }

        public void CreateDefectiveListDataGridView()
        {
            UpdateDefectiveListDataSource();

            dataGridViewDefectiveList.Columns[0].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#01A6F0");
            dataGridViewDefectiveList.Columns[0].DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#01A6F0");
            dataGridViewDefectiveList.Columns[0].DefaultCellStyle.ForeColor = Color.White;

            dataGridViewDefectiveList.Columns[1].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F34F1C");
            dataGridViewDefectiveList.Columns[1].DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#F34F1C");
            dataGridViewDefectiveList.Columns[1].DefaultCellStyle.ForeColor = Color.White;

            dataGridViewDefectiveList.DataSource = itemListDataSource;
        }

        public void GetDefectiveListCurrentSelectedCell(Int32 rowIndex)
        {

        }

        private void buttonDefectiveListPageListFirst_Click(object sender, EventArgs e)
        {
            itemListPageList = new PagedList<Entities.DgvTrnDefectiveListEntity>(itemListData, 1, pageSize);
            itemListDataSource.DataSource = itemListPageList;

            buttonDefectiveListPageListFirst.Enabled = false;
            buttonDefectiveListPageListPrevious.Enabled = false;
            buttonDefectiveListPageListNext.Enabled = true;
            buttonDefectiveListPageListLast.Enabled = true;

            pageNumber = 1;
            textBoxDefectiveListPageNumber.Text = pageNumber + " / " + itemListPageList.PageCount;
        }

        private void buttonDefectiveListPageListPrevious_Click(object sender, EventArgs e)
        {
            if (itemListPageList.HasPreviousPage == true)
            {
                itemListPageList = new PagedList<Entities.DgvTrnDefectiveListEntity>(itemListData, --pageNumber, pageSize);
                itemListDataSource.DataSource = itemListPageList;
            }

            buttonDefectiveListPageListNext.Enabled = true;
            buttonDefectiveListPageListLast.Enabled = true;

            if (pageNumber == 1)
            {
                buttonDefectiveListPageListFirst.Enabled = false;
                buttonDefectiveListPageListPrevious.Enabled = false;
            }

            textBoxDefectiveListPageNumber.Text = pageNumber + " / " + itemListPageList.PageCount;
        }

        private void buttonDefectiveListPageListNext_Click(object sender, EventArgs e)
        {
            if (itemListPageList.HasNextPage == true)
            {
                itemListPageList = new PagedList<Entities.DgvTrnDefectiveListEntity>(itemListData, ++pageNumber, pageSize);
                itemListDataSource.DataSource = itemListPageList;
            }

            buttonDefectiveListPageListFirst.Enabled = true;
            buttonDefectiveListPageListPrevious.Enabled = true;

            if (pageNumber == itemListPageList.PageCount)
            {
                buttonDefectiveListPageListNext.Enabled = false;
                buttonDefectiveListPageListLast.Enabled = false;
            }

            textBoxDefectiveListPageNumber.Text = pageNumber + " / " + itemListPageList.PageCount;
        }

        private void buttonDefectiveListPageListLast_Click(object sender, EventArgs e)
        {
            itemListPageList = new PagedList<Entities.DgvTrnDefectiveListEntity>(itemListData, itemListPageList.PageCount, pageSize);
            itemListDataSource.DataSource = itemListPageList;

            buttonDefectiveListPageListFirst.Enabled = true;
            buttonDefectiveListPageListPrevious.Enabled = true;
            buttonDefectiveListPageListNext.Enabled = false;
            buttonDefectiveListPageListLast.Enabled = false;

            pageNumber = itemListPageList.PageCount;
            textBoxDefectiveListPageNumber.Text = pageNumber + " / " + itemListPageList.PageCount;
        }

        private void textBoxDefectiveListFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UpdateDefectiveListDataSource();
            }
        }

        private void dateTimePickerDefectveListFilter_ValueChanged(object sender, EventArgs e)
        {
            UpdateDefectiveListDataSource();
        }

        private void dataGridViewDefectiveList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                GetDefectiveListCurrentSelectedCell(e.RowIndex);
            }

            if (e.RowIndex > -1 && dataGridViewDefectiveList.CurrentCell.ColumnIndex == dataGridViewDefectiveList.Columns["ColumnDefectiveListButtonEdit"].Index)
            {
                Controllers.TrnDefectiveController trnDefectiveController = new Controllers.TrnDefectiveController();
                TrnPOS.TrnPOSDefectiveDetailForm trnPOSDefectiveDetailForm = new TrnPOS.TrnPOSDefectiveDetailForm(this, trnDefectiveController.DetailDefective(Convert.ToInt32(dataGridViewDefectiveList.Rows[e.RowIndex].Cells[2].Value)));
                trnPOSDefectiveDetailForm.ShowDialog();
            }

            if (e.RowIndex > -1 && dataGridViewDefectiveList.CurrentCell.ColumnIndex == dataGridViewDefectiveList.Columns["ColumnDefectiveListButtonDelete"].Index)
            {
                Boolean isLocked = Convert.ToBoolean(dataGridViewDefectiveList.Rows[e.RowIndex].Cells[11].Value);

                if (isLocked == true)
                {
                    MessageBox.Show("Already locked.", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult deleteDialogResult = MessageBox.Show("Delete defective record?", "Easy POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (deleteDialogResult == DialogResult.Yes)
                    {
                        Controllers.TrnDefectiveController trnDefectiveController = new Controllers.TrnDefectiveController();

                        String[] deleteDefective = trnDefectiveController.DeleteDefective(Convert.ToInt32(dataGridViewDefectiveList.Rows[e.RowIndex].Cells[2].Value));
                        if (deleteDefective[1].Equals("0") == false)
                        {
                            pageNumber = 1;
                            UpdateDefectiveListDataSource();
                        }
                        else
                        {
                            MessageBox.Show(deleteDefective[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Controllers.TrnDefectiveController trnDefectiveController = new Controllers.TrnDefectiveController();
            String[] addDefective = trnDefectiveController.AddDefective();
            if (addDefective[1].Equals("0") == false)
            {
                TrnPOS.TrnPOSDefectiveDetailForm trnPOSDefectiveDetailForm = new TrnPOS.TrnPOSDefectiveDetailForm(this, trnDefectiveController.DetailDefective(Convert.ToInt32(addDefective[1])));
                trnPOSDefectiveDetailForm.ShowDialog();
                UpdateDefectiveListDataSource();
            }
            else
            {
                MessageBox.Show(addDefective[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
