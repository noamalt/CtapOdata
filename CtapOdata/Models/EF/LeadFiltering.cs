using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class LeadFiltering
    {
        public int LeadFilteringId { get; set; }
        public int? CurrentUserId { get; set; }
        public int? RoleId { get; set; }
        public int? DeskId { get; set; }
        public int? LeadStatusId { get; set; }
        public int? CountryId { get; set; }
        public int? LanguageId { get; set; }
        public int? LeadAssignmentTypeId { get; set; }
        public int? SubCampaignId { get; set; }
        public int? OfficeId { get; set; }
        public bool? IsDefault { get; set; }
        public bool? IsActive { get; set; }
        public bool ShowConvertedOnly { get; set; }
        public int? AssignToUserId { get; set; }
        public bool ShowUnAssignedOnly { get; set; }
        public int LastDays { get; set; }
        public bool IsDeskManager { get; set; }
        public bool? IncludeForThisUser { get; set; }
        public int? FinancialRankTypeId { get; set; }

        public Countries Country { get; set; }
        public Users CurrentUser { get; set; }
        public Desks Desk { get; set; }
        public Languages Language { get; set; }
        public LeadAssignmentTypes LeadAssignmentType { get; set; }
        public LeadStatuses LeadStatus { get; set; }
        public Offices Office { get; set; }
        public Roles Role { get; set; }
        public SubCampaigns SubCampaign { get; set; }
    }
}
