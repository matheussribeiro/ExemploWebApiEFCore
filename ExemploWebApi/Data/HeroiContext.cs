using ExemploWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ExemploWebApi.Data
{
    public class HeroiContext : DbContext
    {
        public DbSet<Heroi> Herois { get; set; }
        public DbSet<Batalha> Batalhas { get; set; }
        public DbSet<Arma> Armas { get; set; }
        public DbSet<HeroiBatalha> HeroisBatalhas { get; set; }
        public DbSet<IdentidadeSecreta> IdentidadsSecreta { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Password=admin;Persist Security Info=True;User ID=admin;Initial Catalog=HeroApp;Data Source=DESKTOP-2DOFC66\\SQLEXPRESS");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HeroiBatalha>(entity =>
            {
                entity.HasKey(e=> new {e.BatalhaId,e.HeroiId});
            });
        }
    }
}
