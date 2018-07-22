using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class LeadAssignmentTypes
    {
        public LeadAssignmentTypes()
        {
            LeadFiltering = new HashSet<LeadFiltering>();
            LeadStatusGroups = new HashSet<LeadStatusGroups>();
        }

        public int LeadAssignmentTypeId { get; set; }
        public string Name { get; set; }
        public int RoleId { get; set; }

        public Roles Role { get; set; }
        public ICollection<LeadFiltering> LeadFiltering { get; set; }
        public ICollection<LeadStatusGroups> LeadStatusGroups { get; set; }
    }
}
