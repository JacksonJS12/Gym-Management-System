namespace GymManagementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class MembershipPlan
    {
        public MembershipPlan()
        {
            
        }

        [Key] 
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; } = null!;

        [Required] 
        public decimal Price { get; set; }


    }
}