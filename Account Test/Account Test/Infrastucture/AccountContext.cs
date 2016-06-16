using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Account_Test.Infrastucture
{
    public class AccountContext : DbContext
    {
        public AccountContext() : base("UserAccount")
        {
        }

        public IDbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                 .HasKey(a => a.UserId);
        }
    }
}
