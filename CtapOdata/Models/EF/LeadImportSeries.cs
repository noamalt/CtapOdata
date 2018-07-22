using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class LeadImportSeries
    {
        public int LiSeriesId { get; set; }
        public DateTime? TimeStamp { get; set; }
        public int? OfficeId { get; set; }
        public int? DeskId { get; set; }
        public int? LanguageId { get; set; }
        public int? CampaignId { get; set; }
        public int? SubCampaignId { get; set; }
        public int? AuditUserId { get; set; }
        public int? Success { get; set; }
        public int? Failed { get; set; }
        public int? Duplicated { get; set; }
    }
}
