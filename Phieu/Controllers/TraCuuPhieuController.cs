using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhieuSuaChua.Domain_Model;
using PhieuSuaChua.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;

namespace PhieuSuaChua.Controllers
{
    public class TraCuuPhieuController : Controller
    {
        private readonly PhieusuachuaContext context;
        public TraCuuPhieuController(PhieusuachuaContext context)
        {
            this.context = context;
        }

        public async Task<IActionResult> Index()
        {
            // Phuong phap LinQ
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

            //Phuong phap Procedure
            var listPhieu = await context.ModelTraCuuPhieus.FromSqlRaw("EXEC GetTraCuuPhieuSua").ToListAsync();
            var listMuc = await context.ModelTraCuuPhieuMucs.FromSqlRaw("EXEC GetTraCuuPhieuMuc").ToListAsync();

            var list = new ModelTraCuu()
            {
                TraCuuPhieus = listPhieu,
                TraCuuPhieuMucs = listMuc
            };

            return View(list);
        }
        public async Task<IActionResult> ChiTietPhieuSua(int id)
        {
            // Phuong phap LinQ
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

            //Phuong phap Procedure
            var chitietphieu = await context.ModelChiTietPhieuSuas.FromSqlRaw("EXEC GetChiTietPhieuSua {0}", id).ToListAsync();

            return View(chitietphieu);
        }
        [Authorize]
        [HttpPost]
        public async Task<JsonResult> XacNhanPhieu(int id, string trangthai)
        {
            string message ="NOT";
            int i = 0;
            var update = context.Phieusuas.Find(id);
            if (update != null)
            {
                if (trangthai == "Đã trả máy")
                {
                    update.TrangThaiPhieu = trangthai;
                    update.NgayTra = DateTime.Now;
                }
                else
                {
                    update.TrangThaiPhieu = trangthai;                    
                }
                i = await context.SaveChangesAsync();
                message = "OK";
            }
           
            return Json(new { mesage = message, model = i});
        }
        [Authorize]
        [HttpPost]
        public async Task<JsonResult> UpdateGhiChu(int id, string ghichu)
        {
            string message = "NOT";
            int i = 0;
            var update = await context.Chitietsuas.Where(idSua => idSua.IdPhieu == id).FirstOrDefaultAsync();
            if (update != null)
            {
                update.GhiChu = ghichu;
                i = await context.SaveChangesAsync();
                message = "OK";
            }
            return Json(new { mesage = message, model = i });
        }
        [Authorize]
        [HttpPost]
        public async Task<JsonResult> UpdateLoaiSuaChua(int id, string loaisuachua)
        {
            string message = "NOT";
            int i = 0;
            var update = await context.Chitietsuas.Where(idSua => idSua.IdPhieu == id).FirstOrDefaultAsync();
            if (update != null)
            {
                update.LoaiSuaChua = loaisuachua;
                i = await context.SaveChangesAsync();
                message = "OK";
            }
            return Json(new { mesage = message, model = i });
        }
        [Authorize]
        public  async Task<IActionResult> ChiTietPhieuMuc(int id)
        {
            var  chitietmuc = await context.ModelChiTietPhieuMucs.FromSqlRaw("EXEC GetChiTietPhieuMuc {0}",id).ToListAsync();

            return  View(chitietmuc);
        }
        [Authorize]
        public async Task<JsonResult> UpdateTrangThaiMuc(int id, string trangthai)
        {
            string message = "NOT";
            int i = 0;
            var update  = await context.Phieumucs.Where(idmuc => idmuc.IdMuc == id).FirstOrDefaultAsync();
            if (update != null)
            {
                if (trangthai == "Sửa xong")
                {
                    update.TrangThaiPhieu = trangthai;
                    update.NgaySuaXong = DateTime.Now;
                }
                else if (trangthai == "Đã trả")
                {
                    update.TrangThaiPhieu = trangthai;
                    update.NgaySuaXong = DateTime.Now;
                    update.NgayTra = DateTime.Now;
                }
                else 
                {
                    update.TrangThaiPhieu = trangthai;
                }
                i = await context.SaveChangesAsync();
                message = "OK";
            }
            return Json(new { mesage = message, model = i });
        }
        [Authorize]
        public async Task<JsonResult> UpdateGhiChuMuc(int id, string ghichu)
        {
            string message = "NOT";
            int i = 0;
            var update = await context.Chitietmucs.Where(idchitiet => idchitiet.IdMuc == id).FirstOrDefaultAsync();
            if(update != null)
            {
                update.GhiChu = ghichu;
                i = await context.SaveChangesAsync();
                message = "OK";
            }
            return Json(new { mesage = message, model = i });

        }
        [Authorize]
        public async Task<JsonResult> XacNhanTraHopMuc(int id, string trangthai, string manv)
        {
            string message = "NOT";
            int i = 0;
            var update = await context.Phieumucs.Where(idmuc => idmuc.IdMuc == id).FirstOrDefaultAsync();
            if (update != null)
            {
                update.TrangThaiPhieu = trangthai;
                update.MaNvNhan = manv;
                update.NgayTra = DateTime.Now;
                i = await context.SaveChangesAsync();
                message = "OK";
            }
            return Json(new { mesage = message, model = i });

        }

        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login","Access");
        }
    }
}
