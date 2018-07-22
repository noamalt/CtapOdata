using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class LeadMarketingAffiliates
    {
        public int Id { get; set; }
        public int AffiliateId { get; set; }
        public string AffiliateName { get; set; }
        public int UtmCampaignId { get; set; }
        public DateTime DateEntered { get; set; }
    }
}
