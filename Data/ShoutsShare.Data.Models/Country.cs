// ReSharper disable VirtualMemberCallInConstructor
using ShoutsShare.Data.Common;
using ShoutsShare.Data.Common.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShoutsShare.Data.Models
{
    public class Country : BaseDeletableModel<int>
    {
        public Country()
        {
            this.CountryUsers = new HashSet<ApplicationUser>();
        }

        [Required]
        [MaxLength(DataValidation.NameMaxLength)]
        public string Name { get; set; }

        public virtual ICollection<ApplicationUser> CountryUsers { get; set; }
    }
}