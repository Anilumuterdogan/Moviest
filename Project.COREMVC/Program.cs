using Microsoft.AspNetCore.Identity;
using Project.BLL.SeviceInjections;
using Project.DAL.ContextClasses;
using Project.ENTITIES.Models;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddHttpClient();
builder.Services.AddControllersWithViews();


builder.Services.ConfigureApplicationCookie();
builder.Services.AddIdentityServices();

builder.Services.AddDbContextService();
builder.Services.AddRepServices();
builder.Services.AddManagerServices();
builder.Services.AddInnerInfraServiceInjections();

WebApplication app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "Admin",
    pattern: "{area}/{controller=Home}/{action=Index}/{id?}"
    );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Member}/{action=Index}/{id?}");

app.Run();
