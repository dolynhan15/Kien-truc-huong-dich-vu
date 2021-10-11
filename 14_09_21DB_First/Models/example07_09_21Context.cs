using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace _14_09_21.Models
{
    public partial class example07_09_21Context : DbContext
    {
        public example07_09_21Context()
        {
        }

        public example07_09_21Context(DbContextOptions<example07_09_21Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Lopsh> Lopshes { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=127.0.0.1;user=root;password=12345;database=example07_09_21", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.23-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_0900_ai_ci");

            modelBuilder.Entity<Lopsh>(entity =>
            {
                entity.HasKey(e => e.Idlop)
                    .HasName("PRIMARY");

                entity.ToTable("lopsh");

                entity.Property(e => e.Idlop).HasColumnName("IDLop");

                entity.Property(e => e.Namelop)
                    .HasMaxLength(45)
                    .HasColumnName("nameLop");
            });

            modelBuilder.Entity<SinhVien>(entity =>
            {
                entity.HasKey(e => e.Mssv)
                    .HasName("PRIMARY");

                entity.ToTable("sinh_vien");

                entity.HasIndex(e => e.Idlop, "fkLop_SinhVien_idx");

                entity.Property(e => e.Mssv)
                    .ValueGeneratedNever()
                    .HasColumnName("MSSV");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Idlop).HasColumnName("IDLop");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .HasColumnName("name");

                entity.HasOne(d => d.IdlopNavigation)
                    .WithMany(p => p.SinhViens)
                    .HasForeignKey(d => d.Idlop)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkLop_SinhVien");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
