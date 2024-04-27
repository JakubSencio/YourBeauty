using System;
using System.Data.Entity;
using System.Linq;
using YourBeauty.Models.Configurations;
using YourBeauty.Models.Domains;

namespace YourBeauty
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("name=ApplicationDbContext")
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Pricing> Pricings { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClientConfiguration());
            modelBuilder.Configurations.Add(new PricingConfiguration());

        }
    }
}