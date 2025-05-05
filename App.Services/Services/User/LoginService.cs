using App.Core.Entities.UserManagment;
using Microsoft.AspNetCore.Identity;

namespace App.Services.Services.User
{
    public class LoginService
    {
        private readonly UserManager<AppUser> _userManager;
        public LoginService(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task Login(string userEmail, string userPassword)
        {
            var user = await _userManager.FindByEmailAsync(userEmail);
            
            if (user != null)
            {
                var result = await _userManager.CheckPasswordAsync(user, userPassword);

                if (result)
                {
                    // User is authenticated
                    // Perform login logic here

                    // For example, you might want to sign in the user using a cookie or JWT token
                }
                else
                {
                    // Invalid password
                }
            }
            else
            {
                // User not found
            }
        }
    }
}