using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class PlatformGroups
    {
        public PlatformGroups()
        {
            PlacementsPlatformGroup = new HashSet<Placements>();
            PlacementsPlatformGroupId2Navigation = new HashSet<Placements>();
        }

        public int PlatformGroupId { get; set; }
        public string PlatformGroupName { get; set; }
        public int AccountTypeId { get; set; }
        public int? PlatformId { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDefault { get; set; }

        public Platforms Platform { get; set; }
        public ICollection<Placements> PlacementsPlatformGroup { get; set; }
        public ICollection<Placements> PlacementsPlatformGroupId2Navigation { get; set; }
    }
}
