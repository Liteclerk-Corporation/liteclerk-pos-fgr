using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Entities
{
    public class DgvTrnTradeInLineListEntity
    {
        public String ColumnTradeInLineListButtonEdit { get; set; }
        public String ColumnTradeInLineListButtonDelete { get; set; }
        public Int32 ColumnTradeInLineListId { get; set; }
        public Int32 ColumnTradeInLineListTradeInId { get; set; }
        public Int32 ColumnTradeInLineListItemId { get; set; }
        public String ColumnTradeInLineListItemSize { get; set; }
        public String ColumnTradeInLineListItemBrand { get; set; }
        public String ColumnTradeInLineListItemWarrantyCode { get; set; }
        public String ColumnTradeInLineListQuantity { get; set; }
        public String ColumnTradeInLineListAmount { get; set; }
    }
}
