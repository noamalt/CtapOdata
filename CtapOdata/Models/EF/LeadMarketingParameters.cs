using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class LeadMarketingParameters
    {
        public int RowId { get; set; }
        public int LeadId { get; set; }
        public string AffiliateId { get; set; }
        public string AffiliateName { get; set; }
        public string Source { get; set; }
        public string AffSub { get; set; }
        public string AffSub2 { get; set; }
        public string AffSub3 { get; set; }
        public string AffSub4 { get; set; }
        public string AffSub5 { get; set; }
        public string OfferId { get; set; }
        public string OfferName { get; set; }
        public string OfferUrlId { get; set; }
        public string OfferFileId { get; set; }
        public string FileName { get; set; }
        public string AdvertiserId { get; set; }
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public string Params { get; set; }
        public string TransactionId { get; set; }
        public DateTime? Datetime { get; set; }
        public string OfferRef { get; set; }
        public string AffiliateRef { get; set; }
        public string AdvertiserRef { get; set; }
        public string GoogleCampaign { get; set; }
        public string GoogleAdGroup { get; set; }
        public string GoogleNetwork { get; set; }
        public string GoogleTerm { get; set; }
        public string GoogleAd { get; set; }
        public string GoogleSiteTarget { get; set; }
        public string Device { get; set; }
        public string DeviceModel { get; set; }
        public string Topic { get; set; }
        public string LandingPage { get; set; }
        public string MmAdId { get; set; }
        public string MmPlacementId { get; set; }
        public string MmCampaignId { get; set; }
        public string MmPublisherName { get; set; }
        public string MmAdName { get; set; }
        public string MmCampaignName { get; set; }
        public string MmAdFormat { get; set; }
        public string MmSiteId { get; set; }
        public string MmIsClick { get; set; }
        public string MmLineId { get; set; }
        public string MmAdvertiserId { get; set; }
        public string MmAdvertiserName { get; set; }
        public string MmPlacementBannerSize { get; set; }
        public string MmSectionName { get; set; }
        public string UtmCampaign { get; set; }
        public string UtmSubcampaign { get; set; }
        public string UtmCreative { get; set; }
        public string UtmDynamic { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string CallToActionProvider { get; set; }
        public string D1 { get; set; }
        public string D2 { get; set; }
        public string Funnelid { get; set; }
        public int? UtmCampaignId { get; set; }
        public int? UtmSubcampaignId { get; set; }

        public Leads Lead { get; set; }
    }
}
