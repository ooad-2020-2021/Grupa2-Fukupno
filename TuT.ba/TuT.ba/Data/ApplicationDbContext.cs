using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TuT.ba.Models;

namespace TuT.ba.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<TuT.ba.Models.Predmet> Predmet { get; set; }
        public DbSet<TuT.ba.Models.Student> Student { get; set; }
        public DbSet<TuT.ba.Models.Korisnik> Korisnik { get; set; }
        public DbSet<TuT.ba.Models.Tutor> Tutor { get; set; }
        public DbSet<TuT.ba.Models.Instrukcija> Instrukcija { get; set; }
        public DbSet<TuT.ba.Models.Materijal> Materijal { get; set; }

        public DbSet<TuT.ba.Models.BankovniRacun> BankovniRacun { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Predmet>().ToTable("Predmet");
            modelBuilder.Entity<Instrukcija>().ToTable("Instrukcija");
            modelBuilder.Entity<Korisnik>().ToTable("Korisnik");
            modelBuilder.Entity<Materijal>().ToTable("Materijal");
            modelBuilder.Entity<BankovniRacun>().ToTable("BankovniRacun");

        }
    }
}
