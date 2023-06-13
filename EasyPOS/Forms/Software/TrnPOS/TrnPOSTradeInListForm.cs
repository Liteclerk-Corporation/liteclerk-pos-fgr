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
    public partial class TrnPOSTradeInListForm : Form
    {
        public static List<Entities.DgvTrnTradeInListEntity> itemListData = new List<Entities.DgvTrnTradeInListEntity>();
        public static Int32 pageNumber = 1;
        public static Int32 pageSize = 50;
        public PagedList<Entities.DgvTrnTradeInListEntity> itemListPageList = new PagedList<Entities.DgvTrnTradeInListEntity>(itemListData, pageNumber, pageSize);
        public BindingSource itemListDataSource = new BindingSource();
        public TrnPOSTradeInListForm()
        {
            InitializeComponent();

            CreateTradeInListDataGridView();
        }
        public void UpdateTradeInListDataSource()
        {
            SetTradeInListDataSourceAsync();
        }
        public async void SetTradeInListDataSourceAsync()
        {
            List<Entities.DgvTrnTradeInListEntity> getTradeInListData = await GetTradeInListDataTask();
            if (getTradeInListData.Any())
            {
                itemListData = getTradeInListData;
                itemListPageList = new PagedList<Entities.DgvTrnTradeInListEntity>(itemListData, pageNumber, pageSize);

                if (itemListPageList.PageCount == 1)
                {
                    buttonTradeInListPageListFirst.Enabled = false;
                    buttonTradeInListPageListPrevious.Enabled = false;
                    buttonTradeInListPageListNext.Enabled = false;
                    buttonTradeInListPageListLast.Enabled = false;
                }
                else if (pageNumber == 1)
                {
                    buttonTradeInListPageListFirst.Enabled = false;
                    buttonTradeInListPageListPrevious.Enabled = false;
                    buttonTradeInListPageListNext.Enabled = true;
                    buttonTradeInListPageListLast.Enabled = true;
                }
                else if (pageNumber == itemListPageList.PageCount)
                {
                    buttonTradeInListPageListFirst.Enabled = true;
                    buttonTradeInListPageListPrevious.Enabled = true;
                    buttonTradeInListPageListNext.Enabled = false;
                    buttonTradeInListPageListLast.Enabled = false;
                }
                else
                {
                    buttonTradeInListPageListFirst.Enabled = true;
                    buttonTradeInListPageListPrevious.Enabled = true;
                    buttonTradeInListPageListNext.Enabled = true;
                    buttonTradeInListPageListLast.Enabled = true;
                }

                textBoxTradeInListPageNumber.Text = pageNumber + " / " + itemListPageList.PageCount;
                itemListDataSource.DataSource = itemListPageList;
            }
            else
            {
                buttonTradeInListPageListFirst.Enabled = false;
                buttonTradeInListPageListPrevious.Enabled = false;
                buttonTradeInListPageListNext.Enabled = false;
                buttonTradeInListPageListLast.Enabled = false;

                pageNumber = 1;

                itemListData = new List<Entities.DgvTrnTradeInListEntity>();
                itemListDataSource.Clear();
                textBoxTradeInListPageNumber.Text = "1 / 1";
            }
        }
        public Task<List<Entities.DgvTrnTradeInListEntity>> GetTradeInListDataTask()
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

            DateTime dateFilter = dateTimePickerTradeInListFilter.Value.Date;
            String filter = textBoxTradeInListFilter.Text;
            Controllers.TrnTradeInController trnTradeInController = new Controllers.TrnTradeInController();

            List<Entities.TrnTradeInEntity> listTradeIn = trnTradeInController.ListTradeIn(dateFilter, filter);
            if (listTradeIn.Any())
            {
                var items = from d in listTradeIn
                            select new Entities.DgvTrnTradeInListEntity
                            {
                                ColumnTradeInListButtonEdit = gridEdit,
                                ColumnTradeInListButtonDelete = gridDelete,
                                ColumnTradeInListId = d.Id,
                                ColumnTradeInListTradeInNo = d.TradeInNo,
                                ColumnTradeInListTradeInDate = d.TradeInDate,
                                ColumnTradeInListRemarks = d.Remarks,
                                ColumnTradeInListIsLocked = d.IsLocked
                            };

                return Task.FromResult(items.ToList());
            }
            else
            {
                return Task.FromResult(new List<Entities.DgvTrnTradeInListEntity>());
            }
        }
        public void CreateTradeInListDataGridView()
        {
            UpdateTradeInListDataSource();

            dataGridViewTradeInList.Columns[0].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#01A6F0");
            dataGridViewTradeInList.Columns[0].DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#01A6F0");
            dataGridViewTradeInList.Columns[0].DefaultCellStyle.ForeColor = Color.White;

            dataGridViewTradeInList.Columns[1].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F34F1C");
            dataGridViewTradeInList.Columns[1].DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#F34F1C");
            dataGridViewTradeInList.Columns[1].DefaultCellStyle.ForeColor = Color.White;

            dataGridViewTradeInList.DataSource = itemListDataSource;
        }

        public void GetTradeInListCurrentSelectedCell(Int32 rowIndex)
        {

        }
        private void buttonTradeInListPageListFirst_Click(object sender, EventArgs e)
        {
            itemListPageList = new PagedList<Entities.DgvTrnTradeInListEntity>(itemListData, 1, pageSize);
            itemListDataSource.DataSource = itemListPageList;

            buttonTradeInListPageListFirst.Enabled = false;
            buttonTradeInListPageListPrevious.Enabled = false;
            buttonTradeInListPageListNext.Enabled = true;
            buttonTradeInListPageListLast.Enabled = true;

            pageNumber = 1;
            textBoxTradeInListPageNumber.Text = pageNumber + " / " + itemListPageList.PageCount;
        }

        private void buttonTradeInListPageListPrevious_Click(object sender, EventArgs e)
        {
            if (itemListPageList.HasPreviousPage == true)
            {
                itemListPageList = new PagedList<Entities.DgvTrnTradeInListEntity>(itemListData, --pageNumber, pageSize);
                itemListDataSource.DataSource = itemListPageList;
            }

            buttonTradeInListPageListNext.Enabled = true;
            buttonTradeInListPageListLast.Enabled = true;

            if (pageNumber == 1)
            {
                buttonTradeInListPageListFirst.Enabled = false;
                buttonTradeInListPageListPrevious.Enabled = false;
            }

            textBoxTradeInListPageNumber.Text = pageNumber + " / " + itemListPageList.PageCount;
        }

        private void buttonTradeInListPageListNext_Click(object sender, EventArgs e)
        {
            if (itemListPageList.HasNextPage == true)
            {
                itemListPageList = new PagedList<Entities.DgvTrnTradeInListEntity>(itemListData, ++pageNumber, pageSize);
                itemListDataSource.DataSource = itemListPageList;
            }

            buttonTradeInListPageListFirst.Enabled = true;
            buttonTradeInListPageListPrevious.Enabled = true;

            if (pageNumber == itemListPageList.PageCount)
            {
                buttonTradeInListPageListNext.Enabled = false;
                buttonTradeInListPageListLast.Enabled = false;
            }

            textBoxTradeInListPageNumber.Text = pageNumber + " / " + itemListPageList.PageCount;
        }

        private void buttonTradeInListPageListLast_Click(object sender, EventArgs e)
        {
            itemListPageList = new PagedList<Entities.DgvTrnTradeInListEntity>(itemListData, itemListPageList.PageCount, pageSize);
            itemListDataSource.DataSource = itemListPageList;

            buttonTradeInListPageListFirst.Enabled = true;
            buttonTradeInListPageListPrevious.Enabled = true;
            buttonTradeInListPageListNext.Enabled = false;
            buttonTradeInListPageListLast.Enabled = false;

            pageNumber = itemListPageList.PageCount;
            textBoxTradeInListPageNumber.Text = pageNumber + " / " + itemListPageList.PageCount;
        }
        private void textBoxTradeInListFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UpdateTradeInListDataSource();
            }
        }

        private void dateTimePickerTradeInListFilter_ValueChanged(object sender, EventArgs e)
        {
            UpdateTradeInListDataSource();
        }

        private void dataGridViewTradeInList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                GetTradeInListCurrentSelectedCell(e.RowIndex);
            }

            if (e.RowIndex > -1 && dataGridViewTradeInList.CurrentCell.ColumnIndex == dataGridViewTradeInList.Columns["ColumnTradeInListButtonEdit"].Index)
            {
                Controllers.TrnTradeInController trnTradeInController = new Controllers.TrnTradeInController();
                TrnPOS.TrnPOSTradeInDetailForm trnPOSTradeInDetailForm = new TrnPOS.TrnPOSTradeInDetailForm(this, trnTradeInController.DetailTradeIn(Convert.ToInt32(dataGridViewTradeInList.Rows[e.RowIndex].Cells[2].Value)));
                trnPOSTradeInDetailForm.ShowDialog();
            }

            if (e.RowIndex > -1 && dataGridViewTradeInList.CurrentCell.ColumnIndex == dataGridViewTradeInList.Columns["ColumnTradeInListButtonDelete"].Index)
            {
                Boolean isLocked = Convert.ToBoolean(dataGridViewTradeInList.Rows[e.RowIndex].Cells[6].Value);

                if (isLocked == true)
                {
                    MessageBox.Show("Already locked.", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult deleteDialogResult = MessageBox.Show("Delete Trade - In record?", "Easy POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (deleteDialogResult == DialogResult.Yes)
                    {
                        Controllers.TrnTradeInController trnTradeInController = new Controllers.TrnTradeInController();

                        String[] deleteTradeIn = trnTradeInController.DeleteTradeIn(Convert.ToInt32(dataGridViewTradeInList.Rows[e.RowIndex].Cells[2].Value));
                        if (deleteTradeIn[1].Equals("0") == false)
                        {
                            pageNumber = 1;
                            UpdateTradeInListDataSource();
                        }
                        else
                        {
                            MessageBox.Show(deleteTradeIn[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Controllers.TrnTradeInController trnTradeInController = new Controllers.TrnTradeInController();
            String[] addTradeIn = trnTradeInController.AddTradeIn();
            if (addTradeIn[1].Equals("0") == false)
            {
                TrnPOS.TrnPOSTradeInDetailForm trnPOSTradeInDetailForm = new TrnPOS.TrnPOSTradeInDetailForm(this, trnTradeInController.DetailTradeIn(Convert.ToInt32(addTradeIn[1])));
                trnPOSTradeInDetailForm.ShowDialog();
                UpdateTradeInListDataSource();
            }
            else
            {
                MessageBox.Show(addTradeIn[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
