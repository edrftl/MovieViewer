using Microsoft.AspNetCore.Identity;

namespace MovieViewer.Data.Entities
{
    public class User : IdentityUser
    {
        // add custom properties
        public DateTime? Birthdate { get; set; }
    }
}
