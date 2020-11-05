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
            this.Comments = new HashSet<Comment>();
        }

        [Required]
        public string Url { get; set; }

        [Required]
        public string Title { get; set; }

        public int Views { get; set; }

        public int Likes { get; set; }

        public TimeSpan? Duration { get; set; }

        [ForeignKey(nameof(SocialMedia))]
        public int SocialMediaId { get; set; }
        public SocialMedia SocialMedia { get; set; }

        [Required]
        [ForeignKey(nameof(Creator))]
        public string CreatorId { get; set; }
        public virtual ApplicationUser Creator { get; set; }

        public string Info { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
