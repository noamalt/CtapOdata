using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class BridgeFailureLog
    {
        public int EntryId { get; set; }
        public int? ErrorNumber { get; set; }
        public int? ErrorSeverity { get; set; }
        public int? ErrorState { get; set; }
        public string ErrorProcedure { get; set; }
        public int? ErrorLine { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
