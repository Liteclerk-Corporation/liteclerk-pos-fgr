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
    public partial class MstTableGroupDetailForm : Form, IUpdateListDataSource
    {
        public SysSoftwareForm sysSoftwareForm;
        private Modules.SysUserRightsModule sysUserRights;

        IUpdateListDataSource FormWithUpdate;
        public Entities.MstTableGroupEntity mstTableGroupEntity;

        public static List<Entities.DgvMstTableListEntity> tableData = new List<Entities.DgvMstTableListEntity>();
        public static Int32 tablePageNumber = 1;
        public static Int32 tablePageSize = 50;
        public PagedList<Entities.DgvMstTableListEntity> tablePageList = new PagedList<Entities.DgvMstTableListEntity>(tableData, tablePageNumber, tablePageSize);
        public BindingSource tableDataSource = new BindingSource();

        public MstTableGroupDetailForm(SysSoftwareForm softwareForm, IUpdateListDataSource formWithUpdate, Entities.MstTableGroupEntity tableEntity)
        {
            InitializeComponent();
            sysSoftwareForm = softwareForm;

            sysUserRights = new Modules.SysUserRightsModule("MstRestaurantTableDetail");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FormWithUpdate = formWithUpdate;
                mstTableGroupEntity = tableEntity;

                if (sysUserRights.GetUserRights().CanAdd == false)
                {
                    buttonAddTable.Enabled = false;
                }

                if (sysUserRights.GetUserRights().CanEdit == false)
                {
                    dataGridViewTableList.Columns[0].Visible = false;
                }

                if (sysUserRights.GetUserRights().CanDelete == false)
                {
                    dataGridViewTableList.Columns[1].Visible = false;
                }

                GetTableGroupDetail();
                textBoxTableGroup.Focus();
            }
        }

        public void GetTableGroupDetail()
        {
            textBoxTableGroup.Text = mstTableGroupEntity.TableGroup;
            UpdateComponents(mstTableGroupEntity.IsLocked);

            CreateTableListDataGridView();
        }

        public void UpdateComponents(Boolean isLocked)
        {
            if (sysUserRights.GetUserRights().CanLock == false)
            {
                buttonLock.Enabled = false;
            }
            else
            {
                buttonLock.Enabled = !isLocked;
            }

            if (sysUserRights.GetUserRights().CanUnlock == false)
            {
                buttonUnlock.Enabled = false;
            }
            else
            {
                buttonUnlock.Enabled = isLocked;
            }

            if (sysUserRights.GetUserRights().CanAdd == false)
            {
                buttonAddTable.Enabled = false;
            }
            else
            {
                buttonAddTable.Enabled = !isLocked;
            }

            if (sysUserRights.GetUserRights().CanEdit == false)
            {
                dataGridViewTableList.Columns[0].Visible = false;
            }
            else
            {
                dataGridViewTableList.Columns[0].Visible = !isLocked;
            }

            if (sysUserRights.GetUserRights().CanDelete == false)
            {
                dataGridViewTableList.Columns[1].Visible = false;
            }
            else
            {
                dataGridViewTableList.Columns[1].Visible = !isLocked;
            }

            textBoxTableGroup.Enabled = !isLocked;
            textBoxTableGroup.Focus();
        }

        private void buttonLock_Click(object sender, EventArgs e)
        {
            Controllers.MstTableGroupController mstTableGroupController = new Controllers.MstTableGroupController();

            Entities.MstTableGroupEntity newTableGroupEntity = new Entities.MstTableGroupEntity()
            {
                TableGroup = textBoxTableGroup.Text
            };

            String[] lockTableGroup = mstTableGroupController.LockTableGroup(mstTableGroupEntity.Id, newTableGroupEntity);
            if (lockTableGroup[1].Equals("0") == false)
            {
                UpdateComponents(true);
                FormWithUpdate.UpdateListDataSource();
            }
            else
            {
                UpdateComponents(false);
                MessageBox.Show(lockTableGroup[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUnlock_Click(object sender, EventArgs e)
        {
            Controllers.MstTableGroupController mstTableGroupController = new Controllers.MstTableGroupController();

            String[] unlockTableGroup = mstTableGroupController.UnlockTableGroup(mstTableGroupEntity.Id);
            if (unlockTableGroup[1].Equals("0") == false)
            {
                UpdateComponents(false);
                FormWithUpdate.UpdateListDataSource();
            }
            else
            {
                UpdateComponents(true);
                MessageBox.Show(unlockTableGroup[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            sysSoftwareForm.RemoveTabPage();
        }

        public void UpdateListDataSource()
        {
            SetTableListDataSourceAsync();
        }

        public async void SetTableListDataSourceAsync()
        {
            List<Entities.DgvMstTableListEntity> getTableListData = await GetTableListDataTask();
            if (getTableListData.Any())
            {
                tableData = getTableListData;
                tablePageList = new PagedList<Entities.DgvMstTableListEntity>(tableData, tablePageNumber, tablePageSize);

                if (tablePageList.PageCount == 1)
                {
                    buttonTableListPageListFirst.Enabled = false;
                    buttonTableListPageListPrevious.Enabled = false;
                    buttonTableListPageListNext.Enabled = false;
                    buttonTableListPageListLast.Enabled = false;
                }
                else if (tablePageNumber == 1)
                {
                    buttonTableListPageListFirst.Enabled = false;
                    buttonTableListPageListPrevious.Enabled = false;
                    buttonTableListPageListNext.Enabled = true;
                    buttonTableListPageListLast.Enabled = true;
                }
                else if (tablePageNumber == tablePageList.PageCount)
                {
                    buttonTableListPageListFirst.Enabled = true;
                    buttonTableListPageListPrevious.Enabled = true;
                    buttonTableListPageListNext.Enabled = false;
                    buttonTableListPageListLast.Enabled = false;
                }
                else
                {
                    buttonTableListPageListFirst.Enabled = true;
                    buttonTableListPageListPrevious.Enabled = true;
                    buttonTableListPageListNext.Enabled = true;
                    buttonTableListPageListLast.Enabled = true;
                }

                textBoxTableListPageNumber.Text = tablePageNumber + " / " + tablePageList.PageCount;
                tableDataSource.DataSource = tablePageList;
            }
            else
            {
                buttonTableListPageListFirst.Enabled = false;
                buttonTableListPageListPrevious.Enabled = false;
                buttonTableListPageListNext.Enabled = false;
                buttonTableListPageListLast.Enabled = false;

                tablePageNumber = 1;

                tableData = new List<Entities.DgvMstTableListEntity>();
                tableDataSource.Clear();
                textBoxTableListPageNumber.Text = "1 / 1";
            }
        }

        public Task<List<Entities.DgvMstTableListEntity>> GetTableListDataTask()
        {
            Controllers.MstTableController trnTableController = new Controllers.MstTableController();

            List<Entities.MstTableEntity> listTable = trnTableController.ListTable(mstTableGroupEntity.Id);
            if (listTable.Any())
            {
                var items = from d in listTable
                            select new Entities.DgvMstTableListEntity
                            {
                                ColumnTableListButtonEdit = "Edit",
                                ColumnTableListButtonDelete = "Delete",
                                ColumnTableListId = d.Id,
                                ColumnTableListTableCode = d.TableCode,
                                ColumnTableListTableGroupId = d.TableGroupId,
                                ColumnTableListSortNumber = d.SortNumber
                            };

                return Task.FromResult(items.ToList());
            }
            else
            {
                return Task.FromResult(new List<Entities.DgvMstTableListEntity>());
            }
        }

        public void CreateTableListDataGridView()
        {
            UpdateListDataSource();

            dataGridViewTableList.Columns[0].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#01A6F0");
            dataGridViewTableList.Columns[0].DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#01A6F0");
            dataGridViewTableList.Columns[0].DefaultCellStyle.ForeColor = Color.White;

            dataGridViewTableList.Columns[1].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F34F1C");
            dataGridViewTableList.Columns[1].DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#F34F1C");
            dataGridViewTableList.Columns[1].DefaultCellStyle.ForeColor = Color.White;

            dataGridViewTableList.DataSource = tableDataSource;
        }

        public void GetTableListCurrentSelectedCell(Int32 rowIndex)
        {

        }

        private void dataGridViewTableList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                GetTableListCurrentSelectedCell(e.RowIndex);
            }

            if (e.RowIndex > -1 && dataGridViewTableList.CurrentCell.ColumnIndex == dataGridViewTableList.Columns["ColumnTableListButtonEdit"].Index)
            {
                var id = Convert.ToInt32(dataGridViewTableList.Rows[e.RowIndex].Cells[dataGridViewTableList.Columns["ColumnTableListId"].Index].Value);
                var tableCode = dataGridViewTableList.Rows[e.RowIndex].Cells[dataGridViewTableList.Columns["ColumnTableListTableCode"].Index].Value.ToString();
                var tableGroupId = Convert.ToInt32(dataGridViewTableList.Rows[e.RowIndex].Cells[dataGridViewTableList.Columns["ColumnTableListTableGroupId"].Index].Value);
                var sortNumber = Convert.ToInt32(dataGridViewTableList.Rows[e.RowIndex].Cells[dataGridViewTableList.Columns["ColumnTableListSortNumber"].Index].Value);

                Entities.MstTableEntity mstTableEntity = new Entities.MstTableEntity()
                {
                    Id = id,
                    TableCode = tableCode,
                    TableGroupId = tableGroupId,
                    TableGroup = "",
                    SortNumber = sortNumber,
                    TopLocation = null,
                    LeftLocation = null,
                };

                MstTableDetailForm mstTableDetailForm = new MstTableDetailForm(this, mstTableEntity);
                mstTableDetailForm.ShowDialog();
            }

            if (e.RowIndex > -1 && dataGridViewTableList.CurrentCell.ColumnIndex == dataGridViewTableList.Columns["ColumnTableListButtonDelete"].Index)
            {
                DialogResult deleteDialogResult = MessageBox.Show("Delete Table?", "Easy POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (deleteDialogResult == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(dataGridViewTableList.Rows[e.RowIndex].Cells[dataGridViewTableList.Columns["ColumnTableListId"].Index].Value);

                    Controllers.MstTableController trnTableController = new Controllers.MstTableController();
                    String[] deleteTable = trnTableController.DeleteTable(id);
                    if (deleteTable[1].Equals("0") == false)
                    {
                        tablePageNumber = 1;
                        UpdateListDataSource();
                    }
                    else
                    {
                        MessageBox.Show(deleteTable[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonTableListPageListFirst_Click(object sender, EventArgs e)
        {
            tablePageList = new PagedList<Entities.DgvMstTableListEntity>(tableData, 1, tablePageSize);
            tableDataSource.DataSource = tablePageList;

            buttonTableListPageListFirst.Enabled = false;
            buttonTableListPageListPrevious.Enabled = false;
            buttonTableListPageListNext.Enabled = true;
            buttonTableListPageListLast.Enabled = true;

            tablePageNumber = 1;
            textBoxTableListPageNumber.Text = tablePageNumber + " / " + tablePageList.PageCount;
        }

        private void buttonTableListPageListPrevious_Click(object sender, EventArgs e)
        {
            if (tablePageList.HasPreviousPage == true)
            {
                tablePageList = new PagedList<Entities.DgvMstTableListEntity>(tableData, --tablePageNumber, tablePageSize);
                tableDataSource.DataSource = tablePageList;
            }

            buttonTableListPageListNext.Enabled = true;
            buttonTableListPageListLast.Enabled = true;

            if (tablePageNumber == 1)
            {
                buttonTableListPageListFirst.Enabled = false;
                buttonTableListPageListPrevious.Enabled = false;
            }

            textBoxTableListPageNumber.Text = tablePageNumber + " / " + tablePageList.PageCount;
        }

        private void buttonTableListPageListNext_Click(object sender, EventArgs e)
        {
            if (tablePageList.HasNextPage == true)
            {
                tablePageList = new PagedList<Entities.DgvMstTableListEntity>(tableData, ++tablePageNumber, tablePageSize);
                tableDataSource.DataSource = tablePageList;
            }

            buttonTableListPageListFirst.Enabled = true;
            buttonTableListPageListPrevious.Enabled = true;

            if (tablePageNumber == tablePageList.PageCount)
            {
                buttonTableListPageListNext.Enabled = false;
                buttonTableListPageListLast.Enabled = false;
            }

            textBoxTableListPageNumber.Text = tablePageNumber + " / " + tablePageList.PageCount;
        }

        private void buttonTableListPageListLast_Click(object sender, EventArgs e)
        {
            tablePageList = new PagedList<Entities.DgvMstTableListEntity>(tableData, tablePageList.PageCount, tablePageSize);
            tableDataSource.DataSource = tablePageList;

            buttonTableListPageListFirst.Enabled = true;
            buttonTableListPageListPrevious.Enabled = true;
            buttonTableListPageListNext.Enabled = false;
            buttonTableListPageListLast.Enabled = false;

            tablePageNumber = tablePageList.PageCount;
            textBoxTableListPageNumber.Text = tablePageNumber + " / " + tablePageList.PageCount;
        }

        private void buttonAddTable_Click(object sender, EventArgs e)
        {
            Entities.MstTableEntity mstTableEntity = new Entities.MstTableEntity()
            {
                Id = 0,
                TableCode = "",
                TableGroupId = mstTableGroupEntity.Id,
                TableGroup = "",
                TopLocation = null,
                LeftLocation = null,
            };

            MstTableDetailForm mstTableDetailForm = new MstTableDetailForm(this, mstTableEntity);
            mstTableDetailForm.ShowDialog();
        }
    }
}
