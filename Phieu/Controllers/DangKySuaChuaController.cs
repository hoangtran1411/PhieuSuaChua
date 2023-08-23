using Microsoft.AspNetCore.Mvc;
using PhieuSuaChua.Domain_Model;
using PhieuSuaChua.Models;
using System.Data;
using System.Linq;
using System.Threading.Tasks.Dataflow;
using System.Web;

namespace PhieuSuaChua.Controllers
{
    public class DangKySuaChuaController : Controller
    {
        private readonly PhieusuachuaContext db;
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
            Phieusua sua = new()
            {
                MaNv = model.MaNv,
                TrangThaiPhieu = model.TrangThaiPhieu
            };
            db.Phieusuas.Add(sua);
            db.SaveChanges();

            Chitietsua ct = new()
            {
                IdPhieu = Convert.ToInt32(sua.IdPhieu),
                TenPc = model.TenPC,
                AccountNames = model.User,
                AccountPass = model.Pass,
                ThietBiKhac = model.Thietbikhac,
                TinhTrang = model.Tinhtrang,
                Sdt = model.Sdt,
                LoaiSuaChua = model.LoaiSuaChua,
                GhiChu = model.Ghichu
                
            };
            db.Chitietsuas.Add(ct);
            int number = db.SaveChanges();

            string message;

            if (number > 0)
            {
                message = "OK";
            }
            else
            {
                message = "Wrong";
            }
            int sophieu = Convert.ToInt32(sua.IdPhieu);
            return Json(new { mesage = message, model =  sophieu});
        }
        [HttpPost]
        public JsonResult KiemtraMaNV(Nhanvien nv)
        {
            var result = db.Nhanviens.FirstOrDefault(x=>x.MaNv == nv.MaNv);
            string message;
            if( result != null)
            {
                message = "OK";
            }
            else
            {
                message = "Wrong";
            }
            return Json(new { mesage = message, model = result });
        }
    }
}
