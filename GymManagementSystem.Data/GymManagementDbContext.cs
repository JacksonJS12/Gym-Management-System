using System.Reflection;
using GymManagementSystem.Data.Configurations;

namespace GymManagementSystem.Data
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    using Models;

    public class GymManagementDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        private readonly bool seedDb;

        public GymManagementDbContext(DbContextOptions<GymManagementDbContext> options, bool seedDb = true)
            : base(options)
        {
            this.seedDb = seedDb;
        }
        public GymManagementDbContext()
            : base()
        {

        }
        public DbSet<AttendanceRecord> AttendanceRecords { get; set; }
        public DbSet<GymEquipment> GymEquipment { get; set; }
        public DbSet<GymMember> GymMembers { get; set; }
        public DbSet<StaffMember> StaffMembers { get; set; }
        public DbSet<Locker> Lockers { get; set; }
        public DbSet<MembershipPlan> MembershipPlans { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
            builder.ApplyConfiguration(new AttendanceRecordEntityConfiguration());
            builder.ApplyConfiguration(new GymEquipmentEntityConfiguration());
            builder.ApplyConfiguration(new StaffMemberEntityConfiguration());

            if (this.seedDb)
            {
                builder.ApplyConfiguration(new SeedMembershipPlansEntityConfiguration());
                builder.ApplyConfiguration(new SeedGymEquipmentEntityConfiguration());
                builder.ApplyConfiguration(new SeedLockersEntityConfiguration());
            }

            base.OnModelCreating(builder);
        }
    }
}
