using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Entities
{
    public class TrnDefectiveEntity
    {
        public Int32 Id { get; set; }
        public String DefectiveNo { get; set; }
        public String DefectiveDate { get; set; }
        public String PurchasedDate { get; set; }
        public String InvoiceNo { get; set; }
        public String CustomerName { get; set; }
        public String VehicleType { get; set; }
        public String ReplacementDate{ get; set; }
        public String ReplacementInvoiceNo{ get; set; }
        public Int32 PreparedById { get; set; }
        public Boolean IsLocked { get; set; }
    }
}
