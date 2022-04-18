using System.Web.Mvc;
using Umbraco.Core.Models;
using Umbraco.Core.Services;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace Umbraco.Web.UI.Controllers
{
    public class TestController : RenderMvcController
    {
        private readonly IFileService _fileService;

        public TestController(IFileService fileService)
        {
            _fileService = fileService;
        }

        public ActionResult Test(ContentModel model)
        {
            ITemplate template = _fileService.GetTemplate(model.Content.TemplateId.Value);
            return View(template.Alias, model);
        }
    }
}
