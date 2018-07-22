using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class Currencies
    {
        public Currencies()
        {
            AccountTypeRanking = new HashSet<AccountTypeRanking>();
            DepositProviderSettings = new HashSet<DepositProviderSettings>();
            DepositProvidersPriorities = new HashSet<DepositProvidersPriorities>();
        }

        public int CurrencyId { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDefault { get; set; }

        public ICollection<AccountTypeRanking> AccountTypeRanking { get; set; }
        public ICollection<DepositProviderSettings> DepositProviderSettings { get; set; }
        public ICollection<DepositProvidersPriorities> DepositProvidersPriorities { get; set; }
    }
}
