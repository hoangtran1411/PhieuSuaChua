using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Phieu.Models;
using PhieuSuaChua.Domain_Model;
using PhieuSuaChua.Models;

namespace PhieuSuaChua.Controllers
{
    public class TraCuuPhieuController : Controller
    {
        private PhieusuachuaContext context;
        public TraCuuPhieuController(PhieusuachuaContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
           
            var listPhieu = (from Chitietsua in context.Chitietsuas 
                             join Phieusua in context.Phieusuas 
                             on Chitietsua.IdPhieu equals Phieusua.IdPhieu
                             join Nhanvien in context.Nhanviens
                             on Phieusua.MaNv equals Nhanvien.MaNv
                             orderby Phieusua.IdPhieu descending
                             select new ModelTraCuuPhieu
                             {
                                 Id = Phieusua.IdPhieu,
                                 Ngaytaophieu = Phieusua.NgayTao,
                                 Hoten = Nhanvien.TenNv,
                                 Donvi = Nhanvien.DonVi,
                                 Maytinh = Chitietsua.TenPc,
                                 Thietbikhac = Chitietsua.ThietBiKhac,
                                 Trangthaiphieu = Phieusua.TrangThaiPhieu
                             }).ToList();
            //test
                            
            return View(listPhieu);
        }
        public IActionResult ChiTietPhieuSua(Phieusua id) 
        {
            
            return View(); 
        }
    }
}
