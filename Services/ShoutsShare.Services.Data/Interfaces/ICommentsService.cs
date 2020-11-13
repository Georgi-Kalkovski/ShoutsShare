namespace ShoutsShare.Services.Data.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using ShoutsShare.Web.ViewModels.Comments;

    public interface ICommentsService
    {
        Task Create(CommentViewModel input);

        bool IsInPostId(int commentId, int postId);

        IEnumerable<T> GetAll<T>();
    }
}
