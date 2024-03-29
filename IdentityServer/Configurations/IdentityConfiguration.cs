﻿using System.Collections.Generic;
using IdentityServer4.Models;
using IdentityServer4.Test;

namespace IdentityServer.Configurations
{
    public class IdentityConfiguration
    {
        public static IEnumerable<Client> Clients =>
            new[]
            {
                new Client()
                {
                    ClientId = "ShoppingCartClient",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },
                    AllowedScopes = { "ShoppingCartAPI" }
                }
            };

        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
                new ApiScope("ShoppingCartAPI", "Shopping Cart API")
            };

        public static IEnumerable<ApiResource> ApiResources =>
            new ApiResource[]
            {

            };

        public static IEnumerable<IdentityResource> IdentityResources =>
            new IdentityResource[]
            {

            };
        
        public static IEnumerable<TestUser> TestUsers =>
            new TestUser[]
            {

            };
    }
}
