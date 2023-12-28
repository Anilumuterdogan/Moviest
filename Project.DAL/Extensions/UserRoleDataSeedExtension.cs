using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Extensions
{
    public static class UserRoleDataSeedExtension
    {
        public static void SeedUsers(ModelBuilder modelBuilder) 
        {
            IdentityRole<int> appRole = new()
            {
                 Id = 1,
                 Name = "Admin",
                 NormalizedName = "ADMIN",
                 ConcurrencyStamp = Guid.NewGuid().ToString()
            };
            
            modelBuilder.Entity<IdentityRole<int>>().HasData(appRole);

            PasswordHasher<AppUser> passwordHasher = new PasswordHasher<AppUser>();

            AppUser user = new()
            {
                Id = 1,
                UserName = "aost",
                Email = "aost@gmail.com",
                NormalizedEmail = "AOST@GMAIL.COM",
                NormalizedUserName = "AOST",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                PasswordHash = passwordHasher.HashPassword(null, "aost")
            };

            modelBuilder.Entity<AppUser>().HasData(user);

            modelBuilder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int> { RoleId = appRole.Id, UserId = user.Id });
        }
    }
}
