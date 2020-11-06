using ShoutsShare.Data.Common.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoutsShare.Data.Models
{
    public class ProfilePicture : BaseDeletableModel<int>
    {
        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
