namespace ShoutsShare.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore.Internal;
    using ShoutsShare.Data.Models;

    public class ProfilesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Profiles.Any())
            {
                return;
            }

            var profiles = new List<string> { "Sport", "Coronavirus", "News", "Music", "Programming", "Cats", "Dogs" };
            foreach (var profile in profiles)
            {
                await dbContext.Profiles.AddAsync(new Profile
                {
                    FirstName = profile,
                    LastName = profile,
                    Nickname = profile,
                    Description = profile,
                });
            }
        }
    }
}
