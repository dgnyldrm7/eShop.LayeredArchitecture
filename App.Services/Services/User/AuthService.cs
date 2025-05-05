using App.Core.DTOs;
using App.Core.Entities.UserManagment;
using App.Core.Interfaces.UnitOfWork;
using App.Core.Result;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace App.Services.Services.User
{
    public class AuthService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IUnitOfWork unitOfWork;
        public AuthService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IUnitOfWork unitOfWork)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            this.unitOfWork = unitOfWork;
        }


        /// <summary>
        /// 
        /// Kullanıcı için geniş ölçekli bir login doğrulaması sağlar.
        /// 
        /// </summary>
        public async Task<ServiceResult> LoginAsync(string userMail, string password)
        {
            var user = await _userManager.FindByEmailAsync(userMail);

            if (user == null)
            {
                return ServiceResult.FailResult("Bu kullanıcı bulunamadı.");
            }

            // Hesap kilitli mi?
            if (await _userManager.IsLockedOutAsync(user))
                return ServiceResult.FailResult("Bu kullanıcı banlanmış.");

            // Şifre doğru mu?
            if (await _userManager.CheckPasswordAsync(user, password))
            {
                // Hatalı giriş sayısını sıfırla
                await _userManager.ResetAccessFailedCountAsync(user);

                // Giriş yaptır (cookie tabanlı)
                await _signInManager.SignInAsync(user, isPersistent: true);

                return ServiceResult.SuccessResult("Sisteme giriş yapıldı", user);
            }
            else
            {
                // Hatalı giriş sayısını artır (kilitlenme için) Birer birer arttırırız!
                await _userManager.AccessFailedAsync(user);
                return ServiceResult.FailResult("Hatalı giriş yapıldı.");
            }
        }

        /// <summary>
        /// İlgili yeni müşteri, sisteme kayıt olmak için RegisterDto'yu kullanır.
        /// </summary>
        public async Task<ServiceResult> Register(RegisterDto model)
        {
            if (model == null)
                return ServiceResult.FailResult("Kayıt bilgileri boş olamaz.");

            var existingUserMail = await _userManager.FindByEmailAsync(model.Email);
            if (existingUserMail != null)
                return ServiceResult.FailResult("Bu email adresi zaten kayıtlı.");

            var existingUserNumber = await _userManager.Users
                .FirstOrDefaultAsync(x => x.PhoneNumber == model.PhoneNumber);

            if (existingUserNumber != null)
                return ServiceResult.FailResult("Bu numara zaten kayıtlı.");

            var newUser = new AppUser
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                UserName = model.Email,
                PhoneNumber = model.PhoneNumber,
            };

            var result = await _userManager.CreateAsync(newUser, model.Password);

            if (!result.Succeeded)
                return ServiceResult.FailResult(string.Join("; ", result.Errors.Select(e => e.Description)));

            await unitOfWork.SaveChangesAsync(CancellationToken.None);

            return ServiceResult.SuccessResult("Başarıyla kayıt oluşturuldu.", newUser);
        }

        /// <summary>
        /// Sistemden çıkış yapmayı sağlar. Ekstra var olan cookiyi de silmeye yarar.
        /// </summary>
        public async Task Logout(HttpResponse response)
        {
            await _signInManager.SignOutAsync();

            var cookieOptions = new CookieOptions
            {
                Expires = DateTimeOffset.UtcNow.AddDays(-1),
                HttpOnly = true,
                Secure = true,
                SameSite = SameSiteMode.None
            };

            response.Cookies.Delete("Morlidocom", cookieOptions);
        }

        public void ResetPassword()
        {
            //
        }

        public void ChangePassword()
        {
            //change password
        }

        public void ConfirmEmail()
        {
            //confirm email
        }

        public void SendEmailConfirmation()
        {
            //send email confirmation
        }

        public void SendPasswordResetEmail()
        {
            //send password reset email
        }
    }
}
