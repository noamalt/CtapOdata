using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class UtmSubCampaigns
    {
        public int UtmSubcampaignId { get; set; }
        public int? UtmCampaignId { get; set; }
        public Guid SubCampaignToken { get; set; }
        public string UtmSubcampaign { get; set; }
        public DateTime DateEntered { get; set; }
    }
}
