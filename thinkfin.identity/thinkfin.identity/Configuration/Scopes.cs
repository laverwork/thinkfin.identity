using System;
using System.Collections.Generic;
using Thinktecture.IdentityServer.Core.Models;

namespace thinkfin.identity.Configuration
{
    public static class Scopes
    {
        public static IEnumerable<Scope> Get()
        {
            return new List<Scope>
            {
                StandardScopes.OpenId,
                StandardScopes.Roles,
                StandardScopes.Profile,
                StandardScopes.Email,
                StandardScopes.OfflineAccess,
                new Scope
                {
                    Enabled = true,
                    Name = "marketdataApi",
                    Description = "Access to a sample API",
                    Type = ScopeType.Resource
                }

            };
        }
    }
}