using App.Core.Common.Entities;
using App.Core.Entities.UserManagment;

namespace App.Core.Entities.ProductManagment
{
    public class Comment : EntityBase<int>
    {
        public string Message { get; set; } = default!;
        public string UserId { get; set; } = default!;
        public AppUser? AppUser { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}