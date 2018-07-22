using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class AccountEventsBalanceCorrections
    {
        public int RowId { get; set; }
        public int AccountEventId { get; set; }
        public int? BcaccountEventId { get; set; }
        public string Action { get; set; }
        public decimal? Sum { get; set; }
        public string AuditUser { get; set; }
        public string Reason { get; set; }
        public DateTime? TimeStamp { get; set; }
    }
}
