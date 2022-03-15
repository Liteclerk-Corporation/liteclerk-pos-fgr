using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Entities
{
    public class RepInventoryReportStockOutDetailEntity
    {
        public Int32 Id { get; set; }
        public Int32 stockOutId { get; set; }
        public String ItemCode { get; set; }
        public String BarCode { get; set; }
        public String StockOutDate { get; set; }
        public String StockOutNumber { get; set; }
        public String ManualStockOutNumber { get; set; }
        public String Remarks { get; set; }
        public String Item { get; set; }
        public String Unit { get; set; }
        public Decimal Quantity { get; set; }
        public Decimal Cost { get; set; }
        public Decimal Amount { get; set; }
    }
}
