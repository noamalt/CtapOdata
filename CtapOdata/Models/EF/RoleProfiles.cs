using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class RoleProfiles
    {
        public RoleProfiles()
        {
            ProfilesRolesMapping = new HashSet<ProfilesRolesMapping>();
            UsersProfilesMapping = new HashSet<UsersProfilesMapping>();
        }

        public int ProfileId { get; set; }
        public string ProfileName { get; set; }

        public ICollection<ProfilesRolesMapping> ProfilesRolesMapping { get; set; }
        public ICollection<UsersProfilesMapping> UsersProfilesMapping { get; set; }
    }
}
