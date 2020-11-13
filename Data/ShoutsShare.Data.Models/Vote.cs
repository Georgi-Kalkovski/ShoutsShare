namespace ShoutsShare.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using ShoutsShare.Data.Common.Models;

    public class Vote : BaseModel<int>
    {
        public int ContentId { get; set; }

        public virtual Content Content { get; set; }

        [Required]
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public VoteType Type { get; set; }
    }
}
