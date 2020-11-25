using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CoffeeClubAPI.Models
{
    public partial class CoffeeClubDBContext : DbContext
    {
        public CoffeeClubDBContext()
        {
        }

        public CoffeeClubDBContext(DbContextOptions<CoffeeClubDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Booking> Booking { get; set; }
        public virtual DbSet<Member> Member { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=CoffeeClubDB;Trusted_Connection=True;");
                optionsBuilder.UseSqlServer("Server=database-1.cglpw9iiyqjp.us-east-1.rds.amazonaws.com,1433;Database=CoffeeClubDB;User=admin;Password=Heyletmein05;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>(entity =>
            {
                entity.HasKey(e => e.BookingNumber);

                entity.Property(e => e.BookingDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Shoutee).HasMaxLength(50);

                entity.Property(e => e.Venue)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Booking)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Memeber_Booking");
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
