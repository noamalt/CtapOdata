using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class UtmSubCampaignCampaignMapping
    {
        public int Id { get; set; }
        public int UtmSubcampaignId { get; set; }
        public int UtmCampaignId { get; set; }
        public DateTime? Timestamp { get; set; }
    }
}
