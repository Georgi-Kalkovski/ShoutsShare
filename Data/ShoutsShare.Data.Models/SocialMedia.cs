using ShoutsShare.Data.Common.Models;

namespace ShoutsShare.Data.Models
{
    public class SocialMedia : BaseDeletableModel<int>
    {
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Twitter { get; set; }
        public string Tumblr { get; set; }
        public string LinkedIn { get; set; }
        public string WhatsApp { get; set; }
        public string Snapchat { get; set; }
        public string Pinterest { get; set; }
        public string Reddit { get; set; }
        public string YouTube { get; set; }
        public string Mix { get; set; }
        public string Tagged { get; set; }
        public string Nextdoor { get; set; }
        public string DeviantArt { get; set; }
        public string Quora { get; set; }
        public string Meetup { get; set; }
        public string ReverbNation { get; set; }
        public string Flixster { get; set; }
        public string Goodreads { get; set; }
        public string Twitch { get; set; }
    }
}
