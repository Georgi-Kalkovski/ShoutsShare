using ShoutsShare.Data.Common.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoutsShare.Data.Models
{
    public class Content : BaseDeletableModel<int>
    {
        public Content()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Comments = new HashSet<Comment>();
        }

        public new string Id { get; set; }

        [Required]
        public string Url { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Type { get; set; }

        public int Views { get; set; }

        public int Likes { get; set; }

        public TimeSpan? Duration { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        [ForeignKey(nameof(ContentThumbnail))]
        public int ContentThumbnailId { get; set; }
        public ContentThumbnail ContentThumbnail { get; set; }

        public string Info { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
