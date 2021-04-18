using Domain.Entities;
using Flunt.Notifications;
using Microsoft.EntityFrameworkCore;
using System;

namespace Domain
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<Person> PersonSet { get; set; }
        public DbSet<PersonAddress> PersonAddressSet { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<PayPalPayment> PayPalPayments { get; set; }
        public DbSet<BoletoPayment> BoletoPayments{ get; set; }
        public DbSet<CreditCardPayment> CreditCardPayments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Notification>();
        }

    }
}
