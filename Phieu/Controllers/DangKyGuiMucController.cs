using Microsoft.AspNetCore.Mvc;
using PhieuSuaChua.Domain_Model;
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
        public IActionResult DangKyGuiMuc(ModelDangKyMuc model)
        {
            Phieumuc phieumuc = new()
            {
                MaNvGui = model.MA_NV,
                TrangThaiPhieu = model.TRANG_THAI_PHIEU

            };
            context.Phieumucs.Add(phieumuc);
            context.SaveChanges();

            Chitietmuc chitietmuc = new() 
            {
                IdMuc = Convert.ToInt32(phieumuc.IdMuc),
                TenHopMuc = model.TEN_HOP_MUC,
                LoaiMayIn = model.MAY_IN,
                TinhTrang = model.TINH_TRANG
            };
            context.Chitietmucs.Add(chitietmuc);
            int number = context.SaveChanges();

            string message;

            if (number > 0)
            {
                message = "OK";
            }
            else
            {
                message = "Wrong";
            }
            int sophieu = Convert.ToInt32(phieumuc.IdMuc);
            return Json(new { mesage = message, model = sophieu });
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
