using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class UsersInAccountEvents
    {
        public int AccountEventId { get; set; }
        public int UserId { get; set; }
        public int LeadAssignmentTypeId { get; set; }
        public DateTime? ModifyDate { get; set; }

        public Users User { get; set; }
    }
}
