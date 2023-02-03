using Microsoft.AspNetCore.Identity;
using TestAPI.Models;

namespace TestAPI.Models.Response
{
    public class RegistrationResponse : AutResult
    {
        public IdentityUser userDetails { get; set; }
    }
}
