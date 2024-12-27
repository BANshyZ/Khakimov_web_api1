using System.ComponentModel.DataAnnotations;
using Swashbuckle.AspNetCore.Annotations;

namespace SHURALE.Models
{
    public class Guest
    {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Invalid email format.")]
        [SwaggerSchema(Description = "Email address of the guest")]
        public string Email { get; set; }

        public Guest(string username, string password, string email)
        {
            Username = username ?? throw new ArgumentNullException(nameof(username), "Username cannot be null.");
            Password = password ?? throw new ArgumentNullException(nameof(password), "Password cannot be null.");
            Email = email ?? throw new ArgumentNullException(nameof(email), "Email cannot be null.");
        }
    }
}


