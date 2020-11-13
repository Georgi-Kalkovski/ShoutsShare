namespace ShoutsShare.Services.Data.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using ShoutsShare.Data.Common.Repositories;
    using ShoutsShare.Data.Models;
    using ShoutsShare.Services.Mapping;
    using ShoutsShare.Web.ViewModels.Contents;

    public class ContentsService : IContentsService
    {
        private readonly IDeletableEntityRepository<Content> contentsRepository;

        public ContentsService(IDeletableEntityRepository<Content> contentsRepository)
        {
            this.contentsRepository = contentsRepository;
        }

        public async Task CreateAsync(CreateContentInputModel input)
        {
            var content = new Content
            {
                Name = input.Name,
                Description = input.Description,
                Duration = TimeSpan.FromMinutes(input.Duration.Value),
                Views = input.Views,
                Likes = input.Likes,
                UserId = input.UserId,
                FileModelId = input.FileModelId,
                CategoryId = input.CategoryId,
            };
            await this.contentsRepository.AddAsync(content);
            await this.contentsRepository.SaveChangesAsync();
        }
    }
}
