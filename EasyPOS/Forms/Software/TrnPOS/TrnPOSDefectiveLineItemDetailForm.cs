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
    public partial class TrnPOSDefectiveLineItemDetailForm : Form
    {
        public TrnPOSDefectiveDetailForm trnDefectiveDetailForm;
        public Entities.TrnDefectiveLineEntity trnDefectiveLineEntity;
        public TrnPOSDefectiveLineItemDetailForm(TrnPOSDefectiveDetailForm defectiveDetailForm, Entities.TrnDefectiveLineEntity defectiveLineEntity)
        {
            InitializeComponent();

            trnDefectiveDetailForm = defectiveDetailForm;
            trnDefectiveLineEntity = defectiveLineEntity;

            GetItemList();
        }
        public void GetDefectiveLineItemDetail()
        {
            comboBoxItemDescription.SelectedValue = trnDefectiveLineEntity.ItemId;
            textBoxDefectiveLineQuantity.Text = trnDefectiveLineEntity.Quantity.ToString("#,##0.00");
            textBoxDefectiveLineAmount.Text = trnDefectiveLineEntity.Amount.ToString("#,##0.00");
        }
        public void GetItemList()
        {
            Controllers.TrnDefectiveLineController trnDefectiveLineController = new Controllers.TrnDefectiveLineController();
            if (trnDefectiveLineController.DropdownListItem().Any())
            {
                comboBoxItemDescription.DataSource = trnDefectiveLineController.DropdownListItem();
                comboBoxItemDescription.ValueMember = "Id";
                comboBoxItemDescription.DisplayMember = "ItemDescription";

                GetDefectiveLineItemDetail();
            }
        }
        public void SaveDefectiveLine()
        {
            var id = trnDefectiveLineEntity.Id;
            var defectiveId = trnDefectiveLineEntity.DefectiveId;
            var itemId = comboBoxItemDescription.SelectedValue;
            var quantity = Convert.ToDecimal(textBoxDefectiveLineQuantity.Text);
            var amount = Convert.ToDecimal(textBoxDefectiveLineAmount.Text);

            Entities.TrnDefectiveLineEntity newDefectiveLineEntity = new Entities.TrnDefectiveLineEntity()
            {
                Id = id,
                DefectiveId = defectiveId,
                ItemId = Convert.ToInt32(itemId),
                Quantity = quantity,
                Amount = amount,
                Type = trnDefectiveLineEntity.Type
            };

            Controllers.TrnDefectiveLineController trnPOSDefectiveLineController = new Controllers.TrnDefectiveLineController();
            if (newDefectiveLineEntity.Id == 0)
            {
                String[] addDefectiveLine = trnPOSDefectiveLineController.AddDefectiveLine(newDefectiveLineEntity);
                if (addDefectiveLine[1].Equals("0") == false)
                {
                    trnDefectiveDetailForm.UpdateDefectiveLineListDataSource();
                    Close();
                }
                else
                {
                    MessageBox.Show(addDefectiveLine[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                String[] updateDefectiveLine = trnPOSDefectiveLineController.UpdateDefectiveLine(trnDefectiveLineEntity.Id, newDefectiveLineEntity);
                if (updateDefectiveLine[1].Equals("0") == false)
                {
                    trnDefectiveDetailForm.UpdateDefectiveLineListDataSource();
                    Close();
                }
                else
                {
                    MessageBox.Show(updateDefectiveLine[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveDefectiveLine();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxDefectiveLineQuantity_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxDefectiveLineAmount_KeyPress(object sender, KeyPressEventArgs e)
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
