namespace ShoutsShare.Web.Controllers
{
    using System.Diagnostics;

    using Microsoft.AspNetCore.Mvc;
    using ShoutsShare.Services.Data.Services;
    using ShoutsShare.Web.ViewModels;
    using ShoutsShare.Web.ViewModels.Home;

    public class HomeController : BaseController
    {
        private readonly IContentsService contentsService;

        public HomeController(IContentsService contentsService)
        {
            this.contentsService = contentsService;
        }

        public IActionResult Index()
        {
            var viewModel = new IndexViewModel
            {
                Contents =
                this.contentsService.GetAll<IndexContentViewModel>(),
            };
            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
