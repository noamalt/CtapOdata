using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class UtmCampaigns
    {
        public int UtmCampaignId { get; set; }
        public Guid CampaignToken { get; set; }
        public int OfficeId { get; set; }
        public string UtmCampaign { get; set; }
        public int? AffiliateSourceId { get; set; }
        public DateTime DateEntered { get; set; }
    }
}
