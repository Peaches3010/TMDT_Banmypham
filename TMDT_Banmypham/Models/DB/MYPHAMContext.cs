using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TMDT_Banmypham.Models.DB
{
    public partial class MYPHAMContext : DbContext
    {
        public MYPHAMContext()
        {
        }

        public MYPHAMContext(DbContextOptions<MYPHAMContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Baiviet> Baiviet { get; set; }
        public virtual DbSet<Loaisanpham> Loaisanpham { get; set; }
        public virtual DbSet<Sanpham> Sanpham { get; set; }
        public virtual DbSet<Thanhphan> Thanhphan { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-K7V6G3D\\SQLEXPRESS;Database=MYPHAM;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Baiviet>(entity =>
            {
                entity.HasKey(e => e.MaBv)
                    .HasName("PK__BAIVIET__272475955FA3AC40");

                entity.ToTable("BAIVIET");

                entity.Property(e => e.MaBv)
                    .HasColumnName("MaBV")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MoTaBv)
                    .HasColumnName("MoTaBV")
                    .HasMaxLength(200);

                entity.Property(e => e.TieuDeBv)
                    .IsRequired()
                    .HasColumnName("TieuDeBV")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Loaisanpham>(entity =>
            {
                entity.HasKey(e => e.MaLsp)
                    .HasName("PK__LOAISANP__3B983FFE21785F1A");

                entity.ToTable("LOAISANPHAM");

                entity.Property(e => e.MaLsp)
                    .HasColumnName("MaLSP")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TenLsp)
                    .IsRequired()
                    .HasColumnName("TenLSP")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Sanpham>(entity =>
            {
                entity.HasKey(e => e.MaSp)
                    .HasName("PK__SANPHAM__2725081C8A8A56D2");

                entity.ToTable("SANPHAM");

                entity.Property(e => e.MaSp)
                    .HasColumnName("MaSP")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GiaSp)
                    .HasColumnName("GiaSP")
                    .HasColumnType("money");

                entity.Property(e => e.Hinhanh)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MaLsp)
                    .IsRequired()
                    .HasColumnName("MaLSP")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MoTaSp)
                    .HasColumnName("MoTaSP")
                    .HasMaxLength(4000);

                entity.Property(e => e.TenSp)
                    .IsRequired()
                    .HasColumnName("TenSP")
                    .HasMaxLength(100);

                entity.Property(e => e.ThuongHieu)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.MaLspNavigation)
                    .WithMany(p => p.Sanpham)
                    .HasForeignKey(d => d.MaLsp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SANPHAM__MaLSP__440B1D61");
            });

            modelBuilder.Entity<Thanhphan>(entity =>
            {
                entity.HasKey(e => e.MaTp)
                    .HasName("PK__THANHPHA__2725007DBDC22A2E");

                entity.ToTable("THANHPHAN");

                entity.Property(e => e.MaTp)
                    .HasColumnName("MaTP")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mdat).HasColumnName("MDAT");

                entity.Property(e => e.MoTaTp)
                    .HasColumnName("MoTaTP")
                    .HasMaxLength(20);

                entity.Property(e => e.TenTp)
                    .IsRequired()
                    .HasColumnName("TenTP")
                    .HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
