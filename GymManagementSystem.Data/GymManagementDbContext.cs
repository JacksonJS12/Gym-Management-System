namespace GymManagementSystem.Data
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    using Models;

    public class GymManagementDbContext : IdentityDbContext
    {
        public GymManagementDbContext(DbContextOptions<GymManagementDbContext> options) 
            : base(options)
        {
            
        }
    }
}
