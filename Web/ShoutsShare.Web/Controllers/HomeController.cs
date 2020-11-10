namespace ShoutsShare.Web.Controllers
{
    using System.Diagnostics;
    using System.Linq;

    using Microsoft.AspNetCore.Mvc;
    using ShoutsShare.Data;
    using ShoutsShare.Web.ViewModels;
    using ShoutsShare.Web.ViewModels.Home;

    public class HomeController : BaseController
    {
        private readonly ApplicationDbContext db;

        public HomeController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var viewModel = new IndexViewModel();
            var contents = this.db.Contents.Select(x => new IndexContentViewModel
            {
                Title = x.Title,
                Description = x.Description,
                ImageUrl = x.ImageUrl,
                Type = x.Type,
            }).ToList();

            viewModel.Contents = contents;
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
