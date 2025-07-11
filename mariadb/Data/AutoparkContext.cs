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
        public DbSet<PravnaOsoba> PravneOsobe { get; set; } = null!;
        public DbSet<Proizvodjac> Proizvodjaci { get; set; } = null!;
        public DbSet<Gorivo> Goriva { get; set; } = null!;
        public DbSet<Automobil> Automobili { get; set; } = null!;
        public DbSet<Korisnik> Korisnici { get; set; } = null!;
        public DbSet<Rezervacija> Rezervacije { get; set; } = null!;
        public DbSet<Servis> Servisi { get; set; } = null!;

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
            // Fluent API configurations can be added here if needed
            base.OnModelCreating(modelBuilder);


            // Strictly API configurations for entities
            /*
            modelBuilder.Entity<PravnaOsoba>(entity =>
            {
                entity.HasKey(e => e.IdPravnaOsoba);
                entity.Property(e => e.Naziv).IsRequired().HasMaxLength(255).HasColumnType("varchar(255)");
                entity.Property(e => e.Adresa).IsRequired().HasMaxLength(255).HasColumnType("varchar(255)");
                entity.Property(e => e.Mjesto).IsRequired().HasMaxLength(100).HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<Proizvodjac>(entity =>
            {
                entity.HasKey(e => e.IdProizvodjac);
                entity.Property(e => e.NazivProizvodjaca).IsRequired().HasMaxLength(100).HasColumnType("varchar(100)");

                entity.HasMany(e => e.Automobili)
                      .WithOne(a => a.Proizvodjac)
                      .HasForeignKey(a => a.IdProizvodjac)
                      .OnDelete(DeleteBehavior.Restrict)
                      .HasConstraintName("FK_Automobili_Proizvodjaci");
            });

            modelBuilder.Entity<Gorivo>(entity =>
            {
                entity.HasKey(e => e.IdGoriva);
                entity.Property(e => e.NazivGoriva).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
                entity.Property(e => e.CijenaGoriva).IsRequired().HasColumnType("decimal(6,2)");

                entity.HasMany(e => e.Automobili)
                      .WithOne(a => a.Gorivo)
                      .HasForeignKey(a => a.IdGoriva)
                      .OnDelete(DeleteBehavior.Restrict)
                      .HasConstraintName("FK_Automobili_Goriva");
            });

            modelBuilder.Entity<Automobil>(entity =>
            {
                entity.HasKey(e => e.IdAutomobila);
                entity.Property(e => e.Registracija).IsRequired().HasMaxLength(10).HasColumnType("varchar(10)");
                entity.Property(e => e.DatumRegistracije).HasColumnType("date");
                entity.Property(e => e.Model).IsRequired().HasMaxLength(100).HasColumnType("varchar(100)");
                entity.Property(e => e.GodinaProizvodnje).HasColumnType("int");
                entity.Property(e => e.ccm).HasColumnType("int");
                entity.Property(e => e.kW).HasColumnType("int");
                entity.Property(e => e.Potrosnja).HasColumnType("decimal(4,2)");
                entity.Property(e => e.Dostupan).IsRequired();
                entity.Property(e => e.KilometriNaRegistraciji).HasColumnType("decimal(10,1)");

                entity.HasMany(e => e.Rezervacije)
                      .WithOne(r => r.Automobil)
                      .HasForeignKey(r => r.IdAutomobila)
                      .OnDelete(DeleteBehavior.Restrict)
                      .HasConstraintName("FK_Rezervacije_Automobili");

                entity.HasMany(e => e.Servisi)
                      .WithOne(s => s.Automobil)
                      .HasForeignKey(s => s.IdAutomobila)
                      .OnDelete(DeleteBehavior.Restrict)
                      .HasConstraintName("FK_Servisi_Automobili");
            });

            modelBuilder.Entity<Korisnik>(entity =>
            {
                entity.HasKey(e => e.IdKorisnika);
                entity.Property(e => e.KorisnickoIme).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
                entity.Property(e => e.Lozinka).IsRequired();
                entity.Property(e => e.JeAdmin).IsRequired();
                entity.Property(e => e.ImePrezime).IsRequired();
                entity.Property(e => e.Email).IsRequired();

                entity.HasMany(e => e.Rezervacije)
                      .WithOne(r => r.Korisnik)
                      .HasForeignKey(r => r.IdKorisnika)
                      .OnDelete(DeleteBehavior.Restrict)
                      .HasConstraintName("FK_Rezervacije_Korisnici");
            });

            modelBuilder.Entity<Rezervacija>(entity =>
            {
                entity.HasKey(e => e.IdRezervacije);
                entity.Property(e => e.DatumOdlaska).HasColumnType("date");
                entity.Property(e => e.DatumDolaska).HasColumnType("date");
                entity.Property(e => e.Mjesto).IsRequired().HasMaxLength(100).HasColumnType("varchar(100)");
                entity.Property(e => e.Udaljenost).HasColumnType("decimal(8,2)");
                entity.Property(e => e.RazlogOpis);
                entity.Property(e => e.Odobreno).IsRequired();
            });

            modelBuilder.Entity<Servis>(entity =>
            {
                entity.HasKey(e => e.IdServisa);
                entity.Property(e => e.DatumServisa).HasColumnType("date");
                entity.Property(e => e.CijenaServisa).HasColumnType("decimal(8,2)");
                entity.Property(e => e.OpisServisa).HasMaxLength(255);
            });
            */

        }
    }
}