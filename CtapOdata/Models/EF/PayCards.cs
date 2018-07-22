using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class PayCards
    {
        public PayCards()
        {
            DepositProvidersInPayCards = new HashSet<DepositProvidersInPayCards>();
        }

        public int PayCardId { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public int? CountryId { get; set; }
        public string Mbsymbol { get; set; }
        public bool IsActive { get; set; }
        public string ChainSymbol { get; set; }
        public string CngSymbol { get; set; }

        public Countries Country { get; set; }
        public ICollection<DepositProvidersInPayCards> DepositProvidersInPayCards { get; set; }
    }
}
