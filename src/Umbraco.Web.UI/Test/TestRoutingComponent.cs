using System.Configuration;
using System.Web.Routing;
using Umbraco.Core.Composing;
using Umbraco.Web.UI.Umbraco.Handlers;

namespace Umbraco.Web.UI.Umbraco.Components.Constraints
{
    public class TestRoutingComponent : IComponent
    {
        private const string ActionName = "Test";
        private const string ControllerName = "Test";

        private readonly TestRouteConstraint _testRouteConstraint;

        public TestRoutingComponent()
        {
            _testRouteConstraint = new TestRouteConstraint();
        }

        public void Initialize()
        {
            object defaults = new { controller = ControllerName, action = ActionName };
            object constraints = new { action = _testRouteConstraint };
            var defaultHandler = new TestRoutingHandler(int.Parse(ConfigurationManager.AppSettings.Get("TestContentID")));

            RouteTable.Routes.MapUmbracoRoute(
              "TestRouteDefault",
              "test/{testValue}",
              defaults,
              defaultHandler,
              constraints
            );
        }

        public void Terminate()
        {
        }
    }
}
