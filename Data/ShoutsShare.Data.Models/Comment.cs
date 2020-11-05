using ShoutsShare.Data.Common.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoutsShare.Data.Models
{
    public class Comment : BaseDeletableModel<int>
    {
        public DateTime PostDate { get; set; }

        public string Post { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}