using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CustomIdentity.Models
{
    //IdentityUser has server classes: UserName, Email, PhoneNumber ...
    public class AppUser : IdentityUser
    {
        [Required]
        public string? Name { get; set; }
        public string? Address { get; set; }
    }
}
