using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class ProfilesRolesMapping
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int ProfileId { get; set; }

        public RoleProfiles Profile { get; set; }
        public Roles Role { get; set; }
    }
}
