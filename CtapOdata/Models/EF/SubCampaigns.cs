using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class SubCampaigns
    {
        public SubCampaigns()
        {
            LeadFiltering = new HashSet<LeadFiltering>();
            Placements = new HashSet<Placements>();
        }

        public int SubCampaignId { get; set; }
        public string Name { get; set; }
        public int CampaignId { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public string OfferLeadCodePostBack { get; set; }
        public bool? OfferLeadCodePostBackIsActive { get; set; }
        public string OfferDepositCodePostBack { get; set; }
        public bool? OfferDepositCodePostBackIsActive { get; set; }
        public string OfferFtdcodePostBack { get; set; }
        public bool? OfferFtdcodePostBackIsActive { get; set; }
        public string OfferImpresionCode { get; set; }
        public bool? OfferImpresionCodeIsActive { get; set; }
        public string OfferClickCode { get; set; }
        public bool? OfferClickCodeIsActive { get; set; }
        public int? CampaignTypeId { get; set; }
        public int? CampaignPaymentTermId { get; set; }
        public int? UserId { get; set; }
        public float? LeadCost { get; set; }
        public float? TotalCost { get; set; }
        public int? ExpectedLeads { get; set; }
        public bool? IsOrganic { get; set; }
        public string Comment { get; set; }
        public string Website { get; set; }

        public CampaignPaymentTerms CampaignPaymentTerm { get; set; }
        public CampaignTypes CampaignType { get; set; }
        public Users User { get; set; }
        public ICollection<LeadFiltering> LeadFiltering { get; set; }
        public ICollection<Placements> Placements { get; set; }
    }
}
