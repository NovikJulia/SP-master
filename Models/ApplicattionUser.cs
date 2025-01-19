using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace SP.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [Display(Name = "Vorname")]
        public string Vorname { get; set; } = string.Empty;

        public string? Nachname { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; } = string.Empty;
        public string? Email { get; set; } = string.Empty;

        public UserType Type { get; set; } = UserType.Student;
    }

    public enum UserType
    {
        Student,
        Lehrer, 
        Manager,
        Admin
    }
}
