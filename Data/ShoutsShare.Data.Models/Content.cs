namespace ShoutsShare.Data.Models
{
    using System;
    using System.Collections.Generic;

    using ShoutsShare.Data.Common.Models;

    public class Content : BaseDeletableModel<int>
    {
        public Content()
        {
            this.Comments = new HashSet<Comment>();
        }

        public string Title { get; set; }

        public string ImageUrl { get; set; }

        public string Type { get; set; }

        public string Description { get; set; }

        public int? Views { get; set; }

        public int? Likes { get; set; }

        public TimeSpan? Duration { get; set; }

        public string UserId { get; set; }

        public virtual Profile User { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
