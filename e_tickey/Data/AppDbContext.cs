using e_tickey.Models;
using Microsoft.EntityFrameworkCore;

namespace e_tickey.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActorMovie>().HasKey( am => new {
                am.ActorId,
                am.MovieId
            });

            modelBuilder.Entity<ActorMovie>().HasOne(m => m.Movie).WithMany(am => am.ActorMovies).HasForeignKey(m =>
            m.MovieId);

            modelBuilder.Entity<ActorMovie>().HasOne(m => m.Actor).WithMany(am => am.ActorMovies).HasForeignKey(m =>
            m.ActorId);


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actors => Set<Actor>();
        public DbSet<Cinema> Cinemas => Set<Cinema>();
        public DbSet<Movie> Movies => Set<Movie>();
        public DbSet<Producer> Producers => Set<Producer>();
        public DbSet<ActorMovie> ActorMovies => Set<ActorMovie>();
    }
}