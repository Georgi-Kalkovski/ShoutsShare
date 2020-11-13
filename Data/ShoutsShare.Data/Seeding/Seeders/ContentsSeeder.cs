namespace ShoutsShare.Data.Seeding.Seeders
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using ShoutsShare.Data.Models;

    public class ContentsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Contents.Any())
            {
                return;
            }

            await dbContext.Contents.AddAsync(new Content { Name = "How to Basic For Dummies", Description = "Today I'll show you how to...", Duration = TimeSpan.FromMinutes(40), Views = 10, Likes = 50 });
            await dbContext.Contents.AddAsync(new Content { Name = "Today I Screwed Up", Description = "Today I'll show you how to...", Duration = TimeSpan.FromMinutes(40), Views = 10, Likes = 50 });
            await dbContext.Contents.AddAsync(new Content { Name = "Look at my new pet", Description = "Today I'll show you how to...", Duration = TimeSpan.FromMinutes(40), Views = 10, Likes = 50 });
        }
    }
}
