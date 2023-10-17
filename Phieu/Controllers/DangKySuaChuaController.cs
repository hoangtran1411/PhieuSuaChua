using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private readonly PhieusuachuaContext context;
        public DangKySuaChuaController(PhieusuachuaContext context)
        {
            this.context = context;
        }
      
        public IActionResult Index()
        {
          
            return View();
        }
          
       
        public async Task<IActionResult> DangKySuaChua(ModelDangKySua model)
        {
            string message = "";
            if (model != null)
            {
                Phieusua sua = new()
                {
                    MaNv = model.MaNv,
                    TrangThaiPhieu = model.TrangThaiPhieu
                };
                await context.Phieusuas.AddAsync(sua);
                await context.SaveChangesAsync();

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
                await context.Chitietsuas.AddAsync(ct);
                int number = await context.SaveChangesAsync();

              

                if (number > 0)
                {
                    message = "OK";
                }
                else
                {
                    message = "Wrong";
                }
                int sophieu = Convert.ToInt32(sua.IdPhieu);
                return Json(new { mesage = message, model = sophieu });
            }
            return Json(new { mesage = message });

        }
        [HttpPost]
        public async Task<JsonResult> KiemtraMaNV(Nhanvien nv)
        {
            var result = await context.Nhanviens.FirstOrDefaultAsync(x=>x.MaNv.Equals(nv.MaNv) );
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
