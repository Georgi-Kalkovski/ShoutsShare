namespace ShoutsShare.Services.Data.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using ShoutsShare.Data.Common.Repositories;
    using ShoutsShare.Data.Models;
    using ShoutsShare.Services.Data.Interfaces;
    using ShoutsShare.Services.Mapping;
    using ShoutsShare.Web.ViewModels.Comments;

    public class CommentsService : ICommentsService
    {
        private readonly IDeletableEntityRepository<Comment> commentsRepository;

        public CommentsService(
            IDeletableEntityRepository<Comment> commentsRepository)
        {
            this.commentsRepository = commentsRepository;
        }

        public async Task Create(CommentViewModel input)
        {
            var comment = new Comment
            {
                Description = input.Description,
                ParentId = input.ParentId,
                ContentId = input.ContentId,
                UserId = input.UserId,
            };
            await this.commentsRepository.AddAsync(comment);
            await this.commentsRepository.SaveChangesAsync();
        }

        public bool IsInPostId(int commentId, int postId)
        {
            var commentPostId = this.commentsRepository.All().Where(x => x.Id == commentId)
                .Select(x => x.ContentId).FirstOrDefault();
            return commentPostId == postId;
        }

        public IEnumerable<T> GetAll<T>()
        {
            return this.commentsRepository.All().To<T>().ToList();
        }
    }
}
