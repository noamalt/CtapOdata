using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class UsersInDesks
    {
        public int UserId { get; set; }
        public int DeskId { get; set; }
        public int? OfficeId { get; set; }
        public bool IsManager { get; set; }
        public int LeadAffinity { get; set; }
        public bool? IsTeamLeader { get; set; }
        public bool? IsViewer { get; set; }

        public Desks Desk { get; set; }
        public Users User { get; set; }
    }
}
