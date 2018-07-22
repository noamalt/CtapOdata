using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class PageVisits
    {
        public int PageId { get; set; }
        public string PageName { get; set; }
        public int? Clicks { get; set; }
    }
}
