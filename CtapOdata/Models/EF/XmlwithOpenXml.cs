using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class XmlwithOpenXml
    {
        public int Id { get; set; }
        public string Xmldata { get; set; }
        public DateTime? LoadedDateTime { get; set; }
    }
}
