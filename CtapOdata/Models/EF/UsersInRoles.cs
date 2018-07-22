using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class UsersInRoles
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public int Id { get; set; }

        public Roles Role { get; set; }
        public Users User { get; set; }
    }
}
