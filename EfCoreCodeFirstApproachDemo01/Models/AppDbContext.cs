﻿using Microsoft.EntityFrameworkCore;

namespace EfCoreCodeFirstApproachDemo01.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }



    }
}

