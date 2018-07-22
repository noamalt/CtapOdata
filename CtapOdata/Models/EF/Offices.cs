using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class Offices
    {
        public Offices()
        {
            AccountTypeRanking = new HashSet<AccountTypeRanking>();
            Campaigns = new HashSet<Campaigns>();
            DepositProviderSettings = new HashSet<DepositProviderSettings>();
            DepositProvidersPriorities = new HashSet<DepositProvidersPriorities>();
            Desks = new HashSet<Desks>();
            LandingPageInstances = new HashSet<LandingPageInstances>();
            LeadFiltering = new HashSet<LeadFiltering>();
            UsersInOffices = new HashSet<UsersInOffices>();
            Visits = new HashSet<Visits>();
        }

        public int OfficeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsDefault { get; set; }
        public int MailServerId { get; set; }
        public bool? IsActive { get; set; }
        public int CashierTypeId { get; set; }
        public bool? Regulated { get; set; }

        public MailServersInformation MailServer { get; set; }
        public ICollection<AccountTypeRanking> AccountTypeRanking { get; set; }
        public ICollection<Campaigns> Campaigns { get; set; }
        public ICollection<DepositProviderSettings> DepositProviderSettings { get; set; }
        public ICollection<DepositProvidersPriorities> DepositProvidersPriorities { get; set; }
        public ICollection<Desks> Desks { get; set; }
        public ICollection<LandingPageInstances> LandingPageInstances { get; set; }
        public ICollection<LeadFiltering> LeadFiltering { get; set; }
        public ICollection<UsersInOffices> UsersInOffices { get; set; }
        public ICollection<Visits> Visits { get; set; }
    }
}
