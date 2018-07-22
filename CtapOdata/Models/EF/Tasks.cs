using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class Tasks
    {
        public int TaskId { get; set; }
        public DateTime DateEntered { get; set; }
    }
}
