using Castle.Core.Logging;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Project.BLL.DTOClasses;
using Project.BLL.ManagerServices.Concretes;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ManagerServices.Abstracts
{
    public interface IAppUserManager : IManager<AppUserDTO, AppUser>,IUserStore<AppUser>,IOptions<IdentityOptions>,IPasswordHasher<AppUser>,IEnumerable<IUserValidator<AppUser>>,IEnumerable<IPasswordValidator<AppUser>>,ILookupNormalizer,IServiceProvider,ILogger<AppUserManager> 
    {       
    }
}
