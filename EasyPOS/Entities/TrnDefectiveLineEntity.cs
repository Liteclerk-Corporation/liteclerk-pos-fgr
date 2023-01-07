using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Entities
{
    public class TrnDefectiveLineEntity
    {
        public Int32 Id { get; set; }
        public Int32 DefectiveId { get; set; }
        public Int32 ItemId { get; set; }
        public String Size { get; set; }
        public String Brand { get; set; }
        public String WarrantyCode { get; set; }
        public Decimal Quantity { get; set; }
        public Decimal Amount { get; set; }
        public String Type { get; set; }

    }
}
