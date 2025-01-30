using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using UsersApp.Validators;

namespace UsersApp.Models
{
    public class Users : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime? DOB { get; set; }
        public DateTime Createtime { get; set; }
        public string? ProfilePictureUrl { get; set; }

        public string? Gender { get; set; }  // مثال: "Male", "Female", "Other"

    }
}
