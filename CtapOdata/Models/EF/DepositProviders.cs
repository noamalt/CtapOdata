using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class DepositProviders
    {
        public DepositProviders()
        {
            DepositProviderSettings = new HashSet<DepositProviderSettings>();
            DepositProvidersInPayCards = new HashSet<DepositProvidersInPayCards>();
            DepositProvidersPriorities = new HashSet<DepositProvidersPriorities>();
        }

        public int DepositProviderId { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDefault { get; set; }
        public string Ccurl { get; set; }

        public ICollection<DepositProviderSettings> DepositProviderSettings { get; set; }
        public ICollection<DepositProvidersInPayCards> DepositProvidersInPayCards { get; set; }
        public ICollection<DepositProvidersPriorities> DepositProvidersPriorities { get; set; }
    }
}
