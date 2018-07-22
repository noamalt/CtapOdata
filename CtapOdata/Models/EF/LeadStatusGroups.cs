using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class LeadStatusGroups
    {
        public LeadStatusGroups()
        {
            LeadStatuses = new HashSet<LeadStatuses>();
        }

        public int LeadStatusGroupId { get; set; }
        public string Name { get; set; }
        public int LeadAssignmentTypeId { get; set; }

        public LeadAssignmentTypes LeadAssignmentType { get; set; }
        public ICollection<LeadStatuses> LeadStatuses { get; set; }
    }
}
