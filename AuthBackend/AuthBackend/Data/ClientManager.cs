using IdentityServer4.Models;
using System.Collections.Generic;

namespace AuthBackend.Data
{
    internal static class ClientManager
    {
        public static IEnumerable<Client> Clients =>
            new List<Client>
            {
                    new Client
                    {
                         ClientName = "Client Application1",
                         ClientId = "t8agr5xKt4$3",
                         AllowedGrantTypes = GrantTypes.ClientCredentials,
                         ClientSecrets = { new Secret("eb300de4-add9-42f4-a3ac-abd3c60f1919".Sha256()) },
                         AllowedScopes = new List<string> { "app.api.whatever.read", "app.api.whatever.write" }
                    },
                    new Client
                    {
                         ClientName = "Client Application2",
                         ClientId = "3X=nNv?Sgu$S",
                         AllowedGrantTypes = GrantTypes.ClientCredentials,
                         ClientSecrets = { new Secret("1554db43-3015-47a8-a748-55bd76b6af48".Sha256()) },
                         AllowedScopes = { "app.api.weather" }
                    },
                    new Client
                    {
                         ClientName = "Interactive Client1",
                         ClientId = "test",
                         AllowedGrantTypes = GrantTypes.Code,
                         RequirePkce = true,
                         ClientSecrets = { new Secret("2dbe2d5f-aefc-416c-8ecf-5e333b064c1e".Sha256()) },
                         AllowedScopes = { "app.api.weather" }
                    }
            };
    }
}
