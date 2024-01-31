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
    public class AppRoleManager : BaseManager<AppRoleDTO,AppRole>, IAppRoleManager
    {

        IAppRoleRepository _appRoleRep;
        public AppRoleManager(IAppRoleRepository appRoleRep,IMapper mapper) : base(appRoleRep,mapper)
        {
            _appRoleRep = appRoleRep;
        }
    }
}
