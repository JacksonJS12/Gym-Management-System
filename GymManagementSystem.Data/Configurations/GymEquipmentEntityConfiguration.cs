namespace GymManagementSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Common;
    using Models;

    public class GymEquipmentEntityConfiguration : IEntityTypeConfiguration<GymEquipment>
    {
        public void Configure(EntityTypeBuilder<GymEquipment> builder)
        {
            builder
                .Property(ge => ge.LastMaintenanceDate)
                .HasDefaultValueSql("GETDATE()");

            builder
                .Property(ge => ge.Availability)
                .HasDefaultValue(Availability.Available);
        }
    }
}
