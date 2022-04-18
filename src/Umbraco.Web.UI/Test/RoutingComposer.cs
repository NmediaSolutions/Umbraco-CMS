using Umbraco.Core;
using Umbraco.Core.Composing;
using Umbraco.Web.UI.Umbraco.Components.Constraints;

namespace Umbraco.Web.UI.Umbraco.Composers
{
    public class RoutingComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Components().Append<TestRoutingComponent>();
        }
    }
}
