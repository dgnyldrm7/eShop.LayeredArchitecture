using App.Core.Common.Entities;
using App.Core.Entities.UserManagment;

namespace App.Core.Entities.ProductManagment
{
    public class Question : EntityBase<int>
    {
        public string Message { get; set; } = default!;
        public bool IsAnswered { get; set; }
        public string UserId { get; set; } = default!;
        public AppUser? AppUser { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public int AnswerId { get; set; }
        public Answer? Answer { get; set; }
    }
}