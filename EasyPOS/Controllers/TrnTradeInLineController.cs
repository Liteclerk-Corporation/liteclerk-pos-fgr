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
        public List<Entities.TrnTradeInLineEntity> DropdownListTradeInLineAmount()
        {
            var tradeInLineAmount = from d in db.TrnTradeInLines
                                    where d.TradeInId == d.TrnTradeIn.Id
                            select new Entities.TrnTradeInLineEntity
                            {
                                Id = d.Id,
                                Amount = d.Amount
                            };

            return tradeInLineAmount.ToList();
        }
    }
}
