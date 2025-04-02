using Microsoft.AspNetCore.Identity;

namespace App.Core.Entities.UserManagment
{
    public class AppUser : IdentityUser<string>
    {
        public string? _Name { get; set; }
    }
}
