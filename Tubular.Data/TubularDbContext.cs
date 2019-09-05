using Microsoft.EntityFrameworkCore;
using System;
using Tubular.Data.Entities;

namespace Tubular.Data
{
    public class TubularDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=Tubular;Trusted_Connection=True;");
        }
    }
}
