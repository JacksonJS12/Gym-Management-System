namespace GymManagementSystem.Data
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    using Models;
    using System.Reflection;

    public class GymManagementDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public GymManagementDbContext(DbContextOptions<GymManagementDbContext> options)
            : base(options)
        {

        }

        public DbSet<AttendanceRecord> AttendanceLogs { get; set; } = null!;
        public DbSet<GymEquipment> GymEquipment { get; set; } = null!;
        public DbSet<GymMember> GymMembers { get; set; } = null!;
        public DbSet<StaffMember> StaffMembers { get; set; } = null!;
        public DbSet<Locker> Lockers { get; set; } = null!;
        public DbSet<MembershipPlan> MembershipPlans { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder builder)
        {
            Assembly configAssembly = Assembly.GetAssembly(typeof(GymManagementDbContext)) ??
                                      Assembly.GetExecutingAssembly();
            builder.ApplyConfigurationsFromAssembly(configAssembly);

            base.OnModelCreating(builder);
        }
    }
}
