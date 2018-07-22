using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class LeadDocumentTypes
    {
        public LeadDocumentTypes()
        {
            LeadAssignments = new HashSet<LeadAssignments>();
            LeadDocuments = new HashSet<LeadDocuments>();
        }

        public int LeadDocumentTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<LeadAssignments> LeadAssignments { get; set; }
        public ICollection<LeadDocuments> LeadDocuments { get; set; }
    }
}
