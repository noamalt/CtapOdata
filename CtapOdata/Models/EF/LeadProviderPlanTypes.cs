using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class LeadProviderPlanTypes
    {
        public LeadProviderPlanTypes()
        {
            LeadProviders = new HashSet<LeadProviders>();
        }

        public int LeadProviderPlanTypesId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<LeadProviders> LeadProviders { get; set; }
    }
}
