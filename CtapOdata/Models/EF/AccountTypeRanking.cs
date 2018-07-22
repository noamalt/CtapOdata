using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class AccountTypeRanking
    {
        public int Id { get; set; }
        public int? OfficeId { get; set; }
        public int? CurrencyId { get; set; }
        public int? AccountTypeId { get; set; }
        public decimal? FromAmount { get; set; }

        public AccountTypes AccountType { get; set; }
        public Currencies Currency { get; set; }
        public Offices Office { get; set; }
    }
}
