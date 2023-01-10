using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Controllers
{
    class TrnTradeInLineController
    {
        // ============
        // Data Context
        // ============
        public Data.easyposdbDataContext db = new Data.easyposdbDataContext(Modules.SysConnectionStringModule.GetConnectionString());

        // ====================
        // List Trade - In Line
        // ====================
        public List<Entities.TrnTradeInLineEntity> ListTradeInLine(Int32 tradeInId)
        {
            var tradeInLines = from d in db.TrnTradeInLines
                                 select new Entities.TrnTradeInLineEntity
                                 {
                                     Id = d.Id,
                                     TradeInId = d.TradeInId,
                                     ItemId = d.ItemId,
                                     Size = d.MstItem.Size,
                                     Brand = d.MstItem.Brand,
                                     WarrantyCode = d.MstItem.BarCode,
                                     Quantity = d.Quantity,
                                     Amount = d.Amount,
                                 };

            return tradeInLines.Where(d => d.TradeInId == tradeInId).ToList();
        }
        // ==================
        // Dropdown List Item
        // ==================
        public List<Entities.MstItemEntity> DropdownListItem()
        {
            var items = from d in db.MstItems
                        where d.IsInventory == true
                        && d.IsLocked == true
                        select new Entities.MstItemEntity
                        {
                            Id = d.Id,
                            ItemDescription = d.ItemDescription,
                        };

            return items.OrderBy(d => d.ItemDescription).ToList();
        }
        // ===================
        // Add Trade - In Line
        // ===================
        public String[] AddTradeInLine(Entities.TrnTradeInLineEntity objTradeInLine)
        {
            try
            {
                var currentUserLogin = from d in db.MstUsers where d.Id == Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId) select d;
                if (currentUserLogin.Any() == false)
                {
                    return new String[] { "Current login user not found.", "0" };
                }

                var tradeIn = from d in db.TrnTradeIns
                                where d.Id == objTradeInLine.TradeInId
                                select d;

                if (tradeIn.Any() == false)
                {
                    return new String[] { "Trade - In transaction not found.", "0" };
                }

                var item = from d in db.MstItems
                           where d.Id == objTradeInLine.ItemId
                           && d.IsInventory == true
                           && d.IsLocked == true
                           select d;

                if (item.Any() == false)
                {
                    return new String[] { "Item not found.", "0" };
                }

                Data.TrnTradeInLine newTradeInLine = new Data.TrnTradeInLine
                {
                    TradeInId = objTradeInLine.TradeInId,
                    ItemId = objTradeInLine.ItemId,
                    Quantity = objTradeInLine.Quantity,
                    Amount = objTradeInLine.Amount,
                };

                db.TrnTradeInLines.InsertOnSubmit(newTradeInLine);
                db.SubmitChanges();

                return new String[] { "", "1" };
            }
            catch (Exception e)
            {
                return new String[] { e.Message, "0" };
            }
        }

        // ======================
        // Update Trade - In Line
        // ======================
        public String[] UpdateTradeInLine(Int32 id, Entities.TrnTradeInLineEntity objTradeInLine)
        {
            try
            {
                var currentUserLogin = from d in db.MstUsers where d.Id == Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId) select d;
                if (currentUserLogin.Any() == false)
                {
                    return new String[] { "Current login user not found.", "0" };
                }

                var tradeInLine = from d in db.TrnTradeInLines
                                    where d.Id == id
                                    select d;

                if (tradeInLine.Any())
                {
                    var tradeIn = from d in db.TrnTradeIns
                                    where d.Id == objTradeInLine.TradeInId
                                    select d;

                    if (tradeIn.Any() == false)
                    {
                        return new String[] { "Trade - In transaction not found.", "0" };
                    }

                    var updateTradeInLine = tradeInLine.FirstOrDefault();
                    updateTradeInLine.ItemId = objTradeInLine.ItemId;
                    updateTradeInLine.Quantity = objTradeInLine.Quantity;
                    updateTradeInLine.Amount = objTradeInLine.Amount;
                    db.SubmitChanges();

                    return new String[] { "", "1" };
                }
                else
                {
                    return new String[] { "Trade - In line not found.  " + id, "0" };
                }
            }
            catch (Exception e)
            {
                return new String[] { e.Message, "0" };
            }
        }

        // ======================
        // Delete Trade - In Line
        // ======================
        public String[] DeleteTradeInLine(Int32 id)
        {
            try
            {
                var currentUserLogin = from d in db.MstUsers where d.Id == Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId) select d;
                if (currentUserLogin.Any() == false)
                {
                    return new String[] { "Current login user not found.", "0" };
                }

                var tradeInLine = from d in db.TrnTradeInLines
                                    where d.Id == id
                                    select d;

                if (tradeInLine.Any())
                {
                    var deleteTradeInLine = tradeInLine.FirstOrDefault();
                    db.TrnTradeInLines.DeleteOnSubmit(deleteTradeInLine);

                    db.SubmitChanges();

                    return new String[] { "", "1" };
                }
                else
                {
                    return new String[] { "Trade - In line not found.", "0" };
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
        public List<Entities.TrnTradeInLineEntity> DropdownListTradeInLineAmount(Int32 tradeInId)
        {
            var tradeInLineAmount = from d in db.TrnTradeInLines
                                    where d.TradeInId == tradeInId
                                    group d by new
                                    {
                                        d.TradeInId
                                    }into g
                                    select new Entities.TrnTradeInLineEntity
                                    {
                                        TradeInId = g.Key.TradeInId,
                                        Amount = g.Sum(a => a.Amount)
                                    };

            return tradeInLineAmount.ToList();
        }
    }
}
