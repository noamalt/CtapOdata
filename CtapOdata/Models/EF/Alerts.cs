using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class Alerts
    {
        public int AlertId { get; set; }
        public string AlertBody { get; set; }
        public DateTime AlertDate { get; set; }
        public int ReporterId { get; set; }
        public int UserId { get; set; }
        public int LeadId { get; set; }
        public bool? IsRead { get; set; }
        public int? AlertTypeId { get; set; }

        public Leads Lead { get; set; }
        public Users Reporter { get; set; }
        public Users User { get; set; }
    }
}
