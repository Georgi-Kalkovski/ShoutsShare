namespace ShoutsShare.Web.ViewModels.Contents
{
    using System;

    using ShoutsShare.Data.Models;
    using ShoutsShare.Services.Mapping;

    public class ContentViewModel : IMapFrom<Content>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public TimeSpan? Duration { get; set; }

        public int? Views { get; set; } = 0;

        public int? Likes { get; set; } = 0;

        public string UserId { get; set; }

        public string FileModelId { get; set; }

        public string ContentFileId { get; set; }

        public int? CategoryId { get; set; } = 0;
    }
}
