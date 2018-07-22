using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class BannersInPlacement
    {
        public int PlacementId { get; set; }
        public int BannerId { get; set; }
        public int Significance { get; set; }
        public int Hits { get; set; }

        public Placements Placement { get; set; }
    }
}
