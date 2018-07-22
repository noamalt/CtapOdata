using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class DepositProvidersPriorities
    {
        public int PriorityId { get; set; }
        public int? OfficeId { get; set; }
        public int? DepositProviderId { get; set; }
        public int? CurrencyId { get; set; }
        public string Name { get; set; }
        public string Rank { get; set; }
        public int? Sorting { get; set; }

        public Currencies Currency { get; set; }
        public DepositProviders DepositProvider { get; set; }
        public Offices Office { get; set; }
    }
}
