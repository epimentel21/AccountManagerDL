﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManager.Data.Factory
{
    public class AccountManagerDesignTimeFactory
        : IDesignTimeDbContextFactory<AccountManagerDbContext>
    {
        public AccountManagerDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = 
                new DbContextOptionsBuilder<AccountManagerDbContext>();

            optionsBuilder.UseSqlServer(@"Data Source=DRLT15;Initial Catalog=AccountManagerModule;Integrated Security=True",
                option=> option.MigrationsAssembly(
                    typeof(AccountManagerDbContext).Assembly.FullName));

            var ctx = new AccountManagerDbContext(optionsBuilder.Options);
                 return ctx;
        }
    }
}
