using Microsoft.Extensions.DependencyInjection;
using Project.BLL.ManagerServices.Abstracts;
using Project.BLL.ManagerServices.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.SeviceInjections
{
    public static class ManagerService
    {
        public static IServiceCollection AddManagerServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IManager<,>), typeof(BaseManager<,>));

            services.AddScoped<IAppUserManager, AppUserManager>();
            services.AddScoped<IAppRoleManager, AppRoleManager>();
            services.AddScoped<IAppUserRoleManager, AppUserRoleManager>();
            services.AddScoped<IProfileManager, ProfileManager>();
            services.AddScoped<ICastManager, CastManager>();
            services.AddScoped<IGenreManager, GenreManager>();
            services.AddScoped<IMovieCastManager, MovieCastManager>();
            services.AddScoped<IMovieGenreManager, MovieGenreManager>();
            services.AddScoped<IMovieManager, MovieManager>();
            return services;
        }
    }
}
