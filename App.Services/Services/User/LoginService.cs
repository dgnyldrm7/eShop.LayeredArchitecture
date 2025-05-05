using App.Core.Entities.UserManagment;
using Microsoft.AspNetCore.Identity;

namespace App.Services.Services.User
{
    public class LoginService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;


        public LoginService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task Login(string userEmail, string userPassword)
        {
            var user = await _userManager.FindByEmailAsync(userEmail);
            
            if (user != null)
            {
                var result = await _userManager.CheckPasswordAsync(user, userPassword);

                if (result)
                {
                    //Çerez tabanlı giriş yaptırıyoruz.
                    await _signInManager.SignInAsync(user, isPersistent: true);




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