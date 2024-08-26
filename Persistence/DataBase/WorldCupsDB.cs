
using API.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Persistence.DataBase
{
    public class WorldCupsDB : DbContext
    {
        public WorldCupsDB(DbContextOptions<WorldCupsDB>options) : base (options) 
        {
        }
        public DbSet<ChampionShips> ChampionShips { get; set; }
        public DbSet<Cities> Cities { get; set; }
        public DbSet<Countries> Countries { get; set; }
        public DbSet<CountriesByGroups> CountriesByGroups { get; set; }
        public DbSet<Groups> Groups { get; set; }
        public DbSet<Matches> Matches { get; set; }
        public DbSet<Phases> Phases { get; set; }
        public DbSet<Stadiums> Stadiums { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             modelBuilder.Entity<CountriesByGroups>()
                .HasOne(cbg => cbg.Group)
                .WithMany()
                .HasForeignKey(cbg => cbg.GroupId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CountriesByGroups>()
                .HasOne(cbg => cbg.Country)
                .WithMany()
                .HasForeignKey(cbg => cbg.CountryId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Matches>()
                .HasOne(m => m.FirstCountry)
                .WithMany()
                .HasForeignKey(m => m.FirstCountryId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Matches>()
                .HasOne(m => m.SecondCountry)
                .WithMany()
                .HasForeignKey(m => m.SecondCountryId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Matches>()
                .HasOne(m => m.Stadium)
                .WithMany()
                .HasForeignKey(m => m.StadiumId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Matches>()
                .HasOne(m => m.Phase)
                .WithMany()
                .HasForeignKey(m => m.PhaseId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
