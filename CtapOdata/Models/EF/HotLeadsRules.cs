using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class HotLeadsRules
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? TimeframeHours { get; set; }
        public string LeadStatuses { get; set; }
        public string Source { get; set; }
        public int? CampaignId { get; set; }
        public string SubCampaigns { get; set; }
        public string CampaignChilds { get; set; }
        public string CallToActionProvider { get; set; }
        public bool Active { get; set; }
        public string Desks { get; set; }
        public string Countries { get; set; }
        public int? Language { get; set; }
        public bool? Online { get; set; }
        public int? Priority { get; set; }
        public int? OfficeId { get; set; }
    }
}
