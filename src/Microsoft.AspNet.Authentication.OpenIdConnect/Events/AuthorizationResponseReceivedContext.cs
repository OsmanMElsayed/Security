// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Http.Authentication;

namespace Microsoft.AspNet.Authentication.OpenIdConnect
{
    public class AuthorizationResponseReceivedContext : BaseOpenIdConnectContext
    {
        public AuthorizationResponseReceivedContext(HttpContext context, OpenIdConnectOptions options, AuthenticationProperties properties)
            : base(context, options)
        {
            Properties = properties;
        }

        public AuthenticationProperties Properties { get; }
    }
}
