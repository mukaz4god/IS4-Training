using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.Models;

namespace IS4
{
    public class Config
    {
        public static IEnumerable<ApiResource> Resources()
        {
            return new List<ApiResource>
            {
                 new ApiResource { Name="IS4", DisplayName="Identity Server 4"},
                 new ApiResource { Name="IS4_2", DisplayName="Identity Server 5"}
            };
        }

        public static IEnumerable<Client> Clients()
        {
            return new List<Client>
            {
                new Client {
                    ClientId = "client1",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets =
                    {
                        new Secret("mysecret".Sha256())
                    },
                    AllowedScopes = { "IS4 "},
                },
                new Client
                {
                    ClientId = "client2",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets =
                    {
                        new Secret("mysecret2".Sha256())
                    },
                   AllowedScopes = {"IS4_2"}
                }
            };
        }
    }
}
