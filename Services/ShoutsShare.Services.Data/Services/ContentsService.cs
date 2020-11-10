namespace ShoutsShare.Services.Data.Services
{
    using System.Collections.Generic;
    using System.Linq;

    using ShoutsShare.Data.Common.Repositories;
    using ShoutsShare.Data.Models;
    using ShoutsShare.Services.Mapping;

    public class ContentsService : IContentsService
    {
        private readonly IDeletableEntityRepository<Content> contentsRepository;

        public ContentsService(IDeletableEntityRepository<Content> contentsRepository)
        {
            this.contentsRepository = contentsRepository;
        }

        public IEnumerable<T> GetAll<T>(int? count = null)
        {
            IQueryable<Content> query = this.contentsRepository.All().OrderBy(x => x.Likes);

            if (count.HasValue)
            {
                query = query.Take(count.Value);
            }

            return query.To<T>().ToList();
        }
    }
}
