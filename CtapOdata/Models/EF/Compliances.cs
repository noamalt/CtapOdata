using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class Compliances
    {
        public int ComplianceId { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
    }
}
