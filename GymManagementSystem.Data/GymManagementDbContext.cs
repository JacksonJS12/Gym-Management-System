namespace GymManagementSystem.Data
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    using Models;
    using System.Reflection;

    public class GymManagementDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        public GymManagementDbContext(DbContextOptions<GymManagementDbContext> options) 
            : base(options)
        {
            
        }

        public DbSet<AttendanceLog> AttendanceLogs { get; set; }
        public DbSet<GymEquipment> GymEquipments { get; set; }
        public DbSet<GymMember> GymMembers{ get; set; }
        public DbSet<Locker> Lockers { get; set; }
        public DbSet<MembershipPlan> MembershipPlans { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            Assembly configAssembly = Assembly.GetAssembly(typeof(GymMenagmentSystemDbContext)) ??
                                      Assembly.GetExecutingAssembly();
            builder.ApplyConfigurationsFromAssembly(configAssembly);

            base.OnModelCreating(builder);
        }
    }
}
