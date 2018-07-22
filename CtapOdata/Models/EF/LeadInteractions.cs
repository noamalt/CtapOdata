using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class LeadInteractions
    {
        public int LeadInteractionId { get; set; }
        public int LeadId { get; set; }
        public int LeadInteractionTypeId { get; set; }
        public int? UserId { get; set; }
        public bool IsStatusChanged { get; set; }
        public int? LeadStatusId { get; set; }
        public DateTime DateEntered { get; set; }
        public string Comments { get; set; }
        public bool IsSchedual { get; set; }
        public DateTime? SchedualDate { get; set; }
        public bool? NoAnswer { get; set; }
    }
}
