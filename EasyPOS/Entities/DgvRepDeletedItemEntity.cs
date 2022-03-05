using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Entities
{
    public class DgvRepDeletedItemEntity
    {
        public String ColumnDeletedItemSalesNumber { get; set; }
        public String ColumnDeletedItemItemDescription { get; set; }
        public String ColumnDeletedItemPreparation { get; set; }
        public String ColumnDeletedItemQuantity { get; set; }
        public String ColumnDeletedItemUnit { get; set; }
        public String ColumnDeletedItemPrice { get; set; }
        public String ColumnDeletedItemUserName { get; set; }
        public DateTime ColumnDeletedItemDeletedDateTime { get; set; }
    }
}
