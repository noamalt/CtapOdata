using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class AccountEventsAssignmentCorrections
    {
        public int RowId { get; set; }
        public int AccountEventId { get; set; }
        public string Action { get; set; }
        public string AuditUser { get; set; }
        public string Comment { get; set; }
        public DateTime? TimeStamp { get; set; }
    }
}
