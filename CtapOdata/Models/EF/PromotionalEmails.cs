using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class PromotionalEmails
    {
        public int PromotionalEmailId { get; set; }
        public string PromotionalEmailName { get; set; }
        public string PromotionalEmailDescription { get; set; }
        public string PromotionalEmailCode { get; set; }
        public int PromotionalEmailLanguageId { get; set; }
        public int PromotionalEmailLandingPageId { get; set; }

        public LandingPages PromotionalEmailLandingPage { get; set; }
        public Languages PromotionalEmailLanguage { get; set; }
    }
}
