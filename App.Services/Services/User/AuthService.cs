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

            try
            {
                // Transaction!!
                await unitOfWork.BeginTransactionAsync(CancellationToken.None);

                var result = await _userManager.CreateAsync(newUser, model.Password);

                if (!result.Succeeded)
                {
                    await unitOfWork.RollbackAsync(CancellationToken.None);
                    return ServiceResult.FailResult(string.Join("; ", result.Errors.Select(e => e.Description)));
                }

                await unitOfWork.SaveChangesAsync(CancellationToken.None);
                await unitOfWork.CommitAsync(CancellationToken.None);

                return ServiceResult.SuccessResult("Başarıyla kayıt oluşturuldu.", newUser);
            }
            catch (Exception ex)
            {
                await unitOfWork.RollbackAsync(CancellationToken.None);
                return ServiceResult.FailResult("Kayıt sırasında hata oluştu: " + ex.Message);
            }
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

        /// <summary>
        /// İlgili kullanıcının şifresini değiştirme service'idir.
        /// </summary>
        /// <param name="userEmail"></param>
        /// <param name="currentPassword"></param>
        /// <param name="newPassword"></param>
        /// <returns></returns>
        public async Task<ServiceResult> ChangePasswordAsync(string userEmail, string currentPassword, string newPassword)
        {
            var user = await _userManager.FindByEmailAsync(userEmail);
            if (user == null)
                return ServiceResult.FailResult("Kullanıcı bulunamadı.");

            var result = await _userManager.ChangePasswordAsync(user, currentPassword, newPassword);

            if (!result.Succeeded)
                return ServiceResult.FailResult(string.Join("; ", result.Errors.Select(e => e.Description)));

            await _signInManager.RefreshSignInAsync(user); // cookie güncelle
            return ServiceResult.SuccessResult("Şifre başarıyla değiştirildi.");
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
