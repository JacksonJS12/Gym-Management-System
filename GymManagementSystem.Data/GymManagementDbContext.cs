namespace GymManagementSystem.Data
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    using Models;
    using Configurations;

    public class GymManagementDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        private readonly bool seedDb;
        public GymManagementDbContext(DbContextOptions<GymManagementDbContext> options, bool seedDb = true)
            : base(options)
        {
            this.seedDb = seedDb;
        }

        public DbSet<AttendanceRecord> AttendanceRecords { get; set; } = null!;
        public DbSet<GymEquipment> GymEquipment { get; set; } = null!;
        public DbSet<GymMember> GymMembers { get; set; } = null!;
        public DbSet<StaffMember> StaffMembers { get; set; } = null!;
        public DbSet<Locker> Lockers { get; set; } = null!;
        public DbSet<MembershipPlan> MembershipPlans { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AttendanceRecordEntityConfiguration());
            builder.ApplyConfiguration(new GymEquipmentEntityConfiguration());
            builder.ApplyConfiguration(new StaffMemberEntityConfiguration());
            builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());

            if (!this.seedDb)
            {
                builder.ApplyConfiguration(new SeedGymEquipmentEntityConfiguration());
                builder.ApplyConfiguration(new SeedLockersEntityConfiguration());
                builder.ApplyConfiguration(new SeedMembershipPlansEntityConfiguration());
            }

            base.OnModelCreating(builder);
        }
    }
}
