using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Entities
{
    public class DgvTrnTradeInListEntity
    {
        public String ColumnTradeInListButtonEdit { get; set; }
        public String ColumnTradeInListButtonDelete { get; set; }
        public Int32 ColumnTradeInListId { get; set; }
        public String ColumnTradeInListTradeInNo{ get; set; }
        public String ColumnTradeInListTradeInDate{ get; set; }
        public String ColumnTradeInListRemarks{ get; set; }
        public Boolean ColumnTradeInListIsLocked { get; set; }
    }
}
