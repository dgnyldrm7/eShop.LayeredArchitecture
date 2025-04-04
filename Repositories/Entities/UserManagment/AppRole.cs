using Microsoft.AspNetCore.Identity;

namespace App.Core.Entities.UserManagment
{
    public class AppRole : IdentityRole<string>
    {
        public string? _Name { get; set; }

    }
}