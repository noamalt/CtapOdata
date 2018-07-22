using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class Placements
    {
        public Placements()
        {
            BannersInPlacement = new HashSet<BannersInPlacement>();
            Trackers = new HashSet<Trackers>();
        }

        public int PlacementId { get; set; }
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public int SubCampaignId { get; set; }
        public int DeskId { get; set; }
        public int LanguageId { get; set; }
        public string LandingPageUrl { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsTextLink { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public bool IsSwf { get; set; }
        public bool IsDefault { get; set; }
        public int? PlatformGroupId { get; set; }
        public int? PixelId { get; set; }
        public int? LandingPageId { get; set; }
        public string PlatformComments { get; set; }
        public int? PlatformGroupId2 { get; set; }
        public bool? DisabledChat { get; set; }
        public string Comment { get; set; }

        public Desks Desk { get; set; }
        public LandingPages LandingPage { get; set; }
        public Languages Language { get; set; }
        public Pixels Pixel { get; set; }
        public PlatformGroups PlatformGroup { get; set; }
        public PlatformGroups PlatformGroupId2Navigation { get; set; }
        public SubCampaigns SubCampaign { get; set; }
        public ICollection<BannersInPlacement> BannersInPlacement { get; set; }
        public ICollection<Trackers> Trackers { get; set; }
    }
}
