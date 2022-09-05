using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Entities
{
    public class DgvMstCustomerListEntity
    {
        public String ColumnCustomerListButtonEdit { get; set; }
        public String ColumnCustomerListButtonDelete { get; set; }
        public Int32 ColumnCustomerListId { get; set; }
        public String ColumnCustomerListCustomerCode { get; set; }
        public String ColumnCustomerListCustomer { get; set; }
        public String ColumnCustomerListContactNumber { get; set; }
        public String ColumnCustomerListAddress { get; set; }
        public String ColumnCustomerListVehiclePlateNo { get; set; }
        public String ColumnCustomerListVehicleType { get; set; }
        public Boolean ColumnCustomerListIsLocked { get; set; }
    }
}