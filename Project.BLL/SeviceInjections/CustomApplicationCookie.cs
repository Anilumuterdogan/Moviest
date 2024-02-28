using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.SeviceInjections
{
    public static class CustomApplicationCookie
    {
        public static IServiceCollection ConfigureApplicationCookie (this IServiceCollection services)
        {
             services.ConfigureApplicationCookie(x =>
             {
                 x.Cookie.HttpOnly = true;
                 x.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;
                 x.Cookie.Name = "CyberSelf";
                 x.ExpireTimeSpan = TimeSpan.FromMinutes(99999999);
                 x.Cookie.SameSite = SameSiteMode.Strict;
                 x.LoginPath = new PathString("/Home/SignIn");
                 x.AccessDeniedPath = new PathString("/Home/AccessDenied");
             });
            return services;
        }
    }
}
