using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Entities
{
    public class DgvMstTableListEntity
    {
        public String ColumnTableListButtonEdit { get; set; }
        public String ColumnTableListButtonDelete { get; set; }
        public Int32 ColumnTableListId { get; set; }
        public String ColumnTableListTableCode { get; set; }
        public Int32 ColumnTableListTableGroupId { get; set; }
        public Int32 ColumnTableListSortNumber { get; set; }
    }
}