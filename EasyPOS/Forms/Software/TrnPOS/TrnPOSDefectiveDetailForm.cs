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
    public partial class TrnPOSDefectiveDetailForm : Form
    {
        public TrnPOSDefectiveListForm trnDefectiveListForm;
        public Entities.TrnDefectiveEntity trnDefectiveEntity;

        public static List<Entities.DgvTrnDefectiveLineListEntity> defectiveLineData = new List<Entities.DgvTrnDefectiveLineListEntity>();
        public static Int32 defectiveLinePageNumber = 1;
        public static Int32 defectiveLinePageSize = 50;
        public PagedList<Entities.DgvTrnDefectiveLineListEntity> defectiveLinePageList = new PagedList<Entities.DgvTrnDefectiveLineListEntity>(defectiveLineData, defectiveLinePageNumber, defectiveLinePageSize);
        public BindingSource defectiveLineDataSource = new BindingSource();

        public static List<Entities.DgvTrnDefectiveLineReplacementListEntity> replacementLineData = new List<Entities.DgvTrnDefectiveLineReplacementListEntity>();
        public static Int32 replacementLinePageNumber = 1;
        public static Int32 replacementLinePageSize = 50;
        public PagedList<Entities.DgvTrnDefectiveLineReplacementListEntity> replacementLinePageList = new PagedList<Entities.DgvTrnDefectiveLineReplacementListEntity>(replacementLineData, replacementLinePageNumber, replacementLinePageSize);
        public BindingSource replacementLineDataSource = new BindingSource();

        public TrnPOSDefectiveDetailForm(TrnPOSDefectiveListForm defectiveListForm, Entities.TrnDefectiveEntity defectiveEntity)
        {
            InitializeComponent();

            trnDefectiveListForm = defectiveListForm;
            trnDefectiveEntity = defectiveEntity;

            GetUserList();

            var id = trnDefectiveEntity.Id;

            Controllers.TrnDefectiveController trnDefective = new Controllers.TrnDefectiveController();
            var detail = trnDefective.DetailDefective(id);
        }
        public void GetUserList()
        {
            Controllers.TrnStockInController trnStockInController = new Controllers.TrnStockInController();
            if (trnStockInController.DropdownListStockInUser().Any())
            {
                comboBoxPreparedBy.DataSource = trnStockInController.DropdownListStockInUser();
                comboBoxPreparedBy.ValueMember = "Id";
                comboBoxPreparedBy.DisplayMember = "FullName";

                GetDefectiveDetail();
            }
        }
        public void GetDefectiveDetail()
        {
            UpdateComponents(trnDefectiveEntity.IsLocked);

            textBoxDefectiveNumber.Text = trnDefectiveEntity.DefectiveNo;
            dateTimePickerDefectiveDate.Value = Convert.ToDateTime(trnDefectiveEntity.DefectiveDate);
            textBoxInvoiceNo.Text = trnDefectiveEntity.InvoiceNo;
            textBoxCustomerName.Text = trnDefectiveEntity.CustomerName;
            textBoxWarrantyCode.Text = trnDefectiveEntity.WarrantyCode;
            comboBoxPreparedBy.SelectedValue = trnDefectiveEntity.PreparedById;

            CreateDefectiveLineListDataGridView();
            CreateDefectiveLineReplacementListDataGridView();
        }
        public void UpdateDefectiveLineListDataSource()
        {
            SetDefectiveLineListDataSourceAsync();
        }
        public void UpdateDefectiveLineReplacementListDataSource()
        {
            SetDefectiveLineReplacementListDataSourceAsync();
        }
        public async void SetDefectiveLineListDataSourceAsync()
        {
            List<Entities.DgvTrnDefectiveLineListEntity> getDefectiveLineListData = await GetDefectiveLineListDataTask();
            if (getDefectiveLineListData.Any())
            {
                defectiveLineData = getDefectiveLineListData;
                defectiveLinePageList = new PagedList<Entities.DgvTrnDefectiveLineListEntity>(defectiveLineData, defectiveLinePageNumber, defectiveLinePageSize);

                if (defectiveLinePageList.PageCount == 1)
                {
                    buttonDefectiveLineListPageListFirst.Enabled = false;
                    buttonDefectiveLineListPageListPrevious.Enabled = false;
                    buttonDefectiveLineListPageListNext.Enabled = false;
                    buttonDefectiveLineListPageListLast.Enabled = false;
                }
                else if (defectiveLinePageNumber == 1)
                {
                    buttonDefectiveLineListPageListFirst.Enabled = false;
                    buttonDefectiveLineListPageListPrevious.Enabled = false;
                    buttonDefectiveLineListPageListNext.Enabled = true;
                    buttonDefectiveLineListPageListLast.Enabled = true;
                }
                else if (defectiveLinePageNumber == defectiveLinePageList.PageCount)
                {
                    buttonDefectiveLineListPageListFirst.Enabled = true;
                    buttonDefectiveLineListPageListPrevious.Enabled = true;
                    buttonDefectiveLineListPageListNext.Enabled = false;
                    buttonDefectiveLineListPageListLast.Enabled = false;
                }
                else
                {
                    buttonDefectiveLineListPageListFirst.Enabled = true;
                    buttonDefectiveLineListPageListPrevious.Enabled = true;
                    buttonDefectiveLineListPageListNext.Enabled = true;
                    buttonDefectiveLineListPageListLast.Enabled = true;
                }

                textBoxDefectiveLineListPageNumber.Text = defectiveLinePageNumber + " / " + defectiveLinePageList.PageCount;
                defectiveLineDataSource.DataSource = defectiveLinePageList;
            }
            else
            {
                buttonDefectiveLineListPageListFirst.Enabled = false;
                buttonDefectiveLineListPageListPrevious.Enabled = false;
                buttonDefectiveLineListPageListNext.Enabled = false;
                buttonDefectiveLineListPageListLast.Enabled = false;

                defectiveLinePageNumber = 1;

                defectiveLineData = new List<Entities.DgvTrnDefectiveLineListEntity>();
                defectiveLineDataSource.Clear();
                textBoxDefectiveLineListPageNumber.Text = "1 / 1";
            }
        }
        public async void SetDefectiveLineReplacementListDataSourceAsync()
        {
            List<Entities.DgvTrnDefectiveLineReplacementListEntity> getDefectiveLineListData = await GetDefectiveLineReplacementListDataTask();
            if (getDefectiveLineListData.Any())
            {
                replacementLineData = getDefectiveLineListData;
                replacementLinePageList = new PagedList<Entities.DgvTrnDefectiveLineReplacementListEntity>(replacementLineData, replacementLinePageNumber, replacementLinePageSize);

                if (replacementLinePageList.PageCount == 1)
                {
                    buttonDefectiveLineReplacementListPageListFirst.Enabled = false;
                    buttonDefectiveLineReplacementListPageListPrevious.Enabled = false;
                    buttonDefectiveLineReplacementListPageListNext.Enabled = false;
                    buttonDefectiveLineReplacementListPageListLast.Enabled = false;
                }
                else if (defectiveLinePageNumber == 1)
                {
                    buttonDefectiveLineReplacementListPageListFirst.Enabled = false;
                    buttonDefectiveLineReplacementListPageListPrevious.Enabled = false;
                    buttonDefectiveLineReplacementListPageListNext.Enabled = true;
                    buttonDefectiveLineReplacementListPageListLast.Enabled = true;
                }
                else if (defectiveLinePageNumber == defectiveLinePageList.PageCount)
                {
                    buttonDefectiveLineReplacementListPageListFirst.Enabled = true;
                    buttonDefectiveLineReplacementListPageListPrevious.Enabled = true;
                    buttonDefectiveLineReplacementListPageListNext.Enabled = false;
                    buttonDefectiveLineReplacementListPageListLast.Enabled = false;
                }
                else
                {
                    buttonDefectiveLineReplacementListPageListFirst.Enabled = true;
                    buttonDefectiveLineReplacementListPageListPrevious.Enabled = true;
                    buttonDefectiveLineReplacementListPageListNext.Enabled = true;
                    buttonDefectiveLineReplacementListPageListLast.Enabled = true;
                }

                textBoxDefectiveLineReplacementListPageNumber.Text = replacementLinePageNumber + " / " + replacementLinePageList.PageCount;
                replacementLineDataSource.DataSource = replacementLinePageList;
            }
            else
            {
                buttonDefectiveLineReplacementListPageListFirst.Enabled = false;
                buttonDefectiveLineReplacementListPageListPrevious.Enabled = false;
                buttonDefectiveLineReplacementListPageListNext.Enabled = false;
                buttonDefectiveLineReplacementListPageListLast.Enabled = false;

                replacementLinePageNumber = 1;

                replacementLineData = new List<Entities.DgvTrnDefectiveLineReplacementListEntity>();
                replacementLineDataSource.Clear();
                textBoxDefectiveLineReplacementListPageNumber.Text = "1 / 1";
            }
        }

        public Task<List<Entities.DgvTrnDefectiveLineListEntity>> GetDefectiveLineListDataTask()
        {
            Controllers.TrnDefectiveLineController trnDefectiveLineController = new Controllers.TrnDefectiveLineController();

            List<Entities.TrnDefectiveLineEntity> listDefectiveLine = trnDefectiveLineController.ListDefectiveLine(trnDefectiveEntity.Id);
            if (listDefectiveLine.Any())
            {
                var items = from d in listDefectiveLine
                            select new Entities.DgvTrnDefectiveLineListEntity
                            {
                                ColumnDefectiveLineListButtonEdit = "Edit",
                                ColumnDefectiveLineListButtonDelete = "Delete",
                                ColumnDefectiveLineListId = d.Id,
                                ColumnDefectiveLineListDefectiveId = d.DefectiveId,
                                ColumnDefectiveLineListItemId = d.ItemId,
                                ColumnDefectiveLineListItemDescription = d.ItemDescription,
                                ColumnDefectiveLineListQuantity = d.Quantity.ToString("#,##0.00"),
                                ColumnDefectiveLineListAmount = d.Amount.ToString("#,##0.00"),
                            };

                return Task.FromResult(items.ToList());
            }
            else
            {
                return Task.FromResult(new List<Entities.DgvTrnDefectiveLineListEntity>());
            }
        }
        public Task<List<Entities.DgvTrnDefectiveLineReplacementListEntity>> GetDefectiveLineReplacementListDataTask()
        {
            Controllers.TrnDefectiveLineController trnDefectiveLineController = new Controllers.TrnDefectiveLineController();

            List<Entities.TrnDefectiveLineEntity> listDefectiveLine = trnDefectiveLineController.ListReplacementLine(trnDefectiveEntity.Id);
            if (listDefectiveLine.Any())
            {
                var items = from d in listDefectiveLine
                            select new Entities.DgvTrnDefectiveLineReplacementListEntity
                            {
                                ColumnDefectiveLineReplacementListButtonEdit = "Edit",
                                ColumnDefectiveLineReplacementListButtonDelete = "Delete",
                                ColumnDefectiveLineReplacementListId = d.Id,
                                ColumnDefectiveLineReplacementListDefectiveId = d.DefectiveId,
                                ColumnDefectiveLineReplacementListItemId = d.ItemId,
                                ColumnDefectiveLineReplacementListItemDescription = d.ItemDescription,
                                ColumnDefectiveLineReplacementListQuantity = d.Quantity.ToString("#,##0.00"),
                                ColumnDefectiveLineReplacementListAmount = d.Amount.ToString("#,##0.00"),
                            };

                return Task.FromResult(items.ToList());
            }
            else
            {
                return Task.FromResult(new List<Entities.DgvTrnDefectiveLineReplacementListEntity>());
            }
        }

        public void CreateDefectiveLineListDataGridView()
        {
            UpdateDefectiveLineListDataSource();

            dataGridViewDefectiveLineList.Columns[0].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#01A6F0");
            dataGridViewDefectiveLineList.Columns[0].DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#01A6F0");
            dataGridViewDefectiveLineList.Columns[0].DefaultCellStyle.ForeColor = Color.White;

            dataGridViewDefectiveLineList.Columns[1].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F34F1C");
            dataGridViewDefectiveLineList.Columns[1].DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#F34F1C");
            dataGridViewDefectiveLineList.Columns[1].DefaultCellStyle.ForeColor = Color.White;

            dataGridViewDefectiveLineList.DataSource = defectiveLineDataSource;
        }
        public void CreateDefectiveLineReplacementListDataGridView()
        {
            UpdateDefectiveLineReplacementListDataSource();

            dataGridViewDefectiveLineReplacementList.Columns[0].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#01A6F0");
            dataGridViewDefectiveLineReplacementList.Columns[0].DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#01A6F0");
            dataGridViewDefectiveLineReplacementList.Columns[0].DefaultCellStyle.ForeColor = Color.White;

            dataGridViewDefectiveLineReplacementList.Columns[1].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F34F1C");
            dataGridViewDefectiveLineReplacementList.Columns[1].DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#F34F1C");
            dataGridViewDefectiveLineReplacementList.Columns[1].DefaultCellStyle.ForeColor = Color.White;

            dataGridViewDefectiveLineReplacementList.DataSource = replacementLineDataSource;
        }

        public void GetDefectiveLineListCurrentSelectedCell(Int32 rowIndex)
        {

        }
        public void GetDefectiveLineReplacementListCurrentSelectedCell(Int32 rowIndex)
        {

        }

        private void dataGridViewDefectiveLineList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                GetDefectiveLineListCurrentSelectedCell(e.RowIndex);
            }

            if (e.RowIndex > -1 && dataGridViewDefectiveLineList.CurrentCell.ColumnIndex == dataGridViewDefectiveLineList.Columns["ColumnDefectiveLineListButtonEdit"].Index)
            {
                var id = Convert.ToInt32(dataGridViewDefectiveLineList.Rows[e.RowIndex].Cells[dataGridViewDefectiveLineList.Columns["ColumnDefectiveLineListId"].Index].Value);
                var defectiveId = Convert.ToInt32(dataGridViewDefectiveLineList.Rows[e.RowIndex].Cells[dataGridViewDefectiveLineList.Columns["ColumnDefectiveLineListDefectiveId"].Index].Value);
                var itemId = Convert.ToInt32(dataGridViewDefectiveLineList.Rows[e.RowIndex].Cells[dataGridViewDefectiveLineList.Columns["ColumnDefectiveLineListItemId"].Index].Value);
                var itemDescription = dataGridViewDefectiveLineList.Rows[e.RowIndex].Cells[dataGridViewDefectiveLineList.Columns["ColumnDefectiveLineListItemDescription"].Index].Value.ToString();
                var quantity = Convert.ToDecimal(dataGridViewDefectiveLineList.Rows[e.RowIndex].Cells[dataGridViewDefectiveLineList.Columns["ColumnDefectiveLineListQuantity"].Index].Value);
                var amount = Convert.ToDecimal(dataGridViewDefectiveLineList.Rows[e.RowIndex].Cells[dataGridViewDefectiveLineList.Columns["ColumnDefectiveLineListAmount"].Index].Value);

                Entities.TrnDefectiveLineEntity trnDefectiveLineEntity = new Entities.TrnDefectiveLineEntity()
                {
                    Id = id,
                    DefectiveId = defectiveId,
                    ItemId = itemId,
                    ItemDescription = itemDescription,
                    Quantity = quantity,
                    Amount = amount,
                    Type = "Defective"
                };

                TrnPOSDefectiveLineItemDetailForm trnPOSDefectiveLineItemDetailForm = new TrnPOSDefectiveLineItemDetailForm(this, trnDefectiveLineEntity);
                trnPOSDefectiveLineItemDetailForm.ShowDialog();
            }

            if (e.RowIndex > -1 && dataGridViewDefectiveLineList.CurrentCell.ColumnIndex == dataGridViewDefectiveLineList.Columns["ColumnDefectiveLineListButtonDelete"].Index)
            {
                DialogResult deleteDialogResult = MessageBox.Show("Delete Defective?", "Easy POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (deleteDialogResult == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(dataGridViewDefectiveLineList.Rows[e.RowIndex].Cells[dataGridViewDefectiveLineList.Columns["ColumnDefectiveLineListId"].Index].Value);

                    Controllers.TrnDefectiveLineController trnDefectiveLineController = new Controllers.TrnDefectiveLineController();
                    String[] deleteDefectiveLine = trnDefectiveLineController.DeleteDefectiveLine(id);
                    if (deleteDefectiveLine[1].Equals("0") == false)
                    {
                        defectiveLinePageNumber = 1;
                        UpdateDefectiveLineListDataSource();
                    }
                    else
                    {
                        MessageBox.Show(deleteDefectiveLine[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void dataGridViewDefectiveReplacementLineList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                GetDefectiveLineReplacementListCurrentSelectedCell(e.RowIndex);
            }

            if (e.RowIndex > -1 && dataGridViewDefectiveLineReplacementList.CurrentCell.ColumnIndex == dataGridViewDefectiveLineReplacementList.Columns["ColumnDefectiveLineReplacementListButtonEdit"].Index)
            {
                var id = Convert.ToInt32(dataGridViewDefectiveLineReplacementList.Rows[e.RowIndex].Cells[dataGridViewDefectiveLineReplacementList.Columns["ColumnDefectiveLineReplacementListId"].Index].Value);
                var defectiveId = Convert.ToInt32(dataGridViewDefectiveLineReplacementList.Rows[e.RowIndex].Cells[dataGridViewDefectiveLineReplacementList.Columns["ColumnDefectiveLineReplacementListDefectiveId"].Index].Value);
                var itemId = Convert.ToInt32(dataGridViewDefectiveLineReplacementList.Rows[e.RowIndex].Cells[dataGridViewDefectiveLineReplacementList.Columns["ColumnDefectiveLineReplacementListItemId"].Index].Value);
                var itemDescription = dataGridViewDefectiveLineReplacementList.Rows[e.RowIndex].Cells[dataGridViewDefectiveLineReplacementList.Columns["ColumnDefectiveLineReplacementListItemDescription"].Index].Value.ToString();
                var quantity = Convert.ToDecimal(dataGridViewDefectiveLineReplacementList.Rows[e.RowIndex].Cells[dataGridViewDefectiveLineReplacementList.Columns["ColumnDefectiveLineReplacementListQuantity"].Index].Value);
                var amount = Convert.ToDecimal(dataGridViewDefectiveLineReplacementList.Rows[e.RowIndex].Cells[dataGridViewDefectiveLineReplacementList.Columns["ColumnDefectiveLineReplacementListAmount"].Index].Value);

                Entities.TrnDefectiveLineEntity trnDefectiveLineEntity = new Entities.TrnDefectiveLineEntity()
                {
                    Id = id,
                    DefectiveId = defectiveId,
                    ItemId = itemId,
                    ItemDescription = itemDescription,
                    Quantity = quantity,
                    Amount = amount,
                    Type = "Defective"
                };

                TrnPOSDefectiveLineItemDetailForm trnPOSDefectiveLineItemDetailForm = new TrnPOSDefectiveLineItemDetailForm(this, trnDefectiveLineEntity);
                trnPOSDefectiveLineItemDetailForm.ShowDialog();
            }

            if (e.RowIndex > -1 && dataGridViewDefectiveLineReplacementList.CurrentCell.ColumnIndex == dataGridViewDefectiveLineReplacementList.Columns["ColumnDefectiveLineReplacementListButtonDelete"].Index)
            {
                DialogResult deleteDialogResult = MessageBox.Show("Delete Defective?", "Easy POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (deleteDialogResult == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(dataGridViewDefectiveLineReplacementList.Rows[e.RowIndex].Cells[dataGridViewDefectiveLineReplacementList.Columns["ColumnDefectiveLineReplacementListId"].Index].Value);

                    Controllers.TrnDefectiveLineController trnDefectiveLineController = new Controllers.TrnDefectiveLineController();
                    String[] deleteDefectiveLine = trnDefectiveLineController.DeleteDefectiveLine(id);
                    if (deleteDefectiveLine[1].Equals("0") == false)
                    {
                        replacementLinePageNumber = 1;
                        UpdateDefectiveLineReplacementListDataSource();
                    }
                    else
                    {
                        MessageBox.Show(deleteDefectiveLine[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void buttonDefectiveLineListPageListFirst_Click(object sender, EventArgs e)
        {
            defectiveLinePageList = new PagedList<Entities.DgvTrnDefectiveLineListEntity>(defectiveLineData, 1, defectiveLinePageSize);
            defectiveLineDataSource.DataSource = defectiveLinePageList;

            buttonDefectiveLineListPageListFirst.Enabled = false;
            buttonDefectiveLineListPageListPrevious.Enabled = false;
            buttonDefectiveLineListPageListNext.Enabled = true;
            buttonDefectiveLineListPageListLast.Enabled = true;

            defectiveLinePageNumber = 1;
            textBoxDefectiveLineListPageNumber.Text = defectiveLinePageNumber + " / " + defectiveLinePageList.PageCount;
        }

        private void buttonDefectiveLineListPageListPrevious_Click(object sender, EventArgs e)
        {
            if (defectiveLinePageList.HasPreviousPage == true)
            {
                defectiveLinePageList = new PagedList<Entities.DgvTrnDefectiveLineListEntity>(defectiveLineData, --defectiveLinePageNumber, defectiveLinePageSize);
                defectiveLineDataSource.DataSource = defectiveLinePageList;
            }

            buttonDefectiveLineListPageListNext.Enabled = true;
            buttonDefectiveLineListPageListLast.Enabled = true;

            if (defectiveLinePageNumber == 1)
            {
                buttonDefectiveLineListPageListFirst.Enabled = false;
                buttonDefectiveLineListPageListPrevious.Enabled = false;
            }

            textBoxDefectiveLineListPageNumber.Text = defectiveLinePageNumber + " / " + defectiveLinePageList.PageCount;
        }

        private void buttonDefectiveLineListPageListNext_Click(object sender, EventArgs e)
        {
            if (defectiveLinePageList.HasNextPage == true)
            {
                defectiveLinePageList = new PagedList<Entities.DgvTrnDefectiveLineListEntity>(defectiveLineData, ++defectiveLinePageNumber, defectiveLinePageSize);
                defectiveLineDataSource.DataSource = defectiveLinePageList;
            }

            buttonDefectiveLineListPageListFirst.Enabled = true;
            buttonDefectiveLineListPageListPrevious.Enabled = true;

            if (defectiveLinePageNumber == defectiveLinePageList.PageCount)
            {
                buttonDefectiveLineListPageListNext.Enabled = false;
                buttonDefectiveLineListPageListLast.Enabled = false;
            }

            textBoxDefectiveLineListPageNumber.Text = defectiveLinePageNumber + " / " + defectiveLinePageList.PageCount;
        }
        private void buttonCustomerListPageListLast_Click(object sender, EventArgs e)
        {
            defectiveLinePageList = new PagedList<Entities.DgvTrnDefectiveLineListEntity>(defectiveLineData, ++defectiveLinePageNumber, defectiveLinePageSize);
            defectiveLineDataSource.DataSource = defectiveLinePageList;

            buttonDefectiveLineListPageListFirst.Enabled = true;
            buttonDefectiveLineListPageListPrevious.Enabled = true;
            buttonDefectiveLineListPageListNext.Enabled = false;
            buttonDefectiveLineListPageListLast.Enabled = false;

            defectiveLinePageNumber = defectiveLinePageList.PageCount;
            textBoxDefectiveLineListPageNumber.Text = defectiveLinePageNumber + " / " + defectiveLinePageList.PageCount;
        }
        private void buttonDefectiveLineReplacementListPageListFirst_Click(object sender, EventArgs e)
        {
            replacementLinePageList = new PagedList<Entities.DgvTrnDefectiveLineReplacementListEntity>(replacementLineData, 1, replacementLinePageSize);
            replacementLineDataSource.DataSource = replacementLinePageList;

            buttonDefectiveLineReplacementListPageListFirst.Enabled = false;
            buttonDefectiveLineReplacementListPageListPrevious.Enabled = false;
            buttonDefectiveLineReplacementListPageListNext.Enabled = true;
            buttonDefectiveLineReplacementListPageListLast.Enabled = true;

            replacementLinePageNumber = 1;
            textBoxDefectiveLineReplacementListPageNumber.Text = replacementLinePageNumber + " / " + replacementLinePageList.PageCount;
        }

        private void buttonDefectiveLineReplacementListPageListPrevious_Click(object sender, EventArgs e)
        {
            if (replacementLinePageList.HasPreviousPage == true)
            {
                replacementLinePageList = new PagedList<Entities.DgvTrnDefectiveLineReplacementListEntity>(replacementLineData, --replacementLinePageNumber, replacementLinePageSize);
                replacementLineDataSource.DataSource = replacementLinePageList;
            }

            buttonDefectiveLineReplacementListPageListNext.Enabled = true;
            buttonDefectiveLineReplacementListPageListLast.Enabled = true;

            if (replacementLinePageNumber == 1)
            {
                buttonDefectiveLineReplacementListPageListFirst.Enabled = false;
                buttonDefectiveLineReplacementListPageListPrevious.Enabled = false;
            }

            textBoxDefectiveLineReplacementListPageNumber.Text = replacementLinePageNumber + " / " + replacementLinePageList.PageCount;
        }

        private void buttonDefectiveLineReplacementListPageListNext_Click(object sender, EventArgs e)
        {
            if (replacementLinePageList.HasNextPage == true)
            {
                replacementLinePageList = new PagedList<Entities.DgvTrnDefectiveLineReplacementListEntity>(replacementLineData, ++replacementLinePageNumber, replacementLinePageSize);
                replacementLineDataSource.DataSource = replacementLinePageList;
            }

            buttonDefectiveLineReplacementListPageListFirst.Enabled = true;
            buttonDefectiveLineReplacementListPageListPrevious.Enabled = true;

            if (replacementLinePageNumber == replacementLinePageList.PageCount)
            {
                buttonDefectiveLineReplacementListPageListNext.Enabled = false;
                buttonDefectiveLineReplacementListPageListLast.Enabled = false;
            }

            textBoxDefectiveLineReplacementListPageNumber.Text = replacementLinePageNumber + " / " + replacementLinePageList.PageCount;
        }
        private void buttonDefectiveLineReplacementListPageListLast_Click(object sender, EventArgs e)
        {
            replacementLinePageList = new PagedList<Entities.DgvTrnDefectiveLineReplacementListEntity>(replacementLineData, ++replacementLinePageNumber, replacementLinePageSize);
            replacementLineDataSource.DataSource = replacementLinePageList;

            buttonDefectiveLineReplacementListPageListFirst.Enabled = true;
            buttonDefectiveLineReplacementListPageListPrevious.Enabled = true;
            buttonDefectiveLineReplacementListPageListNext.Enabled = false;
            buttonDefectiveLineReplacementListPageListLast.Enabled = false;

            replacementLinePageNumber = replacementLinePageList.PageCount;
            textBoxDefectiveLineReplacementListPageNumber.Text = replacementLinePageNumber + " / " + replacementLinePageList.PageCount;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Controllers.TrnDefectiveController trnDefectiveController = new Controllers.TrnDefectiveController();

            Entities.TrnDefectiveEntity newDefectiveEntity = new Entities.TrnDefectiveEntity()
            {
                DefectiveNo = textBoxDefectiveNumber.Text,
                DefectiveDate = dateTimePickerDefectiveDate.Value.Date.ToShortDateString(),
                InvoiceNo = textBoxInvoiceNo.Text,
                CustomerName = textBoxCustomerName.Text,
                WarrantyCode = textBoxWarrantyCode.Text,
                PreparedById = Convert.ToInt32(comboBoxPreparedBy.SelectedValue)
            };

            String[] lockDefective = trnDefectiveController.LockDefective(trnDefectiveEntity.Id, newDefectiveEntity);
            if (lockDefective[1].Equals("0") == false)
            {
                UpdateComponents(true);
                trnDefectiveListForm.UpdateDefectiveListDataSource();
            }
            else
            {
                MessageBox.Show(lockDefective[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void UpdateComponents(Boolean isLocked)
        {
            dateTimePickerDefectiveDate.Enabled = !isLocked;
            textBoxDefectiveNumber.Enabled = !isLocked;
            textBoxInvoiceNo.Enabled = !isLocked;
            textBoxCustomerName.Enabled = !isLocked;
            textBoxWarrantyCode.Enabled = !isLocked;
            comboBoxPreparedBy.Enabled = !isLocked;
            buttonAdd.Enabled = !isLocked;
            buttonAddReplacement.Enabled = !isLocked;

            dataGridViewDefectiveLineList.Columns[0].Visible = !isLocked;
            dataGridViewDefectiveLineList.Columns[1].Visible = !isLocked;
            dataGridViewDefectiveLineReplacementList.Columns[0].Visible = !isLocked;
            dataGridViewDefectiveLineReplacementList.Columns[1].Visible = !isLocked;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Controllers.TrnDefectiveController trnDefectiveController = new Controllers.TrnDefectiveController();

            String[] unlockDefective = trnDefectiveController.UnlockDefective(trnDefectiveEntity.Id);
            if (unlockDefective[1].Equals("0") == false)
            {
                UpdateComponents(false);
                trnDefectiveListForm.UpdateDefectiveListDataSource();
            }
            else
            {
                MessageBox.Show(unlockDefective[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Entities.TrnDefectiveLineEntity trnDefectiveLineEntity = new Entities.TrnDefectiveLineEntity()
            {
                Id = 0,
                DefectiveId = trnDefectiveEntity.Id,
                ItemId = 0,
                ItemDescription = "",
                Quantity = 1,
                Amount = 0,
                Type = "Defective"
            };

            TrnPOSDefectiveLineItemDetailForm trnPOSDefectiveLineItemDetailForm = new TrnPOSDefectiveLineItemDetailForm(this, trnDefectiveLineEntity);
            trnPOSDefectiveLineItemDetailForm.ShowDialog();
        }

        private void buttonAddReplacement_Click(object sender, EventArgs e)
        {
            Entities.TrnDefectiveLineEntity trnDefectiveLineEntity = new Entities.TrnDefectiveLineEntity()
            {
                Id = 0,
                DefectiveId = trnDefectiveEntity.Id,
                ItemId = 0,
                ItemDescription = "",
                Quantity = 1,
                Amount = 0,
                Type = "Replacement"
            };

            TrnPOSDefectiveLineItemDetailForm trnPOSDefectiveLineItemDetailForm = new TrnPOSDefectiveLineItemDetailForm(this, trnDefectiveLineEntity);
            trnPOSDefectiveLineItemDetailForm.ShowDialog();
        }
    }
}
