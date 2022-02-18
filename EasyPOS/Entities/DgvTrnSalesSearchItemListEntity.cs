using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Entities
{
    public class DgvTrnSalesSearchItemListEntity
    {
        public Int32 ColumnSearchItemId { get; set; }
        public String ColumnSearchItemBarcode { get; set; }
        public String ColumnSearchItemDescription { get; set; }
        public String ColumnSearchItemGenericName { get; set; }
        public Int32 ColumnSearchItemOutTaxId { get; set; }
        public String ColumnSearchItemOutTax { get; set; }
        public String ColumnSearchItemOutTaxRate { get; set; }
        public Int32 ColumnSearchItemUnitId { get; set; }
        public String ColumnSearchItemUnit { get; set; }
        public String ColumnSearchItemPrice { get; set; }
        public String ColumnSearchItemOnHandQuantity { get; set; }
        public Boolean ColumnSearchItemIsInventory { get; set; }
        public String ColumnSearchItemButtonPick { get; set; }
        public String ColumnSearchItemCategory { get; set; }
    }
}
