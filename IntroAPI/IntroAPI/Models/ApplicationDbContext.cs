using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IntroAPI.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Artist> Artist { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>()
                .ToTable("Artist")
                .HasKey(c => c.ArtistId);
        }
    }
}