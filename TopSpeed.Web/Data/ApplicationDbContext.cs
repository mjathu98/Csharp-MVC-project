﻿using Microsoft.EntityFrameworkCore;
using TopSpeed.Web.Models;

namespace TopSpeed.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Brand> Brands { get; set; }
    }
}
