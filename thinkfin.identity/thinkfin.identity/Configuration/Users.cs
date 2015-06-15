using System.Collections.Generic;
using System.Security.Claims;
using Thinktecture.IdentityServer.Core;
using Thinktecture.IdentityServer.Core.Services.InMemory;

namespace thinkfin.identity.Configuration
{
    public static class Users
    {
        public static List<InMemoryUser> Get()
        {
            return new List<InMemoryUser>
            {
                new InMemoryUser
                {
                    Username = "matt",
                    Password = "matt",
                    Subject = "1",
                    Claims = new List<Claim>
                    {
                        new Claim(Constants.ClaimTypes.GivenName, "matt"),
                        new Claim(Constants.ClaimTypes.FamilyName, "laver"),
                        new Claim(Constants.ClaimTypes.Email, "matt@laver.io"),
                        new Claim(Constants.ClaimTypes.Role, "Admin")
                    }
                }
            };
        }
    }
}