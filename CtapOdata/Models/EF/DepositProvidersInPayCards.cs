using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class DepositProvidersInPayCards
    {
        public int Id { get; set; }
        public int DepositProviderId { get; set; }
        public int PayCardId { get; set; }
        public bool IsDefault { get; set; }

        public DepositProviders DepositProvider { get; set; }
        public PayCards PayCard { get; set; }
    }
}
