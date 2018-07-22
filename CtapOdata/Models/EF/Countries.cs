using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class Countries
    {
        public Countries()
        {
            LeadFiltering = new HashSet<LeadFiltering>();
            LeadInfo = new HashSet<LeadInfo>();
            LeadProviders = new HashSet<LeadProviders>();
            PayCards = new HashSet<PayCards>();
        }

        public int CountryId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Symbol { get; set; }
        public string LanguageCulture { get; set; }
        public int LanguageId { get; set; }
        public string Mbsymbol { get; set; }
        public string Cngsymbol { get; set; }
        public int PlatformId { get; set; }
        public string TimeSpanName { get; set; }

        public Languages Language { get; set; }
        public Platforms Platform { get; set; }
        public RegulatedCountries RegulatedCountries { get; set; }
        public ICollection<LeadFiltering> LeadFiltering { get; set; }
        public ICollection<LeadInfo> LeadInfo { get; set; }
        public ICollection<LeadProviders> LeadProviders { get; set; }
        public ICollection<PayCards> PayCards { get; set; }
    }
}
