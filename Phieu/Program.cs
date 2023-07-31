using Microsoft.EntityFrameworkCore;
using Phieu.Models;
using PhieuSuaChua.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<PhieusuachuaContext>(options =>options.UseSqlServer(builder.Configuration.GetConnectionString("Server=10.14.12.253,1333;user=sasa;password=Bitis@123;database=PhieuSuaChua;Trusted_Connection=True;TrustServerCertificate=True;")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
