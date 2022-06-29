using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OnlineAdz.Models
{
    public partial class AdApplicationContext : DbContext
    {
        public AdApplicationContext()
        {
        }

        public AdApplicationContext(DbContextOptions<AdApplicationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CategoryAd> CategoryAds { get; set; } = null!;
        public virtual DbSet<UserAd> UserAds { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Initial Catalog=AdApplication;User Id=sa;Password=12345");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryAd>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK__Category__19093A0BF1942A85");

                entity.Property(e => e.CategoryId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserAd>(entity =>
            {
                entity.HasKey(e => e.AdId)
                    .HasName("PK__UserAds__7130D5AE87D9A2E0");

                entity.Property(e => e.AdName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AdStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.UserInterest)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                //entity.HasOne(d => d.Category)
                //    .WithMany(p => p.UserAds)
                 //   .HasForeignKey(d => d.CategoryId)
                  //  .OnDelete(DeleteBehavior.ClientSetNull)
                   // .HasConstraintName("FK__UserAds__Categor__1273C1CD");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
