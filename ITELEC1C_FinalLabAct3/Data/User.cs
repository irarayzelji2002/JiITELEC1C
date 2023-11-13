using Microsoft.AspNetCore.Identity;

namespace ITELEC1C_FinalLabAct3.Data
{
    public class User : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
