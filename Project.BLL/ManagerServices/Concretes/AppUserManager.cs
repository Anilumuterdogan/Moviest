using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
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
    public class AppUserManager : BaseManager<AppUserDTO, AppUser>, IAppUserManager
    {
        // ! Liskov's Substitution

        IAppUserRepository _appUserRep;
        public AppUserManager(IAppUserRepository appUserRep, IMapper mapper) : base(appUserRep, mapper)
        {
            _appUserRep = appUserRep;

        }
       
    }
}
