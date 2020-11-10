namespace ShoutsShare.Web.ViewModels.Home
{
    using ShoutsShare.Data.Models;
    using ShoutsShare.Services.Mapping;

    public class IndexContentViewModel : IMapFrom<Content>
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Type { get; set; }

        public string ImageUrl { get; set; }

        public string Url => $"/Leaderboard/{this.Title.Replace(' ', '-')}";
    }
}
