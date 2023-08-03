using Microsoft.AspNetCore.Mvc;
using PhieuSuaChua.Domain_Model;
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
        public IActionResult DangKySuaChua(ModelDangKySua model)
        { 
            Phieusua sua = new Phieusua();
            sua.MaNv = model.MaNv;
            sua.TrangThaiPhieu = model.TrangThaiPhieu;
            db.Phieusuas.Add(sua);
            db.SaveChanges();

            Chitietsua ct = new Chitietsua();
            ct.IdPhieu = Convert.ToInt32(sua.IdPhieu);
            ct.TenPc = model.TenPC;
            ct.AccountNames = model.User;
            ct.AccountPass = model.Pass;
            ct.ThietBiKhac = model.Thietbikhac;
            ct.TinhTrang = model.Tinhtrang;
            ct.Sdt = model.Sdt;
            ct.LoaiSuaChua = model.LoaiSuaChua;
            db.Chitietsuas.Add(ct);
            db.SaveChanges();   
          
            return View();
        }
    }
}
