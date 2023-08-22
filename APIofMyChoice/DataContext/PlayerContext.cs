using APIofMyChoice.Models;
using Microsoft.EntityFrameworkCore;
namespace APIofMyChoice.DataContext
{
    public class PlayerContext : DbContext 
    {
        private const string CONNECTION_STRING = "Server=(localdb)\\mssqllocaldb;Database=APIofMyChoice;Trusted_Connection=True;MultipleActiveResultSets=true";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(CONNECTION_STRING);
        }

        public DbSet<PlayerModel> Players { get; set; }

        public DbSet<TeamModel> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlayerModel>().HasData(
               new PlayerModel {Id = 1, Name = "Stephen Curry", Archetype = "Shooting Playmaker", JerseyNumber = 30, Position = "PG", TeamId = 1, },
               new PlayerModel {Id = 2, Name = "Giannis Antetokounmpo", Archetype = "2-Way Slasher", JerseyNumber = 34, Position = "PF", TeamId = 2 },
               new PlayerModel {Id = 3, Name = "Klay Thompson", Archetype = "2-Way 3pt Specialist", JerseyNumber = 11, Position = "SG", TeamId = 1},
               new PlayerModel {Id = 4, Name = "Nikola Jokic", Archetype = "Playmaking Big", JerseyNumber = 15, Position = "C", TeamId = 3 },
               new PlayerModel {Id = 5, Name = "Jaren Jackson Jr.", Archetype = "2-Way Stretch Big", JerseyNumber = 13, Position = "PF", TeamId = 4 },
               new PlayerModel {Id = 6, Name = "Scoot Henderson", Archetype = "Slashing Playmaker", JerseyNumber = 0, Position = "PG", TeamId = 5 },
               new PlayerModel {Id = 7, Name = "Victor Wembanyama", Archetype = "Unicorn", JerseyNumber = 1, Position = "C", TeamId = 6 },
               new PlayerModel {Id = 8, Name = "Duncan Robinson", Archetype = "Pure 3pt Specialist", JerseyNumber = 55, Position = "SG", TeamId = 7 },
               new PlayerModel {Id = 9, Name = "Lamelo Ball", Archetype = "Playmaking Shot Creator", JerseyNumber = 1, Position = "PG", TeamId = 8 });

            modelBuilder.Entity<TeamModel>().HasData(
                new TeamModel { Id = 1, TeamName = "Warriors", TeamOvr = 89 },
                new TeamModel { Id = 2, TeamName = "Bucks", TeamOvr = 94 },
                new TeamModel { Id = 3, TeamName = "Nuggets", TeamOvr = 97 },
                new TeamModel { Id = 4, TeamName = "Grizzlies", TeamOvr = 91 },
                new TeamModel { Id = 5, TeamName = "Trailblazers", TeamOvr = 83 },
                new TeamModel { Id = 6, TeamName = "Spurs", TeamOvr = 80 },
                new TeamModel { Id = 7, TeamName = "Heat", TeamOvr = 92 },
                new TeamModel { Id = 8, TeamName = "Hornets", TeamOvr = 81 });
        }


    }
}
