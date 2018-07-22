using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class FinancialAccountTypesRankingAudit
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int AuditUserId { get; set; }
        public int FromFinancialAccountTypeId { get; set; }
        public int ToFinancialAccountTypeId { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
