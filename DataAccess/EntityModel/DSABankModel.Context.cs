﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess.EntityModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<ErrorLog> ErrorLogs { get; set; }
        public DbSet<EventLog> EventLogs { get; set; }
        public DbSet<FixedTermAccount> FixedTermAccounts { get; set; }
        public DbSet<FixedTerm> FixedTerms { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<InterestRate> InterestRates { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionType> TransactionTypes { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
