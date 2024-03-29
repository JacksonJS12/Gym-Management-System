namespace GymManagementSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    public class AttendanceRecordEntityConfiguration : IEntityTypeConfiguration<AttendanceRecord>
    {
        public void Configure(EntityTypeBuilder<AttendanceRecord> builder)
        {
            builder
                .Property(a => a.HasLeft)
                .HasDefaultValue(false);

            builder
                .HasOne(ar => ar.User)
                .WithMany(u => u.AttendanceRecords)
                .HasForeignKey(ar => ar.UserId)
                .OnDelete(DeleteBehavior.Restrict);



        }
    }
}
