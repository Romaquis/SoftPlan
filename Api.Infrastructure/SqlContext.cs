using Api.Domain.Entitys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Api.Infrastructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext() { }
        public SqlContext(DbContextOptions<SqlContext> dbContextOptions) : base(dbContextOptions) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public override int SaveChanges()
        {

            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("RegistrerDate") != null))
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Property("RegistrerDate").CurrentValue = DateTime.Now;
                        break;
                }
            }
            return base.SaveChanges();
        }
    }
}
