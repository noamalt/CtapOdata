using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class UserInTeamLeader
    {
        public int Id { get; set; }
        public int TeamLeaderId { get; set; }
        public int UserId { get; set; }
        public int DeskId { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
