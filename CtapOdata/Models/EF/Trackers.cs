using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class Trackers
    {
        public Trackers()
        {
            Impressions = new HashSet<Impressions>();
        }

        public int TrackerId { get; set; }
        public Guid Guid { get; set; }
        public int? BannerId { get; set; }
        public int PlacementId { get; set; }
        public int LandingPageId { get; set; }
        public DateTime DateEntered { get; set; }
        public bool? IsActive { get; set; }

        public Banners Banner { get; set; }
        public LandingPages LandingPage { get; set; }
        public Placements Placement { get; set; }
        public ICollection<Impressions> Impressions { get; set; }
    }
}
