using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class UsersLogin
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int? OfficeId { get; set; }
        public int? AccountId { get; set; }
        public DateTime UtcloginTime { get; set; }
        public DateTime? UtclogoffTime { get; set; }
        public string SessionId { get; set; }
        public string Ip { get; set; }
        public string Browser { get; set; }
    }
}
