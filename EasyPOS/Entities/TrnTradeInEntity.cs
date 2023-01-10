using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Entities
{
    public class TrnTradeInEntity
    {
        public Int32 Id { get; set; }
        public String TradeInNo { get; set; }
        public String TradeInDate { get; set; }
        public String Remarks { get; set; }
        public Int32 PreparedById { get; set; }
        public Boolean IsLocked { get; set; }
    }
}
