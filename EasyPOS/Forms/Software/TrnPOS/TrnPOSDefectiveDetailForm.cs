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

        public TrnPOSDefectiveDetailForm(TrnPOSDefectiveListForm defectiveListForm, Entities.TrnDefectiveEntity defectiveEntity)
        {
            InitializeComponent();

            trnDefectiveListForm = defectiveListForm;
            trnDefectiveEntity = defectiveEntity;

            GetVehicleType();

            var id = trnDefectiveEntity.Id;

            Controllers.TrnDefectiveController trnDefective = new Controllers.TrnDefectiveController();
            var detail = trnDefective.DetailDefective(id);
        }
        public void GetVehicleType()
        {
            List<String> vehicleType;
            vehicleType = new List<String>
            {
                "Private",
                "Commercial"
            };
            comboBoxVehicleType.DataSource = vehicleType;

            GetUserList();
        }
        public void GetUserList()
        {
            Controllers.TrnDefectiveController trnDefectiveController = new Controllers.TrnDefectiveController();
            if (trnDefectiveController.DropdownListDefectiveUser().Any())
            {
                comboBoxPreparedBy.DataSource = trnDefectiveController.DropdownListDefectiveUser();
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
            dateTimePickerPurchasedDate.Value = Convert.ToDateTime(trnDefectiveEntity.PurchasedDate);
            dateTimePickerRepDate.Value = Convert.ToDateTime(trnDefectiveEntity.ReplacementDate);
            textBoxInvoiceNo.Text = trnDefectiveEntity.InvoiceNo;
            textBoxRepInvoiceNo.Text = trnDefectiveEntity.ReplacementInvoiceNo;
            comboBoxVehicleType.SelectedText = trnDefectiveEntity.VehicleType;
            textBoxCustomerName.Text = trnDefectiveEntity.CustomerName;
            comboBoxPreparedBy.SelectedValue = trnDefectiveEntity.PreparedById;

            CreateDefectiveLineListDataGridView();
        }
        public void UpdateDefectiveLineListDataSource()
        {
            SetDefectiveLineListDataSourceAsync();
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
                                ColumnDefectiveLineListItemSize = d.Size,
                                ColumnDefectiveLineListItemBrand = d.Brand,
                                ColumnDefectiveLineListItemWarrantyCode = d.WarrantyCode,
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

        public void GetDefectiveLineListCurrentSelectedCell(Int32 rowIndex)
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
                var size = dataGridViewDefectiveLineList.Rows[e.RowIndex].Cells[dataGridViewDefectiveLineList.Columns["ColumnDefectiveLineListItemSize"].Index].Value.ToString();
                var brand = dataGridViewDefectiveLineList.Rows[e.RowIndex].Cells[dataGridViewDefectiveLineList.Columns["ColumnDefectiveLineListItemBrand"].Index].Value.ToString();
                var warrantyCode = dataGridViewDefectiveLineList.Rows[e.RowIndex].Cells[dataGridViewDefectiveLineList.Columns["ColumnDefectiveLineListWarrantyCode"].Index].Value.ToString();
                var quantity = Convert.ToDecimal(dataGridViewDefectiveLineList.Rows[e.RowIndex].Cells[dataGridViewDefectiveLineList.Columns["ColumnDefectiveLineListQuantity"].Index].Value);
                var amount = Convert.ToDecimal(dataGridViewDefectiveLineList.Rows[e.RowIndex].Cells[dataGridViewDefectiveLineList.Columns["ColumnDefectiveLineListAmount"].Index].Value);

                Entities.TrnDefectiveLineEntity trnDefectiveLineEntity = new Entities.TrnDefectiveLineEntity()
                {
                    Id = id,
                    DefectiveId = defectiveId,
                    ItemId = itemId,
                    Size = size,
                    Brand = brand,
                    WarrantyCode = warrantyCode,
                    Quantity = quantity,
                    Amount = amount,
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
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Controllers.TrnDefectiveController trnDefectiveController = new Controllers.TrnDefectiveController();

            Entities.TrnDefectiveEntity newDefectiveEntity = new Entities.TrnDefectiveEntity()
            {
                DefectiveNo = textBoxDefectiveNumber.Text,
                DefectiveDate = dateTimePickerDefectiveDate.Value.Date.ToShortDateString(),
                PurchasedDate = dateTimePickerPurchasedDate.Value.Date.ToShortDateString(),
                ReplacementDate = dateTimePickerRepDate.Value.Date.ToShortDateString(),
                InvoiceNo = textBoxInvoiceNo.Text,
                VehicleType = comboBoxVehicleType.SelectedValue.ToString(),
                CustomerName = textBoxCustomerName.Text,
                ReplacementInvoiceNo = textBoxRepInvoiceNo.Text,
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
            dateTimePickerPurchasedDate.Enabled = !isLocked;
            dateTimePickerRepDate.Enabled = !isLocked;
            textBoxDefectiveNumber.Enabled = !isLocked;
            textBoxInvoiceNo.Enabled = !isLocked;
            textBoxCustomerName.Enabled = !isLocked;
            textBoxRepInvoiceNo.Enabled = !isLocked;
            comboBoxPreparedBy.Enabled = !isLocked;
            comboBoxVehicleType.Enabled = !isLocked;
            buttonAdd.Enabled = !isLocked;

            dataGridViewDefectiveLineList.Columns[0].Visible = !isLocked;
            dataGridViewDefectiveLineList.Columns[1].Visible = !isLocked;
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
                Quantity = 1,
                Amount = 0,
            };

            TrnPOSDefectiveLineItemDetailForm trnPOSDefectiveLineItemDetailForm = new TrnPOSDefectiveLineItemDetailForm(this, trnDefectiveLineEntity);
            trnPOSDefectiveLineItemDetailForm.ShowDialog();
        }

        private void comboBoxVehicleType_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxVehicleType.Text == "Private")
            {
                textBoxWarrantyPeriod.Text = "21";
            }
            else
            {
                textBoxWarrantyPeriod.Text = "6";
            }
        }
    }
}
