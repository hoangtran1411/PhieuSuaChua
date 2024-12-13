using Microsoft.EntityFrameworkCore;
using PhieuSuaChua.Models;

namespace PhieuSuaChua.MyMapEndpoints
{
    public static class MapEndponts
    {
        public static WebApplication MapEmployee(this WebApplication app)
        {
            app.MapGet(pattern: "/Employee/{employeeCode}", async (string employeeCode, PhieusuachuaContext _context) =>
            {
                var result = await _context.Nhanviens.FirstOrDefaultAsync(x => x.MaNv.Equals(employeeCode));

                string message;
                if (result != null)
                {
                    message = "OK";
                }
                else
                {
                    message = "Wrong";
                }

                return Results.Json(new { mesage = message, model = result });
                
            });
           
            return app;
        }
        public static WebApplication MapDerpartment(this WebApplication app)
        {
            return app;
        }
    }
}
