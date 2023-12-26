using Microsoft.AspNetCore.Identity;
namespace ECUEvents.Data
{
    public class ApplicationUser:IdentityUser
    {
        public string FirstName { get; set; }
        public string LasttName { get; set; }
        

    }
}
