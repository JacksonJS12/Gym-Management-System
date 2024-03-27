namespace GymManagementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class AttendanceLog
    {
        public AttendanceLog()
        {
            this.Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }

        public Guid UserId { get; set; }
        public virtual User User { get; set; } = null!;

        public DateTime CheckInDateTime { get; set; }
        public DateTime CheckOutDateTime { get; set; }
    }
}
