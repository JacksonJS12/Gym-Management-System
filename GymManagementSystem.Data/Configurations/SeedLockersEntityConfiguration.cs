namespace GymManagementSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Common;
    using Models;

    public class SeedLockersEntityConfiguration : IEntityTypeConfiguration<Locker>
    {
        public void Configure(EntityTypeBuilder<Locker> builder)
        {
            Locker[] lockers = GenerateLockers();

            builder.HasData(lockers);
        }

        private Locker[] GenerateLockers()
        {
            ICollection<Locker> lockers = new HashSet<Locker>();
            for (int i = 1; i <= 40; i++)
            {
                Locker locker = new Locker()
                {
                    LockerNumber = i,
                    LockerAvailability = Availability.Available,

                };
                lockers.Add(locker);
            }

            return lockers.ToArray();
        }
    }
}
