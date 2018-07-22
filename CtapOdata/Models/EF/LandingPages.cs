using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class LandingPages
    {
        public LandingPages()
        {
            Banners = new HashSet<Banners>();
            LandingPageInstances = new HashSet<LandingPageInstances>();
            Placements = new HashSet<Placements>();
            PromotionalEmails = new HashSet<PromotionalEmails>();
            Trackers = new HashSet<Trackers>();
        }

        public int LandingPageId { get; set; }
        public string Name { get; set; }
        public string SnapshotFilePath { get; set; }
        public string Url { get; set; }
        public string LandingTemplate { get; set; }
        public string CompletedTemplate { get; set; }

        public ICollection<Banners> Banners { get; set; }
        public ICollection<LandingPageInstances> LandingPageInstances { get; set; }
        public ICollection<Placements> Placements { get; set; }
        public ICollection<PromotionalEmails> PromotionalEmails { get; set; }
        public ICollection<Trackers> Trackers { get; set; }
    }
}
