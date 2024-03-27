namespace GymManagementSystem.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;

    using static Common.EntityValidationConstants.GymMember;
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid();
        }

        [Key]
        public override Guid Id { get; set; }

        [Required]
        [MaxLength(PhoneNumberMaxLength)]
        public override string PhoneNumber { get; set; } = null!;
    }
}
