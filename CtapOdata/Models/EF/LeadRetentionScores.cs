using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class LeadRetentionScores
    {
        public int Id { get; set; }
        public int LeadId { get; set; }
        public int LeadRetentionScore { get; set; }

        public Leads Lead { get; set; }
    }
}
