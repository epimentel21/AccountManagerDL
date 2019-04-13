using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManager.Data.Factory
{
    public class AccountManagerDesignTimeFactory : IDesignTimeDbContextFactory<AccountManagerDbContext>
    {
        public AccountManagerDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AccountManagerDbContext>();

            optionsBuilder.UseSqlServer(@"Server=DRLT15;Database=DbAccountManager;Integrated Security = True");

            return new AccountManagerDbContext(optionsBuilder.Options);
        }
    }
}
