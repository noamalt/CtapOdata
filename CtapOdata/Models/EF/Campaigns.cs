using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class Campaigns
    {
        public int CampaignId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int OfficeId { get; set; }
        public bool IsDeleted { get; set; }
        public int? LeadProviderId { get; set; }

        public LeadProviders LeadProvider { get; set; }
        public Offices Office { get; set; }
    }
}
