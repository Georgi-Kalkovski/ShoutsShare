namespace ShoutsShare.Data.Models
{
    using System.Collections.Generic;

    using ShoutsShare.Data.Common.Models;

    public class Category : BaseDeletableModel<int>
    {
        public Category()
        {
            this.Contents = new HashSet<Content>();
        }

        public string Name { get; set; }

        public ICollection<Content> Contents { get; set; }
    }
}
