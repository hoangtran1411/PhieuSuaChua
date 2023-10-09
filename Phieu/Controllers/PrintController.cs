using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.NETCore;
using PhieuSuaChua.Models;

namespace PhieuSuaChua.Controllers
{
    public class PrintController : Controller
    {
        //private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly PhieusuachuaContext _context;
        public PrintController(PhieusuachuaContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        //[HttpPost]
        public IActionResult PrintPhieu(string id)
        {
            var dataPrint = _context.ModelPrintPhieus.FromSqlRaw($"EXEC Proc_In_PhieuSua {id}").ToList();
            string filePath = Path.Join(@"\\10.90.39.62\Report\", "rpt_Phieu_Sua.rdl");
            using (var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {

                LocalReport report = new LocalReport();
                ReportParameter parameter = new ReportParameter("id_phieu", id);
                report.LoadReportDefinition(fileStream);
                report.SetParameters(parameter);
                //report.SetParameters(new ReportParameter(id));
                report.DataSources.Add(new ReportDataSource(name: "Ds_Print_Phieu", dataPrint));


                byte[] pdfData = report.Render(format: "PDF");
                return File(pdfData, contentType: "application/pdf");

            }

        }
    }
}
