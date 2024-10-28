using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebApiProject
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string? LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(50)]
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
    [Keyless]
    public class UserDetails:IdentityUser
    {
        public int UserId { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string? LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }

    }
    public class LoginModel
    {
        public string UserEmail{ get; set; }
        public string Password { get; set; }
    }
   
}
