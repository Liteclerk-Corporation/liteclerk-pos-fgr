using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Entities
{
    public class RepInventoryReportStockInDetailReportEntity
    {
        public Int32 Id { get; set; }
        public Int32 stockInId { get; set; }
        public String ItemCode { get; set; }
        public String BarCode { get; set; }
        public String StockInDate { get; set; }
        public String StockInNumber { get; set; }
        public String ManualStockInNumber { get; set; }
        public String Remarks { get; set; }
        public Boolean IsReturn { get; set; }
        public String Item { get; set; }
        public String Unit { get; set; }
        public Decimal Quantity { get; set; }
        public Decimal Cost { get; set; }
        public Decimal Amount { get; set; }
        public String ExpiryDate { get; set; }
        public String LotNumber { get; set; }
        public Decimal? SellingPrice { get; set; }
    }
}
