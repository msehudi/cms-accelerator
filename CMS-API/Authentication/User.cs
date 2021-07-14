using System;
using System.Security.Claims;

namespace CMS_API.Authentication
{
    public class User
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }

        internal ClaimsPrincipal ToClaimsPrincipal()
        {
            throw new NotImplementedException();
        }
    }
}