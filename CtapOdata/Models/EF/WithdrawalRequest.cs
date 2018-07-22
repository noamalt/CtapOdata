using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class WithdrawalRequest
    {
        public int WithdrawalRequestId { get; set; }
        public int AccountEventId { get; set; }
        public string TraceId { get; set; }
        public int? StatusId { get; set; }
        public bool? IsRetention { get; set; }
        public bool? IsCompliance { get; set; }
        public bool? IsFinance { get; set; }
        public DateTime? RetentionDate { get; set; }
        public DateTime? ComplianceDate { get; set; }
        public DateTime? FinanceDate { get; set; }
        public int? WdaccountEventId { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime ModifyDate { get; set; }
        public decimal? RequestedAmount { get; set; }
        public decimal? ApprovedAmount { get; set; }
    }
}
