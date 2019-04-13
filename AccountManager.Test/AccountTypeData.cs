using System;
using AccountManager.Data;
using AccountManager.Data.Factory;
using AccountManager.Data.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AccountManager.Test
{
    [TestClass]
    public class AccountTypeData
    {

        private AccountManagerDbContext context;

        public AccountTypeData()
        {
            var factory = new AccountManagerDesignTimeFactory();
            context = factory.CreateDbContext(null);
        }

     

        [TestMethod]
        public void AddOK()
        {
            AccountType accountType = new AccountType { Codigo = "ACT", Name = "Activos" };
            context.AccountType.Add(accountType);
            if (context.ChangeTracker.HasChanges()) {
                int rowsAffected = context.SaveChanges();

                Assert.AreNotEqual(0, rowsAffected);
            }
        }
    }
}
