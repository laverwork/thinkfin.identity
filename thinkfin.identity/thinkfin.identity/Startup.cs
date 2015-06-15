﻿using Owin;
using thinkfin.identity.Configuration;
using Thinktecture.IdentityServer.Core.Configuration;
namespace thinkfin.identity
{
    public sealed class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Map(
                "/core",
                coreApp => coreApp.UseIdentityServer(new IdentityServerOptions
                {
                    SiteName = "Standalone Identity Server",
                    SigningCertificate = Cert.Load(),
                    Factory = InMemoryFactory.Create(Users.Get(), Clients.Get(), Scopes.Get()),
                    RequireSsl = true
                }));
        }
    }
}