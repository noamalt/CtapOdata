using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class UsersCampaignsMapping
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int UtmCampaignId { get; set; }
        public int? OfficeId { get; set; }
        public bool ViewAll { get; set; }
        public DateTime ModifyDate { get; set; }
    }
}
