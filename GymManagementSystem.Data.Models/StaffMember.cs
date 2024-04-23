using Microsoft.AspNetCore.Identity;

namespace GymManagementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static Common.EntityValidationConstants.User;

    public class StaffMember
    {
        public StaffMember()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }
    
        [Required]
        public DateTime ContractStartDate { get; set; }

        [Required]
        public DateTime ContractEndDate { get; set; }

        [Required]
        public decimal Salary { get; set; }

        [Required]
        [MaxLength(PhoneNumberMaxLength)]
        public string PhoneNumber { get; set; } = null!;

        public Guid UserId { get; set; }

        public virtual IdentityUser<Guid> User { get; set; } = null!;

        
    }
}
