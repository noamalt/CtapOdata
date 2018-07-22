using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class InterfaceLanguage
    {
        public int Id { get; set; }
        public int? LanguageId { get; set; }

        public Languages Language { get; set; }
    }
}
