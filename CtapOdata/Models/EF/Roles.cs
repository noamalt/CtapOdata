using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class Roles
    {
        public Roles()
        {
            LeadAssignmentTypes = new HashSet<LeadAssignmentTypes>();
            LeadFiltering = new HashSet<LeadFiltering>();
            ProfilesRolesMapping = new HashSet<ProfilesRolesMapping>();
            UsersInRoles = new HashSet<UsersInRoles>();
        }

        public int RoleId { get; set; }
        public string Name { get; set; }
        public string RoleName { get; set; }
        public int? RoleGroupId { get; set; }
        public bool? IsActive { get; set; }

        public ICollection<LeadAssignmentTypes> LeadAssignmentTypes { get; set; }
        public ICollection<LeadFiltering> LeadFiltering { get; set; }
        public ICollection<ProfilesRolesMapping> ProfilesRolesMapping { get; set; }
        public ICollection<UsersInRoles> UsersInRoles { get; set; }
    }
}
