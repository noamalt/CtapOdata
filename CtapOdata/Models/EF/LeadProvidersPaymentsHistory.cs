using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class LeadProvidersPaymentsHistory
    {
        public int LeadProviderId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Comments { get; set; }
        public int PaymentId { get; set; }

        public LeadProviders LeadProvider { get; set; }
    }
}
