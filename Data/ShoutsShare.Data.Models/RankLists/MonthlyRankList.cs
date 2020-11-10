namespace ShoutsShare.Data.Models.RankLists
{
    using System.Collections.Generic;

    using ShoutsShare.Data.Common.Models;

    public class MonthlyRankList : BaseDeletableModel<int>
    {
        public MonthlyRankList()
        {
            this.Contents = new HashSet<Content>();
        }

        public ICollection<Content> Contents { get; set; }
    }
}
