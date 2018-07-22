using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class ScheduleTasks
    {
        public int MeetingId { get; set; }
        public string MeetingSubject { get; set; }
        public int LeadId { get; set; }
        public int UserId { get; set; }
        public DateTime MeetingDate { get; set; }
        public int PriorityId { get; set; }
        public int ReminderId { get; set; }
        public int? MeetingStatusId { get; set; }
        public bool? IsOpened { get; set; }

        public Leads Lead { get; set; }
        public Priority Priority { get; set; }
        public Reminder Reminder { get; set; }
        public Users User { get; set; }
    }
}
