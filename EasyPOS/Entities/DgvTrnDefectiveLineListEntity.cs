using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Entities
{
    public class DgvTrnDefectiveLineListEntity
    {
        public String ColumnDefectiveLineListButtonEdit { get; set; }
        public String ColumnDefectiveLineListButtonDelete { get; set; }
        public Int32 ColumnDefectiveLineListId { get; set; }
        public Int32 ColumnDefectiveLineListDefectiveId { get; set; }
        public Int32 ColumnDefectiveLineListItemId { get; set; }
        public String ColumnDefectiveLineListItemSize { get; set; }
        public String ColumnDefectiveLineListItemBrand { get; set; }
        public String ColumnDefectiveLineListItemWarrantyCode { get; set; }
        public String ColumnDefectiveLineListQuantity { get; set; }
        public String ColumnDefectiveLineListAmount { get; set; }
    }
}
