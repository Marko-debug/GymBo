using Microsoft.AspNetCore.Identity;

namespace GymBo.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Order>? Order { get; set; }
    }
}
