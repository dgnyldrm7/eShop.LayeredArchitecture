using App.Core.Entities.UserManagment;
using Microsoft.AspNetCore.Identity;

namespace App.Services.Services.User
{
    public class AuthService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        public AuthService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }


        /// <summary>
        /// 
        /// Kullanıcı için geniş ölçekli bir login doğrulaması sağlar.
        /// 
        /// </summary>
        public async Task<bool> LoginAsync(string userMail, string password)
        {
            var user = await _userManager.FindByEmailAsync(userMail);

            if (user == null)
                return false;

            /*
            // E-posta doğrulandı mı? Çok önemli değil!
            if (!await _userManager.IsEmailConfirmedAsync(user))
                return false;
            */

            // Hesap kilitli mi?
            if (await _userManager.IsLockedOutAsync(user))
                return false;

            // Şifre doğru mu?
            if (await _userManager.CheckPasswordAsync(user, password))
            {
                // Hatalı giriş sayısını sıfırla
                await _userManager.ResetAccessFailedCountAsync(user);

                // Giriş yaptır (cookie tabanlı)
                await _signInManager.SignInAsync(user, isPersistent: true);

                return true;
            }
            else
            {
                // Hatalı giriş sayısını artır (kilitlenme için) Birer birer arttırırız!
                await _userManager.AccessFailedAsync(user);
                return false;
            }
        }



        public void Register()
        {

        }

        public void Logout()
        {
            //logout
        }

        public void ResetPassword()
        {
            //reset password
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
