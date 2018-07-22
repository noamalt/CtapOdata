using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class UsersProfilesMapping
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProfileId { get; set; }

        public RoleProfiles Profile { get; set; }
        public Users User { get; set; }
    }
}
