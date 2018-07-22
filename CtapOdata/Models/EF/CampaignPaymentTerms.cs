using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class CampaignPaymentTerms
    {
        public CampaignPaymentTerms()
        {
            SubCampaigns = new HashSet<SubCampaigns>();
        }

        public int CampaignPaymentTermId { get; set; }
        public string Name { get; set; }

        public ICollection<SubCampaigns> SubCampaigns { get; set; }
    }
}
