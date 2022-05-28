using ClassLibrary.Database_Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Database_Context
{
    public class AllDatabaseContext : DbContext
    {
        public AllDatabaseContext(DbContextOptions options) : base(options) { }
        
        public DbSet<User> User { get; set; }
        public DbSet<Playlist> Playlist { get; set; }
        public DbSet<Video> Video { get; set; }
        public DbSet<PlaylistVideos> PlaylistVideo { get; set; }
        public DbSet<CreditCard> CreditCard { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Property(m => m.Biography).IsRequired(false);
            modelBuilder.Entity<User>().Property(m => m.DateExpirationPlan).IsRequired(false);
            modelBuilder.Entity<User>().HasAlternateKey(r => r.Username);
            modelBuilder.Entity<Playlist>().Property(m => m.Title).IsRequired(false);
            modelBuilder.Entity<Playlist>().HasAlternateKey(r => r.Title);
            modelBuilder.Entity<Video>().Property(m => m.Title).IsRequired(false);
            modelBuilder.Entity<Video>().Property(m => m.ChannelName).IsRequired(false);
            modelBuilder.Entity<Video>().Property(m => m.Thumbnail).IsRequired(false);

            base.OnModelCreating(modelBuilder);
        }
    }
}
