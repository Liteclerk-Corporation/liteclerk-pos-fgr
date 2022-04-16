using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Entities
{
    public class RepSalesReportSalesAgentReportEntity
    {
        public Int32 Id { get; set; }
        public Int32 SalesId { get; set; }
        public String SalesAgent { get; set; }
        public String EntryDateTime { get; set; }
        public Decimal Quantity { get; set; }
        public Int32 ItemId { get; set; }
        public String BarCode { get; set; }
        public String ItemDescription { get; set; }
        public Decimal Price { get; set; }
        public Decimal DiscountAmount { get; set; }
        public Decimal Amount { get; set; }
    }
}
