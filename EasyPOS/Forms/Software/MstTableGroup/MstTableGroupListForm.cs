using EasyPOS.Interfaces.Forms;
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

namespace EasyPOS.Forms.Software.MstTableGroup
{
    public partial class MstTableGroupListForm : Form, IUpdateListDataSource
    {
        public SysSoftwareForm sysSoftwareForm;
        private Modules.SysUserRightsModule sysUserRights;

        public static List<Entities.DgvMstTableGroupListEntity> tableGroupListData = new List<Entities.DgvMstTableGroupListEntity>();
        public static Int32 pageNumber = 1;
        public static Int32 pageSize = 50;
        public PagedList<Entities.DgvMstTableGroupListEntity> tableGroupListPageList = new PagedList<Entities.DgvMstTableGroupListEntity>(tableGroupListData, pageNumber, pageSize);
        public BindingSource tableGroupListDataSource = new BindingSource();

        public MstTableGroupListForm(SysSoftwareForm softwareForm)
        {
            InitializeComponent();
            sysSoftwareForm = softwareForm;

            sysUserRights = new Modules.SysUserRightsModule("MstTables");
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
                    dataGridViewTableGroupList.Columns[0].Visible = false;
                }

                if (sysUserRights.GetUserRights().CanDelete == false)
                {
                    dataGridViewTableGroupList.Columns[1].Visible = false;
                }

