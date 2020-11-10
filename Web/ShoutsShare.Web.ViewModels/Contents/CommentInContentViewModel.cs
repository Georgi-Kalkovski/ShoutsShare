namespace ShoutsShare.Web.ViewModels.Contents
{
    using ShoutsShare.Data.Models;
    using ShoutsShare.Services.Mapping;

    public class CommentInContentViewModel : IMapFrom<Comment>
    {
        public string Description { get; set; }

        public virtual string User { get; set; }

        public int CommentsCount { get; set; }
    }
}
