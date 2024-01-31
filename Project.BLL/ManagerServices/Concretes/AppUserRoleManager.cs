using AutoMapper;
using Project.BLL.DTOClasses;
using Project.BLL.ManagerServices.Abstracts;
using Project.DAL.Repositories.Abstracts;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ManagerServices.Concretes
{
    public class AppUserRoleManager : BaseManager<AppUserRoleDTO, AppUserRole>, IAppUserRoleManager
    {
        IAppUserRoleRepository _appUserRoleRep;
        public AppUserRoleManager(IAppUserRoleRepository appUserRoleRep, IMapper mapper) : base(appUserRoleRep,mapper)
        {
            _appUserRoleRep = appUserRoleRep;
        }
    }
}
