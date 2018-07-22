using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class LandingPageInstances
    {
        public int LandingPageId { get; set; }
        public int LanguageId { get; set; }
        public bool IsActive { get; set; }
        public int? SkinId { get; set; }
        public int? FormId { get; set; }
        public int? OfficeId { get; set; }
        public int LandingPageInstanceId { get; set; }
        public int? FormActionTypeId { get; set; }
        public string Title { get; set; }
        public string Keywords { get; set; }
        public string Description { get; set; }

        public Forms Form { get; set; }
        public FormActionType FormActionType { get; set; }
        public LandingPages LandingPage { get; set; }
        public Languages Language { get; set; }
        public Offices Office { get; set; }
        public Skins Skin { get; set; }
    }
}
