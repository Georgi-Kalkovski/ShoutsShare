using ShoutsShare.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoutsShare.Data.Models
{
    public class ContentThumbnail : BaseDeletableModel<int>
    {
        public string ImageUrl { get; set; }
    }
}
