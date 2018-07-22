using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class Banks
    {
        public int BankId { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Symbol { get; set; }
        public bool? IsActive { get; set; }
    }
}
