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
                LoaiSuaChua = model.LoaiSuaChua
            };
            db.Chitietsuas.Add(ct);
            db.SaveChanges();   
          
            return View();
        }
        [HttpPost]
        public JsonResult KiemtraMaNV(Nhanvien nv)
        {
            // anh đưa lên mỗi mã nhân viên mà nhận vào nguyên classs nhân viên dư á

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
            //var listnv = db.Nhanviens.Where(l=>l.MaNv==nv.MaNv).ToArray();
            //var check = listnv.Where(k => k.MaNv == nv.MaNv).Count();
            return Json(new { mesage = message, model = result });
        }
    }
}
