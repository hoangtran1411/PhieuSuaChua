using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PhieuSuaChua.Domain_Model;

namespace PhieuSuaChua.Models;

public partial class PhieusuachuaContext : DbContext
{
    public PhieusuachuaContext()
    {
    }

    public PhieusuachuaContext(DbContextOptions<PhieusuachuaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Chitietmuc> Chitietmucs { get; set; }

    public virtual DbSet<Chitietsua> Chitietsuas { get; set; }

    public virtual DbSet<Nhanvien> Nhanviens { get; set; }

    public virtual DbSet<Phieumuc> Phieumucs { get; set; }

    public virtual DbSet<Phieusua> Phieusuas { get; set; }
    public virtual DbSet<ModelTraCuuPhieu> ModelTraCuuPhieus { get; set; }
    public virtual DbSet<ModelChiTietPhieuSua> ModelChiTietPhieuSuas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=10.14.12.253,1333;Initial Catalog=PHIEUSUACHUA;Persist Security Info=False;User ID=sasa;Password=Bitis@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Chitietmuc>(entity =>
        {
            entity.HasKey(e => e.IdChitiet).HasName("PK__CHITIETM__727EE3085D8CB3A8");

            entity.ToTable("CHITIETMUC");

            entity.Property(e => e.IdChitiet).HasColumnName("ID_CHITIET");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(100)
                .HasColumnName("GHI_CHU");
            entity.Property(e => e.IdMuc).HasColumnName("ID_MUC");
            entity.Property(e => e.LoaiMayIn)
                .HasMaxLength(50)
                .HasColumnName("LOAI_MAY_IN");
            entity.Property(e => e.TenHopMuc)
                .HasMaxLength(50)
                .HasColumnName("TEN_HOP_MUC");
            entity.Property(e => e.TinhTrang)
                .HasMaxLength(100)
                .HasColumnName("TINH_TRANG");

            entity.HasOne(d => d.IdMucNavigation).WithMany(p => p.Chitietmucs)
                .HasForeignKey(d => d.IdMuc)
                .HasConstraintName("FK__CHITIETMU__TINH___33D4B598");
        });

        modelBuilder.Entity<Chitietsua>(entity =>
        {
            entity.HasKey(e => e.IdChitiet).HasName("PK__CHITIETS__727EE308743817E1");

            entity.ToTable("CHITIETSUA");

            entity.Property(e => e.IdChitiet).HasColumnName("ID_CHITIET");
            entity.Property(e => e.AccountNames)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACCOUNT_NAMES");
            entity.Property(e => e.AccountPass)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACCOUNT_PASS");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(200)
                .HasColumnName("GHI_CHU");
            entity.Property(e => e.IdPhieu).HasColumnName("ID_PHIEU");
            entity.Property(e => e.LoaiSuaChua)
                .HasMaxLength(100)
                .HasColumnName("LOAI_SUA_CHUA");
            entity.Property(e => e.Sdt)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.TenPc)
                .HasMaxLength(50)
                .HasColumnName("TEN_PC");
            entity.Property(e => e.ThietBiKhac)
                .HasMaxLength(50)
                .HasColumnName("THIET_BI_KHAC");
            entity.Property(e => e.TinhTrang)
                .HasMaxLength(200)
                .HasColumnName("TINH_TRANG");

            entity.HasOne(d => d.IdPhieuNavigation).WithMany(p => p.Chitietsuas)
                .HasForeignKey(d => d.IdPhieu)
                .HasConstraintName("FK__CHITIETSUA__SDT__2C3393D0");
        });

        modelBuilder.Entity<Nhanvien>(entity =>
        {
            entity.HasKey(e => e.MaNv).HasName("PK__NHANVIEN__53E6E93F6EB7353A");

            entity.ToTable("NHANVIEN");

            entity.Property(e => e.MaNv)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("MA_NV");
            entity.Property(e => e.ChucDanh)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'NHÂN VIÊN')")
                .HasColumnName("CHUC_DANH");
            entity.Property(e => e.DonVi)
                .HasMaxLength(50)
                .HasColumnName("DON_VI");
            entity.Property(e => e.Quyen)
                .HasDefaultValueSql("((0))")
                .HasColumnName("QUYEN");
            entity.Property(e => e.TenNv)
                .HasMaxLength(50)
                .HasColumnName("TEN_NV");
        });

        modelBuilder.Entity<Phieumuc>(entity =>
        {
            entity.HasKey(e => e.IdMuc).HasName("PK__PHIEUMUC__276E66D0B7A8A2B2");

            entity.ToTable("PHIEUMUC");

            entity.Property(e => e.IdMuc).HasColumnName("ID_MUC");
            entity.Property(e => e.MaNvGui)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("MA_NV_GUI");
            entity.Property(e => e.MaNvNhan)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("MA_NV_NHAN");
            entity.Property(e => e.NgayGui)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("NGAY_GUI");
            entity.Property(e => e.NgayTra)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TRA");
            entity.Property(e => e.TrangThaiPhieu)
                .HasMaxLength(50)
                .HasColumnName("TRANG_THAI_PHIEU");

            entity.HasOne(d => d.MaNvGuiNavigation).WithMany(p => p.PhieumucMaNvGuiNavigations)
                .HasForeignKey(d => d.MaNvGui)
                .HasConstraintName("FK__PHIEUMUC__MA_NV___300424B4");

            entity.HasOne(d => d.MaNvNhanNavigation).WithMany(p => p.PhieumucMaNvNhanNavigations)
                .HasForeignKey(d => d.MaNvNhan)
                .HasConstraintName("FK__PHIEUMUC__MA_NV___30F848ED");
        });

        modelBuilder.Entity<Phieusua>(entity =>
        {
            entity.HasKey(e => e.IdPhieu).HasName("PK__PHIEUSUA__C8DC3DA7B7A5571F");

            entity.ToTable("PHIEUSUA");

            entity.Property(e => e.IdPhieu).HasColumnName("ID_PHIEU");
            entity.Property(e => e.MaNv)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("MA_NV");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NgayTra)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TRA");
            entity.Property(e => e.TrangThaiPhieu)
                .HasMaxLength(50)
                .HasColumnName("TRANG_THAI_PHIEU");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.Phieusuas)
                .HasForeignKey(d => d.MaNv)
                .HasConstraintName("FK__PHIEUSUA__TRANG___29572725");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
