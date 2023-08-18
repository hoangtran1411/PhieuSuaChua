using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Phieu.Models;
using PhieuSuaChua.Domain_Model;
using PhieuSuaChua.Models;

namespace PhieuSuaChua.Controllers
{
    public class TraCuuPhieuController : Controller
    {
        private PhieusuachuaContext context;
        public TraCuuPhieuController(PhieusuachuaContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var listPhieu = (from Chitietsua in context.Chitietsuas 
                             join Phieusua in context.Phieusuas 
                             on Chitietsua.IdPhieu equals Phieusua.IdPhieu
                             join Nhanvien in context.Nhanviens
                             on Phieusua.MaNv equals Nhanvien.MaNv
                             orderby Phieusua.IdPhieu descending
                             select new ModelTraCuuPhieu
                             {
                                 Id = Phieusua.IdPhieu,
                                 Ngaytaophieu = Phieusua.NgayTao,
                                 Hoten = Nhanvien.TenNv,
                                 Donvi = Nhanvien.DonVi,
                                 Maytinh = Chitietsua.TenPc,
                                 Thietbikhac = Chitietsua.ThietBiKhac,
                                 Trangthaiphieu = Phieusua.TrangThaiPhieu
                             }).ToList();
                            
            return View(listPhieu);
        }
        public IActionResult ChiTietPhieuSua(int id) 
        {
            var chitietphieu = (from chitietsua in context.Chitietsuas
                                join phieusua in context.Phieusuas
                                on chitietsua.IdPhieu equals phieusua.IdPhieu
                                join nhanvien in context.Nhanviens
                                on phieusua.MaNv equals nhanvien.MaNv
                                select new ModelChiTietPhieuSua
                                {
                                    Id = phieusua.IdPhieu,
                                    MaNV = nhanvien.MaNv,
                                    DonVi = nhanvien.DonVi,
                                    Hoten = nhanvien.TenNv,
                                    Sdt = chitietsua.Sdt,
                                    TenMayTinh = chitietsua.TenPc,
                                    UserName = chitietsua.AccountNames,
                                    Password = chitietsua.AccountPass,
                                    Thietbikhac = chitietsua.ThietBiKhac,
                                    TinhTrang = chitietsua.TinhTrang,
                                    GhiChu = chitietsua.GhiChu,
                                    Trangthaiphieu = phieusua.TrangThaiPhieu,
                                    LoaiSuaChua = chitietsua.LoaiSuaChua

                                }).Where(x=>x.Id == id).ToList();

            return View(chitietphieu); 
        }
        public IActionResult XacNhanPhieu()
        {
            return View(); 
        }
    }
}
