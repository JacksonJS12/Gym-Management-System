namespace GymManagementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class StaffMember : ApplicationUser
    {
        public StaffMember()
            : base()
        {

        }

        [Required]
        public DateTime ContractStartDate { get; set; }

        [Required]
        public DateTime ContractEndDate { get; set; }

        [Required]
        public decimal Salary { get; set; }
    }
}
