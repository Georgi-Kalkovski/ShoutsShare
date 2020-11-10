namespace ShoutsShare.Web.ViewModels.Home
{
    public class IndexContentViewModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Type { get; set; }

        public string ImageUrl { get; set; }

        public string Url => $"/Leaderboard/{this.Title.Replace(' ', '-')}";
    }
}