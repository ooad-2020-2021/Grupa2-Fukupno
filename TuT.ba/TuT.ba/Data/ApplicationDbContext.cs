using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TuT.ba.Models;

namespace TuT.ba.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<TuT.ba.Models.Predmet> Predmet { get; set; }
        public DbSet<TuT.ba.Models.Student> Student { get; set; }
        public DbSet<TuT.ba.Models.Instrukcija> Instrukcija { get; set; }
        public DbSet<TuT.ba.Models.Materijal> Materijal { get; set; }
    }
}
