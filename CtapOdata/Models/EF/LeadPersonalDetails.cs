using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class LeadPersonalDetails
    {
        public int RowId { get; set; }
        public int LeadId { get; set; }
        public int? Bonus { get; set; }
        public int? Age { get; set; }
        public string Gender { get; set; }
        public int? MatirialStatus { get; set; }
        public int? NumOfBankAccounts { get; set; }
        public int? IncomeSource { get; set; }
        public int? Proffesion { get; set; }
        public int? Nationality { get; set; }
        public int? TradingExperince { get; set; }
        public string TradingCompany { get; set; }
        public string GeneralNotes { get; set; }
        public int? LoadingVol { get; set; }
        public int? Activity { get; set; }
        public int? AnticipatedAmountOfDeposit { get; set; }
        public int? Wd { get; set; }
        public int? RetentionComment { get; set; }
        public DateTime Modifydate { get; set; }
        public int? ConnectionType { get; set; }
        public int? VisitedPlatform { get; set; }
        public int? PendingCompliance { get; set; }
        public string RetentionNotes { get; set; }

        public Leads Lead { get; set; }
    }
}
