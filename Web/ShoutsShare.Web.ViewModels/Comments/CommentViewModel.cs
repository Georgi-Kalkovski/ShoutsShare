namespace ShoutsShare.Web.ViewModels.Comments
{
    using System;

    using ShoutsShare.Data.Models;
    using ShoutsShare.Services.Mapping;

    public class CommentViewModel : IMapFrom<Comment>
    {
        public int Id { get; set; }

        public int? ParentId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public string Description { get; set; }

        public int ContentId { get; set; }

        public int MyProperty { get; set; }

        public string UserId { get; set; }
    }
}
