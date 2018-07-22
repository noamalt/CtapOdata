using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class BannerSizes
    {
        public BannerSizes()
        {
            Banners = new HashSet<Banners>();
        }

        public int BannerSizeId { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public ICollection<Banners> Banners { get; set; }
    }
}
