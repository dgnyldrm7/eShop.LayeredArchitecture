namespace App.Core.DTOs
{
    public class RegisterDto
    {
        public string FirstName { get; set; } = default!;

        public string LastName { get; set; } = default!;

        public string Email { get; set; } = default!;

        public string Password { get; set; } = default!;

        public string PhoneNumber { get; set; } = default!;
    }
}