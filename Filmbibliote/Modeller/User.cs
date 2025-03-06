using Microsoft.AspNetCore.Identity;

namespace Filmbibliote.Modeller
{
    public class User : IdentityUser
    {
        public string Address { get; set; }
    }
}
