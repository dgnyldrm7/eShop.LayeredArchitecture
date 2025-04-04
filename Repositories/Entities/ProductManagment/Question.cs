using App.Core.Entities.UserManagment;

namespace App.Core.Entities.ProductManagment
{
    public class Question
    {
        public int Id { get; set; }
        public string Message { get; set; } = default!;
        public bool IsAnswered { get; set; } = false; 
        // Navigation properties
        public int UserId { get; set; }
        public AppUser User { get; set; } = new();
        public int ProductId { get; set; }
        public Product Product { get; set; } = new();
        public int AnswerId { get; set; }
        public Answer Answer { get; set; } = new();
    }
}