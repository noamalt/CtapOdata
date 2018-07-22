using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class Ip2country
    {
        public int Id { get; set; }
        public decimal? Ipfrom { get; set; }
        public decimal? Ipto { get; set; }
        public string CountrySymbol { get; set; }
    }
}
