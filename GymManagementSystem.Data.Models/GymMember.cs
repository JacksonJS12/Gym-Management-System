namespace GymManagementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    
    using static Common.EntityValidationConstants.GymMember;
    public class GymMember
    {
        public GymMember()
        {
            this.Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(PhoneNumberMaxLength)]
        public string PhoneNumber { get; set; } = null!;

        public Guid? LockerId { get; set; }
        public virtual Locker? Locker { get; set; }
        public bool? MembershipStatus { get; set; } //Active = true, Inactive = false
        public int? MembershipPlanId { get; set; }
        public virtual MembershipPlan? MembershipPlan { get; set; }
        public DateTime? MembershipStartDate { get; set; }
        public DateTime? MembershipEndDate { get; set; }

        public Guid UserId { get; set; }
        public virtual User User { get; set; } = null!;
    }
}
