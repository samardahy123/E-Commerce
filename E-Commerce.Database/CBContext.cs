using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using E_Commerce.Entities;

namespace E_Commerce.Database
{
   public class CBContext : DbContext,IDisposable
    {
        public CBContext() : base("E-CommerceConnection")
        {
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Category>().Property(p => p.Name).IsRequired().HasMaxLength(50);
        //}

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        //public DbSet<Config> Configurations { get; set; }
        //public DbSet<Order> Orders { get; set; }
        //public DbSet<OrderItem> OrderItems { get; set; }
    }
}
