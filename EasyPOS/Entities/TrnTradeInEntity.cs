using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Entities
{
    class TrnTradeInEntity
    {
        public Int32 Id { get; set; }
        public String TradeInNo { get; set; }
        public DateTime TradeInDate { get; set; }
        public String Remarks { get; set; }
        public Int32 PreparedById { get; set; }
        public Boolean Islocked { get; set; }
        public Int32 SalesId { get; set; }
    }
}
