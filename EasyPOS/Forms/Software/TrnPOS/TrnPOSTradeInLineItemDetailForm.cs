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
    public partial class TrnPOSTradeInLineItemDetailForm : Form
    {
        public TrnPOSTradeInDetailForm trnTradeInDetailForm;
        public Entities.TrnTradeInLineEntity trnTradeInLineEntity;
        public TrnPOSTradeInLineItemDetailForm(TrnPOSTradeInDetailForm tradeInDetailForm, Entities.TrnTradeInLineEntity tradeInLineEntity)
        {
            InitializeComponent();

            trnTradeInDetailForm = tradeInDetailForm;
            trnTradeInLineEntity = tradeInLineEntity;

            GetItemList();
        }
        public void GetTradeInLineItemDetail()
        {
            comboBoxItemDescription.SelectedValue = trnTradeInLineEntity.ItemId;
            textBoxTradeInLineQuantity.Text = trnTradeInLineEntity.Quantity.ToString("#,##0.00");
            textBoxTradeInLineAmount.Text = trnTradeInLineEntity.Amount.ToString("#,##0.00");
        }
        public void GetItemList()
        {
            Controllers.TrnTradeInLineController trnTradeInLineController = new Controllers.TrnTradeInLineController();
            if (trnTradeInLineController.DropdownListItem().Any())
            {
                comboBoxItemDescription.DataSource = trnTradeInLineController.DropdownListItem();
                comboBoxItemDescription.ValueMember = "Id";
                comboBoxItemDescription.DisplayMember = "ItemDescription";

                GetTradeInLineItemDetail();
            }
        }
        public void SaveTradeInLine()
        {
            var id = trnTradeInLineEntity.Id;
            var tradeInId = trnTradeInLineEntity.TradeInId;
            var itemId = comboBoxItemDescription.SelectedValue;
            var quantity = Convert.ToDecimal(textBoxTradeInLineQuantity.Text);
            var amount = Convert.ToDecimal(textBoxTradeInLineAmount.Text);

            Entities.TrnTradeInLineEntity newTradeInLineEntity = new Entities.TrnTradeInLineEntity()
            {
                Id = id,
                TradeInId = tradeInId,
                ItemId = Convert.ToInt32(itemId),
                Quantity = quantity,
                Amount = amount,
            };

            Controllers.TrnTradeInLineController trnPOSTradeInLineController = new Controllers.TrnTradeInLineController();
            if (newTradeInLineEntity.Id == 0)
            {
                String[] addTradeInLine = trnPOSTradeInLineController.AddTradeInLine(newTradeInLineEntity);
                if (addTradeInLine[1].Equals("0") == false)
                {
                    trnTradeInDetailForm.UpdateTradeInLineListDataSource();
                    Close();
                }
                else
                {
                    MessageBox.Show(addTradeInLine[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                String[] updateTradeInLine = trnPOSTradeInLineController.UpdateTradeInLine(trnTradeInLineEntity.Id, newTradeInLineEntity);
                if (updateTradeInLine[1].Equals("0") == false)
                {
                    trnTradeInDetailForm.UpdateTradeInLineListDataSource();
                    Close();
                }
                else
                {
                    MessageBox.Show(updateTradeInLine[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveTradeInLine();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxTradeInLineQuantity_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxTradeInineAmount_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
