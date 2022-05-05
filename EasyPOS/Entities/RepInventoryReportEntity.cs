using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Entities
{
    class RepInventoryReportEntity
    {
        public String Document { get; set; }
        public String Id { get; set; }
        public DateTime InventoryDate { get; set; }
        public String ItemCode { get; set; }
        public String BarCode { get; set; }
        public String ItemDescription { get; set; }
        public String Unit { get; set; }
        public Decimal Quantity { get; set; }
        public Decimal BeginningQuantity { get; set; }
        public Decimal InQuantity { get; set; }
        public Decimal OutQuantity { get; set; }
        public Decimal EndingQuantity { get; set; }
        public Decimal CountQuantity { get; set; }
        public Decimal Variance { get; set; }
        public Decimal Cost { get; set; }
        public Decimal Price { get; set; }
        public Decimal Amount { get; set; }
        public Decimal SellingAmount { get; set; }
        
    }
}
