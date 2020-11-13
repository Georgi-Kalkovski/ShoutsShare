namespace ShoutsShare.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    using ShoutsShare.Data.Common.Models;

    public class FileModel : BaseDeletableModel<string>
    {
        public FileModel()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [ForeignKey(nameof(Content))]
        public int ContentId { get; set; }

        public virtual Content Content { get; set; }

        public string Extension { get; set; }

        public string AddedByUserId { get; set; }

        public ApplicationUser AddedByUser { get; set; }
    }
}
