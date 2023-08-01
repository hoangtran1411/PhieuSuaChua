using Microsoft.AspNetCore.Mvc;
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
            //var listPhieu = (from ChiTietPhieu in context.ChiTietPhieus
            //                 join Phieu in context.Phieus
            //                 on ChiTietPhieu.ID equals Phieu.IDchiTiet
            //                 join NhanVien in context.NhanViens
            //                 on ChiTietPhieu.MaNv equals NhanVien.MaNv
            //                 select new ModelTraCuuPhieu
            //                 {
            //                     Id = Phieu.ID,
            //                     Ngaytaophieu = Phieu.NgayTaoPhieu,
            //                     Hoten = NhanVien.TenNv,
            //                     Donvi = NhanVien.DonVi,
            //                     Maytinh = ChiTietPhieu.TenMayTinh,
            //                     Thietbikhac = ChiTietPhieu.ThietBiKhac,
            //                     Trangthaiphieu = ChiTietPhieu.TrangThaiPhieu
            //                 }).ToList();
            var listPhieu = (from ChiTietPhieu in context.Chitietsuas
                             join Phieusua in context.Phieusuas
                             on ChiTietPhieu.IdPhieu equals Phieusua.IdPhieu
                             join Nhanvien in context.Nhanviens
                             on Phieusua.MaNv equals Nhanvien.MaNv
                             select new ModelTraCuuPhieu
                             {
                                 Id = Phieusua.IdPhieu,
                                 Ngaytaophieu = Phieusua.NgayTao,
                                 Hoten = Nhanvien.TenNv,
                                 Donvi = Nhanvien.DonVi,
                                 Maytinh = ChiTietPhieu.TenPc,
                                 Thietbikhac = ChiTietPhieu.ThietBiKhac,
                                 Trangthaiphieu = Phieusua.TrangThaiPhieu
                             }).ToList();
            //test
                             select new );

            return View(listPhieu);
        }
    }
}
