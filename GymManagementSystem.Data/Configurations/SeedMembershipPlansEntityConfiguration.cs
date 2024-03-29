namespace GymManagementSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    public class SeedMembershipPlansEntityConfiguration : IEntityTypeConfiguration<MembershipPlan>
    {
        public void Configure(EntityTypeBuilder<MembershipPlan> builder)
        {
            MembershipPlan[] plans = GenerateMembershipPlans();

            builder
                .HasData(plans);
        }

        private MembershipPlan[] GenerateMembershipPlans()
        {
            ICollection<MembershipPlan> plans = new HashSet<MembershipPlan>();

            MembershipPlan plan;
            plan = new MembershipPlan()
            {
                Id = 1,
                Name = "Pay-as-You-Go",
                Description = "One workout only.",
                Price = 10m
            };
            plans.Add(plan);

            plan = new MembershipPlan()
            {
                Id = 2,
                Name = "Standard Monthly Membership",
                Description = "Standard Monthly Membership. You can go to the gym anytime trough the month you paid for.",
                Price = 60m
            };
            plans.Add(plan);

            plan = new MembershipPlan()
            {
                Id = 3,
                Name = "Student Monthly Membership",
                Description = "Student Monthly Membership. You can go to the gym anytime trough the month you paid for. You're using a 30% discount off the price",
                Price = 42m
            };
            plans.Add(plan);

            return plans.ToArray();
        }
    }
}
