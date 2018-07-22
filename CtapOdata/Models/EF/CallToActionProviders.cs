using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class CallToActionProviders
    {
        public int Id { get; set; }
        public string ProviderName { get; set; }
        public string ProviderDescription { get; set; }
        public string ProviderToken { get; set; }
        public bool HiddenDeskEnabled { get; set; }
    }
}
