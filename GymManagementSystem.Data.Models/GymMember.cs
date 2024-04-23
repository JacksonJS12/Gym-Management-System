using Microsoft.AspNetCore.Identity;

namespace GymManagementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class GymMember
    {
        public GymMember()
        {
            Id = Guid.NewGuid();
            AttendanceRecords = new List<AttendanceRecord>();
        }
        [Key]
        public Guid Id { get; set; }

        public Guid? LockerId { get; set; }
        [ForeignKey(nameof(LockerId))]
        public virtual Locker? Locker { get; set; }

        public Guid UserId { get; set; }
        public virtual IdentityUser<Guid> User { get; set; } = null!;

        public bool MembershipStatus { get; set; } //Active = true, Inactive = false

        public int? MembershipPlanId { get; set; }
        [ForeignKey(nameof(MembershipPlanId))]    
        public virtual MembershipPlan? MembershipPlan { get; set; }

        public virtual ICollection<AttendanceRecord> AttendanceRecords{ get; set; }

        public int? GymEquipmentId { get; set; }
        [ForeignKey(nameof(GymEquipmentId))]
        public virtual GymEquipment? UsedGymEquipment { get; set; }

        [Required]
        public DateTime MembershipStartDate { get; set; }
        public DateTime? MembershipEndDate { get; set; }

    }
}
