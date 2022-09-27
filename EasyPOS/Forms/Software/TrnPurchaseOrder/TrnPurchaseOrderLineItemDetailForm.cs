using EasyPOS.Entities;
using EasyPOS.Interfaces.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPOS.Forms.Software.TrnPurchaseOrder
{
    public partial class TrnPurchaseOrderLineItemDetailForm : Form
    {
        IUpdateListDataSource FormWithUpdate;
        public TrnPurchaseOrderLineEntity trnPurchaseOrderLineEntity;
        public TrnPurchaseOrderLineItemDetailForm(IUpdateListDataSource formWithUpdate, TrnPurchaseOrderLineEntity purchaseOrderLineEntity)
        {
            FormWithUpdate = formWithUpdate;
            trnPurchaseOrderLineEntity = purchaseOrderLineEntity;

            InitializeComponent();

            textBoxPurchaseOrderLineQuantity.Focus();
            textBoxPurchaseOrderLineQuantity.SelectAll();

            GetPurchaseOrderLineItemDetail();
        }
        public void GetPurchaseOrderLineItemDetail()
        {
            textBoxPurchaseOrderLineItemDescription.Text = trnPurchaseOrderLineEntity.ItemDescription;
            textBoxPurchaseOrderLineQuantity.Text = trnPurchaseOrderLineEntity.Quantity.ToString("#,##0.00");
            textBoxPurchaseOrderLineUnit.Text = trnPurchaseOrderLineEntity.Unit;
            textBoxPurchaseOrderLineCost.Text = trnPurchaseOrderLineEntity.Cost.ToString("#,##0.00");
            textBoxPurchaseOrderLineAmount.Text = trnPurchaseOrderLineEntity.Amount.ToString("#,##0.00");
        }
        public void ComputeAmount()
        {
            try
            {
                if (String.IsNullOrEmpty(textBoxPurchaseOrderLineQuantity.Text) == false && String.IsNullOrEmpty(textBoxPurchaseOrderLineCost.Text) == false)
                {
                    Decimal quantity = Convert.ToDecimal(textBoxPurchaseOrderLineQuantity.Text);
                    Decimal cost = Convert.ToDecimal(textBoxPurchaseOrderLineCost.Text);
                    Decimal amount = cost * quantity;

                    textBoxPurchaseOrderLineAmount.Text = amount.ToString("#,##0.00");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SavePurchaseOrderLine();
        }
        public void SavePurchaseOrderLine()
        {
            var id = trnPurchaseOrderLineEntity.Id;
            var PurchaseOrderId = trnPurchaseOrderLineEntity.PurchaseOrderId;
            var itemId = trnPurchaseOrderLineEntity.ItemId;
            var itemDescription = trnPurchaseOrderLineEntity.ItemDescription;
            var unitId = trnPurchaseOrderLineEntity.UnitId;
            var unit = trnPurchaseOrderLineEntity.Unit;
            var quantity = Convert.ToDecimal(textBoxPurchaseOrderLineQuantity.Text);
            var cost = Convert.ToDecimal(textBoxPurchaseOrderLineCost.Text);
            var amount = Convert.ToDecimal(textBoxPurchaseOrderLineAmount.Text);

            TrnPurchaseOrderLineEntity newPurchaseOrderLineEntity = new TrnPurchaseOrderLineEntity()
            {
                Id = id,
                PurchaseOrderId = PurchaseOrderId,
                ItemId = itemId,
                ItemDescription = itemDescription,
                UnitId = unitId,
                Unit = unit,
                Quantity = quantity,
                Cost = cost,
                Amount = amount
            };

            Controllers.TrnPurchaseOrderLineController trnPOSPurchaseOrderLineController = new Controllers.TrnPurchaseOrderLineController();
            if (newPurchaseOrderLineEntity.Id == 0)
            {
                String[] addPurchaseOrderLine = trnPOSPurchaseOrderLineController.AddPurchaseOrderLine(newPurchaseOrderLineEntity);
                if (addPurchaseOrderLine[1].Equals("0") == false)
                {
                    FormWithUpdate.UpdateListDataSource();
                    Close();
                }
                else
                {
                    MessageBox.Show(addPurchaseOrderLine[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                String[] updatePurchaseOrderLine = trnPOSPurchaseOrderLineController.UpdatePurchaseOrderLine(trnPurchaseOrderLineEntity.Id, newPurchaseOrderLineEntity);
                if (updatePurchaseOrderLine[1].Equals("0") == false)
                {
                    FormWithUpdate.UpdateListDataSource();
                    Close();
                }
                else
                {
                    MessageBox.Show(updatePurchaseOrderLine[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxPurchaseOrderLineQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxPurchaseOrderLineQuantity_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxPurchaseOrderLineQuantity.Text))
            {
                textBoxPurchaseOrderLineQuantity.Text = "0.00";
            }

            ComputeAmount();
        }

        private void textBoxPurchaseOrderLineCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxPurchaseOrderLineCost_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxPurchaseOrderLineCost.Text))
            {
                textBoxPurchaseOrderLineCost.Text = "0.00";
            }

            ComputeAmount();
        }

        private void textBoxPurchaseOrderLineAmount_TextChanged(object sender, EventArgs e)
        {
            ComputeAmount();
        }
    }
}
