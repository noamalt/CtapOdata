using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class Forms
    {
        public Forms()
        {
            LandingPageInstances = new HashSet<LandingPageInstances>();
        }

        public int FormId { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }

        public ICollection<LandingPageInstances> LandingPageInstances { get; set; }
    }
}
