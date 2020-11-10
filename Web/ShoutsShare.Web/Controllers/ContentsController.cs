namespace ShoutsShare.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using ShoutsShare.Services.Data.Services;
    using ShoutsShare.Web.ViewModels.Contents;

    public class ContentsController : Controller
    {
        private readonly IContentsService contentsService;

        public ContentsController(IContentsService contentsService)
        {
            this.contentsService = contentsService;
        }

        public IActionResult ByName()
        {
            var viewModel = this.contentsService.GetByName<ContentViewModel>();
            return this.View(viewModel);
        }
    }
}
