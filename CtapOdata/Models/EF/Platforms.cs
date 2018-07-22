using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class Platforms
    {
        public Platforms()
        {
            Countries = new HashSet<Countries>();
            PlatformGroups = new HashSet<PlatformGroups>();
        }

        public int PlatformId { get; set; }
        public string Name { get; set; }
        public string DemoServer { get; set; }
        public string LiveServer { get; set; }
        public string DefaultDemoGroup { get; set; }
        public string DefaultLiveGroup { get; set; }
        public int OfficeId { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDefault { get; set; }
        public int? CurrencyId { get; set; }
        public string DeskIds { get; set; }
        public int? AccountTypeId { get; set; }
        public int? PlatformTypeId { get; set; }

        public ICollection<Countries> Countries { get; set; }
        public ICollection<PlatformGroups> PlatformGroups { get; set; }
    }
}
