using Microsoft.AspNetCore.Mvc;
using PhieuSuaChua.Models;

namespace PhieuSuaChua.Controllers
{
    public class DangKyGuiMucController : Controller
    {


        private readonly PhieusuachuaContext context;
        public DangKyGuiMucController(PhieusuachuaContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DangKyGuiMuc()
        {
            return View();
        }
        [HttpPost]
        public JsonResult KiemtraMaNV(Nhanvien nv)
        {
            var result = context.Nhanviens.FirstOrDefault(x => x.MaNv == nv.MaNv);
            string message;
            if (result != null)
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
