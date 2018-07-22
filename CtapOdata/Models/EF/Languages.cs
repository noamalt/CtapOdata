using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class Languages
    {
        public Languages()
        {
            Banners = new HashSet<Banners>();
            Countries = new HashSet<Countries>();
            InterfaceLanguage = new HashSet<InterfaceLanguage>();
            LandingPageInstances = new HashSet<LandingPageInstances>();
            LeadFiltering = new HashSet<LeadFiltering>();
            LeadInfo = new HashSet<LeadInfo>();
            MailSubjects = new HashSet<MailSubjects>();
            Placements = new HashSet<Placements>();
            PromotionalEmails = new HashSet<PromotionalEmails>();
            SmsBodyInStatusAndLabguage = new HashSet<SmsBodyInStatusAndLabguage>();
        }

        public int LanguageId { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Culture { get; set; }
        public int Order { get; set; }
        public bool IsDefault { get; set; }
        public bool IsActive { get; set; }
        public bool IsRtl { get; set; }
        public int? DeskId { get; set; }

        public Desks Desk { get; set; }
        public ICollection<Banners> Banners { get; set; }
        public ICollection<Countries> Countries { get; set; }
        public ICollection<InterfaceLanguage> InterfaceLanguage { get; set; }
        public ICollection<LandingPageInstances> LandingPageInstances { get; set; }
        public ICollection<LeadFiltering> LeadFiltering { get; set; }
        public ICollection<LeadInfo> LeadInfo { get; set; }
        public ICollection<MailSubjects> MailSubjects { get; set; }
        public ICollection<Placements> Placements { get; set; }
        public ICollection<PromotionalEmails> PromotionalEmails { get; set; }
        public ICollection<SmsBodyInStatusAndLabguage> SmsBodyInStatusAndLabguage { get; set; }
    }
}
