using App.Core.Common.Entities;
using App.Core.Entities.ProductManagment;

namespace App.Core.Entities.UserManagment
{
    public class Favorite : EntityBase<int>
    {
        public int ProductId { get; set; }
        public string? UserId { get; set; }
        public Product? Product { get; set; }
        public AppUser? User { get; set; }
    }
}