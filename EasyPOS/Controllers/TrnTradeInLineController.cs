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
