using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class Cultures
    {
        public int Id { get; set; }
        public string LanguageName { get; set; }
        public string DisplayName { get; set; }
        public string CultureCode { get; set; }
    }
}
