namespace GymManagementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Common;
    using static Common.EntityValidationConstants.GymEquipment;
    public class GymEquipment
    {
        public GymEquipment()
        {
            
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        public Availability Availability { get; set; }

        public DateTime LastMaintenanceDate { get; set; }

        public Guid? UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public virtual GymMember? GymMember { get; set; }

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;
    }


}
