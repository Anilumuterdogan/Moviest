using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Project.BLL.DTOClasses;
using Project.BLL.ManagerServices.Abstracts;
using Project.BLL.Mapping;
using Project.DAL.Repositories.Abstracts;
using Project.ENTITIES.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ManagerServices.Concretes
{
    public class AppUserManager : BaseManager<AppUserDTO, AppUser>, IAppUserManager
    {
        // ! Liskov's Substitution
        readonly UserManager<AppUser> _userManager;
        readonly IMapper _mapper;
        IAppUserRepository _appUserRep;

        public AppUserManager(IAppUserRepository appUserRep, IMapper mapper, UserManager<AppUser> userManager) : base(appUserRep, mapper)
        {
            _appUserRep = appUserRep;
            _userManager = userManager;
            _mapper = mapper;
            
        }

        public IdentityOptions Value => throw new NotImplementedException();

        public IDisposable? BeginScope<TState>(TState state) where TState : notnull
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> CreateAsync(AppUser user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            
        }

        public async Task<string> CreateAsync(AppUserDTO user)
        {
           IdentityResult result = await _userManager.CreateAsync(_mapper.Map<AppUser>(user),user.UserPassword);
            if (result.Succeeded)
            {
                return "Kayıt başarılı.";
            }
            else
            {
                return "Kayıt başarısız!";
            }
        }

        public Task<IdentityResult> DeleteAsync(AppUser user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<AppUser?> FindByIdAsync(string userId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<AppUser?> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<IUserValidator<AppUser>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public Task<string?> GetNormalizedUserNameAsync(AppUser user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public object? GetService(Type serviceType)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetUserIdAsync(AppUser user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<string?> GetUserNameAsync(AppUser user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public string HashPassword(AppUser user, string password)
        {
            throw new NotImplementedException();
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            throw new NotImplementedException();
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            throw new NotImplementedException();
        }

        [return: NotNullIfNotNull("email")]
        public string? NormalizeEmail(string? email)
        {
            throw new NotImplementedException();
        }

        [return: NotNullIfNotNull("name")]
        public string? NormalizeName(string? name)
        {
            throw new NotImplementedException();
        }

        public Task SetNormalizedUserNameAsync(AppUser user, string? normalizedName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task SetUserNameAsync(AppUser user, string? userName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> UpdateAsync(AppUser user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public PasswordVerificationResult VerifyHashedPassword(AppUser user, string hashedPassword, string providedPassword)
        {
            throw new NotImplementedException();
        }

        IEnumerator<IPasswordValidator<AppUser>> IEnumerable<IPasswordValidator<AppUser>>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
