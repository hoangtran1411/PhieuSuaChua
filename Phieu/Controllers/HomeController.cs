using Microsoft.AspNetCore.Mvc;
using Phieu.Models;
using PhieuSuaChua.Models;
using System.Diagnostics;


namespace WebBlog.Controllers
{

    public class HomeController : Controller
    {
#pragma warning disable IDE0052 // Remove unread private members
        private readonly ILogger<HomeController> _logger;
#pragma warning restore IDE0052 // Remove unread private members

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //private readonly PhieusuachuaContext context;
        //public HomeController(PhieusuachuaContext context)
        //{
        //    this.context = context;
        //}

        //[Route("Trang-chu.html", Name ="Index")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
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