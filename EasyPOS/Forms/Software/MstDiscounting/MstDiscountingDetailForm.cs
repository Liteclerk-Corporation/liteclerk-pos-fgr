﻿using EasyPOS.Interfaces.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPOS.Forms.Software.MstDiscounting
{
    public partial class MstDiscountingDetailForm : Form
    {
        IUpdateListDataSource FormWithUpdate;
        public SysSoftwareForm sysSoftwareForm;
        private Modules.SysUserRightsModule sysUserRights;

        public Entities.MstDiscountEntity mstDiscountEntity;

        public List<Entities.SysLanguageEntity> sysLanguageEntities = new List<Entities.SysLanguageEntity>();

        public MstDiscountingDetailForm(SysSoftwareForm softwareForm, IUpdateListDataSource formWithUpdate, Entities.MstDiscountEntity itemEntity)
        {
            InitializeComponent();

            buttonLock.Text = SetLabel(buttonLock.Text);
            buttonUnlock.Text = SetLabel(buttonUnlock.Text);
            buttonClose.Text = SetLabel(buttonClose.Text);
            checkBoxMon.Text = SetLabel(checkBoxMon.Text);
            checkBoxTue.Text = SetLabel(checkBoxTue.Text);
            checkBoxWed.Text = SetLabel(checkBoxWed.Text);
            checkBoxThu.Text = SetLabel(checkBoxThu.Text);
            checkBoxFri.Text = SetLabel(checkBoxFri.Text);
            checkBoxSat.Text = SetLabel(checkBoxSat.Text);
            checkBoxSun.Text = SetLabel(checkBoxSun.Text);
            label1.Text = SetLabel(label1.Text);
            label2.Text = SetLabel(label2.Text);
            label3.Text = SetLabel(label3.Text);
            label4.Text = SetLabel(label4.Text);
            label5.Text = SetLabel(label5.Text);
            label6.Text = SetLabel(label6.Text);
            label7.Text = SetLabel(label7.Text);
            label8.Text = SetLabel(label8.Text);
            label9.Text = SetLabel(label9.Text);
            label10.Text = SetLabel(label10.Text);
            label11.Text = SetLabel(label11.Text);
            buttonStockInLineListPageListFirst.Text = SetLabel(buttonStockInLineListPageListFirst.Text);
            buttonStockInLineListPageListLast.Text = SetLabel(buttonStockInLineListPageListLast.Text);
            buttonStockInLineListPageListNext.Text = SetLabel(buttonStockInLineListPageListNext.Text);
            buttonStockInLineListPageListPrevious.Text = SetLabel(buttonStockInLineListPageListPrevious.Text);

            sysSoftwareForm = softwareForm;

            sysUserRights = new Modules.SysUserRightsModule("MstDiscountDetail");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FormWithUpdate = formWithUpdate;
                mstDiscountEntity = itemEntity;

                GetDiscountDetail();
                textBoxDiscount.Focus();
            }
            var id = mstDiscountEntity.Id;

            Controllers.MstDiscountController mstDiscount = new Controllers.MstDiscountController();
            var detail = mstDiscount.DetailDiscount(id);

            if (detail != null)
            {
                sysSoftwareForm.displayTimeStamp(detail.EntryUserUserName, detail.EntryDateTime + " " + detail.EntryTime, detail.UpdatedUserUserName, detail.UpdateDateTime + " " + detail.UpdateTime);
            }
        }

        public string SetLabel(string label)
        {
            Controllers.SysLanguageController sysLabel = new Controllers.SysLanguageController();
            var language = Modules.SysCurrentModule.GetCurrentSettings().Language;
            sysLanguageEntities = sysLabel.ListLanguage("");
            if (sysLanguageEntities.Any())
            {

                if (sysLabel.ListLanguage("").Any())
                {

                    foreach (var displayedLabel in sysLanguageEntities)
                    {
                        if (language != "English")
                        {
                            if (displayedLabel.Label == label)
                            {
                                return displayedLabel.DisplayedLabel;
                            }

                        }
                        else
                        {
                            if (displayedLabel.Label == label)
                            {
                                return displayedLabel.Label;
                            }
                        }
                    }
                }
            }
            return label;
        }

        public void GetDiscountDetail()
        {
            textBoxDiscount.Text = mstDiscountEntity.Discount;
            textBoxDiscountRate.Text = mstDiscountEntity.DiscountRate.ToString("#,##0.00");
            checkBoxVATExempt.Checked = mstDiscountEntity.IsVatExempt;

            checkBoxDateScheduled.Checked = mstDiscountEntity.IsDateScheduled;
            if (String.IsNullOrEmpty(mstDiscountEntity.DateStart) == true)
            {
                dateTimePickerDateStart.Value = DateTime.Today.Date;
            }
            else
            {
                dateTimePickerDateStart.Value = Convert.ToDateTime(mstDiscountEntity.DateStart);
            }

            if (String.IsNullOrEmpty(mstDiscountEntity.DateEnd) == true)
            {
                dateTimePickerDateEnd.Value = DateTime.Today.Date;
            }
            else
            {
                dateTimePickerDateEnd.Value = Convert.ToDateTime(mstDiscountEntity.DateEnd);
            }

            checkBoxDaySchedule.Checked = mstDiscountEntity.IsDayScheduled;
            checkBoxMon.Checked = mstDiscountEntity.DayMon;
            checkBoxTue.Checked = mstDiscountEntity.DayTue;
            checkBoxWed.Checked = mstDiscountEntity.DayWed;
            checkBoxThu.Checked = mstDiscountEntity.DayThu;
            checkBoxFri.Checked = mstDiscountEntity.DayFri;
            checkBoxSat.Checked = mstDiscountEntity.DaySat;
            checkBoxSun.Checked = mstDiscountEntity.DaySun;

            checkBoxTimeScheduled.Checked = mstDiscountEntity.IsTimeScheduled;
            if (String.IsNullOrEmpty(mstDiscountEntity.TimeStart) == true)
            {
                dateTimePickerTimeStart.Value = DateTime.Now;
            }
            else
            {
                dateTimePickerTimeStart.Value = Convert.ToDateTime(mstDiscountEntity.TimeStart);
            }

            if (String.IsNullOrEmpty(mstDiscountEntity.TimeEnd) == true)
            {
                dateTimePickerTimeEnd.Value = DateTime.Now;
            }
            else
            {
                dateTimePickerTimeEnd.Value = Convert.ToDateTime(mstDiscountEntity.TimeEnd);
            }
            UpdateComponents(mstDiscountEntity.IsLocked);
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

            textBoxDiscount.Enabled = !isLocked;
            textBoxDiscountRate.Enabled = !isLocked;
            checkBoxVATExempt.Enabled = !isLocked;
            textBoxDiscount.Focus();

            checkBoxDateScheduled.Enabled = !isLocked;
            if (mstDiscountEntity.IsDateScheduled == true)
            {
                dateTimePickerDateStart.Enabled = !isLocked;
                dateTimePickerDateEnd.Enabled = !isLocked;
            }
            else
            {
                dateTimePickerDateStart.Enabled = false;
                dateTimePickerDateEnd.Enabled = false;
            }

            checkBoxDaySchedule.Enabled = !isLocked;
            if (mstDiscountEntity.IsDayScheduled == true)
            {
                checkBoxMon.Enabled = !isLocked;
                checkBoxTue.Enabled = !isLocked;
                checkBoxWed.Enabled = !isLocked;
                checkBoxThu.Enabled = !isLocked;
                checkBoxFri.Enabled = !isLocked;
                checkBoxSat.Enabled = !isLocked;
                checkBoxSun.Enabled = !isLocked;
            }
            else
            {
                checkBoxMon.Enabled = false;
                checkBoxTue.Enabled = false;
                checkBoxWed.Enabled = false;
                checkBoxThu.Enabled = false;
                checkBoxFri.Enabled = false;
                checkBoxSat.Enabled = false;
                checkBoxSun.Enabled = false;
            }

            checkBoxTimeScheduled.Enabled = !isLocked;
            if (mstDiscountEntity.IsTimeScheduled == true)
            {
                dateTimePickerTimeStart.Enabled = !isLocked;
                dateTimePickerTimeEnd.Enabled = !isLocked;
            }
            else
            {
                dateTimePickerTimeStart.Enabled = false;
                dateTimePickerTimeEnd.Enabled = false;
            }
        }


        private void buttonLock_Click(object sender, EventArgs e)
        {

            Controllers.MstDiscountController mstDiscountController = new Controllers.MstDiscountController();

            Entities.MstDiscountEntity newDiscountEntity = new Entities.MstDiscountEntity()
            {
                Discount = textBoxDiscount.Text,
                DiscountRate = Convert.ToDecimal(textBoxDiscountRate.Text),
                IsVatExempt = checkBoxVATExempt.Checked,
                IsDateScheduled = checkBoxDateScheduled.Checked,
                DateStart = checkBoxDateScheduled.Checked == true ? Convert.ToDateTime(dateTimePickerDateStart.Value).ToShortDateString() : "",
                DateEnd = checkBoxDateScheduled.Checked == true ? Convert.ToDateTime(dateTimePickerDateEnd.Value).ToShortDateString() : "",
                IsTimeScheduled = checkBoxTimeScheduled.Checked,
                TimeStart = checkBoxTimeScheduled.Checked == true ? Convert.ToDateTime(dateTimePickerTimeStart.Value).ToShortTimeString() : "",
                TimeEnd = checkBoxTimeScheduled.Checked == true ? Convert.ToDateTime(dateTimePickerTimeEnd.Value).ToShortTimeString() : "",
                IsDayScheduled = checkBoxDaySchedule.Checked,
                DayMon = checkBoxDaySchedule.Checked == true ? checkBoxMon.Checked : false,
                DayTue = checkBoxDaySchedule.Checked == true ? checkBoxTue.Checked : false,
                DayWed = checkBoxDaySchedule.Checked == true ? checkBoxWed.Checked : false,
                DayThu = checkBoxDaySchedule.Checked == true ? checkBoxThu.Checked : false,
                DayFri = checkBoxDaySchedule.Checked == true ? checkBoxFri.Checked : false,
                DaySat = checkBoxDaySchedule.Checked == true ? checkBoxSat.Checked : false,
                DaySun = checkBoxDaySchedule.Checked == true ? checkBoxSun.Checked : false
            };

            String[] lockDiscount = mstDiscountController.LockDiscount(mstDiscountEntity.Id, newDiscountEntity);

            if (lockDiscount[1].Equals("0") == false)
            {
                UpdateComponents(true);
                FormWithUpdate.UpdateListDataSource();
            }
            else
            {
                UpdateComponents(false);
                MessageBox.Show(lockDiscount[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUnlock_Click(object sender, EventArgs e)
        {
            Controllers.MstDiscountController mstDiscountController = new Controllers.MstDiscountController();

            String[] unlockDiscount = mstDiscountController.UnlockDiscount(mstDiscountEntity.Id);
            if (unlockDiscount[1].Equals("0") == false)
            {
                UpdateComponents(false);
                FormWithUpdate.UpdateListDataSource();
            }
            else
            {
                UpdateComponents(true);
                MessageBox.Show(unlockDiscount[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (textBoxDiscount.Enabled == false)
            {
                sysSoftwareForm.RemoveTabPage();
            }
            else
            {
                DialogResult closeDialogResult = MessageBox.Show("Save Changes?", "Easy POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (closeDialogResult == DialogResult.Yes)
                {
                    Controllers.MstDiscountController mstDiscountController = new Controllers.MstDiscountController();

                    Entities.MstDiscountEntity newDiscountEntity = new Entities.MstDiscountEntity()
                    {
                        Discount = textBoxDiscount.Text,
                        DiscountRate = Convert.ToDecimal(textBoxDiscountRate.Text),
                        IsVatExempt = checkBoxVATExempt.Checked,
                        IsDateScheduled = checkBoxDateScheduled.Checked,
                        DateStart = checkBoxDateScheduled.Checked == true ? Convert.ToDateTime(dateTimePickerDateStart.Value).ToShortDateString() : "",
                        DateEnd = checkBoxDateScheduled.Checked == true ? Convert.ToDateTime(dateTimePickerDateEnd.Value).ToShortDateString() : "",
                        IsTimeScheduled = checkBoxTimeScheduled.Checked,
                        TimeStart = checkBoxTimeScheduled.Checked == true ? Convert.ToDateTime(dateTimePickerTimeStart.Value).ToShortTimeString() : "",
                        TimeEnd = checkBoxTimeScheduled.Checked == true ? Convert.ToDateTime(dateTimePickerTimeEnd.Value).ToShortTimeString() : "",
                        IsDayScheduled = checkBoxDaySchedule.Checked,
                        DayMon = checkBoxDaySchedule.Checked == true ? checkBoxMon.Checked : false,
                        DayTue = checkBoxDaySchedule.Checked == true ? checkBoxTue.Checked : false,
                        DayWed = checkBoxDaySchedule.Checked == true ? checkBoxWed.Checked : false,
                        DayThu = checkBoxDaySchedule.Checked == true ? checkBoxThu.Checked : false,
                        DayFri = checkBoxDaySchedule.Checked == true ? checkBoxFri.Checked : false,
                        DaySat = checkBoxDaySchedule.Checked == true ? checkBoxSat.Checked : false,
                        DaySun = checkBoxDaySchedule.Checked == true ? checkBoxSun.Checked : false
                    };

                    String[] lockDiscount = mstDiscountController.SaveDiscount(mstDiscountEntity.Id, newDiscountEntity);

                    if (lockDiscount[1].Equals("0") == false)
                    {
                        sysSoftwareForm.RemoveTabPage();
                        FormWithUpdate.UpdateListDataSource();
                    }
                    else
                    {
                        MessageBox.Show(lockDiscount[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    sysSoftwareForm.RemoveTabPage();
                }
            }
        }

        private void textBoxDiscountRate_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxDiscountRate_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxDiscountRate.Text) == true)
            {
                textBoxDiscountRate.Text = Convert.ToDecimal(0).ToString("#,##0.00");
            }
            else
            {
                textBoxDiscountRate.Text = Convert.ToDecimal(textBoxDiscountRate.Text).ToString("#,##0.00");
            }
        }

        private void checkBoxDateScheduled_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDateScheduled.Checked == true)
            {
                dateTimePickerDateStart.Enabled = true;
                dateTimePickerDateEnd.Enabled = true;
            }
            else
            {
                dateTimePickerDateStart.Enabled = false;
                dateTimePickerDateEnd.Enabled = false;
            }
        }

        private void checkBoxDaySchedule_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDaySchedule.Checked == true)
            {
                checkBoxMon.Enabled = true;
                checkBoxTue.Enabled = true;
                checkBoxWed.Enabled = true;
                checkBoxThu.Enabled = true;
                checkBoxFri.Enabled = true;
                checkBoxSat.Enabled = true;
                checkBoxSun.Enabled = true;
                checkBoxMon.Focus();
            }
            else
            {
                checkBoxMon.Enabled = false;
                checkBoxTue.Enabled = false;
                checkBoxWed.Enabled = false;
                checkBoxThu.Enabled = false;
                checkBoxFri.Enabled = false;
                checkBoxSat.Enabled = false;
                checkBoxSun.Enabled = false;

                checkBoxMon.Checked = false;
                checkBoxTue.Checked = false;
                checkBoxWed.Checked = false;
                checkBoxThu.Checked = false;
                checkBoxFri.Checked = false;
                checkBoxSat.Checked = false;
                checkBoxSun.Checked = false;
            }
        }

        private void checkBoxTimeScheduled_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTimeScheduled.Checked == true)
            {
                dateTimePickerTimeStart.Enabled = true;
                dateTimePickerTimeEnd.Enabled = true;
            }
            else
            {
                dateTimePickerTimeStart.Enabled = false;
                dateTimePickerTimeEnd.Enabled = false;
            }
        }

        private void textBoxDiscountAmount_KeyPress(object sender, KeyPressEventArgs e)
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
