﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Controllers
{
    class TrnDisbursementController
    {
        // ============
        // Data Context
        // ============
        public Data.easyposdbDataContext db = new Data.easyposdbDataContext(Modules.SysConnectionStringModule.GetConnectionString());

        // ===================
        // Fill Leading Zeroes
        // ===================
        public String FillLeadingZeroes(Int32 number, Int32 length)
        {
            var result = number.ToString();
            var pad = length - result.Length;
            while (pad > 0)
            {
                result = '0' + result;
                pad--;
            }

            return result;
        }

        // =================
        // Disbursement List
        // =================
        public List<Entities.TrnDisbursementEntity> ListDisbursement(DateTime dateFilter, String filter)
        {
            var disbursements = from d in db.TrnDisbursements
                                where d.DisbursementDate == dateFilter
                                && d.DisbursementNumber.Contains(filter)
                                select new Entities.TrnDisbursementEntity
                                {
                                    Id = d.Id,
                                    PeriodId = d.PeriodId,
                                    DisbursementDate = d.DisbursementDate.ToShortDateString(),
                                    DisbursementNumber = d.DisbursementNumber,
                                    DisbursementType = d.DisbursementType,
                                    AccountId = d.AccountId,
                                    Account = d.MstAccount.Account,
                                    Amount = d.Amount,
                                    PayTypeId = d.PayTypeId,
                                    PayType = d.MstPayType.PayType,
                                    TerminalId = d.TerminalId,
                                    Terminal = d.MstTerminal.Terminal,
                                    Remarks = d.Remarks,
                                    IsReturn = d.IsReturn,
                                    StockInId = d.StockInId,
                                    PreparedBy = d.PreparedBy,
                                    CheckedBy = d.CheckedBy,
                                    ApprovedBy = d.ApprovedBy,
                                    IsLocked = d.IsLocked,
                                    EntryUserId = d.EntryUserId,
                                    EntryDateTime = d.EntryDateTime.ToShortDateString(),
                                    UpdateUserId = d.UpdateUserId,
                                    UpdateDateTime = d.UpdateDateTime.ToShortDateString(),
                                    Amount1000 = d.Amount1000,
                                    Amount500 = d.Amount500,
                                    Amount200 = d.Amount200,
                                    Amount100 = d.Amount100,
                                    Amount50 = d.Amount50,
                                    Amount20 = d.Amount20,
                                    Amount10 = d.Amount10,
                                    Amount5 = d.Amount5,
                                    Amount1 = d.Amount1,
                                    Amount025 = d.Amount025,
                                    Amount010 = d.Amount010,
                                    Amount005 = d.Amount005,
                                    Amount001 = d.Amount001,
                                    Payee = d.Payee
                                };

            return disbursements.OrderByDescending(d => d.Id).ToList();
        }

        // ===================
        // Disbursement Detail
        // ===================
        public Entities.TrnDisbursementEntity DetailDisbursement(Int32 id)
        {
            var disbursement = from d in db.TrnDisbursements
                               where d.Id == id
                               select new Entities.TrnDisbursementEntity
                               {
                                   Id = d.Id,
                                   PeriodId = d.PeriodId,
                                   DisbursementDate = d.DisbursementDate.ToShortDateString(),
                                   DisbursementNumber = d.DisbursementNumber,
                                   DisbursementType = d.DisbursementType,
                                   AccountId = d.AccountId,
                                   Account = d.MstAccount.Account,
                                   Amount = d.Amount,
                                   PayTypeId = d.PayTypeId,
                                   PayType = d.MstPayType.PayType,
                                   TerminalId = d.TerminalId,
                                   Terminal = d.MstTerminal.Terminal,
                                   Remarks = d.Remarks,
                                   IsReturn = d.IsReturn,
                                   StockInId = d.StockInId,
                                   PreparedBy = d.PreparedBy,
                                   CheckedBy = d.CheckedBy,
                                   ApprovedBy = d.ApprovedBy,
                                   IsLocked = d.IsLocked,
                                   EntryUserId = d.EntryUserId,
                                   EntryDateTime = d.EntryDateTime.ToShortDateString(),
                                   UpdateUserId = d.UpdateUserId,
                                   UpdateDateTime = d.UpdateDateTime.ToShortDateString(),
                                   Amount1000 = d.Amount1000,
                                   Amount500 = d.Amount500,
                                   Amount200 = d.Amount200,
                                   Amount100 = d.Amount100,
                                   Amount50 = d.Amount50,
                                   Amount20 = d.Amount20,
                                   Amount10 = d.Amount10,
                                   Amount5 = d.Amount5,
                                   Amount1 = d.Amount1,
                                   Amount025 = d.Amount025,
                                   Amount010 = d.Amount010,
                                   Amount005 = d.Amount005,
                                   Amount001 = d.Amount001,
                                   Payee = d.Payee
                               };

            return disbursement.FirstOrDefault();
        }

        // ================
        // Add Disbursement
        // ================
        public String[] AddDisbursement()
        {
            try
            {
                var currentUserLogin = from d in db.MstUsers where d.Id == Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId) select d;
                if (currentUserLogin.Any() == false)
                {
                    return new String[] { "Current login user not found.", "0" };
                }

                var period = from d in db.MstPeriods select d;
                if (period.Any() == false)
                {
                    return new String[] { "Periods not found.", "0" };
                }

                var account = from d in db.MstAccounts select d;
                if (account.Any() == false)
                {
                    return new String[] { "Account not found.", "0" };
                }

                var payType = from d in db.MstPayTypes select d;
                if (payType.Any() == false)
                {
                    return new String[] { "Paytype not found.", "0" };
                }

                var terminal = from d in db.MstTerminals where d.Id == Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().TerminalId) select d;
                if (terminal.Any() == false)
                {
                    return new String[] { "Terminal not found.", "0" };
                }

                String disbursementNumber = "0000000001";
                var lastDisbursement = from d in db.TrnDisbursements.OrderByDescending(d => d.Id) select d;
                if (lastDisbursement.Any())
                {
                    Int32 newDisbursementNumber = Convert.ToInt32(lastDisbursement.FirstOrDefault().DisbursementNumber) + 1;
                    disbursementNumber = FillLeadingZeroes(newDisbursementNumber, 10);
                }

                Data.TrnDisbursement newDisbursement = new Data.TrnDisbursement()
                {
                    PeriodId = period.FirstOrDefault().Id,
                    DisbursementDate = DateTime.Today,
                    DisbursementNumber = disbursementNumber,
                    DisbursementType = "",
                    AccountId = account.FirstOrDefault().Id,
                    Amount = 0,
                    PayTypeId = payType.FirstOrDefault().Id,
                    TerminalId = terminal.FirstOrDefault().Id,
                    Remarks = "",
                    IsReturn = false,
                    StockInId = null,
                    PreparedBy = currentUserLogin.FirstOrDefault().Id,
                    CheckedBy = currentUserLogin.FirstOrDefault().Id,
                    ApprovedBy = currentUserLogin.FirstOrDefault().Id,
                    IsLocked = false,
                    EntryUserId = currentUserLogin.FirstOrDefault().Id,
                    EntryDateTime = DateTime.Now,
                    UpdateUserId = currentUserLogin.FirstOrDefault().Id,
                    UpdateDateTime = DateTime.Now,
                    Amount1000 = null,
                    Amount500 = null,
                    Amount200 = null,
                    Amount100 = null,
                    Amount50 = null,
                    Amount20 = null,
                    Amount10 = null,
                    Amount5 = null,
                    Amount1 = null,
                    Amount025 = null,
                    Amount010 = null,
                    Amount005 = null,
                    Amount001 = null,
                    Payee = ""
                };

                db.TrnDisbursements.InsertOnSubmit(newDisbursement);
                db.SubmitChanges();

                return new String[] { "", newDisbursement.Id.ToString() };
            }
            catch (Exception e)
            {
                return new String[] { e.Message, "0" };
            }
        }

        // =================
        // Lock Disbursement
        // =================
        public String[] LockDisbursement(Int32 id, Entities.TrnDisbursementEntity objDisbursement)
        {
            try
            {
                var currentUserLogin = from d in db.MstUsers where d.Id == Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId) select d;
                if (currentUserLogin.Any() == false)
                {
                    return new String[] { "Current login user not found.", "0" };
                }

                var payType = from d in db.MstPayTypes where d.Id == objDisbursement.PayTypeId select d;
                if (payType.Any() == false)
                {
                    return new String[] { "Paytype not found.", "0" };
                }

                Int32? stockInId = null;

                if (objDisbursement.StockInId != null)
                {
                    var stockIn = from d in db.TrnStockIns
                                  where d.Id == objDisbursement.StockInId
                                  select d;

                    if (stockIn.Any())
                    {
                        stockInId = stockIn.FirstOrDefault().Id;
                    }
                }

                var users = from d in db.MstUsers
                            where d.Id == objDisbursement.CheckedBy
                            && d.Id == objDisbursement.ApprovedBy
                            && d.IsLocked == true
                            select d;

                if (users.Any() == false)
                {
                    return new String[] { "Some users are not found.", "0" };
                }

                var disbursement = from d in db.TrnDisbursements
                                   where d.Id == id
                                   select d;

                if (disbursement.Any())
                {
                    if (disbursement.FirstOrDefault().IsLocked)
                    {
                        return new String[] { "Already locked.", "0" };
                    }

                    var lockDisbursement = disbursement.FirstOrDefault();
                    lockDisbursement.DisbursementType = objDisbursement.DisbursementType;
                    lockDisbursement.PayTypeId = payType.FirstOrDefault().Id;
                    lockDisbursement.Remarks = objDisbursement.Remarks;
                    lockDisbursement.IsReturn = objDisbursement.IsReturn;
                    lockDisbursement.StockInId = stockInId;
                    lockDisbursement.CheckedBy = objDisbursement.CheckedBy;
                    lockDisbursement.ApprovedBy = objDisbursement.ApprovedBy;
                    lockDisbursement.IsLocked = true;
                    lockDisbursement.UpdateUserId = currentUserLogin.FirstOrDefault().Id;
                    lockDisbursement.UpdateDateTime = DateTime.Now;
                    lockDisbursement.Amount1000 = objDisbursement.Amount1000;
                    lockDisbursement.Amount500 = objDisbursement.Amount500;
                    lockDisbursement.Amount200 = objDisbursement.Amount200;
                    lockDisbursement.Amount100 = objDisbursement.Amount100;
                    lockDisbursement.Amount50 = objDisbursement.Amount50;
                    lockDisbursement.Amount20 = objDisbursement.Amount20;
                    lockDisbursement.Amount10 = objDisbursement.Amount10;
                    lockDisbursement.Amount5 = objDisbursement.Amount5;
                    lockDisbursement.Amount1 = objDisbursement.Amount1;
                    lockDisbursement.Amount025 = objDisbursement.Amount025;
                    lockDisbursement.Amount010 = objDisbursement.Amount010;
                    lockDisbursement.Amount005 = objDisbursement.Amount005;
                    lockDisbursement.Amount001 = objDisbursement.Amount001;
                    lockDisbursement.Payee = objDisbursement.Payee;
                    db.SubmitChanges();

                    return new String[] { "", "1" };
                }
                else
                {
                    return new String[] { "Disbursement not found.", "0" };
                }
            }
            catch (Exception e)
            {
                return new String[] { e.Message, "0" };
            }
        }

        // ===================
        // Unlock Disbursement
        // ===================
        public String[] UnlockDisbursement(Int32 id)
        {
            try
            {
                var currentUserLogin = from d in db.MstUsers where d.Id == Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId) select d;
                if (currentUserLogin.Any() == false)
                {
                    return new String[] { "Current login user not found.", "0" };
                }

                var disbursement = from d in db.TrnDisbursements
                                   where d.Id == id
                                   select d;

                if (disbursement.Any())
                {
                    if (disbursement.FirstOrDefault().IsLocked == false)
                    {
                        return new String[] { "Already unlocked.", "0" };
                    }

                    var unlockDisbursement = disbursement.FirstOrDefault();
                    unlockDisbursement.IsLocked = false;
                    unlockDisbursement.UpdateUserId = currentUserLogin.FirstOrDefault().Id;
                    unlockDisbursement.UpdateDateTime = DateTime.Now;
                    db.SubmitChanges();

                    return new String[] { "", "1" };
                }
                else
                {
                    return new String[] { "Disbursement not found.", "0" };
                }
            }
            catch (Exception e)
            {
                return new String[] { e.Message, "0" };
            }
        }

        // ===================
        // Delete Disbursement
        // ===================
        public String[] DeleteDisbursement(Int32 id)
        {
            try
            {
                var currentUserLogin = from d in db.MstUsers where d.Id == Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId) select d;
                if (currentUserLogin.Any() == false)
                {
                    return new String[] { "Current login user not found.", "0" };
                }

                var disbursement = from d in db.TrnDisbursements
                                   where d.Id == id
                                   select d;

                if (disbursement.Any())
                {
                    if (disbursement.FirstOrDefault().IsLocked)
                    {
                        return new String[] { "Disbursement is locked", "0" };
                    }

                    var deleteDisbursement = disbursement.FirstOrDefault();
                    db.TrnDisbursements.DeleteOnSubmit(deleteDisbursement);
                    db.SubmitChanges();

                    return new String[] { "", "1" };
                }
                else
                {
                    return new String[] { "Disbursement not found.", "0" };
                }
            }
            catch (Exception e)
            {
                return new String[] { e.Message, "0" };
            }
        }
    }
}
