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
            modelBuilder.Entity<User>().Property(m => m.Username).UseCollation("SQL_Latin1_General_CP1_CS_AS");
            modelBuilder.Entity<User>().Property(m => m.Email).UseCollation("SQL_Latin1_General_CP1_CS_AS");
            modelBuilder.Entity<User>().Property(m => m.Password).UseCollation("SQL_Latin1_General_CP1_CS_AS");
            modelBuilder.Entity<User>().Property(m => m.Plan).HasDefaultValue(PlanPayment.FREE);
            modelBuilder.Entity<Playlist>().Property(m => m.Title)
                .IsRequired(false)
                .UseCollation("SQL_Latin1_General_CP1_CS_AS");
            modelBuilder.Entity<Playlist>().HasAlternateKey(r => r.Title);
            modelBuilder.Entity<Playlist>().Property(m => m.Type).HasDefaultValue(EnumPlaylistType.PRIVATE);
            modelBuilder.Entity<Video>().Property(m => m.Title)
                .IsRequired(false)
                .UseCollation("SQL_Latin1_General_CP1_CS_AS");
            modelBuilder.Entity<Video>().Property(m => m.ChannelName)
                .IsRequired(false)
                .UseCollation("SQL_Latin1_General_CP1_CS_AS");
            modelBuilder.Entity<Video>().Property(m => m.Thumbnail)
                .IsRequired(false)
                .UseCollation("SQL_Latin1_General_CP1_CS_AS");
            modelBuilder.Entity<Video>().Property(m => m.VideoId).UseCollation("SQL_Latin1_General_CP1_CS_AS");
            modelBuilder.Entity<CreditCard>().Property(m => m.HolderName).UseCollation("SQL_Latin1_General_CP1_CS_AS");

            base.OnModelCreating(modelBuilder);
        }
    }
}
