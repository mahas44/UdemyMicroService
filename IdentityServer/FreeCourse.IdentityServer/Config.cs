// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using FreeCourse.IdentityServer.Constants;
using IdentityServer4;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;

namespace FreeCourse.IdentityServer
{
    public static class Config
    {

        public static IEnumerable<ApiResource> ApiResources => new ApiResource[]
        {
            new ApiResource(ConfigConstants.ApiResources.Catalog) { Scopes={ ConfigConstants.Scopes.CatalogFullPermission} },
            new ApiResource(ConfigConstants.ApiResources.PhotoStock){ Scopes={ ConfigConstants.Scopes.PhotoStockFullPermission } },
            new ApiResource(ConfigConstants.ApiResources.Basket){ Scopes={ ConfigConstants.Scopes.BasketFullPermission } },
            new ApiResource(ConfigConstants.ApiResources.Discount){ Scopes={ ConfigConstants.Scopes.DiscountFullPermission } },
            new ApiResource(IdentityServerConstants.LocalApi.ScopeName)
        };

        public static IEnumerable<IdentityResource> IdentityResources =>
                   new IdentityResource[]
                   {
                       new IdentityResources.Email(), // email claim
                       new IdentityResources.OpenId(), // sub claim
                       new IdentityResources.Profile(),
                       new IdentityResource(){
                           Name = ConfigConstants.CustomIdentityResource.Name,
                           DisplayName = ConfigConstants.CustomIdentityResource.DisplayName,
                           Description = ConfigConstants.CustomIdentityResource.Description,
                           UserClaims = new []{ ConfigConstants.CustomIdentityResource.Claim }
                       }
                   };

        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
                new ApiScope(ConfigConstants.Scopes.CatalogFullPermission, ConfigConstants.ScopeMessages.CatalogFullPermissionMsg),
                new ApiScope(ConfigConstants.Scopes.PhotoStockFullPermission, ConfigConstants.ScopeMessages.PhotoStockFullPermissionMsg),
                new ApiScope(ConfigConstants.Scopes.BasketFullPermission, ConfigConstants.ScopeMessages.BasketFullPermissionMsg),
                new ApiScope(ConfigConstants.Scopes.DiscountFullPermission, ConfigConstants.ScopeMessages.DiscountFullPermissionMsg),
                new ApiScope(IdentityServerConstants.LocalApi.ScopeName),
            };

        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                new Client()
                {
                   ClientName = ConfigConstants.ClientName,
                   ClientId = ConfigConstants.ClientIdForEveryOne,
                   ClientSecrets = {new Secret(ConfigConstants.Secret.Sha256()) },
                   AllowedGrantTypes = GrantTypes.ClientCredentials,
                   AllowedScopes = { ConfigConstants.Scopes.CatalogFullPermission, ConfigConstants.Scopes.PhotoStockFullPermission, IdentityServerConstants.LocalApi.ScopeName },

                },
                new Client()
                {
                   ClientName = ConfigConstants.ClientName,
                   ClientId = ConfigConstants.ClientIdForUser,
                   ClientSecrets = {new Secret(ConfigConstants.Secret.Sha256()) },
                   AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,
                   AllowOfflineAccess =true,
                   AllowedScopes = {
                        ConfigConstants.Scopes.BasketFullPermission,
                        ConfigConstants.Scopes.DiscountFullPermission,
                        IdentityServerConstants.StandardScopes.Email,
                        IdentityServerConstants.StandardScopes.Address,
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.StandardScopes.OfflineAccess, // refresh token 
                        IdentityServerConstants.LocalApi.ScopeName,
                        ConfigConstants.CustomIdentityResource.Name,

                    },
                   AccessTokenLifetime = 1*60*60,
                   RefreshTokenExpiration = TokenExpiration.Absolute,
                   AbsoluteRefreshTokenLifetime = (int) (DateTime.Now.AddDays(60)-DateTime.Now).TotalSeconds,
                   RefreshTokenUsage = TokenUsage.ReUse,

                }
            };
    }
}