using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Entities
{
    public class TrnSalesLineDeletedEntity
    {
        public Int32 Id { get; set; }
        public Int32 SalesId { get; set; }
        public String SalesNumber { get; set; }
        public Int32 ItemId { get; set; }
        public String ItemDescription { get; set; }
        public String ItemKitchen { get; set; }
        public String Preparation { get; set; }
        public Int32 UnitId { get; set; }
        public String Unit { get; set; }
        public Decimal Price { get; set; }
        public Int32 DiscountId { get; set; }
        public String Discount { get; set; }
        public Decimal DiscountRate { get; set; }
        public Decimal DiscountAmount { get; set; }
        public Decimal NetPrice { get; set; }
        public Decimal Quantity { get; set; }
        public Decimal Amount { get; set; }
        public Int32 TaxId { get; set; }
        public String Tax { get; set; }
        public Decimal TaxRate { get; set; }
        public Decimal TaxAmount { get; set; }
        public Int32 UserId { get; set; }
        public String UserName { get; set; }
        public DateTime SalesDate { get; set; }
        public DateTime DeletedDate { get; set; }
        public Boolean IsPrinted { get; set; }
        public Int32 SalesLineId { get; set; }
        public String TableCode { get; set; }
        public Int32? TableId { get; set; }
    }
}
