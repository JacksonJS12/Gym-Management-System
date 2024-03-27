namespace GymManagementSystem.Data.Configurations
{
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Microsoft.EntityFrameworkCore;

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

            // Add Squat Rack
            gymEquipment.Add(new GymEquipment
            {
                Id = 1,
                Name = "Squat Rack",
                Description = "A weight training equipment used for squats."
            });

            // Add Weight Bench
            gymEquipment.Add(new GymEquipment
            {
                Id = 2,
                Name = "Weight Bench",
                Description = "A piece of weight training equipment used for various exercises including bench presses."
            });

            // Add Lat Pulldown Machine
            gymEquipment.Add(new GymEquipment
            {
                Id = 3,
                Name = "Lat Pulldown Machine",
                Description = "A machine used for the lat pulldown exercise targeting the upper back muscles."
            });

            // Add Chest Press Machine
            gymEquipment.Add(new GymEquipment
            {
                Id = 4,
                Name = "Chest Press Machine",
                Description = "A machine used for the chest press exercise targeting the chest muscles."
            });

            // Add Chest Fly Machine
            gymEquipment.Add(new GymEquipment
            {
                Id = 5,
                Name = "Chest Fly Machine",
                Description = "A machine used for the chest fly exercise targeting the chest muscles."
            });

            // Add Shoulder Press Machine
            gymEquipment.Add(new GymEquipment
            {
                Id = 6,
                Name = "Shoulder Press Machine",
                Description = "A machine used for the shoulder press exercise targeting the shoulder muscles."
            });

            // Add Cable Row Machine
            gymEquipment.Add(new GymEquipment
            {
                Id = 7,
                Name = "Cable Row Machine",
                Description = "A machine used for the cable row exercise targeting the back muscles."
            });

            // Add Biceps Curl Bench
            gymEquipment.Add(new GymEquipment
            {
                Id = 8,
                Name = "Biceps Curl Bench",
                Description = "A bench designed for performing biceps curls."
            });

            // Add Leg Press Machine
            gymEquipment.Add(new GymEquipment
            {
                Id = 9,
                Name = "Leg Press Machine",
                Description = "A machine used for the leg press exercise targeting the leg muscles."
            });

            // Add Cable Tower
            gymEquipment.Add(new GymEquipment
            {
                Id = 10,
                Name = "Cable Tower",
                Description = "A versatile machine with cable pulleys for various exercises."
            });

            // Add Smith Machine
            gymEquipment.Add(new GymEquipment
            {
                Id = 11,
                Name = "Smith Machine",
                Description = "A weight training machine with a barbell fixed within steel rails."
            });

            return gymEquipment.ToArray();
        }
    }
}