using App.Core.DTOs;
using App.Core.Entities.UserManagment;
using App.Core.Interfaces.UnitOfWork;
using Microsoft.AspNetCore.Identity;

namespace App.Services.Services
{
    public class UserRegistrationService
    {
        private readonly UserManager<AppUser> _userManager;

        private readonly IUnitOfWork _unitOfWork;

        public UserRegistrationService(UserManager<AppUser> userManager, IUnitOfWork unitOfWork)
        {
            _userManager = userManager;
            _unitOfWork = unitOfWork;
        }

        public async Task<IdentityResult> RegisterUserAsync(RegisterDto model)
        {
            await _unitOfWork.BeginTransactionAsync(CancellationToken.None);

            try
            {
                //Process

                await _unitOfWork.SaveChangesAsync(CancellationToken.None);

                await _unitOfWork.CommitAsync(CancellationToken.None);
            }
            catch
            {
                await _unitOfWork.RollbackAsync(CancellationToken.None);
                throw;
            }

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
