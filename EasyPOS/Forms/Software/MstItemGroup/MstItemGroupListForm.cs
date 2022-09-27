using EasyPOS.Interfaces.Forms;
using PagedList;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPOS.Forms.Software.MstItemGroup
{
    public partial class MstItemGroupListForm : Form, IUpdateListDataSource
    {
        public SysSoftwareForm sysSoftwareForm;
        private Modules.SysUserRightsModule sysUserRights;

        public static List<Entities.DgvMstItemGroupListEntity> itemGroupListData = new List<Entities.DgvMstItemGroupListEntity>();
        public static Int32 pageNumber = 1;
        public static Int32 pageSize = 50;
        public PagedList<Entities.DgvMstItemGroupListEntity> itemGroupListPageList = new PagedList<Entities.DgvMstItemGroupListEntity>(itemGroupListData, pageNumber, pageSize);
        public BindingSource itemGroupListDataSource = new BindingSource();

        public MstItemGroupListForm(SysSoftwareForm softwareForm)
        {
            InitializeComponent();
            sysSoftwareForm = softwareForm;

            sysUserRights = new Modules.SysUserRightsModule("MstItemGroup");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (sysUserRights.GetUserRights().CanAdd == false)
                {
                    buttonAdd.Enabled = false;
                }

                if (sysUserRights.GetUserRights().CanEdit == false)
                {
                    dataGridViewItemGroupList.Columns[0].Visible = false;
                }

                if (sysUserRights.GetUserRights().CanDelete == false)
                {
                    dataGridViewItemGroupList.Columns[1].Visible = false;
                }

                CreateItemGroupListDataGridView();
            }
        }

        public void UpdateListDataSource()
        {
            SetItemGroupListDataSourceAsync();
        }

        public async void SetItemGroupListDataSourceAsync()
        {
            List<Entities.DgvMstItemGroupListEntity> getItemGroupListData = await GetItemGroupListDataTask();
            if (getItemGroupListData.Any())
            {
                itemGroupListData = getItemGroupListData;
                itemGroupListPageList = new PagedList<Entities.DgvMstItemGroupListEntity>(itemGroupListData, pageNumber, pageSize);

                if (itemGroupListPageList.PageCount == 1)
                {
                    buttonItemGroupListPageListFirst.Enabled = false;
                    buttonItemGroupListPageListPrevious.Enabled = false;
                    buttonItemGroupListPageListNext.Enabled = false;
                    buttonItemGroupListPageListLast.Enabled = false;
                }
                else if (pageNumber == 1)
                {
                    buttonItemGroupListPageListFirst.Enabled = false;
                    buttonItemGroupListPageListPrevious.Enabled = false;
                    buttonItemGroupListPageListNext.Enabled = true;
                    buttonItemGroupListPageListLast.Enabled = true;
                }
                else if (pageNumber == itemGroupListPageList.PageCount)
                {
                    buttonItemGroupListPageListFirst.Enabled = true;
                    buttonItemGroupListPageListPrevious.Enabled = true;
                    buttonItemGroupListPageListNext.Enabled = false;
                    buttonItemGroupListPageListLast.Enabled = false;
                }
                else
                {
                    buttonItemGroupListPageListFirst.Enabled = true;
                    buttonItemGroupListPageListPrevious.Enabled = true;
                    buttonItemGroupListPageListNext.Enabled = true;
                    buttonItemGroupListPageListLast.Enabled = true;
                }

                textBoxItemGroupListPageNumber.Text = pageNumber + " / " + itemGroupListPageList.PageCount;
                itemGroupListDataSource.DataSource = itemGroupListPageList;
            }
            else
            {
                buttonItemGroupListPageListFirst.Enabled = false;
                buttonItemGroupListPageListPrevious.Enabled = false;
                buttonItemGroupListPageListNext.Enabled = false;
                buttonItemGroupListPageListLast.Enabled = false;

                pageNumber = 1;

                itemGroupListData = new List<Entities.DgvMstItemGroupListEntity>();
                itemGroupListDataSource.Clear();
                textBoxItemGroupListPageNumber.Text = "1 / 1";
            }
        }

        public Task<List<Entities.DgvMstItemGroupListEntity>> GetItemGroupListDataTask()
        {
            String filter = textBoxItemGroupListFilter.Text;
            Controllers.MstItemGroupController mstItemGroupController = new Controllers.MstItemGroupController();

            List<Entities.MstItemGroupEntity> listItemGroup = mstItemGroupController.ListItemGroup(filter);
            if (listItemGroup.Any())
            {
                var itemGroups = from d in listItemGroup
                                select new Entities.DgvMstItemGroupListEntity
                                {
                                    ColumnItemGroupListButtonEdit = "Edit",
                                    ColumnItemGroupListButtonDelete = "Delete",
                                    ColumnItemGroupListId = d.Id,
                                    ColumnItemGroupListItemGroup = d.ItemGroup,
                                    ColumnItemGroupListIsLocked = d.IsLocked
                                };

                return Task.FromResult(itemGroups.ToList());
            }
            else
            {
                return Task.FromResult(new List<Entities.DgvMstItemGroupListEntity>());
            }
        }

        public void CreateItemGroupListDataGridView()
        {
            UpdateListDataSource();

            dataGridViewItemGroupList.Columns[0].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#01A6F0");
            dataGridViewItemGroupList.Columns[0].DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#01A6F0");
            dataGridViewItemGroupList.Columns[0].DefaultCellStyle.ForeColor = Color.White;

            dataGridViewItemGroupList.Columns[1].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F34F1C");
            dataGridViewItemGroupList.Columns[1].DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#F34F1C");
            dataGridViewItemGroupList.Columns[1].DefaultCellStyle.ForeColor = Color.White;

            dataGridViewItemGroupList.DataSource = itemGroupListDataSource;
        }

        public void GetItemGroupListCurrentSelectedCell(Int32 rowIndex)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            sysSoftwareForm.RemoveTabPage();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Controllers.MstItemGroupController mstItemGroupController = new Controllers.MstItemGroupController();
            String[] addItemGroup = mstItemGroupController.AddItemGroup();
            if (addItemGroup[1].Equals("0") == false)
            {
                sysSoftwareForm.AddTabPageItemGroupDetail(this, mstItemGroupController.DetailItemGroup(Convert.ToInt32(addItemGroup[1])));
                UpdateListDataSource();
            }
            else
            {
                MessageBox.Show(addItemGroup[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewItemGroupList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                GetItemGroupListCurrentSelectedCell(e.RowIndex);
            }

            if (e.RowIndex > -1 && dataGridViewItemGroupList.CurrentCell.ColumnIndex == dataGridViewItemGroupList.Columns["ColumnItemGroupListButtonEdit"].Index)
            {
                Controllers.MstItemGroupController mstItemGroupController = new Controllers.MstItemGroupController();
                sysSoftwareForm.AddTabPageItemGroupDetail(this, mstItemGroupController.DetailItemGroup(Convert.ToInt32(dataGridViewItemGroupList.Rows[e.RowIndex].Cells[2].Value)));
            }

            if (e.RowIndex > -1 && dataGridViewItemGroupList.CurrentCell.ColumnIndex == dataGridViewItemGroupList.Columns["ColumnItemGroupListButtonDelete"].Index)
            {
                Boolean isLocked = Convert.ToBoolean(dataGridViewItemGroupList.Rows[e.RowIndex].Cells[dataGridViewItemGroupList.Columns["ColumnItemGroupListIsLocked"].Index].Value);

                if (isLocked == true)
                {
                    MessageBox.Show("Already locked.", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult deleteDialogResult = MessageBox.Show("Delete ItemGroup?", "Easy POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (deleteDialogResult == DialogResult.Yes)
                    {
                        Controllers.MstItemGroupController mstItemGroupController = new Controllers.MstItemGroupController();

                        String[] deleteItemGroup = mstItemGroupController.DeleteItemGroup(Convert.ToInt32(dataGridViewItemGroupList.Rows[e.RowIndex].Cells[2].Value));
                        if (deleteItemGroup[1].Equals("0") == false)
                        {
                            Int32 currentPageNumber = pageNumber;

                            pageNumber = 1;
                            UpdateListDataSource();

                            if (itemGroupListPageList != null)
                            {
                                if (itemGroupListData.Count() % pageSize == 1)
                                {
                                    pageNumber = currentPageNumber - 1;
                                }
                                else if (itemGroupListData.Count() < 1)
                                {
                                    pageNumber = 1;
                                }
                                else
                                {
                                    pageNumber = currentPageNumber;
                                }

                                itemGroupListDataSource.DataSource = itemGroupListPageList;
                            }
                        }
                        else
                        {
                            MessageBox.Show(deleteItemGroup[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void textBoxItemGroupListFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UpdateListDataSource();
            }
        }

        private void buttonItemGroupListPageListFirst_Click(object sender, EventArgs e)
        {
            itemGroupListPageList = new PagedList<Entities.DgvMstItemGroupListEntity>(itemGroupListData, 1, pageSize);
            itemGroupListDataSource.DataSource = itemGroupListPageList;

            buttonItemGroupListPageListFirst.Enabled = false;
            buttonItemGroupListPageListPrevious.Enabled = false;
            buttonItemGroupListPageListNext.Enabled = true;
            buttonItemGroupListPageListLast.Enabled = true;

            pageNumber = 1;
            textBoxItemGroupListPageNumber.Text = pageNumber + " / " + itemGroupListPageList.PageCount;
        }

        private void buttonItemGroupListPageListPrevious_Click(object sender, EventArgs e)
        {
            if (itemGroupListPageList.HasPreviousPage == true)
            {
                itemGroupListPageList = new PagedList<Entities.DgvMstItemGroupListEntity>(itemGroupListData, --pageNumber, pageSize);
                itemGroupListDataSource.DataSource = itemGroupListPageList;
            }

            buttonItemGroupListPageListNext.Enabled = true;
            buttonItemGroupListPageListLast.Enabled = true;

            if (pageNumber == 1)
            {
                buttonItemGroupListPageListFirst.Enabled = false;
                buttonItemGroupListPageListPrevious.Enabled = false;
            }

            textBoxItemGroupListPageNumber.Text = pageNumber + " / " + itemGroupListPageList.PageCount;
        }

        private void buttonItemGroupListPageListNext_Click(object sender, EventArgs e)
        {
            if (itemGroupListPageList.HasNextPage == true)
            {
                itemGroupListPageList = new PagedList<Entities.DgvMstItemGroupListEntity>(itemGroupListData, ++pageNumber, pageSize);
                itemGroupListDataSource.DataSource = itemGroupListPageList;
            }

            buttonItemGroupListPageListFirst.Enabled = true;
            buttonItemGroupListPageListPrevious.Enabled = true;

            if (pageNumber == itemGroupListPageList.PageCount)
            {
                buttonItemGroupListPageListNext.Enabled = false;
                buttonItemGroupListPageListLast.Enabled = false;
            }

            textBoxItemGroupListPageNumber.Text = pageNumber + " / " + itemGroupListPageList.PageCount;
        }

        private void buttonItemGroupListPageListLast_Click(object sender, EventArgs e)
        {
            itemGroupListPageList = new PagedList<Entities.DgvMstItemGroupListEntity>(itemGroupListData, itemGroupListPageList.PageCount, pageSize);
            itemGroupListDataSource.DataSource = itemGroupListPageList;

            buttonItemGroupListPageListFirst.Enabled = true;
            buttonItemGroupListPageListPrevious.Enabled = true;
            buttonItemGroupListPageListNext.Enabled = false;
            buttonItemGroupListPageListLast.Enabled = false;

            pageNumber = itemGroupListPageList.PageCount;
            textBoxItemGroupListPageNumber.Text = pageNumber + " / " + itemGroupListPageList.PageCount;
        }
    }
}
