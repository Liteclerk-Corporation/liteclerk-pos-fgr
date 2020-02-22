﻿using System;
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
    public partial class TrnPOSTouchDetailForm : Form
    {
        public SysSoftwareForm sysSoftwareForm;
        private Modules.SysUserRightsModule sysUserRights;

        public TrnPOSTouchForm trnPOSTouchForm;
        public Entities.TrnSalesEntity trnSalesEntity;

        public TrnPOSTouchDetailForm(SysSoftwareForm softwareForm, TrnPOSTouchForm POSTouchForm, Entities.TrnSalesEntity salesEntity)
        {
            InitializeComponent();

            sysSoftwareForm = softwareForm;
            trnPOSTouchForm = POSTouchForm;
            trnSalesEntity = salesEntity;

            sysUserRights = new Modules.SysUserRightsModule("TrnSalesDetail");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (sysUserRights.GetUserRights().CanLock == false)
                {
                    buttonLock.Enabled = false;
                }
                else
                {
                    if (trnSalesEntity.IsLocked == true)
                    {
                        buttonLock.Enabled = false;
                    }
                    else
                    {
                        buttonLock.Enabled = true;
                    }
                }

                if (sysUserRights.GetUserRights().CanUnlock == false)
                {
                    buttonUnlock.Enabled = false;
                }
                else
                {
                    if (trnSalesEntity.IsLocked == true)
                    {
                        buttonUnlock.Enabled = true;
                    }
                    else
                    {
                        buttonUnlock.Enabled = false;
                    }
                }

                if (sysUserRights.GetUserRights().CanTender == false)
                {
                    buttonTender.Enabled = false;
                }

                if (sysUserRights.GetUserRights().CanTender == false)
                {
                    buttonBarcode.Enabled = false;
                    buttonSearchItem.Enabled = false;
                }
                else
                {
                    if (trnSalesEntity.IsLocked == true)
                    {
                        buttonBarcode.Enabled = false;
                        buttonSearchItem.Enabled = false;
                    }
                    else
                    {
                        buttonBarcode.Enabled = true;
                        buttonSearchItem.Enabled = true;
                    }
                }

                if (sysUserRights.GetUserRights().CanEdit == false)
                {
                    dataGridViewSalesLineList.Columns[0].Visible = false;
                }
                else
                {
                    if (trnSalesEntity.IsLocked == true)
                    {
                        dataGridViewSalesLineList.Columns[0].Visible = false;
                    }
                    else
                    {
                        dataGridViewSalesLineList.Columns[0].Visible = true;
                    }
                }

                if (sysUserRights.GetUserRights().CanDelete == false)
                {
                    dataGridViewSalesLineList.Columns[1].Visible = false;
                }
                else
                {
                    if (trnSalesEntity.IsLocked == true)
                    {
                        dataGridViewSalesLineList.Columns[1].Visible = false;
                    }
                    else
                    {
                        dataGridViewSalesLineList.Columns[1].Visible = true;
                    }
                }

                GetSalesDetail();
                GetSalesLineList();
            }
        }

        public void GetSalesDetail()
        {
            textBoxTotalSalesAmount.Text = trnSalesEntity.Amount.ToString("#,##0.00");
            labelInvoiceNumber.Text = trnSalesEntity.SalesNumber;
            labelInvoiceDate.Text = trnSalesEntity.SalesDate;
            labelCustomer.Text = trnSalesEntity.Customer;
        }

        private void buttonSearchItem_Click(object sender, EventArgs e)
        {
            TrnSalesDetailSearchItemForm trnSalesDetailSearchItemForm = new TrnSalesDetailSearchItemForm(null, this, trnSalesEntity);
            trnSalesDetailSearchItemForm.ShowDialog();
        }

        private void buttonBarcode_Click(object sender, EventArgs e)
        {
            textBoxBarcode.Focus();
            textBoxBarcode.SelectAll();
        }

        private void buttonTender_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(textBoxTotalSalesAmount.Text) > 0)
            {
                Entities.TrnSalesEntity newSalesEntity = new Entities.TrnSalesEntity
                {
                    Id = trnSalesEntity.Id,
                    Amount = Convert.ToDecimal(textBoxTotalSalesAmount.Text),
                    SalesNumber = trnSalesEntity.SalesNumber,
                    SalesDate = trnSalesEntity.SalesDate,
                    CustomerId = trnSalesEntity.CustomerId,
                    Customer = trnSalesEntity.Customer
                };

                TrnSalesDetailTenderForm trnSalesDetailTenderForm = new TrnSalesDetailTenderForm(sysSoftwareForm, null, null, this, newSalesEntity);
                trnSalesDetailTenderForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Cannot tender zero amount.", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDiscount_Click(object sender, EventArgs e)
        {
            TrnSalesDetailDiscountForm trnSalesDetailDiscountForm = new TrnSalesDetailDiscountForm(null, this);
            trnSalesDetailDiscountForm.ShowDialog();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
            sysSoftwareForm.RemoveTabPage();
        }

        private void textBoxBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Controllers.TrnSalesLineController trnPOSSalesLineController = new Controllers.TrnSalesLineController();

                if (Modules.SysCurrentModule.GetCurrentSettings().IsBarcodeQuantityAlwaysOne == "True")
                {
                    trnPOSSalesLineController.BarcodeSalesLine(trnSalesEntity.Id, textBoxBarcode.Text);
                    GetSalesLineList();
                }
                else
                {
                    Entities.MstItemEntity detailItem = trnPOSSalesLineController.DetailItem(textBoxBarcode.Text);
                    if (detailItem != null)
                    {
                        Int32 ItemId = detailItem.Id;
                        Int32 SalesId = trnSalesEntity.Id;
                        String ItemDescription = detailItem.ItemDescription;
                        Int32 TaxId = detailItem.OutTaxId;
                        String Tax = detailItem.OutTax;
                        Decimal TaxRate = detailItem.OutTaxRate;
                        Int32 UnitId = detailItem.UnitId;
                        String Unit = detailItem.Unit;
                        Decimal Price = detailItem.Price;
                        Int32 DiscountId = Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().DefaultDiscountId);
                        Int32 UserId = Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId);

                        Entities.TrnSalesLineEntity trnSalesLineEntity = new Entities.TrnSalesLineEntity()
                        {
                            Id = 0,
                            SalesId = SalesId,
                            ItemId = ItemId,
                            ItemDescription = ItemDescription,
                            UnitId = UnitId,
                            Unit = Unit,
                            Price = Price,
                            DiscountId = DiscountId,
                            Discount = "",
                            DiscountRate = 0,
                            DiscountAmount = 0,
                            NetPrice = Price,
                            Quantity = 1,
                            Amount = Price,
                            TaxId = TaxId,
                            Tax = Tax,
                            TaxRate = TaxRate,
                            TaxAmount = 0,
                            SalesAccountId = 159,
                            AssetAccountId = 255,
                            CostAccountId = 238,
                            TaxAccountId = 87,
                            SalesLineTimeStamp = DateTime.Now.Date.ToShortDateString(),
                            UserId = UserId,
                            Preparation = "NA",
                            Price1 = 0,
                            Price2 = 0,
                            Price2LessTax = 0,
                            PriceSplitPercentage = 0
                        };

                        TrnSalesDetailSalesItemDetailForm trnSalesDetailSalesItemDetailForm = new TrnSalesDetailSalesItemDetailForm(null, this, trnSalesLineEntity);
                        trnSalesDetailSalesItemDetailForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Item not found.", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                textBoxBarcode.SelectAll();
            }
        }

        public void GetSalesLineList()
        {
            Decimal totalSalesAmount = 0;

            dataGridViewSalesLineList.Rows.Clear();
            dataGridViewSalesLineList.Refresh();

            Controllers.TrnSalesLineController trnPOSSalesLineController = new Controllers.TrnSalesLineController();

            var salesLineList = trnPOSSalesLineController.ListSalesLine(trnSalesEntity.Id);
            if (salesLineList.Any())
            {
                dataGridViewSalesLineList.Columns[0].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#01A6F0");
                dataGridViewSalesLineList.Columns[0].DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#01A6F0");
                dataGridViewSalesLineList.Columns[0].DefaultCellStyle.ForeColor = Color.White;

                dataGridViewSalesLineList.Columns[1].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F34F1C");
                dataGridViewSalesLineList.Columns[1].DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#F34F1C");
                dataGridViewSalesLineList.Columns[1].DefaultCellStyle.ForeColor = Color.White;

                foreach (var objSalesLineList in salesLineList)
                {
                    totalSalesAmount += objSalesLineList.Amount;

                    dataGridViewSalesLineList.Rows.Add(
                        "Edit",
                        "Delete",
                        objSalesLineList.Id,
                        objSalesLineList.SalesId,
                        objSalesLineList.ItemId,
                        objSalesLineList.ItemDescription,
                        objSalesLineList.UnitId,
                        objSalesLineList.Unit,
                        objSalesLineList.Price.ToString("#,##0.00"),
                        objSalesLineList.DiscountId,
                        objSalesLineList.Discount,
                        objSalesLineList.DiscountRate.ToString("#,##0.00"),
                        objSalesLineList.DiscountAmount.ToString("#,##0.00"),
                        objSalesLineList.NetPrice.ToString("#,##0.00"),
                        objSalesLineList.Quantity.ToString("#,##0.00"),
                        objSalesLineList.Amount.ToString("#,##0.00"),
                        objSalesLineList.TaxId,
                        objSalesLineList.Tax,
                        objSalesLineList.TaxRate.ToString("#,##0.00"),
                        objSalesLineList.TaxAmount.ToString("#,##0.00"),
                        objSalesLineList.SalesAccountId,
                        objSalesLineList.AssetAccountId,
                        objSalesLineList.CostAccountId,
                        objSalesLineList.TaxAccountId,
                        objSalesLineList.SalesLineTimeStamp,
                        objSalesLineList.UserId,
                        objSalesLineList.Preparation,
                        objSalesLineList.Price1.ToString("#,##0.00"),
                        objSalesLineList.Price2.ToString("#,##0.00"),
                        objSalesLineList.Price2LessTax.ToString("#,##0.00"),
                        objSalesLineList.PriceSplitPercentage.ToString("#,##0.00")
                    );
                }
            }

            textBoxTotalSalesAmount.Text = totalSalesAmount.ToString("#,##0.00");

            String line1 = Modules.SysCurrentModule.GetCurrentSettings().CustomerDisplayFirstLineMessage;
            String line2 = "P " + textBoxTotalSalesAmount.Text;

            if (totalSalesAmount > 0)
            {
                line1 = "TOTAL:";
            }

            Modules.SysSerialPortModule.WriteSeralPortMessage(line1, line2);
        }

        private void dataGridViewSalesLineList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && dataGridViewSalesLineList.CurrentCell.ColumnIndex == dataGridViewSalesLineList.Columns["ColumnSalesLineEdit"].Index)
            {
                Int32 Id = Convert.ToInt32(dataGridViewSalesLineList.Rows[e.RowIndex].Cells[2].Value);
                Int32 SalesId = Convert.ToInt32(dataGridViewSalesLineList.Rows[e.RowIndex].Cells[3].Value);
                Int32 ItemId = Convert.ToInt32(dataGridViewSalesLineList.Rows[e.RowIndex].Cells[4].Value);
                String ItemDescription = dataGridViewSalesLineList.Rows[e.RowIndex].Cells[5].Value.ToString();
                Int32 UnitId = Convert.ToInt32(dataGridViewSalesLineList.Rows[e.RowIndex].Cells[6].Value);
                String Unit = dataGridViewSalesLineList.Rows[e.RowIndex].Cells[7].Value.ToString();
                Decimal Price = Convert.ToDecimal(dataGridViewSalesLineList.Rows[e.RowIndex].Cells[8].Value);
                Int32 DiscountId = Convert.ToInt32(dataGridViewSalesLineList.Rows[e.RowIndex].Cells[9].Value);
                String Discount = dataGridViewSalesLineList.Rows[e.RowIndex].Cells[10].Value.ToString(); ;
                Decimal DiscountRate = Convert.ToDecimal(dataGridViewSalesLineList.Rows[e.RowIndex].Cells[11].Value);
                Decimal DiscountAmount = Convert.ToDecimal(dataGridViewSalesLineList.Rows[e.RowIndex].Cells[12].Value);
                Decimal NetPrice = Convert.ToDecimal(dataGridViewSalesLineList.Rows[e.RowIndex].Cells[13].Value);
                Decimal Quantity = Convert.ToDecimal(dataGridViewSalesLineList.Rows[e.RowIndex].Cells[14].Value);
                Decimal Amount = Convert.ToDecimal(dataGridViewSalesLineList.Rows[e.RowIndex].Cells[15].Value);
                Int32 TaxId = Convert.ToInt32(dataGridViewSalesLineList.Rows[e.RowIndex].Cells[16].Value);
                String Tax = dataGridViewSalesLineList.Rows[e.RowIndex].Cells[17].Value.ToString();
                Decimal TaxRate = Convert.ToDecimal(dataGridViewSalesLineList.Rows[e.RowIndex].Cells[18].Value);
                Decimal TaxAmount = Convert.ToDecimal(dataGridViewSalesLineList.Rows[e.RowIndex].Cells[19].Value);
                Int32 SalesAccountId = Convert.ToInt32(dataGridViewSalesLineList.Rows[e.RowIndex].Cells[20].Value);
                Int32 AssetAccountId = Convert.ToInt32(dataGridViewSalesLineList.Rows[e.RowIndex].Cells[21].Value);
                Int32 CostAccountId = Convert.ToInt32(dataGridViewSalesLineList.Rows[e.RowIndex].Cells[22].Value);
                Int32 TaxAccountId = Convert.ToInt32(dataGridViewSalesLineList.Rows[e.RowIndex].Cells[23].Value);
                String SalesLineTimeStamp = dataGridViewSalesLineList.Rows[e.RowIndex].Cells[24].Value.ToString();
                Int32 UserId = Convert.ToInt32(dataGridViewSalesLineList.Rows[e.RowIndex].Cells[25].Value);
                String Preparation = dataGridViewSalesLineList.Rows[e.RowIndex].Cells[26].Value.ToString();
                Decimal Price1 = Convert.ToDecimal(dataGridViewSalesLineList.Rows[e.RowIndex].Cells[27].Value);
                Decimal Price2 = Convert.ToDecimal(dataGridViewSalesLineList.Rows[e.RowIndex].Cells[28].Value);
                Decimal Price2LessTax = Convert.ToDecimal(dataGridViewSalesLineList.Rows[e.RowIndex].Cells[29].Value);
                Decimal PriceSplitPercentage = Convert.ToDecimal(dataGridViewSalesLineList.Rows[e.RowIndex].Cells[30].Value);

                Entities.TrnSalesLineEntity trnSalesLineEntity = new Entities.TrnSalesLineEntity()
                {
                    Id = Id,
                    SalesId = SalesId,
                    ItemId = ItemId,
                    ItemDescription = ItemDescription,
                    UnitId = UnitId,
                    Unit = Unit,
                    Price = Price,
                    DiscountId = DiscountId,
                    Discount = Discount,
                    DiscountRate = DiscountRate,
                    DiscountAmount = DiscountAmount,
                    NetPrice = NetPrice,
                    Quantity = Quantity,
                    Amount = Amount,
                    TaxId = TaxId,
                    Tax = Tax,
                    TaxRate = TaxRate,
                    TaxAmount = TaxAmount,
                    SalesAccountId = SalesAccountId,
                    AssetAccountId = AssetAccountId,
                    CostAccountId = CostAccountId,
                    TaxAccountId = TaxAccountId,
                    SalesLineTimeStamp = SalesLineTimeStamp,
                    UserId = UserId,
                    Preparation = Preparation,
                    Price1 = Price1,
                    Price2 = Price2,
                    Price2LessTax = Price2LessTax,
                    PriceSplitPercentage = PriceSplitPercentage,
                };

                TrnSalesDetailSalesItemDetailForm trnSalesDetailSalesItemDetailForm = new TrnSalesDetailSalesItemDetailForm(null, this, trnSalesLineEntity);
                trnSalesDetailSalesItemDetailForm.ShowDialog();
            }

            if (e.RowIndex > -1 && dataGridViewSalesLineList.CurrentCell.ColumnIndex == dataGridViewSalesLineList.Columns["ColumnSalesLineDelete"].Index)
            {
                DialogResult deleteDialogResult = MessageBox.Show("Delete Sales?", "Easy POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (deleteDialogResult == DialogResult.Yes)
                {
                    Controllers.TrnSalesLineController trnPOSSalesLineController = new Controllers.TrnSalesLineController();

                    String[] deleteSalesLine = trnPOSSalesLineController.DeleteSalesLine(Convert.ToInt32(dataGridViewSalesLineList.Rows[e.RowIndex].Cells[2].Value));
                    if (deleteSalesLine[1].Equals("0") == false)
                    {
                        GetSalesLineList();
                    }
                    else
                    {
                        MessageBox.Show(deleteSalesLine[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonLock_Click(object sender, EventArgs e)
        {
            Controllers.TrnSalesController trnPOSSalesController = new Controllers.TrnSalesController();
            String[] lockSales = trnPOSSalesController.LockSales(trnSalesEntity.Id);
            if (lockSales[1].Equals("0") == false)
            {
                buttonLock.Enabled = false;
                buttonUnlock.Enabled = true;
                buttonDiscount.Enabled = false;

                buttonBarcode.Enabled = false;
                buttonSearchItem.Enabled = false;
                textBoxBarcode.Enabled = false;

                dataGridViewSalesLineList.Columns[0].Visible = false;
                dataGridViewSalesLineList.Columns[1].Visible = false;
            }
            else
            {
                MessageBox.Show(lockSales[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUnlock_Click(object sender, EventArgs e)
        {
            Controllers.TrnSalesController trnPOSSalesController = new Controllers.TrnSalesController();
            String[] lockSales = trnPOSSalesController.UnlockSales(trnSalesEntity.Id);
            if (lockSales[1].Equals("0") == false)
            {
                buttonLock.Enabled = true;
                buttonUnlock.Enabled = false;
                buttonDiscount.Enabled = true;

                buttonBarcode.Enabled = true;
                buttonSearchItem.Enabled = true;
                textBoxBarcode.Enabled = true;

                dataGridViewSalesLineList.Columns[0].Visible = true;
                dataGridViewSalesLineList.Columns[1].Visible = true;
            }
            else
            {
                MessageBox.Show(lockSales[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
