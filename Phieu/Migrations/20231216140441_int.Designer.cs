﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PhieuSuaChua.Models;

#nullable disable

namespace PhieuSuaChua.Migrations
{
    [DbContext(typeof(PhieusuachuaContext))]
    [Migration("20231216140441_int")]
    partial class @int
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PhieuSuaChua.Domain_Model.ModelChiTietPhieuMuc", b =>
                {
                    b.Property<int>("ID_MUC")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_MUC"));

                    b.Property<string>("DON_VI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GHI_CHU")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MA_NV_GUI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MA_NV_NHAN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("NGAY_GUI")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NGAY_SUA_XONG")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NGAY_TRA")
                        .HasColumnType("datetime2");

                    b.Property<string>("TEN_HOP_MUC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TEN_NV_GUI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TEN_NV_NHAN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TINH_TRANG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TRANG_THAI_PHIEU")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_MUC");

                    b.ToTable("ModelChiTietPhieuMucs");
                });

            modelBuilder.Entity("PhieuSuaChua.Domain_Model.ModelChiTietPhieuSua", b =>
                {
                    b.Property<int>("ID_PHIEU")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_PHIEU"));

                    b.Property<string>("ACCOUNT_NAMES")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ACCOUNT_PASS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DON_VI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GHI_CHU")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LOAI_SUA_CHUA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MA_NV")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("NGAY_TAO")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NGAY_TRA")
                        .HasColumnType("datetime2");

                    b.Property<string>("SDT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TEN_NV")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TEN_PC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("THIET_BI_KHAC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TINH_TRANG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TRANG_THAI_PHIEU")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_PHIEU");

                    b.ToTable("ModelChiTietPhieuSuas");
                });

            modelBuilder.Entity("PhieuSuaChua.Domain_Model.ModelTraCuuPhieu", b =>
                {
                    b.Property<int>("ID_PHIEU")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_PHIEU"));

                    b.Property<string>("DON_VI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("NGAY_TAO")
                        .HasColumnType("datetime2");

                    b.Property<string>("TEN_NV")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TEN_PC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("THIET_BI_KHAC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TRANG_THAI_PHIEU")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_PHIEU");

                    b.ToTable("ModelTraCuuPhieus");
                });

            modelBuilder.Entity("PhieuSuaChua.Domain_Model.ModelTraCuuPhieuMuc", b =>
                {
                    b.Property<int>("ID_MUC")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_MUC"));

                    b.Property<string>("DON_VI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LOAI_MAY_IN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("NGAY_GUI")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NGAY_SUA_XONG")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NGAY_TRA")
                        .HasColumnType("datetime2");

                    b.Property<string>("TEN_HOP_MUC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TEN_NV")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TRANG_THAI_PHIEU")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_MUC");

                    b.ToTable("ModelTraCuuPhieuMucs");
                });

            modelBuilder.Entity("PhieuSuaChua.Models.Chitietmuc", b =>
                {
                    b.Property<int>("IdChitiet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_CHITIET");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdChitiet"));

                    b.Property<string>("GhiChu")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("GHI_CHU");

                    b.Property<int?>("IdMuc")
                        .HasColumnType("int")
                        .HasColumnName("ID_MUC");

                    b.Property<string>("LoaiMayIn")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("LOAI_MAY_IN");

                    b.Property<string>("TenHopMuc")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("TEN_HOP_MUC");

                    b.Property<string>("TinhTrang")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("TINH_TRANG");

                    b.HasKey("IdChitiet")
                        .HasName("PK__CHITIETM__727EE30841992857");

                    b.HasIndex("IdMuc");

                    b.ToTable("CHITIETMUC", (string)null);
                });

            modelBuilder.Entity("PhieuSuaChua.Models.Chitietsua", b =>
                {
                    b.Property<int>("IdChitiet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_CHITIET");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdChitiet"));

                    b.Property<string>("AccountNames")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("ACCOUNT_NAMES");

                    b.Property<string>("AccountPass")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("ACCOUNT_PASS");

                    b.Property<string>("GhiChu")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("GHI_CHU");

                    b.Property<int?>("IdPhieu")
                        .HasColumnType("int")
                        .HasColumnName("ID_PHIEU");

                    b.Property<string>("LoaiSuaChua")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("LOAI_SUA_CHUA");

                    b.Property<string>("Sdt")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("SDT");

                    b.Property<string>("TenPc")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("TEN_PC");

                    b.Property<string>("ThietBiKhac")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("THIET_BI_KHAC");

                    b.Property<string>("TinhTrang")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("TINH_TRANG");

                    b.HasKey("IdChitiet")
                        .HasName("PK__CHITIETS__727EE308F5F17C3C");

                    b.HasIndex("IdPhieu");

                    b.ToTable("CHITIETSUA", (string)null);
                });

            modelBuilder.Entity("PhieuSuaChua.Models.Nhanvien", b =>
                {
                    b.Property<string>("MaNv")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("MA_NV");

                    b.Property<string>("ChucDanh")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("CHUC_DANH")
                        .HasDefaultValueSql("(N'NHÂN VIÊN')");

                    b.Property<string>("DonVi")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("DON_VI");

                    b.Property<int?>("Quyen")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("QUYEN")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("TenNv")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("TEN_NV");

                    b.HasKey("MaNv")
                        .HasName("PK__NHANVIEN__53E6E93F6EB7353A");

                    b.ToTable("NHANVIEN", (string)null);
                });

            modelBuilder.Entity("PhieuSuaChua.Models.Phieumuc", b =>
                {
                    b.Property<int>("IdMuc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_MUC");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMuc"));

                    b.Property<string>("MaNvGui")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("MA_NV_GUI");

                    b.Property<string>("MaNvNhan")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("MA_NV_NHAN");

                    b.Property<DateTime?>("NgayGui")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("NGAY_GUI")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateTime?>("NgaySuaXong")
                        .HasColumnType("datetime")
                        .HasColumnName("NGAY_SUA_XONG");

                    b.Property<DateTime?>("NgayTra")
                        .HasColumnType("datetime")
                        .HasColumnName("NGAY_TRA");

                    b.Property<string>("TrangThaiPhieu")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("TRANG_THAI_PHIEU");

                    b.HasKey("IdMuc")
                        .HasName("PK__PHIEUMUC__276E66D0E300830C");

                    b.HasIndex("MaNvGui");

                    b.ToTable("PHIEUMUC", (string)null);
                });

            modelBuilder.Entity("PhieuSuaChua.Models.Phieusua", b =>
                {
                    b.Property<int>("IdPhieu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_PHIEU");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPhieu"));

                    b.Property<string>("MaNv")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("MA_NV");

                    b.Property<DateTime?>("NgayTao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("NGAY_TAO")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateTime?>("NgayTra")
                        .HasColumnType("datetime")
                        .HasColumnName("NGAY_TRA");

                    b.Property<string>("TrangThaiPhieu")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("TRANG_THAI_PHIEU");

                    b.HasKey("IdPhieu")
                        .HasName("PK__PHIEUSUA__C8DC3DA745F7693A");

                    b.HasIndex("MaNv");

                    b.ToTable("PHIEUSUA", (string)null);
                });

            modelBuilder.Entity("PhieuSuaChua.Models.Chitietmuc", b =>
                {
                    b.HasOne("PhieuSuaChua.Models.Phieumuc", "IdMucNavigation")
                        .WithMany("Chitietmucs")
                        .HasForeignKey("IdMuc")
                        .HasConstraintName("FK__CHITIETMU__TINH___0D7A0286");

                    b.Navigation("IdMucNavigation");
                });

            modelBuilder.Entity("PhieuSuaChua.Models.Chitietsua", b =>
                {
                    b.HasOne("PhieuSuaChua.Models.Phieusua", "IdPhieuNavigation")
                        .WithMany("Chitietsuas")
                        .HasForeignKey("IdPhieu")
                        .HasConstraintName("FK__CHITIETSUA__SDT__05D8E0BE");

                    b.Navigation("IdPhieuNavigation");
                });

            modelBuilder.Entity("PhieuSuaChua.Models.Phieumuc", b =>
                {
                    b.HasOne("PhieuSuaChua.Models.Nhanvien", "MaNvGuiNavigation")
                        .WithMany("Phieumucs")
                        .HasForeignKey("MaNvGui")
                        .HasConstraintName("FK__PHIEUMUC__MA_NV___0A9D95DB");

                    b.Navigation("MaNvGuiNavigation");
                });

            modelBuilder.Entity("PhieuSuaChua.Models.Phieusua", b =>
                {
                    b.HasOne("PhieuSuaChua.Models.Nhanvien", "MaNvNavigation")
                        .WithMany("Phieusuas")
                        .HasForeignKey("MaNv")
                        .HasConstraintName("FK__PHIEUSUA__TRANG___02FC7413");

                    b.Navigation("MaNvNavigation");
                });

            modelBuilder.Entity("PhieuSuaChua.Models.Nhanvien", b =>
                {
                    b.Navigation("Phieumucs");

                    b.Navigation("Phieusuas");
                });

            modelBuilder.Entity("PhieuSuaChua.Models.Phieumuc", b =>
                {
                    b.Navigation("Chitietmucs");
                });

            modelBuilder.Entity("PhieuSuaChua.Models.Phieusua", b =>
                {
                    b.Navigation("Chitietsuas");
                });
#pragma warning restore 612, 618
        }
    }
}
