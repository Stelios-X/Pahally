using Microsoft.EntityFrameworkCore;
using Pahally.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pahally.Data
{
    public class PahallyContext: DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Database=Pahally;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
