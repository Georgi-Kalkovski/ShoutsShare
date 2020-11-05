﻿using ShoutsShare.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoutsShare.Data.Models.RankLists
{
    public class WeeklyRankList : BaseDeletableModel<int>
    {
        public WeeklyRankList()
        {
            this.Contents = new HashSet<Content>();
        }

        public ICollection<Content> Contents { get; set; }
    }
}
