using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class Apierrors
    {
        public int RowId { get; set; }
        public double? Code { get; set; }
        public string ErrorMessage { get; set; }
        public string Language { get; set; }
        public int? LanguageId { get; set; }
    }
}
