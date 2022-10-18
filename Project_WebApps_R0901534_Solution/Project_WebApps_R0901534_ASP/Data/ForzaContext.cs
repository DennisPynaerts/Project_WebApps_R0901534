using Microsoft.EntityFrameworkCore;
using Project_WebApps_R0901534_ASP.Models;

namespace Project_WebApps_R0901534_ASP.Data
{
    public class ForzaContext : DbContext
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Forza");
            modelBuilder.Entity<Gebruiker>().ToTable("Gebruiker");
            modelBuilder.Entity<Auto>().ToTable("Auto");
            modelBuilder.Entity<AutoKlasse>().ToTable("AutoKlasse");
            modelBuilder.Entity<Circuit>().ToTable("Circuit");
            modelBuilder.Entity<GebruikerAuto>().ToTable("GebruikerAuto");
            modelBuilder.Entity<Klasse>().ToTable("Klasse");
            modelBuilder.Entity<Laptime>().ToTable("Laptime");
            modelBuilder.Entity<Merk>().ToTable("Merk");
            modelBuilder.Entity<Model>().ToTable("Model");
            modelBuilder.Entity<OverMij>().ToTable("OverMij");
        }
    }
}