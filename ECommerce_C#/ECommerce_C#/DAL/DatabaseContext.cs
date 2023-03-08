﻿using ECommerce_C_.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerce_C_.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            
        }

        public DbSet<Country> Countries { get; set; }
    }
}
