using Microsoft.AspNetCore.Identity;

namespace App.Core.Entities.UserManagment
{
    public class AppRole : IdentityRole
    {
        public string? _Name { get; set; }

    }
}