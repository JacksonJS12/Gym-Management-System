namespace GymManagementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Common;

    public class Locker
    {
        public Locker()
        {
            this.Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }

        [Required]
        public int LockerNumber { get; set; }

        public Availability LockerAvailability { get; set; } 

        //public Guid? UserId { get; set; }

        //[ForeignKey(nameof(UserId))]
        //public virtual GymMember? User { get; set; } = null!;
    }

}
