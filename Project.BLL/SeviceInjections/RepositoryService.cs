using Microsoft.Extensions.DependencyInjection;
using Project.DAL.Repositories.Abstracts;
using Project.DAL.Repositories.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.SeviceInjections
{
    public static class RepositoryService
    {
        public static IServiceCollection AddRepServices(this IServiceCollection services)
        {

            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            services.AddScoped<ICastRepository, CastRepository>();
            services.AddScoped<IGenreRepository, GenreRepository>();
            services.AddScoped<IMovieRepository, MovieRepository>();
            services.AddScoped<IMovieGenreRepository, MovieGenreRepository>();
            services.AddScoped<IMovieCastRepository, MovieCastRepository>();
            services.AddScoped<IAppUserRepository, AppUserRepository>();
            services.AddScoped<IProfileRepository, ProfileRepository>();
            
            return services;
        }
    }
}
