using Microsoft.AspNetCore.Mvc;
using PhieuSuaChua.Models;
using System.Data;


namespace PhieuSuaChua.Controllers
{
    public class DangKySuaChuaController : Controller
    {
        private PhieusuachuaContext db;
        public DangKySuaChuaController(PhieusuachuaContext context)
        {
            this.db = context;
        }
      
        public IActionResult Index()
        {
          
            return View();
        }
       
        [HttpPost]
        public async Task<IActionResult> DangKySuaChua(Chitietsua model)
        {
            Chitietsua newmodel = new Chitietsua()
            {
                ma = model.MaNv,
                TenMayTinh = model.TenMayTinh,
                UserName = model.UserName,
                Passwords = model.Passwords,
                ThietBiKhac = model.ThietBiKhac,
                TinhTrang = model.TinhTrang,
                GhiChu = model.GhiChu,
                TrangThaiPhieu = model.TrangThaiPhieu,
                LoaiSuaChua = model.LoaiSuaChua,
                Sdt = model.Sdt,
                
            };
            //db.ChiTietPhieus.Add(newmodel);
           int number = db.SaveChanges();
            if (number > 0)
            {
                ViewBag.Title = "Ok";
            }
            return View();
        }
    }
}
