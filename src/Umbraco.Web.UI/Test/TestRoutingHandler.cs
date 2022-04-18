using System.Web.Routing;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Mvc;

namespace Umbraco.Web.UI.Umbraco.Handlers
{
    public class TestRoutingHandler : UmbracoVirtualNodeRouteHandler
    {
        private readonly int _contentID;

        public TestRoutingHandler(int contentID)
        {
            _contentID = contentID;
        }

        protected sealed override IPublishedContent FindContent(RequestContext requestContext, UmbracoContext umbracoContext)
        {
            if (umbracoContext != null)
            {
                IPublishedContent content = umbracoContext.Content.GetById(false, _contentID);
                return content;
            }

            return null;
        }
    }
}
