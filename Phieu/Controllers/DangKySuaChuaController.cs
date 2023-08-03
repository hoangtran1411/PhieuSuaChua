﻿using Microsoft.AspNetCore.Mvc;
using PhieuSuaChua.Domain_Model;
using PhieuSuaChua.Models;
using System.Data;


namespace PhieuSuaChua.Controllers
{
    public class DangKySuaChuaController : Controller
    {
        private PhieusuachuaContext db;
        public DangKySuaChuaController(PhieusuachuaContext context)
        {
            this.db = context;
        }
      
        public IActionResult Index()
        {
          
            return View();
        }
       
        [HttpPost]
        public IActionResult DangKySuaChua(ModelDangKySua model)
        {
            Phieusua sua = new()
            {
                MaNv = model.MaNv,
                TrangThaiPhieu = model.TrangThaiPhieu
            };
            db.Phieusuas.Add(sua);
            db.SaveChanges();

            Chitietsua ct = new()
            {
                IdPhieu = Convert.ToInt32(sua.IdPhieu),
                TenPc = model.TenPC,
                AccountNames = model.User,
                AccountPass = model.Pass,
                ThietBiKhac = model.Thietbikhac,
                TinhTrang = model.Tinhtrang,
                Sdt = model.Sdt,
                LoaiSuaChua = model.LoaiSuaChua
            };
            db.Chitietsuas.Add(ct);
            db.SaveChanges();   
          
            return View();
        }
        [HttpPost]
        public JsonResult KiemtraMaNV(Nhanvien nv)
        { 
            var kt = (from Nhanvien in db.Nhanviens
                     select Nhanvien).Where(k=>k.MaNv==nv.MaNv).First();
            if (kt.MaNv != nv.MaNv)
            {
                return Json(false);
               
            }
            else
            {
                return Json(true);
            }

        }
    }
}
