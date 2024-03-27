using System.ComponentModel.DataAnnotations.Schema;

namespace GymManagementSystem.Data.Models
{
    public class GymMember : ApplicationUser
    {
        public GymMember()
            : base()
        {

        }

        public Guid? LockerId { get; set; }
        [ForeignKey(nameof(LockerId))]
        public virtual Locker? Locker { get; set; }
        public bool? MembershipStatus { get; set; } //Active = true, Inactive = false
        public int? MembershipPlanId { get; set; }

        [ForeignKey(nameof(MembershipPlanId))]    
        public virtual MembershipPlan? MembershipPlan { get; set; }
        public DateTime MembershipStartDate { get; set; }
        public DateTime? MembershipEndDate { get; set; }
    }
}
