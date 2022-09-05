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

        // ======================
        // Trade-In Dropdown List
        // ======================
        public List<Entities.TrnTradeInEntity> DropdownListTradeInNo()
        {
            var tradeInNo = from d in db.TrnTradeIns
                            where d.IsLocked == true
                            && d.TrnSale.IsTendered == false
                            select new Entities.TrnTradeInEntity
                            {
                                Id = d.Id,
                                TradeInNo = d.TradeInNo
                            };

            return tradeInNo.ToList();
        }
        // ======================
        // Trade-In Dropdown List
        // ======================
        public Int32 SearchTradeInNo(Int32 salesId)
        {
            var tradeIn = from d in db.TrnSales
                          where d.Id == salesId
                          select d;

            return tradeIn.FirstOrDefault().TradeInId;
        }
    }
}
