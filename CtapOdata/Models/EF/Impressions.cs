using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class Impressions
    {
        public int ImpressionId { get; set; }
        public int TrackerId { get; set; }
        public DateTime DateEntered { get; set; }
        public int TotalImpressions { get; set; }

        public Trackers Tracker { get; set; }
    }
}
