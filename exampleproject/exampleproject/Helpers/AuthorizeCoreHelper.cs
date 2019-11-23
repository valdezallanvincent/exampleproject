using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace exampleproject.Helpers
{
    public class AuthorizeCoreHelper : AuthorizeAttribute
    {
        protected override bool IsAuthorized(HttpActionContext actionContext)
        {
            try
            {
                var requestHeaders = actionContext.Request.Headers.Authorization;
                if(requestHeaders.Scheme == "abcd1234"
                    || requestHeaders.Parameter == "abcd1234")
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}