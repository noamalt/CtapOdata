using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class Visits
    {
        public int VisitId { get; set; }
        public int? PlacementId { get; set; }
        public int? OfficeId { get; set; }
        public DateTime DateEntered { get; set; }
        public int TotalVisits { get; set; }

        public Offices Office { get; set; }
    }
}
