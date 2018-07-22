using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CtapOdata.Models.EF
{
    public partial class AccountEvents
    {   [Key]
        public int AccountEventId { get; set; }
        public int CashierTypeId { get; set; }
        public DateTime EventDate { get; set; }
        public int AccountId { get; set; }
        public int AccountEventTypeId { get; set; }
        public decimal TotalSum { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? CoversionRate { get; set; }
        public decimal? TotalUsdsum { get; set; }
        public string TransactionId { get; set; }
        public int? PayCardId { get; set; }
        public bool IsSuccessful { get; set; }
        public string Comments { get; set; }
        public int? StatusCode { get; set; }
        public string PayCardDigits { get; set; }
        public int? DepositProviderId { get; set; }
        public int? DepositTypeId { get; set; }
        public int? BankId { get; set; }
        public string Mtcn { get; set; }
        public decimal? SentAmount { get; set; }
        public int? SentAmountCurrencyId { get; set; }
        public decimal? ReceivedAmount { get; set; }
        public int? ReceivedAmountCurrencyId { get; set; }
        public bool IsOpening { get; set; }
        public bool? IsPending { get; set; }
        public int? IsCompliance { get; set; }
        public int? UserId { get; set; }
        public string OrderReference { get; set; }
        public string BankName { get; set; }
        public string BranchNumber { get; set; }
        public string Swiftcode { get; set; }
        public string Ibancode { get; set; }
        public int? IsRisk { get; set; }
        public bool Is3Ds { get; set; }
    }
}
