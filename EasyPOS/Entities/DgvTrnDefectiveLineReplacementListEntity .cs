using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Entities
{
    public class DgvTrnDefectiveLineReplacementListEntity
    {
        public String ColumnDefectiveLineReplacementListButtonEdit { get; set; }
        public String ColumnDefectiveLineReplacementListButtonDelete { get; set; }
        public Int32 ColumnDefectiveLineReplacementListId { get; set; }
        public Int32 ColumnDefectiveLineReplacementListDefectiveId { get; set; }
        public Int32 ColumnDefectiveLineReplacementListItemId { get; set; }
        public String ColumnDefectiveLineReplacementListItemDescription { get; set; }
        public String ColumnDefectiveLineReplacementListQuantity { get; set; }
        public String ColumnDefectiveLineReplacementListAmount { get; set; }
    }
}
