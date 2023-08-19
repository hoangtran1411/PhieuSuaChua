using Microsoft.AspNetCore.Mvc;
using PhieuSuaChua.Models;

namespace PhieuSuaChua.Controllers
{
    public class DangKyGuiMucController : Controller
    {
      
      
        //private readonly PhieusuachuaContext db;
        //public DangKyGuiMucController(PhieusuachuaContext context)
        //{
        //    this.db = context;
        //}
        public IActionResult Index()
        {
            return View();
        }
    }
}
