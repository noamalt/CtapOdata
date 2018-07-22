using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class LeadRanks
    {
        public int LeadRankId { get; set; }
        public string LeadRankName { get; set; }
        public bool? IsActive { get; set; }
    }
}
