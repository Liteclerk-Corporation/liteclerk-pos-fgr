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
    public partial class TrnPOSTradeInDetailForm : Form
    {
        public TrnPOSTradeInListForm trnTradeInListForm;
        public Entities.TrnTradeInEntity trnTradeInEntity;

        public static List<Entities.DgvTrnTradeInLineListEntity> tradeInLineData = new List<Entities.DgvTrnTradeInLineListEntity>();
        public static Int32 tradeInLinePageNumber = 1;
        public static Int32 tradeInLinePageSize = 50;
        public PagedList<Entities.DgvTrnTradeInLineListEntity> tradeInLinePageList = new PagedList<Entities.DgvTrnTradeInLineListEntity>(tradeInLineData, tradeInLinePageNumber, tradeInLinePageSize);
        public BindingSource tradeInLineDataSource = new BindingSource();
        public TrnPOSTradeInDetailForm(TrnPOSTradeInListForm tradeInListForm, Entities.TrnTradeInEntity tradeInEntity)
        {
            InitializeComponent();
            trnTradeInListForm = tradeInListForm;
            trnTradeInEntity = tradeInEntity;

            var id = trnTradeInEntity.Id;

            GetUserList();

            Controllers.TrnTradeInController trnTradeIn = new Controllers.TrnTradeInController();
            var detail = trnTradeIn.DetailTradeIn(id);
        }
        public void GetUserList()
        {
            Controllers.TrnTradeInController trnTradeInController = new Controllers.TrnTradeInController();
            if (trnTradeInController.DropdownListTradeInUser().Any())
            {
                comboBoxPreparedBy.DataSource = trnTradeInController.DropdownListTradeInUser();
                comboBoxPreparedBy.ValueMember = "Id";
                comboBoxPreparedBy.DisplayMember = "FullName";

                GetTradeInDetail();
            }
        }
        public void GetTradeInDetail()
        {
            UpdateComponents(trnTradeInEntity.IsLocked);

            textBoxTradeInNumber.Text = trnTradeInEntity.TradeInNo;
            dateTimePickerTradeInDate.Value = Convert.ToDateTime(trnTradeInEntity.TradeInDate);
            textBoxRemarks.Text = trnTradeInEntity.Remarks;
            comboBoxPreparedBy.SelectedValue = trnTradeInEntity.PreparedById;

            CreateTradeInLineListDataGridView();
        }
        public void UpdateTradeInLineListDataSource()
        {
            SetTradeInLineListDataSourceAsync();
        }
        public async void SetTradeInLineListDataSourceAsync()
        {
            List<Entities.DgvTrnTradeInLineListEntity> getTradeInLineListData = await GetTradeInLineListDataTask();
            if (getTradeInLineListData.Any())
            {
                tradeInLineData = getTradeInLineListData;
                tradeInLinePageList = new PagedList<Entities.DgvTrnTradeInLineListEntity>(tradeInLineData, tradeInLinePageNumber, tradeInLinePageSize);

                if (tradeInLinePageList.PageCount == 1)
                {
                    buttonTradeInLineListPageListFirst.Enabled = false;
                    buttonTradeInLineListPageListPrevious.Enabled = false;
                    buttonTradeInLineListPageListNext.Enabled = false;
                    buttonTradeInLineListPageListLast.Enabled = false;
                }
                else if (tradeInLinePageNumber == 1)
                {
                    buttonTradeInLineListPageListFirst.Enabled = false;
                    buttonTradeInLineListPageListPrevious.Enabled = false;
                    buttonTradeInLineListPageListNext.Enabled = true;
                    buttonTradeInLineListPageListLast.Enabled = true;
                }
                else if (tradeInLinePageNumber == tradeInLinePageList.PageCount)
                {
                    buttonTradeInLineListPageListFirst.Enabled = true;
                    buttonTradeInLineListPageListPrevious.Enabled = true;
                    buttonTradeInLineListPageListNext.Enabled = false;
                    buttonTradeInLineListPageListLast.Enabled = false;
                }
                else
                {
                    buttonTradeInLineListPageListFirst.Enabled = true;
                    buttonTradeInLineListPageListPrevious.Enabled = true;
                    buttonTradeInLineListPageListNext.Enabled = true;
                    buttonTradeInLineListPageListLast.Enabled = true;
                }

                textBoxTradeInLineListPageNumber.Text = tradeInLinePageNumber + " / " + tradeInLinePageList.PageCount;
                tradeInLineDataSource.DataSource = tradeInLinePageList;
            }
            else
            {
                buttonTradeInLineListPageListFirst.Enabled = false;
                buttonTradeInLineListPageListPrevious.Enabled = false;
                buttonTradeInLineListPageListNext.Enabled = false;
                buttonTradeInLineListPageListLast.Enabled = false;

                tradeInLinePageNumber = 1;

                tradeInLineData = new List<Entities.DgvTrnTradeInLineListEntity>();
                tradeInLineDataSource.Clear();
                textBoxTradeInLineListPageNumber.Text = "1 / 1";
            }
        }
        public Task<List<Entities.DgvTrnTradeInLineListEntity>> GetTradeInLineListDataTask()
        {
            Controllers.TrnTradeInLineController trnTradeInLineController = new Controllers.TrnTradeInLineController();

            List<Entities.TrnTradeInLineEntity> listTradeInLine = trnTradeInLineController.ListTradeInLine(trnTradeInEntity.Id);
            if (listTradeInLine.Any())
            {
                var items = from d in listTradeInLine
                            select new Entities.DgvTrnTradeInLineListEntity
                            {
                                ColumnTradeInLineListButtonEdit = "Edit",
                                ColumnTradeInLineListButtonDelete = "Delete",
                                ColumnTradeInLineListId = d.Id,
                                ColumnTradeInLineListTradeInId = d.TradeInId,
                                ColumnTradeInLineListItemId = d.ItemId,
                                ColumnTradeInLineListItemSize = d.Size,
                                ColumnTradeInLineListItemBrand = d.Brand,
                                ColumnTradeInLineListItemWarrantyCode = d.WarrantyCode,
                                ColumnTradeInLineListQuantity = d.Quantity.ToString("#,##0.00"),
                                ColumnTradeInLineListAmount = d.Amount.ToString("#,##0.00"),
                            };

                return Task.FromResult(items.ToList());
            }
            else
            {
                return Task.FromResult(new List<Entities.DgvTrnTradeInLineListEntity>());
            }
        }

        public void CreateTradeInLineListDataGridView()
        {
            UpdateTradeInLineListDataSource();

            dataGridViewTradeInLineList.Columns[0].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#01A6F0");
            dataGridViewTradeInLineList.Columns[0].DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#01A6F0");
            dataGridViewTradeInLineList.Columns[0].DefaultCellStyle.ForeColor = Color.White;

            dataGridViewTradeInLineList.Columns[1].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F34F1C");
            dataGridViewTradeInLineList.Columns[1].DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#F34F1C");
            dataGridViewTradeInLineList.Columns[1].DefaultCellStyle.ForeColor = Color.White;

            dataGridViewTradeInLineList.DataSource = tradeInLineDataSource;
        }

        public void GetTradeInLineListCurrentSelectedCell(Int32 rowIndex)
        {

        }

        private void dataGridViewTradeInLineList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                GetTradeInLineListCurrentSelectedCell(e.RowIndex);
            }

            if (e.RowIndex > -1 && dataGridViewTradeInLineList.CurrentCell.ColumnIndex == dataGridViewTradeInLineList.Columns["ColumnTradeInLineListButtonEdit"].Index)
            {
                var id = Convert.ToInt32(dataGridViewTradeInLineList.Rows[e.RowIndex].Cells[dataGridViewTradeInLineList.Columns["ColumnTradeInLineListId"].Index].Value);
                var tradeInId = Convert.ToInt32(dataGridViewTradeInLineList.Rows[e.RowIndex].Cells[dataGridViewTradeInLineList.Columns["ColumnTradeInLineListDefectiveId"].Index].Value);
                var itemId = Convert.ToInt32(dataGridViewTradeInLineList.Rows[e.RowIndex].Cells[dataGridViewTradeInLineList.Columns["ColumnTradeInLineListItemId"].Index].Value);
                var size = dataGridViewTradeInLineList.Rows[e.RowIndex].Cells[dataGridViewTradeInLineList.Columns["ColumnTradeInLineListItemSize"].Index].Value.ToString();
                var brand = dataGridViewTradeInLineList.Rows[e.RowIndex].Cells[dataGridViewTradeInLineList.Columns["ColumnTradeInLineListItemBrand"].Index].Value.ToString();
                var warrantyCode = dataGridViewTradeInLineList.Rows[e.RowIndex].Cells[dataGridViewTradeInLineList.Columns["ColumnTradeInLineListWarrantyCode"].Index].Value.ToString();
                var quantity = Convert.ToDecimal(dataGridViewTradeInLineList.Rows[e.RowIndex].Cells[dataGridViewTradeInLineList.Columns["ColumnTradeInLineListQuantity"].Index].Value);
                var amount = Convert.ToDecimal(dataGridViewTradeInLineList.Rows[e.RowIndex].Cells[dataGridViewTradeInLineList.Columns["ColumnTradeInLineListAmount"].Index].Value);

                Entities.TrnTradeInLineEntity trnTradeInLineEntity = new Entities.TrnTradeInLineEntity()
                {
                    Id = id,
                    TradeInId = tradeInId,
                    ItemId = itemId,
                    Size = size,
                    Brand = brand,
                    WarrantyCode = warrantyCode,
                    Quantity = quantity,
                    Amount = amount,
                };

                TrnPOSTradeInLineItemDetailForm trnPOSTradeInLineItemDetailForm = new TrnPOSTradeInLineItemDetailForm(this, trnTradeInLineEntity);
                trnPOSTradeInLineItemDetailForm.ShowDialog();
            }

            if (e.RowIndex > -1 && dataGridViewTradeInLineList.CurrentCell.ColumnIndex == dataGridViewTradeInLineList.Columns["ColumnTradeInLineListButtonDelete"].Index)
            {
                DialogResult deleteDialogResult = MessageBox.Show("Delete Trade - In?", "Easy POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (deleteDialogResult == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(dataGridViewTradeInLineList.Rows[e.RowIndex].Cells[dataGridViewTradeInLineList.Columns["ColumnTradeInLineListId"].Index].Value);

                    Controllers.TrnTradeInLineController trnTradeInLineController = new Controllers.TrnTradeInLineController();
                    String[] deleteTradeInLine = trnTradeInLineController.DeleteTradeInLine(id);
                    if (deleteTradeInLine[1].Equals("0") == false)
                    {
                        tradeInLinePageNumber = 1;
                        UpdateTradeInLineListDataSource();
                    }
                    else
                    {
                        MessageBox.Show(deleteTradeInLine[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void buttonTradeInLineListPageListFirst_Click(object sender, EventArgs e)
        {
            tradeInLinePageList = new PagedList<Entities.DgvTrnTradeInLineListEntity>(tradeInLineData, 1, tradeInLinePageSize);
            tradeInLineDataSource.DataSource = tradeInLinePageList;

            buttonTradeInLineListPageListFirst.Enabled = false;
            buttonTradeInLineListPageListPrevious.Enabled = false;
            buttonTradeInLineListPageListNext.Enabled = true;
            buttonTradeInLineListPageListLast.Enabled = true;

            tradeInLinePageNumber = 1;
            textBoxTradeInLineListPageNumber.Text = tradeInLinePageNumber + " / " + tradeInLinePageList.PageCount;
        }

        private void buttonTradeInLineListPageListPrevious_Click(object sender, EventArgs e)
        {
            if (tradeInLinePageList.HasPreviousPage == true)
            {
                tradeInLinePageList = new PagedList<Entities.DgvTrnTradeInLineListEntity>(tradeInLineData, --tradeInLinePageNumber, tradeInLinePageSize);
                tradeInLineDataSource.DataSource = tradeInLinePageList;
            }

            buttonTradeInLineListPageListNext.Enabled = true;
            buttonTradeInLineListPageListLast.Enabled = true;

            if (tradeInLinePageNumber == 1)
            {
                buttonTradeInLineListPageListFirst.Enabled = false;
                buttonTradeInLineListPageListPrevious.Enabled = false;
            }

            textBoxTradeInLineListPageNumber.Text = tradeInLinePageNumber + " / " + tradeInLinePageList.PageCount;
        }

        private void buttonTradeInLineListPageListNext_Click(object sender, EventArgs e)
        {
            if (tradeInLinePageList.HasNextPage == true)
            {
                tradeInLinePageList = new PagedList<Entities.DgvTrnTradeInLineListEntity>(tradeInLineData, ++tradeInLinePageNumber, tradeInLinePageSize);
                tradeInLineDataSource.DataSource = tradeInLinePageList;
            }

            buttonTradeInLineListPageListFirst.Enabled = true;
            buttonTradeInLineListPageListPrevious.Enabled = true;

            if (tradeInLinePageNumber == tradeInLinePageList.PageCount)
            {
                buttonTradeInLineListPageListNext.Enabled = false;
                buttonTradeInLineListPageListLast.Enabled = false;
            }

            textBoxTradeInLineListPageNumber.Text = tradeInLinePageNumber + " / " + tradeInLinePageList.PageCount;
        }
        private void buttonCustomerListPageListLast_Click(object sender, EventArgs e)
        {
            tradeInLinePageList = new PagedList<Entities.DgvTrnTradeInLineListEntity>(tradeInLineData, ++tradeInLinePageNumber, tradeInLinePageSize);
            tradeInLineDataSource.DataSource = tradeInLinePageList;

            buttonTradeInLineListPageListFirst.Enabled = true;
            buttonTradeInLineListPageListPrevious.Enabled = true;
            buttonTradeInLineListPageListNext.Enabled = false;
            buttonTradeInLineListPageListLast.Enabled = false;

            tradeInLinePageNumber = tradeInLinePageList.PageCount;
            textBoxTradeInLineListPageNumber.Text = tradeInLinePageNumber + " / " + tradeInLinePageList.PageCount;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Controllers.TrnTradeInController trnTradeInController = new Controllers.TrnTradeInController();

            Entities.TrnTradeInEntity newTradeInEntity = new Entities.TrnTradeInEntity()
            {
                TradeInNo = textBoxTradeInNumber.Text,
                TradeInDate = dateTimePickerTradeInDate.Value.Date.ToShortDateString(),
                Remarks = textBoxRemarks.Text,
                PreparedById = Convert.ToInt32(comboBoxPreparedBy.SelectedValue)
            };

            String[] lockTradeIn = trnTradeInController.LockTradeIn(trnTradeInEntity.Id, newTradeInEntity);
            if (lockTradeIn[1].Equals("0") == false)
            {
                UpdateComponents(true);
                trnTradeInListForm.UpdateTradeInListDataSource();
            }
            else
            {
                MessageBox.Show(lockTradeIn[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void UpdateComponents(Boolean isLocked)
        {
            dateTimePickerTradeInDate.Enabled = !isLocked;
            textBoxTradeInNumber.Enabled = !isLocked;
            textBoxRemarks.Enabled = !isLocked;
            comboBoxPreparedBy.Enabled = !isLocked;
            buttonAdd.Enabled = !isLocked;

            dataGridViewTradeInLineList.Columns[0].Visible = !isLocked;
            dataGridViewTradeInLineList.Columns[1].Visible = !isLocked;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Controllers.TrnTradeInController trnTradeInController = new Controllers.TrnTradeInController();

            String[] unlockTradeIn = trnTradeInController.UnlockTradeIn(trnTradeInEntity.Id);
            if (unlockTradeIn[1].Equals("0") == false)
            {
                UpdateComponents(false);
                trnTradeInListForm.UpdateTradeInListDataSource();
            }
            else
            {
                MessageBox.Show(unlockTradeIn[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Entities.TrnTradeInLineEntity trnTradeInLineEntity = new Entities.TrnTradeInLineEntity()
            {
                Id = 0,
                TradeInId = trnTradeInEntity.Id,
                ItemId = 0,
                Quantity = 1,
                Amount = 0,
            };

            TrnPOSTradeInLineItemDetailForm trnPOSTradeInLineItemDetailForm = new TrnPOSTradeInLineItemDetailForm(this, trnTradeInLineEntity);
            trnPOSTradeInLineItemDetailForm.ShowDialog();
        }
    }
}
