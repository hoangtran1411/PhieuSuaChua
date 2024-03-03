using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhieuSuaChua.Migrations
{
    /// <inheritdoc />
    public partial class removeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ModelChiTietPhieuMucs");

            migrationBuilder.DropTable(
                name: "ModelChiTietPhieuSuas");

            migrationBuilder.DropTable(
                name: "ModelTraCuuPhieuMucs");

            migrationBuilder.DropTable(
                name: "ModelTraCuuPhieus");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ModelChiTietPhieuMucs",
                columns: table => new
                {
                    ID_MUC = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DON_VI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GHI_CHU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MA_NV_GUI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MA_NV_NHAN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NGAY_GUI = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NGAY_SUA_XONG = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NGAY_TRA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TEN_HOP_MUC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TEN_NV_GUI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TEN_NV_NHAN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TINH_TRANG = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    ACCOUNT_NAMES = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ACCOUNT_PASS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DON_VI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GHI_CHU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LOAI_SUA_CHUA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MA_NV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NGAY_TAO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NGAY_TRA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TEN_NV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TEN_PC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    THIET_BI_KHAC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TINH_TRANG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TRANG_THAI_PHIEU = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    DON_VI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LOAI_MAY_IN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NGAY_GUI = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NGAY_SUA_XONG = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NGAY_TRA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TEN_HOP_MUC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TEN_NV = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    DON_VI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NGAY_TAO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TEN_NV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TEN_PC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    THIET_BI_KHAC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TRANG_THAI_PHIEU = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelTraCuuPhieus", x => x.ID_PHIEU);
                });
        }
    }
}
