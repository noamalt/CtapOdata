using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using CtapOdata.Models.EF;



namespace CtapOdata.Models
{
    public class DepositorsModel
    {
        [Key]
        public int customerId { get; set; }

        public string status { get; set; }

        public string utm_campaign { get; set; }

        public string utm_subcampaign { get; set; }

        public DateTime createdOn { get; set; }

        public DateTime firstDepositOn { get; set; }

        public string ProviderToken { get; set; }

    }

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
        }


        public DbSet<AccountEvents> Depositors { get; set; }


    }
}
