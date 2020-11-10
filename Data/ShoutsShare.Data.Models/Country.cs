// ReSharper disable VirtualMemberCallInConstructor
namespace ShoutsShare.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using ShoutsShare.Data.Common.Models;

    public class Country : BaseDeletableModel<int>
    {
        public Country()
        {
            this.CountryUsers = new HashSet<Profile>();
        }

        public string Name { get; set; }

        public virtual ICollection<Profile> CountryUsers { get; set; }
    }
}
