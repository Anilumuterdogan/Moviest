using Microsoft.Extensions.DependencyInjection;
using Project.BLL.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.SeviceInjections
{
    public static class InnterServiceInjection
    {
        public static void AddInnerInfraServiceInjections(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(DTOMapProfile));
        }
    }
}
