﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Entities
{
    class MstPayType
    {
        public Int32 Id { get; set; }
        public String PayType { get; set; }
        public Int32 AccountId { get; set; }
        public String Account { get; set; }
        public String SortNumber { get; set; }
    }
}
