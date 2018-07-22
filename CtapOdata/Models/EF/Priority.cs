using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class Priority
    {
        public Priority()
        {
            ScheduleTasks = new HashSet<ScheduleTasks>();
        }

        public int PriorityId { get; set; }
        public string PriorityName { get; set; }

        public ICollection<ScheduleTasks> ScheduleTasks { get; set; }
    }
}
