using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Entities
{
    public class DgvRepSalesReportCollectionSummaryReportEntityList
    {
        public String ColumnTerminal { get; set; }
        public String ColumnCollectionDate { get; set; }
        public String ColumnCollectionNumber { get; set; }
        public String ColumnCustomerCode { get; set; }
        public String ColumnCustomer { get; set; }
        public String ColumnSalesNumber { get; set; }
        public String ColumnRemarks { get; set; }
        public String ColumnPreparedBy { get; set; }
        public Boolean ColumnIsCancelled { get; set; }
        public String ColumnAmount { get; set; }
        public String ColumnTenderedAmount { get; set; }
        public String ColumnChangeAmount { get; set; }
        public String ColumnEntryDateTime { get; set; }
    }
}
