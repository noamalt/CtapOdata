using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class DepositTypes
    {
        public int DepositTypeId { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDefualt { get; set; }
    }
}
