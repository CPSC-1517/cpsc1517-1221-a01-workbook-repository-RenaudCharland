using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestWindSystem.Entities;

namespace WestWindSystem.DAL
{
    internal class WestWindContext : DbContext
    {
        // Parameterized constructor that allows for Dependency Injection
        public WestWindContext(DbContextOptions<WestWindContext> options) : base(options)
        {
            // You do not need to add any code here
        }

        public DbSet<BuildVersion> BuildVersions => Set<BuildVersion>();

        //public DbSet<Category> Categories => Set<Category>();
    }
}
