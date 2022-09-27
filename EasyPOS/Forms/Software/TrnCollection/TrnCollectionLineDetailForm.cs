using EasyPOS.Entities;
using EasyPOS.Interfaces.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EasyPOS.Forms.Software.TrnCollection
{
    public partial class TrnCollectionLineDetailForm : Form
    {
        IUpdateListDataSource FormWithUpdate;
        public TrnCollectionLineEntity trnCollectionLineEntity;

        public TrnCollectionLineDetailForm(IUpdateListDataSource formWithUpdate, TrnCollectionLineEntity collectionLineEntity)
        {
            InitializeComponent();

            FormWithUpdate = formWithUpdate;
            trnCollectionLineEntity = collectionLineEntity;

            comboBoxPayType.Focus();
            GetPayType();
        }

        public void GetPayType()
        {
            Controllers.TrnCollectionLineController trnCollectionLineController = new Controllers.TrnCollectionLineController();
            if (trnCollectionLineController.DropdownListPayType().Any())
            {
                comboBoxPayType.DataSource = trnCollectionLineController.DropdownListPayType();
                comboBoxPayType.ValueMember = "Id";
                comboBoxPayType.DisplayMember = "PayType";

                GetCollectionLineDetails();
            }
        }

        public void GetCollectionLineDetails()
        {
            DateTime checkDate = DateTime.Today;
            if (String.IsNullOrEmpty(trnCollectionLineEntity.CheckDate) == false)
            {
                checkDate = Convert.ToDateTime(trnCollectionLineEntity.CheckDate);
            }

            comboBoxPayType.SelectedValue = trnCollectionLineEntity.PayTypeId;
            textBoxAmount.Text = trnCollectionLineEntity.Amount.ToString("#,##0.00");
            textBoxCheckNumber.Text = trnCollectionLineEntity.CheckNumber;
            dateTimePickerCheckDate.Value = checkDate;
            textBoxCheckBank.Text = trnCollectionLineEntity.CheckBank;
            textBoxCreditCardNumber.Text = trnCollectionLineEntity.CreditCardNumber;
            textBoxCreditCardHolderName.Text = trnCollectionLineEntity.CreditCardHolderName;
            textBoxCreditCardReferenceNumber.Text = trnCollectionLineEntity.CreditCardReferenceNumber;
            textBoxCreditCardType.Text = trnCollectionLineEntity.CreditCardType;
            textBoxCreditCardBank.Text = trnCollectionLineEntity.CreditCardBank;
            textBoxCreditCardVerificationCode.Text = trnCollectionLineEntity.CreditCardVerificationCode;
            textBoxGiftCertificateNumber.Text = trnCollectionLineEntity.GiftCertificateNumber;
            textBoxOtherInformation.Text = trnCollectionLineEntity.OtherInformation;
            textBoxCreditCardExpiry.Text = trnCollectionLineEntity.CreditCardExpiry;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var id = trnCollectionLineEntity.Id;
            var collectionId = trnCollectionLineEntity.CollectionId;
            var amount = Convert.ToDecimal(textBoxAmount.Text);
            var payTypeId = Convert.ToInt32(comboBoxPayType.SelectedValue);
            var checkNumber = textBoxCheckNumber.Text;
            var checkDate = dateTimePickerCheckDate.Value;
            var checkBank = textBoxCheckBank.Text;
            var verificationCode = textBoxCreditCardVerificationCode.Text;
            var creditCardNumber = textBoxCreditCardNumber.Text;
            var creditCardHolderName = textBoxCreditCardHolderName.Text;
            var creditCardReferenceNumber = textBoxCreditCardReferenceNumber.Text;
            var creditCardType = textBoxCreditCardType.Text;
            var creditCardBank = textBoxCreditCardBank.Text;
            var creditCardExpiry = textBoxCreditCardExpiry.Text;
            var giftCertificateNumber = textBoxGiftCertificateNumber.Text;
            var otherInformation = textBoxOtherInformation.Text;

            TrnCollectionLineEntity newCollectionLineEntity = new Entities.TrnCollectionLineEntity()
            {
                Id = id,
                CollectionId = collectionId,
                Amount = amount,
                PayTypeId = payTypeId,
                CheckNumber = checkNumber,
                CheckDate = checkDate.ToShortDateString(),
                CheckBank = checkBank,
                CreditCardVerificationCode = verificationCode,
                CreditCardNumber = creditCardNumber,
                CreditCardHolderName = creditCardHolderName,
                CreditCardReferenceNumber = creditCardReferenceNumber,
                CreditCardType = creditCardType,
                CreditCardBank = creditCardBank,
                CreditCardExpiry = creditCardExpiry,
                GiftCertificateNumber = giftCertificateNumber,
                OtherInformation = otherInformation
            };

            Controllers.TrnCollectionLineController trnPOSCollectionLineController = new Controllers.TrnCollectionLineController();
            if (newCollectionLineEntity.Id == 0)
            {
                String[] addCollectionLine = trnPOSCollectionLineController.AddCollectionLine(newCollectionLineEntity);
                if (addCollectionLine[1].Equals("0") == false)
                {
                    FormWithUpdate.UpdateListDataSource();
                    Close();
                }
                else
                {
                    MessageBox.Show(addCollectionLine[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                String[] updateCollectionLine = trnPOSCollectionLineController.UpdateCollectionLine(trnCollectionLineEntity.Id, newCollectionLineEntity);
                if (updateCollectionLine[1].Equals("0") == false)
                {
                    FormWithUpdate.UpdateListDataSource();
                    Close();
                }
                else
                {
                    MessageBox.Show(updateCollectionLine[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click_1(object sender, EventArgs e)
        {

        }

        private void textBoxAmount_KeyPress(object sender, KeyPressEventArgs e)
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
