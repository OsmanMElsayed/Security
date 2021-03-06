// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Security.Claims;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Http.Authentication;

namespace Microsoft.AspNet.Authentication.Cookies
{
    /// <summary>
    /// Context object passed to the ICookieAuthenticationEvents method SignedIn.
    /// </summary>    
    public class CookieSignedInContext : BaseCookieContext
    {
        /// <summary>
        /// Creates a new instance of the context object.
        /// </summary>
        /// <param name="context">The HTTP request context</param>
        /// <param name="options">The middleware options</param>
        /// <param name="authenticationScheme">Initializes AuthenticationScheme property</param>
        /// <param name="principal">Initializes Principal property</param>
        /// <param name="properties">Initializes Properties property</param>
        public CookieSignedInContext(
            HttpContext context,
            CookieAuthenticationOptions options,
            string authenticationScheme,
            ClaimsPrincipal principal,
            AuthenticationProperties properties)
            : base(context, options)
        {
            AuthenticationScheme = authenticationScheme;
            Principal = principal;
            Properties = properties;
        }

        /// <summary>
        /// The name of the AuthenticationScheme creating a cookie
        /// </summary>
        public string AuthenticationScheme { get; }

        /// <summary>
        /// Contains the claims that were converted into the outgoing cookie.
        /// </summary>
        public ClaimsPrincipal Principal { get; }

        /// <summary>
        /// Contains the extra data that was contained in the outgoing cookie.
        /// </summary>
        public AuthenticationProperties Properties { get; }
    }
}
