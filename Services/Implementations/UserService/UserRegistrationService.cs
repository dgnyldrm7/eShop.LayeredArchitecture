using App.Core.DTOs;
using App.Core.Entities.UserManagment;
using Microsoft.AspNetCore.Identity;

namespace App.Services.Implementations.UserService
{
    public class UserRegistrationService
    {
        private readonly UserManager<AppUser> _userManager;
        //private readonly IEmailSender _emailSender;

        public UserRegistrationService(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IdentityResult> RegisterUserAsync(RegisterDto model)
        {
            var user = new AppUser
            {
                UserName = model.Email,
                Email = model.Email,
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);

                var confirmationLink = $"https://yourapp.com/confirm-email?token={token}&email={model.Email}";

                //await _emailSender.SendEmailAsync(model.Email, "Confirm your email", confirmationLink);
            }

            return result;
        }
    }
}
