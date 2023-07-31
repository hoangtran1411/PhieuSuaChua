using Microsoft.AspNetCore.Mvc;
using PhieuSuaChua.Models;

namespace PhieuSuaChua.Controllers
{
    public class DangKyGuiMucController : Controller
    {
        private PhieuSuaChuaContext db;
        public DangKyGuiMucController(PhieuSuaChuaContext context)
        {
            this.db = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
