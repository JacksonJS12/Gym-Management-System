namespace GymManagementSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    public class GymMemberEntityConfiguration : IEntityTypeConfiguration<GymMember>
    {
        public void Configure(EntityTypeBuilder<GymMember> builder)
        {
            
        }
    }
}
