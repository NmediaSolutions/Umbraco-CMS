using System;
using System.Configuration;
using System.Web;
using System.Web.Routing;

namespace Umbraco.Web.UI.Umbraco.Components.Constraints
{
    public class TestRouteConstraint : IRouteConstraint
    {
        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            //ConfigurationManager.AppSettings.Set("Test", "2");
            var testValue = ConfigurationManager.AppSettings.Get("Test");
            if (testValue == "1")
            {
                return false;
            }


            return true;
        }
    }
}
