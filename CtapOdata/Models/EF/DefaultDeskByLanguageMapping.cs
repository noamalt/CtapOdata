using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class DefaultDeskByLanguageMapping
    {
        public int Id { get; set; }
        public int OfficeId { get; set; }
        public int LanguageId { get; set; }
        public int DefaultDeskId { get; set; }
        public int? LpDefaultDeskId { get; set; }
    }
}
