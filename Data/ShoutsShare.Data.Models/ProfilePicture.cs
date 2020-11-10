namespace ShoutsShare.Data.Models
{
    using ShoutsShare.Data.Common.Models;

    public class ProfilePicture : BaseDeletableModel<int>
    {
        public string UserId { get; set; }

        public virtual Profile User { get; set; }
    }
}
