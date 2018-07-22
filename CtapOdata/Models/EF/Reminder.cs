using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class Reminder
    {
        public Reminder()
        {
            ScheduleTasks = new HashSet<ScheduleTasks>();
        }

        public int ReminderId { get; set; }
        public string ReminderName { get; set; }

        public ICollection<ScheduleTasks> ScheduleTasks { get; set; }
    }
}
