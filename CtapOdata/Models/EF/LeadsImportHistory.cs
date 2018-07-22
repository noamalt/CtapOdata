using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class LeadsImportHistory
    {
        public int LiId { get; set; }
        public DateTime LiDateEntered { get; set; }
        public int LiNumberOfLeads { get; set; }
        public int LiStatus { get; set; }
        public int LiUserId { get; set; }
        public string LiCampaign { get; set; }
        public string LiSubCampaign { get; set; }
        public int? LiDesk { get; set; }
        public int? LiOffice { get; set; }
    }
}
