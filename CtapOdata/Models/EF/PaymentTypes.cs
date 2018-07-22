using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class PaymentTypes
    {
        public PaymentTypes()
        {
            LeadProviders = new HashSet<LeadProviders>();
        }

        public byte PaymentTypeId { get; set; }
        public string PaymentTypeName { get; set; }
        public string PaymentTypeDescription { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDetauld { get; set; }

        public ICollection<LeadProviders> LeadProviders { get; set; }
    }
}
