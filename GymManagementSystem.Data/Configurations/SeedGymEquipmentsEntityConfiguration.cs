namespace GymManagementSystem.Data.Configurations
{
    using System.Collections.Generic;

    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Microsoft.EntityFrameworkCore;

    using Common;
    using Models;

    public class SeedGymEquipmentEntityConfiguration : IEntityTypeConfiguration<GymEquipment>
    {
        public void Configure(EntityTypeBuilder<GymEquipment> builder)
        {
            GymEquipment[] gymEquipmentList = GenerateGymEquipment();

            builder.HasData(gymEquipmentList);
        }

        private GymEquipment[] GenerateGymEquipment()
        {
            ICollection<GymEquipment> gymEquipment = new List<GymEquipment>();

            GymEquipment equipment;
            // Add Squat Rack
            equipment = new GymEquipment()
            {
                Id = 1,
                Name = "Squat Rack",
                Availability = Availability.Available,
                LastMaintenanceDate = DateTime.UtcNow,
                Description = "A weight training equipment used for squats."
            };
            gymEquipment.Add(equipment);

            // Add Weight Bench
            equipment = new GymEquipment()
            {
                Id = 2,
                Name = "Weight Bench",
                Availability = Availability.Available,
                LastMaintenanceDate = DateTime.UtcNow,
                Description = "A piece of weight training equipment used for various exercises including bench presses."
            };
            gymEquipment.Add(equipment);

            // Add Lat Pulldown Machine
            equipment = new GymEquipment()
            {
                Id = 3,
                Name = "Lat Pulldown Machine",
                Availability = Availability.Available,
                LastMaintenanceDate = DateTime.UtcNow,
                Description = "A machine used for the lat pulldown exercise targeting the upper back muscles."
            };
            gymEquipment.Add(equipment);

            // Add Chest Press Machine
            equipment = new GymEquipment()
            {
                Id = 4,
                Name = "Chest Press Machine",
                Availability = Availability.Available,
                LastMaintenanceDate = DateTime.UtcNow,
                Description = "A machine used for the chest press exercise targeting the chest muscles."
            };
            gymEquipment.Add(equipment);

            // Add Chest Fly Machine
            equipment = new GymEquipment()
            {
                Id = 5,
                Name = "Chest Fly Machine",
                Availability = Availability.Available,
                LastMaintenanceDate = DateTime.UtcNow,
                Description = "A machine used for the chest fly exercise targeting the chest muscles."
            };
            gymEquipment.Add(equipment);


            // Add Shoulder Press Machine
            equipment = new GymEquipment()
            {
                Id = 6,
                Name = "Shoulder Press Machine",
                Availability = Availability.Available,
                LastMaintenanceDate = DateTime.UtcNow,
                Description = "A machine used for the shoulder press exercise targeting the shoulder muscles."
            };
            gymEquipment.Add(equipment);


            // Add Cable Row Machine
            equipment = new GymEquipment()
            {
                Id = 7,
                Name = "Cable Row Machine",
                Availability = Availability.Available,
                LastMaintenanceDate = DateTime.UtcNow,
                Description = "A machine used for the cable row exercise targeting the back muscles."
            };
            gymEquipment.Add(equipment);


            // Add Biceps Curl Bench
            equipment = new GymEquipment()
            {
                Id = 8,
                Name = "Biceps Curl Bench",
                Availability = Availability.Available,
                LastMaintenanceDate = DateTime.UtcNow,
                Description = "A bench designed for performing biceps curls."
            };
            gymEquipment.Add(equipment);


            // Add Leg Press Machine
            equipment = new GymEquipment()
            {
                Id = 9,
                Name = "Leg Press Machine",
                Availability = Availability.Available,
                LastMaintenanceDate = DateTime.UtcNow,
                Description = "A machine used for the leg press exercise targeting the leg muscles."
            };
            gymEquipment.Add(equipment);


            // Add Cable Tower
            equipment = new GymEquipment()
            {
                Id = 10,
                Name = "Cable Tower",
                Availability = Availability.Available,
                LastMaintenanceDate = DateTime.UtcNow,
                Description = "A versatile machine with cable pulleys for various exercises."
            };
            gymEquipment.Add(equipment);


            // Add Smith Machine
            equipment = new GymEquipment()
            {
                Id = 11,
                Name = "Smith Machine",
                Availability = Availability.Available,
                LastMaintenanceDate = DateTime.UtcNow,
                Description = "A weight training machine with a barbell fixed within steel rails."
            };
            gymEquipment.Add(equipment);


            return gymEquipment.ToArray();
        }
    }
}