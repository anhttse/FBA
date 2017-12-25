using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Routing.Constraints;
using System.Web.Mvc;
using System.Web.Routing;

namespace FBA.Extension
{
    public class AuthorizeUser : System.Web.Mvc.AuthorizeAttribute
    {
        // Custom property
        public string AccessLevel { get; set; }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            var isAuthorized = base.AuthorizeCore(httpContext);
            if (!isAuthorized)
            {
                return false;
            }

            var ss = httpContext.Session[Common.UserSession].ToString();

            return !string.IsNullOrEmpty(ss);
        }
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new RedirectToRouteResult(
                new RouteValueDictionary(
                    new
                    {
                        controller = "Login",
                        action = "Index"
                    })
            );
        }
    }
}