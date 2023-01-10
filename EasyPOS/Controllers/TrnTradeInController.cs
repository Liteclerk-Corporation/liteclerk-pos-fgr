using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Controllers
{
    class TrnTradeInController
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
        // =============
        // List Trade In 
        // =============
        public List<Entities.TrnTradeInEntity> ListTradeIn(DateTime dateFilter, String filter)
        {
            var defectives = from d in db.TrnTradeIns
                             where d.TradeInDate == dateFilter
                             && d.TradeInNo.Contains(filter)
                             select new Entities.TrnTradeInEntity
                             {
                                 Id = d.Id,
                                 TradeInNo = d.TradeInNo,
                                 TradeInDate = d.TradeInDate.ToShortDateString(),
                                 Remarks = d.Remarks,
                                 IsLocked = d.IsLocked,
                             };

            return defectives.OrderByDescending(d => d.Id).ToList();
        }
        // =================
        // Detail Trade - In
        // =================
        public Entities.TrnTradeInEntity DetailTradeIn(Int32 id)
        {
            var tradeIn = from d in db.TrnTradeIns
                             where d.Id == id
                             select new Entities.TrnTradeInEntity
                             {
                                 Id = d.Id,
                                 TradeInNo = d.TradeInNo,
                                 TradeInDate = d.TradeInDate.ToShortDateString(),
                                 Remarks = d.Remarks,
                                 PreparedById = d.PreparedById,
                                 IsLocked = d.IsLocked,
                             };

            return tradeIn.FirstOrDefault();
        }
        // ====================
        // Dropdown List - User
        // ====================
        public List<Entities.MstUserEntity> DropdownListTradeInUser()
        {
            var users = from d in db.MstUsers
                        select new Entities.MstUserEntity
                        {
                            Id = d.Id,
                            FullName = d.FullName
                        };

            return users.ToList();
        }

        // ==============
        // Add Trade - In
        // ==============
        public String[] AddTradeIn()
        {
            try
            {
                var currentUserLogin = from d in db.MstUsers where d.Id == Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId) select d;
                if (currentUserLogin.Any() == false)
                {
                    return new String[] { "Current login user not found.", "0" };
                }

                DateTime currentDate = DateTime.Today;
                if (Modules.SysCurrentModule.GetCurrentSettings().IsLoginDate == true)
                {
                    currentDate = Convert.ToDateTime(Modules.SysCurrentModule.GetCurrentSettings().CurrentDate);
                }

                String tradeInNumber = "0000000001";
                var lastTradeIn = from d in db.TrnTradeIns.OrderByDescending(d => d.Id) where d.TradeInNo.Contains("-") == false select d;
                if (lastTradeIn.Any())
                {
                    Int32 newTradeInNumber = Convert.ToInt32(lastTradeIn.FirstOrDefault().TradeInNo) + 1;
                    tradeInNumber = FillLeadingZeroes(newTradeInNumber, 10);
                }

                Data.TrnTradeIn newTradeIn = new Data.TrnTradeIn()
                {
                    TradeInNo = tradeInNumber,
                    TradeInDate = currentDate,
                    Remarks = "NA",
                    PreparedById = currentUserLogin.FirstOrDefault().Id,
                    IsLocked = false,
                };

                db.TrnTradeIns.InsertOnSubmit(newTradeIn);
                db.SubmitChanges();

                return new String[] { "", newTradeIn.Id.ToString() };
            }
            catch (Exception e)
            {
                return new String[] { e.Message, "0" };
            }
        }

        // ===============
        // Lock Trade - In
        // ===============
        public String[] LockTradeIn(Int32 id, Entities.TrnTradeInEntity objTradeIn)
        {
            try
            {
                var currentUserLogin = from d in db.MstUsers where d.Id == Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId) select d;
                if (currentUserLogin.Any() == false)
                {
                    return new String[] { "Current login user not found.", "0" };
                }

                var tradeIn = from d in db.TrnTradeIns
                                where d.Id == id
                                select d;

                if (tradeIn.Any())
                {
                    if (tradeIn.FirstOrDefault().IsLocked)
                    {
                        return new String[] { "Already locked.", "0" };
                    }

                    var lockTradeIn = tradeIn.FirstOrDefault();
                    lockTradeIn.TradeInNo = objTradeIn.TradeInNo;
                    lockTradeIn.TradeInDate = Convert.ToDateTime(objTradeIn.TradeInDate);
                    lockTradeIn.Remarks = objTradeIn.Remarks;
                    lockTradeIn.PreparedById = currentUserLogin.FirstOrDefault().Id;
                    lockTradeIn.IsLocked = true;
                    db.SubmitChanges();

                    Modules.TrnInventoryModule trnInventoryModule = new Modules.TrnInventoryModule();
                    trnInventoryModule.UpdateTradeInInventory(tradeIn.FirstOrDefault().Id);

                    return new String[] { "", "1" };
                }
                else
                {
                    return new String[] { "Defective record not found.", "0" };
                }
            }
            catch (Exception e)
            {
                return new String[] { e.Message, "0" };
            }
        }

        // =================
        // Unlock Trade - In
        // =================
        public String[] UnlockTradeIn(Int32 id)
        {
            try
            {
                var currentUserLogin = from d in db.MstUsers where d.Id == Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId) select d;
                if (currentUserLogin.Any() == false)
                {
                    return new String[] { "Current login user not found.", "0" };
                }

                var tradeIn = from d in db.TrnTradeIns
                                where d.Id == id
                                select d;

                if (tradeIn.Any())
                {
                    if (tradeIn.FirstOrDefault().IsLocked == false)
                    {
                        return new String[] { "Already unlocked.", "0" };
                    }

                    var unlockTradeIn = tradeIn.FirstOrDefault();
                    unlockTradeIn.IsLocked = false;
                    db.SubmitChanges();

                    Modules.TrnInventoryModule trnInventoryModule = new Modules.TrnInventoryModule();
                    trnInventoryModule.UpdateTradeInInventory(tradeIn.FirstOrDefault().Id);

                    return new String[] { "", "1" };
                }
                else
                {
                    return new String[] { "Trade - In record not found.", "0" };
                }
            }
            catch (Exception e)
            {
                return new String[] { e.Message, "0" };
            }
        }

        // ==================
        // Delete Trade - In
        // ==================
        public String[] DeleteTradeIn(Int32 id)
        {
            try
            {
                var currentUserLogin = from d in db.MstUsers where d.Id == Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId) select d;
                if (currentUserLogin.Any() == false)
                {
                    return new String[] { "Current login user not found.", "0" };
                }

                var tradeIn = from d in db.TrnTradeIns
                                where d.Id == id
                                select d;

                if (tradeIn.Any())
                {
                    if (tradeIn.FirstOrDefault().IsLocked)
                    {
                        return new String[] { "Defective record is locked", "0" };
                    }

                    var deleteTradeIn = tradeIn.FirstOrDefault();
                    db.TrnTradeIns.DeleteOnSubmit(deleteTradeIn);

                    db.SubmitChanges();

                    return new String[] { "", "1" };
                }
                else
                {
                    return new String[] { "Trade - In record not found.", "0" };
                }
            }
            catch (Exception e)
            {
                return new String[] { e.Message, "0" };
            }
        }
        // ======================
        // Trade-In Dropdown List
        // ======================
        public List<Entities.TrnTradeInEntity> DropdownListTradeInNo()
        {
            var tradeInNo = from d in db.TrnTradeIns
                            where d.IsLocked == true
                            select new Entities.TrnTradeInEntity
                            {
                                Id = d.Id,
                                TradeInNo = d.TradeInNo,
                            };

            return tradeInNo.ToList();
        }
        // ======================
        // Get Trade - In Amount
        // ======================
        public Decimal GetTradeInAmount(Int32 tradeInId)
        {
            Decimal amount = 0;
            var tradeInLines = from d in db.TrnTradeInLines
                               where d.TrnTradeIn.IsLocked == true
                               && d.TradeInId == tradeInId
                               select d;
            if (tradeInLines.Any())
            {
                amount = tradeInLines.Sum(a => a.Amount);
            }

            return amount;
        }
    }
}
