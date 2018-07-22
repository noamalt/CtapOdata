using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class AccountTypes
    {
        public AccountTypes()
        {
            AccountTypeRanking = new HashSet<AccountTypeRanking>();
        }

        public int AccountTypeId { get; set; }
        public string AccountTypeName { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDefault { get; set; }

        public ICollection<AccountTypeRanking> AccountTypeRanking { get; set; }
    }
}
