using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Entities
{
    public class DgvRepSalesCostOfSalesReportEntity
    {
        public String ColumnTerminal { get; set; }
        public String ColumnDate { get; set; }
        public String ColumnSalesNumber { get; set; }
        public String ColumnBarCode { get; set; }
        public String ColumnItemDescription { get; set; }
        public String ColumnQuantity { get; set; }
        public String ColumnCost { get; set; }
        public String ColumnCostAmount { get; set; }
        public String ColumnCostSellingPrice { get; set; }
        public String ColumnCostProfit { get; set; }
    }
}
