namespace ShoutsShare.Web.Controllers
{
    using System;
    using System.Diagnostics;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.CodeAnalysis.CSharp.Syntax;
    using ShoutsShare.Data.Common.Repositories;
    using ShoutsShare.Data.Models;
    using ShoutsShare.Services.Data.Interfaces;
    using ShoutsShare.Web.ViewModels;
    using ShoutsShare.Web.ViewModels.Contents;


    public class HomeController : Controller
    {
        private readonly IContentsService contentsService;

        public HomeController(IContentsService contentsService)
        {
            this.contentsService = contentsService;
        }

        public IActionResult Index()
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
