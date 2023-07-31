using Microsoft.AspNetCore.Mvc;
using Phieu.Models;
using PhieuSuaChua.Models;
using System.Diagnostics;


namespace WebBlog.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        private PhieusuachuaContext context ;
        public HomeController(ILogger<HomeController> logger, PhieusuachuaContext context)
        {
            _logger = logger;
            this.context = context;
        }

        //[Route("Trang-chu.html", Name ="Index")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //[Route("Dang-Ky-Sua-Chua.html", Name = "DangKySuaChua")]
        //public IActionResult DangKySuaChua()
        //{
        //    return View();
        //}

        //[Route("Dang-ky-gui-muc.html")]
        //public IActionResult DangKyGuiMuc()
        //{
        //    return View();
        //}

        [Route("Tra-Cuu-Phieu.html", Name = "TraCuuPhieu")]
        public IActionResult TraCuuPhieu()
        {           
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}