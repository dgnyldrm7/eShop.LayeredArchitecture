using App.Core.Entities.UserManagment;
using Microsoft.AspNetCore.Identity;

namespace App.Services.Services
{
    public class LoginService
    {
        private UserManager<AppUser> userManager;
        public LoginService(UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
        }

        public async Task CreateUser()
        {
            var newUser = new AppUser
            {
                UserName = "amet",
            };

            var user = userManager.CreateAsync(newUser);
            

        }
        //write a summary code
   }
}
