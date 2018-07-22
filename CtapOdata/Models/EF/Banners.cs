using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class Banners
    {
        public Banners()
        {
            Trackers = new HashSet<Trackers>();
        }

        public int BannerId { get; set; }
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public int LanguageId { get; set; }
        public bool IsSwf { get; set; }
        public string FilePath { get; set; }
        public int BannerSizeId { get; set; }
        public int DefaultLandingPageId { get; set; }

        public BannerSizes BannerSize { get; set; }
        public LandingPages DefaultLandingPage { get; set; }
        public Languages Language { get; set; }
        public ICollection<Trackers> Trackers { get; set; }
    }
}
