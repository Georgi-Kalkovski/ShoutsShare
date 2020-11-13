namespace ShoutsShare.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using ShoutsShare.Data.Common.Models;

    public class Content : BaseDeletableModel<int>
    {
        public Content()
        {
            this.Comments = new HashSet<Comment>();
            this.Votes = new HashSet<Vote>();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public TimeSpan? Duration { get; set; }

        public int? Views { get; set; }

        public int? Likes { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public string FileModelId { get; set; }

        public virtual FileModel FileModel { get; set; }

        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<Vote> Votes { get; set; }
    }
}
