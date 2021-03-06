﻿namespace ShoutsShare.Data.Models
{
    using ShoutsShare.Data.Common.Models;

    public class Comment : BaseDeletableModel<int>
    {
        public int ContentId { get; set; }

        public virtual Content Content { get; set; }

        public int? ParentId { get; set; }

        public virtual Comment Parent { get; set; }

        public string Description { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
