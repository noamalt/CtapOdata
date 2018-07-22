using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class RegulatedCountries
    {
        public int CountryId { get; set; }

        public Countries Country { get; set; }
    }
}
