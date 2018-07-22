using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class LeadStatuses
    {
        public LeadStatuses()
        {
            LeadFiltering = new HashSet<LeadFiltering>();
            SmsBodyInStatusAndLabguage = new HashSet<SmsBodyInStatusAndLabguage>();
        }

        public int LeadStatusId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int LeadStatusGroupId { get; set; }
        public bool IsDefault { get; set; }
        public bool IsActive { get; set; }

        public LeadStatusGroups LeadStatusGroup { get; set; }
        public ICollection<LeadFiltering> LeadFiltering { get; set; }
        public ICollection<SmsBodyInStatusAndLabguage> SmsBodyInStatusAndLabguage { get; set; }
    }
}
