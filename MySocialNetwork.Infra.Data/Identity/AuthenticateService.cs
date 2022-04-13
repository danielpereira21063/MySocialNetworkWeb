using Microsoft.AspNetCore.Identity;
using MySocialNetwork.Domain.Account;

namespace MySocialNetwork.Infra.Data.Identity
{
    public class AuthenticateService : IAuthenticate
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signManager;

        public AuthenticateService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signManager = signInManager;
        }

        public async Task<bool> Authenticate(string email, string password)
        {
            var result = await _signManager.PasswordSignInAsync(email, password, false, lockoutOnFailure: false);

            return result.Succeeded;
        }

        public async Task<bool> RegisterUser(string email, string password)
        {
            var applicationUser = new ApplicationUser
            {
                UserName = email,
                Email = email,
                NormalizedEmail = email.ToUpper()
            };

            var result = await _userManager.CreateAsync(applicationUser, password);

            if (result.Succeeded)
            {
                await _signManager.SignInAsync(applicationUser, isPersistent: false);
            }

            return result.Succeeded;

        }

        public async Task Logout()
        {
            await _signManager.SignOutAsync();
        }
    }
}
