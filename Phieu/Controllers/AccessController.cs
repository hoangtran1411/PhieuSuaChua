using Microsoft.AspNetCore.Mvc;

using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using PhieuSuaChua.Models;
using Microsoft.EntityFrameworkCore;

namespace PhieuSuaChua.Controllers
{
    public class AccessController : Controller
    {
        //private readonly IHttpContextAccessor _contextAccessor;
        private readonly PhieusuachuaContext context;
        public AccessController(PhieusuachuaContext context)
        {
            this.context = context;
        }
        //public AccessController(IHttpContextAccessor _contextAccessor)
        //{
        //    this._contextAccessor = _contextAccessor;
        //}
        public IActionResult Login()
        {
            ClaimsPrincipal claimsUser = HttpContext.User;
            if (claimsUser.Identity != null)
            {
                if (claimsUser.Identity.IsAuthenticated)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            var user = await context.Nhanviens.Where(nv => nv.MaNv ==username && nv.MaNv.ToUpper()== password).FirstOrDefaultAsync();
            if (user != null )
            {
                
                if (user.Quyen <= 1 && user.DonVi == "P.CNTT")
                {
                    
                    List<Claim> claims = new()
                    {
                        new Claim(ClaimTypes.NameIdentifier, user.MaNv),
                        new Claim(ClaimTypes.Name, user.TenNv!),
                        new Claim("Other","Role")
                    };
                    
                    ClaimsIdentity claimsIdentity = new(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    ClaimsPrincipal principal = new ClaimsPrincipal(claimsIdentity);
                    AuthenticationProperties properties = new()
                    {
                        AllowRefresh = true,
                        //IsPersistent = true,
                    };
                    await HttpContext.SignInAsync(principal, properties);
                    //if (claimsIdentity != null)
                    //{
                       
                    //    if (user.TenNv != null)
                    //    {
                    //        HttpContext.Session.SetString("Login", user.TenNv);
                    //    }
                       
                    //}
                  
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return View();
                }
            }
            return View();

        }
    }
}
