using mariadb.Entities;
using Microsoft.EntityFrameworkCore;
using mariadb.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mariadb.Data
{
    public class AutoparkDbContext : DbContext
    {
        public DbSet<Automobil> Automobili { get; set; }
        public DbSet<Gorivo> Goriva { get; set; }
        public DbSet<Korisnik> Korisnici { get; set; }
        public DbSet<PravnaOsoba> PravneOsobe { get; set; }
        public DbSet<Proizvodjac> Proizvodjaci { get; set; }
        public DbSet<Rezervacija> Rezervacije { get; set; }
        public DbSet<Servis> Servisi { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(
    // Use the connection string from the configuration helper

    ConfigurationHelper.GetConnectionString("AutoparkContext"),
    ServerVersion.AutoDetect(ConfigurationHelper.GetConnectionString("AutoparkContext"))
);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}