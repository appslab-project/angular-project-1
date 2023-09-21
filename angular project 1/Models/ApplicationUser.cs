using Microsoft.AspNetCore.Identity;

namespace angular_project_1.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int xp { get; set; }
        public string guild { get; set; }

    }
}