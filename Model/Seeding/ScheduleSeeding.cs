using Microsoft.EntityFrameworkCore;
using Model.Entities;

namespace Model.Seeding
{
    public class ScheduleSeeding
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            //Usuarios
            var admin = new User()
            {
                Id = 1,
                Email = "admin@gmail.com",
                Password = "123456789",
                Name = "Admin",
                Role = Enum.Role.Admin
            };
            modelBuilder.Entity<User>().HasData(admin);

            //Celenadario
            var calendar2023A = new Calendar()
            {
                Id = 1,
                Period = "2023A",
                PeriodInit = new DateTime(2023, 4, 3),
                PeriodEnd = new DateTime(2023, 9, 30)
            };
            modelBuilder.Entity<Calendar>().HasData(calendar2023A);

            //Edificios
            var electrica = new Building()
            {
                Id = 1,
                Code = "E16",
                Name = "Edificio de Eléctrica"
            };
            var quimica_electrica = new Building()
            {
                Id = 2,
                Code = "E17",
                Name = "Edificio de Química/Eléctrica",
            };
            modelBuilder.Entity<Building>().HasData(electrica, quimica_electrica);

            //Pisos del edificio de Electrica
            var s1 = new Floor() { 
                Id = 1,
                Code = "S1",
                BuildingId = 1,
            };
            var pbE = new Floor() { 
                Id = 2,
                Code = "PB",
                BuildingId = 1
            };
            var p1E = new Floor()
            {
                Id = 3,
                Code = "P1",
                BuildingId = 1
            };
            var p2E = new Floor()
            {
                Id = 4,
                Code = "P2",
                BuildingId = 1
            };

            var pbQ = new Floor()
            {
                Id = 5,
                Code = "PB",
                BuildingId = 2
            };
            var mzQ = new Floor()
            {
                Id = 6,
                Code = "MZ",
                BuildingId = 2
            };
            var p3Q = new Floor()
            {
                Id = 7,
                Code = "P3",
                BuildingId = 2
            };
            var p4Q = new Floor()
            {
                Id = 8,
                Code = "P4",
                BuildingId = 2
            };
            var p5Q = new Floor()
            {
                Id = 9,
                Code = "P5",
                BuildingId = 2
            };
            var p6Q = new Floor()
            {
                Id = 10,
                Code = "P6",
                BuildingId = 2
            };
            var p7Q = new Floor()
            {
                Id = 11,
                Code = "P7",
                BuildingId = 2
            };
            var p8Q = new Floor()
            {
                Id = 12,
                Code = "P8",
                BuildingId = 2
            };
            modelBuilder.Entity<Floor>().HasData(s1, pbE, p1E, p2E, pbQ, mzQ, p3Q, p4Q, p5Q, p6Q, p7Q, p8Q);

            
        }


    }
}
