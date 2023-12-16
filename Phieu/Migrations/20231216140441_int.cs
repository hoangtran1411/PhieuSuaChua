using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhieuSuaChua.Migrations
{
    /// <inheritdoc />
    public partial class @int : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ModelChiTietPhieuMucs",
                columns: table => new
                {
                    ID_MUC = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MA_NV_GUI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TEN_NV_GUI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DON_VI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MA_NV_NHAN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TEN_NV_NHAN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TEN_HOP_MUC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TINH_TRANG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NGAY_GUI = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NGAY_SUA_XONG = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NGAY_TRA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GHI_CHU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TRANG_THAI_PHIEU = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelChiTietPhieuMucs", x => x.ID_MUC);
                });

            migrationBuilder.CreateTable(
                name: "ModelChiTietPhieuSuas",
                columns: table => new
                {
                    ID_PHIEU = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MA_NV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DON_VI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TEN_NV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TEN_PC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ACCOUNT_NAMES = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ACCOUNT_PASS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    THIET_BI_KHAC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TINH_TRANG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GHI_CHU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TRANG_THAI_PHIEU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LOAI_SUA_CHUA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NGAY_TAO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NGAY_TRA = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelChiTietPhieuSuas", x => x.ID_PHIEU);
                });

            migrationBuilder.CreateTable(
                name: "ModelTraCuuPhieuMucs",
                columns: table => new
                {
                    ID_MUC = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LOAI_MAY_IN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NGAY_GUI = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NGAY_SUA_XONG = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NGAY_TRA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DON_VI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TEN_NV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TEN_HOP_MUC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TRANG_THAI_PHIEU = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelTraCuuPhieuMucs", x => x.ID_MUC);
                });

            migrationBuilder.CreateTable(
                name: "ModelTraCuuPhieus",
                columns: table => new
                {
                    ID_PHIEU = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NGAY_TAO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TEN_NV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DON_VI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TEN_PC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    THIET_BI_KHAC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TRANG_THAI_PHIEU = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelTraCuuPhieus", x => x.ID_PHIEU);
                });

            migrationBuilder.CreateTable(
                name: "NHANVIEN",
                columns: table => new
                {
                    MA_NV = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    TEN_NV = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DON_VI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CHUC_DANH = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "(N'NHÂN VIÊN')"),
                    QUYEN = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__NHANVIEN__53E6E93F6EB7353A", x => x.MA_NV);
                });

            migrationBuilder.CreateTable(
                name: "PHIEUMUC",
                columns: table => new
                {
                    ID_MUC = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MA_NV_GUI = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    MA_NV_NHAN = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    NGAY_GUI = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    NGAY_TRA = table.Column<DateTime>(type: "datetime", nullable: true),
                    TRANG_THAI_PHIEU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NGAY_SUA_XONG = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PHIEUMUC__276E66D0E300830C", x => x.ID_MUC);
                    table.ForeignKey(
                        name: "FK__PHIEUMUC__MA_NV___0A9D95DB",
                        column: x => x.MA_NV_GUI,
                        principalTable: "NHANVIEN",
                        principalColumn: "MA_NV");
                });

            migrationBuilder.CreateTable(
                name: "PHIEUSUA",
                columns: table => new
                {
                    ID_PHIEU = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MA_NV = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    NGAY_TAO = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    NGAY_TRA = table.Column<DateTime>(type: "datetime", nullable: true),
                    TRANG_THAI_PHIEU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PHIEUSUA__C8DC3DA745F7693A", x => x.ID_PHIEU);
                    table.ForeignKey(
                        name: "FK__PHIEUSUA__TRANG___02FC7413",
                        column: x => x.MA_NV,
                        principalTable: "NHANVIEN",
                        principalColumn: "MA_NV");
                });

            migrationBuilder.CreateTable(
                name: "CHITIETMUC",
                columns: table => new
                {
                    ID_CHITIET = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_MUC = table.Column<int>(type: "int", nullable: true),
                    TEN_HOP_MUC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LOAI_MAY_IN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GHI_CHU = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TINH_TRANG = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CHITIETM__727EE30841992857", x => x.ID_CHITIET);
                    table.ForeignKey(
                        name: "FK__CHITIETMU__TINH___0D7A0286",
                        column: x => x.ID_MUC,
                        principalTable: "PHIEUMUC",
                        principalColumn: "ID_MUC");
                });

            migrationBuilder.CreateTable(
                name: "CHITIETSUA",
                columns: table => new
                {
                    ID_CHITIET = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_PHIEU = table.Column<int>(type: "int", nullable: true),
                    TEN_PC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ACCOUNT_NAMES = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ACCOUNT_PASS = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    THIET_BI_KHAC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TINH_TRANG = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    GHI_CHU = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    LOAI_SUA_CHUA = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SDT = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CHITIETS__727EE308F5F17C3C", x => x.ID_CHITIET);
                    table.ForeignKey(
                        name: "FK__CHITIETSUA__SDT__05D8E0BE",
                        column: x => x.ID_PHIEU,
                        principalTable: "PHIEUSUA",
                        principalColumn: "ID_PHIEU");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CHITIETMUC_ID_MUC",
                table: "CHITIETMUC",
                column: "ID_MUC");

            migrationBuilder.CreateIndex(
                name: "IX_CHITIETSUA_ID_PHIEU",
                table: "CHITIETSUA",
                column: "ID_PHIEU");

            migrationBuilder.CreateIndex(
                name: "IX_PHIEUMUC_MA_NV_GUI",
                table: "PHIEUMUC",
                column: "MA_NV_GUI");

            migrationBuilder.CreateIndex(
                name: "IX_PHIEUSUA_MA_NV",
                table: "PHIEUSUA",
                column: "MA_NV");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CHITIETMUC");

            migrationBuilder.DropTable(
                name: "CHITIETSUA");

            migrationBuilder.DropTable(
                name: "ModelChiTietPhieuMucs");

            migrationBuilder.DropTable(
                name: "ModelChiTietPhieuSuas");

            migrationBuilder.DropTable(
                name: "ModelTraCuuPhieuMucs");

            migrationBuilder.DropTable(
                name: "ModelTraCuuPhieus");

            migrationBuilder.DropTable(
                name: "PHIEUMUC");

            migrationBuilder.DropTable(
                name: "PHIEUSUA");

            migrationBuilder.DropTable(
                name: "NHANVIEN");
        }
    }
}
