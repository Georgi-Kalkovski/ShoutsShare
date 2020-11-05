// ReSharper disable VirtualMemberCallInConstructor
namespace ShoutsShare.Data.Models
{
    using System;
    using System.Collections.Generic;

    using ShoutsShare.Data.Common.Models;

    using Microsoft.AspNetCore.Identity;
    using ShoutsShare.Data.Models.Enums;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using ShoutsShare.Data.Common;

    public class ApplicationUser : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Roles = new HashSet<IdentityUserRole<string>>();
            this.Claims = new HashSet<IdentityUserClaim<string>>();
            this.Logins = new HashSet<IdentityUserLogin<string>>();
            this.FriendList = new HashSet<ApplicationUser>();

            this.Contents = new HashSet<UserContent>();
        }

        [Required]
        [MaxLength(DataValidation.NameMaxLength)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(DataValidation.NameMaxLength)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(DataValidation.NameMaxLength)]
        public string Nickname { get; set; }

        public DateTime BirthDate { get; set; }

        [Required]
        public Gender Gender { get; set; }

        public string Address { get; set; }

        public string Info { get; set; }

        public int Likes { get; set; }

        [ForeignKey(nameof(Country))]
        public int CountryId { get; set; }
        public Country Country { get; set; }

        public virtual ICollection<UserContent> Contents { get; set; }

        public virtual ICollection<ApplicationUser> FriendList { get; set; }

        // Audit info
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        // Deletable entity
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }

        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }
    }
}
