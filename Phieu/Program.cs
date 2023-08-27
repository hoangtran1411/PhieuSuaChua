using Microsoft.EntityFrameworkCore;
using Phieu.Models;
using PhieuSuaChua.Models;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
// Them Xac thuc
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(option =>
{
    option.LoginPath = "/Access/Login";
    option.ExpireTimeSpan = TimeSpan.FromMinutes(5);
});

builder.Services.AddDbContext<PhieusuachuaContext>(options =>options.UseSqlServer(builder.Configuration.GetConnectionString("Server=10.14.12.253,1333;Initial Catalog=PHIEUSUACHUA;Persist Security Info=False;User ID=sasa;Password=Bitis@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True")));
builder.Services.AddDistributedMemoryCache();

//builder.Services.AddSession(options =>
//{
//    options.IdleTimeout = TimeSpan.FromMinutes(10);
//    options.Cookie.HttpOnly = true;
//    options.Cookie.IsEssential = true;
//});
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

// Them xac thuc
app.UseAuthentication();

app.UseAuthorization();

//app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
