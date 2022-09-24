using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Entities
{
    public class DgvTrnDefectiveListEntity
    {
        public String ColumnDefectiveListButtonEdit { get; set; }
        public String ColumnDefectiveListButtonDelete { get; set; }
        public Int32 ColumnDefectiveListId { get; set; }
        public Int32 ColumnDefectiveListSalesId { get; set; }
        public String ColumnDefectiveListDefectiveNo { get; set; }
        public String ColumnDefectiveListDefectiveDate { get; set; }
        public String ColumnDefectiveListInvoiceNo { get; set; }
        public String ColumnDefectiveListCustomerName { get; set; }
        public String ColumnDefectiveListWarrantyCode { get; set; }
        public Int32 ColumnDefectiveListPreparedById { get; set; }
        public Boolean ColumnDefectiveListIsLocked { get; set; }
    }
}
