using Microsoft.EntityFrameworkCore;
using Project_WebApps_R0901534_ASP.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Project_WebApps_R0901534_ASP.Areas.Identity;

namespace Project_WebApps_R0901534_ASP.Data
{
    public class ForzaContext : IdentityDbContext<Gebruiker>
    {
        public ForzaContext(DbContextOptions<ForzaContext> options) : base(options)
        {
        }

        public DbSet<Gebruiker> Gebruikers { get; set; }
        public DbSet<Auto> Autos { get; set; }
        public DbSet<AutoKlasse> AutoKlasses { get; set; }
        public DbSet<Circuit> Circuits { get; set; }
        public DbSet<GebruikerAuto> GebruikerAutos { get; set; }
        public DbSet<Klasse> Klasses { get; set; }
        public DbSet<Laptime> Laptimes { get; set; }
        public DbSet<Merk> Merken { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<OverMij> OverMijs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Forza;Trusted_Connection=True;");
        }
    }
}