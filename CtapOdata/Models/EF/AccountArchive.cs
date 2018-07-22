using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class AccountArchive
    {
        public int ArchiveId { get; set; }
        public int ArchiveAccountId { get; set; }
        public int LeadId { get; set; }
        public string Username { get; set; }
        public DateTime DateEntered { get; set; }
        public DateTime DateArchived { get; set; }
        public int? PlatformId { get; set; }
        public int? OfficeId { get; set; }
        public int? AccountTypeId { get; set; }
        public bool IsReal { get; set; }
        public bool? IsAdvancedTrader { get; set; }
        public string UserPassword { get; set; }
        public string Email { get; set; }
        public string TradingGroup { get; set; }
        public bool? EnableCreditCardSave { get; set; }
        public bool? IsTest { get; set; }
        public bool? IsReturn { get; set; }
        public bool? Dfaccount { get; set; }
        public DateTime? AccountTypeResetDate { get; set; }

        public Accounts ArchiveAccount { get; set; }
    }
}
