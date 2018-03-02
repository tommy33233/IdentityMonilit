using Microsoft.AspNet.Identity.EntityFramework;

namespace IdentityAuth.Models
{
    public class ApplicationUser:IdentityUser
    {
        public int Year { get; set; }
        public ApplicationUser()
        {
        }
    }
}