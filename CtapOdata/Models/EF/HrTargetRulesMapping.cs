using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class HrTargetRulesMapping
    {
        public int Id { get; set; }
        public int? TargetRuleId { get; set; }
        public int? TargetRuleTypeId { get; set; }
        public int? RuleMonth { get; set; }
        public int? RuleYear { get; set; }
        public int? HruserId { get; set; }
        public int? DepartmentId { get; set; }
        public decimal? TargetValue { get; set; }
        public int? TargetRuleScopeId { get; set; }
    }
}
