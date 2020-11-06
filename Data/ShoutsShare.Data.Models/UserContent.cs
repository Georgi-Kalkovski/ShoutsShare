using ShoutsShare.Data.Common.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoutsShare.Data.Models
{
    public class UserContent : BaseDeletableModel<int>
    {
        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        [Required]
        [ForeignKey(nameof(Content))]
        public string ContentId { get; set; }
        public virtual Content Content { get; set; }

        public virtual SocialMedia SocialMedia { get; set; }
    }
}
