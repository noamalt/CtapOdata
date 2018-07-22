using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class Desks
    {
        public Desks()
        {
            Languages = new HashSet<Languages>();
            LeadAssignments = new HashSet<LeadAssignments>();
            LeadFiltering = new HashSet<LeadFiltering>();
            Placements = new HashSet<Placements>();
            UsersInDesks = new HashSet<UsersInDesks>();
        }

        public int DeskId { get; set; }
        public int OfficeId { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsDefault { get; set; }
        public int? LanguageId { get; set; }
        public DateTime? DateCreated { get; set; }

        public Offices Office { get; set; }
        public DesksTokens DesksTokens { get; set; }
        public ICollection<Languages> Languages { get; set; }
        public ICollection<LeadAssignments> LeadAssignments { get; set; }
        public ICollection<LeadFiltering> LeadFiltering { get; set; }
        public ICollection<Placements> Placements { get; set; }
        public ICollection<UsersInDesks> UsersInDesks { get; set; }
    }
}
