using Microsoft.AspNetCore.Identity;
using MySocialNetwork.Domain.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySocialNetwork.Infra.Data.Identity
{
    public class SeedUserRoleInitial : ISeedUserRoleInitial
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public SeedUserRoleInitial(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public void SeedRoles()
        {
            if (!_roleManager.RoleExistsAsync("User").Result)
            {
                IdentityRole role = new IdentityRole
                {
                    Name = "User",
                    NormalizedName = "USER"
                };

                IdentityResult result = _roleManager.CreateAsync(role).Result;
            }

            if(!_roleManager.RoleExistsAsync("Admin").Result)
            {
                IdentityRole role = new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                };

                IdentityResult result = _roleManager.CreateAsync(role).Result;
            }


        }

        public void SeedUsers()
        {
            var email = "user@localhost";
            var password = "#23012001D@niel";

            if (_userManager.FindByEmailAsync(email).Result == null)
            {
                ApplicationUser user = new ApplicationUser
                {
                    UserName = email,
                    Email = email,
                    NormalizedEmail = email.ToUpper(),
                    NormalizedUserName = email.ToUpper(),
                    EmailConfirmed = true,
                    LockoutEnabled = false,
                    SecurityStamp = Guid.NewGuid().ToString(),
                };

                IdentityResult result = _userManager.CreateAsync(user, password).Result;

                if (result.Succeeded)
                {
                    _userManager.AddToRoleAsync(user, "User").Wait();
                }
            }

            email = "admin@localhost";

            if (_userManager.FindByEmailAsync(email).Result == null)
            {
                ApplicationUser user = new ApplicationUser
                {
                    UserName = email,
                    Email = email,
                    NormalizedEmail = email.ToUpper(),
                    NormalizedUserName = email.ToUpper(),
                    EmailConfirmed = true,
                    LockoutEnabled = false,
                    SecurityStamp = Guid.NewGuid().ToString(),
                };

                IdentityResult result = _userManager.CreateAsync(user, password).Result;

                if (result.Succeeded)
                {
                    _userManager.AddToRoleAsync(user, "Admin").Wait();
                }
            }
        }
    }
}
