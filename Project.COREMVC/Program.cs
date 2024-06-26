﻿using Project.BLL.SeviceInjections;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.



builder.Services.AddHttpClient();
builder.Services.AddControllersWithViews();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(x =>
{
    x.IdleTimeout = TimeSpan.FromMinutes(60); 
    x.Cookie.HttpOnly = true; 
    x.Cookie.IsEssential = true;
});
   
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

app.UseSession();

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
