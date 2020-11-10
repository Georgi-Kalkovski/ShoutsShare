namespace ShoutsShare.Data.Models
{
    using ShoutsShare.Data.Common.Models;

    public class Comment : BaseDeletableModel<int>
    {
        public string Description { get; set; }

        public int? ContentId { get; set; }

        public virtual Content Content { get; set; }

        public string UserId { get; set; }

        public virtual Profile User { get; set; }
    }
}
