using Floren.Data.EntityFramework.Maps;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Floren.Data.EntityFramework
{
    public class FlorenDataContext : DbContext
    {
        private readonly IConfiguration _config;


        public FlorenDataContext(IConfiguration config)
        {
            _config = config;
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("FlorenConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FarmaciaMap());
            modelBuilder.ApplyConfiguration(new PlantaoMap());

            modelBuilder.Seed();

        }

    }

}