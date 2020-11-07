using ShoutsShare.Data.Common.Models;

namespace ShoutsShare.Data.Models
{
    public class ContentThumbnail : BaseDeletableModel<int>
    {
        public string ImageUrl { get; set; }
    }
}
