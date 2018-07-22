using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class Skins
    {
        public Skins()
        {
            LandingPageInstances = new HashSet<LandingPageInstances>();
        }

        public int SkinId { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }

        public ICollection<LandingPageInstances> LandingPageInstances { get; set; }
    }
}
