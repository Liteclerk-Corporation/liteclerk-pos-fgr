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
        // Dropdown List Discount
        // ======================
        public List<Entities.TrnTradeInEntity> DropdownListTradeInNo()
        {
            var tradeInNo = from d in db.TrnTradeIns
                            where d.IsLocked == true
                            select new Entities.TrnTradeInEntity
                            {
                                Id = d.Id,
                                TradeInNo = d.TradeInNo
                            };

            return tradeInNo.ToList();
        }
    }
}
