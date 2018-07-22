using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class CampaignTypes
    {
        public CampaignTypes()
        {
            SubCampaigns = new HashSet<SubCampaigns>();
        }

        public int CampaignTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<SubCampaigns> SubCampaigns { get; set; }
    }
}
