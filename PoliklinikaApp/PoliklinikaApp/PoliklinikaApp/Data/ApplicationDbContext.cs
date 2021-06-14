using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PoliklinikaApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PoliklinikaApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }
            public DbSet<PoliklinikaApp.Models.Doktor> Doktor { get; set; }
            public DbSet<PoliklinikaApp.Models.Pacijent> Pacijent { get; set; }
            public DbSet<PoliklinikaApp.Models.MedicinskiKarton> MedicinskiKarton { get; set; }
            public DbSet<PoliklinikaApp.Models.Nalaz> Nalaz { get; set; }
            public DbSet<PoliklinikaApp.Models.Recept> Recept { get; set; }
            public DbSet<PoliklinikaApp.Models.RasporedZaZakazivanje> RasporedZaZakazivanje { get; set; }
            public DbSet<PoliklinikaApp.Models.RasporedPregleda> RasporedPregleda { get; set; }
            public DbSet<PoliklinikaApp.Models.Pregled> Pregled { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Doktor>().ToTable("Doktor");
            modelBuilder.Entity<Pacijent>().ToTable("Pacijent");
            modelBuilder.Entity<MedicinskiKarton>().ToTable("MedicinskiKarton");
            modelBuilder.Entity<Nalaz>().ToTable("Nalaz");
            modelBuilder.Entity<Recept>().ToTable("Recept");
            modelBuilder.Entity<RasporedZaZakazivanje>().ToTable("RasporedZaZakazivanje");
            modelBuilder.Entity<RasporedPregleda>().ToTable("RasporedPregleda");
            modelBuilder.Entity<Pregled>().ToTable("Pregled");
        }
    }
}
