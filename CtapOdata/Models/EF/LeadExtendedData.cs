using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class LeadExtendedData
    {
        public int LeadId { get; set; }
        public string ColumnKey { get; set; }
        public int? ValueId { get; set; }
        public string StringValue { get; set; }
        public DateTime ModifyDate { get; set; }
    }
}
