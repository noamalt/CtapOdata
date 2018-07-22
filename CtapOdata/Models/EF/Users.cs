using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class Users
    {
        public Users()
        {
            AlertsReporter = new HashSet<Alerts>();
            AlertsUser = new HashSet<Alerts>();
            HrUsersMapping = new HashSet<HrUsersMapping>();
            LeadFiltering = new HashSet<LeadFiltering>();
            ScheduleTasks = new HashSet<ScheduleTasks>();
            SubCampaigns = new HashSet<SubCampaigns>();
            UsersInAccountEvents = new HashSet<UsersInAccountEvents>();
            UsersInDesks = new HashSet<UsersInDesks>();
            UsersInOffices = new HashSet<UsersInOffices>();
            UsersInRoles = new HashSet<UsersInRoles>();
            UsersProfilesMapping = new HashSet<UsersProfilesMapping>();
        }

        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PasswordQuestion { get; set; }
        public string PasswordAnswer { get; set; }
        public bool IsOnline { get; set; }
        public DateTime DateCreated { get; set; }
        public bool? IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public string UserRank { get; set; }
        public int? UserFtdcount { get; set; }
        public int? UserFtdamount { get; set; }
        public DateTime? DateModified { get; set; }

        public ICollection<Alerts> AlertsReporter { get; set; }
        public ICollection<Alerts> AlertsUser { get; set; }
        public ICollection<HrUsersMapping> HrUsersMapping { get; set; }
        public ICollection<LeadFiltering> LeadFiltering { get; set; }
        public ICollection<ScheduleTasks> ScheduleTasks { get; set; }
        public ICollection<SubCampaigns> SubCampaigns { get; set; }
        public ICollection<UsersInAccountEvents> UsersInAccountEvents { get; set; }
        public ICollection<UsersInDesks> UsersInDesks { get; set; }
        public ICollection<UsersInOffices> UsersInOffices { get; set; }
        public ICollection<UsersInRoles> UsersInRoles { get; set; }
        public ICollection<UsersProfilesMapping> UsersProfilesMapping { get; set; }
    }
}
