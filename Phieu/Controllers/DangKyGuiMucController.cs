using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhieuSuaChua.Domain_Model;
using PhieuSuaChua.Models;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;

namespace PhieuSuaChua.Controllers
{
    [Authorize]
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
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            HttpContext.Session.Remove("Login");
            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> DangKyGuiMuc(ModelDangKyMuc model)
        {
            string message ="";
            if (model != null)
            {
                Phieumuc phieumuc = new()
                {
                    MaNvGui = model.MA_NV,
                    TrangThaiPhieu = model.TRANG_THAI_PHIEU

                };
                await context.Phieumucs.AddAsync(phieumuc);
                await context.SaveChangesAsync();

                Chitietmuc chitietmuc = new()
                {
                    IdMuc = Convert.ToInt32(phieumuc.IdMuc),
                    TenHopMuc = model.TEN_HOP_MUC,
                    LoaiMayIn = model.MAY_IN,
                    TinhTrang = model.TINH_TRANG
                };
                await context.Chitietmucs.AddAsync(chitietmuc);
                int number = await context.SaveChangesAsync();

                

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
            return Json(new { mesage = message});
        }
        [HttpPost]
        public async Task<JsonResult> KiemtraMaNV(Nhanvien nv)
        {
            var result = await context.Nhanviens.FirstOrDefaultAsync(x => x.MaNv.Equals(nv.MaNv));
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
