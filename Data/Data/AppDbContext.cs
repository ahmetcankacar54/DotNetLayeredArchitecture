using System;
using Microsoft.EntityFrameworkCore;
using Data.Entities.Concretes;

namespace Data
{
        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {
            }

            public DbSet<Product> Products { get; set; }
            public DbSet<User> Users { get; set; }
            public DbSet<Category> Categories { get; set; }
            public DbSet<Brand> Brands { get; set; }
            public DbSet<Order> Orders { get; set; }

        
        }

}

