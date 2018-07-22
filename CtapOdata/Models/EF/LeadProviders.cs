using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class LeadProviders
    {
        public LeadProviders()
        {
            Campaigns = new HashSet<Campaigns>();
            LeadProvidersPaymentsHistory = new HashSet<LeadProvidersPaymentsHistory>();
        }

        public int LeadProviderId { get; set; }
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int LeadProviderPlanTypesId { get; set; }
        public string Phone { get; set; }
        public string SeconderyPhone { get; set; }
        public string WebsiteName { get; set; }
        public string WebsiteUrl { get; set; }
        public int CountryId { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public byte PaymentTypeId { get; set; }
        public byte IsActive { get; set; }
        public int Commission { get; set; }
        public int? UpToCommission { get; set; }
        public bool? IsSubAffiliate { get; set; }
        public int? ParentId { get; set; }
        public int? ParentCommission { get; set; }
        public bool? IsParent { get; set; }

        public Countries Country { get; set; }
        public LeadProviderPlanTypes LeadProviderPlanTypes { get; set; }
        public PaymentTypes PaymentType { get; set; }
        public ICollection<Campaigns> Campaigns { get; set; }
        public ICollection<LeadProvidersPaymentsHistory> LeadProvidersPaymentsHistory { get; set; }
    }
}
