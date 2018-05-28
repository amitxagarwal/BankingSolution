using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace BankingSolution.Models
{
    public class BankDBContext : DbContext
    {
        public DbSet<Transaction> transDBSet { get; set; }
        public DbSet<Account> accDBSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)    
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();            
        }


    }
}