namespace ShoutsShare.Data.Models.RankLists
{
    using System.Collections.Generic;

    using ShoutsShare.Data.Common.Models;

    public class WeeklyRankList : BaseDeletableModel<int>
    {
        public WeeklyRankList()
        {
            this.Contents = new HashSet<Content>();
        }

        public ICollection<Content> Contents { get; set; }
    }
}
