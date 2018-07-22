using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class RepositoryLeadInteractions
    {
        public int Id { get; set; }
        public int LeadInteractionId { get; set; }
        public bool IsStatusChanged { get; set; }
        public DateTime DateEntered { get; set; }
        public string Comments { get; set; }
        public int? LeadStatusId { get; set; }
        public string LeadStatusName { get; set; }
        public int? LeadStatusGroupId { get; set; }
        public string LeadStatusGroupName { get; set; }
        public int LeadInteractionTypeId { get; set; }
        public string LeadInteractionTypeName { get; set; }
        public int? UserId { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int LeadId { get; set; }
        public bool IsSchedual { get; set; }
        public DateTime? SchedualDate { get; set; }
        public bool? IsForexTrader { get; set; }
        public bool? IsGeneralTrader { get; set; }
        public bool? IsMale { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool? NoAnswer { get; set; }
    }
}
