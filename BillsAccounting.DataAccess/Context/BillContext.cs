using System;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using BillsAccounting.Models;
using BillsAccounting.Models.BillsComponents;

namespace BillsAccounting.DataAccess.Context
{
    public class BillContext : DbContext
    {
        public BillContext(DbContextOptions options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<Service>()
                .HasKey(x => x.SercviceId);

            modelBuilder.Entity<Bill>()
                .HasKey(x => x.BillId);
            
            modelBuilder.Entity<Bill>()
                .HasOne(x => x.ColdWater);
            modelBuilder.Entity<Bill>()
                .HasOne(x => x.HotWaterAndHeating);
                modelBuilder.Entity<Bill>()
                .HasOne(x => x.Electricity);
        }
        public DbSet<Service> Services {get; set;}
        public DbSet<Bill> Bills {get; set;}
    }
}