using IdentityServer4.Models;
using System.Collections.Generic;

namespace AuthBackend.Data
{
    internal static class ResourceManager
    {
        public static IEnumerable<ApiScope> GetApiScopes()
        {
            return new List<ApiScope>
            {
                new ApiScope(name: "app.api.whatever.read", displayName: "Whatever read"),
                new ApiScope(name: "app.api.whatever.write", displayName: "Whatever write"),
                new ApiScope(name: "app.api.whatever.full", displayName: "Whatever full"),

                new ApiScope(name: "app.api.weather", displayName: "Weather Apis"),
            };
        }

        public static IEnumerable<ApiResource> Apis =>
            new List<ApiResource>
            {
                new ApiResource {
                    Name = "app.api.whatever",
                    DisplayName = "Whatever Apis",
                    ApiSecrets = { new Secret("a75a559d-1dab-4c65-9bc0-f8e590cb388d".Sha256()) },
                    Scopes = new List<string> {
                        "app.api.whatever.read",
                        "app.api.whatever.write",
                        "app.api.whatever.full"
                    }
                },
                new ApiResource {
                    Name = "app.api.weather",
                    DisplayName = "Weather Apis",
                    Enabled = true,
                    Scopes = new List<string> { "app.api.weather" }
                }
            };

        public static IEnumerable<IdentityResource> IdentityResources =>
            new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
            };
    }
}
