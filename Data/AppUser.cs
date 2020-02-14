using Microsoft.AspNetCore.Identity;

namespace CBBlazorEFID.Data
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }                
    }
}