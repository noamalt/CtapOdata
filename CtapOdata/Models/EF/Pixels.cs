using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class Pixels
    {
        public Pixels()
        {
            Placements = new HashSet<Placements>();
        }

        public int PixelId { get; set; }
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string Body { get; set; }
        public bool IsConversionOnly { get; set; }
        public bool? IsDeposit { get; set; }

        public ICollection<Placements> Placements { get; set; }
    }
}
