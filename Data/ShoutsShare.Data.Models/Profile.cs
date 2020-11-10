namespace ShoutsShare.Data.Models
{
    using System;
    using System.Collections.Generic;

    using ShoutsShare.Data.Common.Models;
    using ShoutsShare.Data.Models.Enums;

    public class Profile : BaseDeletableModel<int>
    {
        public Profile()
        {
            this.FriendList = new HashSet<Profile>();
            this.Contents = new HashSet<Content>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Nickname { get; set; }

        public DateTime? BirthDate { get; set; }

        public Gender? Gender { get; set; }

        public string Address { get; set; }

        public string Description { get; set; }

        public int? Likes { get; set; }

        public int? ProfilePictureId { get; set; }

        public virtual ProfilePicture ProfilePicture { get; set; }

        public int? CountryId { get; set; }

        public virtual Country Country { get; set; }

        public virtual ICollection<Profile> FriendList { get; set; }

        public virtual ICollection<Content> Contents { get; set; }
    }
}
