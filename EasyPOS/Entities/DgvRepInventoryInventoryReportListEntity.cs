using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Entities
{
    public class DgvRepInventoryInventoryReportListEntity
    {
        public String ColumnItemCode { get; set; }
        public String ColumnBarCode { get; set; }
        public String ColumnItemDescription { get; set; }
        public String ColumnUnit { get; set; }
        public String ColumnBegQuantity { get; set; }
        public String ColumnInQuantity { get; set; }
        public String ColumnOutQuantity { get; set; }
        public String ColumnEndingQuantity { get; set; }
        public String ColumnStockCount { get; set; }
        public String ColumnVariance { get; set; }
        public String ColumnCost { get; set; }
        public String ColumnItemPrice { get; set; }
        public String ColumnAmount { get; set; }
        public String ColumnSellingAmount { get; set; }
    }
}
