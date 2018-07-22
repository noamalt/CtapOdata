using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CtapOdata.Models.EF
{
    public partial class CRM3Context : DbContext
    {
        public CRM3Context()
        {
        }

        public CRM3Context(DbContextOptions<CRM3Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountArchive> AccountArchive { get; set; }
        public virtual DbSet<AccountEvents> AccountEvents { get; set; }
        public virtual DbSet<AccountEventsAssignmentCorrections> AccountEventsAssignmentCorrections { get; set; }
        public virtual DbSet<AccountEventsBalanceCorrections> AccountEventsBalanceCorrections { get; set; }
        public virtual DbSet<AccountEventTypes> AccountEventTypes { get; set; }
        public virtual DbSet<Accounts> Accounts { get; set; }
        public virtual DbSet<AccountTokens> AccountTokens { get; set; }
        public virtual DbSet<AccountTokenTypes> AccountTokenTypes { get; set; }
        public virtual DbSet<AccountTypeRanking> AccountTypeRanking { get; set; }
        public virtual DbSet<AccountTypes> AccountTypes { get; set; }
        public virtual DbSet<Alerts> Alerts { get; set; }
        public virtual DbSet<AllowedIpaddresses> AllowedIpaddresses { get; set; }
        public virtual DbSet<Answers> Answers { get; set; }
        public virtual DbSet<Apierrors> Apierrors { get; set; }
        public virtual DbSet<Banks> Banks { get; set; }
        public virtual DbSet<Banners> Banners { get; set; }
        public virtual DbSet<BannersInPlacement> BannersInPlacement { get; set; }
        public virtual DbSet<BannerSizes> BannerSizes { get; set; }
        public virtual DbSet<BridgeFailureLog> BridgeFailureLog { get; set; }
        public virtual DbSet<CallToActionProviders> CallToActionProviders { get; set; }
        public virtual DbSet<CampaignPaymentTerms> CampaignPaymentTerms { get; set; }
        public virtual DbSet<Campaigns> Campaigns { get; set; }
        public virtual DbSet<CampaignTypes> CampaignTypes { get; set; }
        public virtual DbSet<CashierSettings> CashierSettings { get; set; }
        public virtual DbSet<CashierTypes> CashierTypes { get; set; }
        public virtual DbSet<ComplianceInAccountEvents> ComplianceInAccountEvents { get; set; }
        public virtual DbSet<ComplianceRejectionReason> ComplianceRejectionReason { get; set; }
        public virtual DbSet<Compliances> Compliances { get; set; }
        public virtual DbSet<CompliancesInLeads> CompliancesInLeads { get; set; }
        public virtual DbSet<ComplianceStatus> ComplianceStatus { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<CountryGroups> CountryGroups { get; set; }
        public virtual DbSet<Cultures> Cultures { get; set; }
        public virtual DbSet<Currencies> Currencies { get; set; }
        public virtual DbSet<DefaultDeskByLanguageMapping> DefaultDeskByLanguageMapping { get; set; }
        public virtual DbSet<DeploymentMetadata> DeploymentMetadata { get; set; }
        public virtual DbSet<DepositProviders> DepositProviders { get; set; }
        public virtual DbSet<DepositProviderSettings> DepositProviderSettings { get; set; }
        public virtual DbSet<DepositProvidersInPayCards> DepositProvidersInPayCards { get; set; }
        public virtual DbSet<DepositProvidersPriorities> DepositProvidersPriorities { get; set; }
        public virtual DbSet<DepositTypes> DepositTypes { get; set; }
        public virtual DbSet<Desks> Desks { get; set; }
        public virtual DbSet<DesksTokens> DesksTokens { get; set; }
        public virtual DbSet<EmailPromotionActions> EmailPromotionActions { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<FinancialAccountTypes> FinancialAccountTypes { get; set; }
        public virtual DbSet<FinancialAccountTypesAssignments> FinancialAccountTypesAssignments { get; set; }
        public virtual DbSet<FinancialAccountTypesRankingAudit> FinancialAccountTypesRankingAudit { get; set; }
        public virtual DbSet<FormActionType> FormActionType { get; set; }
        public virtual DbSet<Forms> Forms { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<HealthCheckUsers> HealthCheckUsers { get; set; }
        public virtual DbSet<HotLeadsRules> HotLeadsRules { get; set; }
        public virtual DbSet<HrDepartments> HrDepartments { get; set; }
        public virtual DbSet<HrDepartmentTypes> HrDepartmentTypes { get; set; }
        public virtual DbSet<HrDepartmentTypesMapping> HrDepartmentTypesMapping { get; set; }
        public virtual DbSet<HrLocations> HrLocations { get; set; }
        public virtual DbSet<HrTargetRules> HrTargetRules { get; set; }
        public virtual DbSet<HrTargetRulesMapping> HrTargetRulesMapping { get; set; }
        public virtual DbSet<HrTargetRulesTypes> HrTargetRulesTypes { get; set; }
        public virtual DbSet<HrUsers> HrUsers { get; set; }
        public virtual DbSet<HrUsersMapping> HrUsersMapping { get; set; }
        public virtual DbSet<Impressions> Impressions { get; set; }
        public virtual DbSet<InterfaceLanguage> InterfaceLanguage { get; set; }
        public virtual DbSet<Ip2country> Ip2country { get; set; }
        public virtual DbSet<Ip2countryOld> Ip2countryOld { get; set; }
        public virtual DbSet<LandingPageInstances> LandingPageInstances { get; set; }
        public virtual DbSet<LandingPages> LandingPages { get; set; }
        public virtual DbSet<Languages> Languages { get; set; }
        public virtual DbSet<LaverateErrorLog> LaverateErrorLog { get; set; }
        public virtual DbSet<LeadAssignments> LeadAssignments { get; set; }
        public virtual DbSet<LeadAssignmentTypes> LeadAssignmentTypes { get; set; }
        public virtual DbSet<LeadDocuments> LeadDocuments { get; set; }
        public virtual DbSet<LeadDocumentTypes> LeadDocumentTypes { get; set; }
        public virtual DbSet<LeadExtendedColumnMapping> LeadExtendedColumnMapping { get; set; }
        public virtual DbSet<LeadExtendedData> LeadExtendedData { get; set; }
        public virtual DbSet<LeadExtendedDataColumns> LeadExtendedDataColumns { get; set; }
        public virtual DbSet<LeadFiltering> LeadFiltering { get; set; }
        public virtual DbSet<LeadImportSeries> LeadImportSeries { get; set; }
        public virtual DbSet<LeadImportTempEmails> LeadImportTempEmails { get; set; }
        public virtual DbSet<LeadInfo> LeadInfo { get; set; }
        public virtual DbSet<LeadInteractions> LeadInteractions { get; set; }
        public virtual DbSet<LeadInteractionTypes> LeadInteractionTypes { get; set; }
        public virtual DbSet<LeadMarketingAffiliates> LeadMarketingAffiliates { get; set; }
        public virtual DbSet<LeadMarketingAffiliateSources> LeadMarketingAffiliateSources { get; set; }
        public virtual DbSet<LeadMarketingParameters> LeadMarketingParameters { get; set; }
        public virtual DbSet<LeadPersonalDetails> LeadPersonalDetails { get; set; }
        public virtual DbSet<LeadProviderMarketingToolsType> LeadProviderMarketingToolsType { get; set; }
        public virtual DbSet<LeadProviderPlanTypes> LeadProviderPlanTypes { get; set; }
        public virtual DbSet<LeadProviders> LeadProviders { get; set; }
        public virtual DbSet<LeadProvidersPaymentsHistory> LeadProvidersPaymentsHistory { get; set; }
        public virtual DbSet<LeadRanks> LeadRanks { get; set; }
        public virtual DbSet<LeadRetentionScores> LeadRetentionScores { get; set; }
        public virtual DbSet<LeadRetentionScoresBidata> LeadRetentionScoresBidata { get; set; }
        public virtual DbSet<Leads> Leads { get; set; }
        public virtual DbSet<LeadsImportHistory> LeadsImportHistory { get; set; }
        public virtual DbSet<LeadStatuses> LeadStatuses { get; set; }
        public virtual DbSet<LeadStatusGroups> LeadStatusGroups { get; set; }
        public virtual DbSet<LeadValidationStatuses> LeadValidationStatuses { get; set; }
        public virtual DbSet<LiveKashCards> LiveKashCards { get; set; }
        public virtual DbSet<MailSenders> MailSenders { get; set; }
        public virtual DbSet<MailServersInformation> MailServersInformation { get; set; }
        public virtual DbSet<MailSubjects> MailSubjects { get; set; }
        public virtual DbSet<MailTemplates> MailTemplates { get; set; }
        public virtual DbSet<MeetingStatus> MeetingStatus { get; set; }
        public virtual DbSet<MetatraderLeverage> MetatraderLeverage { get; set; }
        public virtual DbSet<Nationalities> Nationalities { get; set; }
        public virtual DbSet<Numbers> Numbers { get; set; }
        public virtual DbSet<Offices> Offices { get; set; }
        public virtual DbSet<PageVisits> PageVisits { get; set; }
        public virtual DbSet<PayCards> PayCards { get; set; }
        public virtual DbSet<PaymentStatuses> PaymentStatuses { get; set; }
        public virtual DbSet<PaymentTypes> PaymentTypes { get; set; }
        public virtual DbSet<Pixels> Pixels { get; set; }
        public virtual DbSet<Placements> Placements { get; set; }
        public virtual DbSet<PlatformGroups> PlatformGroups { get; set; }
        public virtual DbSet<Platforms> Platforms { get; set; }
        public virtual DbSet<PlatformTypes> PlatformTypes { get; set; }
        public virtual DbSet<Priority> Priority { get; set; }
        public virtual DbSet<ProfilesRolesMapping> ProfilesRolesMapping { get; set; }
        public virtual DbSet<PromotionalEmails> PromotionalEmails { get; set; }
        public virtual DbSet<Questionnaires> Questionnaires { get; set; }
        public virtual DbSet<QuestionnairesTypes> QuestionnairesTypes { get; set; }
        public virtual DbSet<Questions> Questions { get; set; }
        public virtual DbSet<RegulatedCountries> RegulatedCountries { get; set; }
        public virtual DbSet<RegulationQuestionnaireAnswers> RegulationQuestionnaireAnswers { get; set; }
        public virtual DbSet<RegulationQuestions> RegulationQuestions { get; set; }
        public virtual DbSet<Reminder> Reminder { get; set; }
        public virtual DbSet<ReportsLeadInteractions> ReportsLeadInteractions { get; set; }
        public virtual DbSet<RepositoryLeadInteractions> RepositoryLeadInteractions { get; set; }
        public virtual DbSet<RetentionScores> RetentionScores { get; set; }
        public virtual DbSet<RoleGroups> RoleGroups { get; set; }
        public virtual DbSet<RoleProfiles> RoleProfiles { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<ScheduleTasks> ScheduleTasks { get; set; }
        public virtual DbSet<Skins> Skins { get; set; }
        public virtual DbSet<SmsBodyInStatusAndLabguage> SmsBodyInStatusAndLabguage { get; set; }
        public virtual DbSet<SmsTemplates> SmsTemplates { get; set; }
        public virtual DbSet<SubCampaigns> SubCampaigns { get; set; }
        public virtual DbSet<Tasks> Tasks { get; set; }
        public virtual DbSet<Trackers> Trackers { get; set; }
        public virtual DbSet<UserInTeamLeader> UserInTeamLeader { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersCampaignsMapping> UsersCampaignsMapping { get; set; }
        public virtual DbSet<UsersInAccountEvents> UsersInAccountEvents { get; set; }
        public virtual DbSet<UsersInDesks> UsersInDesks { get; set; }
        public virtual DbSet<UsersInOffices> UsersInOffices { get; set; }
        public virtual DbSet<UsersInRoles> UsersInRoles { get; set; }
        public virtual DbSet<UsersLogin> UsersLogin { get; set; }
        public virtual DbSet<UsersProfilesMapping> UsersProfilesMapping { get; set; }
        public virtual DbSet<UtmCampaigns> UtmCampaigns { get; set; }
        public virtual DbSet<UtmSubCampaignCampaignMapping> UtmSubCampaignCampaignMapping { get; set; }
        public virtual DbSet<UtmSubCampaigns> UtmSubCampaigns { get; set; }
        public virtual DbSet<Visits> Visits { get; set; }
        public virtual DbSet<WithdrawalRequest> WithdrawalRequest { get; set; }
        public virtual DbSet<XmlwithOpenXml> XmlwithOpenXml { get; set; }

        // Unable to generate entity type for table 'dbo.PlacementBudget'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Pushed_Event_q'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Multilingual'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.mt4_prices'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DashboardDefinitions'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DuplicatesLeads'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RepositoryLeadsData'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Lead_ImportBulk'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SearchTMP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Lead_ImportBulk_Failed'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RepositoryLeadsData_21072016'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LeadSummeryList'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.crossOfficeDeskConnections'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ExculdedInteractionTypes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TempLogCreatePayout'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Comments'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Log'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ManagedDesks'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.temp_logdf'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DepositProvidersVerification'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DepositLimitations'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.country2group'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tempUsers'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpLeadMarketing'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Office_Status'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AccountsPayCardsProviders'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LeadExtraDetails'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpTable'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LeadExtendedInformation'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.temp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AccountInEncryptCards'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DepositRequests'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LeadsAssign_IG'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LevareteTemp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.User_InterfaceLanguage'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.leadstmp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PlacementInQuestions'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.HR_Employee'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FXCurrencies'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AllStrings'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.mt4_prices_temp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FilteredLeadsTrace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BlockedCountries'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BI_rowData'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("data source=devsrv\\devsql;initial catalog=CRM3;persist security info=True;user id=cm;password=Central_14;multipleactiveresultsets=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountArchive>(entity =>
            {
                entity.HasKey(e => e.ArchiveId);

                entity.ToTable("Account_Archive");

                entity.Property(e => e.ArchiveId).HasColumnName("ArchiveID");

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.Property(e => e.AccountTypeResetDate).HasColumnType("datetime");

                entity.Property(e => e.ArchiveAccountId).HasColumnName("ArchiveAccountID");

                entity.Property(e => e.DateArchived).HasColumnType("datetime");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.Dfaccount).HasColumnName("DFAccount");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.IsTest).HasColumnName("isTest");

                entity.Property(e => e.LeadId).HasColumnName("LeadID");

                entity.Property(e => e.OfficeId).HasColumnName("OfficeID");

                entity.Property(e => e.PlatformId).HasColumnName("PlatformID");

                entity.Property(e => e.TradingGroup).HasMaxLength(50);

                entity.Property(e => e.UserPassword).HasMaxLength(50);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.ArchiveAccount)
                    .WithMany(p => p.AccountArchive)
                    .HasForeignKey(d => d.ArchiveAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Accounts_Archive_Account_accountid");
            });

            modelBuilder.Entity<AccountEvents>(entity =>
            {
                entity.HasKey(e => e.AccountEventId);

                entity.HasIndex(e => new { e.AccountEventId, e.UserId })
                    .HasName("MX6__UserID_INCL_AccountEventID");

                entity.HasIndex(e => new { e.CurrencyId, e.TotalUsdsum })
                    .HasName("MX4_AccountEvents");

                entity.HasIndex(e => new { e.TransactionId, e.DepositProviderId })
                    .HasName("MX5_TransactionID");

                entity.HasIndex(e => new { e.AccountEventId, e.AccountId, e.AccountEventTypeId, e.IsSuccessful })
                    .HasName("MX1_AccountEvents");

                entity.HasIndex(e => new { e.AccountEventId, e.CurrencyId, e.TotalUsdsum, e.IsSuccessful, e.OrderReference })
                    .HasName("MX7_OrderReference_INCL");

                entity.HasIndex(e => new { e.AccountId, e.TotalUsdsum, e.AccountEventTypeId, e.IsSuccessful, e.IsOpening, e.EventDate })
                    .HasName("MX3");

                entity.HasIndex(e => new { e.AccountId, e.TotalUsdsum, e.IsSuccessful, e.IsOpening, e.UserId, e.EventDate })
                    .HasName("MX2");

                entity.Property(e => e.AccountEventId).HasColumnName("AccountEventID");

                entity.Property(e => e.AccountEventTypeId).HasColumnName("AccountEventTypeID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.BankName).HasMaxLength(50);

                entity.Property(e => e.BranchNumber).HasMaxLength(50);

                entity.Property(e => e.CashierTypeId)
                    .HasColumnName("CashierTypeID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Comments).HasMaxLength(250);

                entity.Property(e => e.CoversionRate)
                    .HasColumnName("coversionRate")
                    .HasColumnType("decimal(19, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("CurrencyID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DepositProviderId).HasColumnName("DepositProviderID");

                entity.Property(e => e.DepositTypeId).HasColumnName("DepositTypeID");

                entity.Property(e => e.EventDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ibancode)
                    .HasColumnName("IBANCode")
                    .HasMaxLength(50);

                entity.Property(e => e.Is3Ds).HasColumnName("Is3DS");

                entity.Property(e => e.IsCompliance).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPending).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsRisk).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mtcn)
                    .HasColumnName("MTCN")
                    .HasMaxLength(50);

                entity.Property(e => e.OrderReference).HasMaxLength(50);

                entity.Property(e => e.PayCardDigits)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'n/a')");

                entity.Property(e => e.PayCardId).HasColumnName("PayCardID");

                entity.Property(e => e.ReceivedAmount)
                    .HasColumnType("decimal(19, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReceivedAmountCurrencyId).HasColumnName("ReceivedAmountCurrencyID");

                entity.Property(e => e.SentAmount)
                    .HasColumnType("decimal(19, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SentAmountCurrencyId).HasColumnName("SentAmountCurrencyID");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("((0))");

                entity.Property(e => e.Swiftcode)
                    .HasColumnName("SWIFTCode")
                    .HasMaxLength(50);

                entity.Property(e => e.TotalSum).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.TotalUsdsum)
                    .HasColumnName("TotalUSDSum")
                    .HasColumnType("decimal(19, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(250);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasDefaultValueSql("((139))");
            });

            modelBuilder.Entity<AccountEventsAssignmentCorrections>(entity =>
            {
                entity.HasKey(e => e.RowId);

                entity.ToTable("AccountEvents_AssignmentCorrections");

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.AccountEventId).HasColumnName("AccountEventID");

                entity.Property(e => e.Action).HasMaxLength(50);

                entity.Property(e => e.AuditUser).HasMaxLength(50);

                entity.Property(e => e.Comment).HasMaxLength(100);

                entity.Property(e => e.TimeStamp).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<AccountEventsBalanceCorrections>(entity =>
            {
                entity.HasKey(e => e.RowId);

                entity.ToTable("AccountEvents_BalanceCorrections");

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.AccountEventId).HasColumnName("AccountEventID");

                entity.Property(e => e.Action).HasMaxLength(50);

                entity.Property(e => e.AuditUser).HasMaxLength(50);

                entity.Property(e => e.BcaccountEventId).HasColumnName("BCAccountEventID");

                entity.Property(e => e.Reason).HasMaxLength(100);

                entity.Property(e => e.Sum).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TimeStamp).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<AccountEventTypes>(entity =>
            {
                entity.HasKey(e => e.AccountEventTypeId);

                entity.Property(e => e.AccountEventTypeId).HasColumnName("AccountEventTypeID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Accounts>(entity =>
            {
                entity.HasKey(e => e.AccountId);

                entity.HasIndex(e => e.Username)
                    .HasName("IX_AccountsUsername");

                entity.HasIndex(e => new { e.AccountId, e.LeadId })
                    .HasName("IDX_Accounts_LeadID_AccountID");

                entity.HasIndex(e => new { e.OfficeId, e.Email })
                    .HasName("MX2_OfficeID_Email");

                entity.HasIndex(e => new { e.UserPassword, e.Email })
                    .HasName("MX1_UserPassword_Email");

                entity.HasIndex(e => new { e.LeadId, e.Username, e.DateEntered })
                    .HasName("MX3_DateEntered_INCL_LeadID_Username");

                entity.HasIndex(e => new { e.Username, e.LeadId, e.AccountId })
                    .HasName("IX_Accounts_user")
                    .IsUnique();

                entity.HasIndex(e => new { e.AccountId, e.LeadId, e.IsReal, e.IsTest })
                    .HasName("MX4_IsReal_isTest_INCL");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AccountTypeId)
                    .HasColumnName("AccountTypeID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AccountTypeResetDate).HasColumnType("datetime");

                entity.Property(e => e.DateEntered)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dfaccount)
                    .HasColumnName("DFAccount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EnableCreditCardSave).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsAdvancedTrader).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsReal)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsReturn).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsTest)
                    .HasColumnName("isTest")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LeadId).HasColumnName("LeadID");

                entity.Property(e => e.OfficeId)
                    .HasColumnName("OfficeID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PlatformId).HasColumnName("PlatformID");

                entity.Property(e => e.TradingGroup)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'HFV-REG')");

                entity.Property(e => e.UserPassword).HasMaxLength(50);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AccountTokens>(entity =>
            {
                entity.HasKey(e => e.AccountTokenId);

                entity.HasIndex(e => e.AccountId)
                    .HasName("MX1_AccountID");

                entity.Property(e => e.AccountTokenId)
                    .HasColumnName("AccountTokenID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AccountTokenTypeId).HasColumnName("AccountTokenTypeID");

                entity.Property(e => e.DateEntered).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountTokens)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountTokens_Accounts");

                entity.HasOne(d => d.AccountTokenType)
                    .WithMany(p => p.AccountTokens)
                    .HasForeignKey(d => d.AccountTokenTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountTokens_AccountTokenTypes");
            });

            modelBuilder.Entity<AccountTokenTypes>(entity =>
            {
                entity.HasKey(e => e.AccountTokenTypeId);

                entity.Property(e => e.AccountTokenTypeId).HasColumnName("AccountTokenTypeID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AccountTypeRanking>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.FromAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OfficeId).HasColumnName("OfficeID");

                entity.HasOne(d => d.AccountType)
                    .WithMany(p => p.AccountTypeRanking)
                    .HasForeignKey(d => d.AccountTypeId)
                    .HasConstraintName("FK_AccountTypeRanking_AccountTypes");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.AccountTypeRanking)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_AccountTypeRanking_Currencies");

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.AccountTypeRanking)
                    .HasForeignKey(d => d.OfficeId)
                    .HasConstraintName("FK_AccountTypeRanking_Offices");
            });

            modelBuilder.Entity<AccountTypes>(entity =>
            {
                entity.HasKey(e => e.AccountTypeId);

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.Property(e => e.AccountTypeName)
                    .IsRequired()
                    .HasColumnName("Account_Type_Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Alerts>(entity =>
            {
                entity.HasKey(e => e.AlertId);

                entity.HasIndex(e => new { e.AlertId, e.AlertBody, e.AlertDate, e.ReporterId, e.LeadId, e.UserId, e.AlertTypeId, e.IsRead })
                    .HasName("MX1_UserID_AlertTypeID_IsRead_INCL");

                entity.Property(e => e.AlertId).HasColumnName("AlertID");

                entity.Property(e => e.AlertBody)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.AlertTypeId)
                    .HasColumnName("AlertTypeID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsRead).HasDefaultValueSql("((0))");

                entity.Property(e => e.LeadId).HasColumnName("LeadID");

                entity.Property(e => e.ReporterId).HasColumnName("ReporterID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Lead)
                    .WithMany(p => p.Alerts)
                    .HasForeignKey(d => d.LeadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Alerts_Leads");

                entity.HasOne(d => d.Reporter)
                    .WithMany(p => p.AlertsReporter)
                    .HasForeignKey(d => d.ReporterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Alerts_Users");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AlertsUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Alerts_Users1");
            });

            modelBuilder.Entity<AllowedIpaddresses>(entity =>
            {
                entity.HasKey(e => e.IpAddress);

                entity.ToTable("AllowedIPAddresses");

                entity.Property(e => e.IpAddress)
                    .HasColumnName("IP_Address")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Answers>(entity =>
            {
                entity.HasKey(e => e.AnswerId);

                entity.HasIndex(e => e.QuestionId)
                    .HasName("Idx_QuestionID")
                    .IsUnique()
                    .HasFilter("([IsDefault]=(1))");

                entity.HasIndex(e => new { e.Body, e.QuestionId })
                    .HasName("BodyCONSTRAINT")
                    .IsUnique();

                entity.Property(e => e.Body)
                    .IsRequired()
                    .HasMaxLength(700);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Question)
                    .WithOne(p => p.Answers)
                    .HasForeignKey<Answers>(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_question_answerID");
            });

            modelBuilder.Entity<Apierrors>(entity =>
            {
                entity.HasKey(e => e.RowId);

                entity.ToTable("APIErrors");

                entity.Property(e => e.RowId).HasColumnName("rowID");

                entity.Property(e => e.ErrorMessage).HasMaxLength(255);

                entity.Property(e => e.Language).HasMaxLength(255);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");
            });

            modelBuilder.Entity<Banks>(entity =>
            {
                entity.HasKey(e => e.BankId);

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Symbol)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Banners>(entity =>
            {
                entity.HasKey(e => e.BannerId);

                entity.Property(e => e.BannerId).HasColumnName("BannerID");

                entity.Property(e => e.BannerSizeId).HasColumnName("BannerSizeID");

                entity.Property(e => e.DefaultLandingPageId).HasColumnName("DefaultLandingPageID");

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.BannerSize)
                    .WithMany(p => p.Banners)
                    .HasForeignKey(d => d.BannerSizeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Banners_BannerSizes");

                entity.HasOne(d => d.DefaultLandingPage)
                    .WithMany(p => p.Banners)
                    .HasForeignKey(d => d.DefaultLandingPageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Banners_LandingPages");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.Banners)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Banners_Languages");
            });

            modelBuilder.Entity<BannersInPlacement>(entity =>
            {
                entity.HasKey(e => new { e.PlacementId, e.BannerId });

                entity.HasIndex(e => e.BannerId)
                    .HasName("IX_BannersInPlacement");

                entity.Property(e => e.PlacementId).HasColumnName("PlacementID");

                entity.Property(e => e.BannerId).HasColumnName("BannerID");

                entity.HasOne(d => d.Placement)
                    .WithMany(p => p.BannersInPlacement)
                    .HasForeignKey(d => d.PlacementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BannersInPlacement_Placements");
            });

            modelBuilder.Entity<BannerSizes>(entity =>
            {
                entity.HasKey(e => e.BannerSizeId);

                entity.Property(e => e.BannerSizeId).HasColumnName("BannerSizeID");
            });

            modelBuilder.Entity<BridgeFailureLog>(entity =>
            {
                entity.HasKey(e => e.EntryId);

                entity.ToTable("Bridge_failure_log", "Cashier");

                entity.Property(e => e.EntryId).HasColumnName("EntryID");

                entity.Property(e => e.ErrorMessage).HasMaxLength(4000);

                entity.Property(e => e.ErrorProcedure).HasMaxLength(128);

                entity.Property(e => e.Timestamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<CallToActionProviders>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProviderDescription).HasMaxLength(250);

                entity.Property(e => e.ProviderName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProviderToken).HasMaxLength(50);
            });

            modelBuilder.Entity<CampaignPaymentTerms>(entity =>
            {
                entity.HasKey(e => e.CampaignPaymentTermId);

                entity.Property(e => e.CampaignPaymentTermId)
                    .HasColumnName("CampaignPaymentTermID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Campaigns>(entity =>
            {
                entity.HasKey(e => e.CampaignId);

                entity.Property(e => e.CampaignId).HasColumnName("CampaignID");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.LeadProviderId).HasColumnName("LeadProviderID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OfficeId).HasColumnName("OfficeID");

                entity.HasOne(d => d.LeadProvider)
                    .WithMany(p => p.Campaigns)
                    .HasForeignKey(d => d.LeadProviderId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Campaigns_LeadProviders");

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.Campaigns)
                    .HasForeignKey(d => d.OfficeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Campaigns_Offices");
            });

            modelBuilder.Entity<CampaignTypes>(entity =>
            {
                entity.HasKey(e => e.CampaignTypeId);

                entity.Property(e => e.CampaignTypeId)
                    .HasColumnName("CampaignTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CashierSettings>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CashierTypeId).HasColumnName("CashierTypeID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.OfficeId).HasColumnName("OfficeID");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Sportbook)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CashierTypes>(entity =>
            {
                entity.HasKey(e => e.CashierTypeId);

                entity.Property(e => e.CashierTypeId).HasColumnName("CashierTypeID");

                entity.Property(e => e.CashierTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'DmdCashier')");

                entity.Property(e => e.Url).HasMaxLength(100);
            });

            modelBuilder.Entity<ComplianceInAccountEvents>(entity =>
            {
                entity.HasKey(e => e.RowNumber);

                entity.Property(e => e.RowNumber).ValueGeneratedNever();

                entity.Property(e => e.AccountEventId).HasColumnName("AccountEventID");
            });

            modelBuilder.Entity<ComplianceRejectionReason>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Compliances>(entity =>
            {
                entity.HasKey(e => e.ComplianceId);

                entity.Property(e => e.ComplianceId).HasColumnName("ComplianceID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CompliancesInLeads>(entity =>
            {
                entity.Property(e => e.ComplianceCreationDate).HasColumnType("datetime");

                entity.Property(e => e.ComplianceModificationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ComplianceStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.DocumentTypeId).HasColumnName("DocumentTypeID");

                entity.Property(e => e.FileExtension).HasMaxLength(15);

                entity.Property(e => e.FileGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.FileName).HasMaxLength(50);

                entity.Property(e => e.LeadId).HasColumnName("LeadID");

                entity.Property(e => e.UserId).HasDefaultValueSql("((139))");
            });

            modelBuilder.Entity<ComplianceStatus>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<Countries>(entity =>
            {
                entity.HasKey(e => e.CountryId);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.Cngsymbol)
                    .HasColumnName("CNGSymbol")
                    .HasMaxLength(3);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LanguageCulture)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Mbsymbol)
                    .HasColumnName("MBSymbol")
                    .HasMaxLength(3);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PlatformId)
                    .HasColumnName("platformID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Symbol)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.TimeSpanName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Europe/Sofia')");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.Countries)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Countries_Languages");

                entity.HasOne(d => d.Platform)
                    .WithMany(p => p.Countries)
                    .HasForeignKey(d => d.PlatformId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Countries_Platforms");
            });

            modelBuilder.Entity<CountryGroups>(entity =>
            {
                entity.HasKey(e => e.CountryGroupId);

                entity.Property(e => e.CountryGroupId).HasColumnName("CountryGroupID");

                entity.Property(e => e.GroupName).HasMaxLength(50);

                entity.Property(e => e.Symbol).HasMaxLength(50);
            });

            modelBuilder.Entity<Cultures>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CultureCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LanguageName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Currencies>(entity =>
            {
                entity.HasKey(e => e.CurrencyId);

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Symbol)
                    .IsRequired()
                    .HasMaxLength(5);
            });

            modelBuilder.Entity<DefaultDeskByLanguageMapping>(entity =>
            {
                entity.HasKey(e => new { e.OfficeId, e.LanguageId, e.DefaultDeskId });

                entity.Property(e => e.OfficeId).HasColumnName("OfficeID");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.DefaultDeskId).HasColumnName("DefaultDeskID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LpDefaultDeskId).HasColumnName("LP_DefaultDeskID");
            });

            modelBuilder.Entity<DeploymentMetadata>(entity =>
            {
                entity.ToTable("DeploymentMetadata", "RedGateLocal");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.As)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.BlockId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.By)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("(original_login())");

                entity.Property(e => e.CompletedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertedSerial)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasDefaultValueSql("(@@dbts+(1))");

                entity.Property(e => e.MetadataVersion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedSerial)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.With)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("(app_name())");
            });

            modelBuilder.Entity<DepositProviders>(entity =>
            {
                entity.HasKey(e => e.DepositProviderId);

                entity.Property(e => e.DepositProviderId).HasColumnName("DepositProviderID");

                entity.Property(e => e.Ccurl)
                    .HasColumnName("CCUrl")
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Symbol)
                    .IsRequired()
                    .HasMaxLength(3);
            });

            modelBuilder.Entity<DepositProviderSettings>(entity =>
            {
                entity.HasKey(e => e.ProviderSettingId);

                entity.Property(e => e.ProviderSettingId).HasColumnName("ProviderSettingID");

                entity.Property(e => e.BrandId)
                    .HasColumnName("BrandID")
                    .HasMaxLength(250);

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.DepositProviderId)
                    .HasColumnName("DepositProviderID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ExtSecret)
                    .HasColumnName("Ext_Secret")
                    .HasMaxLength(250);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MerchantId)
                    .IsRequired()
                    .HasColumnName("MerchantID")
                    .HasMaxLength(250);

                entity.Property(e => e.OfficeId).HasColumnName("OfficeID");

                entity.Property(e => e.Password).HasMaxLength(250);

                entity.Property(e => e.PaymentMethodId)
                    .HasColumnName("PaymentMethodID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SettingName).HasMaxLength(250);

                entity.Property(e => e.StoreId)
                    .HasColumnName("StoreID")
                    .HasMaxLength(250);

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.DepositProviderSettings)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepositProviderSetting_Currencies");

                entity.HasOne(d => d.DepositProvider)
                    .WithMany(p => p.DepositProviderSettings)
                    .HasForeignKey(d => d.DepositProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepositProviderSettings_DepositProviders");

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.DepositProviderSettings)
                    .HasForeignKey(d => d.OfficeId)
                    .HasConstraintName("FK_DepositProviderSettings_Offices");
            });

            modelBuilder.Entity<DepositProvidersInPayCards>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DepositProviderId).HasColumnName("DepositProviderID");

                entity.Property(e => e.PayCardId).HasColumnName("PayCardID");

                entity.HasOne(d => d.DepositProvider)
                    .WithMany(p => p.DepositProvidersInPayCards)
                    .HasForeignKey(d => d.DepositProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepositProvidersInPayCards_DepositProviders");

                entity.HasOne(d => d.PayCard)
                    .WithMany(p => p.DepositProvidersInPayCards)
                    .HasForeignKey(d => d.PayCardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepositProvidersInPayCards_PayCards");
            });

            modelBuilder.Entity<DepositProvidersPriorities>(entity =>
            {
                entity.HasKey(e => e.PriorityId);

                entity.Property(e => e.PriorityId).HasColumnName("PriorityID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.DepositProviderId).HasColumnName("DepositProviderID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.OfficeId).HasColumnName("OfficeID");

                entity.Property(e => e.Rank).HasMaxLength(50);

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.DepositProvidersPriorities)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_DepositProvidersPriorities_Currencies");

                entity.HasOne(d => d.DepositProvider)
                    .WithMany(p => p.DepositProvidersPriorities)
                    .HasForeignKey(d => d.DepositProviderId)
                    .HasConstraintName("FK_DepositProvidersPriorities_DepositProviders");

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.DepositProvidersPriorities)
                    .HasForeignKey(d => d.OfficeId)
                    .HasConstraintName("FK_DepositProvidersPriorities_Offices");
            });

            modelBuilder.Entity<DepositTypes>(entity =>
            {
                entity.HasKey(e => e.DepositTypeId);

                entity.Property(e => e.DepositTypeId).HasColumnName("DepositTypeID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Desks>(entity =>
            {
                entity.HasKey(e => e.DeskId);

                entity.Property(e => e.DeskId).HasColumnName("DeskID");

                entity.Property(e => e.DateCreated).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OfficeId).HasColumnName("OfficeID");

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.Desks)
                    .HasForeignKey(d => d.OfficeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Desks_Offices");
            });

            modelBuilder.Entity<DesksTokens>(entity =>
            {
                entity.HasKey(e => e.DeskId);

                entity.Property(e => e.DeskId)
                    .HasColumnName("DeskID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DeskToken)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.Desk)
                    .WithOne(p => p.DesksTokens)
                    .HasForeignKey<DesksTokens>(d => d.DeskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DesksTokens_Desks");
            });

            modelBuilder.Entity<EmailPromotionActions>(entity =>
            {
                entity.HasKey(e => e.EmailPromotionActionId);

                entity.Property(e => e.EmailPromotionActionId)
                    .HasColumnName("EmailPromotionActionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmailPromotionActionName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.EmailPromotionAction)
                    .WithOne(p => p.InverseEmailPromotionAction)
                    .HasForeignKey<EmailPromotionActions>(d => d.EmailPromotionActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmailPromotionActions_EmailPromotionActions");
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.ToTable("event");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Eventend)
                    .HasColumnName("eventend")
                    .HasColumnType("datetime");

                entity.Property(e => e.Eventstart)
                    .HasColumnName("eventstart")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Resource)
                    .HasColumnName("resource")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            modelBuilder.Entity<FinancialAccountTypes>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FinancialAccountTypeDescription).HasMaxLength(50);

                entity.Property(e => e.FinancialAccountTypeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<FinancialAccountTypesAssignments>(entity =>
            {
                entity.HasIndex(e => e.AccountId)
                    .HasName("MX1_AccountID");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FinancialAccountTypeId)
                    .HasColumnName("FinancialAccountTypeID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsModified).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.FinancialAccountTypesAssignments)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountsFinancialAccountTypes_Accounts");

                entity.HasOne(d => d.FinancialAccountType)
                    .WithMany(p => p.FinancialAccountTypesAssignments)
                    .HasForeignKey(d => d.FinancialAccountTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountsFinancialAccountTypes_AccountsFinancialAccountTypes");
            });

            modelBuilder.Entity<FinancialAccountTypesRankingAudit>(entity =>
            {
                entity.ToTable("FinancialAccountTypes_Ranking_Audit");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AuditUserId).HasColumnName("audit_UserID");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FromFinancialAccountTypeId).HasColumnName("from_FinancialAccountTypeID");

                entity.Property(e => e.ToFinancialAccountTypeId).HasColumnName("to_FinancialAccountTypeID");
            });

            modelBuilder.Entity<FormActionType>(entity =>
            {
                entity.Property(e => e.FormActionTypeId)
                    .HasColumnName("FormActionTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Forms>(entity =>
            {
                entity.HasKey(e => e.FormId);

                entity.HasIndex(e => e.Name)
                    .HasName("IX_Forms")
                    .IsUnique();

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Gender1)
                    .HasColumnName("Gender")
                    .HasMaxLength(50);

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("key")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HealthCheckUsers>(entity =>
            {
                entity.HasKey(e => e.Healthcheckuser);

                entity.ToTable("HealthCheck_Users");

                entity.Property(e => e.Healthcheckuser)
                    .HasColumnName("healthcheckuser")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Dateentered)
                    .HasColumnName("dateentered")
                    .HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HotLeadsRules>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CallToActionProvider).HasMaxLength(250);

                entity.Property(e => e.CampaignId).HasColumnName("CampaignID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.OfficeId).HasColumnName("OfficeID");

                entity.Property(e => e.Priority).HasDefaultValueSql("((0))");

                entity.Property(e => e.Source).HasMaxLength(250);
            });

            modelBuilder.Entity<HrDepartments>(entity =>
            {
                entity.HasKey(e => e.DepartmentId);

                entity.ToTable("HR_Departments");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DepartmentDescription).HasMaxLength(250);

                entity.Property(e => e.DepartmentManagerId).HasColumnName("DepartmentManagerID");

                entity.Property(e => e.DepartmentName).HasMaxLength(50);
            });

            modelBuilder.Entity<HrDepartmentTypes>(entity =>
            {
                entity.HasKey(e => e.DepartmentTypeId);

                entity.ToTable("HR_DepartmentTypes");

                entity.Property(e => e.DepartmentTypeId).HasColumnName("DepartmentTypeID");

                entity.Property(e => e.DepartmentTypeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<HrDepartmentTypesMapping>(entity =>
            {
                entity.ToTable("HR_DepartmentTypesMapping");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DepartmentTypeId).HasColumnName("DepartmentTypeID");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.HrDepartmentTypesMapping)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HR_DepartmentTypesMapping_HR_Departments");

                entity.HasOne(d => d.DepartmentType)
                    .WithMany(p => p.HrDepartmentTypesMapping)
                    .HasForeignKey(d => d.DepartmentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HR_DepartmentTypesMapping_HR_DepartmentTypes");
            });

            modelBuilder.Entity<HrLocations>(entity =>
            {
                entity.HasKey(e => e.LocationId);

                entity.ToTable("HR_Locations");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.Location).HasMaxLength(50);
            });

            modelBuilder.Entity<HrTargetRules>(entity =>
            {
                entity.HasKey(e => e.TargetRuleId);

                entity.ToTable("HR_TargetRules");

                entity.Property(e => e.TargetRuleId).HasColumnName("TargetRuleID");

                entity.Property(e => e.TargetRuleDescription).HasMaxLength(250);

                entity.Property(e => e.TargetRuleName).HasMaxLength(250);
            });

            modelBuilder.Entity<HrTargetRulesMapping>(entity =>
            {
                entity.ToTable("HR_TargetRulesMapping");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.HruserId).HasColumnName("HRUserID");

                entity.Property(e => e.TargetRuleId).HasColumnName("TargetRuleID");

                entity.Property(e => e.TargetRuleScopeId).HasColumnName("TargetRuleScopeID");

                entity.Property(e => e.TargetRuleTypeId).HasColumnName("TargetRuleTypeID");
            });

            modelBuilder.Entity<HrTargetRulesTypes>(entity =>
            {
                entity.HasKey(e => e.TargetRuleTypeId);

                entity.ToTable("HR_TargetRulesTypes");

                entity.Property(e => e.TargetRuleTypeId).HasColumnName("TargetRuleTypeID");

                entity.Property(e => e.TargetRuleTypeDescription).HasMaxLength(250);

                entity.Property(e => e.TargetRuleTypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<HrUsers>(entity =>
            {
                entity.HasKey(e => e.HruserId);

                entity.ToTable("HR_Users");

                entity.Property(e => e.HruserId).HasColumnName("HRUserID");

                entity.Property(e => e.BeginDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Ext).HasMaxLength(250);

                entity.Property(e => e.Fname)
                    .HasColumnName("FName")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'N/A')");

                entity.Property(e => e.Lname)
                    .HasColumnName("LName")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'N/A')");

                entity.Property(e => e.LocationId)
                    .HasColumnName("LocationID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.TeamLeaderId).HasColumnName("TeamLeaderID");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.HrUsers)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_HR_Users_HR_Departments");
            });

            modelBuilder.Entity<HrUsersMapping>(entity =>
            {
                entity.ToTable("HR_UsersMapping");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.HruserId).HasColumnName("HRUserID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.HrUsersMapping)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HR_UsersMapping_Users");
            });

            modelBuilder.Entity<Impressions>(entity =>
            {
                entity.HasKey(e => e.ImpressionId);

                entity.Property(e => e.ImpressionId).HasColumnName("ImpressionID");

                entity.Property(e => e.DateEntered)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TrackerId).HasColumnName("TrackerID");

                entity.HasOne(d => d.Tracker)
                    .WithMany(p => p.Impressions)
                    .HasForeignKey(d => d.TrackerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Impressions_Trackers");
            });

            modelBuilder.Entity<InterfaceLanguage>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LanguageId).HasColumnName("languageID");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.InterfaceLanguage)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("InterfaceLanguage_language");
            });

            modelBuilder.Entity<Ip2country>(entity =>
            {
                entity.ToTable("IP2Country");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CountrySymbol).HasMaxLength(3);

                entity.Property(e => e.Ipfrom)
                    .HasColumnName("IPFrom")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Ipto)
                    .HasColumnName("IPTo")
                    .HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<Ip2countryOld>(entity =>
            {
                entity.ToTable("IP2CountryOld");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CountrySymbol)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.Ipfrom)
                    .HasColumnName("IPFrom")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Ipto)
                    .HasColumnName("IPTo")
                    .HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<LandingPageInstances>(entity =>
            {
                entity.HasKey(e => e.LandingPageInstanceId);

                entity.HasIndex(e => new { e.LandingPageId, e.LanguageId })
                    .HasName("LandingPageInLanguagesCONSTRAIN")
                    .IsUnique();

                entity.Property(e => e.LandingPageInstanceId).HasColumnName("LandingPageInstance_ID");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Keywords).HasMaxLength(500);

                entity.Property(e => e.LandingPageId).HasColumnName("LandingPageID");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.HasOne(d => d.FormActionType)
                    .WithMany(p => p.LandingPageInstances)
                    .HasForeignKey(d => d.FormActionTypeId)
                    .HasConstraintName("FK_LandingPageInstances_FormActionType");

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.LandingPageInstances)
                    .HasForeignKey(d => d.FormId)
                    .HasConstraintName("FK_LandingPageInLanguages_Forms");

                entity.HasOne(d => d.LandingPage)
                    .WithMany(p => p.LandingPageInstances)
                    .HasForeignKey(d => d.LandingPageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LandingPageInLanguages_LandingPages");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.LandingPageInstances)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LandingPageInLanguages_LandingPageInLanguages");

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.LandingPageInstances)
                    .HasForeignKey(d => d.OfficeId)
                    .HasConstraintName("FK_LandingPageInLanguages_Offices");

                entity.HasOne(d => d.Skin)
                    .WithMany(p => p.LandingPageInstances)
                    .HasForeignKey(d => d.SkinId)
                    .HasConstraintName("FK_LandingPageInLanguages_Languages");
            });

            modelBuilder.Entity<LandingPages>(entity =>
            {
                entity.HasKey(e => e.LandingPageId);

                entity.Property(e => e.LandingPageId).HasColumnName("LandingPageID");

                entity.Property(e => e.CompletedTemplate)
                    .HasColumnName("Completed Template")
                    .HasMaxLength(200);

                entity.Property(e => e.LandingTemplate)
                    .HasColumnName("Landing Template")
                    .HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SnapshotFilePath)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Languages>(entity =>
            {
                entity.HasKey(e => e.LanguageId);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Culture)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeskId).HasColumnName("DeskID");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Desk)
                    .WithMany(p => p.Languages)
                    .HasForeignKey(d => d.DeskId)
                    .HasConstraintName("FK_Languages_Desks");
            });

            modelBuilder.Entity<LaverateErrorLog>(entity =>
            {
                entity.Property(e => e.ErrorDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<LeadAssignments>(entity =>
            {
                entity.HasKey(e => e.LeadAssignmentId);

                entity.HasIndex(e => new { e.LeadAssignmentId, e.AssignedToDeskId, e.AssignedToUserId, e.DateEntered, e.LeadId })
                    .HasName("IDX_LeadAssignments_LeadID_AssignedToDeskID");

                entity.Property(e => e.LeadAssignmentId).HasColumnName("LeadAssignmentID");

                entity.Property(e => e.AssignedByUserId).HasColumnName("AssignedByUserID");

                entity.Property(e => e.AssignedToDeskId).HasColumnName("AssignedToDeskID");

                entity.Property(e => e.AssignedToUserId).HasColumnName("AssignedToUserID");

                entity.Property(e => e.DateEntered).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LeadAssignmentTypeId).HasColumnName("LeadAssignmentTypeID");

                entity.Property(e => e.LeadId).HasColumnName("LeadID");

                entity.Property(e => e.OfficeId).HasColumnName("OfficeID");

                entity.HasOne(d => d.AssignedToDesk)
                    .WithMany(p => p.LeadAssignments)
                    .HasForeignKey(d => d.AssignedToDeskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LeadAssignments_Desks");

                entity.HasOne(d => d.LeadAssignmentType)
                    .WithMany(p => p.LeadAssignments)
                    .HasForeignKey(d => d.LeadAssignmentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LeadAssignments_LeadDocumentTypes");
            });

            modelBuilder.Entity<LeadAssignmentTypes>(entity =>
            {
                entity.HasKey(e => e.LeadAssignmentTypeId);

                entity.Property(e => e.LeadAssignmentTypeId).HasColumnName("LeadAssignmentTypeID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.LeadAssignmentTypes)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LeadAssignmentTypes_Roles");
            });

            modelBuilder.Entity<LeadDocuments>(entity =>
            {
                entity.HasKey(e => e.LeadDocumentId);

                entity.Property(e => e.LeadDocumentId).HasColumnName("LeadDocumentID");

                entity.Property(e => e.FileExtension)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.LeadDocumentTypeId).HasColumnName("LeadDocumentTypeID");

                entity.Property(e => e.LeadId).HasColumnName("LeadID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.LeadDocumentType)
                    .WithMany(p => p.LeadDocuments)
                    .HasForeignKey(d => d.LeadDocumentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LeadDocuments_LeadDocumentTypes");

                entity.HasOne(d => d.Lead)
                    .WithMany(p => p.LeadDocuments)
                    .HasForeignKey(d => d.LeadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LeadDocuments_Leads");
            });

            modelBuilder.Entity<LeadDocumentTypes>(entity =>
            {
                entity.HasKey(e => e.LeadDocumentTypeId);

                entity.Property(e => e.LeadDocumentTypeId).HasColumnName("LeadDocumentTypeID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LeadExtendedColumnMapping>(entity =>
            {
                entity.HasKey(e => new { e.OfficeId, e.Key });

                entity.ToTable("Lead_ExtendedColumnMapping");

                entity.Property(e => e.OfficeId).HasColumnName("OfficeID");

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .HasMaxLength(50);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<LeadExtendedData>(entity =>
            {
                entity.HasKey(e => new { e.LeadId, e.ColumnKey });

                entity.ToTable("Lead_ExtendedData");

                entity.Property(e => e.LeadId).HasColumnName("LeadID");

                entity.Property(e => e.ColumnKey)
                    .HasColumnName("column_key")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StringValue)
                    .HasColumnName("string_value")
                    .HasMaxLength(250);

                entity.Property(e => e.ValueId).HasColumnName("valueID");
            });

            modelBuilder.Entity<LeadExtendedDataColumns>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Key });

                entity.ToTable("Lead_ExtendedDataColumns");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .HasMaxLength(50);

                entity.Property(e => e.ColumnName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LeadFiltering>(entity =>
            {
                entity.Property(e => e.CurrentUserId).HasColumnName("CurrentUserID");

                entity.Property(e => e.FinancialRankTypeId).HasColumnName("FinancialRankTypeID");

                entity.Property(e => e.IncludeForThisUser).HasDefaultValueSql("((1))");

                entity.Property(e => e.LastDays).HasDefaultValueSql("((3))");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.LeadFiltering)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_LeadFiltering_Countries");

                entity.HasOne(d => d.CurrentUser)
                    .WithMany(p => p.LeadFiltering)
                    .HasForeignKey(d => d.CurrentUserId)
                    .HasConstraintName("FK_LeadFiltering_Users");

                entity.HasOne(d => d.Desk)
                    .WithMany(p => p.LeadFiltering)
                    .HasForeignKey(d => d.DeskId)
                    .HasConstraintName("FK_LeadFiltering_Desks");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.LeadFiltering)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("FK_LeadFiltering_Languages");

                entity.HasOne(d => d.LeadAssignmentType)
                    .WithMany(p => p.LeadFiltering)
                    .HasForeignKey(d => d.LeadAssignmentTypeId)
                    .HasConstraintName("FK_LeadFiltering_LeadAssignmentTypes");

                entity.HasOne(d => d.LeadStatus)
                    .WithMany(p => p.LeadFiltering)
                    .HasForeignKey(d => d.LeadStatusId)
                    .HasConstraintName("FK_LeadFiltering_LeadStatuses");

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.LeadFiltering)
                    .HasForeignKey(d => d.OfficeId)
                    .HasConstraintName("FK_LeadFiltering_Offices");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.LeadFiltering)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_LeadFiltering_Roles");

                entity.HasOne(d => d.SubCampaign)
                    .WithMany(p => p.LeadFiltering)
                    .HasForeignKey(d => d.SubCampaignId)
                    .HasConstraintName("FK_LeadFiltering_SubCampaigns");
            });

            modelBuilder.Entity<LeadImportSeries>(entity =>
            {
                entity.HasKey(e => e.LiSeriesId);

                entity.ToTable("Lead_ImportSeries");

                entity.Property(e => e.LiSeriesId).HasColumnName("LI_SeriesID");

                entity.Property(e => e.AuditUserId).HasColumnName("AuditUserID");

                entity.Property(e => e.CampaignId).HasColumnName("CampaignID");

                entity.Property(e => e.DeskId).HasColumnName("DeskID");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.OfficeId).HasColumnName("OfficeID");

                entity.Property(e => e.SubCampaignId).HasColumnName("SubCampaignID");

                entity.Property(e => e.TimeStamp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<LeadImportTempEmails>(entity =>
            {
                entity.ToTable("Lead_Import_TempEmails");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email).HasMaxLength(50);
            });

            modelBuilder.Entity<LeadInfo>(entity =>
            {
                entity.Property(e => e.LeadInfoId).HasColumnName("LeadInfoID");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.Address2).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.LeadId).HasColumnName("LeadID");

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.LeadInfo)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_LeadInfo_Countries");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.LeadInfo)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("FK_LeadInfo_Languages");

                entity.HasOne(d => d.Lead)
                    .WithMany(p => p.LeadInfo)
                    .HasForeignKey(d => d.LeadId)
                    .HasConstraintName("FK_LeadInfo_Leads");
            });

            modelBuilder.Entity<LeadInteractions>(entity =>
            {
                entity.HasKey(e => e.LeadInteractionId);

                entity.HasIndex(e => new { e.LeadId, e.IsStatusChanged })
                    .HasName("MX2_LeadID_IsStatusChanged");

                entity.HasIndex(e => new { e.LeadId, e.LeadInteractionId })
                    .HasName("_dta_index_LeadInteractions_29_1598628738__K2_K1");

                entity.HasIndex(e => new { e.LeadInteractionId, e.LeadStatusId, e.LeadId })
                    .HasName("IDX_LeadInteractions_LeadID_StatusID");

                entity.HasIndex(e => new { e.LeadId, e.LeadInteractionTypeId, e.UserId, e.DateEntered })
                    .HasName("MX1_LeadInteractionTypeID_UserID_DateEntered_INCL_LeadID");

                entity.Property(e => e.LeadInteractionId).HasColumnName("LeadInteractionID");

                entity.Property(e => e.DateEntered).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LeadId).HasColumnName("LeadID");

                entity.Property(e => e.LeadInteractionTypeId).HasColumnName("LeadInteractionTypeID");

                entity.Property(e => e.LeadStatusId).HasColumnName("LeadStatusID");

                entity.Property(e => e.NoAnswer).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<LeadInteractionTypes>(entity =>
            {
                entity.HasKey(e => e.LeadInteractionTypeId);

                entity.Property(e => e.LeadInteractionTypeId).HasColumnName("LeadInteractionTypeID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LeadMarketingAffiliates>(entity =>
            {
                entity.HasKey(e => new { e.AffiliateId, e.AffiliateName });

                entity.ToTable("LeadMarketing_Affiliates");

                entity.Property(e => e.AffiliateId).HasColumnName("AffiliateID");

                entity.Property(e => e.AffiliateName).HasMaxLength(50);

                entity.Property(e => e.DateEntered)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UtmCampaignId).HasColumnName("utm_campaignID");
            });

            modelBuilder.Entity<LeadMarketingAffiliateSources>(entity =>
            {
                entity.HasKey(e => e.AffiliateSourceId);

                entity.ToTable("LeadMarketing_AffiliateSources");

                entity.Property(e => e.AffiliateSourceId).HasColumnName("AffiliateSourceID");

                entity.Property(e => e.AffiliateSource).HasMaxLength(50);
            });

            modelBuilder.Entity<LeadMarketingParameters>(entity =>
            {
                entity.HasKey(e => e.LeadId);

                entity.HasIndex(e => new { e.UtmSubcampaign, e.UtmCampaignId })
                    .HasName("MX3");

                entity.HasIndex(e => new { e.AffiliateId, e.LeadId, e.AffiliateName })
                    .HasName("MX6_affiliate_name_INCL");

                entity.HasIndex(e => new { e.LeadId, e.UtmCampaign, e.UtmCampaignId })
                    .HasName("MX4");

                entity.HasIndex(e => new { e.LeadId, e.UtmCampaign, e.UtmSubcampaign, e.UtmCreative })
                    .HasName("MX1_LeadMarketingParameters");

                entity.HasIndex(e => new { e.AffiliateRef, e.LeadId, e.TransactionId, e.AffiliateId, e.UtmCampaignId })
                    .HasName("MX7_affiliate_id_utm_campaignID_INCL");

                entity.HasIndex(e => new { e.LeadId, e.UtmCampaign, e.UtmSubcampaign, e.UtmCampaignId, e.UtmSubcampaignId })
                    .HasName("MX5");

                entity.Property(e => e.LeadId)
                    .HasColumnName("leadID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdvertiserId)
                    .HasColumnName("advertiser_id")
                    .HasMaxLength(50);

                entity.Property(e => e.AdvertiserRef)
                    .HasColumnName("advertiser_ref")
                    .HasMaxLength(50);

                entity.Property(e => e.AffSub)
                    .HasColumnName("aff_sub")
                    .HasMaxLength(50);

                entity.Property(e => e.AffSub2)
                    .HasColumnName("aff_sub2")
                    .HasMaxLength(50);

                entity.Property(e => e.AffSub3)
                    .HasColumnName("aff_sub3")
                    .HasMaxLength(50);

                entity.Property(e => e.AffSub4)
                    .HasColumnName("aff_sub4")
                    .HasMaxLength(50);

                entity.Property(e => e.AffSub5)
                    .HasColumnName("aff_sub5")
                    .HasMaxLength(50);

                entity.Property(e => e.AffiliateId)
                    .HasColumnName("affiliate_id")
                    .HasMaxLength(50);

                entity.Property(e => e.AffiliateName)
                    .HasColumnName("affiliate_name")
                    .HasMaxLength(50);

                entity.Property(e => e.AffiliateRef)
                    .HasColumnName("affiliate_ref")
                    .HasMaxLength(50);

                entity.Property(e => e.CallToActionProvider)
                    .HasColumnName("call_to_action_provider")
                    .HasMaxLength(50);

                entity.Property(e => e.CountryCode)
                    .HasColumnName("country_code")
                    .HasMaxLength(50);

                entity.Property(e => e.D1)
                    .HasColumnName("d1")
                    .HasMaxLength(250);

                entity.Property(e => e.D2)
                    .HasColumnName("d2")
                    .HasMaxLength(250);

                entity.Property(e => e.Datetime)
                    .HasColumnName("datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Device)
                    .HasColumnName("device")
                    .HasMaxLength(50);

                entity.Property(e => e.DeviceModel)
                    .HasColumnName("device_model")
                    .HasMaxLength(50);

                entity.Property(e => e.FileName)
                    .HasColumnName("file_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Funnelid)
                    .HasColumnName("funnelid")
                    .HasMaxLength(250);

                entity.Property(e => e.GoogleAd)
                    .HasColumnName("Google_ad")
                    .HasMaxLength(50);

                entity.Property(e => e.GoogleAdGroup)
                    .HasColumnName("Google_ad_group")
                    .HasMaxLength(50);

                entity.Property(e => e.GoogleCampaign)
                    .HasColumnName("Google_campaign")
                    .HasMaxLength(50);

                entity.Property(e => e.GoogleNetwork)
                    .HasColumnName("Google_network")
                    .HasMaxLength(50);

                entity.Property(e => e.GoogleSiteTarget)
                    .HasColumnName("Google_SiteTarget")
                    .HasMaxLength(50);

                entity.Property(e => e.GoogleTerm)
                    .HasColumnName("Google_term")
                    .HasMaxLength(50);

                entity.Property(e => e.LandingPage)
                    .HasColumnName("landing_page")
                    .HasMaxLength(500);

                entity.Property(e => e.MmAdFormat)
                    .HasColumnName("MM_AdFormat")
                    .HasMaxLength(50);

                entity.Property(e => e.MmAdId)
                    .HasColumnName("MM_AdID")
                    .HasMaxLength(50);

                entity.Property(e => e.MmAdName)
                    .HasColumnName("MM_AdName")
                    .HasMaxLength(50);

                entity.Property(e => e.MmAdvertiserId)
                    .HasColumnName("MM_AdvertiserID")
                    .HasMaxLength(50);

                entity.Property(e => e.MmAdvertiserName)
                    .HasColumnName("MM_AdvertiserName")
                    .HasMaxLength(50);

                entity.Property(e => e.MmCampaignId)
                    .HasColumnName("MM_CampaignID")
                    .HasMaxLength(50);

                entity.Property(e => e.MmCampaignName)
                    .HasColumnName("MM_CampaignName")
                    .HasMaxLength(50);

                entity.Property(e => e.MmIsClick)
                    .HasColumnName("MM_IsClick")
                    .HasMaxLength(50);

                entity.Property(e => e.MmLineId)
                    .HasColumnName("MM_LineID")
                    .HasMaxLength(50);

                entity.Property(e => e.MmPlacementBannerSize)
                    .HasColumnName("MM_PlacementBannerSize")
                    .HasMaxLength(50);

                entity.Property(e => e.MmPlacementId)
                    .HasColumnName("MM_PlacementID")
                    .HasMaxLength(50);

                entity.Property(e => e.MmPublisherName)
                    .HasColumnName("MM_PublisherName")
                    .HasMaxLength(50);

                entity.Property(e => e.MmSectionName)
                    .HasColumnName("MM_SectionName")
                    .HasMaxLength(50);

                entity.Property(e => e.MmSiteId)
                    .HasColumnName("MM_SiteID")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OfferFileId)
                    .HasColumnName("offer_file_id")
                    .HasMaxLength(50);

                entity.Property(e => e.OfferId)
                    .HasColumnName("offer_id")
                    .HasMaxLength(50);

                entity.Property(e => e.OfferName)
                    .HasColumnName("offer_name")
                    .HasMaxLength(50);

                entity.Property(e => e.OfferRef)
                    .HasColumnName("offer_ref")
                    .HasMaxLength(50);

                entity.Property(e => e.OfferUrlId)
                    .HasColumnName("offer_url_id")
                    .HasMaxLength(50);

                entity.Property(e => e.Params)
                    .HasColumnName("params")
                    .HasMaxLength(50);

                entity.Property(e => e.RegionCode)
                    .HasColumnName("region_code")
                    .HasMaxLength(50);

                entity.Property(e => e.RowId)
                    .HasColumnName("rowID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Source)
                    .HasColumnName("source")
                    .HasMaxLength(50);

                entity.Property(e => e.Topic)
                    .HasColumnName("topic")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transaction_id")
                    .HasMaxLength(50);

                entity.Property(e => e.UtmCampaign)
                    .HasColumnName("utm_campaign")
                    .HasMaxLength(250);

                entity.Property(e => e.UtmCampaignId)
                    .HasColumnName("utm_campaignID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UtmCreative)
                    .HasColumnName("utm_creative")
                    .HasMaxLength(250);

                entity.Property(e => e.UtmDynamic)
                    .HasColumnName("utm_dynamic")
                    .HasMaxLength(250);

                entity.Property(e => e.UtmSubcampaign)
                    .HasColumnName("utm_subcampaign")
                    .HasMaxLength(250);

                entity.Property(e => e.UtmSubcampaignId).HasColumnName("utm_subcampaignID");

                entity.HasOne(d => d.Lead)
                    .WithOne(p => p.LeadMarketingParameters)
                    .HasForeignKey<LeadMarketingParameters>(d => d.LeadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LeadMarketingParameters_LeadID");
            });

            modelBuilder.Entity<LeadPersonalDetails>(entity =>
            {
                entity.HasKey(e => e.RowId);

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.ConnectionType).HasDefaultValueSql("((0))");

                entity.Property(e => e.Gender).HasMaxLength(10);

                entity.Property(e => e.GeneralNotes).HasMaxLength(250);

                entity.Property(e => e.LeadId).HasColumnName("LeadID");

                entity.Property(e => e.Modifydate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RetentionNotes).HasMaxLength(250);

                entity.Property(e => e.TradingCompany).HasMaxLength(50);

                entity.Property(e => e.Wd).HasColumnName("WD");

                entity.HasOne(d => d.Lead)
                    .WithMany(p => p.LeadPersonalDetails)
                    .HasForeignKey(d => d.LeadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LeadPersonalDetails_Leads");
            });

            modelBuilder.Entity<LeadProviderMarketingToolsType>(entity =>
            {
                entity.HasKey(e => e.MarketingToolId);

                entity.Property(e => e.MarketingToolId).HasColumnName("MarketingToolID");

                entity.Property(e => e.MarketingToolName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LeadProviderPlanTypes>(entity =>
            {
                entity.Property(e => e.LeadProviderPlanTypesId)
                    .HasColumnName("LeadProviderPlanTypesID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LeadProviders>(entity =>
            {
                entity.HasKey(e => e.LeadProviderId);

                entity.Property(e => e.LeadProviderId).HasColumnName("LeadProviderID");

                entity.Property(e => e.City).HasMaxLength(250);

                entity.Property(e => e.Commission).HasDefaultValueSql("((15))");

                entity.Property(e => e.CountryId)
                    .HasColumnName("CountryID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.LeadProviderPlanTypesId).HasColumnName("LeadProviderPlanTypesID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PaymentTypeId)
                    .HasColumnName("PaymentTypeID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SeconderyPhone).HasMaxLength(250);

                entity.Property(e => e.Street).HasMaxLength(250);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.WebsiteName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("(N'Default')");

                entity.Property(e => e.WebsiteUrl)
                    .IsRequired()
                    .HasColumnName("WebsiteURL")
                    .HasMaxLength(250)
                    .HasDefaultValueSql("(N'http://www.hfx.com')");

                entity.Property(e => e.Zip)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.LeadProviders)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LeadProviders_LeadProviders");

                entity.HasOne(d => d.LeadProviderPlanTypes)
                    .WithMany(p => p.LeadProviders)
                    .HasForeignKey(d => d.LeadProviderPlanTypesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LeadProviders_LeadProviderPlanTypes");

                entity.HasOne(d => d.PaymentType)
                    .WithMany(p => p.LeadProviders)
                    .HasForeignKey(d => d.PaymentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LeadProviders_PaymentTypes");
            });

            modelBuilder.Entity<LeadProvidersPaymentsHistory>(entity =>
            {
                entity.HasKey(e => e.PaymentId);

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Comments).HasMaxLength(150);

                entity.Property(e => e.LeadProviderId).HasColumnName("LeadProviderID");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.HasOne(d => d.LeadProvider)
                    .WithMany(p => p.LeadProvidersPaymentsHistory)
                    .HasForeignKey(d => d.LeadProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LeadProvidersPaymentsHistory_LeadProviders");
            });

            modelBuilder.Entity<LeadRanks>(entity =>
            {
                entity.HasKey(e => e.LeadRankId);

                entity.Property(e => e.LeadRankId).HasColumnName("LeadRankID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LeadRankName)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<LeadRetentionScores>(entity =>
            {
                entity.HasIndex(e => e.LeadId)
                    .HasName("IX_LeadRetentionScores")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LeadId).HasColumnName("LeadID");

                entity.HasOne(d => d.Lead)
                    .WithOne(p => p.LeadRetentionScores)
                    .HasForeignKey<LeadRetentionScores>(d => d.LeadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LeadRetentionScore_Leads");
            });

            modelBuilder.Entity<LeadRetentionScoresBidata>(entity =>
            {
                entity.ToTable("LeadRetentionScoresBIData");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LeadId).HasColumnName("LeadID");
            });

            modelBuilder.Entity<Leads>(entity =>
            {
                entity.HasKey(e => e.LeadId)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.AssignedToUserId)
                    .HasName("MX14_AssighnToUserID");

                entity.HasIndex(e => e.ParentLeadId)
                    .HasName("IDX_Leads_ParentLeadID");

                entity.HasIndex(e => new { e.DateEntered, e.LeadId })
                    .HasName("IX_Leads")
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => new { e.LeadId, e.PlacementId })
                    .HasName("IX_Leads_1");

                entity.HasIndex(e => new { e.AssignedToUserId, e.LeadStatusId, e.ParentLeadId, e.OfficeId })
                    .HasName("MX11");

                entity.HasIndex(e => new { e.AssignedToUserId, e.ParentLeadId, e.OfficeId, e.DateEntered })
                    .HasName("MX3_AssignedToUserID_ParentLeadID_OfficeID_DateEntered");

                entity.HasIndex(e => new { e.AssignedToUserId, e.ParentLeadId, e.OfficeId, e.LastAssignmentDate, e.CountryId })
                    .HasName("MX12");

                entity.HasIndex(e => new { e.LeadId, e.LeadAssignmentTypeId, e.AssignedToUserId, e.OfficeId, e.LastAssignmentDate })
                    .HasName("MX10_LeadAssignmentTypeID_AssignedToUserID_OfficeID_LastAssignmentDate_INCL_LeadID");

                entity.HasIndex(e => new { e.AssignedToDeskId, e.AssignedToUserId, e.LastActivity, e.LeadId, e.ModifyDate, e.ParentLeadId })
                    .HasName("MX8_ParentLeadID_INCL");

                entity.HasIndex(e => new { e.LeadId, e.Email, e.FirstName, e.LastName, e.Phone, e.OfficeId })
                    .HasName("IX_")
                    .IsUnique();

                entity.HasIndex(e => new { e.AssignedToDeskId, e.AssignedToUserId, e.LastActivity, e.LastAssignmentDate, e.LeadId, e.ModifyDate, e.ParentLeadId })
                    .HasName("MX9_ParentLeadID_INCL");

                entity.HasIndex(e => new { e.LeadId, e.AssignedToDeskId, e.DateEntered, e.LanguageId, e.FirstName, e.LastName, e.Email, e.OfficeId, e.CountryId })
                    .HasName("MX4_OfficeID_incl");

                entity.HasIndex(e => new { e.AssignedToDeskId, e.CountryId, e.DateEntered, e.Email, e.FirstName, e.LanguageId, e.LastAssignmentDate, e.LastName, e.LeadId, e.ModifyDate, e.Phone, e.ParentLeadId })
                    .HasName("MX7_ParentLeadID_INCL");

                entity.HasIndex(e => new { e.Serial, e.LeadAssignmentTypeId, e.AssignedToUserId, e.AssignedToDeskId, e.LeadStatusId, e.DateEntered, e.LanguageId, e.CountryId, e.Email, e.Phone, e.ParentLeadId, e.OfficeId, e.LeadId })
                    .HasName("MX1_ParentLeadID_OfficeID_LeadID_INCL");

                entity.HasIndex(e => new { e.LeadId, e.LeadProviderId, e.LeadAssignmentTypeId, e.AssignedToUserId, e.AssignedToDeskId, e.LeadStatusId, e.IsConverted, e.CountryId, e.FirstName, e.LastName, e.Email, e.Phone, e.Mobile, e.IsMale, e.DateOfBirth, e.IsForexTrader, e.IsGeneralTrader, e.LeadRankId, e.ParentLeadId, e.OfficeId, e.LanguageId, e.DateEntered })
                    .HasName("MX5_ParentLeadID_OfficeID_LanguageID_DateEntered");

                entity.HasIndex(e => new { e.LeadProviderId, e.IsConverted, e.Phone, e.Mobile, e.IsMale, e.DateOfBirth, e.IsForexTrader, e.IsGeneralTrader, e.LeadRankId, e.Email, e.LeadAssignmentTypeId, e.OfficeId, e.DateEntered, e.CountryId, e.FirstName, e.LastName, e.LanguageId, e.LeadId, e.AssignedToDeskId, e.AssignedToUserId, e.ParentLeadId, e.LeadStatusId })
                    .HasName("_dta_index_Leads_29_462220997__K27_K7_K22_K12_K24_K25_K26_K23_K1_K10_K9_K21_K11_5_20_28_29_37_43_45_46_47");

                entity.HasIndex(e => new { e.LeadProviderId, e.IsConverted, e.Phone, e.Mobile, e.IsMale, e.DateOfBirth, e.IsForexTrader, e.IsGeneralTrader, e.LeadRankId, e.FirstName, e.LeadAssignmentTypeId, e.OfficeId, e.DateEntered, e.CountryId, e.Email, e.LastName, e.LanguageId, e.LeadId, e.AssignedToDeskId, e.AssignedToUserId, e.ParentLeadId, e.LeadStatusId })
                    .HasName("_dta_index_Leads_29_462220997__K25_K7_K22_K12_K24_K27_K26_K23_K1_K10_K9_K21_K11_5_20_28_29_37_43_45_46_47");

                entity.HasIndex(e => new { e.LeadProviderId, e.IsConverted, e.Phone, e.Mobile, e.IsMale, e.DateOfBirth, e.IsForexTrader, e.IsGeneralTrader, e.LeadRankId, e.LastName, e.LeadAssignmentTypeId, e.OfficeId, e.DateEntered, e.CountryId, e.Email, e.FirstName, e.LanguageId, e.LeadId, e.AssignedToDeskId, e.AssignedToUserId, e.ParentLeadId, e.LeadStatusId })
                    .HasName("_dta_index_Leads_29_462220997__K26_K7_K22_K12_K24_K27_K25_K23_K1_K10_K9_K21_K11_5_20_28_29_37_43_45_46_47");

                entity.HasIndex(e => new { e.LeadId, e.PlacementId, e.LeadProviderId, e.LeadAssignmentTypeId, e.AssignedToDeskId, e.LeadStatusId, e.DateEntered, e.IsConverted, e.ParentLeadId, e.LanguageId, e.CountryId, e.FirstName, e.LastName, e.Email, e.Phone, e.Mobile, e.IsMale, e.DateOfBirth, e.IsForexTrader, e.IsGeneralTrader, e.LeadRankId, e.AssignedToUserId, e.OfficeId })
                    .HasName("IX_LeadsAssignedToUserIDOfficeID");

                entity.HasIndex(e => new { e.LeadId, e.PlacementId, e.LeadProviderId, e.LeadAssignmentTypeId, e.AssignedToUserId, e.AssignedToDeskId, e.LeadStatusId, e.DateEntered, e.IsConverted, e.ParentLeadId, e.LanguageId, e.CountryId, e.FirstName, e.LastName, e.Email, e.Phone, e.Mobile, e.IsMale, e.DateOfBirth, e.IsForexTrader, e.IsGeneralTrader, e.LeadRankId, e.OfficeId })
                    .HasName("IX_LeadsOfficeID");

                entity.HasIndex(e => new { e.LeadId, e.PlacementId, e.LeadProviderId, e.LeadAssignmentTypeId, e.AssignedToUserId, e.AssignedToDeskId, e.LeadStatusId, e.IsConverted, e.ParentLeadId, e.LanguageId, e.CountryId, e.FirstName, e.LastName, e.Email, e.Phone, e.Mobile, e.IsMale, e.DateOfBirth, e.IsForexTrader, e.IsGeneralTrader, e.LeadRankId, e.OfficeId, e.LastAssignmentDate })
                    .HasName("IX_LeadsOfficeIDLastAssignmentDate");

                entity.HasIndex(e => new { e.LeadId, e.LeadProviderId, e.LeadAssignmentTypeId, e.AssignedToUserId, e.AssignedToDeskId, e.LeadStatusId, e.IsConverted, e.ParentLeadId, e.LanguageId, e.CountryId, e.FirstName, e.LastName, e.Email, e.Phone, e.Mobile, e.IsMale, e.DateOfBirth, e.IsForexTrader, e.IsGeneralTrader, e.LeadRankId, e.EmailPromotionActionId, e.EmailPromotionDate, e.OfficeId, e.DateEntered })
                    .HasName("MX2_OfficeID_DateEntered_INCL_BIG");

                entity.HasIndex(e => new { e.LeadId, e.LeadProviderId, e.LeadAssignmentTypeId, e.AssignedToUserId, e.IsConverted, e.LanguageId, e.CountryId, e.FirstName, e.LastName, e.Email, e.Phone, e.Mobile, e.IsMale, e.DateOfBirth, e.IsForexTrader, e.IsGeneralTrader, e.LeadRankId, e.EmailPromotionActionId, e.EmailPromotionDate, e.AssignedToDeskId, e.LeadStatusId, e.ParentLeadId, e.OfficeId, e.DateEntered })
                    .HasName("MX6_INCL_BIG");

                entity.HasIndex(e => new { e.LeadId, e.LeadProviderId, e.LeadAssignmentTypeId, e.AssignedToDeskId, e.LeadStatusId, e.IsConverted, e.LanguageId, e.CountryId, e.FirstName, e.LastName, e.Email, e.Phone, e.Mobile, e.IsMale, e.DateOfBirth, e.IsForexTrader, e.IsGeneralTrader, e.LeadRankId, e.EmailPromotionActionId, e.EmailPromotionDate, e.LeadRisk, e.LastActivity, e.AssignedToUserId, e.ParentLeadId, e.OfficeId, e.LastAssignmentDate })
                    .HasName("MX14");

                entity.Property(e => e.LeadId).HasColumnName("LeadID");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'P.O. box 54')");

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'P.O. box 54')");

                entity.Property(e => e.AssignedToDeskId).HasColumnName("AssignedToDeskID");

                entity.Property(e => e.AssignedToUserId).HasColumnName("AssignedToUserID");

                entity.Property(e => e.Browser).HasMaxLength(50);

                entity.Property(e => e.CfdKnowledge).HasColumnName("CFD_Knowledge");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('N/A')");

                entity.Property(e => e.CountryId)
                    .HasColumnName("CountryID")
                    .HasDefaultValueSql("((31))");

                entity.Property(e => e.CountryIdCitizenship).HasColumnName("CountryID_Citizenship");

                entity.Property(e => e.CountryIdResidence).HasColumnName("CountryID_Residence");

                entity.Property(e => e.DateEntered).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1970-01-01 00:00:00.000')");

                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("(N'Error@Error.com')");

                entity.Property(e => e.EmailPromotionActionId)
                    .HasColumnName("EmailPromotionActionID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailPromotionDate).HasColumnType("datetime");

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.Im)
                    .HasColumnName("IM")
                    .HasMaxLength(50);

                entity.Property(e => e.Industry).HasMaxLength(50);

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'127.0.0.1')");

                entity.Property(e => e.IpAddress).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IsAllowedNewsLetter).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDepositPixel).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDupulicate)
                    .HasColumnName("isDupulicate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPendingAssignment)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Keyword).HasMaxLength(300);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.LastActivity)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.LeadAssignmentTypeId).HasColumnName("LeadAssignmentTypeID");

                entity.Property(e => e.LeadProviderId).HasColumnName("LeadProviderID");

                entity.Property(e => e.LeadProviderParam).HasMaxLength(250);

                entity.Property(e => e.LeadRankId).HasColumnName("LeadRankID");

                entity.Property(e => e.LeadRisk).HasDefaultValueSql("((0))");

                entity.Property(e => e.LeadStatusId)
                    .HasColumnName("LeadStatusID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.MobileOriginal)
                    .HasColumnName("Mobile_Original")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifyDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Neighberhood).HasMaxLength(50);

                entity.Property(e => e.OfficeId)
                    .HasColumnName("OfficeID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.OriginLeadId).HasColumnName("originLeadID");

                entity.Property(e => e.Over18Declaration)
                    .HasColumnName("Over18_Declaration")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ParentLeadId).HasColumnName("ParentLeadID");

                entity.Property(e => e.PepRelated)
                    .HasColumnName("PEP_Related")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.PhoneOriginal)
                    .HasColumnName("Phone_Original")
                    .HasMaxLength(50);

                entity.Property(e => e.PhoneValidationStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlacementId).HasColumnName("PlacementID");

                entity.Property(e => e.ReferrerUrl).HasMaxLength(500);

                entity.Property(e => e.RegStep).HasDefaultValueSql("((2))");

                entity.Property(e => e.RegUrl).HasMaxLength(500);

                entity.Property(e => e.Serial).HasMaxLength(250);

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('N/A')");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('12345')");
            });

            modelBuilder.Entity<LeadsImportHistory>(entity =>
            {
                entity.HasKey(e => e.LiId);

                entity.Property(e => e.LiId).HasColumnName("LI_ID");

                entity.Property(e => e.LiCampaign)
                    .HasColumnName("LI_Campaign")
                    .HasMaxLength(250);

                entity.Property(e => e.LiDateEntered)
                    .HasColumnName("LI_DateEntered")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LiDesk).HasColumnName("LI_Desk");

                entity.Property(e => e.LiNumberOfLeads).HasColumnName("LI_NumberOfLeads");

                entity.Property(e => e.LiOffice).HasColumnName("LI_Office");

                entity.Property(e => e.LiStatus).HasColumnName("LI_Status");

                entity.Property(e => e.LiSubCampaign)
                    .HasColumnName("LI_SubCampaign")
                    .HasMaxLength(250);

                entity.Property(e => e.LiUserId).HasColumnName("LI_UserId");
            });

            modelBuilder.Entity<LeadStatuses>(entity =>
            {
                entity.HasKey(e => e.LeadStatusId);

                entity.Property(e => e.LeadStatusId).HasColumnName("LeadStatusID");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.LeadStatusGroupId).HasColumnName("LeadStatusGroupID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.LeadStatusGroup)
                    .WithMany(p => p.LeadStatuses)
                    .HasForeignKey(d => d.LeadStatusGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LeadStatuses_LeadStatusGroups");
            });

            modelBuilder.Entity<LeadStatusGroups>(entity =>
            {
                entity.HasKey(e => e.LeadStatusGroupId);

                entity.Property(e => e.LeadStatusGroupId).HasColumnName("LeadStatusGroupID");

                entity.Property(e => e.LeadAssignmentTypeId).HasColumnName("LeadAssignmentTypeID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.LeadAssignmentType)
                    .WithMany(p => p.LeadStatusGroups)
                    .HasForeignKey(d => d.LeadAssignmentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LeadStatusGroups_LeadAssignmentTypes");
            });

            modelBuilder.Entity<LeadValidationStatuses>(entity =>
            {
                entity.HasKey(e => e.ValidationStatusId);

                entity.ToTable("Lead_ValidationStatuses");

                entity.Property(e => e.ValidationStatusId).HasColumnName("ValidationStatusID");

                entity.Property(e => e.Status).HasMaxLength(50);
            });

            modelBuilder.Entity<LiveKashCards>(entity =>
            {
                entity.HasKey(e => e.LiveKashCard);

                entity.Property(e => e.LiveKashCard)
                    .HasMaxLength(150)
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.DateOfBirth).HasMaxLength(50);

                entity.Property(e => e.LiveKashCvv)
                    .IsRequired()
                    .HasColumnName("LiveKashCVV")
                    .HasMaxLength(50);

                entity.Property(e => e.LiveKashExpiration)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.LiveKashCards)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LiveKashCards_Accounts");
            });

            modelBuilder.Entity<MailSenders>(entity =>
            {
                entity.HasKey(e => e.MailSenderId);

                entity.Property(e => e.MailSenderId).HasColumnName("MailSenderID");

                entity.Property(e => e.MailSenderDisplayName)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<MailServersInformation>(entity =>
            {
                entity.HasKey(e => e.MailServerId);

                entity.Property(e => e.MailServerId).HasColumnName("MailServerID");

                entity.Property(e => e.DisplayName).HasMaxLength(50);

                entity.Property(e => e.HostAddress)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.IsSsl).HasColumnName("IsSSL");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Port)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Timeout).HasDefaultValueSql("((10000))");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MailSubjects>(entity =>
            {
                entity.HasKey(e => e.SubjectId);

                entity.Property(e => e.SubjectId)
                    .HasColumnName("SubjectID")
                    .ValueGeneratedNever();

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.MailId).HasColumnName("MailID");

                entity.Property(e => e.SubjectText)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.MailSubjects)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Subjects_Languages");

                entity.HasOne(d => d.Mail)
                    .WithMany(p => p.MailSubjects)
                    .HasForeignKey(d => d.MailId)
                    .HasConstraintName("FK_MailSubjects_MailTemplates");
            });

            modelBuilder.Entity<MailTemplates>(entity =>
            {
                entity.HasKey(e => e.MailId);

                entity.Property(e => e.MailId).HasColumnName("MailID");

                entity.Property(e => e.IsNewsLetter).HasDefaultValueSql("((0))");

                entity.Property(e => e.MailFileName).HasMaxLength(150);

                entity.Property(e => e.MailFriendlyName).HasMaxLength(150);

                entity.Property(e => e.MailName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.MailSenderId).HasColumnName("MailSenderID");

                entity.HasOne(d => d.MailSender)
                    .WithMany(p => p.MailTemplates)
                    .HasForeignKey(d => d.MailSenderId)
                    .HasConstraintName("FK_MailTemplates_MailSenders");
            });

            modelBuilder.Entity<MeetingStatus>(entity =>
            {
                entity.Property(e => e.MeetingStatusId).HasColumnName("MeetingStatusID");

                entity.Property(e => e.MeetingStatusName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MetatraderLeverage>(entity =>
            {
                entity.Property(e => e.MetatraderLeverageId)
                    .HasColumnName("Metatrader_Leverage_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.MetatraderLeverageName).HasColumnName("Metatrader_Leverage_Name");
            });

            modelBuilder.Entity<Nationalities>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nationality).HasMaxLength(255);
            });

            modelBuilder.Entity<Numbers>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.Property(e => e.Number).ValueGeneratedNever();
            });

            modelBuilder.Entity<Offices>(entity =>
            {
                entity.HasKey(e => e.OfficeId);

                entity.Property(e => e.OfficeId).HasColumnName("OfficeID");

                entity.Property(e => e.CashierTypeId).HasColumnName("CashierTypeID");

                entity.Property(e => e.MailServerId).HasColumnName("MailServerID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Regulated).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.MailServer)
                    .WithMany(p => p.Offices)
                    .HasForeignKey(d => d.MailServerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Offices_MailServers");
            });

            modelBuilder.Entity<PageVisits>(entity =>
            {
                entity.HasKey(e => e.PageId);

                entity.Property(e => e.PageId).HasColumnName("PageID");

                entity.Property(e => e.PageName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PayCards>(entity =>
            {
                entity.HasKey(e => e.PayCardId);

                entity.Property(e => e.PayCardId).HasColumnName("PayCardID");

                entity.Property(e => e.ChainSymbol).HasMaxLength(10);

                entity.Property(e => e.CngSymbol).HasMaxLength(10);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.Mbsymbol)
                    .HasColumnName("MBSymbol")
                    .HasMaxLength(10);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Symbol)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.PayCards)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_PayCards_Countries");
            });

            modelBuilder.Entity<PaymentStatuses>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.Property(e => e.StatusId).HasColumnName("statusID");

                entity.Property(e => e.Key).HasMaxLength(50);

                entity.Property(e => e.StatusName)
                    .HasColumnName("statusName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PaymentTypes>(entity =>
            {
                entity.HasKey(e => e.PaymentTypeId);

                entity.Property(e => e.PaymentTypeId).HasColumnName("PaymentTypeID");

                entity.Property(e => e.PaymentTypeDescription).HasMaxLength(250);

                entity.Property(e => e.PaymentTypeName)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Pixels>(entity =>
            {
                entity.HasKey(e => e.PixelId);

                entity.HasIndex(e => e.Name)
                    .HasName("IX_Pixels")
                    .IsUnique();

                entity.Property(e => e.PixelId).HasColumnName("PixelID");

                entity.Property(e => e.Body).IsRequired();

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.IsDeposit).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Placements>(entity =>
            {
                entity.HasKey(e => e.PlacementId);

                entity.Property(e => e.PlacementId).HasColumnName("PlacementID");

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.DeskId).HasColumnName("DeskID");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Height).HasDefaultValueSql("((0))");

                entity.Property(e => e.LandingPageId).HasColumnName("LandingPageID");

                entity.Property(e => e.LandingPageUrl)
                    .HasColumnName("LandingPageURL")
                    .HasMaxLength(2000)
                    .HasDefaultValueSql("('http://landing.hfx.com/')");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PixelId).HasColumnName("PixelID");

                entity.Property(e => e.PlatformComments).HasMaxLength(1500);

                entity.Property(e => e.PlatformGroupId).HasColumnName("Platform_Group_ID");

                entity.Property(e => e.PlatformGroupId2).HasColumnName("Platform_Group_ID2");

                entity.Property(e => e.SubCampaignId).HasColumnName("SubCampaignID");

                entity.Property(e => e.Width).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Desk)
                    .WithMany(p => p.Placements)
                    .HasForeignKey(d => d.DeskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Placements_Desks");

                entity.HasOne(d => d.LandingPage)
                    .WithMany(p => p.Placements)
                    .HasForeignKey(d => d.LandingPageId)
                    .HasConstraintName("fk_placement_landingPage");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.Placements)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Placements_Languages");

                entity.HasOne(d => d.Pixel)
                    .WithMany(p => p.Placements)
                    .HasForeignKey(d => d.PixelId)
                    .HasConstraintName("fk_Placement_pixel");

                entity.HasOne(d => d.PlatformGroup)
                    .WithMany(p => p.PlacementsPlatformGroup)
                    .HasForeignKey(d => d.PlatformGroupId)
                    .HasConstraintName("FK_Placements_PlatformGroups");

                entity.HasOne(d => d.PlatformGroupId2Navigation)
                    .WithMany(p => p.PlacementsPlatformGroupId2Navigation)
                    .HasForeignKey(d => d.PlatformGroupId2)
                    .HasConstraintName("FK_Placements_PlatformGroups2");

                entity.HasOne(d => d.SubCampaign)
                    .WithMany(p => p.Placements)
                    .HasForeignKey(d => d.SubCampaignId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Placements_SubCampaigns");
            });

            modelBuilder.Entity<PlatformGroups>(entity =>
            {
                entity.HasKey(e => e.PlatformGroupId);

                entity.Property(e => e.PlatformGroupId).HasColumnName("Platform_Group_ID");

                entity.Property(e => e.AccountTypeId).HasColumnName("Account_Type_ID");

                entity.Property(e => e.PlatformGroupName)
                    .IsRequired()
                    .HasColumnName("Platform_Group_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.PlatformId).HasColumnName("PlatformID");

                entity.HasOne(d => d.Platform)
                    .WithMany(p => p.PlatformGroups)
                    .HasForeignKey(d => d.PlatformId)
                    .HasConstraintName("FK_PlatformGroups_Platforms");
            });

            modelBuilder.Entity<Platforms>(entity =>
            {
                entity.HasKey(e => e.PlatformId);

                entity.Property(e => e.PlatformId).HasColumnName("PlatformID");

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.DefaultDemoGroup)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DefaultLiveGroup)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DemoServer)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeskIds).HasColumnName("DeskIDs");

                entity.Property(e => e.LiveServer)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OfficeId).HasColumnName("OfficeID");

                entity.Property(e => e.PlatformTypeId).HasColumnName("PlatformTypeID");
            });

            modelBuilder.Entity<PlatformTypes>(entity =>
            {
                entity.HasKey(e => e.PlatformTypeId);

                entity.Property(e => e.PlatformTypeId).HasColumnName("PlatformTypeID");

                entity.Property(e => e.PlatformTypeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Priority>(entity =>
            {
                entity.Property(e => e.PriorityId)
                    .HasColumnName("PriorityID")
                    .ValueGeneratedNever();

                entity.Property(e => e.PriorityName)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<ProfilesRolesMapping>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.ProfilesRolesMapping)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProfilesRolesMapping_Profiles");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.ProfilesRolesMapping)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProfilesRolesMapping_Roles");
            });

            modelBuilder.Entity<PromotionalEmails>(entity =>
            {
                entity.HasKey(e => e.PromotionalEmailId);

                entity.Property(e => e.PromotionalEmailId).HasColumnName("PromotionalEmailID");

                entity.Property(e => e.PromotionalEmailCode).IsRequired();

                entity.Property(e => e.PromotionalEmailDescription)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.PromotionalEmailLandingPageId).HasColumnName("PromotionalEmailLandingPageID");

                entity.Property(e => e.PromotionalEmailLanguageId).HasColumnName("PromotionalEmailLanguageID");

                entity.Property(e => e.PromotionalEmailName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.PromotionalEmailLandingPage)
                    .WithMany(p => p.PromotionalEmails)
                    .HasForeignKey(d => d.PromotionalEmailLandingPageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PromotionalEmails_LandingPages");

                entity.HasOne(d => d.PromotionalEmailLanguage)
                    .WithMany(p => p.PromotionalEmails)
                    .HasForeignKey(d => d.PromotionalEmailLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PromotionalEmails_Languages");
            });

            modelBuilder.Entity<Questionnaires>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AnswerId).HasColumnName("AnswerID");

                entity.Property(e => e.Order).HasDefaultValueSql("((0))");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.QuestionnaireId).HasColumnName("QuestionnaireID");
            });

            modelBuilder.Entity<QuestionnairesTypes>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<Questions>(entity =>
            {
                entity.HasKey(e => e.QuestionId);

                entity.HasIndex(e => e.ShortText)
                    .HasName("ShortTextUnique")
                    .IsUnique();

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.Body)
                    .IsRequired()
                    .HasMaxLength(700);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShortText)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<RegulatedCountries>(entity =>
            {
                entity.HasKey(e => e.CountryId);

                entity.Property(e => e.CountryId)
                    .HasColumnName("countryID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.Country)
                    .WithOne(p => p.RegulatedCountries)
                    .HasForeignKey<RegulatedCountries>(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RegulatedCountries_Countries");
            });

            modelBuilder.Entity<RegulationQuestionnaireAnswers>(entity =>
            {
                entity.HasKey(e => e.AnswerId);

                entity.Property(e => e.AnswerId).HasColumnName("AnswerID");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("key")
                    .HasMaxLength(250)
                    .HasDefaultValueSql("(N'key')");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<RegulationQuestions>(entity =>
            {
                entity.HasKey(e => e.QuestionId);

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("key")
                    .HasMaxLength(250)
                    .HasDefaultValueSql("(N'key')");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Reminder>(entity =>
            {
                entity.Property(e => e.ReminderId)
                    .HasColumnName("ReminderID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ReminderName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ReportsLeadInteractions>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.LeadId).HasColumnName("LeadID");

                entity.Property(e => e.LeadInteractionId).HasColumnName("LeadInteractionID");

                entity.Property(e => e.LeadInteractionTypeId).HasColumnName("LeadInteractionTypeID");

                entity.Property(e => e.LeadInteractionTypeName).HasMaxLength(50);

                entity.Property(e => e.LeadStatusGroupId).HasColumnName("LeadStatusGroupID");

                entity.Property(e => e.LeadStatusGroupName).HasMaxLength(50);

                entity.Property(e => e.LeadStatusId).HasColumnName("LeadStatusID");

                entity.Property(e => e.LeadStatusName).HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            modelBuilder.Entity<RepositoryLeadInteractions>(entity =>
            {
                entity.HasIndex(e => new { e.UserId, e.Username, e.LeadId, e.DateEntered })
                    .HasName("MX2_DateEntered_INCL");

                entity.HasIndex(e => new { e.Username, e.LeadInteractionTypeName, e.UserId, e.DateEntered })
                    .HasName("MX1_LeadInteractionTypeName_UserID_DateEntered_INCL_Username");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.LeadId).HasColumnName("LeadID");

                entity.Property(e => e.LeadInteractionId).HasColumnName("LeadInteractionID");

                entity.Property(e => e.LeadInteractionTypeId).HasColumnName("LeadInteractionTypeID");

                entity.Property(e => e.LeadInteractionTypeName).HasMaxLength(50);

                entity.Property(e => e.LeadStatusGroupId).HasColumnName("LeadStatusGroupID");

                entity.Property(e => e.LeadStatusGroupName).HasMaxLength(50);

                entity.Property(e => e.LeadStatusId).HasColumnName("LeadStatusID");

                entity.Property(e => e.LeadStatusName).HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            modelBuilder.Entity<RetentionScores>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Score)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('n/a')");
            });

            modelBuilder.Entity<RoleGroups>(entity =>
            {
                entity.HasKey(e => e.RoleGroupId);

                entity.Property(e => e.RoleGroupId).HasColumnName("RoleGroupID");

                entity.Property(e => e.RoleGroupName)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<RoleProfiles>(entity =>
            {
                entity.HasKey(e => e.ProfileId);

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.ProfileName)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.RoleGroupId)
                    .HasColumnName("RoleGroupID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RoleName).HasMaxLength(50);
            });

            modelBuilder.Entity<ScheduleTasks>(entity =>
            {
                entity.HasKey(e => e.MeetingId);

                entity.Property(e => e.MeetingId).HasColumnName("MeetingID");

                entity.Property(e => e.IsOpened).HasDefaultValueSql("((0))");

                entity.Property(e => e.LeadId).HasColumnName("LeadID");

                entity.Property(e => e.MeetingStatusId)
                    .HasColumnName("MeetingStatusID")
                    .HasDefaultValueSql("((4))");

                entity.Property(e => e.MeetingSubject)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.PriorityId).HasColumnName("PriorityID");

                entity.Property(e => e.ReminderId).HasColumnName("ReminderID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Lead)
                    .WithMany(p => p.ScheduleTasks)
                    .HasForeignKey(d => d.LeadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScheduleTasks_Leads1");

                entity.HasOne(d => d.Priority)
                    .WithMany(p => p.ScheduleTasks)
                    .HasForeignKey(d => d.PriorityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScheduleTasks_Priority1");

                entity.HasOne(d => d.Reminder)
                    .WithMany(p => p.ScheduleTasks)
                    .HasForeignKey(d => d.ReminderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScheduleTasks_Reminder1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ScheduleTasks)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScheduleTasks_Users1");
            });

            modelBuilder.Entity<Skins>(entity =>
            {
                entity.HasKey(e => e.SkinId);

                entity.HasIndex(e => e.Name)
                    .HasName("IX_Skins")
                    .IsUnique();

                entity.Property(e => e.SkinId).HasColumnName("SkinID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SmsBodyInStatusAndLabguage>(entity =>
            {
                entity.Property(e => e.SmsTemplateId).HasColumnName("smsTemplateId");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.SmsBodyInStatusAndLabguage)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("FK_SmsBodyInStatusAndLabguage_Languages");

                entity.HasOne(d => d.SmsTemplate)
                    .WithMany(p => p.SmsBodyInStatusAndLabguage)
                    .HasForeignKey(d => d.SmsTemplateId)
                    .HasConstraintName("FK_SmsBodyInStatusAndLabguage_SmsBody");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.SmsBodyInStatusAndLabguage)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_SmsBodyInStatusAndLabguage_LeadStatuses");
            });

            modelBuilder.Entity<SmsTemplates>(entity =>
            {
                entity.HasKey(e => e.TemplateId);

                entity.Property(e => e.Body).IsRequired();

                entity.Property(e => e.FriendlyName).HasMaxLength(1000);
            });

            modelBuilder.Entity<SubCampaigns>(entity =>
            {
                entity.HasKey(e => e.SubCampaignId);

                entity.Property(e => e.SubCampaignId).HasColumnName("SubCampaignID");

                entity.Property(e => e.CampaignId).HasColumnName("CampaignID");

                entity.Property(e => e.CampaignPaymentTermId).HasColumnName("CampaignPaymentTermID");

                entity.Property(e => e.CampaignTypeId).HasColumnName("CampaignTypeID");

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.IsOrganic).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OfferClickCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OfferClickCodeIsActive).HasColumnName("OfferClickCode_IsActive");

                entity.Property(e => e.OfferDepositCodePostBack)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OfferDepositCodePostBackIsActive)
                    .HasColumnName("OfferDepositCodePostBack_IsActive")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OfferFtdcodePostBack)
                    .HasColumnName("OfferFTDCodePostBack")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OfferFtdcodePostBackIsActive).HasColumnName("OfferFTDCodePostBack_IsActive");

                entity.Property(e => e.OfferImpresionCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OfferImpresionCodeIsActive).HasColumnName("OfferImpresionCode_IsActive");

                entity.Property(e => e.OfferLeadCodePostBack)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OfferLeadCodePostBackIsActive)
                    .HasColumnName("OfferLeadCodePostBack_IsActive")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Website)
                    .HasColumnName("website")
                    .HasColumnType("ntext");

                entity.HasOne(d => d.CampaignPaymentTerm)
                    .WithMany(p => p.SubCampaigns)
                    .HasForeignKey(d => d.CampaignPaymentTermId)
                    .HasConstraintName("FK_SubCampaigns_CampaignPaymentTerms");

                entity.HasOne(d => d.CampaignType)
                    .WithMany(p => p.SubCampaigns)
                    .HasForeignKey(d => d.CampaignTypeId)
                    .HasConstraintName("FK_SubCampaigns_CampaignTypes");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SubCampaigns)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_SubCampaigns_Users");
            });

            modelBuilder.Entity<Tasks>(entity =>
            {
                entity.HasKey(e => e.TaskId);

                entity.Property(e => e.TaskId)
                    .HasColumnName("TaskID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateEntered)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Trackers>(entity =>
            {
                entity.HasKey(e => e.TrackerId);

                entity.Property(e => e.TrackerId).HasColumnName("TrackerID");

                entity.Property(e => e.BannerId).HasColumnName("BannerID");

                entity.Property(e => e.DateEntered)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Guid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LandingPageId).HasColumnName("LandingPageID");

                entity.Property(e => e.PlacementId).HasColumnName("PlacementID");

                entity.HasOne(d => d.Banner)
                    .WithMany(p => p.Trackers)
                    .HasForeignKey(d => d.BannerId)
                    .HasConstraintName("FK_Trackers_Banners");

                entity.HasOne(d => d.LandingPage)
                    .WithMany(p => p.Trackers)
                    .HasForeignKey(d => d.LandingPageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Trackers_LandingPages");

                entity.HasOne(d => d.Placement)
                    .WithMany(p => p.Trackers)
                    .HasForeignKey(d => d.PlacementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Trackers_Placements");
            });

            modelBuilder.Entity<UserInTeamLeader>(entity =>
            {
                entity.Property(e => e.ModifyDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.HasIndex(e => e.UserId)
                    .HasName("_dta_index_Users_29_2099048__K1");

                entity.HasIndex(e => new { e.Username, e.UserId })
                    .HasName("_dta_index_Users_29_2099048__K1_2");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.DateCreated).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PasswordAnswer).HasMaxLength(250);

                entity.Property(e => e.PasswordQuestion).HasMaxLength(250);

                entity.Property(e => e.UserFtdamount).HasColumnName("UserFTDAmount");

                entity.Property(e => e.UserFtdcount).HasColumnName("UserFTDCount");

                entity.Property(e => e.UserRank).HasMaxLength(50);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UsersCampaignsMapping>(entity =>
            {
                entity.HasIndex(e => e.ModifyDate)
                    .HasName("MX2_ModifyDate");

                entity.HasIndex(e => e.UserId)
                    .HasName("MX1_UserID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OfficeId).HasColumnName("OfficeID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UtmCampaignId).HasColumnName("utm_campaignID");
            });

            modelBuilder.Entity<UsersInAccountEvents>(entity =>
            {
                entity.HasKey(e => new { e.AccountEventId, e.UserId, e.LeadAssignmentTypeId });

                entity.Property(e => e.AccountEventId).HasColumnName("AccountEventID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.LeadAssignmentTypeId).HasColumnName("LeadAssignmentTypeID");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UsersInAccountEvents)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsersInAccountEvents_Users");
            });

            modelBuilder.Entity<UsersInDesks>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.DeskId });

                entity.HasIndex(e => e.DeskId)
                    .HasName("IX_UsersInDesks");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.DeskId).HasColumnName("DeskID");

                entity.Property(e => e.OfficeId)
                    .HasColumnName("OfficeID")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Desk)
                    .WithMany(p => p.UsersInDesks)
                    .HasForeignKey(d => d.DeskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsersInDesks_Desks");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UsersInDesks)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UsersInDesks_Users");
            });

            modelBuilder.Entity<UsersInOffices>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.OfficeId });

                entity.HasIndex(e => e.OfficeId)
                    .HasName("IX_UsersInOffices");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.OfficeId).HasColumnName("OfficeID");

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.UsersInOffices)
                    .HasForeignKey(d => d.OfficeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsersInOffices_Offices");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UsersInOffices)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsersInOffices_Users");
            });

            modelBuilder.Entity<UsersInRoles>(entity =>
            {
                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_UserInRoles");

                entity.HasIndex(e => new { e.UserId, e.RoleId })
                    .HasName("_dta_index_04-12-16");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UsersInRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserInRoles_Roles");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UsersInRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserInRoles_Users");
            });

            modelBuilder.Entity<UsersLogin>(entity =>
            {
                entity.HasIndex(e => new { e.UtcloginTime, e.Id, e.AccountId })
                    .HasName("MX1_AccountID_INCL_UTCLoginTime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Browser).HasMaxLength(50);

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficeId).HasColumnName("OfficeID");

                entity.Property(e => e.SessionId)
                    .HasColumnName("SessionID")
                    .HasMaxLength(250);

                entity.Property(e => e.Username).HasMaxLength(50);

                entity.Property(e => e.UtcloginTime)
                    .HasColumnName("UTCLoginTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.UtclogoffTime)
                    .HasColumnName("UTCLogoffTime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<UsersProfilesMapping>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.UsersProfilesMapping)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsersProfilesMapping_Profiles");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UsersProfilesMapping)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsersProfilesMapping_Users");
            });

            modelBuilder.Entity<UtmCampaigns>(entity =>
            {
                entity.HasKey(e => new { e.UtmCampaignId, e.OfficeId, e.UtmCampaign });

                entity.ToTable("UTM_Campaigns");

                entity.Property(e => e.UtmCampaignId)
                    .HasColumnName("utm_campaignID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OfficeId)
                    .HasColumnName("OfficeID")
                    .HasDefaultValueSql("((6))");

                entity.Property(e => e.UtmCampaign)
                    .HasColumnName("utm_campaign")
                    .HasMaxLength(50);

                entity.Property(e => e.AffiliateSourceId)
                    .HasColumnName("AffiliateSourceID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CampaignToken).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateEntered)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<UtmSubCampaignCampaignMapping>(entity =>
            {
                entity.HasKey(e => new { e.UtmSubcampaignId, e.UtmCampaignId });

                entity.ToTable("UTM_SubCampaignCampaignMapping");

                entity.Property(e => e.UtmSubcampaignId).HasColumnName("utm_subcampaignID");

                entity.Property(e => e.UtmCampaignId).HasColumnName("utm_campaignID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<UtmSubCampaigns>(entity =>
            {
                entity.HasKey(e => e.UtmSubcampaignId);

                entity.ToTable("UTM_SubCampaigns");

                entity.Property(e => e.UtmSubcampaignId).HasColumnName("utm_subcampaignID");

                entity.Property(e => e.DateEntered)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SubCampaignToken).HasDefaultValueSql("(newid())");

                entity.Property(e => e.UtmCampaignId).HasColumnName("utm_campaignID");

                entity.Property(e => e.UtmSubcampaign)
                    .IsRequired()
                    .HasColumnName("utm_subcampaign")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Visits>(entity =>
            {
                entity.HasKey(e => e.VisitId)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.DateEntered)
                    .HasName("IX_Visits")
                    .ForSqlServerIsClustered();

                entity.Property(e => e.VisitId).HasColumnName("VisitID");

                entity.Property(e => e.DateEntered).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OfficeId).HasColumnName("OfficeID");

                entity.Property(e => e.PlacementId).HasColumnName("PlacementID");

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.Visits)
                    .HasForeignKey(d => d.OfficeId)
                    .HasConstraintName("FK_Visits_Placements");
            });

            modelBuilder.Entity<WithdrawalRequest>(entity =>
            {
                entity.HasIndex(e => e.AccountEventId)
                    .HasName("MX1_WithdrawalRequest");

                entity.Property(e => e.WithdrawalRequestId).HasColumnName("WithdrawalRequestID");

                entity.Property(e => e.AccountEventId).HasColumnName("AccountEventID");

                entity.Property(e => e.ApprovedAmount)
                    .HasColumnType("decimal(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsCompliance).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsFinance).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsRetention).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifyDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RequestedAmount)
                    .HasColumnType("decimal(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusId)
                    .HasColumnName("statusID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TraceId)
                    .HasColumnName("TraceID")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WdaccountEventId).HasColumnName("WDAccountEventId");
            });

            modelBuilder.Entity<XmlwithOpenXml>(entity =>
            {
                entity.ToTable("XMLwithOpenXML");

                entity.Property(e => e.LoadedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Xmldata)
                    .HasColumnName("XMLData")
                    .HasColumnType("xml");
            });
        }
    }
}
