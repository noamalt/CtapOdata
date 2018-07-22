using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class LeadAssignments
    {
        public int LeadAssignmentId { get; set; }
        public int LeadId { get; set; }
        public int? AssignedByUserId { get; set; }
        public int? AssignedToUserId { get; set; }
        public int AssignedToDeskId { get; set; }
        public DateTime DateEntered { get; set; }
        public int LeadAssignmentTypeId { get; set; }
        public int? OfficeId { get; set; }

        public Desks AssignedToDesk { get; set; }
        public LeadDocumentTypes LeadAssignmentType { get; set; }
    }
}
