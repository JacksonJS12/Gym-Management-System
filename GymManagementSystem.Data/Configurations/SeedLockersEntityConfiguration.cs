namespace GymManagementSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Common;
    using Models;
    using System;

    public class SeedLockersEntityConfiguration : IEntityTypeConfiguration<Locker>
    {
        public void Configure(EntityTypeBuilder<Locker> builder)
        {
            HashSet<Locker> lockers = GenerateLockers();

            builder.HasData(lockers);
        }

        private HashSet<Locker> GenerateLockers()
        {
            var lockers = new HashSet<Locker>()
            {
                new Locker()
                {
                    LockerNumber = 1,
                    LockerAvailability = Availability.Available
                },
                new Locker()
                {
                    LockerNumber = 2,
                    LockerAvailability = Availability.Available
                },
                new Locker()
                {
                    LockerNumber = 3,
                    LockerAvailability = Availability.Available
                },
                new Locker()
                {
                    LockerNumber = 4,
                    LockerAvailability = Availability.Available
                },
                new Locker()
                {
                    LockerNumber = 5,
                    LockerAvailability = Availability.Available
                },
                new Locker()
                {
                    LockerNumber = 6,
                    LockerAvailability = Availability.Available
                },
                new Locker()
                {
                    LockerNumber = 7,
                    LockerAvailability = Availability.Available
                },
                new Locker()
                {
                    LockerNumber = 8,
                    LockerAvailability = Availability.Available
                },
                new Locker()
                {
                    LockerNumber = 9,
                    LockerAvailability = Availability.Available
                },
                new Locker()
                {
                    LockerNumber = 10,
                    LockerAvailability = Availability.Available
                },
                new Locker()
                {
                    LockerNumber = 11,
                    LockerAvailability = Availability.Available
                },
                new Locker()
                {
                    LockerNumber = 12,
                    LockerAvailability = Availability.Available
                },
                new Locker()
                {
                    LockerNumber = 13,
                    LockerAvailability = Availability.Available
                },
                new Locker()
                {
                    LockerNumber = 14,
                    LockerAvailability = Availability.Available
                },
                new Locker()
                {
                    LockerNumber = 15,
                    LockerAvailability = Availability.Available
                },
                new Locker()
                {
                    LockerNumber = 16,
                    LockerAvailability = Availability.Available
                },
                new Locker()
                {
                    LockerNumber = 17,
                    LockerAvailability = Availability.Available
                },
                new Locker()
                {
                    LockerNumber = 18,
                    LockerAvailability = Availability.Available
                },
                new Locker()
                {
                    LockerNumber = 19,
                    LockerAvailability = Availability.Available
                },
                new Locker()
                {
                    LockerNumber = 20,
                    LockerAvailability = Availability.Available
                },
                new Locker()
                {
                    LockerNumber = 21,
                    LockerAvailability = Availability.Available
                },
                new Locker()
                {
                    LockerNumber = 22,
                    LockerAvailability = Availability.Available
                },
                new Locker()
                {
                    LockerNumber = 23,
                    LockerAvailability = Availability.Available
                },
                new Locker()
                {
                    LockerNumber = 24,
                    LockerAvailability = Availability.Available
                },
                new Locker()
                {
                    LockerNumber = 25,
                    LockerAvailability = Availability.Available
                },
                new Locker()
                {
                    LockerNumber = 26,
                    LockerAvailability = Availability.Available
                },
                new Locker()
                {
                    LockerNumber = 27,
                    LockerAvailability = Availability.Available
                },
                new Locker()
                {
                    LockerNumber = 28,
                    LockerAvailability = Availability.Available
                },
                new Locker()
                {
                    LockerNumber = 29,
                    LockerAvailability = Availability.Available
                },
                new Locker()
                {
                    LockerNumber = 30,
                    LockerAvailability = Availability.Available
                },
                new Locker()
                {
                    LockerNumber = 31,
                    LockerAvailability = Availability.Available
                },
                new Locker()
                {
                    LockerNumber = 32,
                    LockerAvailability = Availability.Available
                },
                new Locker()
                {
                    LockerNumber = 33,
                    LockerAvailability = Availability.Available
                },
                new Locker()
                {
                    LockerNumber = 34,
                    LockerAvailability = Availability.Available
                },
                new Locker()
                {
                    LockerNumber = 35,
                    LockerAvailability = Availability.Available
                },
                new Locker()
                {
                    LockerNumber = 36,
                    LockerAvailability = Availability.Available
                },
                new Locker()
                {
                    LockerNumber = 37,
                    LockerAvailability = Availability.Available
                },
                new Locker()
                {
                    LockerNumber = 38,
                    LockerAvailability = Availability.Available
                },
                new Locker()
                {
                    LockerNumber = 39,
                    LockerAvailability = Availability.Available
                },
                new Locker()
                {
                    LockerNumber = 40,
                    LockerAvailability = Availability.Available
                }
            };

            return lockers;
        }
    }
}
