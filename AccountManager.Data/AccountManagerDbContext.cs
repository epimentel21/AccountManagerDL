using AccountManager.Data.Models;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManager.Data
{
    public class AccountManagerDbContext : DbContext
    {
        public AccountManagerDbContext(DbContextOptions<AccountManagerDbContext> options) : base(options)
        {

        }

        public DbSet<AccountType> AccountType { get; set; }
        public DbSet<Account> Account { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountType>()
                .HasKey(option => option.Id);

            modelBuilder.Entity<Account>()
                .HasKey(option => option.Id);

            modelBuilder.Entity<AccountType>()
                .HasIndex(option => option.Codigo)
                .IsUnique(true);

            modelBuilder.Entity<Account>()
                .HasIndex(option => option.Code)
                .IsUnique(true);

            modelBuilder.Entity<Account>()
                .HasOne(option => option.AccountType)
                .WithMany(opt => opt.Accounts)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
