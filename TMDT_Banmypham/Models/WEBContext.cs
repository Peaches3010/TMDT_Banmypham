using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TMDT_Banmypham.Models
{
    public partial class WEBContext : DbContext
    {
        public WEBContext()
        {
        }

        public WEBContext(DbContextOptions<WEBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Giohang> Giohang { get; set; }
        public virtual DbSet<GiohangNguoisudung> GiohangNguoisudung { get; set; }
        public virtual DbSet<GiohangSanpham> GiohangSanpham { get; set; }
        public virtual DbSet<Hinhanh> Hinhanh { get; set; }
        public virtual DbSet<Loaisanpham> Loaisanpham { get; set; }
        public virtual DbSet<Nguoisudung> Nguoisudung { get; set; }
        public virtual DbSet<Sanpham> Sanpham { get; set; }
        public virtual DbSet<SanphamThanhphan> SanphamThanhphan { get; set; }
        public virtual DbSet<Thanhphan> Thanhphan { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=WEB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Giohang>(entity =>
            {
                entity.HasKey(e => e.MaGh)
                    .HasName("PK__GIOHANG__2725AE859EBD1B2D");

                entity.ToTable("GIOHANG");

                entity.Property(e => e.MaGh)
                    .HasColumnName("MaGH")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TongGia).HasColumnType("money");
            });

            modelBuilder.Entity<GiohangNguoisudung>(entity =>
            {
                entity.HasKey(e => new { e.MaGh, e.MaNsd })
                    .HasName("PK__GIOHANG___5484133B20E73B4B");

                entity.ToTable("GIOHANG_NGUOISUDUNG");

                entity.Property(e => e.MaGh)
                    .HasColumnName("MaGH")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaNsd)
                    .HasColumnName("MaNSD")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.MaGhNavigation)
                    .WithMany(p => p.GiohangNguoisudung)
                    .HasForeignKey(d => d.MaGh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GIOHANG_NG__MaGH__07C12930");

                entity.HasOne(d => d.MaNsdNavigation)
                    .WithMany(p => p.GiohangNguoisudung)
                    .HasForeignKey(d => d.MaNsd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GIOHANG_N__MaNSD__08B54D69");
            });

            modelBuilder.Entity<GiohangSanpham>(entity =>
            {
                entity.HasKey(e => new { e.MaGh, e.MaSp })
                    .HasName("PK__GIOHANG___F557FE0489BE77FF");

                entity.ToTable("GIOHANG_SANPHAM");

                entity.Property(e => e.MaGh)
                    .HasColumnName("MaGH")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaSp)
                    .HasColumnName("MaSP")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.MaGhNavigation)
                    .WithMany(p => p.GiohangSanpham)
                    .HasForeignKey(d => d.MaGh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GIOHANG_SA__MaGH__03F0984C");

                entity.HasOne(d => d.MaSpNavigation)
                    .WithMany(p => p.GiohangSanpham)
                    .HasForeignKey(d => d.MaSp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GIOHANG_SA__MaSP__04E4BC85");
            });

            modelBuilder.Entity<Hinhanh>(entity =>
            {
                entity.HasKey(e => e.MaHa)
                    .HasName("PK__HINHANH__2725A6FDA017CA55");

                entity.ToTable("HINHANH");

                entity.Property(e => e.MaHa)
                    .HasColumnName("MaHA")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TenHa)
                    .IsRequired()
                    .HasColumnName("TenHA")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Loaisanpham>(entity =>
            {
                entity.HasKey(e => e.MaLsp)
                    .HasName("PK__LOAISANP__3B983FFE6241861E");

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

            modelBuilder.Entity<Nguoisudung>(entity =>
            {
                entity.HasKey(e => e.MaNsd)
                    .HasName("PK__NGUOISUD__3A1BDBE61FB5631C");

                entity.ToTable("NGUOISUDUNG");

                entity.Property(e => e.MaNsd)
                    .HasColumnName("MaNSD")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Diachi)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.MatKhauNsd)
                    .IsRequired()
                    .HasColumnName("MatKhauNSD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NgaySinh).HasColumnType("datetime");

                entity.Property(e => e.Sdt).HasColumnName("SDT");

                entity.Property(e => e.TaiKhoanNsd)
                    .IsRequired()
                    .HasColumnName("TaiKhoanNSD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TenNsd)
                    .IsRequired()
                    .HasColumnName("TenNSD")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Sanpham>(entity =>
            {
                entity.HasKey(e => e.MaSp)
                    .HasName("PK__SANPHAM__2725081CA266C53B");

                entity.ToTable("SANPHAM");

                entity.Property(e => e.MaSp)
                    .HasColumnName("MaSP")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DatSp)
                    .IsRequired()
                    .HasColumnName("DAT_SP")
                    .HasMaxLength(15);

                entity.Property(e => e.GiaSp)
                    .HasColumnName("GiaSP")
                    .HasColumnType("money");

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
                    .HasConstraintName("FK__SANPHAM__MaLSP__7B5B524B");
            });

            modelBuilder.Entity<SanphamThanhphan>(entity =>
            {
                entity.HasKey(e => new { e.MaSp, e.MaTp })
                    .HasName("PK__SANPHAM___E557581B59596E02");

                entity.ToTable("SANPHAM_THANHPHAN");

                entity.Property(e => e.MaSp)
                    .HasColumnName("MaSP")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaTp)
                    .HasColumnName("MaTP")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.MaSpNavigation)
                    .WithMany(p => p.SanphamThanhphan)
                    .HasForeignKey(d => d.MaSp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SANPHAM_TH__MaSP__7E37BEF6");

                entity.HasOne(d => d.MaTpNavigation)
                    .WithMany(p => p.SanphamThanhphan)
                    .HasForeignKey(d => d.MaTp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SANPHAM_TH__MaTP__7F2BE32F");
            });

            modelBuilder.Entity<Thanhphan>(entity =>
            {
                entity.HasKey(e => e.MaTp)
                    .HasName("PK__THANHPHA__2725007D816EBA95");

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
