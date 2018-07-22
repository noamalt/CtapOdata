using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class LaverateErrorLog
    {
        public int LaverateErrorLogId { get; set; }
        public string UserName { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime? ErrorDate { get; set; }
        public int? Type { get; set; }
    }
}
