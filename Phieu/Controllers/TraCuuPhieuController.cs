using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhieuSuaChua.Domain_Model;
using PhieuSuaChua.Models;

namespace PhieuSuaChua.Controllers
{
    public class TraCuuPhieuController : Controller
    {
        private readonly PhieusuachuaContext context;
        public TraCuuPhieuController(PhieusuachuaContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            // LinQ
            //var listPhieu = (from Chitietsua in context.Chitietsuas
            //                 join Phieusua in context.Phieusuas
            //                 on Chitietsua.IdPhieu equals Phieusua.IdPhieu
            //                 join Nhanvien in context.Nhanviens
            //                 on Phieusua.MaNv equals Nhanvien.MaNv
            //                 //orderby Phieusua.IdPhieu descending
            //                 select new ModelTraCuuPhieu
            //                 {
            //                     Id = Phieusua.IdPhieu,
            //                     Ngaytaophieu = Phieusua.NgayTao,
            //                     Hoten = Nhanvien.TenNv,
            //                     Donvi = Nhanvien.DonVi,
            //                     Maytinh = Chitietsua.TenPc,
            //                     Thietbikhac = Chitietsua.ThietBiKhac,
            //                     Trangthaiphieu = Phieusua.TrangThaiPhieu
            //                 }).ToList();

            // Procedure
            var listPhieu = context.ModelTraCuuPhieus.FromSqlRaw("EXEC GetTraCuuPhieuSua").ToList();
            
            return View(listPhieu);
        }
        public IActionResult ChiTietPhieuSua(int id)
        {
            //var chitietphieu = (from chitietsua in context.Chitietsuas
            //                    join phieusua in context.Phieusuas
            //                    on chitietsua.IdPhieu equals phieusua.IdPhieu
            //                    join nhanvien in context.Nhanviens
            //                    on phieusua.MaNv equals nhanvien.MaNv
            //                    select new ModelChiTietPhieuSua
            //                    {
            //                        Id = phieusua.IdPhieu,
            //                        MaNV = nhanvien.MaNv,
            //                        DonVi = nhanvien.DonVi,
            //                        Hoten = nhanvien.TenNv,
            //                        Sdt = chitietsua.Sdt,
            //                        TenMayTinh = chitietsua.TenPc,
            //                        UserName = chitietsua.AccountNames,
            //                        Password = chitietsua.AccountPass,
            //                        Thietbikhac = chitietsua.ThietBiKhac,
            //                        TinhTrang = chitietsua.TinhTrang,
            //                        GhiChu = chitietsua.GhiChu,
            //                        Trangthaiphieu = phieusua.TrangThaiPhieu,
            //                        LoaiSuaChua = chitietsua.LoaiSuaChua,
            //                        Ngaynhan = phieusua.NgayTao,
            //                        Ngaytra = phieusua.NgayTra
            //                    }).Where(x => x.Id == id).ToList();
            var chitietphieu = context.ModelChiTietPhieuSuas.FromSqlRaw("EXEC GetChiTietPhieuSua {0}", id).ToList();

            return View(chitietphieu);
        }
        [HttpPost]
        public IActionResult XacNhanPhieu(int id, string trangthai)
        {
            var update = context.Phieusuas.Find(id);
            if (update != null)
            {
                if (trangthai == "Đã trả máy")
                {
                    update.TrangThaiPhieu = trangthai;
                    update.NgayTra = DateTime.Now;
                    context.SaveChanges();
                }
                else
                {
                    update.TrangThaiPhieu = trangthai;
                    context.SaveChanges();
                }
                
            }

            return View();
        }

        [HttpPost]
        public IActionResult UpdateGhiChu(int id, string ghichu)
        {
            var update = context.Chitietsuas.Where(idSua => idSua.IdPhieu == id).FirstOrDefault();
            if (update != null)
            {
                update.GhiChu = ghichu;
                context.SaveChanges();
            }
            return View();
        }

        [HttpPost]
        public IActionResult UpdateLoaiSuaChua(int id, string loaisuachua)
        {
            var update = context.Chitietsuas.Where(idSua => idSua.IdPhieu == id).FirstOrDefault();
            if (update != null)
            {
                update.LoaiSuaChua = loaisuachua;
                context.SaveChanges();
            }
            return View();
        }
    }
}
