namespace ShoutsShare.Web.ViewModels.Contents
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using ShoutsShare.Data.Models;
    using ShoutsShare.Services.Mapping;
    using ShoutsShare.Web.ViewModels.Comments;

    public class CreateContentInputModel : IMapTo<Content>
    {
        [MinLength(3)]
        public string Name { get; set; }

        [MinLength(3)]
        public string Description { get; set; }

        [Range(0, 24 * 60)]
        public int? Duration { get; set; }

        [Range(0, double.PositiveInfinity)]
        public int? Views { get; set; }

        [Range(0, double.PositiveInfinity)]
        public int? Likes { get; set; }

        public string UserId { get; set; }

        public string FileModelId { get; set; }

        public string ContentFileId { get; set; }

        public int? CategoryId { get; set; }

        public virtual IEnumerable<Comment> Comments { get; set; }
    }
}
