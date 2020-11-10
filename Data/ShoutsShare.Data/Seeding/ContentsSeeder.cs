namespace ShoutsShare.Data.Seeding
{
    using System;
    using System.Collections.Generic;
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

            var contents = new List<string> { "Sport", "Coronavirus", "News", "Music", "Programming", "Cats", "Dogs" };
            foreach (var content in contents)
            {
                await dbContext.Contents.AddAsync(new Content
                {
                    Title = content,
                    Type = content,
                    Description = content,
                });
            }
        }
    }
}
