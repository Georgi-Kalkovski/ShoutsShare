namespace ShoutsShare.Web.ViewModels.Comments
{
    using System.ComponentModel.DataAnnotations;

    using ShoutsShare.Data.Models;
    using ShoutsShare.Services.Mapping;

    public class CreateCommentInputModel
    {
        public int PostId { get; set; }

        public int ParentId { get; set; }

        [Required]
        [MinLength(3)]
        public string Content { get; set; }
    }
}
