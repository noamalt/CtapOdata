using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class LeadRetentionScoresBidata
    {
        public int Id { get; set; }
        public int LeadId { get; set; }
        public int LeadRetentionScore { get; set; }
    }
}
