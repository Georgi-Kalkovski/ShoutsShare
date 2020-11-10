namespace ShoutsShare.Web.ViewModels.Contents
{
    using System;
    using System.Collections.Generic;

    using ShoutsShare.Data.Models;
    using ShoutsShare.Services.Mapping;

    public class ContentViewModel : IMapFrom<Content>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string ImageUrl { get; set; }

        public string Type { get; set; }

        public string Description { get; set; }

        public virtual IEnumerable<CommentInContentViewModel> Comments { get; set; }
    }
}
