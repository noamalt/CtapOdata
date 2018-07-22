using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class PaymentStatuses
    {
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public string Key { get; set; }
    }
}
