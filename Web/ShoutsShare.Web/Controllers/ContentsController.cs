namespace ShoutsShare.Web.Controllers
{
    using System.Security.Cryptography.X509Certificates;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using ShoutsShare.Services.Data.Interfaces;
    using ShoutsShare.Web.ViewModels.Contents;

    public class ContentsController : Controller
    {
        private readonly IContentsService contentsService;

        public ContentsController(IContentsService contentsService)
        {
            this.contentsService = contentsService;
        }

        public IActionResult Create()
        {
            var viewModel = new CreateContentInputModel();
            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateContentInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            await this.contentsService.CreateAsync(input);

            return this.Redirect("/");
        }
    }
}