                CreateTableGroupListDataGridView();
            }
        }

        public void UpdateListDataSource()
        {
            SetTableGroupListDataSourceAsync();
        }

        public async void SetTableGroupListDataSourceAsync()
        {
            List<Entities.DgvMstTableGroupListEntity> getTableGroupListData = await GetTableGroupListDataTask();
            if (getTableGroupListData.Any())
            {
                tableGroupListData = getTableGroupListData;
                tableGroupListPageList = new PagedList<Entities.DgvMstTableGroupListEntity>(tableGroupListData, pageNumber, pageSize);

                if (tableGroupListPageList.PageCount == 1)
                {
                    buttonTableGroupListPageListFirst.Enabled = false;
                    buttonTableGroupListPageListPrevious.Enabled = false;
                    buttonTableGroupListPageListNext.Enabled = false;
                    buttonTableGroupListPageListLast.Enabled = false;
                }
                else if (pageNumber == 1)
                {
                    buttonTableGroupListPageListFirst.Enabled = false;
                    buttonTableGroupListPageListPrevious.Enabled = false;
                    buttonTableGroupListPageListNext.Enabled = true;
                    buttonTableGroupListPageListLast.Enabled = true;
                }
                else if (pageNumber == tableGroupListPageList.PageCount)
                {
                    buttonTableGroupListPageListFirst.Enabled = true;
                    buttonTableGroupListPageListPrevious.Enabled = true;
                    buttonTableGroupListPageListNext.Enabled = false;
                    buttonTableGroupListPageListLast.Enabled = false;
                }
                else
                {
                    buttonTableGroupListPageListFirst.Enabled = true;
                    buttonTableGroupListPageListPrevious.Enabled = true;
                    buttonTableGroupListPageListNext.Enabled = true;
                    buttonTableGroupListPageListLast.Enabled = true;
                }

                textBoxTableGroupListPageNumber.Text = pageNumber + " / " + tableGroupListPageList.PageCount;
                tableGroupListDataSource.DataSource = tableGroupListPageList;
            }
            else
            {
                buttonTableGroupListPageListFirst.Enabled = false;
                buttonTableGroupListPageListPrevious.Enabled = false;
                buttonTableGroupListPageListNext.Enabled = false;
                buttonTableGroupListPageListLast.Enabled = false;

                pageNumber = 1;

                tableGroupListData = new List<Entities.DgvMstTableGroupListEntity>();
                tableGroupListDataSource.Clear();
                textBoxTableGroupListPageNumber.Text = "1 / 1";
            }
        }

        public Task<List<Entities.DgvMstTableGroupListEntity>> GetTableGroupListDataTask()
        {
            String filter = textBoxTableGroupListFilter.Text;
            Controllers.MstTableGroupController mstTableGroupController = new Controllers.MstTableGroupController();

            List<Entities.MstTableGroupEntity> listTableGroup = mstTableGroupController.ListTableGroup(filter);
            if (listTableGroup.Any())
            {
                var tableGroups = from d in listTableGroup
                                  select new Entities.DgvMstTableGroupListEntity
                                  {
                                      ColumnTableGroupListButtonEdit = "Edit",
                                      ColumnTableGroupListButtonDelete = "Delete",
                                      ColumnTableGroupListId = d.Id,
                                      ColumnTableGroupListTableGroup = d.TableGroup,
                                      ColumnTableGroupListIsLocked = d.IsLocked
                                  };

                return Task.FromResult(tableGroups.ToList());
            }
            else
            {
                return Task.FromResult(new List<Entities.DgvMstTableGroupListEntity>());
            }
        }

        public void CreateTableGroupListDataGridView()
        {
            UpdateListDataSource();

            dataGridViewTableGroupList.Columns[0].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#01A6F0");
            dataGridViewTableGroupList.Columns[0].DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#01A6F0");
            dataGridViewTableGroupList.Columns[0].DefaultCellStyle.ForeColor = Color.White;

            dataGridViewTableGroupList.Columns[1].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F34F1C");
            dataGridViewTableGroupList.Columns[1].DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#F34F1C");
            dataGridViewTableGroupList.Columns[1].DefaultCellStyle.ForeColor = Color.White;

            dataGridViewTableGroupList.DataSource = tableGroupListDataSource;
        }

        public void GetTableGroupListCurrentSelectedCell(Int32 rowIndex)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            sysSoftwareForm.RemoveTabPage();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Controllers.MstTableGroupController mstTableGroupController = new Controllers.MstTableGroupController();
            String[] addTableGroup = mstTableGroupController.AddTableGroup();
            if (addTableGroup[1].Equals("0") == false)
            {
                sysSoftwareForm.AddTabPageTableGroupDetail(this, mstTableGroupController.DetailTableGroup(Convert.ToInt32(addTableGroup[1])));
                UpdateListDataSource();
            }
            else
            {
                MessageBox.Show(addTableGroup[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewTableGroupList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                GetTableGroupListCurrentSelectedCell(e.RowIndex);
            }

            if (e.RowIndex > -1 && dataGridViewTableGroupList.CurrentCell.ColumnIndex == dataGridViewTableGroupList.Columns["ColumnTableGroupListButtonEdit"].Index)
            {
                Controllers.MstTableGroupController mstTableGroupController = new Controllers.MstTableGroupController();
                sysSoftwareForm.AddTabPageTableGroupDetail(this, mstTableGroupController.DetailTableGroup(Convert.ToInt32(dataGridViewTableGroupList.Rows[e.RowIndex].Cells[2].Value)));
            }

            if (e.RowIndex > -1 && dataGridViewTableGroupList.CurrentCell.ColumnIndex == dataGridViewTableGroupList.Columns["ColumnTableGroupListButtonDelete"].Index)
            {
                Boolean isLocked = Convert.ToBoolean(dataGridViewTableGroupList.Rows[e.RowIndex].Cells[dataGridViewTableGroupList.Columns["ColumnTableGroupListIsLocked"].Index].Value);

                if (isLocked == true)
                {
                    MessageBox.Show("Already locked.", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult deleteDialogResult = MessageBox.Show("Delete TableGroup?", "Easy POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (deleteDialogResult == DialogResult.Yes)
                    {
                        Controllers.MstTableGroupController mstTableGroupController = new Controllers.MstTableGroupController();

                        String[] deleteTableGroup = mstTableGroupController.DeleteTableGroup(Convert.ToInt32(dataGridViewTableGroupList.Rows[e.RowIndex].Cells[2].Value));
                        if (deleteTableGroup[1].Equals("0") == false)
                        {
                            Int32 currentPageNumber = pageNumber;

                            pageNumber = 1;
                            UpdateListDataSource();

                            if (tableGroupListPageList != null)
                            {
                                if (tableGroupListData.Count() % pageSize == 1)
                                {
                                    pageNumber = currentPageNumber - 1;
                                }
                                else if (tableGroupListData.Count() < 1)
                                {
                                    pageNumber = 1;
                                }
                                else
                                {
                                    pageNumber = currentPageNumber;
                                }

                                tableGroupListDataSource.DataSource = tableGroupListPageList;
                            }
                        }
                        else
                        {
                            MessageBox.Show(deleteTableGroup[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void textBoxTableGroupListFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UpdateListDataSource();
            }
        }

        private void buttonTableGroupListPageListFirst_Click(object sender, EventArgs e)
        {
            tableGroupListPageList = new PagedList<Entities.DgvMstTableGroupListEntity>(tableGroupListData, 1, pageSize);
            tableGroupListDataSource.DataSource = tableGroupListPageList;

            buttonTableGroupListPageListFirst.Enabled = false;
            buttonTableGroupListPageListPrevious.Enabled = false;
            buttonTableGroupListPageListNext.Enabled = true;
            buttonTableGroupListPageListLast.Enabled = true;

            pageNumber = 1;
            textBoxTableGroupListPageNumber.Text = pageNumber + " / " + tableGroupListPageList.PageCount;
        }

        private void buttonTableGroupListPageListPrevious_Click(object sender, EventArgs e)
        {
            if (tableGroupListPageList.HasPreviousPage == true)
            {
                tableGroupListPageList = new PagedList<Entities.DgvMstTableGroupListEntity>(tableGroupListData, --pageNumber, pageSize);
                tableGroupListDataSource.DataSource = tableGroupListPageList;
            }

            buttonTableGroupListPageListNext.Enabled = true;
            buttonTableGroupListPageListLast.Enabled = true;

            if (pageNumber == 1)
            {
                buttonTableGroupListPageListFirst.Enabled = false;
                buttonTableGroupListPageListPrevious.Enabled = false;
            }

            textBoxTableGroupListPageNumber.Text = pageNumber + " / " + tableGroupListPageList.PageCount;
        }

        private void buttonTableGroupListPageListNext_Click(object sender, EventArgs e)
        {
            if (tableGroupListPageList.HasNextPage == true)
            {
                tableGroupListPageList = new PagedList<Entities.DgvMstTableGroupListEntity>(tableGroupListData, ++pageNumber, pageSize);
                tableGroupListDataSource.DataSource = tableGroupListPageList;
            }

            buttonTableGroupListPageListFirst.Enabled = true;
            buttonTableGroupListPageListPrevious.Enabled = true;

            if (pageNumber == tableGroupListPageList.PageCount)
            {
                buttonTableGroupListPageListNext.Enabled = false;
                buttonTableGroupListPageListLast.Enabled = false;
            }

            textBoxTableGroupListPageNumber.Text = pageNumber + " / " + tableGroupListPageList.PageCount;
        }

        private void buttonTableGroupListPageListLast_Click(object sender, EventArgs e)
        {
            tableGroupListPageList = new PagedList<Entities.DgvMstTableGroupListEntity>(tableGroupListData, tableGroupListPageList.PageCount, pageSize);
            tableGroupListDataSource.DataSource = tableGroupListPageList;

            buttonTableGroupListPageListFirst.Enabled = true;
            buttonTableGroupListPageListPrevious.Enabled = true;
            buttonTableGroupListPageListNext.Enabled = false;
            buttonTableGroupListPageListLast.Enabled = false;

            pageNumber = tableGroupListPageList.PageCount;
            textBoxTableGroupListPageNumber.Text = pageNumber + " / " + tableGroupListPageList.PageCount;
        }
    }
}
