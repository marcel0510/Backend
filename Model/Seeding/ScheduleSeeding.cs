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
            var s1 = new Floor()
            {
                Id = 1,
                Code = "S1",
                BuildingId = 1,
            };
            var pbE = new Floor()
            {
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


            //**********************************  AULAS  **************************************

            //EDIFICIO DE ELECTRICA (E16)
            //P1
            //E16/P1/E006A
            var e16_p1_e006a = new Classroom()
            {
                Id = 1,
                Code = "E006A",
                IsLab = true,
                Name = "LAB. CIRCUITOS ELECTRICOS A",
                Capacity = 12,
                Floor = "P1",
                BuildingId = 1,
            };
            //E16/P1/E006B
            var e16_p1_e006b = new Classroom()
            {
                Id = 2,
                Code = "E006B",
                IsLab = true,
                Name = "LAB. CIRCUITOS ELECTRICOS B",
                Capacity = 12,
                Floor = "P1",
                BuildingId = 1,
            };
            var e16_p1_e007a = new Classroom()
            {
                Id = 3,
                Code = "E007A",
                IsLab = true,
                Name = "LAB. CIRCUITOS ELECTRICOS C",
                Capacity = 12,
                Floor = "P1",
                BuildingId = 1,
            };
            var e16_p1_e007b = new Classroom()
            {
                Id = 4,
                Code = "E007B",
                IsLab = true,
                Name = "LAB. CIRCUITOS ELECTRICOS D",
                Capacity = 12,
                Floor = "P1",
                BuildingId = 1,
            };
            var e16_p1_e008 = new Classroom()
            {
                Id = 5,
                Code = "E008",
                IsLab = true,
                Name = "LAB. CIRCUITOS ELECTRICOS",
                Capacity = 16,
                Floor = "P1",
                BuildingId = 1,
            };
            var e16_p1_e013 = new Classroom()
            {
                Id = 6,
                Code = "E008",
                IsLab = true,
                Name = "LAB. ALTA FRECUENCIA",
                Capacity = 20,
                Floor = "P1",
                BuildingId = 1,
            };
            var e16_p1_e018 = new Classroom()
            {
                Id = 7,
                Code = "E018",
                IsLab = true,
                Name = "LAB. DISPOSITIVOS ELECTRONICOS",
                Capacity = 12,
                Floor = "P1",
                BuildingId = 1,
            };
            var e16_p1_e019 = new Classroom()
            {
                Id = 8,
                Code = "E019",
                IsLab = true,
                Name = "LAB. DISPOSITIVOS ELECTRONICOS",
                Capacity = 12,
                Floor = "P1",
                BuildingId = 1,
            };
            var e16_p1_e020 = new Classroom()
            {
                Id = 9,
                Code = "E020",
                IsLab = true,
                Name = "LAB.COMUNICACION ANALOGICA",
                Capacity = 4,
                Floor = "P1",
                BuildingId = 1,
            };
            var e16_p1_e021 = new Classroom()
            {
                Id = 10,
                Code = "E021",
                IsLab = false,
                Name = null,
                Capacity = 50,
                Floor = "P1",
                BuildingId = 1,
            };
            //P2
            var e16_p2_e001 = new Classroom()
            {
                Id = 11,
                Code = "E001",
                IsLab = false,
                Name = null,
                Capacity = 8,
                Floor = "P2",
                BuildingId = 1,
            };
            var e16_p2_e002 = new Classroom()
            {
                Id = 12,
                Code = "E001",
                IsLab = true,
                Name = "LAB. REDES 2",
                Capacity = 16,
                Floor = "P2",
                BuildingId = 1,
            };
            var e16_p2_e003 = new Classroom()
            {
                Id = 13,
                Code = "E002",
                IsLab = true,
                Name = "LAB. REDES 1",
                Capacity = 18,
                Floor = "P2",
                BuildingId = 1,
            };

            var e16_p2_e004 = new Classroom()
            {
                Id = 14,
                Code = "E004",
                IsLab = true,
                Name = "LAB. SISTEMAS DIGITALES A",
                Capacity = 10,
                Floor = "P2",
                BuildingId = 1,
            };
            var e16_p2_e005 = new Classroom()
            {
                Id = 15,
                Code = "E005",
                IsLab = true,
                Name = "LAB. SISTEMAS DIGITALES B",
                Capacity = 4,
                Floor = "P2",
                BuildingId = 1,
            };
            var e16_p2_e006 = new Classroom()
            {
                Id = 16,
                Code = "E006",
                IsLab = true,
                Name = "LAB. SISTEMAS DIGITALES",
                Capacity = 25,
                Floor = "P2",
                BuildingId = 1,
            };
            var e16_p2_e012 = new Classroom()
            {
                Id = 17,
                Code = "E012",
                IsLab = true,
                Name = "LAB. CONECTIVIDAD DE REDES",
                Capacity = 20,
                Floor = "P2",
                BuildingId = 1,
            };
            var e16_p2_e013 = new Classroom()
            {
                Id = 18,
                Code = "E013",
                IsLab = true,
                Name = "LAB. DE SISTEMAS DE CONTROL",
                Capacity = 30,
                Floor = "P2",
                BuildingId = 1,
            };
            var e16_p2_e014 = new Classroom()
            {
                Id = 19,
                Code = "E014",
                IsLab = true,
                Name = "LAB. DE SISTEMAS MICROPROCESADOS",
                Capacity = 25,
                Floor = "P2",
                BuildingId = 1,
            };
            var e16_p2_e015 = new Classroom()
            {
                Id = 20,
                Code = "E015",
                IsLab = true,
                Name = "LAB. INVEST. EN CONTROL CON MICROPROCESADORES",
                Capacity = 6,
                Floor = "P2",
                BuildingId = 1,
            };
            var e16_p2_e020 = new Classroom()
            {
                Id = 21,
                Code = "E020",
                IsLab = true,
                Name = "AULA MAGNA ELECTRICA",
                Capacity = 200,
                Floor = "P2",
                BuildingId = 1,
            };
            //PB
            var e16_pb_e002 = new Classroom()
            {
                Id = 22,
                Code = "E002",
                IsLab = true,
                Name = "LAB. CONTROL INDUSTRIAL",
                Capacity = 10,
                Floor = "PB",
                BuildingId = 1,
            };
            var e16_pb_e003 = new Classroom()
            {
                Id = 23,
                Code = "E003",
                IsLab = true,
                Name = "LAB. AUTOMATIZACION USANDO PLCS",
                Capacity = 6,
                Floor = "PB",
                BuildingId = 1,
            };
            var e16_pb_e007 = new Classroom()
            {
                Id = 24,
                Code = "E007",
                IsLab = true,
                Name = "LAB. ELECTRONICA DE POTENCIA",
                Capacity = 9,
                Floor = "PB",
                BuildingId = 1,
            };
            var e16_pb_e008 = new Classroom()
            {
                Id = 25,
                Code = "E008",
                IsLab = true,
                Name = "LAB. CONTROL MAQUINAS",
                Capacity = 12,
                Floor = "PB",
                BuildingId = 1,
            };
            var e16_pb_e026 = new Classroom()
            {
                Id = 26,
                Code = "E026",
                IsLab = true,
                Name = "LAB. DE PROTECCIONES ELECTRICAS (LABPE)",
                Capacity = 11,
                Floor = "PB",
                BuildingId = 1,
            };
            //S1
            var e16_s1_e001 = new Classroom()
            {
                Id = 27,
                Code = "E001",
                IsLab = false,
                Name = null,
                Capacity = 20,
                Floor = "S1",
                BuildingId = 1,
            };
            var e16_s1_e004 = new Classroom()
            {
                Id = 28,
                Code = "E004",
                IsLab = false,
                Name = null,
                Capacity = 50,
                Floor = "S1",
                BuildingId = 1,
            };
            var e16_s1_e005 = new Classroom()
            {
                Id = 29,
                Code = "E005",
                IsLab = false,
                Name = null,
                Capacity = 42,
                Floor = "S1",
                BuildingId = 1,
            };
            var e16_s1_e011 = new Classroom()
            {
                Id = 30,
                Code = "E011",
                IsLab = true,
                Name = "LAB. MAQUINAS ELECTRICAS",
                Capacity = 50,
                Floor = "S1",
                BuildingId = 1,
            };
            var e16_s1_e012a = new Classroom()
            {
                Id = 31,
                Code = "E012A",
                IsLab = true,
                Name = "LAB. DE SISTEMAS ELÉCTRICOS DE POTENCIA",
                Capacity = 11,
                Floor = "S1",
                BuildingId = 1,
            };
            var e16_s1_e012b = new Classroom()
            {
                Id = 32,
                Code = "E012B",
                IsLab = true,
                Name = "LAB. DE DISTRIBUCIÓN",
                Capacity = 9,
                Floor = "S1",
                BuildingId = 1,
            };
            var e16_s1_e017 = new Classroom()
            {
                Id = 33,
                Code = "E017",
                IsLab = true,
                Name = "LAB. ALTO VOLTAJE",
                Capacity = 25,
                Floor = "S1",
                BuildingId = 1,
            };

            //***************** Edificio de Quimica/Electrica *********************
            //MZ
            var e17_mz_e002 = new Classroom()
            {
                Id = 34,
                Code = "E002",
                IsLab = false,
                Name = null,
                Capacity = 22,
                Floor = "MZ",
                BuildingId = 2,
            };
            var e17_mz_e004 = new Classroom()
            {
                Id = 35,
                Code = "E004",
                IsLab = true,
                Name = "LAB. DE MANDOS NEUMATICOS",
                Capacity = 4,
                Floor = "MZ",
                BuildingId = 2,
            };
            //P1
            var e17_p1_e001 = new Classroom()
            {
                Id = 36,
                Code = "E001",
                IsLab = false,
                Name = null,
                Capacity = 22,
                Floor = "P1",
                BuildingId = 2,
            };
            var e17_p1_e002 = new Classroom()
            {
                Id = 37,
                Code = "E002",
                IsLab = false,
                Name = null,
                Capacity = 12,
                Floor = "P1",
                BuildingId = 2,
            };
            var e17_p1_e003 = new Classroom()
            {
                Id = 38,
                Code = "E003",
                IsLab = false,
                Name = null,
                Capacity = 12,
                Floor = "P1",
                BuildingId = 2,
            };
            var e17_p1_e004 = new Classroom()
            {
                Id = 39,
                Code = "E004",
                IsLab = false,
                Name = null,
                Capacity = 12,
                Floor = "P1",
                BuildingId = 2,
            };
            var e17_p1_e006 = new Classroom()
            {
                Id = 40,
                Code = "E006",
                IsLab = false,
                Name = null,
                Capacity = 12,
                Floor = "P1",
                BuildingId = 2,
            };
            var e17_p1_e007 = new Classroom()
            {
                Id = 41,
                Code = "E007",
                IsLab = false,
                Name = null,
                Capacity = 12,
                Floor = "P1",
                BuildingId = 2,
            };
            var e17_p1_e008 = new Classroom()
            {
                Id = 42,
                Code = "E008",
                IsLab = false,
                Name = null,
                Capacity = 12,
                Floor = "P1",
                BuildingId = 2,
            };
            var e17_p1_e009 = new Classroom()
            {
                Id = 43,
                Code = "E009",
                IsLab = false,
                Name = null,
                Capacity = 12,
                Floor = "P1",
                BuildingId = 2,
            };
            var e17_p1_e010 = new Classroom()
            {
                Id = 44,
                Code = "E010",
                IsLab = false,
                Name = null,
                Capacity = 12,
                Floor = "P1",
                BuildingId = 2,
            };
            var e17_p1_e011 = new Classroom()
            {
                Id = 45,
                Code = "E011",
                IsLab = false,
                Name = null,
                Capacity = 12,
                Floor = "P1",
                BuildingId = 2,
            };
            var e17_p1_e012 = new Classroom()
            {
                Id = 46,
                Code = "E012",
                IsLab = false,
                Name = null,
                Capacity = 12,
                Floor = "P1",
                BuildingId = 2,
            };
            var e17_p1_e013 = new Classroom()
            {
                Id = 47,
                Code = "E013",
                IsLab = false,
                Name = null,
                Capacity = 12,
                Floor = "P1",
                BuildingId = 2,
            };
            var e17_p1_e014 = new Classroom()
            {
                Id = 48,
                Code = "E014",
                IsLab = false,
                Name = null,
                Capacity = 12,
                Floor = "P1",
                BuildingId = 2,
            };
            var e17_p1_e019 = new Classroom()
            {
                Id = 49,
                Code = "E019",
                IsLab = true,
                Name = "AULA MAGNA QUIMICA",
                Capacity = 196,
                Floor = "P",
                BuildingId = 2,
            };
            //P2
            var e17_p2_e004 = new Classroom()
            {
                Id = 50,
                Code = "E004",
                IsLab = true,
                Name = "LAB. INVEST. PROCESOS",
                Capacity = 15,
                Floor = "P2",
                BuildingId = 2,
            };
            var e17_p2_e005 = new Classroom()
            {
                Id = 51,
                Code = "E005",
                IsLab = false,
                Name = null,
                Capacity = 29,
                Floor = "P2",
                BuildingId = 2,
            };
            var e17_p2_e009 = new Classroom()
            {
                Id = 52,
                Code = "E009",
                IsLab = false,
                Name = null,
                Capacity = 23,
                Floor = "P2",
                BuildingId = 2,
            };
            var e17_p2_e021 = new Classroom()
            {
                Id = 53,
                Code = "E021",
                IsLab = false,
                Name = null,
                Capacity = 56,
                Floor = "P2",
                BuildingId = 2,
            };
            var e17_p2_e022 = new Classroom()
            {
                Id = 54,
                Code = "E022",
                IsLab = false,
                Name = null,
                Capacity = 54,
                Floor = "P2",
                BuildingId = 2,
            };
            var e17_p2_e023 = new Classroom()
            {
                Id = 55,
                Code = "E023",
                IsLab = false,
                Name = null,
                Capacity = 50,
                Floor = "P2",
                BuildingId = 2,
            };
            var e17_p2_e030 = new Classroom()
            {
                Id = 56,
                Code = "E030",
                IsLab = true,
                Name = "LAB. DE COMPUTACION",
                Capacity = 40,
                Floor = "P2",
                BuildingId = 2,
            };
            //P3
            var e17_p3_e001 = new Classroom()
            {
                Id = 57,
                Code = "E001",
                IsLab = false,
                Name = null,
                Capacity = 41,
                Floor = "P3",
                BuildingId = 2,
            };
            var e17_p3_e002 = new Classroom()
            {
                Id = 58,
                Code = "E002",
                IsLab = false,
                Name = null,
                Capacity = 50,
                Floor = "P3",
                BuildingId = 2,
            };
            var e17_p3_e014 = new Classroom()
            {
                Id = 59,
                Code = "E014",
                IsLab = true,
                Name = "LAB. COMPUTACION QUIMICA",
                Capacity = 29,
                Floor = "P3",
                BuildingId = 2,
            };
            var e17_p3_e016 = new Classroom()
            {
                Id = 60,
                Code = "E016",
                IsLab = true,
                Name = "LAB. CENTRO COMPUTO AGROIND",
                Capacity = 29,
                Floor = "P3",
                BuildingId = 2,
            };
            var e17_p3_e021 = new Classroom()
            {
                Id = 61,
                Code = "E021",
                IsLab = false,
                Name = null,
                Capacity = 56,
                Floor = "P3",
                BuildingId = 2,
            };
            var e17_p3_e022 = new Classroom()
            {
                Id = 62,
                Code = "E022",
                IsLab = false,
                Name = null,
                Capacity = 54,
                Floor = "P3",
                BuildingId = 2,
            };
            var e17_p3_e023 = new Classroom()
            {
                Id = 63,
                Code = "E023",
                IsLab = false,
                Name = null,
                Capacity = 50,
                Floor = "P3",
                BuildingId = 2,
            };
            //P4
            var e17_p4_e004 = new Classroom()
            {
                Id = 64,
                Code = "E004",
                IsLab = true,
                Name = "LAB. TERMODINAMICA",
                Capacity = 20,
                Floor = "P4",
                BuildingId = 2,
            };
            var e17_p4_e005 = new Classroom()
            {
                Id = 65,
                Code = "E005",
                IsLab = true,
                Name = "LAB. TERMODINAMICA",
                Capacity = 20,
                Floor = "P4",
                BuildingId = 2,
            };
            var e17_p4_e006 = new Classroom()
            {
                Id = 66,
                Code = "E006",
                IsLab = true,
                Name = "LAB. TERMODINAMICA",
                Capacity = 20,
                Floor = "P4",
                BuildingId = 2,
            };
            var e17_p4_e007 = new Classroom()
            {
                Id = 67,
                Code = "E007",
                IsLab = true,
                Name = "LAB. TERMODINAMICA",
                Capacity = 20,
                Floor = "P4",
                BuildingId = 2,
            };
            var e17_p4_e008 = new Classroom()
            {
                Id = 68,
                Code = "E008",
                IsLab = true,
                Name = "LAB. TERMODINAMICA",
                Capacity = 20,
                Floor = "P4",
                BuildingId = 2,
            };
            var e17_p4_e009 = new Classroom()
            {
                Id = 69,
                Code = "E009",
                IsLab = false,
                Name = null,
                Capacity = 19,
                Floor = "P4",
                BuildingId = 2,
            };
            var e17_p4_e013 = new Classroom()
            {
                Id = 70,
                Code = "E013",
                IsLab = true,
                Name = "LAB. FISICO-QUIMICA",
                Capacity = 25,
                Floor = "P4",
                BuildingId = 2,
            };
            var e17_p4_e020 = new Classroom()
            {
                Id = 71,
                Code = "E020",
                IsLab = false,
                Name = null,
                Capacity = 48,
                Floor = "P4",
                BuildingId = 2,
            };
            var e17_p4_e021 = new Classroom()
            {
                Id = 72,
                Code = "E021",
                IsLab = false,
                Name = null,
                Capacity = 48,
                Floor = "P4",
                BuildingId = 2,
            };
            var e17_p4_e022 = new Classroom()
            {
                Id = 73,
                Code = "E022",
                IsLab = false,
                Name = null,
                Capacity = 48,
                Floor = "P4",
                BuildingId = 2,
            };
            var e17_p4_e023 = new Classroom()
            {
                Id = 74,
                Code = "E023",
                IsLab = false,
                Name = null,
                Capacity = 48,
                Floor = "P4",
                BuildingId = 2,
            };
            //P5
            var e17_p5_e001 = new Classroom()
            {
                Id = 75,
                Code = "E001",
                IsLab = false,
                Name = null,
                Capacity = 48,
                Floor = "P5",
                BuildingId = 2,
            };
            var e17_p5_e010 = new Classroom()
            {
                Id = 76,
                Code = "E010",
                IsLab = true,
                Name = "Lab. Petroleos",
                Capacity = 48,
                Floor = "P5",
                BuildingId = 2,
            };
            var e17_p5_e020 = new Classroom()
            {
                Id = 77,
                Code = "E020",
                IsLab = false,
                Name = null,
                Capacity = 48,
                Floor = "P5",
                BuildingId = 2,
            };
            var e17_p5_e027 = new Classroom()
            {
                Id = 78,
                Code = "E027",
                IsLab = false,
                Name = null,
                Capacity = 50,
                Floor = "P5",
                BuildingId = 2,
            };
            var e17_p5_e028 = new Classroom()
            {
                Id = 79,
                Code = "E028",
                IsLab = false,
                Name = null,
                Capacity = 48,
                Floor = "P5",
                BuildingId = 2,
            };
            var e17_p5_e029 = new Classroom()
            {
                Id = 80,
                Code = "E029",
                IsLab = false,
                Name = null,
                Capacity = 48,
                Floor = "P5",
                BuildingId = 2,
            };
            //P6
            var e17_p6_e002 = new Classroom()
            {
                Id = 81,
                Code = "E002",
                IsLab = true,
                Name = "LAB. DE SENSORES Y TRANSDUCTORES",
                Capacity = 8,
                Floor = "P6",
                BuildingId = 2,
            };
            var e17_p6_e003 = new Classroom()
            {
                Id = 82,
                Code = "E003",
                IsLab = true,
                Name = "LAB. INSTRUMENTACIÓN INDUSTRIAL",
                Capacity = 6,
                Floor = "P6",
                BuildingId = 2,
            };
            var e17_p6_e004 = new Classroom()
            {
                Id = 83,
                Code = "E004",
                IsLab = true,
                Name = "LAB. DE SCADA",
                Capacity = 6,
                Floor = "P6",
                BuildingId = 2,
            };
            var e17_p6_e022 = new Classroom()
            {
                Id = 84,
                Code = "E022",
                IsLab = true,
                Name = "LAB. SALA E",
                Capacity = 20,
                Floor = "P6",
                BuildingId = 2,
            };
            var e17_p6_e023 = new Classroom()
            {
                Id = 85,
                Code = "E023",
                IsLab = true,
                Name = "LAB. SALA D",
                Capacity = 20,
                Floor = "P6",
                BuildingId = 2,
            };
            var e17_p6_e026 = new Classroom()
            {
                Id = 86,
                Code = "E026",
                IsLab = true,
                Name = "LAB. SALA C",
                Capacity = 20,
                Floor = "P6",
                BuildingId = 2,
            };
            var e17_p6_e027 = new Classroom()
            {
                Id = 87,
                Code = "E027",
                IsLab = true,
                Name = "LAB. SALA B",
                Capacity = 20,
                Floor = "P6",
                BuildingId = 2,
            };
            var e17_p6_e028 = new Classroom()
            {
                Id = 88,
                Code = "E028",
                IsLab = true,
                Name = "LAB. SALA A",
                Capacity = 20,
                Floor = "P6",
                BuildingId = 2,
            };
            //P7
            var e17_p7_e001 = new Classroom()
            {
                Id = 89,
                Code = "E001",
                IsLab = true,
                Name = "LAB. COMUNICACIONES INALÁMBRICAS",
                Capacity = 8,
                Floor = "P7",
                BuildingId = 2,
            };
            var e17_p7_e002 = new Classroom()
            {
                Id = 90,
                Code = "E002",
                IsLab = true,
                Name = "LAB. SISTEMAS DE TRANSMISIÓN",
                Capacity = 6,
                Floor = "P7",
                BuildingId = 2,
            };
            var e17_p7_e003 = new Classroom()
            {
                Id = 91,
                Code = "E003",
                IsLab = true,
                Name = "LAB. SOFTWARE DEFINIDO POR RADIO",
                Capacity = 20,
                Floor = "P8",
                BuildingId = 2,
            };
            var e17_p7_e004 = new Classroom()
            {
                Id = 92,
                Code = "E004",
                IsLab = true,
                Name = "LAB. INTERCONECTIVIDAD",
                Capacity = 30,
                Floor = "P7",
                BuildingId = 2,
            };
            var e17_p7_e005 = new Classroom()
            {
                Id = 93,
                Code = "E005",
                IsLab = true,
                Name = "LAB. COMUNICACIONES UNIFICADAS",
                Capacity = 18,
                Floor = "P7",
                BuildingId = 2,
            };
            var e17_p7_e006 = new Classroom()
            {
                Id = 94,
                Code = "E006",
                IsLab = true,
                Name = "LAB. REDES INDUSTRIALES Y SCADA",
                Capacity = 8,
                Floor = "P7",
                BuildingId = 2,
            };
            var e17_p7_e008 = new Classroom()
            {
                Id = 95,
                Code = "E008",
                IsLab = true,
                Name = "LAB. DE INVEST. EN REDES Y SISTEMAS DISTRI",
                Capacity = 8,
                Floor = "P7",
                BuildingId = 2,
            };
            var e17_p7_e014 = new Classroom()
            {
                Id = 96,
                Code = "E014",
                IsLab = true,
                Name = "LAB. INVES. Y SIMULACION DE TELECOM",
                Capacity = 6,
                Floor = "P7",
                BuildingId = 2,
            };
            var e17_p7_e015 = new Classroom()
            {
                Id = 97,
                Code = "E015",
                IsLab = true,
                Name = "LAB. COMUNICACIONES OPTICAS",
                Capacity = 6,
                Floor = "P7",
                BuildingId = 2,
            };
            var e17_p7_e024 = new Classroom()
            {
                Id = 98,
                Code = "E024",
                IsLab = false,
                Name = null,
                Capacity = 30,
                Floor = "P7",
                BuildingId = 2,
            };
            var e17_p7_e025 = new Classroom()
            {
                Id = 99,
                Code = "E025",
                IsLab = false,
                Name = null,
                Capacity = 32,
                Floor = "P7",
                BuildingId = 2,
            };
            var e17_p7_e026 = new Classroom()
            {
                Id = 100,
                Code = "E026",
                IsLab = false,
                Name = null,
                Capacity = 38,
                Floor = "P7",
                BuildingId = 2,
            };
            //P8
            var e17_P8_e002 = new Classroom()
            {
                Id = 101,
                Code = "E002",
                IsLab = true,
                Name = "LABORATORIO DE ANTENAS",
                Capacity = 6,
                Floor = "P8",
                BuildingId = 2,
            };
            //PB
            var e17_pb_e001 = new Classroom()
            {
                Id = 102,
                Code = "E001",
                IsLab = false,
                Name = null,
                Capacity = 30,
                Floor = "PB",
                BuildingId = 2,
            };
            var e17_pb_e014 = new Classroom()
            {
                Id = 103,
                Code = "E014",
                IsLab = false,
                Name = null,
                Capacity = 18,
                Floor = "PB",
                BuildingId = 2,
            };
            var e17_pb_e020 = new Classroom()
            {
                Id = 104,
                Code = "E020",
                IsLab = false,
                Name = null,
                Capacity = 55,
                Floor = "PB",
                BuildingId = 2,
            };
            var e17_pb_e023 = new Classroom()
            {
                Id = 105,
                Code = "E023",
                IsLab = true,
                Name = "LAB. CONTROL DE PROCESOS",
                Capacity = 10,
                Floor = "PB",
                BuildingId = 2,
            };

            //Agregado
            modelBuilder
                .Entity<Classroom>()
                .HasData(
                //E16
                e16_p1_e006a, e16_p1_e006b, e16_p1_e007a, e16_p1_e007b, e16_p1_e008, e16_p1_e013, e16_p1_e018, e16_p1_e019, e16_p1_e020, e16_p1_e021,
                e16_p2_e001, e16_p2_e002, e16_p2_e003, e16_p2_e004, e16_p2_e005, e16_p2_e006, e16_p2_e012, e16_p2_e013, e16_p2_e014, e16_p2_e015, e16_p2_e020,
                e16_pb_e002, e16_pb_e003, e16_pb_e007, e16_pb_e008, e16_pb_e026,
                e16_s1_e001, e16_s1_e004, e16_s1_e005, e16_s1_e011, e16_s1_e012a, e16_s1_e012b, e16_s1_e017,
                //E17
                e17_mz_e002, e17_mz_e004,
                e17_p1_e001, e17_p1_e002, e17_p1_e003, e17_p1_e004, e17_p1_e006, e17_p1_e007, e17_p1_e008, e17_p1_e009, e17_p1_e010, e17_p1_e011, e17_p1_e012, e17_p1_e013, e17_p1_e014, e17_p1_e019,
                e17_p2_e004, e17_p2_e005, e17_p2_e009, e17_p2_e021, e17_p2_e022, e17_p2_e023, e17_p2_e030,
                e17_p3_e001, e17_p3_e002, e17_p3_e014, e17_p3_e016, e17_p3_e021, e17_p3_e022, e17_p3_e023,
                e17_p4_e004, e17_p4_e005, e17_p4_e006, e17_p4_e007, e17_p4_e008, e17_p4_e009, e17_p4_e013, e17_p4_e020, e17_p4_e021, e17_p4_e022, e17_p4_e023,
                e17_p5_e001, e17_p5_e010, e17_p5_e020, e17_p5_e027, e17_p5_e028, e17_p5_e029,
                e17_p6_e002, e17_p6_e003, e17_p6_e004, e17_p6_e022, e17_p6_e023, e17_p6_e026, e17_p6_e027, e17_p6_e028,
                e17_p7_e001, e17_p7_e002, e17_p7_e003, e17_p7_e004, e17_p7_e005, e17_p7_e006, e17_p7_e008, e17_p7_e014, e17_p7_e015, e17_p7_e024, e17_p7_e025, e17_p7_e026,
                e17_P8_e002,
                e17_pb_e001, e17_pb_e014, e17_pb_e020, e17_pb_e023
                );

            //**************************** MATERIAS ***************************
            // ----------- Repetidas ---------------
            // materias comunes
            var algebra = new Subject()
            {
                Id = 1,
                Code = "MATD113",
                IsLab = false,
                Name = "ÁLGEBRA LINEAL",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 1,
            };
            var calculo = new Subject()
            {
                Id = 2,
                Code = "MATD123",
                IsLab = false,
                Name = "CÁLCULO EN UNA VARIABLE",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 1,
            };
            var mecanica = new Subject()
            {
                Id = 3,
                Code = "FISD134",
                IsLab = false,
                Name = "MECÁNICA NEWTONIANA",
                Alias = null,
                NumHours = 192,
                NumCredits = 4,
                NumSemester = 1,
            };
            var laboratorioMecanica = new Subject()
            {
                Id = 4,
                Code = "FISD134L",
                IsLab = true,
                Name = "LABORATORIO MECÁNICA NEWTONIANA",
                Alias = null,
                NumHours = 192,
                NumCredits = 4,
                NumSemester = 1,
            };
            var quimica = new Subject()
            {
                Id = 5,
                Code = "QUID143",
                IsLab = false,
                Name = "QUÍMICA GENERAL",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 1,
            };
            var herramientasInformaticas = new Subject()
            {
                Id = 6,
                Code = "ICOD111",
                IsLab = false,
                Name = "HERRAMIENTAS INFORMÁTICAS",
                Alias = null,
                NumHours = 48,
                NumCredits = 1,
                NumSemester = 1,
            };
            var comunicacionOralEscrita = new Subject()
            {
                Id = 7,
                Code = "CSHD111",
                IsLab = false,
                Name = "COMUNICACIÓN ORAL Y ESCRITA",
                Alias = null,
                NumHours = 48,
                NumCredits = 1,
                NumSemester = 1,
            };
            var ecuacionesDiferenciales = new Subject()
            {
                Id = 8,
                Code = "MATD213",
                IsLab = false,
                Name = "ECUACIONES DIFERENCIALES ORDINARIAS",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 2,
            };
            var probabilidadEstadistica = new Subject()
            {
                Id = 9,
                Code = "MATD223",
                IsLab = false,
                Name = "PROBABILIDAD Y ESTADÍSTICA BÁSICAS",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 2,
            };
            var calculoVectorial = new Subject()
            {
                Id = 10,
                Code = "IEED232",
                IsLab = false,
                Name = "CÁLCULO VECTORIAL",
                Alias = null,
                NumHours = 96,
                NumCredits = 2,
                NumSemester = 2,
            };
            var fundamentosElectromagnetismo = new Subject()
            {
                Id = 11,
                Code = "IEED242",
                IsLab = false,
                Name = "FUNDAMENTOS DE ELECTROMAGNETISMO",
                Alias = null,
                NumHours = 96,
                NumCredits = 2,
                NumSemester = 2,
            };
            var programacion = new Subject()
            {
                Id = 12,
                Code = "IEED252",
                IsLab = false,
                Name = "PROGRAMACIÓN",
                Alias = null,
                NumHours = 96,
                NumCredits = 2,
                NumSemester = 2,
            };
            var analisisSocioeconomico = new Subject()
            {
                Id = 13,
                Code = "CSHD211",
                IsLab = false,
                Name = "ANÁLISIS SOCIOECONÓMICO Y POLÍTICO DEL ECUADOR",
                Alias = null,
                NumHours = 48,
                NumCredits = 1,
                NumSemester = 2,
            };
            var electrotecnia = new Subject()
            {
                Id = 14,
                Code = "IEED272",
                IsLab = false,
                Name = "ELECTROTECNIA",
                Alias = null,
                NumHours = 96,
                NumCredits = 2,
                NumSemester = 2,
            };
            var laboratorioElectrotecnia = new Subject()
            {
                Id = 15,
                Code = "IEED272L",
                IsLab = true,
                Name = "LABORATORIO DE ELECTROTECNIA",
                Alias = null,
                NumHours = 96,
                NumCredits = 2,
                NumSemester = 2,
            };
            var matematicaAvanzada = new Subject()
            {
                Id = 16,
                Code = "IEED312",
                IsLab = false,
                Name = "MATEMÁTICA AVANZADA",
                Alias = null,
                NumHours = 96,
                NumCredits = 2,
                NumSemester = 3,
            };
            var sistemasDigitales = new Subject()
            {
                Id = 17,
                Code = "IEED323",
                IsLab = false,
                Name = "SISTEMAS DIGITALES",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 2,
            };
            var laboratorioSistemasDigitales = new Subject()
            {
                Id = 18,
                Code = "IEED323L",
                IsLab = true,
                Name = "LABORATORIO DE SISTEMAS DIGITALES",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 2,
            };
            var dispositivosElectronicos = new Subject()
            {
                Id = 19,
                Code = "IEED333",
                IsLab = false,
                Name = "DISPOSITIVOS ELECTRÓNICOS",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 3,
            };
            var laboratorioDispositivosElectronicos = new Subject()
            {
                Id = 20,
                Code = "IEED333L",
                IsLab = true,
                Name = "LABORATORIO DE DISPOSITIVOS ELECTRONICOS",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 3,
            };
            var teoriaElectromagnetica = new Subject()
            {
                Id = 21,
                Code = "IEED342",
                IsLab = false,
                Name = "TEORÍA ELECTROMAGNÉTICA",
                Alias = null,
                NumHours = 96,
                NumCredits = 2,
                NumSemester = 3,
            };
            var fundamentosCircuitosElectricos = new Subject()
            {
                Id = 22,
                Code = "IEED353",
                IsLab = false,
                Name = "FUNDAMENTOS DE CIRCUITOS ELÉCTRICOS",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 3,
            };
            var laboratorioFundamentosCircuitosElectricos = new Subject()
            {
                Id = 23,
                Code = "IEED353L",
                IsLab = true,
                Name = "LABORATORIO DE FUNDAMENTOS DE CIRCUITOS ELÉCTRICOS",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 3,
            };
            var matematicaDiscreta = new Subject()
            {
                Id = 24,
                Code = "IEED371",
                IsLab = false,
                Name = "MATEMÁTICA DISCRETA",
                Alias = null,
                NumHours = 48,
                NumCredits = 1,
                NumSemester = 3,
            };
            var instalacionesElectricasComunicaciones = new Subject()
            {
                Id = 25,
                Code = "IEED413",
                IsLab = false,
                Name = "INSTALACIONES ELÉCTRICAS Y COMUNICACIONES",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 4,
            };
            var analisisSenalesSistemas = new Subject()
            {
                Id = 26,
                Code = "IEAD423",
                IsLab = false,
                Name = "ANÁLISIS DE SEÑALES Y SISTEMAS",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 4,
            };
            var circuitosElectronicos = new Subject()
            {
                Id = 27,
                Code = "IEED433",
                IsLab = false,
                Name = "CIRCUITOS ELECTRÓNICOS",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 4,
            };
            var laboratorioCircuitosElectronicos = new Subject()
            {
                Id = 28,
                Code = "IEED433L",
                IsLab = true,
                Name = "LABORATORIO DE CIRCUITOS ELECTRÓNICOS",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 4,
            };
            var conversionElectromecanicaEnergia = new Subject()
            {
                Id = 29,
                Code = "IELD443",
                IsLab = false,
                Name = "CONVERSIÓN ELECTROMECÁNICA DE ENERGÍA",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 4,
            };
            var laboratorioConversionElectromecanicaEnergia = new Subject()
            {
                Id = 30,
                Code = "IELD443L",
                IsLab = true,
                Name = "LABORATORIO DE CONVERSIÓN ELECTROMECÁNICA DE ENERGÍA",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 4,
            };
            var analisisCircuitosElectricos = new Subject()
            {
                Id = 31,
                Code = "IEED452",
                IsLab = false,
                Name = "ANÁLISIS DE CIRCUITOS ELÉCTRICOS",
                Alias = null,
                NumHours = 96,
                NumCredits = 2,
                NumSemester = 4,
            };
            var laboratorioAnalisisCircuitosElectricos = new Subject()
            {
                Id = 32,
                Code = "IEED452L",
                IsLab = true,
                Name = "LABORATORIO DE ANÁLISIS DE CIRCUITOS ELÉCTRICOS",
                Alias = null,
                NumHours = 96,
                NumCredits = 2,
                NumSemester = 4,
            };
            var electronicaPotencia = new Subject()
            {
                Id = 33,
                Code = "IEAD533",
                IsLab = false,
                Name = "ELECTRÓNICA DE POTENCIA",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 5,
            };
            var laboratorioElectronicaPotencia = new Subject()
            {
                Id = 34,
                Code = "IEAD533L",
                IsLab = true,
                Name = "LABORATORIO DE ELECTRÓNICA DE POTENCIA",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 5,
            };
            var maquinasElectricas = new Subject()
            {
                Id = 35,
                Code = "IELD543",
                IsLab = false,
                Name = "MÁQUINAS ELÉCTRICAS",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 5,
            };
            var laboratorioMaquinasElectricas = new Subject()
            {
                Id = 36,
                Code = "IELD543L",
                IsLab = true,
                Name = "LABORATORIO DE MÁQUINAS ELÉCTRICAS",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 5,
            };
            var sistemasControlAutomatico = new Subject()
            {
                Id = 37,
                Code = "IEAD553",
                IsLab = false,
                Name = "SISTEMAS DE CONTROL AUTOMÁTICO",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 5,
            };
            var laboratorioSistemasControlAutomatico = new Subject()
            {
                Id = 38,
                Code = "IEAD553L",
                IsLab = true,
                Name = "LABORATORIO DE SISTEMAS DE CONTROL AUTOMÁTICO",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 5,
            };
            var controlIndustrial = new Subject()
            {
                Id = 39,
                Code = "IEAD642",
                IsLab = false,
                Name = "CONTROL INDUSTRIAL",
                Alias = null,
                NumHours = 96,
                NumCredits = 2,
                NumSemester = 6,
            };
            var laboratorioControlIndustrial = new Subject()
            {
                Id = 40,
                Code = "IEAD642L",
                IsLab = true,
                Name = "LABORATORIO DE CONTROL INDUSTRIAL",
                Alias = null,
                NumHours = 96,
                NumCredits = 2,
                NumSemester = 6,
            };
            var seguridadIndustrialProteccionAmbiental = new Subject()
            {
                Id = 41,
                Code = "IELD761",
                IsLab = false,
                Name = "SEGURIDAD INDUSTRIAL Y PROTECCIÓN AMBIENTAL",
                Alias = null,
                NumHours = 48,
                NumCredits = 1,
                NumSemester = 9,
            };
            var analisisSenalesDiscretasComunicaciones = new Subject()
            {
                Id = 42,
                Code = "TELD423",
                IsLab = false,
                Name = "ANÁLISIS DE SEÑALES DISCRETAS PARA COMUNICACIONES",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 4,
            };
            var teoriaInformacionCodificacion = new Subject()
            {
                Id = 43,
                Code = "TELD522",
                IsLab = false,
                Name = "TEORÍA DE LA INFORMACIÓN Y CODIFICACIÓN",
                Alias = null,
                NumHours = 96,
                NumCredits = 2,
                NumSemester = 5,
            };
            var sistemasEmbebidos = new Subject()
            {
                Id = 44,
                Code = "ITID553",
                IsLab = false,
                Name = "SISTEMAS EMBEBIDOS",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 5,
            };
            var laboratorioSistemasEmbebidos = new Subject()
            {
                Id = 45,
                Code = "ITID553L",
                IsLab = true,
                Name = "LABORATORIO DE SISTEMAS EMBEBIDOS",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 5,
            };
            var sistemasCableadoEstructurado = new Subject()
            {
                Id = 46,
                Code = "ITID512",
                IsLab = false,
                Name = "SISTEMAS DE CABLEADO ESTRUCTURADO",
                Alias = null,
                NumHours = 96,
                NumCredits = 2,
                NumSemester = 5,
            };
            var gestionOrganizacional = new Subject()
            {
                Id = 47,
                Code = "ADMD511",
                IsLab = false,
                Name = "GESTIÓN ORGANIZACIONAL",
                Alias = null,
                NumHours = 48,
                NumCredits = 1,
                NumSemester = 5,
            };
            var gestionProcesosCalidad = new Subject()
            {
                Id = 48,
                Code = "ADMD611",
                IsLab = false,
                Name = "GESTIÓN DE PROCESOS Y CALIDAD",
                Alias = null,
                NumHours = 48,
                NumCredits = 1,
                NumSemester = 6,
            };
            var ingenieriaFinanciera = new Subject()
            {
                Id = 49,
                Code = "ADMD711",
                IsLab = false,
                Name = "INGENIERÍA FINANCIERA",
                Alias = null,
                NumHours = 48,
                NumCredits = 1,
                NumSemester = 7,
            };
            var disenoTrabajoIntegracionCurricular = new Subject()
            {
                Id = 50,
                Code = "TITD101",
                IsLab = false,
                Name = "DISEÑO DE TRABAJO DE INTEGRACIÓN CURRICULAR/ PREPARACIÓN EXAMEN DE CARÁCTER COMPLEXIVO",
                Alias = null,
                NumHours = 48,
                NumCredits = 1,
                NumSemester = 8,
            };
            var trabajoIntegracionCurricular = new Subject()
            {
                Id = 51,
                Code = "TITD201",
                IsLab = false,
                Name = "TRABAJO DE INTEGRACIÓN CURRICULAR/EXAMEN DE CARÁCTER COMPLEXIVO",
                Alias = null,
                NumHours = 240,
                NumCredits = 5,
                NumSemester = 9,
            };
            // ----------- Electrica ---------------
            var modelacionSistemasElectricosPotencia = new Subject()
            {
                Id = 52,
                Code = "IELD512",
                IsLab = false,
                Name = "MODELACIÓN DE SISTEMAS ELÉCTRICOS DE POTENCIA",
                Alias = null,
                NumHours = 96,
                NumCredits = 2,
                NumSemester = 5,
            };
            var laboratorioModelacionSistemasElectricosPotencia = new Subject()
            {
                Id = 53,
                Code = "IELD512L",
                IsLab = true,
                Name = "LAB. DE MODELACIÓN DE SISTEMAS ELÉCTRICOS DE POTENCIA",
                Alias = null,
                NumHours = 96,
                NumCredits = 2,
                NumSemester = 5,
            };
            var altoVoltaje = new Subject()
            {
                Id = 54,
                Code = "IELD523",
                IsLab = false,
                Name = "ALTO VOLTAJE",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 5,
            };
            var laboratorioAltoVoltaje = new Subject()
            {
                Id = 55,
                Code = "IELD523L",
                IsLab = true,
                Name = "LAB. DE ALTO VOLTAJE",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 5,
            };
            var estudiosEstadoEstacionarioSistemasElectricosPotencia = new Subject()
            {
                Id = 56,
                Code = "IELD613",
                IsLab = false,
                Name = "ESTUDIOS DE ESTADO ESTACIONARIO DE SISTEMAS ELÉCTRICOS DE POTENCIA",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 6,
            };
            var laboratorioEstudiosEstadoEstacionarioSistemasElectricosPotencia = new Subject()
            {
                Id = 57,
                Code = "IELD613L",
                IsLab = true,
                Name = "LAB. DE ESTUDIOS DE ESTADO ESTACIONARIO DE SISTEMAS ELÉCTRICOS DE POTENCIA",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 6,
            };
            var disenoAltoVoltaje = new Subject()
            {
                Id = 58,
                Code = "IELD622",
                IsLab = false,
                Name = "DISEÑO EN ALTO VOLTAJE",
                Alias = null,
                NumHours = 96,
                NumCredits = 2,
                NumSemester = 6,
            };
            var sistemasElectricosDistribucion = new Subject()
            {
                Id = 59,
                Code = "IELD633",
                IsLab = false,
                Name = "SISTEMAS ELÉCTRICOS DE DISTRIBUCIÓN",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 6,
            };
            var laboratorioSistemasElectricosDistribucion = new Subject()
            {
                Id = 60,
                Code = "IELD633L",
                IsLab = true,
                Name = "LAB. DE SISTEMAS ELÉCTRICOS DE DISTRIBUCIÓN",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 6,
            };
            var dinamicaMaquinasElectricas = new Subject()
            {
                Id = 61,
                Code = "IELD643",
                IsLab = false,
                Name = "DINÁMICA DE MÁQUINAS ELÉCTRICAS",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 6,
            };
            var laboratorioDinamicaMaquinasElectricas = new Subject()
            {
                Id = 62,
                Code = "IELD643L",
                IsLab = true,
                Name = "LAB. DE DINÁMICA DE MÁQUINAS ELÉCTRICAS",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 6,
            };
            var instalacionesElectricasMedioVoltaje = new Subject()
            {
                Id = 63,
                Code = "IELD652",
                IsLab = false,
                Name = "INSTALACIONES ELÉCTRICAS DE MEDIO VOLTAJE",
                Alias = null,
                NumHours = 96,
                NumCredits = 2,
                NumSemester = 6,
            };
            var estabilidadSistemasElectricosPotencia = new Subject()
            {
                Id = 64,
                Code = "IELD713",
                IsLab = false,
                Name = "ESTABILIDAD DE SISTEMAS ELÉCTRICOS DE POTENCIA",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 7,
            };
            var laboratorioEstabilidadSistemasElectricosPotencia = new Subject()
            {
                Id = 65,
                Code = "IELD713L",
                IsLab = true,
                Name = "LAB. DE ESTABILIDAD DE SISTEMAS ELÉCTRICOS DE POTENCIA",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 7,
            };
            var disenoElectromecanicoLineasTransmision = new Subject()
            {
                Id = 66,
                Code = "IELD722",
                IsLab = false,
                Name = "DISEÑO ELECTROMECÁNICO DE LÍNEAS DE TRANSMISIÓN",
                Alias = null,
                NumHours = 96,
                NumCredits = 2,
                NumSemester = 7,
            };
            var construccionRedesElectricas = new Subject()
            {
                Id = 67,
                Code = "IELD732",
                IsLab = false,
                Name = "CONSTRUCCIÓN DE REDES ELÉCTRICAS",
                Alias = null,
                NumHours = 96,
                NumCredits = 2,
                NumSemester = 7,
            };
            var centralesGeneracionElectrica = new Subject()
            {
                Id = 68,
                Code = "IELD742",
                IsLab = false,
                Name = "CENTRALES DE GENERACIÓN ELÉCTRICA",
                Alias = null,
                NumHours = 96,
                NumCredits = 2,
                NumSemester = 7,
            };
            var introduccionProteccionesElectricas = new Subject()
            {
                Id = 69,
                Code = "IELD753",
                IsLab = false,
                Name = "INTRODUCCIÓN A PROTECCIONES ELÉCTRICAS",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 7,
            };
            var laboratorioIntroduccionProteccionesElectricas = new Subject()
            {
                Id = 70,
                Code = "IELD753L",
                IsLab = true,
                Name = "LAB. DE INTRODUCCIÓN A PROTECCIONES ELÉCTRICAS",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 7,
            };
            var optimizacionSistemasElectricosPotencia = new Subject()
            {
                Id = 71,
                Code = "IELD772",
                IsLab = false,
                Name = "OPTIMIZACIÓN DE SISTEMAS ELÉCTRICOS DE POTENCIA",
                Alias = null,
                NumHours = 96,
                NumCredits = 2,
                NumSemester = 7,
            };
            var operacionControlSistemasElectricosPotencia = new Subject()
            {
                Id = 72,
                Code = "IELD813",
                IsLab = false,
                Name = "OPERACIÓN Y CONTROL DE SISTEMAS ELÉCTRICOS DE POTENCIA",
                Alias = null,
                NumHours = 86,
                NumCredits = 2,
                NumSemester = 7,
            };
            var analisisSistemasElectricosPotencia = new Subject()
            {
                Id = 73,
                Code = "IELD801",
                IsLab = false,
                Name = "ANÁLISIS DE SISTEMAS ELÉCTRICOS DE POTENCIA",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 8,
            };
            var accionamientoMaquinasElectricas = new Subject()
            {
                Id = 74,
                Code = "IELD802",
                IsLab = false,
                Name = "ACCIONAMIENTO DE MÁQUINAS ELÉCTRICAS",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 8,
            };
            var redesElectricasInteligentesGeneracionDistribuida = new Subject()
            {
                Id = 75,
                Code = "ELD803",
                IsLab = false,
                Name = "REDES ELÉCTRICAS INTELIGENTES Y GENERACIÓN DISTRIBUIDA",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 8,
            };
            var calidadEnergiaElectrica = new Subject()
            {
                Id = 76,
                Code = "IELD832",
                IsLab = false,
                Name = "CALIDAD DE ENERGÍA ELÉCTRICA",
                Alias = null,
                NumHours = 96,
                NumCredits = 2,
                NumSemester = 8,
            };
            var confiabilidadSistemasElectricosPotencia = new Subject()
            {
                Id = 77,
                Code = "IELD842",
                IsLab = false,
                Name = "CONFIABILIDAD DE SISTEMAS ELÉCTRICOS DE POTENCIA",
                Alias = null,
                NumHours = 96,
                NumCredits = 2,
                NumSemester = 8,
            };
            var planificacionSistemasElectricosDistribucion = new Subject()
            {
                Id = 78,
                Code = "IELD852",
                IsLab = false,
                Name = "PLANIFICACIÓN DE SISTEMAS ELÉCTRICOS DE DISTRIBUCIÓN",
                Alias = null,
                NumHours = 96,
                NumCredits = 2,
                NumSemester = 8,
            };
            var analisisEstabilidadPequenaSeñalSistemas = new Subject()
            {
                Id = 79,
                Code = "IELD901",
                IsLab = false,
                Name = "ANÁLISIS DE ESTABILIDAD DE PEQUEÑA SEÑAL DE SISTEMAS",
                Alias = null,
                NumHours = 96,
                NumCredits = 2,
                NumSemester = 9,
            };
            var integracionEnergiasRenovablesSistemas = new Subject()
            {
                Id = 80,
                Code = "ELD902",
                IsLab = false,
                Name = "INTEGRACIÓN DE ENERGÍAS RENOVABLES A SISTEMAS ELÉCTRICOS DE POTENCIA",
                Alias = null,
                NumHours = 96,
                NumCredits = 2,
                NumSemester = 9,
            };
            var sistemaGestionRedesDistribucion = new Subject()
            {
                Id = 81,
                Code = "ELD903",
                IsLab = false,
                Name = "SISTEMA DE GESTIÓN DE REDES ELÉCTRICAS DE DISTRIBUCIÓN",
                Alias = null,
                NumHours = 96,
                NumCredits = 2,
                NumSemester = 9,
            };
            // -----------  Control ----------------
            //5to Semestre
            var sensoresytransductores = new Subject()
            {
                Id = 82,
                Code = "IEAD513",
                IsLab = false,
                Name = "SENSORES Y TRANSDUCTORES",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 5,
            };
            var labSensoresytransductores = new Subject()
            {
                Id = 83,
                Code = "IEAD513L",
                IsLab = true,
                Name = "LAB. DE SENSORES Y TRANSDUCTORES",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 5,
            };
            var sistemasMicroprocesados = new Subject()
            {
                Id = 84,
                Code = "IEAD522",
                IsLab = false,
                Name = "SISTEMAS MICROPROCESADOS",
                Alias = null,
                NumCredits = 2,
                NumHours = 96,
                NumSemester = 5,
            };
            var labSistemasMicroprocesados = new Subject()
            {
                Id = 85,
                Code = "IEAD522L",
                IsLab = true,
                Name = "LAB. DE SISTEMAS MICROPROCESADOS",
                Alias = null,
                NumCredits = 2,
                NumHours = 96,
                NumSemester = 5,
            };
            //6to semestre
            var instrumentacionIndustrial = new Subject()
            {
                Id = 86,
                Code = "IEAD613",
                IsLab = false,
                Name = "INSTRUMENTACIÓN INDUSTRIAL",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 6,
            };
            var labInstrumentacionIndustrial = new Subject()
            {
                Id = 87,
                Code = "IEAD613L",
                IsLab = true,
                Name = "LAB. DE INSTRUMENTACIÓN INDUSTRIAL",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 6,
            };
            var controlEmbebido = new Subject()
            {
                Id = 88,
                Code = "IEAD623",
                IsLab = false,
                Name = "CONTROL EMBEBIDO",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 6,
            };
            var labControlEmbebido = new Subject()
            {
                Id = 89,
                Code = "IEAD623L",
                IsLab = true,
                Name = "LAB. DE CONTROL EMBEBIDO",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 6,
            };
            var conversoresEstaticos = new Subject()
            {
                Id = 90,
                Code = "IEAD633",
                IsLab = false,
                Name = "CONVERSORES ESTÁTICOS",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 6,
            };
            var labConversoresEstaticos = new Subject()
            {
                Id = 91,
                Code = "IEAD633L",
                IsLab = true,
                Name = "LAB. DE CONVERSORES ESTÁTICOS",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 6,
            };
            var sistemasControlDiscreto = new Subject()
            {
                Id = 92,
                Code = "IEAD653",
                IsLab = false,
                Name = "SISTEMAS DE CONTROL DISCRETO",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 6,
            };
            var labSistemasControlDiscreto = new Subject()
            {
                Id = 93,
                Code = "IEAD653L",
                IsLab = true,
                Name = "LAB. DE SISTEMAS DE CONTROL DISCRETO",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 6,
            };
            //7mo semestre
            var redesIndustriales = new Subject()
            {
                Id = 94,
                Code = "IEAD713",
                IsLab = false,
                Name = "REDES INDUSTRIALES",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 7,
            };
            var labRedesIndustriales = new Subject()
            {
                Id = 95,
                Code = "IEAD713L",
                IsLab = true,
                Name = "LAB. DE REDES INDUSTRIALES",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 7,
            };
            var instalacionesElectricasIndustriales = new Subject()
            {
                Id = 96,
                Code = "IEAD722",
                IsLab = false,
                Name = "INSTALACIONES ELÉCTRICAS INDUSTRIALES",
                Alias = null,
                NumCredits = 2,
                NumHours = 96,
                NumSemester = 7,
            };
            var accionamientosElectronicos = new Subject()
            {
                Id = 97,
                Code = "IEAD733",
                IsLab = false,
                Name = "ACCIONAMIENTOS ELECTRÓNICOS",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 7,
            };
            var labAccionamientosElectronicos = new Subject()
            {
                Id = 98,
                Code = "IEAD733L",
                IsLab = true,
                Name = "LAB. DE ACCIONAMIENTOS ELECTRÓNICOS",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 7,
            };
            var automatizacionPLCs = new Subject()
            {
                Id = 99,
                Code = "IEAD743",
                IsLab = false,
                Name = "AUTOMATIZACIÓN USANDO PLCs",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 7,
            };
            var labAutomatizacionPLCs = new Subject()
            {
                Id = 100,
                Code = "IEAD743L",
                IsLab = true,
                Name = "LAB. DE AUTOMATIZACIÓN USANDO PLCs",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 7,
            };
            var controlProcesosIndustriales = new Subject()
            {
                Id = 101,
                Code = "IEAD753",
                IsLab = false,
                Name = "CONTROL DE PROCESOS INDUSTRIALES",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 7,
            };
            var labControlProcesosIndustriales = new Subject()
            {
                Id = 102,
                Code = "IEAD753L",
                IsLab = true,
                Name = "LAB. DE CONTROL DE PROCESOS INDUSTRIALES",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 7,
            };
            //8vo semestre
            var sintesisPlantasIndustriales = new Subject()
            {
                Id = 103,
                Code = "IEAD801",
                IsLab = false,
                Name = "SÍNTESIS DE PLANTAS INDUSTRIALES",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 8,
            };
            var instrumentacionBiomedica = new Subject()
            {
                Id = 104,
                Code = "IEAD802",
                IsLab = false,
                Name = "INSTRUMENTACIÓN BIOMÉDICA",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 8,
            };
            var fundamentosSistemasElectricosPotencia = new Subject()
            {
                Id = 105,
                Code = "IEAD803",
                IsLab = false,
                Name = "FUNDAMENTOS DE SISTEMAS ELÉCTRICOS DE POTENCIA",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 8,
            };
            var sistemasScada = new Subject()
            {
                Id = 106,
                Code = "IEAD823",
                IsLab = false,
                Name = "SISTEMAS SCADA",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 8,
            };
            var labSistemasScada = new Subject()
            {
                Id = 107,
                Code = "IEAD823L",
                IsLab = true,
                Name = "LAB. DE SISTEMAS SCADA",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 8,
            };
            var mandosNeumaticos = new Subject()
            {
                Id = 108,
                Code = "IEAD833",
                IsLab = false,
                Name = "MANDOS NEUMÁTICOS",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 8,
            };
            var labMandosNeumaticos = new Subject()
            {
                Id = 109,
                Code = "IEAD833L",
                IsLab = true,
                Name = "LAB. DE MANDOS NEUMÁTICOS",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 8,
            };
            var robotica = new Subject()
            {
                Id = 110,
                Code = "IEAD842",
                IsLab = false,
                Name = "ROBÓTICA",
                Alias = null,
                NumCredits = 2,
                NumHours = 96,
                NumSemester = 8,
            };
            var labRobotica = new Subject()
            {
                Id = 111,
                Code = "IEAD842L",
                IsLab = true,
                Name = "LAB. DE ROBÓTICA",
                Alias = null,
                NumCredits = 2,
                NumHours = 96,
                NumSemester = 8,
            };
            var introduccionControlMultivariable = new Subject()
            {
                Id = 112,
                Code = "IEAD853",
                IsLab = false,
                Name = "INTRODUCCIÓN A CONTROL MULTIVARIABLE",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 8,
            };
            //9no semestre
            var introduccionIndustria40 = new Subject()
            {
                Id = 113,
                Code = "IEAD901",
                IsLab = false,
                Name = "INTRODUCCIÓN A INDUSTRIA 4.0",
                Alias = null,
                NumCredits = 2,
                NumHours = 96,
                NumSemester = 9,
            };
            var visionArtificial = new Subject()
            {
                Id = 114,
                Code = "IEAD902",
                IsLab = false,
                Name = "VISIÓN ARTIFICIAL",
                Alias = null,
                NumCredits = 2,
                NumHours = 96,
                NumSemester = 9,
            };
            var energiasRenovablesRedesInteligentes = new Subject()
            {
                Id = 115,
                Code = "IEAD903",
                IsLab = false,
                Name = "ENERGÍAS RENOVABLES Y REDES INTELIGENTES",
                Alias = null,
                NumCredits = 2,
                NumHours = 96,
                NumSemester = 9,
            };

            // -----------  Telecomunicaciones ---------------
            //4to semestre
            var sistemaOperativoLinux = new Subject()
            {
                Id = 116,
                Code = "TELD452",
                IsLab = false,
                Name = "SISTEMA OPERATIVO LINUX",
                Alias = null,
                NumCredits = 2,
                NumHours = 96,
                NumSemester = 4,
            };
            //5to semestre
            var fundamentosComunicaciones = new Subject()
            {
                Id = 117,
                Code = "TELD513",
                IsLab = false,
                Name = "FUNDAMENTOS DE COMUNICACIONES",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 5,
            };
            var labFundamentosComunicaciones = new Subject()
            {
                Id = 118,
                Code = "TELD513L",
                IsLab = true,
                Name = "LAB. DE FUNDAMENTOS DE COMUNICACIONES",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 5,
            };
            var procesamientoDigitalSenales = new Subject()
            {
                Id = 119,
                Code = "TELD532",
                IsLab = false,
                Name = "PROCESAMIENTO DIGITAL DE SEÑALES",
                Alias = null,
                NumCredits = 2,
                NumHours = 96,
                NumSemester = 5,
            };
            var sistemasTransmision = new Subject()
            {
                Id = 120,
                Code = "TELD553",
                IsLab = false,
                Name = "SISTEMAS DE TRANSMISIÓN",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 5,
            };
            var labSistemasTransmision = new Subject()
            {
                Id = 121,
                Code = "TELD553L",
                IsLab = true,
                Name = "LAB. DE SISTEMAS DE TRANSMISIÓN",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 5,
            };
            //6to semestre
            var comunicacionDigital = new Subject()
            {
                Id = 122,
                Code = "TELD613",
                IsLab = false,
                Name = "COMUNICACIÓN DIGITAL",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 6,
            };
            var labComunicacionDigital = new Subject()
            {
                Id = 123,
                Code = "TELD613L",
                IsLab = true,
                Name = "LAB. DE COMUNICACIÓN DIGITAL",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 6,
            };
            var telematicaBasica = new Subject()
            {
                Id = 124,
                Code = "TELD623",
                IsLab = false,
                Name = "TELEMÁTICA BÁSICA",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 6,
            };
            var labTelematicaBasica = new Subject()
            {
                Id = 125,
                Code = "TELD623L",
                IsLab = true,
                Name = "LAB. DE TELEMÁTICA BÁSICA",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 6,
            };
            var electronicaRadiofrecuencia = new Subject()
            {
                Id = 126,
                Code = "TELD633",
                IsLab = false,
                Name = "ELECTRÓNICA DE RADIOFRECUENCIA",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 6,
            };
            var labElectronicaRadiofrecuencia = new Subject()
            {
                Id = 127,
                Code = "TELD633L",
                IsLab = true,
                Name = "LAB. DE ELECTRÓNICA DE RADIOFRECUENCIA",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 6,
            };
            var aplicacionesSistemasEmbebidos = new Subject()
            {
                Id = 128,
                Code = "TELD642",
                IsLab = false,
                Name = "APLICACIONES CON SISTEMAS EMBEBIDOS",
                Alias = null,
                NumCredits = 2,
                NumHours = 96,
                NumSemester = 6,
            };
            var labAplicacionesSistemasEmbebidos = new Subject()
            {
                Id = 129,
                Code = "TELD642L",
                IsLab = true,
                Name = "LAB. DE APLICACIONES CON SISTEMAS EMBEBIDOS",
                Alias = null,
                NumCredits = 2,
                NumHours = 96,
                NumSemester = 6,
            };
            var propagacionAntenas = new Subject()
            {
                Id = 130,
                Code = "TELD654",
                IsLab = false,
                Name = "PROPAGACIÓN Y ANTENAS",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 6,
            };
            var labPropagacionAntenas = new Subject()
            {
                Id = 131,
                Code = "TELD654L",
                IsLab = true,
                Name = "LAB. DE PROPAGACIÓN Y ANTENAS",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 6,
            };
            //7mo semestre
            var comunicacionesOpticas = new Subject()
            {
                Id = 132,
                Code = "TELD713",
                IsLab = false,
                Name = "COMUNICACIONES ÓPTICAS",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 7,
            };
            var labComunicacionesOpticas = new Subject()
            {
                Id = 133,
                Code = "TELD713L",
                IsLab = true,
                Name = "LAB. DE COMUNICACIONES ÓPTICAS",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 7,
            };
            var telematicaAvanzada = new Subject()
            {
                Id = 134,
                Code = "TELD723",
                IsLab = false,
                Name = "TELEMÁTICA AVANZADA",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 7,
            };
            var labTelematicaAvanzada = new Subject()
            {
                Id = 135,
                Code = "TELD723L",
                IsLab = true,
                Name = "LAB. DE TELEMÁTICA AVANZADA",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 7,
            };
            var comunicacionesInalambricas = new Subject()
            {
                Id = 136,
                Code = "TELD733",
                IsLab = false,
                Name = "COMUNICACIONES INALÁMBRICAS",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 7,
            };
            var labComunicacionesInalambricas = new Subject()
            {
                Id = 137,
                Code = "TELD733L",
                IsLab = true,
                Name = "LAB. DE COMUNICACIONES INALÁMBRICAS",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 7,
            };
            var telefoniaIP = new Subject()
            {
                Id = 138,
                Code = "TELD743",
                IsLab = false,
                Name = "TELEFONÍA IP",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 7,
            };
            var ingenieriaMicroondas = new Subject()
            {
                Id = 139,
                Code = "TELD752",
                IsLab = false,
                Name = "INGENIERÍA DE MICROONDAS",
                Alias = null,
                NumCredits = 2,
                NumHours = 96,
                NumSemester = 7,
            };
            //8vo semestre
            var componentesPasivosRF = new Subject()
            {
                Id = 140,
                Code = "TELD801",
                IsLab = false,
                Name = "COMPONENTES PASIVOS DE RADIOFRECUENCIA",
                Alias = null,
                NumCredits = 2,
                NumHours = 96,
                NumSemester = 8,
            };
            var tecnicasAvanzadasPDSD = new Subject()
            {
                Id = 141,
                Code = "TELD802",
                IsLab = false,
                Name = "TÉCNICAS AVANZADAS DE PROCESAMIENTO DIGITAL DE SEÑALES",
                Alias = null,
                NumCredits = 2,
                NumHours = 96,
                NumSemester = 8,
            };
            var conmutacionEnrutamientoAvanzado = new Subject()
            {
                Id = 142,
                Code = "TELD803",
                IsLab = false,
                Name = "CONMUTACIÓN Y ENRUTAMIENTO AVANZADO",
                Alias = null,
                NumCredits = 2,
                NumHours = 96,
                NumSemester = 8,
            };
            var redesOpticas = new Subject()
            {
                Id = 143,
                Code = "TELD823",
                IsLab = false,
                Name = "REDES ÓPTICAS",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 8,
            };
            var labRedesOpticas = new Subject()
            {
                Id = 144,
                Code = "TELD823L",
                IsLab = true,
                Name = "LAB. DE REDES ÓPTICAS",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 8,
            };
            var introduccionDisenoRedes = new Subject()
            {
                Id = 145,
                Code = "TELD833",
                IsLab = false,
                Name = "INTRODUCCIÓN A DISEÑO DE REDES",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 8,
            };
            var sistemasCelulares = new Subject()
            {
                Id = 146,
                Code = "TELD843",
                IsLab = false,
                Name = "SISTEMAS CELULARES",
                Alias = null,
                NumCredits = 3,
                NumHours = 144,
                NumSemester = 8,
            };
            var fundamentosSeguridad = new Subject()
            {
                Id = 147,
                Code = "TELD852",
                IsLab = false,
                Name = "FUNDAMENTOS DE SEGURIDAD",
                Alias = null,
                NumCredits = 2,
                NumHours = 96,
                NumSemester = 8,
            };
            var labFundamentosSeguridad = new Subject()
            {
                Id = 148,
                Code = "TELD852L",
                IsLab = true,
                Name = "LAB. DE FUNDAMENTOS DE SEGURIDAD",
                Alias = null,
                NumCredits = 2,
                NumHours = 96,
                NumSemester = 8,
            };
            //9no semestre
            var componentesActivosRF = new Subject()
            {
                Id = 149,
                Code = "TELD901",
                IsLab = false,
                Name = "COMPONENTES ACTIVOS DE RADIOFRECUENCIA",
                Alias = null,
                NumCredits = 2,
                NumHours = 96,
                NumSemester = 9,
            };
            var tecnicasAvanzadasClasificacionSenales = new Subject()
            {
                Id = 150,
                Code = "TELD902",
                IsLab = false,
                Name = "TÉCNICAS AVANZADAS DE CLASIFICACIÓN DE SEÑALES",
                Alias = null,
                NumCredits = 2,
                NumHours = 96,
                NumSemester = 9,
            };
            var tecnologiasAvanzadasRedesDatos = new Subject()
            {
                Id = 151,
                Code = "TELD903",
                IsLab = false,
                Name = "TECNOLOGÍAS AVANZADAS DE REDES DE DATOS",
                Alias = null,
                NumCredits = 2,
                NumHours = 96,
                NumSemester = 9,
            };
            var marcoRegulatorioServiciosTelecom = new Subject()
            {
                Id = 152,
                Code = "TELD941",
                IsLab = false,
                Name = "MARCO REGULATORIO DE LOS SERVICIOS DE TELECOMUNICACIONES",
                Alias = null,
                NumCredits = 1,
                NumHours = 48,
                NumSemester = 9,
            };

            // ---------- TI -------------
            var basesDeDatos = new Subject()
            {
                Id = 153,
                Code = "ITID443",
                IsLab = false,
                Name = "BASES DE DATOS",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 4,
            };
            var sistemasOperativos = new Subject()
            {
                Id = 154,
                Code = "ITID452",
                IsLab = false,
                Name = "SISTEMAS OPERATIVOS",
                Alias = null,
                NumHours = 96,
                NumCredits = 2,
                NumSemester = 4,
            };
            var transmisionDigital = new Subject()
            {
                Id = 155,
                Code = "ITID524",
                IsLab = false,
                Name = "TRANSMISIÓN DIGITAL",
                Alias = null,
                NumHours = 192,
                NumCredits = 4,
                NumSemester = 5,
            };
            var laboratorioTransmisionDigital = new Subject()
            {
                Id = 156,
                Code = "ITID524L",
                IsLab = true,
                Name = "LAB. DE TRANSMISIÓN DIGITAL",
                Alias = null,
                NumHours = 192,
                NumCredits = 4,
                NumSemester = 5,
            };
            var disenoProgramacionSoftware = new Subject()
            {
                Id = 157,
                Code = "ITID543",
                IsLab = false,
                Name = "DISEÑO Y PROGRAMACIÓN DE SOFTWARE",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 5,
            };
            var cableadoEstructuradoAvanzado = new Subject()
            {
                Id = 158,
                Code = "ITID612",
                IsLab = false,
                Name = "CABLEADO ESTRUCTURADO AVANZADO",
                Alias = null,
                NumHours = 96,
                NumCredits = 2,
                NumSemester = 6,
            };
            var redesAreaLocal = new Subject()
            {
                Id = 159,
                Code = "ITID623",
                IsLab = false,
                Name = "REDES DE ÁREA LOCAL",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 6,
            };
            var laboratorioRedesAreaLocal = new Subject()
            {
                Id = 160,
                Code = "ITID623L",
                IsLab = true,
                Name = "LAB. DE REDES DE ÁREA LOCAL",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 6,
            };
            var enrutamiento = new Subject()
            {
                Id = 161,
                Code = "ITID633",
                IsLab = false,
                Name = "ENRUTAMIENTO",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 6,
            };
            var laboratorioEnrutamiento = new Subject()
            {
                Id = 162,
                Code = "ITID633L",
                IsLab = true,
                Name = "LAB. DE ENRUTAMIENTO",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 6,
            };
            var sistemasInalambricos = new Subject()
            {
                Id = 163,
                Code = "ITID643",
                IsLab = false,
                Name = "SISTEMAS INALÁMBRICOS",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 6,
            };
            var almacenamientoProcesamientoDatos = new Subject()
            {
                Id = 164,
                Code = "ITID653",
                IsLab = false,
                Name = "ALMACENAMIENTO Y PROCESAMIENTO DE DATOS",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 6,
            };
            var aplicacionesDistribuidas = new Subject()
            {
                Id = 165,
                Code = "ITID713",
                IsLab = false,
                Name = "APLICACIONES DISTRIBUIDAS",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 7,
            };
            var redesAreaExtendida = new Subject()
            {
                Id = 166,
                Code = "ITID723",
                IsLab = false,
                Name = "REDES DE ÁREA EXTENDIDA",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 7,
            };
            var laboratorioRedesAreaExtendida = new Subject()
            {
                Id = 167,
                Code = "ITID723L",
                IsLab = true,
                Name = "LAB. DE REDES DE ÁREA EXTENDIDA",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 7,
            };
            var seguridadRedes = new Subject()
            {
                Id = 168,
                Code = "ITID733",
                IsLab = false,
                Name = "SEGURIDAD EN REDES",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 7,
            };
            var redesIntranets = new Subject()
            {
                Id = 169,
                Code = "ITID742",
                IsLab = false,
                Name = "REDES E INTRANETS",
                Alias = null,
                NumHours = 96,
                NumCredits = 2,
                NumSemester = 7,
            };
            var aplicacionesWebMoviles = new Subject()
            {
                Id = 170,
                Code = "ITID753",
                IsLab = false,
                Name = "APLICACIONES WEB Y MÓVILES",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 7,
            };
            var hackingEtico = new Subject()
            {
                Id = 171,
                Code = "ITID801",
                IsLab = false,
                Name = "HACKING ÉTICO",
                Alias = null,
                NumHours = 96,
                NumCredits = 2,
                NumSemester = 8,
            };
            var comunicacionesUnificadas = new Subject()
            {
                Id = 172,
                Code = "ITID802",
                IsLab = false,
                Name = "COMUNICACIONES UNIFICADAS",
                Alias = null,
                NumHours = 96,
                NumCredits = 2,
                NumSemester = 8,
            };
            var disenoAplicacionesServiciosInternet = new Subject()
            {
                Id = 173,
                Code = "ITID803",
                IsLab = false,
                Name = "DISEÑO DE APLICACIONES Y SERVICIOS DE INTERNET",
                Alias = null,
                NumHours = 96,
                NumCredits = 2,
                NumSemester = 8,
            };
            var evaluacionRedes = new Subject()
            {
                Id = 174,
                Code = "ITID822",
                IsLab = false,
                Name = "EVALUACIÓN DE REDES",
                Alias = null,
                NumHours = 96,
                NumCredits = 2,
                NumSemester = 8,
            };
            var redesAreaLocalInalambricas = new Subject()
            {
                Id = 175,
                Code = "ITID832",
                IsLab = false,
                Name = "REDES DE ÁREA LOCAL INALÁMBRICAS",
                Alias = null,
                NumHours = 96,
                NumCredits = 2,
                NumSemester = 8,
            };
            var administracionRedes = new Subject()
            {
                Id = 176,
                Code = "ITID843",
                IsLab = false,
                Name = "ADMINISTRACIÓN DE REDES",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 8,
            };
            var mineriaDatos = new Subject()
            {
                Id = 177,
                Code = "ITID853",
                IsLab = false,
                Name = "MINERÍA DE DATOS",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 8,
            };
            var sistemasIoT = new Subject()
            {
                Id = 178,
                Code = "ITID862",
                IsLab = false,
                Name = "SISTEMAS IoT",
                Alias = null,
                NumHours = 96,
                NumCredits = 2,
                NumSemester = 8,
            };
            var administracionProcesosServiciosTI = new Subject()
            {
                Id = 179,
                Code = "ITID901",
                IsLab = false,
                Name = "ADMINISTRACIÓN DE PROCESOS Y SERVICIOS DE TI",
                Alias = null,
                NumHours = 96,
                NumCredits = 2,
                NumSemester = 9,
            };
            var redesDefinidasSoftware = new Subject()
            {
                Id = 180,
                Code = "ITID902",
                IsLab = false,
                Name = "REDES DEFINIDAS POR SOFTWARE",
                Alias = null,
                NumHours = 96,
                NumCredits = 2,
                NumSemester = 9,
            };
            var aplicacionesMovilesAvanzadas = new Subject()
            {
                Id = 181,
                Code = "ITID903",
                IsLab = false,
                Name = "APLICACIONES MÓVILES AVANZADAS",
                Alias = null,
                NumHours = 96,
                NumCredits = 2,
                NumSemester = 9,
            };

            //Olvidadas
            var ecologia = new Subject()
            {
                Id = 182,
                Code = "AMBD900",
                IsLab = false,
                Name = "ECOLOGIA Y AMBIENTE",
                Alias = null,
                NumHours = 0,
                NumCredits = 0,
                NumSemester = 5
            };
            var emprendimiento = new Subject()
            {
                Id = 183,
                Code = "ADMD700",
                IsLab = false,
                Name = "EMPRENDIMIENTO",
                Alias = null,
                NumHours = 0,
                NumCredits = 0,
                NumSemester = 5
            };
            var formulacion = new Subject()
            {
                Id = 184,
                Code = "ADMD800",
                IsLab = false,
                Name = "FORMULACION Y EVALUACION DE PROYECTOS",
                Alias = null,
                NumHours = 0,
                NumCredits = 0,
                NumSemester = 5
            };
            var metodologiaEstudio = new Subject()
            {
                Id = 185,
                Code = "IEED210",
                IsLab = false,
                Name = "METODOLOGIAS DE ESTUDIO",
                Alias = null,
                NumHours = 0,
                NumCredits = 0,
                NumSemester = 5
            };
            var prograAvanzada = new Subject()
            {
                Id = 186,
                Code = "ITID433",
                IsLab = false,
                Name = "PROGRAMACION AVANZADA",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 4
            };
            var protecciones = new Subject()
            {
                Id = 187,
                Code = "IELD941",
                IsLab = false,
                Name = "PROTECCIONES ELÉCTRICAS",
                Alias = null,
                NumHours = 48,
                NumCredits = 1,
                NumSemester = 9
            };
            var sistemasDeGestion = new Subject()
            {
                Id = 188,
                Code = "IELD903",
                IsLab = false,
                Name = "SISTEMAS DE GESTIÓN EN REDES ELÉCTRICAS DE DISTRIBUCIÓN",
                Alias = null,
                NumHours = 96,
                NumCredits = 2,
                NumSemester = 9
            };
            var labMicroondas = new Subject()
            {
                Id = 189,
                Code = "TELD752L",
                IsLab = true,
                Name = "LAB. INGENIERIA DE MICROONDAS",
                Alias = null,
                NumHours = 96,
                NumCredits = 2,
                NumSemester = 7
            };
            var regulacion = new Subject()
            {
                Id = 190,
                Code = "ITID941",
                IsLab = false,
                Name = "REGULACION DE LAS TECNOLOGIAS DE LA INFORMACION Y LA COMUNICACION",
                Alias = null,
                NumHours = 48,
                NumCredits = 1,
                NumSemester = 9
            };
            var redesElectricas = new Subject()
            {
                Id = 191,
                Code = "IELD803",
                IsLab = false,
                Name = "REDES ELÉCTRICAS INTELIGENTES Y GENERACIÓN DISTRIBUIDA",
                Alias = null,
                NumHours = 144,
                NumCredits = 3,
                NumSemester = 8
            };
            var clubes = new Subject()
            {
                Id = 192,
                Code = "SOCD210",
                IsLab = false,
                Name = "CLUBES",
                Alias = null,
                NumHours = 0,
                NumCredits = 0,
                NumSemester = 5
            };

            //Agregado
            modelBuilder
                .Entity<Subject>()
                .HasData(
                //Repetidas
                algebra, calculo, mecanica, laboratorioMecanica, quimica, herramientasInformaticas, comunicacionOralEscrita,
                ecuacionesDiferenciales, probabilidadEstadistica, calculoVectorial, fundamentosElectromagnetismo, programacion,
                analisisSocioeconomico, electrotecnia, laboratorioElectrotecnia, matematicaAvanzada, sistemasDigitales, laboratorioSistemasDigitales,
                dispositivosElectronicos, laboratorioDispositivosElectronicos, teoriaElectromagnetica, fundamentosCircuitosElectricos,
                laboratorioFundamentosCircuitosElectricos, matematicaDiscreta, instalacionesElectricasComunicaciones, analisisSenalesSistemas,
                circuitosElectronicos, laboratorioCircuitosElectronicos, conversionElectromecanicaEnergia, laboratorioConversionElectromecanicaEnergia,
                analisisCircuitosElectricos, laboratorioAnalisisCircuitosElectricos, electronicaPotencia, laboratorioElectronicaPotencia, maquinasElectricas,
                laboratorioMaquinasElectricas, sistemasControlAutomatico, laboratorioSistemasControlAutomatico, controlIndustrial, laboratorioControlIndustrial,
                seguridadIndustrialProteccionAmbiental, analisisSenalesDiscretasComunicaciones, teoriaInformacionCodificacion, sistemasEmbebidos,
                laboratorioSistemasEmbebidos, sistemasCableadoEstructurado, gestionOrganizacional, gestionProcesosCalidad, ingenieriaFinanciera, disenoTrabajoIntegracionCurricular, trabajoIntegracionCurricular,
                //Electrica
                modelacionSistemasElectricosPotencia, laboratorioModelacionSistemasElectricosPotencia, altoVoltaje, laboratorioAltoVoltaje, estudiosEstadoEstacionarioSistemasElectricosPotencia, laboratorioEstudiosEstadoEstacionarioSistemasElectricosPotencia,
                disenoAltoVoltaje, sistemasElectricosDistribucion, laboratorioSistemasElectricosDistribucion, dinamicaMaquinasElectricas,
                laboratorioDinamicaMaquinasElectricas, instalacionesElectricasMedioVoltaje, estabilidadSistemasElectricosPotencia, laboratorioEstabilidadSistemasElectricosPotencia, disenoElectromecanicoLineasTransmision,
                construccionRedesElectricas, centralesGeneracionElectrica, introduccionProteccionesElectricas, laboratorioIntroduccionProteccionesElectricas, optimizacionSistemasElectricosPotencia,
                operacionControlSistemasElectricosPotencia, analisisSistemasElectricosPotencia, accionamientoMaquinasElectricas, redesElectricasInteligentesGeneracionDistribuida, calidadEnergiaElectrica, confiabilidadSistemasElectricosPotencia,
                planificacionSistemasElectricosDistribucion, analisisEstabilidadPequenaSeñalSistemas, integracionEnergiasRenovablesSistemas, sistemaGestionRedesDistribucion,
                //Control
                sensoresytransductores, labSensoresytransductores, sistemasMicroprocesados, labSistemasMicroprocesados,
                instrumentacionIndustrial, labInstrumentacionIndustrial, controlEmbebido, labControlEmbebido, conversoresEstaticos, labConversoresEstaticos, sistemasControlDiscreto, labSistemasControlDiscreto,
                redesIndustriales, labRedesIndustriales, instalacionesElectricasIndustriales, accionamientosElectronicos, labAccionamientosElectronicos, automatizacionPLCs, labAutomatizacionPLCs, controlProcesosIndustriales, labControlProcesosIndustriales,
                sintesisPlantasIndustriales, instrumentacionBiomedica, fundamentosSistemasElectricosPotencia, sistemasScada, labSistemasScada, mandosNeumaticos, labMandosNeumaticos, robotica, labRobotica, introduccionControlMultivariable,
                introduccionIndustria40, visionArtificial, energiasRenovablesRedesInteligentes,
                //Telecom
                sistemaOperativoLinux,
                fundamentosComunicaciones, labFundamentosComunicaciones, procesamientoDigitalSenales, sistemasTransmision, labSistemasTransmision,
                comunicacionDigital, labComunicacionDigital, telematicaBasica, labTelematicaBasica, electronicaRadiofrecuencia, labElectronicaRadiofrecuencia, aplicacionesSistemasEmbebidos, labAplicacionesSistemasEmbebidos, propagacionAntenas, labPropagacionAntenas,
                comunicacionesOpticas, labComunicacionesOpticas, telematicaAvanzada, labTelematicaAvanzada, comunicacionesInalambricas, labComunicacionesInalambricas, telefoniaIP, ingenieriaMicroondas,
                componentesPasivosRF, tecnicasAvanzadasPDSD, conmutacionEnrutamientoAvanzado, redesOpticas, labRedesOpticas, introduccionDisenoRedes, sistemasCelulares, fundamentosSeguridad, labFundamentosSeguridad,
                componentesActivosRF, tecnicasAvanzadasClasificacionSenales, tecnologiasAvanzadasRedesDatos, marcoRegulatorioServiciosTelecom,
                //Ti
                basesDeDatos, sistemasOperativos, transmisionDigital, laboratorioTransmisionDigital, disenoProgramacionSoftware, cableadoEstructuradoAvanzado,
                redesAreaLocal, laboratorioRedesAreaLocal, enrutamiento, laboratorioEnrutamiento, sistemasInalambricos, almacenamientoProcesamientoDatos,
                aplicacionesDistribuidas, redesAreaExtendida, laboratorioRedesAreaExtendida, seguridadRedes, redesIntranets, aplicacionesWebMoviles,
                hackingEtico, comunicacionesUnificadas, disenoAplicacionesServiciosInternet, evaluacionRedes, redesAreaLocalInalambricas, administracionRedes,
                mineriaDatos, sistemasIoT, administracionProcesosServiciosTI, redesDefinidasSoftware, aplicacionesMovilesAvanzadas,
                //Olvidadas
                ecologia, emprendimiento, formulacion, metodologiaEstudio, prograAvanzada, protecciones,
                sistemasDeGestion, labMicroondas, regulacion, redesElectricas, clubes
                );


            //GRUPOS EDIFICIO 16
            //AULA E16/P1/E006A
            //LAB. ELECTROTECNIA
            #region e16_p1_e006a_gr1_1_15
            var e16_p1_e006a_gr1_1_15 = new Group()
            {
                Id = 501,
                Name = "GR1-1",
                SubjectId = 15,
                ClassroomId = 1,
                CalendarId = 1,
            }; 
            var e16_p1_e006a_gr1_1_15_session1 = new Session()
            {
                Id = 1001,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 501
            };
            #endregion

            #region e16_p1_e006a_gr1_2_15
            var e16_p1_e006a_gr1_2_15 = new Group()
            {
                Id = 502,
                Name = "GR1-2",
                SubjectId = 15,
                ClassroomId = 1,
                CalendarId = 1,
            };
            var e16_p1_e006a_gr1_2_15_session1 = new Session()
            {
                Id = 1002,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 502
            };
            #endregion

            #region e16_p1_e006a_gr1_3_15
            var e16_p1_e006a_gr1_3_15 = new Group()
            {
                Id = 503,
                Name = "GR1-3",
                SubjectId = 15,
                ClassroomId = 1,
                CalendarId = 1,
            };
            var e16_p1_e006a_gr1_3_15_session1 = new Session()
            {
                Id = 1003,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 503
            };
            #endregion

            #region e16_p1_e006a_gr1_4_15
            var e16_p1_e006a_gr1_4_15 = new Group()
            {
                Id = 504,
                Name = "GR1-4",
                SubjectId = 15,
                ClassroomId = 1,
                CalendarId = 1
            };
            var e16_p1_e006a_gr1_4_15_session1 = new Session()
            {
                Id = 1004,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 504
            };
            #endregion

            #region e16_p1_e006a_gr3_1_15
            var e16_p1_e006a_gr3_1_15 = new Group()
            {
                Id = 505,
                Name = "GR3-1",
                SubjectId = 15,
                ClassroomId = 1,
                CalendarId = 1,
            };
            var e16_p1_e006a_gr3_1_15_session1 = new Session()
            {
                Id = 1005,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 505
            };
            #endregion

            #region e16_p1_e006a_gr3_3_15
            var e16_p1_e006a_gr3_3_15 = new Group()
            {
                Id = 506,
                Name = "GR3-3",
                SubjectId = 15,
                ClassroomId = 1,
                CalendarId = 1,
            };
            var e16_p1_e006a_gr3_3_15_session1 = new Session()
            {
                Id = 1006,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 506
            };
            #endregion

            #region e16_p1_e006a_gr3_4_15
            var e16_p1_e006a_gr3_4_15 = new Group()
            {
                Id = 507,
                Name = "GR3-4",
                SubjectId = 15,
                ClassroomId = 1,
                CalendarId = 1,
            };
            var e16_p1_e006a_gr3_4_15_session1 = new Session()
            {
                Id = 1007,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 507
            };
            #endregion

            #region e16_p1_e006a_gr3_5_15
            var e16_p1_e006a_gr3_5_15 = new Group()
            {
                Id = 508,
                Name = "GR3-5",
                SubjectId = 15,
                ClassroomId = 1,
                CalendarId = 1,
            };
            var e16_p1_e006a_gr3_5_15_session1 = new Session()
            {
                Id = 1008,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 508
            };
            #endregion

            #region e16_p1_e006a_gr5_2_15
            var e16_p1_e006a_gr5_2_15 = new Group()
            {
                Id = 509,
                Name = "GR5-2",
                SubjectId = 15,
                ClassroomId = 1,
                CalendarId = 1,
            };
            var e16_p1_e006a_gr5_2_15_session1 = new Session()
            {
                Id = 1009,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 509
            };

            #endregion

            #region e16_p1_e006a_gr5_3_15
            var e16_p1_e006a_gr5_3_15 = new Group()
            {
                Id = 510,
                Name = "GR5-3",
                SubjectId = 15,
                ClassroomId = 1,
                CalendarId = 1,
            };
            var e16_p1_e006a_gr5_3_15_session1 = new Session()
            {
                Id = 1010,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 510
            };
            #endregion

            #region e16_p1_e006a_gr5_4_15
            var e16_p1_e006a_gr5_4_15 = new Group()
            {
                Id = 511,
                Name = "GR5-4",
                SubjectId = 15,
                ClassroomId = 1,
                CalendarId = 1,
            };
            var e16_p1_e006a_gr5_4_15_session1 = new Session()
            {
                Id = 1011,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 511
            };
            #endregion

            #region e16_p1_e006a_gr5_5_15
            var e16_p1_e006a_gr5_5_15 = new Group()
            {
                Id = 512,
                Name = "GR5-5",
                SubjectId = 15,
                ClassroomId = 1,
                CalendarId = 1,
            };
            var e16_p1_e006a_gr5_5_15_session1 = new Session()
            {
                Id = 1012,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 512
            };
            #endregion

            //LAB. FUNDAMENTOS DE CIRCUITOS
            #region e16_p1_e006a_gr1_5_23
            var e16_p1_e006a_gr1_5_23 = new Group()
            {
                Id = 513,
                Name = "GR1-5",
                SubjectId = 23,
                ClassroomId = 1,
                CalendarId = 1,
            };
            var e16_p1_e006a_gr1_5_23_session1 = new Session()
            {
                Id = 1013,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 513
            };
            #endregion

            #region e16_p1_e006a_gr4_2_23
            var e16_p1_e006a_gr4_2_23 = new Group()
            {
                Id = 514,
                Name = "GR4-2",
                SubjectId = 23,
                ClassroomId = 1,
                CalendarId = 1,
            };
            var e16_p1_e006a_gr4_2_23_session1 = new Session()
            {
                Id = 1014,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 514
            };
            #endregion

            #region e16_p1_e006a_gr4_4_23
            var e16_p1_e006a_gr4_4_23 = new Group()
            {
                Id = 515,
                Name = "GR4-4",
                SubjectId = 23,
                ClassroomId = 1,
                CalendarId = 1,
            };
            var e16_p1_e006a_gr4_4_23_session1 = new Session()
            {
                Id = 1015,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 515
            };
            #endregion

            #region e16_p1_e006a_gr5_1_23
            var e16_p1_e006a_gr5_1_23 = new Group()
            {
                Id = 516,
                Name = "GR5-1",
                SubjectId = 23,
                ClassroomId = 1,
                CalendarId = 1,
                Sessions = new List<Session>() {
                    
                }
            };
            var e16_p1_e006a_gr5_1_23_session1 = new Session()
            {
                Id = 1016,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 516
            };
            #endregion

            //AULA E16/P1/E006B
            //LAB. ELECTROTECNIA

            #region e16_p1_e006b_gr2_1_15
            var e16_p1_e006b_gr2_1_15 = new Group()
            {
                Id = 517,
                Name = "GR2-1",
                SubjectId = 15,
                ClassroomId = 2,
                CalendarId = 1,
            };
            var e16_p1_e006b_gr2_1_15_session1 = new Session()
            {
                Id = 1017,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 517
            };
            #endregion

            #region e16_p1_e006b_gr2_2_15
            var e16_p1_e006b_gr2_2_15 = new Group()
            {
                Id = 518,
                Name = "GR2-2",
                SubjectId = 15,
                ClassroomId = 2,
                CalendarId = 1,
            };
            var e16_p1_e006b_gr2_2_15_session1 = new Session()
            {
                Id = 1018,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 518
            };
            #endregion

            #region e16_p1_e006b_gr2_3_15
            var e16_p1_e006b_gr2_3_15 = new Group()
            {
                Id = 519,
                Name = "GR2-3",
                SubjectId = 15,
                ClassroomId = 2,
                CalendarId = 1,
            };
            var e16_p1_e006b_gr2_3_15_session1 = new Session()
            {
                Id = 1019,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 519
            };
            #endregion

            #region e16_p1_e006b_gr2_5_15
            var e16_p1_e006b_gr2_5_15 = new Group()
            {
                Id = 520,
                Name = "GR2-5",
                SubjectId = 15,
                ClassroomId = 2,
                CalendarId = 1,
            };
            var e16_p1_e006b_gr2_5_15_session1 = new Session()
            {
                Id = 1020,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 520
            };
            #endregion

            //LAB. FUNDAMENTOS DE CIRCUITOS

            #region e16_p1_e006b_gr4_5_23
            var e16_p1_e006b_gr4_5_23 = new Group()
            {
                Id = 521,
                Name = "GR4-5",
                SubjectId = 23,
                ClassroomId = 2,
                CalendarId = 1,
            };
            var e16_p1_e006b_gr4_5_23_session1 = new Session()
            {
                Id = 1021,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 521
            };
            #endregion

            //AULA E16/P1/E007A
            //LAB. FUNDAMENTOS DE CIRCUITOS

            #region e16_p1_e007a_gr1_1_23
            var e16_p1_e007a_gr1_1_23 = new Group()
            {
                Id = 522,
                Name = "GR1-1",
                SubjectId = 23,
                ClassroomId = 3,
                CalendarId = 1,
            };

            var e16_p1_e007a_gr1_1_23_session1 = new Session()
            {
                Id = 1022,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 522
            };
            #endregion

            #region e16_p1_e007a_gr1_4_23
            var e16_p1_e007a_gr1_4_23 = new Group()
            {
                Id = 523,
                Name = "GR1-4",
                SubjectId = 23,
                ClassroomId = 3,
                CalendarId = 1,
            };

            var e16_p1_e007a_gr1_4_23_session1 = new Session()
            {
                Id = 1023,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 523
            };

            #endregion

            #region e16_p1_e007a_gr2_3_23
            var e16_p1_e007a_gr2_3_23 = new Group()
            {
                Id = 524,
                Name = "GR2-3",
                SubjectId = 23,
                ClassroomId = 3,
                CalendarId = 1,
            };

            var e16_p1_e007a_gr2_3_23_session1 = new Session()
            {
                Id = 1024,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 524
            };
            #endregion

            #region e16_p1_e007a_gr3_1_23
            var e16_p1_e007a_gr3_1_23 = new Group()
            {
                Id = 525,
                Name = "GR3-1",
                SubjectId = 23,
                ClassroomId = 3,
                CalendarId = 1,
            };

            var e16_p1_e007a_gr3_1_23_session1 = new Session()
            {
                Id = 1025,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 525
            };
            #endregion

            #region e16_p1_e007a_gr3_2_23
            var e16_p1_e007a_gr3_2_23 = new Group()
            {
                Id = 526,
                Name = "GR3-2",
                SubjectId = 23,
                ClassroomId = 3,
                CalendarId = 1,
            };

            var e16_p1_e007a_gr3_2_23_session1 = new Session()
            {
                Id = 1026,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 526
            };
            #endregion

            #region e16_p1_e007a_gr3_3_23
            var e16_p1_e007a_gr3_3_23 = new Group()
            {
                Id = 527,
                Name = "GR3-3",
                SubjectId = 23,
                ClassroomId = 3,
                CalendarId = 1,
            };

            var e16_p1_e007a_gr3_3_23_session1 = new Session()
            {
                Id = 1027,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 527
            };
            #endregion

            #region e16_p1_e007a_gr4_3_23
            var e16_p1_e007a_gr4_3_23 = new Group()
            {
                Id = 528,
                Name = "GR4-3",
                SubjectId = 23,
                ClassroomId = 3,
                CalendarId = 1,
            };

            var e16_p1_e007a_gr4_3_23_session1 = new Session()
            {
                Id = 1028,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 528
            };
            #endregion

            #region e16_p1_e007a_gr5_2_23
            var e16_p1_e007a_gr5_2_23 = new Group()
            {
                Id = 529,
                Name = "GR5-2",
                SubjectId = 23,
                ClassroomId = 3,
                CalendarId = 1,
            };

            var e16_p1_e007a_gr5_2_23_session1 = new Session()
            {
                Id = 1029,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 529
            };
            #endregion

            #region e16_p1_e007a_gr5_3_23
            var e16_p1_e007a_gr5_3_23 = new Group()
            {
                Id = 530,
                Name = "GR5-3",
                SubjectId = 23,
                ClassroomId = 3,
                CalendarId = 1,
            };

            var e16_p1_e007a_gr5_3_23_session1 = new Session()
            {
                Id = 1030,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 530
            };
            #endregion

            //LAB. ANALISIS DE CIRCUITOS ELECTRONICOS

            #region e16_p1_e007a_gr1_1_32
            var e16_p1_e007a_gr1_1_32 = new Group()
            {
                Id = 531,
                Name = "GR1-1",
                SubjectId = 32,
                ClassroomId = 3,
                CalendarId = 1,
            };

            var e16_p1_e007a_gr1_1_32_session1 = new Session()
            {
                Id = 1031,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 531
            };
            #endregion

            #region e16_p1_e007a_gr1_2_32
            var e16_p1_e007a_gr1_2_32 = new Group()
            {
                Id = 532,
                Name = "GR1-2",
                SubjectId = 32,
                ClassroomId = 3,
                CalendarId = 1,
            };

            var e16_p1_e007a_gr1_2_32_session1 = new Session()
            {
                Id = 1032,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 532
            };
            #endregion

            #region e16_p1_e007a_gr1_3_32
            var e16_p1_e007a_gr1_3_32 = new Group()
            {
                Id = 533,
                Name = "GR1-3",
                SubjectId = 32,
                ClassroomId = 3,
                CalendarId = 1,
            };

            var e16_p1_e007a_gr1_3_32_session1 = new Session()
            {
                Id = 1033,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 533
            };
            #endregion

            #region e16_p1_e007a_gr1_4_32
            var e16_p1_e007a_gr1_4_32 = new Group()
            {
                Id = 534,
                Name = "GR1-4",
                SubjectId = 32,
                ClassroomId = 3,
                CalendarId = 1,
            };

            var e16_p1_e007a_gr1_4_32_session1 = new Session()
            {
                Id = 1034,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 534
            };
            #endregion

            #region e16_p1_e007a_gr2_2_32
            var e16_p1_e007a_gr2_2_32 = new Group()
            {
                Id = 535,
                Name = "GR2-2",
                SubjectId = 32,
                ClassroomId = 3,
                CalendarId = 1,
            };

            var e16_p1_e007a_gr2_2_32_session1 = new Session()
            {
                Id = 1035,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 535
            };
            #endregion

            #region e16_p1_e007a_gr2_3_32
            var e16_p1_e007a_gr2_3_32 = new Group()
            {
                Id = 536,
                Name = "GR2-3",
                SubjectId = 32,
                ClassroomId = 3,
                CalendarId = 1,
            };

            var e16_p1_e007a_gr2_3_32_session1 = new Session()
            {
                Id = 1036,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 536
            };
            #endregion

            #region e16_p1_e007a_gr2_4_32
            var e16_p1_e007a_gr2_4_32 = new Group()
            {
                Id = 537,
                Name = "GR2-4",
                SubjectId = 32,
                ClassroomId = 3,
                CalendarId = 1,
            };

            var e16_p1_e007a_gr2_4_32_session1 = new Session()
            {
                Id = 1037,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 537
            };
            #endregion

            //AULA E16/P1/E007B
            //LAB. FUNDAMENTOS DE CIRCUITOS

            #region e16_p1_e007b_gr1_3_23
            var e16_p1_e007b_gr1_3_23 = new Group()
            {
                Id = 538,
                Name = "GR1-3",
                SubjectId = 23,
                ClassroomId = 4,
                CalendarId = 1,
            };

            var e16_p1_e007b_gr1_3_23_session1 = new Session()
            {
                Id = 1038,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 538
            };
            #endregion

            #region e16_p1_e007b_gr2_2_23
            var e16_p1_e007b_gr2_2_23 = new Group()
            {
                Id = 539,
                Name = "GR2-2",
                SubjectId = 23,
                ClassroomId = 4,
                CalendarId = 1,
            };

            var e16_p1_e007b_gr2_2_23_session1 = new Session()
            {
                Id = 1039,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 539
            };
            #endregion

            #region e16_p1_e007b_gr2_4_23
            var e16_p1_e007b_gr2_4_23 = new Group()
            {
                Id = 540,
                Name = "GR2-4",
                SubjectId = 23,
                ClassroomId = 4,
                CalendarId = 1,
            };

            var e16_p1_e007b_gr2_4_23_session1 = new Session()
            {
                Id = 1040,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 540
            };
            #endregion

            #region e16_p1_e007b_gr3_4_23
            var e16_p1_e007b_gr3_4_23 = new Group()
            {
                Id = 541,
                Name = "GR3-4",
                SubjectId = 23,
                ClassroomId = 4,
                CalendarId = 1,
            };

            var e16_p1_e007b_gr3_4_23_session1 = new Session()
            {
                Id = 1041,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 541
            };
            #endregion

            #region e16_p1_e007b_gr5_4_23
            var e16_p1_e007b_gr5_4_23 = new Group()
            {
                Id = 542,
                Name = "GR5-4",
                SubjectId = 23,
                ClassroomId = 4,
                CalendarId = 1,
            };

            var e16_p1_e007b_gr5_4_23_session1 = new Session()
            {
                Id = 1042,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 542
            };
            #endregion

            //DISEÑO DE TIC

            #region e16_p1_e007b_gr3_50
            var e16_p1_e007b_gr3_50 = new Group()
            {
                Id = 543,
                Name = "GR3",
                SubjectId = 50,
                ClassroomId = 4,
                CalendarId = 1,
            };

            var e16_p1_e007b_gr3_50_session1 = new Session()
            {
                Id = 1043,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(17, 0, 0),
                GroupId = 543
            };
            #endregion

            //AULA E16/P1/E013
            //LAB. ELECTRONICA DE RADIOFRECUENCIA
            #region e16_p1_e013_gr1
            var e16_p1_e013_gr1 = new Group()
            {
                Id = 544,
                Name = "GR1",
                SubjectId = 127,
                ClassroomId = 6,
                CalendarId = 1,
            };

            var e16_p1_e013_gr1_session1 = new Session()
            {
                Id = 1044,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 544
            };
            #endregion

            #region e16_p1_e013_gr2
            var e16_p1_e013_gr2 = new Group()
            {
                Id = 545,
                Name = "GR2",
                SubjectId = 127,
                ClassroomId = 6,
                CalendarId = 1,
            };

            var e16_p1_e013_gr2_session1 = new Session()
            {
                Id = 1045,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 545
            };
            #endregion

            #region e16_p1_e013_gr3
            var e16_p1_e013_gr3 = new Group()
            {
                Id = 546,
                Name = "GR3",
                SubjectId = 127,
                ClassroomId = 6,
                CalendarId = 1,
            };

            var e16_p1_e013_gr3_session1 = new Session()
            {
                Id = 1046,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 546
            };
            #endregion

            //AULA E16/P1/E018
            //LAB. DISPOSITIVOS ELECTRONICOS
            #region e16_p1_e018_gr1_3
            var e16_p1_e018_gr1_3 = new Group()
            {
                Id = 547,
                Name = "GR1-3",
                SubjectId = 20,
                ClassroomId = 7,
                CalendarId = 1,
            };

            var e16_p1_e018_gr1_3_session1 = new Session()
            {
                Id = 1047,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 547
            };
            #endregion

            #region e16_p1_e018_gr1_4
            var e16_p1_e018_gr1_4 = new Group()
            {
                Id = 548,
                Name = "GR1-4",
                SubjectId = 20,
                ClassroomId = 7,
                CalendarId = 1,
            };

            var e16_p1_e018_gr1_4_session1 = new Session()
            {
                Id = 1048,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 548
            };
            #endregion

            #region e16_p1_e018_gr1_5
            var e16_p1_e018_gr1_5 = new Group()
            {
                Id = 549,
                Name = "GR1-5",
                SubjectId = 20,
                ClassroomId = 7,
                CalendarId = 1,
            };

            var e16_p1_e018_gr1_5_session1 = new Session()
            {
                Id = 1049,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 549
            };
            #endregion

            #region e16_p1_e018_gr3_1
            var e16_p1_e018_gr3_1 = new Group()
            {
                Id = 550,
                Name = "GR3-1",
                SubjectId = 20,
                ClassroomId = 7,
                CalendarId = 1,
            };

            var e16_p1_e018_gr3_1_session1 = new Session()
            {
                Id = 1050,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 550
            };
            #endregion

            #region e16_p1_e018_gr3_3
            var e16_p1_e018_gr3_3 = new Group()
            {
                Id = 551,
                Name = "GR3-3",
                SubjectId = 20,
                ClassroomId = 7,
                CalendarId = 1,
            };

            var e16_p1_e018_gr3_3_session1 = new Session()
            {
                Id = 1051,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 551
            };
            #endregion

            #region e16_p1_e018_gr3_4
            var e16_p1_e018_gr3_4 = new Group()
            {
                Id = 552,
                Name = "GR3-4",
                SubjectId = 20,
                ClassroomId = 7,
                CalendarId = 1,
            };

            var e16_p1_e018_gr3_4_session1 = new Session()
            {
                Id = 1052,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 552
            };
            #endregion

            //LAB. DISPOSITIVOS CIRCUITOS ELECTRONICOS

            #region e16_p1_e018_gr1_2_28
            var e16_p1_e018_gr1_2_28 = new Group()
            {
                Id = 553,
                Name = "GR1-2",
                SubjectId = 28,
                ClassroomId = 7,
                CalendarId = 1,
            };

            var e16_p1_e018_gr1_2_28_session1 = new Session()
            {
                Id = 1053,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 553
            };
            #endregion

            #region e16_p1_e018_gr1_3_28
            var e16_p1_e018_gr1_3_28 = new Group()
            {
                Id = 554,
                Name = "GR1-3",
                SubjectId = 28,
                ClassroomId = 7,
                CalendarId = 1,
            };

            var e16_p1_e018_gr1_3_28_session1 = new Session()
            {
                Id = 1054,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 554
            };
            #endregion

            #region e16_p1_e018_gr1_4_28
            var e16_p1_e018_gr1_4_28 = new Group()
            {
                Id = 555,
                Name = "GR1-4",
                SubjectId = 28,
                ClassroomId = 7,
                CalendarId = 1,
            };

            var e16_p1_e018_gr1_4_28_session1 = new Session()
            {
                Id = 1055,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 555
            };
            #endregion

            #region e16_p1_e018_gr3_2_28
            var e16_p1_e018_gr3_2_28 = new Group()
            {
                Id = 556,
                Name = "GR3-2",
                SubjectId = 28,
                ClassroomId = 7,
                CalendarId = 1,
            };

            var e16_p1_e018_gr3_2_28_session1 = new Session()
            {
                Id = 1056,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 556
            };

            #endregion

            #region e16_p1_e018_gr3_4_28
            var e16_p1_e018_gr3_4_28 = new Group()
            {
                Id = 557,
                Name = "GR3-4",
                SubjectId = 28,
                ClassroomId = 7,
                CalendarId = 1,
            };

            var e16_p1_e018_gr3_4_28_session1 = new Session()
            {
                Id = 1057,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 557
            };
            #endregion

            //AULA E16/P1/E019
            //LAB. DISPOSITIVOS ELECTRONICOS

            #region e16_p1_e019_gr2_1_20
            var e16_p1_e019_gr2_1_20 = new Group()
            {
                Id = 558,
                Name = "GR2-1",
                SubjectId = 20,
                ClassroomId = 8,
                CalendarId = 1,
            };

            var e16_p1_e019_gr2_1_20_session1 = new Session()
            {
                Id = 1058,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 558
            };
            #endregion

            #region e16_p1_e019_gr2_3_20
            var e16_p1_e019_gr2_3_20 = new Group()
            {
                Id = 559,
                Name = "GR2-3",
                SubjectId = 20,
                ClassroomId = 8,
                CalendarId = 1,
            };

            var e16_p1_e019_gr2_3_20_session1 = new Session()
            {
                Id = 1059,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 559
            };
            #endregion

            #region e16_p1_e019_gr2_4_20
            var e16_p1_e019_gr2_4_20 = new Group()
            {
                Id = 560,
                Name = "GR2-4",
                SubjectId = 20,
                ClassroomId = 8,
                CalendarId = 1,
            };

            var e16_p1_e019_gr2_4_20_session1 = new Session()
            {
                Id = 1060,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 560
            };
            #endregion

            #region e16_p1_e019_gr4_1_20
            var e16_p1_e019_gr4_1_20 = new Group()
            {
                Id = 561,
                Name = "GR4-1",
                SubjectId = 20,
                ClassroomId = 8,
                CalendarId = 1,
            };

            var e16_p1_e019_gr4_1_20_session1 = new Session()
            {
                Id = 1061,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 561
            };
            #endregion

            #region e16_p1_e019_gr4_2_20
            var e16_p1_e019_gr4_2_20 = new Group()
            {
                Id = 562,
                Name = "GR4-2",
                SubjectId = 20,
                ClassroomId = 8,
                CalendarId = 1,
            };

            var e16_p1_e019_gr4_2_20_session1 = new Session()
            {
                Id = 1062,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 562
            };
            #endregion

            #region e16_p1_e019_gr4_3_20
            var e16_p1_e019_gr4_3_20 = new Group()
            {
                Id = 563,
                Name = "GR4-3",
                SubjectId = 20,
                ClassroomId = 8,
                CalendarId = 1,
            };

            var e16_p1_e019_gr4_3_20_session1 = new Session()
            {
                Id = 1063,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 563
            };
            #endregion

            #region e16_p1_e019_gr5_1_20
            var e16_p1_e019_gr5_1_20 = new Group()
            {
                Id = 564,
                Name = "GR5-1",
                SubjectId = 20,
                ClassroomId = 8,
                CalendarId = 1,
            };

            
            var e16_p1_e019_gr5_1_20_session1 = new Session()
            {
                Id = 1064,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 564
            };
            #endregion

            #region e16_p1_e019_gr5_2_20
            var e16_p1_e019_gr5_2_20 = new Group()
            {
                Id = 565,
                Name = "GR5-2",
                SubjectId = 20,
                ClassroomId = 8,
                CalendarId = 1,
            };
            var e16_p1_e019_gr5_2_20_session1 = new Session()
            {
                Id = 1065,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 565
            };
            #endregion

            #region e16_p1_e019_gr5_3_20
            var e16_p1_e019_gr5_3_20 = new Group()
            {
                Id = 566,
                Name = "GR5-3",
                SubjectId = 20,
                ClassroomId = 8,
                CalendarId = 1,
            };

            var e16_p1_e019_gr5_3_20_session1 = new Session()
            {
                Id = 1066,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 566
            };
            #endregion

            //LAB. CIRCUITOS ELECTRONICOS 20
            #region e16_p1_e019_gr2_2_28
            var e16_p1_e019_gr2_2_28 = new Group()
            {
                Id = 567,
                Name = "GR2-2",
                SubjectId = 28,
                ClassroomId = 8,
                CalendarId = 1,
            };

            var e16_p1_e019_gr2_2_28_session1 = new Session()
            {
                Id = 1067,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 567
            };
            #endregion

            #region e16_p1_e019_gr2_4_28
            var e16_p1_e019_gr2_4_28 = new Group()
            {
                Id = 568,
                Name = "GR2-4",
                SubjectId = 28,
                ClassroomId = 8,
                CalendarId = 1,
            };

            var e16_p1_e019_gr2_4_28_session1 = new Session()
            {
                Id = 1068,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 568
            };
            #endregion

            #region e16_p1_e019_gr4_1_28
            var e16_p1_e019_gr4_1_28 = new Group()
            {
                Id = 569,
                Name = "GR4-1",
                SubjectId = 28,
                ClassroomId = 8,
                CalendarId = 1,
            };

            var e16_p1_e019_gr4_1_28_session1 = new Session()
            {
                Id = 1069,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 569
            };
            #endregion

            #region e16_p1_e019_gr4_4_28
            var e16_p1_e019_gr4_4_28 = new Group()
            {
                Id = 570,
                Name = "GR4-4",
                SubjectId = 28,
                ClassroomId = 8,
                CalendarId = 1,
            };

            var e16_p1_e019_gr4_4_28_session1 = new Session()
            {
                Id = 1070,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 570
            };
            #endregion

            //E16/P1/E020
            //LAB. CIRCUITOS ELECTRONICOS 20
            #region  e16_p1_e020_gr2_3_28
            var e16_p1_e020_gr2_3_28 = new Group()
            {
                Id = 571,
                Name = "GR2-3",
                SubjectId = 28,
                ClassroomId = 9,
                CalendarId = 1,
            };

            var e16_p1_e020_gr2_3_28_session1 = new Session()
            {
                Id = 1071,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 571
            };
            #endregion

            #region e16_p1_e020_gr3_1_28
            var e16_p1_e020_gr3_1_28 = new Group()
            {
                Id = 572,
                Name = "GR3-1",
                SubjectId = 28,
                ClassroomId = 9,
                CalendarId = 1,
            };

            var e16_p1_e020_gr3_1_28_session1 = new Session()
            {
                Id = 1072,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 572
            };
            #endregion

            #region e16_p1_e020_gr4_2_28
            var e16_p1_e020_gr4_2_28 = new Group()
            {
                Id = 573,
                Name = "GR4-2",
                SubjectId = 28,
                ClassroomId = 9,
                CalendarId = 1,
            };

            var e16_p1_e020_gr4_2_28_session1 = new Session()
            {
                Id = 1073,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 573
            };
            #endregion

            #region e16_p1_e020_gr4_3_28
            var e16_p1_e020_gr4_3_28 = new Group()
            {
                Id = 574,
                Name = "GR4-3",
                SubjectId = 28,
                ClassroomId = 9,
                CalendarId = 1,
            };

            var e16_p1_e020_gr4_3_28_session1 = new Session()
            {
                Id = 1074,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 574
            };
            #endregion

            //E16/P1/E021
            //ADMINISTRACION DE PROCESOS Y SERVICIOS DE TI
            #region e16_p1_e021_gr1_179
            var e16_p1_e021_gr1_179 = new Group()
            {
                Id = 575,
                Name = "GR1",
                SubjectId = 179,
                ClassroomId = 10,
                CalendarId = 1,
            };

            var e16_p1_e021_gr1_179_session1 = new Session()
            {
                Id = 1075,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(17, 0, 0),
                EndTime = new TimeSpan(19, 0, 0),
                GroupId = 575
            };

            var e16_p1_e021_gr1_179_session2 = new Session()
            {
                Id = 1076,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(18, 0, 0),
                EndTime = new TimeSpan(19, 0, 0),
                GroupId = 575
            };
            #endregion

            //CABLEADO ESTRUCTURADO AVANZADO
            #region e16_p1_e021_gr2_158
            var e16_p1_e021_gr2_158 = new Group()
            {
                Id = 576,
                Name = "GR2",
                SubjectId = 158,
                ClassroomId = 10,
                CalendarId = 1,
            };

            var e16_p1_e021_gr2_158_session1 = new Session()
            {
                Id = 1077,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(17, 0, 0),
                GroupId = 576
            };

            var e16_p1_e021_gr2_158_session2 = new Session()
            {
                Id = 1078,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 576
            };
            #endregion

            //ENRUTAMIENTO
            #region e16_p1_e021_gr1_161
            var e16_p1_e021_gr1_161 = new Group()
            {
                Id = 577,
                Name = "GR1",
                SubjectId = 161,
                ClassroomId = 10,
                CalendarId = 1,
            };

            var e16_p1_e021_gr1_161_session1 = new Session()
            {
                Id = 1079,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 577
            };
            #endregion

            //REGULACION DE LAS TECNOLOGIAS DE LA INFORMACION Y LA COMUNICACION
            #region e16_p1_e021_gr1_190
            var e16_p1_e021_gr1_190 = new Group()
            {
                Id = 578,
                Name = "GR1",
                SubjectId = 190,
                ClassroomId = 10,
                CalendarId = 1,
            };

            var e16_p1_e021_gr1_190_session1 = new Session()
            {
                Id = 1080,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(18, 0, 0),
                EndTime = new TimeSpan(20, 0, 0),
                GroupId = 578
            };
            #endregion

            //TEORIA ELECTROMAGNETICA 
            #region e16_p1_e021_gr2_21
            var e16_p1_e021_gr2_21 = new Group()
            {
                Id = 579,
                Name = "GR2",
                SubjectId = 21,
                ClassroomId = 10,
                CalendarId = 1,
            };

            var e16_p1_e021_gr2_21_session1 = new Session()
            {
                Id = 1081,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 579
            };

            var e16_p1_e021_gr2_21_session2 = new Session()
            {
                Id = 1082,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 579
            };
            #endregion

            //CONTROL INDUSTRIAL
            #region e16_p1_e021_gr1_39
            var e16_p1_e021_gr1_39 = new Group()
            {
                Id = 580,
                Name = "GR1",
                SubjectId = 39,
                ClassroomId = 10,
                CalendarId = 1,
            };

            var e16_p1_e021_gr1_39_session1 = new Session()
            {
                Id = 1083,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 580
            };
            #endregion

            //ALTO VOLTAJE 
            #region e16_p1_e021_gr1_54
            var e16_p1_e021_gr1_54 = new Group()
            {
                Id = 581,
                Name = "GR1",
                SubjectId = 54,
                ClassroomId = 10,
                CalendarId = 1,
            };

            var e16_p1_e021_gr1_54_session1 = new Session()
            {
                Id = 1084,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 581
            };

            var e16_p1_e021_gr1_54_session2 = new Session()
            {
                Id = 1085,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(8, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 581
            };
            #endregion

            //ANÁLISIS AVANZADO DE SISTEMAS ELÉCTRICOS DE POTENCIA
            #region e16_p1_e021_gr1_73
            var e16_p1_e021_gr1_73 = new Group()
            {
                Id = 582,
                Name = "GR1",
                SubjectId = 73,
                ClassroomId = 10,
                CalendarId = 1,
            };

            var e16_p1_e021_gr1_73_session1 = new Session()
            {
                Id = 1086,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 582
            };

            var e16_p1_e021_gr1_73_session2 = new Session()
            {
                Id = 1087,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 582
            };
            #endregion

            //FUNDAMENTOS DE SEGURIDAD
            #region e16_p1_e021_gr1_147
            var e16_p1_e021_gr1_147 = new Group()
            {
                Id = 583,
                Name = "GR1",
                SubjectId = 147,
                ClassroomId = 10,
                CalendarId = 1,
            };

            var e16_p1_e021_gr1_147_session1 = new Session()
            {
                Id = 1088,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 583
            };

            var e16_p1_e021_gr1_147_session2 = new Session()
            {
                Id = 1089,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 583
            };
            #endregion

            //TELEMATICA BASICA
            #region e16_p1_e021_gr1_124
            var e16_p1_e021_gr1_124 = new Group()
            {
                Id = 584,
                Name = "GR1",
                SubjectId = 124,
                ClassroomId = 10,
                CalendarId = 1,
            };

            var e16_p1_e021_gr1_124_session1 = new Session()
            {
                Id = 1090,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 584
            };

            var e16_p1_e021_gr1_124_session2 = new Session()
            {
                Id = 1091,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(10, 0, 0),
                GroupId = 584
            };
            #endregion


            //E16/P2/E001
            //LAB. TRANSIMISION DIGITAL
            #region e16_p2_e001_gr1_156
            var e16_p2_e001_gr1_156 = new Group()
            {
                Id = 585,
                Name = "GR1",
                SubjectId = 156,
                ClassroomId = 11,
                CalendarId = 1,
            };

            var e16_p2_e001_gr1_156_session1 = new Session()
            {
                Id = 1092,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(8, 0, 0),
                GroupId = 585
            };

            var e16_p2_e001_gr1_156_session2 = new Session()
            {
                Id = 1093,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 585
            };
            #endregion

            #region e16_p2_e001_gr2_156
            var e16_p2_e001_gr2_156 = new Group()
            {
                Id = 586,
                Name = "GR2",
                SubjectId = 156,
                ClassroomId = 11,
                CalendarId = 1,
            };
           

            var e16_p2_e001_gr2_156_session1 = new Session()
            {
                Id = 1094,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 586
            };

            var e16_p2_e001_gr2_156_session2 = new Session()
            {
                Id = 1095,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(8, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 586
            };
            #endregion

            #region e16_p2_e001_gr3_156
            var e16_p2_e001_gr3_156 = new Group()
            {
                Id = 587,
                Name = "GR3",
                SubjectId = 156,
                ClassroomId = 11,
                CalendarId = 1,
            };

            var e16_p2_e001_gr3_156_session1 = new Session()
            {
                Id = 1096,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 587
            };
            #endregion

            //LAB. COMUNICACION DIGITAL ***REVISAR***
            #region e16_p2_e001_gr1_123
            var e16_p2_e001_gr1_123 = new Group()
            {
                Id = 588,
                Name = "GR1",
                SubjectId = 123,
                ClassroomId = 11,
                CalendarId = 1,
            };

            var e16_p2_e001_gr1_123_session1 = new Session()
            {
                Id = 1097,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(12, 0, 0),
                GroupId = 588
            };
            #endregion

            #region e16_p2_e001_gr2_123
            var e16_p2_e001_gr2_123 = new Group()
            {
                Id = 589,
                Name = "GR2",
                SubjectId = 123,
                ClassroomId = 11,
                CalendarId = 1,
            };

            var e16_p2_e001_gr2_123_session1 = new Session()
            {
                Id = 1098,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(12, 0, 0),
                GroupId = 589
            };
            #endregion

            //LAB. FUNDAMENTOS DE COMUNICACION
            #region e16_p2_e001_gr1_118
            var e16_p2_e001_gr1_118 = new Group()
            {
                Id = 590,
                Name = "GR1",
                SubjectId = 118,
                ClassroomId = 11,
                CalendarId = 1,
            };

            var e16_p2_e001_gr1_118_session1 = new Session()
            {
                Id = 1099,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 590
            };
            #endregion

            #region e16_p2_e001_gr2_118
            var e16_p2_e001_gr2_118 = new Group()
            {
                Id = 591,
                Name = "GR2",
                SubjectId = 118,
                ClassroomId = 11,
                CalendarId = 1,
            };

            var e16_p2_e001_gr2_118_session1 = new Session()
            {
                Id = 1100,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 591
            };
            #endregion

            #region e16_p2_e001_gr3_118
            var e16_p2_e001_gr3_118 = new Group()
            {
                Id = 592,
                Name = "GR3",
                SubjectId = 118,
                ClassroomId = 11,
                CalendarId = 1,
            };

            var e16_p2_e001_gr3_118_session1 = new Session()
            {
                Id = 1101,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 592
            };
            #endregion


            //E16/P2/E002
            #region e16_p2_e002_gr1_165
            var e16_p2_e002_gr1_165 = new Group()
            {
                Id = 593,
                Name = "GR1",
                SubjectId = 165,
                ClassroomId = 12,
                CalendarId = 1,
            };

            var e16_p2_e002_gr1_165_session1 = new Session()
            {
                Id = 1102,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 593
            };

            var e16_p2_e002_gr1_165_session2 = new Session()
            {
                Id = 1103,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 593
            };
            #endregion

            #region e16_p2_e002_gr2_153
            var e16_p2_e002_gr2_153 = new Group()
            {
                Id = 594,
                Name = "GR2",
                SubjectId = 153,
                ClassroomId = 12,
                CalendarId = 1,
            };

            var e16_p2_e002_gr2_153_session1 = new Session()
            {
                Id = 1104,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 594
            };

            var e16_p2_e002_gr2_153_session2 = new Session()
            {
                Id = 1105,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 594
            };
            #endregion

            #region e16_p2_e002_gr1_160
            var e16_p2_e002_gr1_160 = new Group()
            {
                Id = 595,
                Name = "GR1",
                SubjectId = 160,
                ClassroomId = 12,
                CalendarId = 1,
            };

            var e16_p2_e002_gr1_160_session1 = new Session()
            {
                Id = 1106,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 595
            };
            #endregion

            #region e16_p2_e002_gr1_175
            var e16_p2_e002_gr1_175 = new Group()
            {
                Id = 596,
                Name = "GR1",
                SubjectId = 175,
                ClassroomId = 12,
                CalendarId = 1,
            };

            var e16_p2_e002_gr1_175_session1 = new Session()
            {
                Id = 1107,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(15, 0, 0),
                GroupId = 593
            };

            #endregion

            #region e16_p2_e002_gr1_169
            var e16_p2_e002_gr1_169 = new Group()
            {
                Id = 597,
                Name = "GR1",
                SubjectId = 169,
                ClassroomId = 12,
                CalendarId = 1,
            };

            var e16_p2_e002_gr1_169_session1 = new Session()
            {
                Id = 1108,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 597
            };

            var e16_p2_e002_gr1_169_session2 = new Session()
            {
                Id = 1109,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(12, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 597
            };
            #endregion

            #region e16_p2_e002_gr1_168
            var e16_p2_e002_gr1_168 = new Group()
            {
                Id = 598,
                Name = "GR1",
                SubjectId = 168,
                ClassroomId = 12,
                CalendarId = 1,
            };

            var e16_p2_e002_gr1_168_session1 = new Session()
            {
                Id = 1110,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 598
            };

            #endregion

            #region e16_p2_e002_gr1_154
            var e16_p2_e002_gr1_154 = new Group()
            {
                Id = 599,
                Name = "GR1",
                SubjectId = 154,
                ClassroomId = 12,
                CalendarId = 1,
            };

            var e16_p2_e002_gr1_154_session1 = new Session()
            {
                Id = 1111,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 599
            };

            var e16_p2_e002_gr1_154_session2 = new Session()
            {
                Id = 1112,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(8, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 599
            };

            var e16_p2_e002_gr1_154_session3 = new Session()
            {
                Id = 1113,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 599
            };

            #endregion

            //E16/P2/E003
            #region e16_p2_e003_gr1_159
            var e16_p2_e003_gr1_159 = new Group()
            {
                Id = 600,
                Name = "GR1",
                SubjectId = 159,
                ClassroomId = 13,
                CalendarId = 1,
            };

            var e16_p2_e003_gr1_159_session1 = new Session()
            {
                Id = 1114,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 600
            };

            var e16_p2_e003_gr1_159_session2 = new Session()
            {
                Id = 1115,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(15, 0, 0),
                GroupId = 600
            };

            #endregion

            #region e16_p2_e003_gr1_175
            var e16_p2_e003_gr1_175 = new Group()
            {
                Id = 601,
                Name = "GR1",
                SubjectId = 175,
                ClassroomId = 13,
                CalendarId = 1,
            };

            var e16_p2_e003_gr1_175_session1 = new Session()
            {
                Id = 1116,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 601
            };

            #endregion

            #region e16_p2_e003_gr1_168
            var e16_p2_e003_gr1_168 = new Group()
            {
                Id = 602,
                Name = "GR1",
                SubjectId = 168,
                ClassroomId = 13,
                CalendarId = 1,
            };

            var e16_p2_e003_gr1_168_session1 = new Session()
            {
                Id = 1117,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 602
            };

            #endregion

            #region e16_p2_e003_gr1_163
            var e16_p2_e003_gr1_163 = new Group()
            {
                Id = 603,
                Name = "GR1",
                SubjectId = 163,
                ClassroomId = 13,
                CalendarId = 1,
            };

            var e16_p2_e003_gr1_163_session1 = new Session()
            {
                Id = 1118,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 603
            };

            var e16_p2_e003_gr1_163_session2 = new Session()
            {
                Id = 1119,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 603
            };

            #endregion

            //E16/P2/E004
            //LAB. SISTEMAS DIGITALES
            #region e16_p2_e004_gr1_1_18
            var e16_p2_e004_gr1_1_18 = new Group()
            {
                Id = 604,
                Name = "GR1-1",
                SubjectId = 18,
                ClassroomId = 14,
                CalendarId = 1,
            };

            var e16_p2_e004_gr1_1_18_session1 = new Session()
            {
                Id = 1120,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 604
            };

            #endregion

            #region e16_p2_e004_gr1_2_18
            var e16_p2_e004_gr1_2_18 = new Group()
            {
                Id = 605,
                Name = "GR1-2",
                SubjectId = 18,
                ClassroomId = 14,
                CalendarId = 1,
            };

            var e16_p2_e004_gr1_2_18_session1 = new Session()
            {
                Id = 1121,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 605
            };

            #endregion

            #region e16_p2_e004_gr1_3_18
            var e16_p2_e004_gr1_3_18 = new Group()
            {
                Id = 606,
                Name = "GR1-3",
                SubjectId = 18,
                ClassroomId = 14,
                CalendarId = 1,
            };

            var e16_p2_e004_gr1_3_18_session1 = new Session()
            {
                Id = 1122,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 606
            };
            #endregion

            #region e16_p2_e004_gr1_4_18
            var e16_p2_e004_gr1_4_18 = new Group()
            {
                Id = 607,
                Name = "GR1-4",
                SubjectId = 18,
                ClassroomId = 14,
                CalendarId = 1,
            };

            var e16_p2_e004_gr1_4_18_session1 = new Session()
            {
                Id = 1123,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 607
            };

            #endregion

            #region e16_p2_e004_gr3_1_18
            var e16_p2_e004_gr3_1_18 = new Group()
            {
                Id = 608,
                Name = "GR3-1",
                SubjectId = 18,
                ClassroomId = 14,
                CalendarId = 1,
            };

            var e16_p2_e004_gr3_1_18_session1 = new Session()
            {
                Id = 1124,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 608
            };

            #endregion

            #region e16_p2_e004_gr3_2_18
            var e16_p2_e004_gr3_2_18 = new Group()
            {
                Id = 609,
                Name = "GR3-2",
                SubjectId = 18,
                ClassroomId = 14,
                CalendarId = 1,
            };

            var e16_p2_e004_gr3_2_18_session1 = new Session()
            {
                Id = 1125,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 609
            };

            #endregion

            #region e16_p2_e004_gr3_3_18
            var e16_p2_e004_gr3_3_18 = new Group()
            {
                Id = 610,
                Name = "GR3-3",
                SubjectId = 18,
                ClassroomId = 14,
                CalendarId = 1,
            };

            var e16_p2_e004_gr3_3_18_session1 = new Session()
            {
                Id = 1126,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 610
            };

            #endregion

            #region e16_p2_e004_gr3_4_18
            var e16_p2_e004_gr3_4_18 = new Group()
            {
                Id = 611,
                Name = "GR3-4",
                SubjectId = 18,
                ClassroomId = 14,
                CalendarId = 1,
            };

            var e16_p2_e004_gr3_4_18_session1 = new Session()
            {
                Id = 1127,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 611
            };
            #endregion

            #region e16_p2_e004_gr4_1_18
            var e16_p2_e004_gr4_1_18 = new Group()
            {
                Id = 612,
                Name = "GR4-1",
                SubjectId = 18,
                ClassroomId = 14,
                CalendarId = 1,
            };

            var e16_p2_e004_gr4_1_18_session1 = new Session()
            {
                Id = 1128,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 612
            };
            #endregion

            #region e16_p2_e004_gr4_2_18
            var e16_p2_e004_gr4_2_18 = new Group()
            {
                Id = 613,
                Name = "GR4-2",
                SubjectId = 18,
                ClassroomId = 14,
                CalendarId = 1,
            };

            var e16_p2_e004_gr4_2_18_session1 = new Session()
            {
                Id = 1129,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 613
            };
            #endregion

            #region e16_p2_e004_gr4_3_18
            var e16_p2_e004_gr4_3_18 = new Group()
            {
                Id = 614,
                Name = "GR4-3",
                SubjectId = 18,
                ClassroomId = 14,
                CalendarId = 1,
            };

            var e16_p2_e004_gr4_3_18_session1 = new Session()
            {
                Id = 1130,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 614
            };
            #endregion

            #region e16_p2_e004_gr4_4_18
            var e16_p2_e004_gr4_4_18 = new Group()
            {
                Id = 615,
                Name = "GR4-4",
                SubjectId = 18,
                ClassroomId = 14,
                CalendarId = 1,
            };

            var e16_p2_e004_gr4_4_18_session1 = new Session()
            {
                Id = 1131,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 615
            };
            #endregion

            //E17/P5/E027
            #region e17_p5_e027_gr3_1
            var e17_p5_e027_gr3_1 = new Group()
            {
                Id = 616,
                Name = "GR3",
                SubjectId = 1,
                ClassroomId = 78,
                CalendarId = 1,
            };

            var e17_p5_e027_gr3_1_session1 = new Session()
            {
                Id = 1132,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 616
            };

            var e17_p5_e027_gr3_1_session2 = new Session()
            {
                Id = 1133,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 616
            };

            #endregion

            #region e17_p5_e027_gr4_1
            var e17_p5_e027_gr4_1 = new Group()
            {
                Id = 617,
                Name = "GR4",
                SubjectId = 1,
                ClassroomId = 78,
                CalendarId = 1,
            };

            var e17_p5_e027_gr4_1_session1 = new Session()
            {
                Id = 1134,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 617
            };

            var e17_p5_e027_gr4_1_session2 = new Session()
            {
                Id = 1135,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 617
            };

            #endregion

            #region e17_p5_e027_gr3_2
            var e17_p5_e027_gr3_2 = new Group()
            {
                Id = 618,
                Name = "GR3",
                SubjectId = 2,
                ClassroomId = 78,
                CalendarId = 1,
            };

            var e17_p5_e027_gr3_2_session1 = new Session()
            {
                Id = 1136,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 618
            };

            var e17_p5_e027_gr3_2_session2 = new Session()
            {
                Id = 1137,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 618
            };
            #endregion

            #region e17_p5_e027_gr1_184
            var e17_p5_e027_gr1_184 = new Group()
            {
                Id = 619,
                Name = "GR1",
                SubjectId = 184,
                ClassroomId = 78,
                CalendarId = 1,
            };

            var e17_p5_e027_gr1_184_session1 = new Session()
            {
                Id = 1138,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 619
            };
            #endregion

            #region e17_p5_e027_gr4_48
            var e17_p5_e027_gr4_48 = new Group()
            {
                Id = 620,
                Name = "GR4",
                SubjectId = 48,
                ClassroomId = 78,
                CalendarId = 1,
            };

            var e17_p5_e027_gr4_48_session1 = new Session()
            {
                Id = 1139,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 620
            };
            #endregion

            #region e17_p5_e027_gr3_3
            var e17_p5_e027_gr3_3 = new Group()
            {
                Id = 621,
                Name = "GR3",
                SubjectId = 3,
                ClassroomId = 78,
                CalendarId = 1,
            };

            var e17_p5_e027_gr3_3_session1 = new Session()
            {
                Id = 1140,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 621
            };

            var e17_p5_e027_gr3_3_session2 = new Session()
            {
                Id = 1141,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 621
            };
            #endregion

            #region e17_p5_e027_gr4_3
            var e17_p5_e027_gr4_3 = new Group()
            {
                Id = 622,
                Name = "GR4",
                SubjectId = 3,
                ClassroomId = 78,
                CalendarId = 1,
            };

            var e17_p5_e027_gr4_3_session1 = new Session()
            {
                Id = 1142,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 622
            };

            var e17_p5_e027_gr4_3_session2 = new Session()
            {
                Id = 1143,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 622
            };
            #endregion

            #region e17_p5_e027_gr1_9
            var e17_p5_e027_gr1_9 = new Group()
            {
                Id = 623,
                Name = "GR1",
                SubjectId = 9,
                ClassroomId = 78,
                CalendarId = 1,
            };

            var e17_p5_e027_gr1_9_session1 = new Session()
            {
                Id = 1144,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 623
            };

            var e17_p5_e027_gr1_9_session2 = new Session()
            {
                Id = 1145,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 623
            };
            #endregion

            #region e17_p5_e027_gr3_5
            var e17_p5_e027_gr3_5 = new Group()
            {
                Id = 624,
                Name = "GR3",
                SubjectId = 5,
                ClassroomId = 78,
                CalendarId = 1,
            };

            var e17_p5_e027_gr3_5_session1 = new Session()
            {
                Id = 1146,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 624
            };

            var e17_p5_e027_gr3_5_session2 = new Session()
            {
                Id = 1147,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 624
            };

            #endregion

            #region e17_p5_e027_gr4_5
            var e17_p5_e027_gr4_5 = new Group()
            {
                Id = 625,
                Name = "GR4",
                SubjectId = 5,
                ClassroomId = 78,
                CalendarId = 1,
            };

            var e17_p5_e027_gr4_5_session1 = new Session()
            {
                Id = 1148,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 625
            };

            var e17_p5_e027_gr4_5_session2 = new Session()
            {
                Id = 1149,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 625
            };
            #endregion

            #region e17_p5_e027_gr2_39
            var e17_p5_e027_gr2_39 = new Group()
            {
                Id = 626,
                Name = "GR2",
                SubjectId = 39,
                ClassroomId = 78,
                CalendarId = 1,
            };

            var e17_p5_e027_gr2_39_session1 = new Session()
            {
                Id = 1150,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 626
            };

            #endregion


            //E17/P7/E001
            #region e17_p7_e001_gr1_2_45
            var e17_p7_e001_gr1_2_45 = new Group()
            {
                Id = 627,
                Name = "GR1-2",
                SubjectId = 45,
                ClassroomId = 89,
                CalendarId = 1,
            };

            var e17_p7_e001_gr1_2_45_session1 = new Session()
            {
                Id = 1151,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 627
            };
            #endregion

            #region e17_p7_e001_gr1_3_45

            var e17_p7_e001_gr1_3_45 = new Group()
            {
                Id = 628,
                Name = "GR1-3",
                SubjectId = 45,
                ClassroomId = 89,
                CalendarId = 1,
            };

            var e17_p7_e001_gr1_3_45_session1 = new Session()
            {
                Id = 1152,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 628
            };
            #endregion

            #region e17_p7_e001_gr1_4_45
            var e17_p7_e001_gr1_4_45 = new Group()
            {
                Id = 629,
                Name = "GR1-4",
                SubjectId = 45,
                ClassroomId = 89,
                CalendarId = 1,
            };

            var e17_p7_e001_gr1_4_45_session1 = new Session()
            {
                Id = 1153,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 629
            };
            #endregion

            #region e17_p7_e001_gr1_5_45
            var e17_p7_e001_gr1_5_45 = new Group()
            {
                Id = 630,
                Name = "GR1-5",
                SubjectId = 45,
                ClassroomId = 89,
                CalendarId = 1,
            };

            var e17_p7_e001_gr1_5_45_session1 = new Session()
            {
                Id = 1154,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 630
            };
            #endregion

            #region e17_p7_e001_gr1_129
            var e17_p7_e001_gr1_129 = new Group()
            {
                Id = 631,
                Name = "GR1",
                SubjectId = 129,
                ClassroomId = 89,
                CalendarId = 1,
            };

            var e17_p7_e001_gr1_129_session1 = new Session()
            {
                Id = 1155,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 631
            };
            #endregion

            #region e17_p7_e001_gr2_129
            var e17_p7_e001_gr2_129 = new Group()
            {
                Id = 632,
                Name = "GR2",
                SubjectId = 129,
                ClassroomId = 89,
                CalendarId = 1,
            };

            var e17_p7_e001_gr2_129_session1 = new Session()
            {
                Id = 1156,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 632
            };
            #endregion

            #region e17_p7_e001_gr1_137
            var e17_p7_e001_gr1_137 = new Group()
            {
                Id = 633,
                Name = "GR1",
                SubjectId = 137,
                ClassroomId = 89,
                CalendarId = 1,
            };

            var e17_p7_e001_gr1_137_session1 = new Session()
            {
                Id = 1157,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(8, 0, 0),
                GroupId = 633
            };
            #endregion

            #region e17_p7_e001_gr2_137
            var e17_p7_e001_gr2_137 = new Group()
            {
                Id = 634,
                Name = "GR2",
                SubjectId = 137,
                ClassroomId = 89,
                CalendarId = 1,
            };

            var e17_p7_e001_gr2_137_session1 = new Session()
            {
                Id = 1158,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(10, 0, 0),
                GroupId = 634
            };
            #endregion

            #region e17_p7_e001_gr3_137
            var e17_p7_e001_gr3_137 = new Group()
            {
                Id = 635,
                Name = "GR3",
                SubjectId = 137,
                ClassroomId = 89,
                CalendarId = 1,
            };

            var e17_p7_e001_gr3_137_session1 = new Session()
            {
                Id = 1159,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(15, 0, 0),
                GroupId = 635
            };
            #endregion

            //E17/P7/E002
            #region e17_p7_e002_gr1_140
            var e17_p7_e002_gr1_140 = new Group()
            {
                Id = 636,
                Name = "GR1",
                SubjectId = 140,
                ClassroomId = 90,
                CalendarId = 1,
            };

            var e17_p7_e002_gr1_140_session1 = new Session()
            {
                Id = 1160,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 636
            };
            #endregion

            #region e17_p7_e002_gr1_189
            var e17_p7_e002_gr1_189 = new Group()
            {
                Id = 637,
                Name = "GR1",
                SubjectId = 189,
                ClassroomId = 90,
                CalendarId = 1,
            };

            var e17_p7_e002_gr1_189_session1 = new Session()
            {
                Id = 1161,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 637
            };
            #endregion

            #region e17_p7_e002_gr2_189
            var e17_p7_e002_gr2_189 = new Group()
            {
                Id = 638,
                Name = "GR2",
                SubjectId = 189,
                ClassroomId = 90,
                CalendarId = 1,
            };

            var e17_p7_e002_gr2_189_session1 = new Session()
            {
                Id = 1162,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 638
            };
            #endregion

            #region e17_p7_e002_gr3_189
            var e17_p7_e002_gr3_189 = new Group()
            {
                Id = 639,
                Name = "GR3",
                SubjectId = 189,
                ClassroomId = 90,
                CalendarId = 1,
            };

            var e17_p7_e002_gr3_189_session1 = new Session()
            {
                Id = 1163,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 639
            };
            #endregion

            #region e17_p7_e002_gr4_189
            var e17_p7_e002_gr4_189 = new Group()
            {
                Id = 640,
                Name = "GR4",
                SubjectId = 189,
                ClassroomId = 90,
                CalendarId = 1,
            };

            var e17_p7_e002_gr4_189_session1 = new Session()
            {
                Id = 1164,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 640
            };
            #endregion

            #region e17_p7_e002_gr1_121
            var e17_p7_e002_gr1_121  = new Group()
            {
                Id = 641,
                Name = "GR1",
                SubjectId = 121,
                ClassroomId = 90,
                CalendarId = 1,
            };

            var e17_p7_e002_gr1_121_session1 = new Session()
            {
                Id = 1165,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 641
            };
            #endregion

            #region e17_p7_e002_gr2_121
            var e17_p7_e002_gr2_121 = new Group()
            {
                Id = 642,
                Name = "GR2",
                SubjectId = 121,
                ClassroomId = 90,
                CalendarId = 1,
            };

            var e17_p7_e002_gr2_121_session1 = new Session()
            {
                Id = 1166,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 642
            };
            #endregion

            #region e17_p7_e002_gr3_121
            var e17_p7_e002_gr3_121 = new Group()
            {
                Id = 643,
                Name = "GR3",
                SubjectId = 121,
                ClassroomId = 90,
                CalendarId = 1,
            };

            var e17_p7_e002_gr3_121_session1 = new Session()
            {
                Id = 1167,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 643
            };
            #endregion

            #region e17_p7_e002_gr4_121
            var e17_p7_e002_gr4_121 = new Group()
            {
                Id = 644,
                Name = "GR4",
                SubjectId = 121,
                ClassroomId = 90,
                CalendarId = 1,
            };

            var e17_p7_e002_gr4_121_session1 = new Session()
            {
                Id = 1168,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 644
            };
            #endregion

            #region e17_p7_e002_gr5_121
            var e17_p7_e002_gr5_121 = new Group()
            {
                Id = 645,
                Name = "GR5",
                SubjectId = 121,
                ClassroomId = 90,
                CalendarId = 1,
            };

            var e17_p7_e002_gr5_121_session1 = new Session()
            {
                Id = 1169,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 645
            };
            #endregion

            //E17/P7/E006
            #region e17_p7_e006_gr2_95
            var e17_p7_e006_gr2_95 = new Group()
            {
                Id = 646,
                Name = "GR2",
                SubjectId = 95,
                ClassroomId = 94,
                CalendarId = 1,
            };

            var e17_p7_e006_gr2_95_session1 = new Session()
            {
                Id = 1170,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 646
            };
            #endregion

            #region e17_p7_e006_gr3_95
            var e17_p7_e006_gr3_95 = new Group()
            {
                Id = 647,
                Name = "GR3",
                SubjectId = 95,
                ClassroomId = 94,
                CalendarId = 1,
            };

            var e17_p7_e006_gr3_95_session1 = new Session()
            {
                Id = 1171,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 647
            };
            #endregion

            #region e17_p7_e006_gr4_95
            var e17_p7_e006_gr4_95 = new Group()
            {
                Id = 648,
                Name = "GR4",
                SubjectId = 95,
                ClassroomId = 94,
                CalendarId = 1,
            };

            var e17_p7_e006_gr4_95_session1 = new Session()
            {
                Id = 1172,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 648
            };
            #endregion

            #region e17_p7_e006_gr5_95
            var e17_p7_e006_gr5_95 = new Group()
            {
                Id = 649,
                Name = "GR5",
                SubjectId = 95,
                ClassroomId = 94,
                CalendarId = 1,
            };

            var e17_p7_e006_gr5_95_session1 = new Session()
            {
                Id = 1173,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 649
            };
            #endregion

            #region e17_p7_e006_gr7_95
            var e17_p7_e006_gr7_95 = new Group()
            {
                Id = 650,
                Name = "GR7",
                SubjectId = 95,
                ClassroomId = 94,
                CalendarId = 1,
            };

            var e17_p7_e006_gr7_95_session1 = new Session()
            {
                Id = 1174,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 650
            };
            #endregion

            #region e17_p7_e006_gr1_107
            var e17_p7_e006_gr1_107 = new Group()
            {
                Id = 651,
                Name = "GR1",
                SubjectId = 107,
                ClassroomId = 94,
                CalendarId = 1,
            };

            var e17_p7_e006_gr1_107_session1 = new Session()
            {
                Id = 1175,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(10, 0, 0),
                GroupId = 651
            };
            #endregion

            #region e17_p7_e006_gr2_107
            var e17_p7_e006_gr2_107 = new Group()
            {
                Id = 652,
                Name = "GR2",
                SubjectId = 107,
                ClassroomId = 94,
                CalendarId = 1,
            };

            var e17_p7_e006_gr2_107_session1 = new Session()
            {
                Id = 1176,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(10, 0, 0),
                GroupId = 652
            };
            #endregion

            #region e17_p7_e006_gr3_107
            var e17_p7_e006_gr3_107 = new Group()
            {
                Id = 653,
                Name = "GR3",
                SubjectId = 107,
                ClassroomId = 94,
                CalendarId = 1,
            };

            var e17_p7_e006_gr3_107_session1 = new Session()
            {
                Id = 1177,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(10, 0, 0),
                GroupId = 653
            };
            #endregion

            #region e17_p7_e006_gr4_107
            var e17_p7_e006_gr4_107 = new Group()
            {
                Id = 654,
                Name = "GR4",
                SubjectId = 107,
                ClassroomId = 94,
                CalendarId = 1,
            };

            var e17_p7_e006_gr4_107_session1 = new Session()
            {
                Id = 1178,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(8, 0, 0),
                GroupId = 654
            };
            #endregion

            #region e17_p7_e006_gr5_107
            var e17_p7_e006_gr5_107 = new Group()
            {
                Id = 655,
                Name = "GR5",
                SubjectId = 107,
                ClassroomId = 94,
                CalendarId = 1,
            };

            var e17_p7_e006_gr5_107_session1 = new Session()
            {
                Id = 1179,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(15, 0, 0),
                GroupId = 655
            };
            #endregion

            //E17/PB/E020 

            #region e17_pb_e020_gr1_1
            var e17_pb_e020_gr1_1 = new Group()
            {
                Id = 656,
                Name = "GR1",
                SubjectId = 1,
                ClassroomId = 104,
                CalendarId = 1,
            };

            var e17_pb_e020_gr1_1_session1 = new Session()
            {
                Id = 1180,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 656
            };

            var e17_pb_e020_gr1_1_session2 = new Session()
            {
                Id = 1181,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 656
            };
            #endregion

            #region e17_pb_e020_gr2_1
            var e17_pb_e020_gr2_1 = new Group()
            {
                Id = 657,
                Name = "GR2",
                SubjectId = 1,
                ClassroomId = 104,
                CalendarId = 1,
            };

            var e17_pb_e020_gr2_1_session1 = new Session()
            {
                Id = 1182,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 657
            };

            var e17_pb_e020_gr2_1_session2 = new Session()
            {
                Id = 1183,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 657
            };
            #endregion

            #region e17_pb_e020_gr1_2
            var e17_pb_e020_gr1_2 = new Group()
            {
                Id = 658,
                Name = "GR1",
                SubjectId = 2,
                ClassroomId = 104,
                CalendarId = 1,
            };

            var e17_pb_e020_gr1_2_session1 = new Session()
            {
                Id = 1184,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 658
            };

            var e17_pb_e020_gr1_2_session2 = new Session()
            {
                Id = 1185,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 658
            };
            #endregion

            #region e17_pb_e020_gr2_2
            var e17_pb_e020_gr2_2 = new Group()
            {
                Id = 659,
                Name = "GR2",
                SubjectId = 2,
                ClassroomId = 104,
                CalendarId = 1,
            };

            var e17_pb_e020_gr2_2_session1 = new Session()
            {
                Id = 1186,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 659
            };

            var e17_pb_e020_gr2_2_session2 = new Session()
            {
                Id = 1187,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 659
            };
            #endregion

            #region e17_pb_e020_gr1_3
            var e17_pb_e020_gr1_3 = new Group()
            {
                Id = 660,
                Name = "GR1",
                SubjectId = 3,
                ClassroomId = 104,
                CalendarId = 1,
            };

            var e17_pb_e020_gr1_3_session1 = new Session()
            {
                Id = 1188,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 660
            };

            var e17_pb_e020_gr1_3_session2 = new Session()
            {
                Id = 1189,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 660
            };
            #endregion

            #region e17_pb_e020_gr2_3
            var e17_pb_e020_gr2_3 = new Group()
            {
                Id = 661,
                Name = "GR2",
                SubjectId = 3,
                ClassroomId = 104,
                CalendarId = 1,
            };

            var e17_pb_e020_gr2_3_session1 = new Session()
            {
                Id = 1190,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 661
            };

            var e17_pb_e020_gr2_3_session2 = new Session()
            {
                Id = 1191,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 661
            };
            #endregion

            #region e17_pb_e020_gr1_5
            var e17_pb_e020_gr1_5 = new Group()
            {
                Id = 662,
                Name = "GR1",
                SubjectId = 5,
                ClassroomId = 104,
                CalendarId = 1,
            };

            var e17_pb_e020_gr1_5_session1 = new Session()
            {
                Id = 1192,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 662
            };

            var e17_pb_e020_gr1_5_session2 = new Session()
            {
                Id = 1193,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 662
            };
            #endregion

            #region e17_pb_e020_gr2_5
            var e17_pb_e020_gr2_5 = new Group()
            {
                Id = 663,
                Name = "GR2",
                SubjectId = 5,
                ClassroomId = 104,
                CalendarId = 1,
            };

            var e17_pb_e020_gr2_5_session1 = new Session()
            {
                Id = 1194,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 663
            };

            var e17_pb_e020_gr2_5_session2 = new Session()
            {
                Id = 1195,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 663
            };
            #endregion


            //E17/P6/E004

            #region e17_p6_e004_gr1_1_87
            var e17_p6_e004_gr1_1_87 = new Group()
            {
                Id = 664,
                Name = "GR1-1",
                SubjectId = 87,
                ClassroomId = 83,
                CalendarId = 1,
            };

            var e17_p6_e004_gr1_1_87_session1 = new Session()
            {
                Id = 1196,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 664
            };

            #endregion

            #region e17_p6_e004_gr1_2_87
            var e17_p6_e004_gr1_2_87 = new Group()
            {
                Id = 665,
                Name = "GR1-2",
                SubjectId = 87,
                ClassroomId = 83,
                CalendarId = 1,
            };

            var e17_p6_e004_gr1_2_87_session1 = new Session()
            {
                Id = 1197,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 665
            };
            #endregion

            #region e17_p6_e004_gr1_3_87
            var e17_p6_e004_gr1_3_87 = new Group()
            {
                Id = 666,
                Name = "GR1-3",
                SubjectId = 87,
                ClassroomId = 83,
                CalendarId = 1,
            };

            var e17_p6_e004_gr1_3_87_session1 = new Session()
            {
                Id = 1198,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 666
            };

            #endregion

            #region e17_p6_e004_gr1_4_87
            var e17_p6_e004_gr1_4_87 = new Group()
            {
                Id = 667,
                Name = "GR1-4",
                SubjectId = 87,
                ClassroomId = 83,
                CalendarId = 1,
            };

            var e17_p6_e004_gr1_4_87_session1 = new Session()
            {
                Id = 1199,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 667
            };
            #endregion 

            #region e17_p6_e004_gr1_5_87
            var e17_p6_e004_gr1_5_87 = new Group()
            {
                Id = 668,
                Name = "GR1-5",
                SubjectId = 87,
                ClassroomId = 83,
                CalendarId = 1,
            };

            var e17_p6_e004_gr1_5_87_session1 = new Session()
            {
                Id = 1200,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 668
            };
            #endregion

            #region e17_p6_e004_gr1_51
            var e17_p6_e004_gr1_51 = new Group()
            {
                Id = 669,
                Name = "GR1",
                SubjectId = 51,
                ClassroomId = 83,
                CalendarId = 1,
            };

            var e17_p6_e004_gr1_51_session1 = new Session()
            {
                Id = 1201,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(8, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 669
            };
            #endregion


            ////E17/P6/E022
            #region e17_p6_e022_gr1_42
            var e17_p6_e022_gr1_42 = new Group()
            {
                Id = 670,
                Name = "GR1",
                SubjectId = 42,
                ClassroomId = 84,
                CalendarId = 1,
            };

            var e17_p6_e022_gr1_42_session1 = new Session()
            {
                Id = 1202,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 670
            };

            var e17_p6_e022_gr1_42_session2 = new Session()
            {
                Id = 1203,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(8, 0, 0),
                GroupId = 670
            };

            // Repetir el proceso para los demás grupos y sesiones

            #endregion

            #region e17_p6_e022_gr10_6
            var e17_p6_e022_gr10_6 = new Group()
            {
                Id = 677,
                Name = "GR10",
                SubjectId = 6,
                ClassroomId = 84,
                CalendarId = 1,
            };

            var e17_p6_e022_gr10_6_session1 = new Session()
            {
                Id = 1204,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 677
            };
            #endregion

            #region e17_p6_e022_gr4_6
            var e17_p6_e022_gr4_6 = new Group()
            {
                Id = 678,
                Name = "GR4",
                SubjectId = 6,
                ClassroomId = 84,
                CalendarId = 1,
            };

            var e17_p6_e022_gr4_6_session1 = new Session()
            {
                Id = 1205,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 678
            };
            #endregion

            #region e17_p6_e022_gr7_6
            var e17_p6_e022_gr7_6 = new Group()
            {
                Id = 679,
                Name = "GR7",
                SubjectId = 6,
                ClassroomId = 84,
                CalendarId = 1,
            };

            var e17_p6_e022_gr7_6_session1 = new Session()
            {
                Id = 1206,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 679
            };
            #endregion

            #region e17_p6_e022_gr1_167
            var e17_p6_e022_gr1_167 = new Group()
            {
                Id = 680,
                Name = "GR1",
                SubjectId = 167,
                ClassroomId = 84,
                CalendarId = 1,
            };

            var e17_p6_e022_gr1_167_session1 = new Session()
            {
                Id = 1207,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 680
            };
            #endregion

            #region e17_p6_e022_gr4_12
            var e17_p6_e022_gr4_12 = new Group()
            {
                Id = 681,
                Name = "GR4",
                SubjectId = 12,
                ClassroomId = 84,
                CalendarId = 1,
            };

            var e17_p6_e022_gr4_12_session1 = new Session()
            {
                Id = 1208,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 681
            };

            var e17_p6_e022_gr4_12_session2 = new Session()
            {
                Id = 1209,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(10, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 681
            };
            #endregion

            #region e17_p6_e022_gr1_119
            var e17_p6_e022_gr1_119 = new Group()
            {
                Id = 682,
                Name = "GR1",
                SubjectId = 119,
                ClassroomId = 84,
                CalendarId = 1,
            };

            var e17_p6_e022_gr1_119_session1 = new Session()
            {
                Id = 1210,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 682
            };

            var e17_p6_e022_gr1_119_session2 = new Session()
            {
                Id = 1211,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(15, 0, 0),
                GroupId = 682
            };
            #endregion

            #region e17_p6_e022_gr1_125
            var e17_p6_e022_gr1_125 = new Group()
            {
                Id = 683,
                Name = "GR1",
                SubjectId = 125,
                ClassroomId = 84,
                CalendarId = 1,
            };

            var e17_p6_e022_gr1_125_session1 = new Session()
            {
                Id = 1212,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 683
            };
            #endregion

            #region e17_p6_e022_gr2_125
            var e17_p6_e022_gr2_125 = new Group()
            {
                Id = 684,
                Name = "GR2",
                SubjectId = 125,
                ClassroomId = 84,
                CalendarId = 1,
            };

            var e17_p6_e022_gr2_125_session1 = new Session()
            {
                Id = 1213,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 684
            };
            #endregion

            //E17/P6/E026
            #region e17_p6_e026_gr1_171
            var e17_p6_e026_gr1_171 = new Group()
            {
                Id = 685,
                Name = "GR1",
                SubjectId = 171,
                ClassroomId = 86,
                CalendarId = 1,
            };

            var e17_p6_e026_gr1_171_session1 = new Session()
            {
                Id = 1214,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 685
            };

            var e17_p6_e026_gr1_171_session2 = new Session()
            {
                Id = 1215,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(10, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 685
            };
            #endregion

            #region e17_p6_e026_gr1_6
            var e17_p6_e026_gr1_6 = new Group()
            {
                Id = 686,
                Name = "GR1",
                SubjectId = 6,
                ClassroomId = 86,
                CalendarId = 1,
            };

            var e17_p6_e026_gr1_6_session1 = new Session()
            {
                Id = 1216,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 686
            };
            #endregion

            #region e17_p6_e026_gr8_6
            var e17_p6_e026_gr8_6 = new Group()
            {
                Id = 687,
                Name = "GR8",
                SubjectId = 6,
                ClassroomId = 86,
                CalendarId = 1,
            };

            var e17_p6_e026_gr8_6_session1 = new Session()
            {
                Id = 1217,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 687
            };
            #endregion

            #region e17_p6_e026_gr10_12
            var e17_p6_e026_gr10_12 = new Group()
            {
                Id = 688,
                Name = "GR10",
                SubjectId = 12,
                ClassroomId = 86,
                CalendarId = 1,
            };

            var e17_p6_e026_gr10_12_session1 = new Session()
            {
                Id = 1218,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 688
            };

            var e17_p6_e026_gr10_12_session2 = new Session()
            {
                Id = 1219,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(15, 0, 0),
                GroupId = 688
            };
            #endregion

            #region e17_p6_e026_gr1_112
            var e17_p6_e026_gr1_112 = new Group()
            {
                Id = 689,
                Name = "GR1",
                SubjectId = 112,
                ClassroomId = 86,
                CalendarId = 1,
            };

            var e17_p6_e026_gr1_112_session1 = new Session()
            {
                Id = 1220,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 689
            };

            var e17_p6_e026_gr1_112_session2 = new Session()
            {
                Id = 1221,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(8, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 689
            };
            #endregion

            #region e17_p6_e026_gr1_142
            var e17_p6_e026_gr1_142 = new Group()
            {
                Id = 690,
                Name = "GR1",
                SubjectId = 142,
                ClassroomId = 86,
                CalendarId = 1,
            };

            var e17_p6_e026_gr1_142_session1 = new Session()
            {
                Id = 1222,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 690
            };
            #endregion

            #region e17_p6_e026_gr1_116
            var e17_p6_e026_gr1_116 = new Group()
            {
                Id = 691,
                Name = "GR1",
                SubjectId = 116,
                ClassroomId = 86,
                CalendarId = 1,
            };

            var e17_p6_e026_gr1_116_session1 = new Session()
            {
                Id = 1223,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 691
            };

            var e17_p6_e026_gr1_116_session2 = new Session()
            {
                Id = 1224,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(10, 0, 0),
                GroupId = 691
            };
            #endregion

            #region e17_p6_e026_gr2_116
            var e17_p6_e026_gr2_116 = new Group()
            {
                Id = 692,
                Name = "GR2",
                SubjectId = 116,
                ClassroomId = 86,
                CalendarId = 1,
            };

            var e17_p6_e026_gr2_116_session1 = new Session()
            {
                Id = 1225,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(10, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 692
            };

            var e17_p6_e026_gr2_116_session2 = new Session()
            {
                Id = 1226,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 692
            };
            #endregion


            //E17/P7/E004
            #region e17_p7_e004_gr1_164
            var e17_p7_e004_gr1_164 = new Group()
            {
                Id = 693,
                Name = "GR1",
                SubjectId = 164,
                ClassroomId = 92,
                CalendarId = 1,
            };

            var e17_p7_e004_gr1_164_session1 = new Session()
            {
                Id = 1227,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 693
            };

            var e17_p7_e004_gr1_164_session2 = new Session()
            {
                Id = 1228,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 693
            };
            #endregion

            #region e17_p7_e004_gr1_170
            var e17_p7_e004_gr1_170 = new Group()
            {
                Id = 694,
                Name = "GR1",
                SubjectId = 170,
                ClassroomId = 92,
                CalendarId = 1,
            };

            var e17_p7_e004_gr1_170_session1 = new Session()
            {
                Id = 1229,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 694
            };

            var e17_p7_e004_gr1_170_session2 = new Session()
            {
                Id = 1230,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 694
            };

            var e17_p7_e004_gr1_170_session3 = new Session()
            {
                Id = 1231,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(10, 0, 0),
                GroupId = 694
            };
            #endregion

            #region e17_p7_e004_ay_192
            var e17_p7_e004_ay_192 = new Group()
            {
                Id = 695,
                Name = "AY",
                SubjectId = 192,
                ClassroomId = 92,
                CalendarId = 1,
            };

            var e17_p7_e004_ay_192_session1 = new Session()
            {
                Id = 1232,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 695
            };
            #endregion

            #region e17_p7_e004_gr1_157
            var e17_p7_e004_gr1_157 = new Group()
            {
                Id = 696,
                Name = "GR1",
                SubjectId = 157,
                ClassroomId = 92,
                CalendarId = 1,
            };

            var e17_p7_e004_gr1_157_session1 = new Session()
            {
                Id = 1233,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 696
            };

            var e17_p7_e004_gr1_157_session2 = new Session()
            {
                Id = 1234,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 696
            };
            #endregion

            #region e17_p7_e004_gr1_162
            var e17_p7_e004_gr1_162 = new Group()
            {
                Id = 697,
                Name = "GR1",
                SubjectId = 162,
                ClassroomId = 92,
                CalendarId = 1,
            };

            var e17_p7_e004_gr1_162_session1 = new Session()
            {
                Id = 1235,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 697
            };
            #endregion

            #region e17_p7_e004_gr1_186
            var e17_p7_e004_gr1_186 = new Group()
            {
                Id = 698,
                Name = "GR1",
                SubjectId = 186,
                ClassroomId = 92,
                CalendarId = 1,
            };

            var e17_p7_e004_gr1_186_session1 = new Session()
            {
                Id = 1236,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 698
            };

            var e17_p7_e004_gr1_186_session2 = new Session()
            {
                Id = 1237,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 698
            };
            #endregion

            //E17/P7/E025
            #region e17_p7_e025_gr2_90
            var e17_p7_e025_gr2_90 = new Group()
            {
                Id = 699,
                Name = "GR2",
                SubjectId = 90,
                ClassroomId = 99,
                CalendarId = 1,
            };

            var e17_p7_e025_gr2_90_session1 = new Session()
            {
                Id = 1238,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 699
            };

            var e17_p7_e025_gr2_90_session2 = new Session()
            {
                Id = 1239,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(10, 0, 0),
                GroupId = 699
            };
            #endregion

            #region e17_p7_e025_gr1_96
            var e17_p7_e025_gr1_96 = new Group()
            {
                Id = 700,
                Name = "GR1",
                SubjectId = 96,
                ClassroomId = 99,
                CalendarId = 1,
            };

            var e17_p7_e025_gr1_96_session1 = new Session()
            {
                Id = 1240,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 700
            };
            #endregion

            #region e17_p7_e025_gr1_94
            var e17_p7_e025_gr1_94 = new Group()
            {
                Id = 701,
                Name = "GR1",
                SubjectId = 94,
                ClassroomId = 99,
                CalendarId = 1,
            };

            var e17_p7_e025_gr1_94_session1 = new Session()
            {
                Id = 1241,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 701
            };

            // Puedes repetir este proceso para otras sesiones si es necesario

            #endregion

            #region e17_p7_e025_gr1_74
            var e17_p7_e025_gr1_74 = new Group()
            {
                Id = 702,
                Name = "GR1",
                SubjectId = 74,
                ClassroomId = 99,
                CalendarId = 1,
            };

            var e17_p7_e025_gr1_74_session1 = new Session()
            {
                Id = 1242,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 702
            };

            var e17_p7_e025_gr1_74_session2 = new Session()
            {
                Id = 1243,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 702
            };
            #endregion

            #region e17_p7_e025_gr1_76
            var e17_p7_e025_gr1_76 = new Group()
            {
                Id = 703,
                Name = "GR1",
                SubjectId = 76,
                ClassroomId = 99,
                CalendarId = 1,
            };

            var e17_p7_e025_gr1_76_session1 = new Session()
            {
                Id = 1244,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 703
            };

            var e17_p7_e025_gr1_76_session2 = new Session()
            {
                Id = 1245, // Cambiar el ID para esta sesión
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(10, 0, 0),
                GroupId = 703
            };
            #endregion

            #region e17_p7_e025_gr1_191
            var e17_p7_e025_gr1_191 = new Group()
            {
                Id = 704,
                Name = "GR1",
                SubjectId = 191,
                ClassroomId = 99,
                CalendarId = 1,
            };

            var e17_p7_e025_gr1_191_session1 = new Session()
            {
                Id = 1246,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 704
            };

            #endregion

            #region e17_p7_e025_gr1_138
            var e17_p7_e025_gr1_138 = new Group()
            {
                Id = 705,
                Name = "GR1",
                SubjectId = 138,
                ClassroomId = 99,
                CalendarId = 1,
            };

            var e17_p7_e025_gr1_138_session1 = new Session()
            {
                Id = 1247,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(15, 0, 0),
                GroupId = 705
            };

            var e17_p7_e025_gr1_138_session2 = new Session()
            {
                Id = 1248,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 705
            };

            #endregion

            #region e17_p7_e025_gr1_134
            var e17_p7_e025_gr1_134 = new Group()
            {
                Id = 706,
                Name = "GR1",
                SubjectId = 134,
                ClassroomId = 99,
                CalendarId = 1,
            };

            var e17_p7_e025_gr1_134_session1 = new Session()
            {
                Id = 1249,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 706
            };

            var e17_p7_e025_gr1_134_session2 = new Session()
            {
                Id = 1250,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(10, 0, 0),
                GroupId = 706
            };

            #endregion

            //E17/P7/E026 PROBADO

            #region e17_p7_e026_gr1_166
            var e17_p7_e026_gr1_166 = new Group()
            {
                Id = 707,
                Name = "GR1",
                SubjectId = 166,
                ClassroomId = 100,
                CalendarId = 1,
            };

            var e17_p7_e026_gr1_166_session1 = new Session()
            {
                Id = 1251,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(12, 0, 0),
                GroupId = 707
            };

            var e17_p7_e026_gr1_166_session2 = new Session()
            {
                Id = 1252,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 707
            };

            #endregion

            #region e17_p7_e026_gr1_43
            var e17_p7_e026_gr1_43 = new Group()
            {
                Id = 708,
                Name = "GR1",
                SubjectId = 43,
                ClassroomId = 100,
                CalendarId = 1,
            };

            var e17_p7_e026_gr1_43_session1 = new Session()
            {
                Id = 1253,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(12, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 708
            };

            var e17_p7_e026_gr1_43_session2 = new Session()
            {
                Id = 1254,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 708
            };

            #endregion

            #region e17_p7_e026_gr1_78
            var e17_p7_e026_gr1_78 = new Group()
            {
                Id = 709,
                Name = "GR1",
                SubjectId = 78,
                ClassroomId = 100,
                CalendarId = 1,
            };

            var e17_p7_e026_gr1_78_session1 = new Session()
            {
                Id = 1255,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(10, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 709
            };

            var e17_p7_e026_gr1_78_session2 = new Session()
            {
                Id = 1256,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 709
            };

            #endregion

            #region e17_p7_e026_gr1_122
            var e17_p7_e026_gr1_122 = new Group()
            {
                Id = 710,
                Name = "GR1",
                SubjectId = 122,
                ClassroomId = 100,
                CalendarId = 1,
            };

            var e17_p7_e026_gr1_122_session1 = new Session()
            {
                Id = 1257,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 710
            };

            var e17_p7_e026_gr1_122_session2 = new Session()
            {
                Id = 1258,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(10, 30, 0),
                GroupId = 710
            };

            #endregion

            #region e17_p7_e026_gr1_145
            var e17_p7_e026_gr1_145 = new Group()
            {
                Id = 711,
                Name = "GR1",
                SubjectId = 145,
                ClassroomId = 100,
                CalendarId = 1,
            };

            var e17_p7_e026_gr1_145_session1 = new Session()
            {
                Id = 1259,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(10, 0, 0),
                EndTime = new TimeSpan(11, 30, 0),
                GroupId = 711
            };

            var e17_p7_e026_gr1_145_session2 = new Session()
            {
                Id = 1260,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 711
            };

            #endregion

            #region e17_p7_e026_gr1_143
            var e17_p7_e026_gr1_143 = new Group()
            {
                Id = 712,
                Name = "GR1",
                SubjectId = 143,
                ClassroomId = 100,
                CalendarId = 1,
            };

            var e17_p7_e026_gr1_143_session1 = new Session()
            {
                Id = 1261,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 712
            };

            var e17_p7_e026_gr1_143_session2 = new Session()
            {
                Id = 1262,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(15, 0, 0),
                GroupId = 712
            };

            #endregion

            //E17/P6/E028
            #region e17_p6_e028_gr2_88
            var e17_p6_e028_gr2_88 = new Group()
            {
                Id = 713,
                Name = "GR2",
                SubjectId = 135,
                ClassroomId = 88,
                CalendarId = 1,
            };

            var e17_p6_e028_gr2_88_session1 = new Session()
            {
                Id = 1263,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 713
            };

            #endregion

            //E17/P7/E014
            #region e17_p7_e014_gr2_50
            var e17_p7_e014_gr2_50 = new Group()
            {
                Id = 714,
                Name = "GR2",
                SubjectId = 50,
                ClassroomId = 96,
                CalendarId = 1,
            };

            var e17_p7_e014_gr2_50_session1 = new Session()
            {
                Id = 1264,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(12, 0, 0),
                GroupId = 714
            };

            #endregion

            //E17/P7/E015
            #region e17_p7_e015_gr2_133
            var e17_p7_e015_gr2_133 = new Group()
            {
                Id = 715,
                Name = "GR2",
                SubjectId = 133,
                ClassroomId = 97,
                CalendarId = 1,
            };

            var e17_p7_e015_gr2_133_session1 = new Session()
            {
                Id = 1265,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 715
            };
            #endregion

            #region e17_p7_e015_gr3_133
            var e17_p7_e015_gr3_133 = new Group()
            {
                Id = 716,
                Name = "GR3",
                SubjectId = 133,
                ClassroomId = 97,
                CalendarId = 1,
            };

            var e17_p7_e015_gr3_133_session1 = new Session()
            {
                Id = 1267,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 716
            };
            #endregion

            #region e17_p7_e015_gr2_144
            var e17_p7_e015_gr2_144 = new Group()
            {
                Id = 717,
                Name = "GR2",
                SubjectId = 144,
                ClassroomId = 97,
                CalendarId = 1,
            };

            var e17_p7_e015_gr2_144_session1 = new Session()
            {
                Id = 1268,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(10, 0, 0),
                GroupId = 717
            };
            #endregion

            #region e17_p7_e015_gr3_144
            var e17_p7_e015_gr3_144 = new Group()
            {
                Id = 718,
                Name = "GR3",
                SubjectId = 144,
                ClassroomId = 97,
                CalendarId = 1,
            };

            var e17_p7_e015_gr3_144_session1 = new Session()
            {
                Id = 1269,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(15, 0, 0),
                GroupId = 718
            };
            #endregion

            #region e17_p7_e015_gr4_144
            var e17_p7_e015_gr4_144 = new Group()
            {
                Id = 719,
                Name = "GR4",
                SubjectId = 144,
                ClassroomId = 97,
                CalendarId = 1,
            };

            var e17_p7_e015_gr4_144_session1 = new Session()
            {
                Id = 1270,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(8, 0, 0),
                GroupId = 719
            };
            #endregion

            //E17/P7/E024
            #region e17_p7_e024_gr1_174
            var e17_p7_e024_gr1_174 = new Group()
            {
                Id = 720,
                Name = "GR1",
                SubjectId = 174,
                ClassroomId = 98,
                CalendarId = 1,
            };

            var e17_p7_e024_gr1_174_session1 = new Session()
            {
                Id = 1271,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 720
            };

            var e17_p7_e024_gr1_174_session2 = new Session()
            {
                Id = 1272,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 720
            };

            #endregion

            #region e17_p7_e024_gr1_106
            var e17_p7_e024_gr1_106 = new Group()
            {
                Id = 721,
                Name = "GR1",
                SubjectId = 106,
                ClassroomId = 98,
                CalendarId = 1,
            };

            var e17_p7_e024_gr1_106_session1 = new Session()
            {
                Id = 1273,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 721
            };
            #endregion

            #region e17_p7_e024_gr2_191
            var e17_p7_e024_gr2_191 = new Group()
            {
                Id = 722,
                Name = "GR1",
                SubjectId = 191,
                ClassroomId = 98,
                CalendarId = 1,
            };

            var e17_p7_e024_gr2_191_session1 = new Session()
            {
                Id = 1274,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 722
            };
            #endregion

            #region e17_p7_e024_gr1_132
            var e17_p7_e024_gr1_132 = new Group()
            {
                Id = 723,
                Name = "GR1",
                SubjectId = 132,
                ClassroomId = 98,
                CalendarId = 1,
            };

            var e17_p7_e024_gr1_132_session1 = new Session()
            {
                Id = 1275,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 722
            };

            var e17_p7_e024_gr1_132_session2 = new Session()
            {
                Id = 1276,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(8, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 722
            };
            #endregion

            #region e17_p7_e024_gr2_139
            var e17_p7_e024_gr2_139 = new Group()
            {
                Id = 724,
                Name = "GR1",
                SubjectId = 139,
                ClassroomId = 98,
                CalendarId = 1,
            };

            var e17_p7_e024_gr2_139_session1 = new Session()
            {
                Id = 1277,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(10, 0, 0),
                GroupId = 723
            };

            var e17_p7_e024_gr2_139_session2 = new Session()
            {
                Id = 1278,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 723
            };
            #endregion

            //E17/P8/E002
            #region e17_p8_e002_gr1_131
            var e17_p8_e002_gr1_131 = new Group()
            {
                Id = 725,
                Name = "GR1",
                SubjectId = 131,
                ClassroomId = 101,
                CalendarId = 1,
            };

            var e17_p8_e002_gr1_131_session1 = new Session()
            {
                Id = 1279,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 723
            };
            #endregion

            #region e17_p8_e002_gr2_131
            var e17_p8_e002_gr2_131 = new Group()
            {
                Id = 726,
                Name = "GR2",
                SubjectId = 131,
                ClassroomId = 101,
                CalendarId = 1,
            };

            var e17_p8_e002_gr2_131_session1 = new Session()
            {
                Id = 1280,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 724
            };
            #endregion

            #region e17_p8_e002_gr3_131
            var e17_p8_e002_gr3_131 = new Group()
            {
                Id = 727,
                Name = "GR3",
                SubjectId = 131,
                ClassroomId = 101,
                CalendarId = 1,
            };

            var e17_p8_e002_gr3_131_session1 = new Session()
            {
                Id = 1281,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 725
            };
            #endregion

            #region e17_p8_e002_gr4_131
            var e17_p8_e002_gr4_131 = new Group()
            {
                Id = 728,
                Name = "GR4",
                SubjectId = 131,
                ClassroomId = 101,
                CalendarId = 1,
            };
          
            var e17_p8_e002_gr4_131_session1 = new Session()
            {
                Id = 1282,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 726
            };
            #endregion

            //E17/PB/E023
            #region e17_pb_e023_gr1_102
            var e17_pb_e023_gr1_102 = new Group()
            {
                Id = 729,
                Name = "GR1",
                SubjectId = 102,
                ClassroomId = 105,
                CalendarId = 1,
            };

            var e17_pb_e023_gr1_102_session1 = new Session()
            {
                Id = 1283,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 726
            };
            #endregion

            #region e17_pb_e023_gr2_102
            var e17_pb_e023_gr2_102 = new Group()
            {
                Id = 730,
                Name = "GR2",
                SubjectId = 102,
                ClassroomId = 105,
                CalendarId = 1,
            };

            var e17_pb_e023_gr2_102_session1 = new Session()
            {
                Id = 1284,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 727
            };
            #endregion

            #region e17_pb_e023_gr3_102
            var e17_pb_e023_gr3_102 = new Group()
            {
                Id = 731,
                Name = "GR3",
                SubjectId = 102,
                ClassroomId = 105,
                CalendarId = 1,
            };

            var e17_pb_e023_gr3_102_session1 = new Session()
            {
                Id = 1285,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 728
            };
            #endregion

            modelBuilder
                .Entity<Group>()
                .HasData(
                 #region GRUPOS EDIFICIO 16
                
                //AULA E16/P1/E006A
                //LAB. ELECTROTECNIA
                e16_p1_e006a_gr1_1_15, e16_p1_e006a_gr1_2_15, e16_p1_e006a_gr1_3_15, e16_p1_e006a_gr1_4_15, e16_p1_e006a_gr3_1_15, e16_p1_e006a_gr3_3_15, e16_p1_e006a_gr3_4_15, e16_p1_e006a_gr3_5_15, e16_p1_e006a_gr5_2_15, e16_p1_e006a_gr5_3_15, e16_p1_e006a_gr5_4_15, e16_p1_e006a_gr5_5_15,
                //LAB. FUNDAMENTOS DE CIRCUITOS
                e16_p1_e006a_gr1_5_23, e16_p1_e006a_gr4_2_23, e16_p1_e006a_gr4_4_23, e16_p1_e006a_gr5_1_23,
                //AULA E16/P1/E006B
                //LAB. ELECTROTECNIA
                e16_p1_e006b_gr2_1_15, e16_p1_e006b_gr2_2_15, e16_p1_e006b_gr2_3_15, e16_p1_e006b_gr2_5_15,
                //LAB. FUNDAMENTOS DE CIRCUITOS
                e16_p1_e006b_gr4_5_23,
                //AULA E16/P1/E007A
                //LAB. FUNDAMENTOS DE CIRCUITOS
                e16_p1_e007a_gr1_1_23, e16_p1_e007a_gr1_4_23, e16_p1_e007a_gr2_3_23, e16_p1_e007a_gr3_1_23, e16_p1_e007a_gr3_2_23, e16_p1_e007a_gr3_3_23, e16_p1_e007a_gr4_3_23, e16_p1_e007a_gr5_2_23, e16_p1_e007a_gr5_3_23,
                //LAB. ANALISIS DE CIRCUITOS
                e16_p1_e007a_gr1_1_32, e16_p1_e007a_gr1_2_32, e16_p1_e007a_gr1_3_32, e16_p1_e007a_gr1_4_32, e16_p1_e007a_gr2_2_32, e16_p1_e007a_gr2_3_32, e16_p1_e007a_gr2_4_32,
                //AULA E16/P1/E007B
                //LAB. FUNDAMENTOS DE CIRCUITOS
                e16_p1_e007b_gr1_3_23, e16_p1_e007b_gr2_2_23, e16_p1_e007b_gr2_4_23, e16_p1_e007b_gr3_4_23, e16_p1_e007b_gr5_4_23,
                //DISEÑO DE TIC
                e16_p1_e007b_gr3_50,
                //AULA E16/P1/E013
                //LAB. ELECTRONICA DE RADIOFRECUENCIA
                e16_p1_e013_gr1, e16_p1_e013_gr2, e16_p1_e013_gr3,
                //AULA E16/P1/E018
                //LAB. DISPOSITIVOS ELECTRONICOS
                e16_p1_e018_gr1_3, e16_p1_e018_gr1_4, e16_p1_e018_gr1_5, e16_p1_e018_gr3_1, e16_p1_e018_gr3_3, e16_p1_e018_gr3_4,
                //LAB. DISPOSITIVOS CIRCUITOS ELECTRONICOS
                e16_p1_e018_gr1_2_28, e16_p1_e018_gr1_3_28, e16_p1_e018_gr1_4_28, e16_p1_e018_gr3_2_28, e16_p1_e018_gr3_4_28,
                //AULA E16/P1/E019
                //LAB. DISPOSITIVOS ELECTRONICOS
                e16_p1_e019_gr5_3_20, e16_p1_e019_gr5_2_20, e16_p1_e019_gr5_1_20, e16_p1_e019_gr4_3_20, e16_p1_e019_gr4_2_20, e16_p1_e019_gr4_1_20, e16_p1_e019_gr2_4_20, e16_p1_e019_gr2_3_20, e16_p1_e019_gr2_1_20,
                //LAB. DISPOSITIVOS ELECTRONICOS
                e16_p1_e019_gr4_4_28, e16_p1_e019_gr4_1_28, e16_p1_e019_gr2_4_28, e16_p1_e019_gr2_2_28,
                //E16/P1/E020
                //LAB. CIRCUITOS ELECTRONICOS 20
                e16_p1_e020_gr4_3_28, e16_p1_e020_gr4_2_28, e16_p1_e020_gr3_1_28, e16_p1_e020_gr2_3_28,
                //E16/P1/E021 -- VER
                e16_p1_e021_gr1_179, e16_p1_e021_gr1_124, e16_p1_e021_gr1_147, e16_p1_e021_gr1_73, e16_p1_e021_gr1_54, e16_p1_e021_gr1_39, e16_p1_e021_gr2_21, e16_p1_e021_gr1_190, e16_p1_e021_gr1_161, e16_p1_e021_gr2_158,
                //E16/P2/E001
                //LAB. TRANSIMISION DIGITAL
                e16_p2_e001_gr3_156, e16_p2_e001_gr2_156, e16_p2_e001_gr1_156,
                //LAB. COMUNICACION DIGITAL
                e16_p2_e001_gr2_123, e16_p2_e001_gr1_123,
                //LAB. FUNDAMENTOS DE COMUNICACION
                e16_p2_e001_gr3_118, e16_p2_e001_gr2_118, e16_p2_e001_gr1_118,
                //E16/P2/E002
                e16_p2_e002_gr1_165, e16_p2_e002_gr2_153, e16_p2_e002_gr1_160, e16_p2_e002_gr1_175, e16_p2_e002_gr1_169, e16_p2_e002_gr1_168, e16_p2_e002_gr1_154,
                //E16/P2/E003
                e16_p2_e003_gr1_159, e16_p2_e003_gr1_175, e16_p2_e003_gr1_168, e16_p2_e003_gr1_163,
                //E16/P2/E004
                //LAB. SISTEMAS DIGITALES
                e16_p2_e004_gr1_1_18, e16_p2_e004_gr1_2_18, e16_p2_e004_gr1_3_18, e16_p2_e004_gr1_4_18, e16_p2_e004_gr3_1_18, e16_p2_e004_gr3_2_18, e16_p2_e004_gr3_3_18, e16_p2_e004_gr3_4_18, e16_p2_e004_gr4_1_18, e16_p2_e004_gr4_2_18, e16_p2_e004_gr4_3_18, e16_p2_e004_gr4_4_18,
            #endregion
                 #region GRUPOS EDIFICIO 17
                //E17/P5/E027
                e17_p5_e027_gr3_1, e17_p5_e027_gr4_1, e17_p5_e027_gr3_2, e17_p5_e027_gr1_184, e17_p5_e027_gr4_48, e17_p5_e027_gr3_3, e17_p5_e027_gr4_3, e17_p5_e027_gr1_9,
                e17_p5_e027_gr3_5, e17_p5_e027_gr4_5, e17_p5_e027_gr2_39,
                //E17/P7/E001
                e17_p7_e001_gr1_2_45, e17_p7_e001_gr1_3_45, e17_p7_e001_gr1_4_45, e17_p7_e001_gr1_5_45, e17_p7_e001_gr1_129, e17_p7_e001_gr2_129, e17_p7_e001_gr1_137,
                e17_p7_e001_gr2_137, e17_p7_e001_gr3_137,
                //E17/P7/E002
                e17_p7_e002_gr1_140, e17_p7_e002_gr1_189, e17_p7_e002_gr2_189, e17_p7_e002_gr3_189, e17_p7_e002_gr4_189, e17_p7_e002_gr1_121, e17_p7_e002_gr2_121,
                e17_p7_e002_gr3_121, e17_p7_e002_gr4_121, e17_p7_e002_gr5_121,
                //E17/P7/E006
                e17_p7_e006_gr2_95, e17_p7_e006_gr3_95, e17_p7_e006_gr4_95, e17_p7_e006_gr5_95, e17_p7_e006_gr7_95, e17_p7_e006_gr1_107, e17_p7_e006_gr2_107,
                e17_p7_e006_gr3_107, e17_p7_e006_gr4_107, e17_p7_e006_gr5_107,
                //E17/PB/E020
                e17_pb_e020_gr1_1, e17_pb_e020_gr2_1, e17_pb_e020_gr1_2, e17_pb_e020_gr2_2, e17_pb_e020_gr1_3, e17_pb_e020_gr2_3, e17_pb_e020_gr1_5, e17_pb_e020_gr2_5,
                //E17/P6/E004
                e17_p6_e004_gr1_1_87, e17_p6_e004_gr1_2_87, e17_p6_e004_gr1_3_87, e17_p6_e004_gr1_4_87, e17_p6_e004_gr1_5_87, e17_p6_e004_gr1_51,
                //E17/P6/E022
                e17_p6_e022_gr1_42, e17_p6_e022_gr10_6, e17_p6_e022_gr4_6, e17_p6_e022_gr7_6, e17_p6_e022_gr1_167, e17_p6_e022_gr4_12, e17_p6_e022_gr1_119,
                e17_p6_e022_gr1_125, e17_p6_e022_gr2_125,
                //E17/P6/E026
                e17_p6_e026_gr1_171, e17_p6_e026_gr1_6, e17_p6_e026_gr8_6, e17_p6_e026_gr10_12, e17_p6_e026_gr1_112, e17_p6_e026_gr1_142, e17_p6_e026_gr1_116,
                e17_p6_e026_gr2_116,
                //E17/P7/E004
                e17_p7_e004_gr1_164, e17_p7_e004_gr1_170, e17_p7_e004_ay_192, e17_p7_e004_gr1_157, e17_p7_e004_gr1_162, e17_p7_e004_gr1_186,
                //E17/P7/E025
                e17_p7_e025_gr2_90, e17_p7_e025_gr1_96, e17_p7_e025_gr1_94, e17_p7_e025_gr1_74, e17_p7_e025_gr1_76, e17_p7_e025_gr1_191, e17_p7_e025_gr1_138,
                e17_p7_e025_gr1_134,

                //E17/P7/E026
                e17_p7_e026_gr1_166, e17_p7_e026_gr1_43, e17_p7_e026_gr1_78, e17_p7_e026_gr1_122, e17_p7_e026_gr1_145, e17_p7_e026_gr1_143,
                //E17/P7/E028
                e17_p6_e028_gr2_88,
                //E17/P7/E014
                e17_p7_e014_gr2_50,
                //E17/P7/E015
                e17_p7_e015_gr2_133, e17_p7_e015_gr3_133, e17_p7_e015_gr2_144, e17_p7_e015_gr3_144, e17_p7_e015_gr4_144,
                //E17/P8/E024
                e17_p7_e024_gr1_174, e17_p7_e024_gr1_106, e17_p7_e024_gr2_191, e17_p7_e024_gr1_132, e17_p7_e024_gr2_139,
                //E17/P8/E002
                e17_p8_e002_gr1_131, e17_p8_e002_gr2_131, e17_p8_e002_gr3_131, e17_p8_e002_gr4_131,
                //E17/PB/E023
                e17_pb_e023_gr1_102, e17_pb_e023_gr2_102, e17_pb_e023_gr3_102
            #endregion
                );

            modelBuilder
             .Entity<Session>()
             .HasData(
            //E16
            #region E16/P1/E006A - LAB. ELECTROTECNIA
                //e16_p1_e006a_gr1_1_15
                e16_p1_e006a_gr1_1_15_session1,
                //e16_p1_e006a_gr1_2_15
                e16_p1_e006a_gr1_2_15_session1,
                //e16_p1_e006a_gr1_3_15
                e16_p1_e006a_gr1_3_15_session1,
                //e16_p1_e006a_gr1_4_15
                e16_p1_e006a_gr1_4_15_session1,
                //e16_p1_e006a_gr3_1_15
                e16_p1_e006a_gr3_1_15_session1,
                //e16_p1_e006a_gr3_3_15
                e16_p1_e006a_gr3_3_15_session1,
                //e16_p1_e006a_gr3_4_15
                e16_p1_e006a_gr3_4_15_session1,
                //e16_p1_e006a_gr3_5_15
                e16_p1_e006a_gr3_5_15_session1,
                //e16_p1_e006a_gr5_2_15
                e16_p1_e006a_gr5_2_15_session1,
                //e16_p1_e006a_gr5_3_15
                e16_p1_e006a_gr5_3_15_session1,
                //e16_p1_e006a_gr5_4_15
                e16_p1_e006a_gr5_4_15_session1,
                //e16_p1_e006a_gr5_5_15
                e16_p1_e006a_gr5_5_15_session1,
            #endregion
            #region E16/P1/E006A - FUNDAMENTOS DE CIRCUITOS
                //e16_p1_e006a_gr1_5_23
                e16_p1_e006a_gr1_5_23_session1,
                //e16_p1_e006a_gr4_2_23
                e16_p1_e006a_gr4_2_23_session1,
                //e16_p1_e006a_gr4_4_23
                e16_p1_e006a_gr4_4_23_session1,
                //e16_p1_e006a_gr5_1_23,
                e16_p1_e006a_gr5_1_23_session1,

            #endregion
            #region E16/P1/E006B - LAB. ELECTROTECNIA
                //e16_p1_e006b_gr2_1_15
                e16_p1_e006b_gr2_1_15_session1,
                //e16_p1_e006b_gr2_2_15
                e16_p1_e006b_gr2_2_15_session1,
                //e16_p1_e006b_gr2_3_15
                e16_p1_e006b_gr2_3_15_session1,
                //e16_p1_e006b_gr2_5_15
                e16_p1_e006b_gr2_5_15_session1,
            #endregion
            #region E16/P1/E006B - LAB. FUNDAMENTOS DE CIRCUITOS
                //e16_p1_e006b_gr4_5_23
                e16_p1_e006b_gr4_5_23_session1,
            #endregion
            #region E16/P1/E007A LAB. FUNDAMENTOS DE CIRCUITOS 
                e16_p1_e007a_gr1_1_23_session1,
                e16_p1_e007a_gr1_4_23_session1,
                e16_p1_e007a_gr2_3_23_session1,
                e16_p1_e007a_gr3_1_23_session1,
                e16_p1_e007a_gr3_2_23_session1,
                e16_p1_e007a_gr3_3_23_session1,
                e16_p1_e007a_gr4_3_23_session1,
                e16_p1_e007a_gr5_2_23_session1,
                e16_p1_e007a_gr5_3_23_session1,
            #endregion
            #region E16/P1/E007A LAB. ANALISIS DE CIRCUITOS
                e16_p1_e007a_gr1_1_32_session1,
                e16_p1_e007a_gr1_2_32_session1,
                e16_p1_e007a_gr1_3_32_session1,
                e16_p1_e007a_gr1_4_32_session1,
                e16_p1_e007a_gr2_2_32_session1,
                e16_p1_e007a_gr2_3_32_session1,
                e16_p1_e007a_gr2_4_32_session1,
            #endregion
            #region E16/P1/E007B LAB. FUNDAMENTOS DE CIRCUITOS
                e16_p1_e007b_gr1_3_23_session1,
                e16_p1_e007b_gr2_2_23_session1,
                e16_p1_e007b_gr2_4_23_session1,
                e16_p1_e007b_gr3_4_23_session1,
                e16_p1_e007b_gr5_4_23_session1,
            #endregion
            #region E16/P1/E007B - DISEÑO TIC
                e16_p1_e007b_gr3_50_session1,
            #endregion
            #region E16/P1/E013 - LAB. ELECTRONICA DE RADIOFRECUENCIA
                e16_p1_e013_gr1_session1,
                e16_p1_e013_gr2_session1,
                e16_p1_e013_gr3_session1,
            #endregion
            #region E16/P1/E018 - LAB. DISPOSITIVOS ELECTÓNICOS
                e16_p1_e018_gr1_3_session1,
                e16_p1_e018_gr1_4_session1,
                e16_p1_e018_gr1_5_session1,
                e16_p1_e018_gr3_1_session1,
                e16_p1_e018_gr3_3_session1,
                e16_p1_e018_gr3_4_session1,
            #endregion
            #region E16/P1/E018 - LAB. CIRCUITOS ELECTRONICOS
                e16_p1_e018_gr1_2_28_session1,
                e16_p1_e018_gr1_3_28_session1,
                e16_p1_e018_gr1_4_28_session1,
                e16_p1_e018_gr3_2_28_session1,
                e16_p1_e018_gr3_4_28_session1,
            #endregion
            #region E16/P1/E019 - LAB. DISPOSITIVOS ELECTRONICOS
                e16_p1_e019_gr5_3_20_session1,
                e16_p1_e019_gr5_2_20_session1,
                e16_p1_e019_gr5_1_20_session1,
                e16_p1_e019_gr4_3_20_session1,
                e16_p1_e019_gr4_2_20_session1,
                e16_p1_e019_gr4_1_20_session1,
                e16_p1_e019_gr2_4_20_session1,
                e16_p1_e019_gr2_3_20_session1,
                e16_p1_e019_gr2_1_20_session1,
            #endregion
            #region E16/P1/E019 - LAB. CIRCUITOS ELECTRONICOS
                e16_p1_e019_gr4_4_28_session1,
                e16_p1_e019_gr4_1_28_session1,
                e16_p1_e019_gr2_4_28_session1,
                e16_p1_e019_gr2_2_28_session1,
            #endregion
            #region E16/P1/E020 - LAB. CIRCUITOS ELECTRONICOS
                e16_p1_e020_gr4_3_28_session1,
                e16_p1_e020_gr4_2_28_session1,
                e16_p1_e020_gr3_1_28_session1,
                e16_p1_e020_gr2_3_28_session1,
            #endregion
            #region E16/P1/E021
                e16_p1_e021_gr1_179_session1, e16_p1_e021_gr1_179_session2,
                e16_p1_e021_gr1_124_session1, e16_p1_e021_gr1_124_session2,
                e16_p1_e021_gr1_147_session1, e16_p1_e021_gr1_147_session2,
                e16_p1_e021_gr1_73_session1, e16_p1_e021_gr1_73_session2,
                e16_p1_e021_gr1_54_session1, e16_p1_e021_gr1_54_session2,
                e16_p1_e021_gr1_39_session1,
                e16_p1_e021_gr2_21_session1, e16_p1_e021_gr2_21_session2,
                e16_p1_e021_gr1_190_session1,
                e16_p1_e021_gr1_161_session1,
                e16_p1_e021_gr2_158_session1, e16_p1_e021_gr2_158_session2,
            #endregion
            #region E16/P2/E001 - LAB. TRANSIMISION DIGITAL
                e16_p2_e001_gr3_156_session1,
                e16_p2_e001_gr2_156_session1, e16_p2_e001_gr2_156_session2,
                e16_p2_e001_gr1_156_session1, e16_p2_e001_gr1_156_session2,
            #endregion
            #region E16/P2/E001 - LAB. COMUNICACION DIGITAL
                e16_p2_e001_gr2_123_session1,
                e16_p2_e001_gr1_123_session1,
            #endregion
            #region E16/P2/E001 - LAB. FUNDAMENTOS DE COMUNICACIONES
                e16_p2_e001_gr3_118_session1,
                e16_p2_e001_gr2_118_session1,
                e16_p2_e001_gr1_118_session1,
            #endregion
            #region E16/P2/E002
                e16_p2_e002_gr1_165_session1, e16_p2_e002_gr1_165_session2,
                e16_p2_e002_gr2_153_session1, e16_p2_e002_gr2_153_session2,
                e16_p2_e002_gr1_160_session1,
                e16_p2_e002_gr1_175_session1,
                e16_p2_e002_gr1_169_session1, e16_p2_e002_gr1_169_session2,
                e16_p2_e002_gr1_168_session1,
                e16_p2_e002_gr1_154_session1, e16_p2_e002_gr1_154_session2, e16_p2_e002_gr1_154_session3,
            #endregion
            #region E16/P2/E003
                e16_p2_e003_gr1_159_session1, e16_p2_e003_gr1_159_session2,
                e16_p2_e003_gr1_175_session1,
                e16_p2_e003_gr1_168_session1,
                e16_p2_e003_gr1_163_session1, e16_p2_e003_gr1_163_session2,
            #endregion
            #region E16/P2/E004 - LAB. SISTEMAS DIGITALES
                e16_p2_e004_gr1_1_18_session1,
                e16_p2_e004_gr1_2_18_session1,
                e16_p2_e004_gr1_3_18_session1,
                e16_p2_e004_gr1_4_18_session1,
                e16_p2_e004_gr3_1_18_session1,
                e16_p2_e004_gr3_2_18_session1,
                e16_p2_e004_gr3_3_18_session1,
                e16_p2_e004_gr3_4_18_session1,
                e16_p2_e004_gr4_1_18_session1,
                e16_p2_e004_gr4_2_18_session1,
                e16_p2_e004_gr4_3_18_session1,
                e16_p2_e004_gr4_4_18_session1,
            #endregion
            //E17
            #region E17/P5/E027
                e17_p5_e027_gr3_1_session1, e17_p5_e027_gr3_1_session2,
                e17_p5_e027_gr4_1_session1, e17_p5_e027_gr4_1_session2,
                e17_p5_e027_gr3_2_session1, e17_p5_e027_gr3_2_session2,
                e17_p5_e027_gr1_184_session1,
                e17_p5_e027_gr4_48_session1,
                e17_p5_e027_gr3_3_session1, e17_p5_e027_gr3_3_session2,
                e17_p5_e027_gr4_3_session1, e17_p5_e027_gr4_3_session2,
                e17_p5_e027_gr1_9_session1, e17_p5_e027_gr1_9_session2,
                e17_p5_e027_gr3_5_session1, e17_p5_e027_gr3_5_session2,
                e17_p5_e027_gr4_5_session1, e17_p5_e027_gr4_5_session2,
                e17_p5_e027_gr2_39_session1,
            #endregion
            #region E17/P7/E001
                e17_p7_e001_gr1_2_45_session1,
                e17_p7_e001_gr1_3_45_session1,
                e17_p7_e001_gr1_4_45_session1,
                e17_p7_e001_gr1_5_45_session1,
                e17_p7_e001_gr1_129_session1,
                e17_p7_e001_gr2_129_session1,
                e17_p7_e001_gr1_137_session1,
                e17_p7_e001_gr2_137_session1,
                e17_p7_e001_gr3_137_session1,
            #endregion
            #region E17/P7/E002
                e17_p7_e002_gr1_140_session1,
                e17_p7_e002_gr1_189_session1,
                e17_p7_e002_gr2_189_session1,
                e17_p7_e002_gr3_189_session1,
                e17_p7_e002_gr4_189_session1,
                e17_p7_e002_gr1_121_session1,
                e17_p7_e002_gr2_121_session1,
                e17_p7_e002_gr3_121_session1,
                e17_p7_e002_gr4_121_session1,
                e17_p7_e002_gr5_121_session1,
            #endregion
            #region E17/P7/E006
                e17_p7_e006_gr2_95_session1,
                e17_p7_e006_gr3_95_session1,
                e17_p7_e006_gr4_95_session1,
                e17_p7_e006_gr5_95_session1,
                e17_p7_e006_gr7_95_session1,
                e17_p7_e006_gr1_107_session1,
                e17_p7_e006_gr2_107_session1,
                e17_p7_e006_gr3_107_session1,
                e17_p7_e006_gr4_107_session1,
                e17_p7_e006_gr5_107_session1,
            #endregion
            #region E17/PB/E020
                e17_pb_e020_gr1_1_session1, e17_pb_e020_gr1_1_session2,
                e17_pb_e020_gr2_1_session1, e17_pb_e020_gr2_1_session2,
                e17_pb_e020_gr1_2_session1, e17_pb_e020_gr1_2_session2,
                e17_pb_e020_gr2_2_session1, e17_pb_e020_gr2_2_session2,
                e17_pb_e020_gr1_3_session1, e17_pb_e020_gr1_3_session2,
                e17_pb_e020_gr2_3_session1, e17_pb_e020_gr2_3_session2,
                e17_pb_e020_gr1_5_session1, e17_pb_e020_gr1_5_session2,
                e17_pb_e020_gr2_5_session1, e17_pb_e020_gr2_5_session2,
            #endregion
            #region E17/P6/E004
                e17_p6_e004_gr1_1_87_session1,
                e17_p6_e004_gr1_2_87_session1,
                e17_p6_e004_gr1_3_87_session1,
                e17_p6_e004_gr1_4_87_session1,
                e17_p6_e004_gr1_5_87_session1,
                e17_p6_e004_gr1_51_session1,
            #endregion
            #region E17/P6/E022
                e17_p6_e022_gr1_42_session1, e17_p6_e022_gr1_42_session2,
                e17_p6_e022_gr10_6_session1,
                e17_p6_e022_gr4_6_session1,
                e17_p6_e022_gr7_6_session1,
                e17_p6_e022_gr1_167_session1,
                e17_p6_e022_gr4_12_session1, e17_p6_e022_gr4_12_session2,
                e17_p6_e022_gr1_119_session1, e17_p6_e022_gr1_119_session2,
                e17_p6_e022_gr1_125_session1,
                e17_p6_e022_gr2_125_session1,
            #endregion
            #region E17/P6/E026
                e17_p6_e026_gr1_171_session1, e17_p6_e026_gr1_171_session2,
                e17_p6_e026_gr1_6_session1,
                e17_p6_e026_gr8_6_session1,
                e17_p6_e026_gr10_12_session1, e17_p6_e026_gr10_12_session2,
                e17_p6_e026_gr1_112_session1, e17_p6_e026_gr1_112_session2,
                e17_p6_e026_gr1_142_session1,
                e17_p6_e026_gr1_116_session1, e17_p6_e026_gr1_116_session2,
                e17_p6_e026_gr2_116_session1, e17_p6_e026_gr2_116_session2,
            #endregion
            #region E17/P7/E004
                e17_p7_e004_gr1_164_session1, e17_p7_e004_gr1_164_session2,
                e17_p7_e004_gr1_170_session1, e17_p7_e004_gr1_170_session2, e17_p7_e004_gr1_170_session3,
                e17_p7_e004_ay_192_session1,
                e17_p7_e004_gr1_157_session1, e17_p7_e004_gr1_157_session2,
                e17_p7_e004_gr1_162_session1,
                e17_p7_e004_gr1_186_session1, e17_p7_e004_gr1_186_session2,
            #endregion
            #region E17/P7/E025
                e17_p7_e025_gr2_90_session1, e17_p7_e025_gr2_90_session2,
                e17_p7_e025_gr1_96_session1,
                e17_p7_e025_gr1_94_session1,
                e17_p7_e025_gr1_74_session1, e17_p7_e025_gr1_74_session2,
                e17_p7_e025_gr1_76_session1, e17_p7_e025_gr1_76_session2,
                e17_p7_e025_gr1_191_session1,
                e17_p7_e025_gr1_138_session1, e17_p7_e025_gr1_138_session2,
                e17_p7_e025_gr1_134_session1, e17_p7_e025_gr1_134_session2,
            #endregion
            #region E17/P7/E026
                e17_p7_e026_gr1_166_session1, e17_p7_e026_gr1_166_session2,
                e17_p7_e026_gr1_43_session1, e17_p7_e026_gr1_43_session2,
                e17_p7_e026_gr1_78_session1, e17_p7_e026_gr1_78_session2,
                e17_p7_e026_gr1_122_session1, e17_p7_e026_gr1_122_session2,
                e17_p7_e026_gr1_145_session1, e17_p7_e026_gr1_145_session2,
                e17_p7_e026_gr1_143_session1, e17_p7_e026_gr1_143_session2,
            #endregion
            #region E17/P6/E028
                e17_p6_e028_gr2_88_session1,
            #endregion
            #region E17/P7/E014
                e17_p7_e014_gr2_50_session1,
            #endregion
            #region E17/P7/E015
                e17_p7_e015_gr2_133_session1,
                e17_p7_e015_gr3_133_session1,
                e17_p7_e015_gr2_144_session1,
                e17_p7_e015_gr3_144_session1,
                e17_p7_e015_gr4_144_session1,
            #endregion
            #region E17/P7/E024
                e17_p7_e024_gr1_174_session1, e17_p7_e024_gr1_174_session2,
                e17_p7_e024_gr1_106_session1,
                e17_p7_e024_gr2_191_session1,
                e17_p7_e024_gr1_132_session1, e17_p7_e024_gr1_132_session2,
                e17_p7_e024_gr2_139_session1, e17_p7_e024_gr2_139_session2,
            #endregion
            #region E17/P8/E002
                e17_p8_e002_gr1_131_session1,
                e17_p8_e002_gr2_131_session1,
                e17_p8_e002_gr3_131_session1,
                e17_p8_e002_gr4_131_session1,
            #endregion
            #region E17/PB/E023
                e17_pb_e023_gr1_102_session1,
                e17_pb_e023_gr2_102_session1,
                e17_pb_e023_gr3_102_session1
            #endregion
              );



            //***************** JOU   ***********************

            

        }
    }
}
