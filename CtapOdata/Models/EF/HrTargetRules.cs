using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class HrTargetRules
    {
        public int TargetRuleId { get; set; }
        public string TargetRuleName { get; set; }
        public string TargetRuleDescription { get; set; }
    }
}
