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
            #region EDIFICIO 16
            #region e16_s1_e017_gr1_33_55
            var e16_s1_e017_gr1_33_55 = new Group()
            {
                Id = 8,
                Name = "GR1",
                SubjectId = 55,
                ClassroomId = 33,
                CalendarId = 1,
            };

            var e16_s1_e017_gr1_33_55_session1 = new Session()
            {
                Id = 8,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 8,
            };
            #endregion

            #region e16_s1_e017_gr2_33_55
            var e16_s1_e017_gr2_33_55 = new Group()
            {
                Id = 9,
                Name = "GR2",
                SubjectId = 55,
                ClassroomId = 33,
                CalendarId = 1,
            };

            var e16_s1_e017_gr2_33_55_session1 = new Session()
            {
                Id = 9,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 9,
            };
            #endregion

            #region e16_s1_e017_gr3_33_55
            var e16_s1_e017_gr3_33_55 = new Group()
            {
                Id = 10,
                Name = "GR3",
                SubjectId = 55,
                ClassroomId = 33,
                CalendarId = 1,
            };

            var e16_s1_e017_gr3_33_55_session1 = new Session()
            {
                Id = 10,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 10,
            };
            #endregion

            // AULA E16/S1/E012B
            #region e16_s1_e012b_gr1_32_65
            var e16_s1_e012b_gr1_32_65 = new Group()
            {
                Id = 11,
                Name = "GR1",
                SubjectId = 65,
                ClassroomId = 32,
                CalendarId = 1,
            };

            var e16_s1_e012b_gr1_32_65_session1 = new Session()
            {
                Id = 11,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 11,
            };
            #endregion

            #region e16_s1_e012b_gr2_32_65
            var e16_s1_e012b_gr2_32_65 = new Group()
            {
                Id = 12,
                Name = "GR2",
                SubjectId = 65,
                ClassroomId = 32,
                CalendarId = 1,
            };

            var e16_s1_e012b_gr2_32_65_session1 = new Session()
            {
                Id = 12,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 12,
            };
            #endregion

            #region e16_s1_e012b_gr1_32_60
            var e16_s1_e012b_gr1_32_60 = new Group()
            {
                Id = 13,
                Name = "GR1",
                SubjectId = 60,
                ClassroomId = 32,
                CalendarId = 1,
            };

            var e16_s1_e012b_gr1_32_60_session1 = new Session()
            {
                Id = 13,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 13,
            };
            #endregion

            #region e16_s1_e012b_gr2_32_60
            var e16_s1_e012b_gr2_32_60 = new Group()
            {
                Id = 14,
                Name = "GR2",
                SubjectId = 60,
                ClassroomId = 32,
                CalendarId = 1,
            };

            var e16_s1_e012b_gr2_32_60_session1 = new Session()
            {
                Id = 14,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 14,
            };
            #endregion

            #region e16_s1_e012b_gr3_32_60
            var e16_s1_e012b_gr3_32_60 = new Group()
            {
                Id = 15,
                Name = "GR3",
                SubjectId = 60,
                ClassroomId = 32,
                CalendarId = 1,
            };

            var e16_s1_e012b_gr3_32_60_session1 = new Session()
            {
                Id = 15,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 15,
            };
            #endregion

            #region e16_s1_e012b_gr4_32_60
            var e16_s1_e012b_gr4_32_60 = new Group()
            {
                Id = 16,
                Name = "GR4",
                SubjectId = 60,
                ClassroomId = 32,
                CalendarId = 1,
            };

            var e16_s1_e012b_gr4_32_60_session1 = new Session()
            {
                Id = 16,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 16,
            };
            #endregion

            #region e16_s1_e012b_gr5_32_60
            var e16_s1_e012b_gr5_32_60 = new Group()
            {
                Id = 17,
                Name = "GR5",
                SubjectId = 60,
                ClassroomId = 32,
                CalendarId = 1,
            };

            var e16_s1_e012b_gr5_32_60_session1 = new Session()
            {
                Id = 17,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 17,
            };
            #endregion

            #region e16_s1_e012b_gr6_32_60
            var e16_s1_e012b_gr6_32_60 = new Group()
            {
                Id = 18,
                Name = "GR6",
                SubjectId = 60,
                ClassroomId = 32,
                CalendarId = 1,
            };

            var e16_s1_e012b_gr6_32_60_session1 = new Session()
            {
                Id = 18,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 18,
            };
            #endregion
            // AULA E16/S1/E012A
            #region e16_s1_e012a_gr1_31_62
            var e16_s1_e012a_gr1_31_62 = new Group()
            {
                Id = 19,
                Name = "GR1",
                SubjectId = 62,
                ClassroomId = 31,
                CalendarId = 1,
            };

            var e16_s1_e012a_gr1_31_62_session1 = new Session()
            {
                Id = 19,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 19,
            };
            #endregion

            #region e16_s1_e012a_gr2_31_62
            var e16_s1_e012a_gr2_31_62 = new Group()
            {
                Id = 20,
                Name = "GR2",
                SubjectId = 62,
                ClassroomId = 31,
                CalendarId = 1,
            };

            var e16_s1_e012a_gr2_31_62_session1 = new Session()
            {
                Id = 20,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 20,
            };
            #endregion

            #region e16_s1_e012a_gr3_31_62
            var e16_s1_e012a_gr3_31_62 = new Group()
            {
                Id = 21,
                Name = "GR3",
                SubjectId = 62,
                ClassroomId = 31,
                CalendarId = 1,
            };

            var e16_s1_e012a_gr3_31_62_session1 = new Session()
            {
                Id = 21,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 21,
            };
            #endregion

            #region e16_s1_e012a_gr4_31_62
            var e16_s1_e012a_gr4_31_62 = new Group()
            {
                Id = 22,
                Name = "GR4",
                SubjectId = 62,
                ClassroomId = 31,
                CalendarId = 1,
            };

            var e16_s1_e012a_gr4_31_62_session1 = new Session()
            {
                Id = 22,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 22,
            };
            #endregion

            #region e16_s1_e012a_gr3_31_65
            var e16_s1_e012a_gr3_31_65 = new Group()
            {
                Id = 23,
                Name = "GR3",
                SubjectId = 65,
                ClassroomId = 31,
                CalendarId = 1,
            };

            var e16_s1_e012a_gr3_31_65_session1 = new Session()
            {
                Id = 23,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 23,
            };
            #endregion

            #region e16_s1_e012a_gr4_31_65
            var e16_s1_e012a_gr4_31_65 = new Group()
            {
                Id = 24,
                Name = "GR4",
                SubjectId = 65,
                ClassroomId = 31,
                CalendarId = 1,
            };

            var e16_s1_e012a_gr4_31_65_session1 = new Session()
            {
                Id = 24,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 24,
            };
            #endregion

            #region e16_s1_e012a_gr6_31_65
            var e16_s1_e012a_gr6_31_65 = new Group()
            {
                Id = 25,
                Name = "GR6",
                SubjectId = 65,
                ClassroomId = 31,
                CalendarId = 1,
            };

            var e16_s1_e012a_gr6_31_65_session1 = new Session()
            {
                Id = 25,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 25,
            };
            #endregion

            #region e16_s1_e012a_gr1-1_31_57
            var e16_s1_e012a_gr1_1_31_57 = new Group()
            {
                Id = 26,
                Name = "GR1-1",
                SubjectId = 57,
                ClassroomId = 31,
                CalendarId = 1,
            };

            var e16_s1_e012a_gr1_1_31_57_session1 = new Session()
            {
                Id = 26,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 26,
            };
            #endregion

            //AULA E16/S1/E011
            #region e16_s1_e011_gr1-1_30_30
            var e16_s1_e011_gr1_1_30_30 = new Group()
            {
                Id = 27,
                Name = "GR1-1",
                SubjectId = 30,
                ClassroomId = 30,
                CalendarId = 1,
            };

            var e16_s1_e011_gr1_1_30_30_session1 = new Session()
            {
                Id = 27, // Incrementar el ID automáticamente
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 27,
            };
            #endregion

            #region e16_s1_e011_gr1-2_30_30
            var e16_s1_e011_gr1_2_30_30 = new Group()
            {
                Id = 28,
                Name = "GR1-2",
                SubjectId = 30,
                ClassroomId = 30,
                CalendarId = 1,
            };

            var e16_s1_e011_gr1_2_30_30_session1 = new Session()
            {
                Id = 28, // Incrementar el ID automáticamente
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 28,
            };
            #endregion

            #region e16_s1_e011_gr1-3_30_30
            var e16_s1_e011_gr1_3_30_30 = new Group()
            {
                Id = 29,
                Name = "GR1-3",
                SubjectId = 30,
                ClassroomId = 30,
                CalendarId = 1,
            };

            var e16_s1_e011_gr1_3_30_30_session1 = new Session()
            {
                Id = 29, // Incrementar el ID automáticamente
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 29,
            };
            #endregion

            #region e16_s1_e011_gr1-4_30_30
            var e16_s1_e011_gr1_4_30_30 = new Group()
            {
                Id = 30,
                Name = "GR1-4",
                SubjectId = 30,
                ClassroomId = 30,
                CalendarId = 1,
            };

            var e16_s1_e011_gr1_4_30_30_session1 = new Session()
            {
                Id = 30, // Incrementar el ID automáticamente
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 30,
            };
            #endregion
            #region e16_s1_e011_gr2-1_30_30
            var e16_s1_e011_gr2_1_30_30 = new Group()
            {
                Id = 31,
                Name = "GR2-1",
                SubjectId = 30,
                ClassroomId = 30,
                CalendarId = 1,
            };

            var e16_s1_e011_gr2_1_30_30_session1 = new Session()
            {
                Id = 31,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 31,
            };
            #endregion

            #region e16_s1_e011_gr2-2_30_30
            var e16_s1_e011_gr2_2_30_30 = new Group()
            {
                Id = 32,
                Name = "GR2-2",
                SubjectId = 30,
                ClassroomId = 30,
                CalendarId = 1,
            };

            var e16_s1_e011_gr2_2_30_30_session1 = new Session()
            {
                Id = 32,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 32,
            };
            #endregion

            #region e16_s1_e011_gr2-3_30_30
            var e16_s1_e011_gr2_3_30_30 = new Group()
            {
                Id = 33,
                Name = "GR2-3",
                SubjectId = 30,
                ClassroomId = 30,
                CalendarId = 1,
            };

            var e16_s1_e011_gr2_3_30_30_session1 = new Session()
            {
                Id = 33,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 33,
            };
            #endregion

            #region e16_s1_e011_gr2-4_30_30
            var e16_s1_e011_gr2_4_30_30 = new Group()
            {
                Id = 34,
                Name = "GR2-4",
                SubjectId = 30,
                ClassroomId = 30,
                CalendarId = 1,
            };

            var e16_s1_e011_gr2_4_30_30_session1 = new Session()
            {
                Id = 34,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 34,
            };
            #endregion

            #region e16_s1_e011_gr1-1_30_36
            var e16_s1_e011_gr1_1_30_36 = new Group()
            {
                Id = 35,
                Name = "GR1-1",
                SubjectId = 36,
                ClassroomId = 30,
                CalendarId = 1,
            };

            var e16_s1_e011_gr1_1_30_36_session1 = new Session()
            {
                Id = 35,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 35,
            };
            #endregion

            #region e16_s1_e011_gr1-2_30_36
            var e16_s1_e011_gr1_2_30_36 = new Group()
            {
                Id = 36,
                Name = "GR1-2",
                SubjectId = 36,
                ClassroomId = 30,
                CalendarId = 1,
            };

            var e16_s1_e011_gr1_2_30_36_session1 = new Session()
            {
                Id = 36,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 36,
            };
            #endregion

            #region e16_s1_e011_gr1-3_30_36
            var e16_s1_e011_gr1_3_30_36 = new Group()
            {
                Id = 37,
                Name = "GR1-3",
                SubjectId = 36,
                ClassroomId = 30,
                CalendarId = 1,
            };

            var e16_s1_e011_gr1_3_30_36_session1 = new Session()
            {
                Id = 37,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 37,
            };
            #endregion

            #region e16_s1_e011_gr1-4_30_36
            var e16_s1_e011_gr1_4_30_36 = new Group()
            {
                Id = 38,
                Name = "GR1-4",
                SubjectId = 36,
                ClassroomId = 30,
                CalendarId = 1,
            };

            var e16_s1_e011_gr1_4_30_36_session1 = new Session()
            {
                Id = 38,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 38,
            };
            #endregion

            #region e16_s1_e011_gr2-1_30_36
            var e16_s1_e011_gr2_1_30_36 = new Group()
            {
                Id = 39,
                Name = "GR2-1",
                SubjectId = 36,
                ClassroomId = 30,
                CalendarId = 1,
            };

            var e16_s1_e011_gr2_1_30_36_session1 = new Session()
            {
                Id = 39,
                Day = Enum.Day.Lunes, // Coloca el día correcto
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 39,
            };
            #endregion

            #region e16_s1_e011_gr2-2_30_36
            var e16_s1_e011_gr2_2_30_36 = new Group()
            {
                Id = 40,
                Name = "GR2-2",
                SubjectId = 36,
                ClassroomId = 30,
                CalendarId = 1,
            };

            var e16_s1_e011_gr2_2_30_36_session1 = new Session()
            {
                Id = 40,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 40,
            };
            #endregion

            #region e16_s1_e011_gr2-3_30_36
            var e16_s1_e011_gr2_3_30_36 = new Group()
            {
                Id = 41,
                Name = "GR2-3",
                SubjectId = 36,
                ClassroomId = 30,
                CalendarId = 1,
            };

            var e16_s1_e011_gr2_3_30_36_session1 = new Session()
            {
                Id = 41,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 41,
            };
            #endregion

            #region e16_s1_e011_gr2-4_30_36
            var e16_s1_e011_gr2_4_30_36 = new Group()
            {
                Id = 42,
                Name = "GR2-4",
                SubjectId = 36,
                ClassroomId = 30,
                CalendarId = 1,
            };

            var e16_s1_e011_gr2_4_30_36_session1 = new Session()
            {
                Id = 42,
                Day = Enum.Day.Domingo, // Coloca el día correcto
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 42,
            };
            #endregion
            // AULA E16/S1/E005
            #region e16_s1_e005_gr2_29_184
            var e16_s1_e005_gr2_29_184 = new Group()
            {
                Id = 43,
                Name = "GR2",
                SubjectId = 184,
                ClassroomId = 29,
                CalendarId = 1,
            };

            var e16_s1_e005_gr2_29_184_session1 = new Session()
            {
                Id = 43,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 43,
            };
            #endregion

            #region e16_s1_e005_gr1_29_99
            var e16_s1_e005_gr1_29_99 = new Group()
            {
                Id = 44,
                Name = "GR1",
                SubjectId = 99,
                ClassroomId = 29,
                CalendarId = 1,
            };

            var e16_s1_e005_gr1_29_99_session1 = new Session()
            {
                Id = 44,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 44,
            };
            #endregion
            #region e16_s1_e005_gr1_29_37
            var e16_s1_e005_gr1_29_37 = new Group()
            {
                Id = 48,
                Name = "GR1",
                SubjectId = 37,
                ClassroomId = 29,
                CalendarId = 1,
            };

            var e16_s1_e005_gr1_29_37_session1 = new Session()
            {
                Id = 48,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 48,
            };

            var e16_s1_e005_gr1_29_37_session2 = new Session()
            {
                Id = 49,
                Day = Enum.Day.Miercoles, // Día de inicio de la segunda sesión
                StartTime = new TimeSpan(7, 0, 0), // Hora de inicio de la segunda sesión
                EndTime = new TimeSpan(8, 0, 0), // Hora de finalización de la segunda sesión
                GroupId = 48,
            };
            #endregion
            #region e16_s1_e005_gr1_29_56
            var e16_s1_e005_gr1_29_56 = new Group()
            {
                Id = 50,
                Name = "GR1",
                SubjectId = 56,
                ClassroomId = 29,
                CalendarId = 1,
            };

            var e16_s1_e005_gr1_29_56_session1 = new Session()
            {
                Id = 50,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(12, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 50,
            };

            var e16_s1_e005_gr1_29_56_session2 = new Session()
            {
                Id = 51,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 50,
            };
            #endregion

            #region e16_s1_e005_gr1_29_59
            var e16_s1_e005_gr1_29_59 = new Group()
            {
                Id = 52,
                Name = "GR1",
                SubjectId = 59,
                ClassroomId = 29,
                CalendarId = 1,
            };

            var e16_s1_e005_gr1_29_59_session1 = new Session()
            {
                Id = 52,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 52,
            };

            var e16_s1_e005_gr1_29_59_session2 = new Session()
            {
                Id = 53,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(15, 0, 0),
                GroupId = 52,
            };
            #endregion
            #region e16_s1_e005_gr1_29_146
            var e16_s1_e005_gr1_29_146 = new Group()
            {
                Id = 54,
                Name = "GR1",
                SubjectId = 146,
                ClassroomId = 29,
                CalendarId = 1,
            };

            var e16_s1_e005_gr1_29_146_session1 = new Session()
            {
                Id = 54,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(12, 0, 0),
                GroupId = 54,
            };

            var e16_s1_e005_gr1_29_146_session2 = new Session()
            {
                Id = 55,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 54,
            };
            #endregion
            //AULA E16/S1/E004
            #region e16_s1_e004_gr2_28_10
            var e16_s1_e004_gr2_28_10 = new Group()
            {
                Id = 56,
                Name = "GR2",
                SubjectId = 10,
                ClassroomId = 28,
                CalendarId = 1,
            };

            var e16_s1_e004_gr2_28_10_session1 = new Session()
            {
                Id = 56,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 56,
            };

            var e16_s1_e004_gr2_28_10_session2 = new Session()
            {
                Id = 57,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(12, 0, 0),
                GroupId = 56,
            };
            #endregion

            #region e16_s1_e004_gr3_28_14
            var e16_s1_e004_gr3_28_14 = new Group()
            {
                Id = 58,
                Name = "GR3",
                SubjectId = 14,
                ClassroomId = 28,
                CalendarId = 1,
            };

            var e16_s1_e004_gr3_28_14_session1 = new Session()
            {
                Id = 58,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 58,
            };

            var e16_s1_e004_gr3_28_14_session2 = new Session()
            {
                Id = 59,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(10, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 58,
            };
            #endregion

            #region e16_s1_e004_gr1_28_46
            var e16_s1_e004_gr1_28_46 = new Group()
            {
                Id = 60,
                Name = "GR1",
                SubjectId = 46,
                ClassroomId = 28,
                CalendarId = 1,
            };

            var e16_s1_e004_gr1_28_46_session1 = new Session()
            {
                Id = 60,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 60,
            };

            var e16_s1_e004_gr1_28_46_session2 = new Session()
            {
                Id = 61,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(15, 0, 0),
                GroupId = 60,
            };
            #endregion

            #region e16_s1_e004_gr1_28_66
            var e16_s1_e004_gr1_28_66 = new Group()
            {
                Id = 62,
                Name = "GR1",
                SubjectId = 66,
                ClassroomId = 28,
                CalendarId = 1,
            };

            var e16_s1_e004_gr1_28_66_session1 = new Session()
            {
                Id = 62,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(12, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 62,
            };

            var e16_s1_e004_gr1_28_66_session2 = new Session()
            {
                Id = 63,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 62,
            };
            #endregion

            #region e16_s1_e004_gr1_28_64
            var e16_s1_e004_gr1_28_64 = new Group()
            {
                Id = 64,
                Name = "GR1",
                SubjectId = 64,
                ClassroomId = 28,
                CalendarId = 1,
            };

            var e16_s1_e004_gr1_28_64_session1 = new Session()
            {
                Id = 64,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 64,
            };

            var e16_s1_e004_gr1_28_64_session2 = new Session()
            {
                Id = 65,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(10, 0, 0),
                GroupId = 64,
            };
            #endregion
            // AULA E16/S1/E001
            #region e16_s1_e001_gr1_27_136
            var e16_s1_e001_gr1_27_136 = new Group()
            {
                Id = 66,
                Name = "GR1",
                SubjectId = 136,
                ClassroomId = 27,
                CalendarId = 1,
            };

            var e16_s1_e001_gr1_27_136_session1 = new Session()
            {
                Id = 66,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 66,
            };

            var e16_s1_e001_gr1_27_136_session2 = new Session()
            {
                Id = 67,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 66,
            };
            #endregion
            //AULA  E16/PB/E026
            #region e16_pb_e026_gr1_26_70
            var e16_pb_e026_gr1_26_70 = new Group()
            {
                Id = 68,
                Name = "GR1",
                SubjectId = 70,
                ClassroomId = 26,
                CalendarId = 1,
            };

            var e16_pb_e026_gr1_26_70_session1 = new Session()
            {
                Id = 68,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(10, 0, 0),
                EndTime = new TimeSpan(12, 0, 0),
                GroupId = 68,
            };
            #endregion

            #region e16_pb_e026_gr2_26_70
            var e16_pb_e026_gr2_26_70 = new Group()
            {
                Id = 69,
                Name = "GR2",
                SubjectId = 70,
                ClassroomId = 26,
                CalendarId = 1,
            };

            var e16_pb_e026_gr2_26_70_session1 = new Session()
            {
                Id = 69,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 69,
            };
            #endregion

            #region e16_pb_e026_gr4_26_70
            var e16_pb_e026_gr4_26_70 = new Group()
            {
                Id = 70,
                Name = "GR4",
                SubjectId = 70,
                ClassroomId = 26,
                CalendarId = 1,
            };

            var e16_pb_e026_gr4_26_70_session1 = new Session()
            {
                Id = 70,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 70,
            };
            #endregion

            #region e16_pb_e026_gr5_26_70
            var e16_pb_e026_gr5_26_70 = new Group()
            {
                Id = 71,
                Name = "GR5",
                SubjectId = 70,
                ClassroomId = 26,
                CalendarId = 1,
            };

            var e16_pb_e026_gr5_26_70_session1 = new Session()
            {
                Id = 71,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 71,
            };
            #endregion
            //AULA E16/PB/E008
            #region e16_pb_e008_gr1_25_98
            var e16_pb_e008_gr1_25_98 = new Group()
            {
                Id = 72,
                Name = "GR1",
                SubjectId = 98,
                ClassroomId = 25,
                CalendarId = 1,
            };

            var e16_pb_e008_gr1_25_98_session1 = new Session()
            {
                Id = 72,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 72,
            };
            #endregion

            #region e16_pb_e008_gr2_25_98
            var e16_pb_e008_gr2_25_98 = new Group()
            {
                Id = 73,
                Name = "GR2",
                SubjectId = 98,
                ClassroomId = 25,
                CalendarId = 1,
            };

            var e16_pb_e008_gr2_25_98_session1 = new Session()
            {
                Id = 73,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 73,
            };
            #endregion

            #region e16_pb_e008_gr3_25_98
            var e16_pb_e008_gr3_25_98 = new Group()
            {
                Id = 74,
                Name = "GR3",
                SubjectId = 98,
                ClassroomId = 25,
                CalendarId = 1,
            };

            var e16_pb_e008_gr3_25_98_session1 = new Session()
            {
                Id = 74,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 74,
            };
            #endregion

            #region e16_pb_e008_gr4_25_98
            var e16_pb_e008_gr4_25_98 = new Group()
            {
                Id = 75,
                Name = "GR4",
                SubjectId = 98,
                ClassroomId = 25,
                CalendarId = 1,
            };

            var e16_pb_e008_gr4_25_98_session1 = new Session()
            {
                Id = 75,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 75,
            };
            #endregion

            // AULA E16/PB/E007

            #region e16_pb_e007_gr1_1_24_91
            var e16_pb_e007_gr1_1_24_91 = new Group()
            {
                Id = 76,
                Name = "GR1-1",
                SubjectId = 91,
                ClassroomId = 24,
                CalendarId = 1,
            };

            var e16_pb_e007_gr1_1_24_91_session1 = new Session()
            {
                Id = 76,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 76,
            };
            #endregion

            #region e16_pb_e007_gr1_2_24_91
            var e16_pb_e007_gr1_2_24_91 = new Group()
            {
                Id = 77,
                Name = "GR1-2",
                SubjectId = 91,
                ClassroomId = 24,
                CalendarId = 1,
            };

            var e16_pb_e007_gr1_2_24_91_session1 = new Session()
            {
                Id = 77,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 77,
            };
            #endregion

            #region e16_pb_e007_gr1_3_24_91
            var e16_pb_e007_gr1_3_24_91 = new Group()
            {
                Id = 78,
                Name = "GR1-3",
                SubjectId = 91,
                ClassroomId = 24,
                CalendarId = 1,
            };

            var e16_pb_e007_gr1_3_24_91_session1 = new Session()
            {
                Id = 78,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 78,
            };
            #endregion

            #region e16_pb_e007_gr1_4_24_91
            var e16_pb_e007_gr1_4_24_91 = new Group()
            {
                Id = 79,
                Name = "GR1-4",
                SubjectId = 91,
                ClassroomId = 24,
                CalendarId = 1,
            };

            var e16_pb_e007_gr1_4_24_91_session1 = new Session()
            {
                Id = 79,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 79,
            };
            #endregion

            #region e16_pb_e007_gr2_1_24_91
            var e16_pb_e007_gr2_1_24_91 = new Group()
            {
                Id = 80,
                Name = "GR2-1",
                SubjectId = 91,
                ClassroomId = 24,
                CalendarId = 1,
            };

            var e16_pb_e007_gr2_1_24_91_session1 = new Session()
            {
                Id = 80,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 80,
            };
            #endregion

            #region e16_pb_e007_gr2_2_24_91
            var e16_pb_e007_gr2_2_24_91 = new Group()
            {
                Id = 81,
                Name = "GR2-2",
                SubjectId = 91,
                ClassroomId = 24,
                CalendarId = 1,
            };

            var e16_pb_e007_gr2_2_24_91_session1 = new Session()
            {
                Id = 81,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 81,
            };
            #endregion

            #region e16_pb_e007_gr2_3_24_91
            var e16_pb_e007_gr2_3_24_91 = new Group()
            {
                Id = 82,
                Name = "GR2-3",
                SubjectId = 91,
                ClassroomId = 24,
                CalendarId = 1,
            };

            var e16_pb_e007_gr2_3_24_91_session1 = new Session()
            {
                Id = 82,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 82,
            };
            #endregion

            #region e16_pb_e007_gr1_1_24_34
            var e16_pb_e007_gr1_1_24_34 = new Group()
            {
                Id = 83,
                Name = "GR1-1",
                SubjectId = 34,
                ClassroomId = 24,
                CalendarId = 1,
            };

            var e16_pb_e007_gr1_1_24_34_session1 = new Session()
            {
                Id = 83,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 83,
            };
            #endregion

            #region e16_pb_e007_gr1_2_24_34
            var e16_pb_e007_gr1_2_24_34 = new Group()
            {
                Id = 84,
                Name = "GR1-2",
                SubjectId = 34,
                ClassroomId = 24,
                CalendarId = 1,
            };

            var e16_pb_e007_gr1_2_24_34_session1 = new Session()
            {
                Id = 84,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 84,
            };
            #endregion

            #region e16_pb_e007_gr1_3_24_34
            var e16_pb_e007_gr1_3_24_34 = new Group()
            {
                Id = 85,
                Name = "GR1-3",
                SubjectId = 34,
                ClassroomId = 24,
                CalendarId = 1,
            };

            var e16_pb_e007_gr1_3_24_34_session1 = new Session()
            {
                Id = 85,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 85,
            };
            #endregion

            #region e16_pb_e007_gr1_5_24_34
            var e16_pb_e007_gr1_5_24_34 = new Group()
            {
                Id = 86,
                Name = "GR1-5",
                SubjectId = 34,
                ClassroomId = 24,
                CalendarId = 1,
            };

            var e16_pb_e007_gr1_5_24_34_session1 = new Session()
            {
                Id = 86,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 86,
            };
            #endregion

            #region e16_pb_e007_gr2_1_24_34
            var e16_pb_e007_gr2_1_24_34 = new Group()
            {
                Id = 87,
                Name = "GR2-1",
                SubjectId = 34,
                ClassroomId = 24,
                CalendarId = 1,
            };

            var e16_pb_e007_gr2_1_24_34_session1 = new Session()
            {
                Id = 87,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 87,
            };
            #endregion

            #region e16_pb_e007_gr2_2_24_34
            var e16_pb_e007_gr2_2_24_34 = new Group()
            {
                Id = 88,
                Name = "GR2-2",
                SubjectId = 34,
                ClassroomId = 24,
                CalendarId = 1,
            };

            var e16_pb_e007_gr2_2_24_34_session1 = new Session()
            {
                Id = 88,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 88,
            };
            #endregion

            #region e16_pb_e007_gr2_3_24_34
            var e16_pb_e007_gr2_3_24_34 = new Group()
            {
                Id = 89,
                Name = "GR2-3",
                SubjectId = 34,
                ClassroomId = 24,
                CalendarId = 1,
            };

            var e16_pb_e007_gr2_3_24_34_session1 = new Session()
            {
                Id = 89,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 89,
            };
            #endregion

            #region e16_pb_e007_gr2_4_24_34
            var e16_pb_e007_gr2_4_24_34 = new Group()
            {
                Id = 90,
                Name = "GR2-4",
                SubjectId = 34,
                ClassroomId = 24,
                CalendarId = 1,
            };

            var e16_pb_e007_gr2_4_24_34_session1 = new Session()
            {
                Id = 90,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 90,
            };
            #endregion

            #region e16_pb_e007_gr2_5_24_34
            var e16_pb_e007_gr2_5_24_34 = new Group()
            {
                Id = 91,
                Name = "GR2-5",
                SubjectId = 34,
                ClassroomId = 24,
                CalendarId = 1,
            };

            var e16_pb_e007_gr2_5_24_34_session1 = new Session()
            {
                Id = 91,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 91,
            };
            #endregion

            #region e16_pb_e007_gr3_1_24_34
            var e16_pb_e007_gr3_1_24_34 = new Group()
            {
                Id = 92,
                Name = "GR3-1",
                SubjectId = 34,
                ClassroomId = 24,
                CalendarId = 1,
            };

            var e16_pb_e007_gr3_1_24_34_session1 = new Session()
            {
                Id = 92,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 92,
            };
            #endregion

            #region e16_pb_e007_gr3_2_24_34
            var e16_pb_e007_gr3_2_24_34 = new Group()
            {
                Id = 93,
                Name = "GR3-2",
                SubjectId = 34,
                ClassroomId = 24,
                CalendarId = 1,
            };

            var e16_pb_e007_gr3_2_24_34_session1 = new Session()
            {
                Id = 93,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 93,
            };
            #endregion

            #region e16_pb_e007_gr3_3_24_34
            var e16_pb_e007_gr3_3_24_34 = new Group()
            {
                Id = 94,
                Name = "GR3-3",
                SubjectId = 34,
                ClassroomId = 24,
                CalendarId = 1,
            };

            var e16_pb_e007_gr3_3_24_34_session1 = new Session()
            {
                Id = 94,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 94,
            };
            #endregion

            #region e16_pb_e007_gr3_4_24_34
            var e16_pb_e007_gr3_4_24_34 = new Group()
            {
                Id = 95,
                Name = "GR3-4",
                SubjectId = 34,
                ClassroomId = 24,
                CalendarId = 1,
            };

            var e16_pb_e007_gr3_4_24_34_session1 = new Session()
            {
                Id = 95,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 95,
            };
            #endregion

            #region e16_pb_e007_gr3_5_24_34
            var e16_pb_e007_gr3_5_24_34 = new Group()
            {
                Id = 96,
                Name = "GR3-5",
                SubjectId = 34,
                ClassroomId = 24,
                CalendarId = 1,
            };

            var e16_pb_e007_gr3_5_24_34_session1 = new Session()
            {
                Id = 96,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 96,
            };
            #endregion
            //AULA  E16/PB/E003
            #region e16_pb_e003_gr2_23_100
            var e16_pb_e003_gr2_23_100 = new Group()
            {
                Id = 97,
                Name = "GR2",
                SubjectId = 100,
                ClassroomId = 23,
                CalendarId = 1,
            };

            var e16_pb_e003_gr2_23_100_session1 = new Session()
            {
                Id = 97,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 97,
            };
            #endregion

            #region e16_pb_e003_gr3_23_100
            var e16_pb_e003_gr3_23_100 = new Group()
            {
                Id = 98,
                Name = "GR3",
                SubjectId = 100,
                ClassroomId = 23,
                CalendarId = 1,
            };

            var e16_pb_e003_gr3_23_100_session1 = new Session()
            {
                Id = 98,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 98,
            };
            #endregion

            #region e16_pb_e003_gr5_23_100
            var e16_pb_e003_gr5_23_100 = new Group()
            {
                Id = 99,
                Name = "GR5",
                SubjectId = 100,
                ClassroomId = 23,
                CalendarId = 1,
            };

            var e16_pb_e003_gr5_23_100_session1 = new Session()
            {
                Id = 99,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 99,
            };
            #endregion

            #region e16_pb_e003_gr6_23_51
            var e16_pb_e003_gr6_23_51 = new Group()
            {
                Id = 100,
                Name = "GR6",
                SubjectId = 51,
                ClassroomId = 23,
                CalendarId = 1,
            };

            var e16_pb_e003_gr6_23_51_session1 = new Session()
            {
                Id = 100,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 100,
            };
            #endregion
            //AULA E16/PB/E002
            #region e16_pb_e002_gr1_1_22_40
            var e16_pb_e002_gr1_1_22_40 = new Group()
            {
                Id = 101,
                Name = "GR1-1",
                SubjectId = 40,
                ClassroomId = 22,
                CalendarId = 1,
            };

            var e16_pb_e002_gr1_1_22_40_session1 = new Session()
            {
                Id = 101,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 101,
            };
            #endregion

            #region e16_pb_e002_gr1_2_22_40
            var e16_pb_e002_gr1_2_22_40 = new Group()
            {
                Id = 102,
                Name = "GR1-2",
                SubjectId = 40,
                ClassroomId = 22,
                CalendarId = 1,
            };

            var e16_pb_e002_gr1_2_22_40_session1 = new Session()
            {
                Id = 102,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 102,
            };
            #endregion

            #region e16_pb_e002_gr1_3_22_40
            var e16_pb_e002_gr1_3_22_40 = new Group()
            {
                Id = 103,
                Name = "GR1-3",
                SubjectId = 40,
                ClassroomId = 22,
                CalendarId = 1,
            };

            var e16_pb_e002_gr1_3_22_40_session1 = new Session()
            {
                Id = 103,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 103,
            };
            #endregion

            #region e16_pb_e002_gr2_2_22_40
            var e16_pb_e002_gr2_2_22_40 = new Group()
            {
                Id = 104,
                Name = "GR2-2",
                SubjectId = 40,
                ClassroomId = 22,
                CalendarId = 1,
            };

            var e16_pb_e002_gr2_2_22_40_session1 = new Session()
            {
                Id = 104,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 104,
            };
            #endregion

            #region e16_pb_e002_gr2_3_22_40
            var e16_pb_e002_gr2_3_22_40 = new Group()
            {
                Id = 105,
                Name = "GR2-3",
                SubjectId = 40,
                ClassroomId = 22,
                CalendarId = 1,
            };

            var e16_pb_e002_gr2_3_22_40_session1 = new Session()
            {
                Id = 105,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 105,
            };
            #endregion

            #region e16_pb_e002_gr2_4_22_40
            var e16_pb_e002_gr2_4_22_40 = new Group()
            {
                Id = 106,
                Name = "GR2-4",
                SubjectId = 40,
                ClassroomId = 22,
                CalendarId = 1,
            };

            var e16_pb_e002_gr2_4_22_40_session1 = new Session()
            {
                Id = 106,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 106,
            };
            #endregion
            //AULA E16/P2/E020
            #region e16_p2_e020_gr4_21_2
            var e16_p2_e020_gr4_21_2 = new Group()
            {
                Id = 107,
                Name = "GR4",
                SubjectId = 2,
                ClassroomId = 21,
                CalendarId = 1,
            };

            var e16_p2_e020_gr4_21_2_session1 = new Session()
            {
                Id = 107,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 107,
            };
            #endregion

            #region e16_p2_e020_gr4_21_2_session2
            var e16_p2_e020_gr4_21_2_session2 = new Session()
            {
                Id = 108,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 107,
            };
            #endregion

            #region e16_p2_e020_gr1_gp_21_3
            var e16_p2_e020_gr1_gp_21_3 = new Group()
            {
                Id = 109,
                Name = "GR1-GP",
                SubjectId = 3,
                ClassroomId = 21,
                CalendarId = 1,
            };

            var e16_p2_e020_gr1_gp_21_3_session1 = new Session()
            {
                Id = 109,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 109,
            };
            #endregion

            #region e16_p2_e020_gr1_gp_21_3_session2
            var e16_p2_e020_gr1_gp_21_3_session2 = new Session()
            {
                Id = 110,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 109,
            };
            #endregion
            //AULA E16/P2/E015

            #region e16_p2_e015_gr3_20_51
            var e16_p2_e015_gr3_20_51 = new Group()
            {
                Id = 111,
                Name = "GR3",
                SubjectId = 51,
                ClassroomId = 20,
                CalendarId = 1,
            };

            var e16_p2_e015_gr3_20_51_session1 = new Session()
            {
                Id = 111,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(12, 0, 0),
                GroupId = 111,
            };
            #endregion

            #region e16_p2_e015_gr3_20_51_session2
            var e16_p2_e015_gr3_20_51_session2 = new Session()
            {
                Id = 112,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 111,
            };
            #endregion

            #region e16_p2_e015_gr9_20_51
            var e16_p2_e015_gr9_20_51 = new Group()
            {
                Id = 113,
                Name = "GR9",
                SubjectId = 51,
                ClassroomId = 20,
                CalendarId = 1,
            };

            var e16_p2_e015_gr9_20_51_session1 = new Session()
            {
                Id = 113,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 113,
            };
            #endregion

            #region e16_p2_e015_gr9_20_51_session2
            var e16_p2_e015_gr9_20_51_session2 = new Session()
            {
                Id = 114,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(8, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 113,
            };
            #endregion
            //AULA E16/P2/E014

            #region e16_p2_e014_gr1_1_19_89
            var e16_p2_e014_gr1_1_19_89 = new Group()
            {
                Id = 115,
                Name = "GR1-1",
                SubjectId = 89,
                ClassroomId = 19,
                CalendarId = 1,
            };

            var e16_p2_e014_gr1_1_19_89_session1 = new Session()
            {
                Id = 115,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 115,
            };
            #endregion

            #region e16_p2_e014_gr1_2_19_89
            var e16_p2_e014_gr1_2_19_89 = new Group()
            {
                Id = 116,
                Name = "GR1-2",
                SubjectId = 89,
                ClassroomId = 19,
                CalendarId = 1,
            };

            var e16_p2_e014_gr1_2_19_89_session1 = new Session()
            {
                Id = 116,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 116,
            };
            #endregion

            #region e16_p2_e014_gr1_3_19_89
            var e16_p2_e014_gr1_3_19_89 = new Group()
            {
                Id = 117,
                Name = "GR1-3",
                SubjectId = 89,
                ClassroomId = 19,
                CalendarId = 1,
            };

            var e16_p2_e014_gr1_3_19_89_session1 = new Session()
            {
                Id = 117,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 117,
            };
            #endregion

            #region e16_p2_e014_gr2_1_19_89
            var e16_p2_e014_gr2_1_19_89 = new Group()
            {
                Id = 118,
                Name = "GR2-1",
                SubjectId = 89,
                ClassroomId = 19,
                CalendarId = 1,
            };

            var e16_p2_e014_gr2_1_19_89_session1 = new Session()
            {
                Id = 118,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 118,
            };
            #endregion

            #region e16_p2_e014_gr2_2_19_89
            var e16_p2_e014_gr2_2_19_89 = new Group()
            {
                Id = 119,
                Name = "GR2-2",
                SubjectId = 89,
                ClassroomId = 19,
                CalendarId = 1,
            };

            var e16_p2_e014_gr2_2_19_89_session1 = new Session()
            {
                Id = 119,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 119,
            };
            #endregion

            #region e16_p2_e014_gr2_3_19_89
            var e16_p2_e014_gr2_3_19_89 = new Group()
            {
                Id = 120,
                Name = "GR2-3",
                SubjectId = 89,
                ClassroomId = 19,
                CalendarId = 1,
            };

            var e16_p2_e014_gr2_3_19_89_session1 = new Session()
            {
                Id = 120,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 120,
            };
            #endregion

            #region e16_p2_e014_gr1_1_19_85
            var e16_p2_e014_gr1_1_19_85 = new Group()
            {
                Id = 121,
                Name = "GR1-1",
                SubjectId = 85,
                ClassroomId = 19,
                CalendarId = 1,
            };

            var e16_p2_e014_gr1_1_19_85_session1 = new Session()
            {
                Id = 121,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 121,
            };
            #endregion

            #region e16_p2_e014_gr1_2_19_85
            var e16_p2_e014_gr1_2_19_85 = new Group()
            {
                Id = 122,
                Name = "GR1-2",
                SubjectId = 85,
                ClassroomId = 19,
                CalendarId = 1,
            };

            var e16_p2_e014_gr1_2_19_85_session1 = new Session()
            {
                Id = 122,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 122,
            };
            #endregion

            #region e16_p2_e014_gr1_3_19_85
            var e16_p2_e014_gr1_3_19_85 = new Group()
            {
                Id = 123,
                Name = "GR1-3",
                SubjectId = 85,
                ClassroomId = 19,
                CalendarId = 1,
            };

            var e16_p2_e014_gr1_3_19_85_session1 = new Session()
            {
                Id = 123,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 123,
            };
            #endregion

            #region e16_p2_e014_gr1_4_19_85
            var e16_p2_e014_gr1_4_19_85 = new Group()
            {
                Id = 124,
                Name = "GR1-4",
                SubjectId = 85,
                ClassroomId = 19,
                CalendarId = 1,
            };

            var e16_p2_e014_gr1_4_19_85_session1 = new Session()
            {
                Id = 124,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 124,
            };
            #endregion

            #region e16_p2_e014_gr1_5_19_85
            var e16_p2_e014_gr1_5_19_85 = new Group()
            {
                Id = 125,
                Name = "GR1-5",
                SubjectId = 85,
                ClassroomId = 19,
                CalendarId = 1,
            };

            var e16_p2_e014_gr1_5_19_85_session1 = new Session()
            {
                Id = 125,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 125,
            };
            #endregion

            #region e16_p2_e014_gr1_6_19_85
            var e16_p2_e014_gr1_6_19_85 = new Group()
            {
                Id = 126,
                Name = "GR1-6",
                SubjectId = 85,
                ClassroomId = 19,
                CalendarId = 1,
            };

            var e16_p2_e014_gr1_6_19_85_session1 = new Session()
            {
                Id = 126,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 126,
            };
            #endregion
            #region e16_p2_e014_gr2_19_88
            var e16_p2_e014_gr2_19_88 = new Group()
            {
                Id = 127,
                Name = "GR2",
                SubjectId = 88,
                ClassroomId = 19,
                CalendarId = 1,
            };

            var e16_p2_e014_gr2_19_88_session1 = new Session()
            {
                Id = 127,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 127,
            };

            var e16_p2_e014_gr2_19_88_session2 = new Session()
            {
                Id = 128,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(10, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 127,
            };
            #endregion
            //AULA E16/P2/E013
            #region e16_p2_e013_gr1_2_18_38
            var e16_p2_e013_gr1_2_18_38 = new Group()
            {
                Id = 129,
                Name = "GR1-2",
                SubjectId = 38,
                ClassroomId = 18,
                CalendarId = 1,
            };

            var e16_p2_e013_gr1_2_18_38_session1 = new Session()
            {
                Id = 129,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 129,
            };
            #endregion

            #region e16_p2_e013_gr1_3_18_38
            var e16_p2_e013_gr1_3_18_38 = new Group()
            {
                Id = 130,
                Name = "GR1-3",
                SubjectId = 38,
                ClassroomId = 18,
                CalendarId = 1,
            };

            var e16_p2_e013_gr1_3_18_38_session1 = new Session()
            {
                Id = 130,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 130,
            };
            #endregion

            #region e16_p2_e013_gr1_4_18_38
            var e16_p2_e013_gr1_4_18_38 = new Group()
            {
                Id = 131,
                Name = "GR1-4",
                SubjectId = 38,
                ClassroomId = 18,
                CalendarId = 1,
            };

            var e16_p2_e013_gr1_4_18_38_session1 = new Session()
            {
                Id = 131,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 131,
            };
            #endregion

            #region e16_p2_e013_gr2_1_18_38
            var e16_p2_e013_gr2_1_18_38 = new Group()
            {
                Id = 132,
                Name = "GR2-1",
                SubjectId = 38,
                ClassroomId = 18,
                CalendarId = 1,
            };

            var e16_p2_e013_gr2_1_18_38_session1 = new Session()
            {
                Id = 132,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 132,
            };
            #endregion

            #region e16_p2_e013_gr2_2_18_38
            var e16_p2_e013_gr2_2_18_38 = new Group()
            {
                Id = 133,
                Name = "GR2-2",
                SubjectId = 38,
                ClassroomId = 18,
                CalendarId = 1,
            };

            var e16_p2_e013_gr2_2_18_38_session1 = new Session()
            {
                Id = 133,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 133,
            };
            #endregion

            #region e16_p2_e013_gr2_3_18_38
            var e16_p2_e013_gr2_3_18_38 = new Group()
            {
                Id = 134,
                Name = "GR2-3",
                SubjectId = 38,
                ClassroomId = 18,
                CalendarId = 1,
            };

            var e16_p2_e013_gr2_3_18_38_session1 = new Session()
            {
                Id = 134,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 134,
            };
            #endregion

            #region e16_p2_e013_gr1_1_18_93
            var e16_p2_e013_gr1_1_18_93 = new Group()
            {
                Id = 135,
                Name = "GR1-1",
                SubjectId = 93,
                ClassroomId = 18,
                CalendarId = 1,
            };

            var e16_p2_e013_gr1_1_18_93_session1 = new Session()
            {
                Id = 135,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 135,
            };
            #endregion

            #region e16_p2_e013_gr1_2_18_93
            var e16_p2_e013_gr1_2_18_93 = new Group()
            {
                Id = 136,
                Name = "GR1-2",
                SubjectId = 93,
                ClassroomId = 18,
                CalendarId = 1,
            };

            var e16_p2_e013_gr1_2_18_93_session1 = new Session()
            {
                Id = 136,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 136,
            };
            #endregion

            #region e16_p2_e013_gr1_3_18_93
            var e16_p2_e013_gr1_3_18_93 = new Group()
            {
                Id = 137,
                Name = "GR1-3",
                SubjectId = 93,
                ClassroomId = 18,
                CalendarId = 1,
            };

            var e16_p2_e013_gr1_3_18_93_session1 = new Session()
            {
                Id = 137,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 137,
            };
            #endregion

            #region e16_p2_e013_gr1_4_18_93
            var e16_p2_e013_gr1_4_18_93 = new Group()
            {
                Id = 138,
                Name = "GR1-4",
                SubjectId = 93,
                ClassroomId = 18,
                CalendarId = 1,
            };

            var e16_p2_e013_gr1_4_18_93_session1 = new Session()
            {
                Id = 138,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 138,
            };
            #endregion

            #region e16_p2_e013_gr1_5_18_93
            var e16_p2_e013_gr1_5_18_93 = new Group()
            {
                Id = 139,
                Name = "GR1-5",
                SubjectId = 93,
                ClassroomId = 18,
                CalendarId = 1,
            };

            var e16_p2_e013_gr1_5_18_93_session1 = new Session()
            {
                Id = 139,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 139,
            };
            #endregion

            #region e16_p2_e013_gr1_18_108
            var e16_p2_e013_gr1_18_108 = new Group()
            {
                Id = 140,
                Name = "GR1",
                SubjectId = 108,
                ClassroomId = 18,
                CalendarId = 1,
            };

            var e16_p2_e013_gr1_18_108_session1 = new Session()
            {
                Id = 140,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 140,
            };
            #endregion

            #region e16_p2_e013_gr1_18_110
            var e16_p2_e013_gr1_18_110 = new Group()
            {
                Id = 141,
                Name = "GR1",
                SubjectId = 110,
                ClassroomId = 18,
                CalendarId = 1,
            };

            var e16_p2_e013_gr1_18_110_session1 = new Session()
            {
                Id = 141,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 141,
            };
            #endregion

            #region e16_p2_e013_gr1_18_88
            var e16_p2_e013_gr1_18_88 = new Group()
            {
                Id = 142,
                Name = "GR1",
                SubjectId = 88,
                ClassroomId = 18,
                CalendarId = 1,
            };

            var e16_p2_e013_gr1_18_88_session1 = new Session()
            {
                Id = 142,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 142,
            };

            var e16_p2_e013_gr1_18_88_session2 = new Session()
            {
                Id = 143,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(10, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 142,
            };
            #endregion
            modelBuilder
                 .Entity<Group>()
                 .HasData(
                                       
         e16_s1_e017_gr1_33_55,
         e16_s1_e017_gr2_33_55,
         e16_s1_e017_gr3_33_55,
         e16_s1_e012b_gr1_32_65,
         e16_s1_e012b_gr2_32_65,
         e16_s1_e012b_gr1_32_60,
         e16_s1_e012b_gr2_32_60,
         e16_s1_e012b_gr3_32_60,
         e16_s1_e012b_gr4_32_60,
         e16_s1_e012b_gr5_32_60,
         e16_s1_e012b_gr6_32_60,
         e16_s1_e012a_gr1_31_62,
         e16_s1_e012a_gr2_31_62,
         e16_s1_e012a_gr3_31_62,
         e16_s1_e012a_gr4_31_62,
         e16_s1_e012a_gr3_31_65,
         e16_s1_e012a_gr4_31_65,
         e16_s1_e012a_gr6_31_65,
         e16_s1_e012a_gr1_1_31_57,
         e16_s1_e011_gr1_1_30_30,
         e16_s1_e011_gr1_2_30_30,
         e16_s1_e011_gr1_3_30_30,
         e16_s1_e011_gr1_4_30_30,
         e16_s1_e011_gr2_1_30_30,
         e16_s1_e011_gr2_2_30_30,
         e16_s1_e011_gr2_3_30_30,
         e16_s1_e011_gr2_4_30_30,
         e16_s1_e011_gr1_1_30_36,
         e16_s1_e011_gr1_2_30_36,
         e16_s1_e011_gr1_3_30_36,
         e16_s1_e011_gr1_4_30_36,
         e16_s1_e011_gr2_1_30_36,
         e16_s1_e011_gr2_2_30_36,
         e16_s1_e011_gr2_3_30_36,
         e16_s1_e011_gr2_4_30_36,
         e16_s1_e005_gr2_29_184,
         e16_s1_e005_gr1_29_99,
         e16_s1_e005_gr1_29_37,
         e16_s1_e005_gr1_29_56,
         e16_s1_e005_gr1_29_59,
         e16_s1_e005_gr1_29_146,
         e16_s1_e004_gr2_28_10,
         e16_s1_e004_gr3_28_14,
         e16_s1_e004_gr1_28_46,
         e16_s1_e004_gr1_28_66,
         e16_s1_e004_gr1_28_64,
         e16_s1_e001_gr1_27_136,
         e16_pb_e026_gr1_26_70,
         e16_pb_e026_gr2_26_70,
         e16_pb_e026_gr4_26_70,
         e16_pb_e026_gr5_26_70,
         e16_pb_e008_gr1_25_98,
         e16_pb_e008_gr2_25_98,
         e16_pb_e008_gr3_25_98,
         e16_pb_e008_gr4_25_98,
         e16_pb_e007_gr1_1_24_91,
         e16_pb_e007_gr1_2_24_91,
         e16_pb_e007_gr1_3_24_91,
         e16_pb_e007_gr1_4_24_91,
         e16_pb_e007_gr2_1_24_91,
         e16_pb_e007_gr2_2_24_91,
         e16_pb_e007_gr2_3_24_91,
         e16_pb_e007_gr1_1_24_34,
         e16_pb_e007_gr1_2_24_34,
         e16_pb_e007_gr1_3_24_34,
         e16_pb_e007_gr1_5_24_34,
         e16_pb_e007_gr2_1_24_34,
         e16_pb_e007_gr2_2_24_34,
         e16_pb_e007_gr2_3_24_34,
         e16_pb_e007_gr2_4_24_34,
         e16_pb_e007_gr2_5_24_34,
         e16_pb_e007_gr3_1_24_34,
         e16_pb_e007_gr3_2_24_34,
         e16_pb_e007_gr3_3_24_34,
         e16_pb_e007_gr3_4_24_34,
         e16_pb_e007_gr3_5_24_34,
         e16_pb_e003_gr2_23_100,
         e16_pb_e003_gr3_23_100,
         e16_pb_e003_gr5_23_100,
         e16_pb_e003_gr6_23_51,
         e16_pb_e002_gr1_1_22_40,
         e16_pb_e002_gr1_2_22_40,
         e16_pb_e002_gr1_3_22_40,
         e16_pb_e002_gr2_2_22_40,
         e16_pb_e002_gr2_3_22_40,
         e16_pb_e002_gr2_4_22_40,
         e16_p2_e020_gr4_21_2,
         e16_p2_e020_gr1_gp_21_3,
         e16_p2_e015_gr3_20_51,
         e16_p2_e015_gr9_20_51,
         e16_p2_e014_gr1_1_19_89,
         e16_p2_e014_gr1_2_19_89,
         e16_p2_e014_gr1_3_19_89,
         e16_p2_e014_gr2_1_19_89,
         e16_p2_e014_gr2_2_19_89,
         e16_p2_e014_gr2_3_19_89,
         e16_p2_e014_gr1_1_19_85,
         e16_p2_e014_gr1_2_19_85,
         e16_p2_e014_gr1_3_19_85,
         e16_p2_e014_gr1_4_19_85,
         e16_p2_e014_gr1_5_19_85,
         e16_p2_e014_gr1_6_19_85,
         e16_p2_e014_gr2_19_88,
         e16_p2_e013_gr1_2_18_38,
         e16_p2_e013_gr1_3_18_38,
         e16_p2_e013_gr1_4_18_38,
         e16_p2_e013_gr2_1_18_38,
         e16_p2_e013_gr2_2_18_38,
         e16_p2_e013_gr2_3_18_38,
         e16_p2_e013_gr1_1_18_93,
         e16_p2_e013_gr1_2_18_93,
         e16_p2_e013_gr1_3_18_93,
         e16_p2_e013_gr1_4_18_93,
         e16_p2_e013_gr1_5_18_93,
         e16_p2_e013_gr1_18_108,
         e16_p2_e013_gr1_18_110,
         e16_p2_e013_gr1_18_88
         

         );

            modelBuilder
                         .Entity<Session>()
                         .HasData(

                            e16_s1_e017_gr1_33_55_session1,
                            e16_s1_e017_gr2_33_55_session1,
                            e16_s1_e017_gr3_33_55_session1,
                            e16_s1_e012b_gr1_32_65_session1,
                            e16_s1_e012b_gr2_32_65_session1,
                            e16_s1_e012b_gr1_32_60_session1,
                            e16_s1_e012b_gr2_32_60_session1,
                            e16_s1_e012b_gr3_32_60_session1,
                            e16_s1_e012b_gr4_32_60_session1,
                            e16_s1_e012b_gr5_32_60_session1,
                            e16_s1_e012b_gr6_32_60_session1,
                            e16_s1_e012a_gr1_31_62_session1,
                            e16_s1_e012a_gr2_31_62_session1,
                            e16_s1_e012a_gr3_31_62_session1,
                            e16_s1_e012a_gr4_31_62_session1,
                            e16_s1_e012a_gr3_31_65_session1,
                            e16_s1_e012a_gr4_31_65_session1,
                            e16_s1_e012a_gr6_31_65_session1,
                            e16_s1_e012a_gr1_1_31_57_session1,
                            e16_s1_e011_gr1_1_30_30_session1,
                            e16_s1_e011_gr1_2_30_30_session1,
                            e16_s1_e011_gr1_3_30_30_session1,
                            e16_s1_e011_gr1_4_30_30_session1,
                            e16_s1_e011_gr2_1_30_30_session1,
                            e16_s1_e011_gr2_2_30_30_session1,
                            e16_s1_e011_gr2_3_30_30_session1,
                            e16_s1_e011_gr2_4_30_30_session1,
                            e16_s1_e011_gr1_1_30_36_session1,
                            e16_s1_e011_gr1_2_30_36_session1,
                            e16_s1_e011_gr1_3_30_36_session1,
                            e16_s1_e011_gr1_4_30_36_session1,
                            e16_s1_e011_gr2_1_30_36_session1,
                            e16_s1_e011_gr2_2_30_36_session1,
                            e16_s1_e011_gr2_3_30_36_session1,
                            e16_s1_e011_gr2_4_30_36_session1,
                            e16_s1_e005_gr2_29_184_session1,
                            e16_s1_e005_gr1_29_99_session1,
                            e16_s1_e005_gr1_29_37_session1,
                            e16_s1_e005_gr1_29_37_session2,
                            e16_s1_e005_gr1_29_56_session1,
                            e16_s1_e005_gr1_29_56_session2,
                            e16_s1_e005_gr1_29_59_session1,
                            e16_s1_e005_gr1_29_59_session2,
                            e16_s1_e005_gr1_29_146_session1,
                            e16_s1_e005_gr1_29_146_session2,
                            e16_s1_e004_gr2_28_10_session1,
                            e16_s1_e004_gr2_28_10_session2,
                            e16_s1_e004_gr3_28_14_session1,
                            e16_s1_e004_gr3_28_14_session2,
                            e16_s1_e004_gr1_28_46_session1,
                            e16_s1_e004_gr1_28_46_session2,
                            e16_s1_e004_gr1_28_66_session1,
                            e16_s1_e004_gr1_28_66_session2,
                            e16_s1_e004_gr1_28_64_session1,
                            e16_s1_e004_gr1_28_64_session2,
                            e16_s1_e001_gr1_27_136_session1,
                            e16_s1_e001_gr1_27_136_session2,
                            e16_pb_e026_gr1_26_70_session1,
                            e16_pb_e026_gr2_26_70_session1,
                            e16_pb_e026_gr4_26_70_session1,
                            e16_pb_e026_gr5_26_70_session1,
                            e16_pb_e008_gr1_25_98_session1,
                            e16_pb_e008_gr2_25_98_session1,
                            e16_pb_e008_gr3_25_98_session1,
                            e16_pb_e008_gr4_25_98_session1,
                            e16_pb_e007_gr1_1_24_91_session1,
                            e16_pb_e007_gr1_2_24_91_session1,
                            e16_pb_e007_gr1_3_24_91_session1,
                            e16_pb_e007_gr1_4_24_91_session1,
                            e16_pb_e007_gr2_1_24_91_session1,
                            e16_pb_e007_gr2_2_24_91_session1,
                            e16_pb_e007_gr2_3_24_91_session1,
                            e16_pb_e007_gr1_1_24_34_session1,
                            e16_pb_e007_gr1_2_24_34_session1,
                            e16_pb_e007_gr1_3_24_34_session1,
                            e16_pb_e007_gr1_5_24_34_session1,
                            e16_pb_e007_gr2_1_24_34_session1,
                            e16_pb_e007_gr2_2_24_34_session1,
                            e16_pb_e007_gr2_3_24_34_session1,
                            e16_pb_e007_gr2_4_24_34_session1,
                            e16_pb_e007_gr2_5_24_34_session1,
                            e16_pb_e007_gr3_1_24_34_session1,
                            e16_pb_e007_gr3_2_24_34_session1,
                            e16_pb_e007_gr3_3_24_34_session1,
                            e16_pb_e007_gr3_4_24_34_session1,
                            e16_pb_e007_gr3_5_24_34_session1,
                            e16_pb_e003_gr2_23_100_session1,
                            e16_pb_e003_gr3_23_100_session1,
                            e16_pb_e003_gr5_23_100_session1,
                            e16_pb_e003_gr6_23_51_session1,
                            e16_pb_e002_gr1_1_22_40_session1,
                            e16_pb_e002_gr1_2_22_40_session1,
                            e16_pb_e002_gr1_3_22_40_session1,
                            e16_pb_e002_gr2_2_22_40_session1,
                            e16_pb_e002_gr2_3_22_40_session1,
                            e16_pb_e002_gr2_4_22_40_session1,
                            e16_p2_e020_gr4_21_2_session1,
                            e16_p2_e020_gr4_21_2_session2,
                            e16_p2_e020_gr1_gp_21_3_session1,
                            e16_p2_e020_gr1_gp_21_3_session2,
                            e16_p2_e015_gr3_20_51_session1,
                            e16_p2_e015_gr3_20_51_session2,
                            e16_p2_e015_gr9_20_51_session1,
                            e16_p2_e015_gr9_20_51_session2,
                            e16_p2_e014_gr1_1_19_89_session1,
                            e16_p2_e014_gr1_2_19_89_session1,
                            e16_p2_e014_gr1_3_19_89_session1,
                            e16_p2_e014_gr2_1_19_89_session1,
                            e16_p2_e014_gr2_2_19_89_session1,
                            e16_p2_e014_gr2_3_19_89_session1,
                            e16_p2_e014_gr1_1_19_85_session1,
                            e16_p2_e014_gr1_2_19_85_session1,
                            e16_p2_e014_gr1_3_19_85_session1,
                            e16_p2_e014_gr1_4_19_85_session1,
                            e16_p2_e014_gr1_5_19_85_session1,
                            e16_p2_e014_gr1_6_19_85_session1,
                            e16_p2_e014_gr2_19_88_session1,
                            e16_p2_e014_gr2_19_88_session2,
                            e16_p2_e013_gr1_2_18_38_session1,
                            e16_p2_e013_gr1_3_18_38_session1,
                            e16_p2_e013_gr1_4_18_38_session1,
                            e16_p2_e013_gr2_1_18_38_session1,
                            e16_p2_e013_gr2_2_18_38_session1,
                            e16_p2_e013_gr2_3_18_38_session1,
                            e16_p2_e013_gr1_1_18_93_session1,
                            e16_p2_e013_gr1_2_18_93_session1,
                            e16_p2_e013_gr1_3_18_93_session1,
                            e16_p2_e013_gr1_4_18_93_session1,
                            e16_p2_e013_gr1_5_18_93_session1,
                            e16_p2_e013_gr1_18_108_session1,
                            e16_p2_e013_gr1_18_110_session1,
                            e16_p2_e013_gr1_18_88_session1,
                            e16_p2_e013_gr1_18_88_session2
            

                         );


            #endregion

            #region EDIFICIO 17
            #region e17_mz_e002_gr1_34_111
            var e17_mz_e002_gr1_34_111 = new Group()
            {
                Id = 1, // El ID del grupo se incrementará automáticamente
                Name = "GR1",
                SubjectId = 111,
                ClassroomId = 34,
                CalendarId = 1,
            };

            var e17_mz_e002_gr1_34_111_session1 = new Session()
            {
                Id = 1, // El ID de la sesión se incrementará automáticamente
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(8, 0, 0),
                GroupId = e17_mz_e002_gr1_34_111.Id,
            };
            #endregion
            #region e17_mz_e002_gr2_34_111
            var e17_mz_e002_gr2_34_111 = new Group()
            {
                Id = 2,
                Name = "GR2",
                SubjectId = 111,
                ClassroomId = 34,
                CalendarId = 1,
            };

            var e17_mz_e002_gr2_34_111_session1 = new Session()
            {
                Id = 2,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(10, 0, 0),
                GroupId = 2,
            };
            #endregion

            #region e17_mz_e002_gr3_34_111
            var e17_mz_e002_gr3_34_111 = new Group()
            {
                Id = 3,
                Name = "GR3",
                SubjectId = 111,
                ClassroomId = 34,
                CalendarId = 1,
            };

            var e17_mz_e002_gr3_34_111_session1 = new Session()
            {
                Id = 3,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(15, 0, 0),
                GroupId = 3,
            };
            #endregion
            //AULAS EDIFIO 17
            //AULA E17/MZ/E004
            #region e17_mz_e004_gr1_35_109
            var e17_mz_e004_gr1_35_109 = new Group()
            {
                Id = 4,
                Name = "GR1",
                SubjectId = 109,
                ClassroomId = 35,
                CalendarId = 1,
            };

            var e17_mz_e004_gr1_35_109_session1 = new Session()
            {
                Id = 4,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 4,
            };
            #endregion

            #region e17_mz_e004_gr2_35_109
            var e17_mz_e004_gr2_35_109 = new Group()
            {
                Id = 5,
                Name = "GR2",
                SubjectId = 109,
                ClassroomId = 35,
                CalendarId = 1,
            };

            var e17_mz_e004_gr2_35_109_session1 = new Session()
            {
                Id = 5,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 5,
            };
            #endregion

            #region e17_mz_e004_gr3_35_109
            var e17_mz_e004_gr3_35_109 = new Group()
            {
                Id = 6,
                Name = "GR3",
                SubjectId = 109,
                ClassroomId = 35,
                CalendarId = 1,
            };

            var e17_mz_e004_gr3_35_109_session1 = new Session()
            {
                Id = 6,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 6,
            };
            #endregion

            #region e17_mz_e004_gr4_35_109
            var e17_mz_e004_gr4_35_109 = new Group()
            {
                Id = 7,
                Name = "GR4",
                SubjectId = 109,
                ClassroomId = 35,
                CalendarId = 1,
            };

            var e17_mz_e004_gr4_35_109_session1 = new Session()
            {
                Id = 7,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 7,
            };
            #endregion
            //AULA E17/P6/E023
            #region e17_p6_e023_gr1_85_151
            var e17_p6_e023_gr1_85_151 = new Group()
            {
                Id = 143,
                Name = "GR1",
                SubjectId = 151,
                ClassroomId = 85,
                CalendarId = 1,
            };

            var e17_p6_e023_gr1_85_151_session1 = new Session()
            {
                Id = 144,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 143,
            };
            #endregion
            #region e17_p6_e023_gr1_85_176
            var e17_p6_e023_gr1_85_176 = new Group()
            {
                Id = 145,
                Name = "GR1",
                SubjectId = 176,
                ClassroomId = 85,
                CalendarId = 1,
            };

            var e17_p6_e023_gr1_85_176_session1 = new Session()
            {
                Id = 146,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 145,
            };

            var e17_p6_e023_gr1_85_176_session2 = new Session()
            {
                Id = 147,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 145,
            };
            #endregion

            #region e17_p6_e023_gr1_85_12
            var e17_p6_e023_gr1_85_12 = new Group()
            {
                Id = 148,
                Name = "GR1",
                SubjectId = 12,
                ClassroomId = 85,
                CalendarId = 1,
            };

            var e17_p6_e023_gr1_85_12_session1 = new Session()
            {
                Id = 149,
                Day = Enum.Day.Domingo,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 148,
            };

            var e17_p6_e023_gr1_85_12_session2 = new Session()
            {
                Id = 150,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(10, 0, 0),
                GroupId = 148,
            };
            #endregion

            #region e17_p6_e023_gr6_85_12
            var e17_p6_e023_gr6_85_12 = new Group()
            {
                Id = 151,
                Name = "GR6",
                SubjectId = 12,
                ClassroomId = 85,
                CalendarId = 1,
            };

            var e17_p6_e023_gr6_85_12_session1 = new Session()
            {
                Id = 152,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(12, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 151,
            };

            var e17_p6_e023_gr6_85_12_session2 = new Session()
            {
                Id = 153,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 151,
            };
            #endregion

            #region e17_p6_e023_gr2_85_186
            var e17_p6_e023_gr2_85_186 = new Group()
            {
                Id = 154,
                Name = "GR2",
                SubjectId = 186,
                ClassroomId = 85,
                CalendarId = 1,
            };

            var e17_p6_e023_gr2_85_186_session1 = new Session()
            {
                Id = 155,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 154,
            };

            var e17_p6_e023_gr2_85_186_session2 = new Session()
            {
                Id = 156,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 154,
            };
            #endregion
            //AULA E17/P6/E027

            #region e17_p6_e027_gr11_87_6
            var e17_p6_e027_gr11_87_6 = new Group()
            {
                Id = 157,
                Name = "GR11",
                SubjectId = 6,
                ClassroomId = 87,
                CalendarId = 1,
            };

            var e17_p6_e027_gr11_87_6_session1 = new Session()
            {
                Id = 158,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 157,
            };
            #endregion

            #region e17_p6_e027_gr2_87_6
            var e17_p6_e027_gr2_87_6 = new Group()
            {
                Id = 159,
                Name = "GR2",
                SubjectId = 6,
                ClassroomId = 87,
                CalendarId = 1,
            };

            var e17_p6_e027_gr2_87_6_session1 = new Session()
            {
                Id = 160,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 159,
            };
            #endregion

            #region e17_p6_e027_gr2_87_167
            var e17_p6_e027_gr2_87_167 = new Group()
            {
                Id = 161,
                Name = "GR2",
                SubjectId = 167,
                ClassroomId = 87,
                CalendarId = 1,
            };

            var e17_p6_e027_gr2_87_167_session1 = new Session()
            {
                Id = 162,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 161,
            };
            #endregion
            #region e17_p6_e027_gr11_87_12
            var e17_p6_e027_gr11_87_12 = new Group()
            {
                Id = 163,
                Name = "GR11",
                SubjectId = 12,
                ClassroomId = 87,
                CalendarId = 1,
            };

            var e17_p6_e027_gr11_87_12_session1 = new Session()
            {
                Id = 164,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 163,
            };

            var e17_p6_e027_gr11_87_12_session2 = new Session()
            {
                Id = 165,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(15, 0, 0),
                GroupId = 163,
            };
            #endregion

            #region e17_p6_e027_gr5_87_12
            var e17_p6_e027_gr5_87_12 = new Group()
            {
                Id = 166,
                Name = "GR5",
                SubjectId = 12,
                ClassroomId = 87,
                CalendarId = 1,
            };

            var e17_p6_e027_gr5_87_12_session1 = new Session()
            {
                Id = 167,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 166,
            };

            var e17_p6_e027_gr5_87_12_session2 = new Session()
            {
                Id = 168,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(10, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 166,
            };
            #endregion

            #region e17_p6_e027_gr1_87_177
            var e17_p6_e027_gr1_87_177 = new Group()
            {
                Id = 169,
                Name = "GR1",
                SubjectId = 177,
                ClassroomId = 87,
                CalendarId = 1,
            };

            var e17_p6_e027_gr1_87_177_session1 = new Session()
            {
                Id = 170,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 169,
            };

            var e17_p6_e027_gr1_87_177_session2 = new Session()
            {
                Id = 171,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 169,
            };

            var e17_p6_e027_gr1_87_177_session3 = new Session()
            {
                Id = 172,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(10, 0, 0),
                GroupId = 169,
            };
            #endregion

            //AULA E17/P6/E003

            var e17_p6_e003_gr7_82_51 = new Group()
            {
                Id = 172,
                Name = "GR7",
                SubjectId = 51,
                ClassroomId = 82,
                CalendarId = 1,
            };

            var e17_p6_e003_gr7_82_51_session1 = new Session()
            {
                Id = 173,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(15, 0, 0),
                GroupId = 172,
            };

            var e17_p6_e003_gr7_82_51_session2 = new Session()
            {
                Id = 174,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(15, 0, 0),
                EndTime = new TimeSpan(17, 0, 0),
                GroupId = 172,
            };


            // AULA E17/P6/E002
            #region e17_p6_e002_gr1_1_83
            var e17_p6_e002_gr1_1_83 = new Group()
            {
                Id = 175, // Cambiado el ID del grupo a 175
                Name = "GR1-1",
                SubjectId = 83, // Cambiado el ID de la materia a 83
                ClassroomId = 81, // Cambiado el ID del aula a 81
                CalendarId = 1,
            };

            var e17_p6_e002_gr1_1_83_session1 = new Session()
            {
                Id = 175, // Cambiado el ID de la sesión a 175
                Day = Enum.Day.Viernes, // Cambiado el día a Viernes
                StartTime = new TimeSpan(7, 0, 0), // Cambiado la hora de inicio a las 7:00 AM
                EndTime = new TimeSpan(9, 0, 0), // Cambiado la hora de finalización a las 9:00 AM
                GroupId = 175, // Cambiado el ID del grupo
            };
            #endregion

            #region e17_p6_e002_gr1_2_83
            var e17_p6_e002_gr1_2_83 = new Group()
            {
                Id = 178, // ID del grupo incrementado automáticamente
                Name = "GR1-2",
                SubjectId = 83,
                ClassroomId = 81,
                CalendarId = 1,
            };

            var e17_p6_e002_gr1_2_83_session1 = new Session()
            {
                Id = 178, // ID de la sesión incrementado automáticamente
                Day = Enum.Day.Viernes, // Día corregido a Viernes
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 178, // ID del grupo correspondiente
            };
            #endregion
            #region e17_p6_e002_gr1_3_83
            var e17_p6_e002_gr1_3_83 = new Group()
            {
                Id = 179,
                Name = "GR1-3",
                SubjectId = 83,
                ClassroomId = 81,
                CalendarId = 1,
            };

            var e17_p6_e002_gr1_3_83_session1 = new Session()
            {
                Id = 179,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 179,
            };
            #endregion

            #region e17_p6_e002_gr1_4_83
            var e17_p6_e002_gr1_4_83 = new Group()
            {
                Id = 180,
                Name = "GR1-4",
                SubjectId = 83,
                ClassroomId = 81,
                CalendarId = 1,
            };

            var e17_p6_e002_gr1_4_83_session1 = new Session()
            {
                Id = 180,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 180,
            };
            #endregion

            #region e17_p6_e002_gr1_5_83
            var e17_p6_e002_gr1_5_83 = new Group()
            {
                Id = 181,
                Name = "GR1-5",
                SubjectId = 83,
                ClassroomId = 81,
                CalendarId = 1,
            };

            var e17_p6_e002_gr1_5_83_session1 = new Session()
            {
                Id = 181,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 181,
            };
            #endregion
            #region e17_p6_e002_gr1_6_83
            var e17_p6_e002_gr1_6_83 = new Group()
            {
                Id = 182,
                Name = "GR1-6",
                SubjectId = 83,
                ClassroomId = 81,
                CalendarId = 1,
            };

            var e17_p6_e002_gr1_6_83_session1 = new Session()
            {
                Id = 182,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 182,
            };
            #endregion

            #region e17_p6_e002_gr1_7_83
            var e17_p6_e002_gr1_7_83 = new Group()
            {
                Id = 183,
                Name = "GR1-7",
                SubjectId = 83,
                ClassroomId = 81,
                CalendarId = 1,
            };

            var e17_p6_e002_gr1_7_83_session1 = new Session()
            {
                Id = 183,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 183,
            };
            #endregion
            //AULA E17/P5/E029
            #region e17_p5_e029_gr3_10
            var e17_p5_e029_gr3_10 = new Group()
            {
                Id = 184, // Continuando la numeración de IDs
                Name = "GR3",
                SubjectId = 10,
                ClassroomId = 80,
                CalendarId = 1,
            };

            var e17_p5_e029_gr3_10_session1 = new Session()
            {
                Id = 184, // Continuando la numeración de IDs
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 184,
            };

            var e17_p5_e029_gr3_10_session2 = new Session()
            {
                Id = 185, // Incrementando la numeración de IDs
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(12, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 184,
            };
            #endregion

            #region e17_p5_e029_gr1_8
            var e17_p5_e029_gr1_8 = new Group()
            {
                Id = 185, // Continuando la numeración de IDs
                Name = "GR1",
                SubjectId = 8,
                ClassroomId = 80,
                CalendarId = 1,
            };

            var e17_p5_e029_gr1_8_session1 = new Session()
            {
                Id = 186, // Incrementando la numeración de IDs
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 185,
            };

            var e17_p5_e029_gr1_8_session2 = new Session()
            {
                Id = 187, // Incrementando la numeración de IDs
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 185,
            };
            #endregion
            #region e17_p5_e029_gr1_14
            var e17_p5_e029_gr1_14 = new Group()
            {
                Id = 188,
                Name = "GR1",
                SubjectId = 14,
                ClassroomId = 80,
                CalendarId = 1,
            };

            var e17_p5_e029_gr1_14_session1 = new Session()
            {
                Id = 188,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 188,
            };

            var e17_p5_e029_gr1_14_session2 = new Session()
            {
                Id = 189,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(10, 0, 0),
                GroupId = 188,
            };
            #endregion

            #region e17_p5_e029_gr5_22
            var e17_p5_e029_gr5_22 = new Group()
            {
                Id = 189,
                Name = "GR5",
                SubjectId = 22,
                ClassroomId = 80,
                CalendarId = 1,
            };

            var e17_p5_e029_gr5_22_session1 = new Session()
            {
                Id = 190,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(15, 0, 0),
                GroupId = 189,
            };

            var e17_p5_e029_gr5_22_session2 = new Session()
            {
                Id = 191,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 189,
            };
            #endregion
            #region e17_p5_e029_gr1_68
            var e17_p5_e029_gr1_68 = new Group()
            {
                Id = 190, // Continuando la numeración de IDs
                Name = "GR1",
                SubjectId = 68,
                ClassroomId = 80,
                CalendarId = 1,
            };

            var e17_p5_e029_gr1_68_session1 = new Session()
            {
                Id = 192, // Continuando la numeración de IDs
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(10, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 190,
            };
            #endregion
            #region e17_p5_e029_gr1_68_4
            var e17_p5_e029_gr1_68_4 = new Group()
            {
                Id = 191, // Continuando la numeración de IDs
                Name = "GR1",
                SubjectId = 68,
                ClassroomId = 80,
                CalendarId = 1,
            };

            var e17_p5_e029_gr1_68_4_session1 = new Session()
            {
                Id = 195, // Continuando la numeración de IDs
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 191,
            };
            #endregion

            #region e17_p5_e029_gr1_187_1
            var e17_p5_e029_gr1_187_1 = new Group()
            {
                Id = 192, // Continuando la numeración de IDs
                Name = "GR1",
                SubjectId = 187,
                ClassroomId = 80,
                CalendarId = 1,
            };

            var e17_p5_e029_gr1_187_1_session1 = new Session()
            {
                Id = 196, // Continuando la numeración de IDs
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 192,
            };
            #endregion
            #region e17_p5_e029_gr1_10_2
            var e17_p5_e029_gr1_10_2 = new Group()
            {
                Id = 193, // Continuando la numeración de IDs
                Name = "GR1",
                SubjectId = 10,
                ClassroomId = 80,
                CalendarId = 1,
            };

            var e17_p5_e029_gr1_10_2_session1 = new Session()
            {
                Id = 197, // Continuando la numeración de IDs
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(12, 0, 0),
                GroupId = 193,
            };
            #endregion
            //AULA E17/P5/E028
            #region e17_p5_e028_gr6_79
            var e17_p5_e028_gr6_79 = new Group()
            {
                Id = 194, // Continuando la numeración de IDs
                Name = "GR6",
                SubjectId = 1,
                ClassroomId = 79,
                CalendarId = 1,
            };

            var e17_p5_e028_gr6_79_session1 = new Session()
            {
                Id = 198, // Continuando la numeración de IDs
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 194,
            };

            var e17_p5_e028_gr6_79_session2 = new Session()
            {
                Id = 199, // Incrementando la numeración de IDs
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 194,
            };
            #endregion

            #region e17_p5_e028_gr1_GP_79
            var e17_p5_e028_gr1_GP_79 = new Group()
            {
                Id = 195, // Continuando la numeración de IDs
                Name = "GR1-GP",
                SubjectId = 2,
                ClassroomId = 79,
                CalendarId = 1,
            };

            var e17_p5_e028_gr1_GP_79_session1 = new Session()
            {
                Id = 200, // Continuando la numeración de IDs
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 195,
            };

            var e17_p5_e028_gr1_GP_79_session2 = new Session()
            {
                Id = 201, // Incrementando la numeración de IDs
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 195,
            };
            #endregion
            #region e17_p5_e028_gr6_79_2
            var e17_p5_e028_gr6_79_2 = new Group()
            {
                Id = 196, // Continuando la numeración de IDs
                Name = "GR6",
                SubjectId = 2,
                ClassroomId = 79,
                CalendarId = 1,
            };

            var e17_p5_e028_gr6_79_2_session1 = new Session()
            {
                Id = 202, // Continuando la numeración de IDs
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 196,
            };

            var e17_p5_e028_gr6_79_2_session2 = new Session()
            {
                Id = 203, // Incrementando la numeración de IDs
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 196,
            };
            #endregion

            #region e17_p5_e028_gr2_79_8
            var e17_p5_e028_gr2_79_8 = new Group()
            {
                Id = 197, // Continuando la numeración de IDs
                Name = "GR2",
                SubjectId = 8,
                ClassroomId = 79,
                CalendarId = 1,
            };

            var e17_p5_e028_gr2_79_8_session1 = new Session()
            {
                Id = 204, // Continuando la numeración de IDs
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 197,
            };

            var e17_p5_e028_gr2_79_8_session2 = new Session()
            {
                Id = 205, // Incrementando la numeración de IDs
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 197,
            };
            #endregion

            #region e17_p5_e028_gr2_79_14
            var e17_p5_e028_gr2_79_14 = new Group()
            {
                Id = 198, // Continuando la numeración de IDs
                Name = "GR2",
                SubjectId = 14,
                ClassroomId = 79,
                CalendarId = 1,
            };

            var e17_p5_e028_gr2_79_14_session1 = new Session()
            {
                Id = 206, // Continuando la numeración de IDs
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 198,
            };

            var e17_p5_e028_gr2_79_14_session2 = new Session()
            {
                Id = 207, // Incrementando la numeración de IDs
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 198,
            };
            #endregion
            #region e17_p5_e028_gr4_79_14
            var e17_p5_e028_gr4_79_14 = new Group()
            {
                Id = 199, // Continuando la numeración de IDs
                Name = "GR4",
                SubjectId = 14,
                ClassroomId = 79,
                CalendarId = 1,
            };

            var e17_p5_e028_gr4_79_14_session1 = new Session()
            {
                Id = 208, // Continuando la numeración de IDs
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 199,
            };

            var e17_p5_e028_gr4_79_14_session2 = new Session()
            {
                Id = 209, // Incrementando la numeración de IDs
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(10, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 199,
            };
            #endregion

            #region e17_p5_e028_gr6_79_3
            var e17_p5_e028_gr6_79_3 = new Group()
            {
                Id = 200, // Continuando la numeración de IDs
                Name = "GR6",
                SubjectId = 3,
                ClassroomId = 79,
                CalendarId = 1,
            };

            var e17_p5_e028_gr6_79_3_session1 = new Session()
            {
                Id = 210, // Continuando la numeración de IDs
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 200,
            };

            var e17_p5_e028_gr6_79_3_session2 = new Session()
            {
                Id = 211, // Incrementando la numeración de IDs
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 200,
            };
            #endregion

            #region e17_p5_e028_gr2_GP_79_9
            var e17_p5_e028_gr2_GP_79_9 = new Group()
            {
                Id = 201, // Continuando la numeración de IDs
                Name = "GR2-GP",
                SubjectId = 9,
                ClassroomId = 79,
                CalendarId = 1,
            };

            var e17_p5_e028_gr2_GP_79_9_session1 = new Session()
            {
                Id = 212, // Continuando la numeración de IDs
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 201,
            };

            var e17_p5_e028_gr2_GP_79_9_session2 = new Session()
            {
                Id = 213, // Incrementando la numeración de IDs
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 201,
            };
            #endregion
            #region e17_p5_e028_gr6_79_5
            var e17_p5_e028_gr6_79_5 = new Group()
            {
                Id = 202, // Continuando la numeración de IDs
                Name = "GR6",
                SubjectId = 5,
                ClassroomId = 79,
                CalendarId = 1,
            };

            var e17_p5_e028_gr6_79_5_session1 = new Session()
            {
                Id = 214, // Continuando la numeración de IDs
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 202,
            };

            var e17_p5_e028_gr6_79_5_session2 = new Session()
            {
                Id = 215, // Incrementando la numeración de IDs
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 202,
            };
            #endregion

            #region e17_p5_e028_gr2_79_27
            var e17_p5_e028_gr2_79_27 = new Group()
            {
                Id = 203, // Continuando la numeración de IDs
                Name = "GR2",
                SubjectId = 27,
                ClassroomId = 79,
                CalendarId = 1,
            };

            var e17_p5_e028_gr2_79_27_session1 = new Session()
            {
                Id = 216, // Continuando la numeración de IDs
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 203,
            };

            var e17_p5_e028_gr2_79_27_session2 = new Session()
            {
                Id = 217, // Incrementando la numeración de IDs
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(10, 0, 0),
                GroupId = 203,
            };
            #endregion

            //AULA E17/P5/E020
            #region e17_p5_e020_gr2_77_25
            var e17_p5_e020_gr2_77_25 = new Group()
            {
                Id = 204, // Continuando la numeración de IDs
                Name = "GR2",
                SubjectId = 25,
                ClassroomId = 77,
                CalendarId = 1,
            };

            var e17_p5_e020_gr2_77_25_session1 = new Session()
            {
                Id = 218, // Continuando la numeración de IDs
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 204,
            };

            var e17_p5_e020_gr2_77_25_session2 = new Session()
            {
                Id = 219, // Incrementando la numeración de IDs
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 204,
            };
            #endregion

            #region e17_p5_e020_gr1_77_44
            var e17_p5_e020_gr1_77_44 = new Group()
            {
                Id = 205, // Continuando la numeración de IDs
                Name = "GR1",
                SubjectId = 44,
                ClassroomId = 77,
                CalendarId = 1,
            };

            var e17_p5_e020_gr1_77_44_session1 = new Session()
            {
                Id = 220, // Continuando la numeración de IDs
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 205,
            };

            var e17_p5_e020_gr1_77_44_session2 = new Session()
            {
                Id = 221, // Incrementando la numeración de IDs
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(8, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 205,
            };
            #endregion

            #region e17_p5_e020_gr3_77_26
            var e17_p5_e020_gr3_77_26 = new Group()
            {
                Id = 206, // Continuando la numeración de IDs
                Name = "GR3",
                SubjectId = 26,
                ClassroomId = 77,
                CalendarId = 1,
            };

            var e17_p5_e020_gr3_77_26_session1 = new Session()
            {
                Id = 222, // Continuando la numeración de IDs
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 206,
            };

            var e17_p5_e020_gr3_77_26_session2 = new Session()
            {
                Id = 223, // Incrementando la numeración de IDs
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 206,
            };
            #endregion
            #region e17_p5_e020_gr1_77_90
            var e17_p5_e020_gr1_77_90 = new Group()
            {
                Id = 207, // Continuando la numeración de IDs
                Name = "GR1",
                SubjectId = 90,
                ClassroomId = 77,
                CalendarId = 1,
            };

            var e17_p5_e020_gr1_77_90_session1 = new Session()
            {
                Id = 224, // Continuando la numeración de IDs
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 207,
            };

            var e17_p5_e020_gr1_77_90_session2 = new Session()
            {
                Id = 225, // Incrementando la numeración de IDs
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(10, 0, 0),
                GroupId = 207,
            };
            #endregion

            #region e17_p5_e020_gr1_77_86
            var e17_p5_e020_gr1_77_86 = new Group()
            {
                Id = 208, // Continuando la numeración de IDs
                Name = "GR1",
                SubjectId = 86,
                ClassroomId = 77,
                CalendarId = 1,
            };

            var e17_p5_e020_gr1_77_86_session1 = new Session()
            {
                Id = 226, // Continuando la numeración de IDs
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(10, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 208,
            };

            var e17_p5_e020_gr1_77_86_session2 = new Session()
            {
                Id = 227, // Incrementando la numeración de IDs
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 208,
            };
            #endregion
            #region e17_p5_e020_gr2_77_49
            var e17_p5_e020_gr2_77_49 = new Group()
            {
                Id = 209, // Continuando la numeración de IDs
                Name = "GR2",
                SubjectId = 49,
                ClassroomId = 77,
                CalendarId = 1,
            };

            var e17_p5_e020_gr2_77_49_session1 = new Session()
            {
                Id = 228, // Continuando la numeración de IDs
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 209,
            };
            #endregion

            #region e17_p5_e020_gr1_77_61
            var e17_p5_e020_gr1_77_61 = new Group()
            {
                Id = 210, // Continuando la numeración de IDs
                Name = "GR1",
                SubjectId = 61,
                ClassroomId = 77,
                CalendarId = 1,
            };

            var e17_p5_e020_gr1_77_61_session1 = new Session()
            {
                Id = 229, // Continuando la numeración de IDs
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(12, 0, 0),
                GroupId = 210,
            };
            #endregion

            #region e17_p5_e020_gr1_77_69
            var e17_p5_e020_gr1_77_69 = new Group()
            {
                Id = 211, // Continuando la numeración de IDs
                Name = "GR1",
                SubjectId = 69,
                ClassroomId = 77,
                CalendarId = 1,
            };

            var e17_p5_e020_gr1_77_69_session1 = new Session()
            {
                Id = 230, // Continuando la numeración de IDs
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 211,
            };
            #endregion
            //AULA E17/P4/E023

            #region e17_p4_e023_gr1_74_10
            var e17_p4_e023_gr1_74_10 = new Group()
            {
                Id = 212, // Continuando la numeración de IDs
                Name = "GR1",
                SubjectId = 10,
                ClassroomId = 74,
                CalendarId = 1,
            };

            var e17_p4_e023_gr1_74_10_session1 = new Session()
            {
                Id = 231, // Continuando la numeración de IDs
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 212,
            };
            #endregion

            #region e17_p4_e023_gr1_74_182
            var e17_p4_e023_gr1_74_182 = new Group()
            {
                Id = 213, // Continuando la numeración de IDs
                Name = "GR1",
                SubjectId = 182,
                ClassroomId = 74,
                CalendarId = 1,
            };

            var e17_p4_e023_gr1_74_182_session1 = new Session()
            {
                Id = 232, // Continuando la numeración de IDs
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 213,
            };
            #endregion

            #region e17_p4_e023_gr1_74_101
            var e17_p4_e023_gr1_74_101 = new Group()
            {
                Id = 214, // Continuando la numeración de IDs
                Name = "GR1",
                SubjectId = 101,
                ClassroomId = 74,
                CalendarId = 1,
            };

            var e17_p4_e023_gr1_74_101_session1 = new Session()
            {
                Id = 233, // Continuando la numeración de IDs
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 214,
            };
            #endregion
            #region e17_p4_e023_gr1_74_19
            var e17_p4_e023_gr1_74_19 = new Group()
            {
                Id = 215, // Continuando la numeración de IDs
                Name = "GR1",
                SubjectId = 19,
                ClassroomId = 74,
                CalendarId = 1,
            };

            var e17_p4_e023_gr1_74_19_session1 = new Session()
            {
                Id = 234, // Continuando la numeración de IDs
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 215,
            };

            var e17_p4_e023_gr1_74_19_session2 = new Session()
            {
                Id = 235, // Incrementando la numeración de IDs
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(8, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 215,
            };
            #endregion

            #region e17_p4_e023_gr3_74_19
            var e17_p4_e023_gr3_74_19 = new Group()
            {
                Id = 216, // Continuando la numeración de IDs
                Name = "GR3",
                SubjectId = 19,
                ClassroomId = 74,
                CalendarId = 1,
            };

            var e17_p4_e023_gr3_74_19_session1 = new Session()
            {
                Id = 236, // Continuando la numeración de IDs
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 216,
            };

            var e17_p4_e023_gr3_74_19_session2 = new Session()
            {
                Id = 237, // Incrementando la numeración de IDs
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(12, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 216,
            };
            #endregion
            #region e17_p4_e023_gr2_74_22
            var e17_p4_e023_gr2_74_22 = new Group()
            {
                Id = 217, // Continuando la numeración de IDs
                Name = "GR2",
                SubjectId = 22,
                ClassroomId = 74,
                CalendarId = 1,
            };

            var e17_p4_e023_gr2_74_22_session1 = new Session()
            {
                Id = 238, // Continuando la numeración de IDs
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 217,
            };

            var e17_p4_e023_gr2_74_22_session2 = new Session()
            {
                Id = 239, // Incrementando la numeración de IDs
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(8, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 217,
            };
            #endregion

            #region e17_p4_e023_gr4_74_16
            var e17_p4_e023_gr4_74_16 = new Group()
            {
                Id = 218, // Continuando la numeración de IDs
                Name = "GR4",
                SubjectId = 16,
                ClassroomId = 74,
                CalendarId = 1,
            };

            var e17_p4_e023_gr4_74_16_session1 = new Session()
            {
                Id = 240, // Continuando la numeración de IDs
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 218,
            };

            var e17_p4_e023_gr4_74_16_session2 = new Session()
            {
                Id = 241, // Incrementando la numeración de IDs
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(15, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 218,
            };
            #endregion

            #region e17_p4_e023_gr4_74_17
            var e17_p4_e023_gr4_74_17 = new Group()
            {
                Id = 219, // Continuando la numeración de IDs
                Name = "GR4",
                SubjectId = 17,
                ClassroomId = 74,
                CalendarId = 1,
            };

            var e17_p4_e023_gr4_74_17_session1 = new Session()
            {
                Id = 242, // Continuando la numeración de IDs
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 219,
            };

            var e17_p4_e023_gr4_74_17_session2 = new Session()
            {
                Id = 243, // Incrementando la numeración de IDs
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(8, 0, 0),
                GroupId = 219,
            };
            #endregion
            #region e17_p4_e023_gr1_74_126
            var e17_p4_e023_gr1_74_126 = new Group()
            {
                Id = 220, // Continuando la numeración de IDs
                Name = "GR1",
                SubjectId = 126,
                ClassroomId = 74,
                CalendarId = 1,
            };

            var e17_p4_e023_gr1_74_126_session1 = new Session()
            {
                Id = 244, // Continuando la numeración de IDs
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(8, 0, 0),
                GroupId = 220,
            };

            var e17_p4_e023_gr1_74_126_session2 = new Session()
            {
                Id = 245, // Incrementando la numeración de IDs
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 220,
            };
            #endregion

            #region e17_p4_e023_gr1_74_130
            var e17_p4_e023_gr1_74_130 = new Group()
            {
                Id = 221, // Continuando la numeración de IDs
                Name = "GR1",
                SubjectId = 130,
                ClassroomId = 74,
                CalendarId = 1,
            };

            var e17_p4_e023_gr1_74_130_session1 = new Session()
            {
                Id = 246, // Continuando la numeración de IDs
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(8, 0, 0),
                GroupId = 221,
            };

            var e17_p4_e023_gr1_74_130_session2 = new Session()
            {
                Id = 247, // Incrementando la numeración de IDs
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 221,
            };
            #endregion



            //AULA E17/P4/E022 ********
            #region e17_p4_e022_gr1_73_26
            var e17_p4_e022_gr1_73_26 = new Group()
            {
                Id = 222, // Continuando la numeración de IDs
                Name = "GR1",
                SubjectId = 26,
                ClassroomId = 73,
                CalendarId = 1,
            };

            var e17_p4_e022_gr1_73_26_session1 = new Session()
            {
                Id = 248, // Continuando la numeración de IDs
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 222,
            };

            var e17_p4_e022_gr1_73_26_session2 = new Session()
            {
                Id = 249, // Incrementando la numeración de IDs
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 222,
            };
            #endregion

            #region e17_p4_e022_gr1_73_33
            var e17_p4_e022_gr1_73_33 = new Group()
            {
                Id = 223, // Continuando la numeración de IDs
                Name = "GR1",
                SubjectId = 33,
                ClassroomId = 73,
                CalendarId = 1,
            };

            var e17_p4_e022_gr1_73_33_session1 = new Session()
            {
                Id = 250, // Continuando la numeración de IDs
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 223,
            };

            var e17_p4_e022_gr1_73_33_session2 = new Session()
            {
                Id = 251, // Incrementando la numeración de IDs
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(12, 0, 0),
                GroupId = 223,
            };
            #endregion

            #region e17_p4_e022_gr1_73_92
            var e17_p4_e022_gr1_73_92 = new Group()
            {
                Id = 224, // Continuando la numeración de IDs
                Name = "GR1",
                SubjectId = 92,
                ClassroomId = 73,
                CalendarId = 1,
            };

            var e17_p4_e022_gr1_73_92_session1 = new Session()
            {
                Id = 252, // Continuando la numeración de IDs
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 224,
            };

            var e17_p4_e022_gr1_73_92_session2 = new Session()
            {
                Id = 253, // Incrementando la numeración de IDs
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 224,
            };
            #endregion
            #region e17_p4_e022_gr1_73_21
            var e17_p4_e022_gr1_73_21 = new Group()
            {
                Id = 225, // Continuando la numeración de IDs
                Name = "GR1",
                SubjectId = 21,
                ClassroomId = 73,
                CalendarId = 1,
            };

            var e17_p4_e022_gr1_73_21_session1 = new Session()
            {
                Id = 254, // Continuando la numeración de IDs
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 225,
            };

            var e17_p4_e022_gr1_73_21_session2 = new Session()
            {
                Id = 255, // Incrementando la numeración de IDs
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 225,
            };
            #endregion

            #region e17_p4_e022_gr3_73_21
            var e17_p4_e022_gr3_73_21 = new Group()
            {
                Id = 226, // Continuando la numeración de IDs
                Name = "GR3",
                SubjectId = 21,
                ClassroomId = 73,
                CalendarId = 1,
            };

            var e17_p4_e022_gr3_73_21_session1 = new Session()
            {
                Id = 256, // Continuando la numeración de IDs
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 226,
            };

            var e17_p4_e022_gr3_73_21_session2 = new Session()
            {
                Id = 257, // Incrementando la numeración de IDs
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 226,
            };
            #endregion
            #region e17_p4_e022_gr2_73_19
            var e17_p4_e022_gr2_73_19 = new Group()
            {
                Id = 227, // Continuando la numeración de IDs
                Name = "GR2",
                SubjectId = 19,
                ClassroomId = 73,
                CalendarId = 1,
            };

            var e17_p4_e022_gr2_73_19_session1 = new Session()
            {
                Id = 258, // Continuando la numeración de IDs
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 227,
            };

            var e17_p4_e022_gr2_73_19_session2 = new Session()
            {
                Id = 259, // Incrementando la numeración de IDs
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(8, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 227,
            };
            #endregion

            #region e17_p4_e022_gr4_73_19
            var e17_p4_e022_gr4_73_19 = new Group()
            {
                Id = 228, // Continuando la numeración de IDs
                Name = "GR4",
                SubjectId = 19,
                ClassroomId = 73,
                CalendarId = 1,
            };

            var e17_p4_e022_gr4_73_19_session1 = new Session()
            {
                Id = 260, // Continuando la numeración de IDs
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 228,
            };

            var e17_p4_e022_gr4_73_19_session2 = new Session()
            {
                Id = 261, // Incrementando la numeración de IDs
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(12, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 228,
            };
            #endregion
            #region e17_p4_e022_gr1_73_47
            var e17_p4_e022_gr1_73_47 = new Group()
            {
                Id = 229, // Continuando la numeración de IDs
                Name = "GR1",
                SubjectId = 47,
                ClassroomId = 73,
                CalendarId = 1,
            };

            var e17_p4_e022_gr1_73_47_session1 = new Session()
            {
                Id = 262, // Continuando la numeración de IDs
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 229,
            };
            #endregion

            #region e17_p4_e022_gr3_73_49
            var e17_p4_e022_gr3_73_49 = new Group()
            {
                Id = 230, // Continuando la numeración de IDs
                Name = "GR3",
                SubjectId = 49,
                ClassroomId = 73,
                CalendarId = 1,
            };

            var e17_p4_e022_gr3_73_49_session1 = new Session()
            {
                Id = 263, // Continuando la numeración de IDs
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(17, 0, 0),
                EndTime = new TimeSpan(19, 0, 0),
                GroupId = 230,
            };
            #endregion

            #region e17_p4_e022_gr1_73_31
            var e17_p4_e022_gr1_73_31 = new Group()
            {
                Id = 231, // Continuando la numeración de IDs
                Name = "GR1",
                SubjectId = 31,
                ClassroomId = 73,
                CalendarId = 1,
            };

            var e17_p4_e022_gr1_73_31_session1 = new Session()
            {
                Id = 264, // Continuando la numeración de IDs
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 231,
            };
            #endregion

            #region e17_p4_e022_gr2_73_31
            var e17_p4_e022_gr2_73_31 = new Group()
            {
                Id = 232, // Continuando la numeración de IDs
                Name = "GR2",
                SubjectId = 31,
                ClassroomId = 73,
                CalendarId = 1,
            };

            var e17_p4_e022_gr2_73_31_session1 = new Session()
            {
                Id = 265, // Continuando la numeración de IDs
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 232,
            };
            #endregion

            #region e17_p4_e022_gr1_73_72
            var e17_p4_e022_gr1_73_72 = new Group()
            {
                Id = 233, // Continuando la numeración de IDs
                Name = "GR1",
                SubjectId = 72,
                ClassroomId = 73,
                CalendarId = 1,
            };

            var e17_p4_e022_gr1_73_72_session1 = new Session()
            {
                Id = 266, // Continuando la numeración de IDs
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 233,
            };
            #endregion

            //AULA E17/P4/E022
            #region e17_p4_e021_gr2_72_47
            var e17_p4_e021_gr2_72_47 = new Group()
            {
                Id = 234, // Continuando la numeración de IDs
                Name = "GR2",
                SubjectId = 47,
                ClassroomId = 72,
                CalendarId = 1,
            };

            var e17_p4_e021_gr2_72_47_session1 = new Session()
            {
                Id = 267, // Continuando la numeración de IDs
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 234,
            };
            #endregion

            #region e17_p4_e021_gr3_72_185
            var e17_p4_e021_gr3_72_185 = new Group()
            {
                Id = 235, // Continuando la numeración de IDs
                Name = "GR3",
                SubjectId = 185,
                ClassroomId = 72,
                CalendarId = 1,
            };

            var e17_p4_e021_gr3_72_185_session1 = new Session()
            {
                Id = 268, // Continuando la numeración de IDs
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 235,
            };
            #endregion
            #region e17_p4_e021_gr4_72_21
            var e17_p4_e021_gr4_72_21 = new Group()
            {
                Id = 236, // Continuando la numeración de IDs
                Name = "GR4",
                SubjectId = 21,
                ClassroomId = 72,
                CalendarId = 1,
            };

            var e17_p4_e021_gr4_72_21_session1 = new Session()
            {
                Id = 269, // Continuando la numeración de IDs
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 236,
            };

            var e17_p4_e021_gr4_72_21_session2 = new Session()
            {
                Id = 270, // Incrementando la numeración de IDs
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 236,
            };
            #endregion

            #region e17_p4_e021_gr2_72_26
            var e17_p4_e021_gr2_72_26 = new Group()
            {
                Id = 237, // Continuando la numeración de IDs
                Name = "GR2",
                SubjectId = 26,
                ClassroomId = 72,
                CalendarId = 1,
            };

            var e17_p4_e021_gr2_72_26_session1 = new Session()
            {
                Id = 271, // Continuando la numeración de IDs
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 237,
            };

            var e17_p4_e021_gr2_72_26_session2 = new Session()
            {
                Id = 272, // Incrementando la numeración de IDs
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 237,
            };
            #endregion

            #region e17_p4_e021_gr1_72_35
            var e17_p4_e021_gr1_72_35 = new Group()
            {
                Id = 238, // Continuando la numeración de IDs
                Name = "GR1",
                SubjectId = 35,
                ClassroomId = 72,
                CalendarId = 1,
            };

            var e17_p4_e021_gr1_72_35_session1 = new Session()
            {
                Id = 273, // Continuando la numeración de IDs
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 238,
            };

            var e17_p4_e021_gr1_72_35_session2 = new Session()
            {
                Id = 274, // Incrementando la numeración de IDs
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(12, 0, 0),
                GroupId = 238,
            };
            #endregion

            #region e17_p4_e021_gr2_72_37
            var e17_p4_e021_gr2_72_37 = new Group()
            {
                Id = 239, // Continuando la numeración de IDs
                Name = "GR2",
                SubjectId = 37,
                ClassroomId = 72,
                CalendarId = 1,
            };

            var e17_p4_e021_gr2_72_37_session1 = new Session()
            {
                Id = 275, // Continuando la numeración de IDs
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 239,
            };

            var e17_p4_e021_gr2_72_37_session2 = new Session()
            {
                Id = 276, // Incrementando la numeración de IDs
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(15, 0, 0),
                GroupId = 239,
            };
            #endregion
            #region e17_p4_e021_gr1-gp_72_1
            var e17_p4_e021_gr1_gp_72_1 = new Group()
            {
                Id = 240, // Continuando la numeración de IDs
                Name = "GR1-GP",
                SubjectId = 1,
                ClassroomId = 72,
                CalendarId = 1,
            };

            var e17_p4_e021_gr1_gp_72_1_session1 = new Session()
            {
                Id = 277, // Continuando la numeración de IDs
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 240,
            };

            var e17_p4_e021_gr1_gp_72_1_session2 = new Session()
            {
                Id = 278, // Incrementando la numeración de IDs
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 240,
            };
            #endregion

            #region e17_p4_e021_gr1_72_63
            var e17_p4_e021_gr1_72_63 = new Group()
            {
                Id = 241, // Continuando la numeración de IDs
                Name = "GR1",
                SubjectId = 63,
                ClassroomId = 72,
                CalendarId = 1,
            };

            var e17_p4_e021_gr1_72_63_session1 = new Session()
            {
                Id = 279, // Continuando la numeración de IDs
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 241,
            };

            var e17_p4_e021_gr1_72_63_session2 = new Session()
            {
                Id = 280, // Incrementando la numeración de IDs
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(17, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 241,
            };
            #endregion
            //AULA E17/P4/E020
            #region e17_p4_e020_gr2_71_33
            var e17_p4_e020_gr2_71_33 = new Group()
            {
                Id = 243, // Continuando la numeración de IDs
                Name = "GR2",
                SubjectId = 33,
                ClassroomId = 71,
                CalendarId = 1,
            };

            var e17_p4_e020_gr2_71_33_session1 = new Session()
            {
                Id = 283, // Continuando la numeración de IDs
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 243,
            };

            var e17_p4_e020_gr2_71_33_session2 = new Session()
            {
                Id = 284, // Incrementando la numeración de IDs
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(12, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 243,
            };
            #endregion

            #region e17_p4_e020_gr3_71_33
            var e17_p4_e020_gr3_71_33 = new Group()
            {
                Id = 244, // Continuando la numeración de IDs
                Name = "GR3",
                SubjectId = 33,
                ClassroomId = 71,
                CalendarId = 1,
            };

            var e17_p4_e020_gr3_71_33_session1 = new Session()
            {
                Id = 285, // Continuando la numeración de IDs
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                GroupId = 244,
            };

            var e17_p4_e020_gr3_71_33_session2 = new Session()
            {
                Id = 286, // Incrementando la numeración de IDs
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(13, 0, 0),
                EndTime = new TimeSpan(14, 0, 0),
                GroupId = 244,
            };
            #endregion

            #region e17_p4_e020_gr2_71_35
            var e17_p4_e020_gr2_71_35 = new Group()
            {
                Id = 245, // Continuando la numeración de IDs
                Name = "GR2",
                SubjectId = 35,
                ClassroomId = 71,
                CalendarId = 1,
            };

            var e17_p4_e020_gr2_71_35_session1 = new Session()
            {
                Id = 287, // Continuando la numeración de IDs
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 245,
            };

            var e17_p4_e020_gr2_71_35_session2 = new Session()
            {
                Id = 288, // Incrementando la numeración de IDs
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(12, 0, 0),
                GroupId = 245,
            };
            #endregion

            #region e17_p4_e020_gr1_71_41
            var e17_p4_e020_gr1_71_41 = new Group()
            {
                Id = 246, // Continuando la numeración de IDs
                Name = "GR1",
                SubjectId = 41,
                ClassroomId = 71,
                CalendarId = 1,
            };

            var e17_p4_e020_gr1_71_41_session1 = new Session()
            {
                Id = 289, // Continuando la numeración de IDs
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 246,
            };

            var e17_p4_e020_gr1_71_41_session2 = new Session()
            {
                Id = 290, // Incrementando la numeración de IDs
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(15, 0, 0),
                GroupId = 246,
            };
            #endregion
            #region e17_p4_e020_gr1_71_25
            var e17_p4_e020_gr1_71_25 = new Group()
            {
                Id = 247, // Continuando la numeración de IDs
                Name = "GR1",
                SubjectId = 25,
                ClassroomId = 71,
                CalendarId = 1,
            };

            var e17_p4_e020_gr1_71_25_session1 = new Session()
            {
                Id = 291, // Continuando la numeración de IDs
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                GroupId = 247,
            };
            #endregion

            #region e17_p4_e020_gr1_71_82
            var e17_p4_e020_gr1_71_82 = new Group()
            {
                Id = 248, // Continuando la numeración de IDs
                Name = "GR1",
                SubjectId = 82,
                ClassroomId = 71,
                CalendarId = 1,
            };

            var e17_p4_e020_gr1_71_82_session1 = new Session()
            {
                Id = 292, // Continuando la numeración de IDs
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 248,
            };
            #endregion

            #region e17_p4_e020_gr1_71_117
            var e17_p4_e020_gr1_71_117 = new Group()
            {
                Id = 249, // Continuando la numeración de IDs
                Name = "GR1",
                SubjectId = 117,
                ClassroomId = 71,
                CalendarId = 1,
            };

            var e17_p4_e020_gr1_71_117_session1 = new Session()
            {
                Id = 293, // Continuando la numeración de IDs
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 249,
            };
            #endregion

            #region e17_p4_e020_gr1_71_120
            var e17_p4_e020_gr1_71_120 = new Group()
            {
                Id = 250, // Continuando la numeración de IDs
                Name = "GR1",
                SubjectId = 120,
                ClassroomId = 71,
                CalendarId = 1,
            };

            var e17_p4_e020_gr1_71_120_session1 = new Session()
            {
                Id = 294, // Continuando la numeración de IDs
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(8, 0, 0),
                GroupId = 250,
            };
            #endregion
            #region e17_p4_e020_gr1_71_84
            var e17_p4_e020_gr1_71_84 = new Group()
            {
                Id = 255, // Continuando la numeración de IDs
                Name = "GR1",
                SubjectId = 84,
                ClassroomId = 71,
                CalendarId = 1,
            };

            var e17_p4_e020_gr1_71_84_session1 = new Session()
            {
                Id = 299, // Continuando la numeración de IDs
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 255,
            };
            #endregion

            #region e17_p4_e020_gr1_71_67
            var e17_p4_e020_gr1_71_67 = new Group()
            {
                Id = 256, // Continuando la numeración de IDs
                Name = "GR1",
                SubjectId = 67,
            ClassroomId = 71,
            CalendarId = 1,
        };

        var e17_p4_e020_gr1_71_67_session1 = new Session()
        {
            Id = 300, // Continuando la numeración de IDs
            Day = Enum.Day.Jueves,
            StartTime = new TimeSpan(17, 0, 0),
            EndTime = new TimeSpan(19, 0, 0),
            GroupId = 256,
        };
        #endregion

        #region e17_p4_e020_gr1_71_152
        var e17_p4_e020_gr1_71_152 = new Group()
        {
            Id = 257, // Continuando la numeración de IDs
            Name = "GR1",
            SubjectId = 152,
            ClassroomId = 71,
            CalendarId = 1,
        };

        var e17_p4_e020_gr1_71_152_session1 = new Session()
        {
            Id = 301, // Continuando la numeración de IDs
            Day = Enum.Day.Lunes,
            StartTime = new TimeSpan(16, 0, 0),
            EndTime = new TimeSpan(18, 0, 0),
            GroupId = 257,
        };
        #endregion
        #region e17_p4_e020_gr1_71_48
        var e17_p4_e020_gr1_71_48 = new Group()
        {
            Id = 258, // Continuando la numeración de IDs
            Name = "GR1",
            SubjectId = 48,
            ClassroomId = 71,
            CalendarId = 1,
        };

        var e17_p4_e020_gr1_71_48_session1 = new Session()
        {
            Id = 302, // Continuando la numeración de IDs
            Day = Enum.Day.Lunes,
            StartTime = new TimeSpan(11, 0, 0),
            EndTime = new TimeSpan(13, 0, 0),
            GroupId = 258,
        };
        #endregion

        #region e17_p4_e020_gr3_71_48
        var e17_p4_e020_gr3_71_48 = new Group()
        {
            Id = 259, // Continuando la numeración de IDs
            Name = "GR3",
            SubjectId = 48,
            ClassroomId = 71,
            CalendarId = 1,
        };

        var e17_p4_e020_gr3_71_48_session1 = new Session()
        {
            Id = 303, // Continuando la numeración de IDs
            Day = Enum.Day.Lunes,
            StartTime = new TimeSpan(14, 0, 0),
            EndTime = new TimeSpan(16, 0, 0),
            GroupId = 259,
        };
        #endregion

        #region e17_p4_e020_gr3_71_156
        var e17_p4_e020_gr3_71_156 = new Group()
        {
            Id = 260, // Continuando la numeración de IDs
            Name = "GR3",
            SubjectId = 156,
            ClassroomId = 71,
            CalendarId = 1,
        };

        var e17_p4_e020_gr3_71_156_session1 = new Session()
        {
            Id = 304, // Continuando la numeración de IDs
            Day = Enum.Day.Viernes,
            StartTime = new TimeSpan(7, 0, 0),
            EndTime = new TimeSpan(8, 0, 0),
            GroupId = 260,
        };
        #endregion
        // AULA E17/P3/E022
        #region e17_p3_e022_gr2_62_183
        var e17_p3_e022_gr2_62_183 = new Group()
        {
            Id = 261, // Continuando la numeración de IDs
            Name = "GR2",
            ClassroomId = 62,
            SubjectId = 183,
            CalendarId = 1,
        };

        var e17_p3_e022_gr2_62_183_session1 = new Session()
        {
            Id = 305, // Continuando la numeración de IDs
            Day = Enum.Day.Lunes,
            StartTime = new TimeSpan(16, 0, 0),
            EndTime = new TimeSpan(18, 0, 0),
            GroupId = 261,
        };
        #endregion

        #region e17_p3_e022_gr2_62_24
        var e17_p3_e022_gr2_62_24 = new Group()
        {
            Id = 262, // Continuando la numeración de IDs
            Name = "GR2",
            ClassroomId = 62,
            SubjectId = 24,
            CalendarId = 1,
        };

        var e17_p3_e022_gr2_62_24_session1 = new Session()
        {
            Id = 306, // Continuando la numeración de IDs
            Day = Enum.Day.Jueves,
            StartTime = new TimeSpan(7, 0, 0),
            EndTime = new TimeSpan(9, 0, 0),
            GroupId = 262,
        };
        #endregion

        #region e17_p3_e022_gr1_62_61
        var e17_p3_e022_gr1_62_61 = new Group()
        {
            Id = 263, // Continuando la numeración de IDs
            Name = "GR1",
            ClassroomId = 62,
            SubjectId = 61,
            CalendarId = 1,
        };

        var e17_p3_e022_gr1_62_61_session1 = new Session()
        {
            Id = 307, // Continuando la numeración de IDs
            Day = Enum.Day.Lunes,
            StartTime = new TimeSpan(9, 0, 0),
            EndTime = new TimeSpan(11, 0, 0),
            GroupId = 263,
        };
        #endregion

        #region e17_p3_e022_gr1_62_72
        var e17_p3_e022_gr1_62_72 = new Group()
        {
            Id = 264, // Continuando la numeración de IDs
            Name = "GR1",
            ClassroomId = 62,
            SubjectId = 72,
            CalendarId = 1,
        };

        var e17_p3_e022_gr1_62_72_session1 = new Session()
        {
            Id = 308, // Continuando la numeración de IDs
            Day = Enum.Day.Martes,
            StartTime = new TimeSpan(14, 0, 0),
            EndTime = new TimeSpan(16, 0, 0),
            GroupId = 264,
        };
        #endregion
        #region e17_p3_e022_gr1_62_155
        var e17_p3_e022_gr1_62_155 = new Group()
        {
            Id = 265, // Continuando la numeración de IDs
            Name = "GR1",
            ClassroomId = 62,
            SubjectId = 155,
            CalendarId = 1,
        };

        var e17_p3_e022_gr1_62_155_session1 = new Session()
        {
            Id = 309, // Continuando la numeración de IDs
            Day = Enum.Day.Martes,
            StartTime = new TimeSpan(9, 0, 0),
            EndTime = new TimeSpan(11, 0, 0),
            GroupId = 265,
        };

        var e17_p3_e022_gr1_62_155_session2 = new Session()
        {
            Id = 310, // Continuando la numeración de IDs
            Day = Enum.Day.Jueves,
            StartTime = new TimeSpan(9, 0, 0),
            EndTime = new TimeSpan(11, 0, 0),
            GroupId = 265,
        };
        #endregion

        #region e17_p3_e022_gr4_62_27
        var e17_p3_e022_gr4_62_27 = new Group()
        {
            Id = 266, // Continuando la numeración de IDs
            Name = "GR4",
            ClassroomId = 62,
            SubjectId = 27,
            CalendarId = 1,
        };

        var e17_p3_e022_gr4_62_27_session1 = new Session()
        {
            Id = 311, // Continuando la numeración de IDs
            Day = Enum.Day.Miercoles,
            StartTime = new TimeSpan(11, 0, 0),
            EndTime = new TimeSpan(13, 0, 0),
            GroupId = 266,
        };

        var e17_p3_e022_gr4_62_27_session2 = new Session()
        {
            Id = 312, // Continuando la numeración de IDs
            Day = Enum.Day.Viernes,
            StartTime = new TimeSpan(12, 0, 0),
            EndTime = new TimeSpan(13, 0, 0),
            GroupId = 266,
        };
        #endregion

        #region e17_p3_e022_gr1_62_77
        var e17_p3_e022_gr1_62_77 = new Group()
        {
            Id = 267, // Continuando la numeración de IDs
            Name = "GR1",
            ClassroomId = 62,
            SubjectId = 77,
            CalendarId = 1,
        };

        var e17_p3_e022_gr1_62_77_session1 = new Session()
        {
            Id = 313, // Continuando la numeración de IDs
            Day = Enum.Day.Martes,
            StartTime = new TimeSpan(17, 0, 0),
            EndTime = new TimeSpan(19, 0, 0),
            GroupId = 267,
        };

        var e17_p3_e022_gr1_62_77_session2 = new Session()
        {
            Id = 314, // Continuando la numeración de IDs
            Day = Enum.Day.Jueves,
            StartTime = new TimeSpan(17, 0, 0),
            EndTime = new TimeSpan(18, 0, 0),
            GroupId = 267,
        };
        #endregion
        #region e17_p3_e022_gr3_62_22
        var e17_p3_e022_gr3_62_22 = new Group()
        {
            Id = 268, // Continuando la numeración de IDs
            Name = "GR3",
            ClassroomId = 62,
            SubjectId = 22,
            CalendarId = 1,
        };

        var e17_p3_e022_gr3_62_22_session1 = new Session()
        {
            Id = 315, // Continuando la numeración de IDs
            Day = Enum.Day.Miercoles,
            StartTime = new TimeSpan(14, 0, 0),
            EndTime = new TimeSpan(15, 0, 0),
            GroupId = 268,
        };

        var e17_p3_e022_gr3_62_22_session2 = new Session()
        {
            Id = 316, // Continuando la numeración de IDs
            Day = Enum.Day.Viernes,
            StartTime = new TimeSpan(14, 0, 0),
            EndTime = new TimeSpan(16, 0, 0),
            GroupId = 268,
        };
        #endregion

        #region e17_p3_e022_gr2_62_11
        var e17_p3_e022_gr2_62_11 = new Group()
        {
            Id = 269, // Continuando la numeración de IDs
            Name = "GR2",
            ClassroomId = 62,
            SubjectId = 11,
            CalendarId = 1,
        };

        var e17_p3_e022_gr2_62_11_session1 = new Session()
        {
            Id = 317, // Continuando la numeración de IDs
            Day = Enum.Day.Lunes,
            StartTime = new TimeSpan(14, 0, 0),
            EndTime = new TimeSpan(16, 0, 0),
            GroupId = 269,
        };

        var e17_p3_e022_gr2_62_11_session2 = new Session()
        {
            Id = 318, // Continuando la numeración de IDs
            Day = Enum.Day.Miercoles,
            StartTime = new TimeSpan(14, 0, 0),
            EndTime = new TimeSpan(16, 0, 0),
            GroupId = 269,
        };
        #endregion

        #region e17_p3_e022_gr3_62_11
        var e17_p3_e022_gr3_62_11 = new Group()
        {
            Id = 270, // Continuando la numeración de IDs
            Name = "GR3",
            ClassroomId = 62,
            SubjectId = 11,
            CalendarId = 1,
        };

        var e17_p3_e022_gr3_62_11_session1 = new Session()
        {
            Id = 319, // Continuando la numeración de IDs
            Day = Enum.Day.Martes,
            StartTime = new TimeSpan(11, 0, 0),
            EndTime = new TimeSpan(13, 0, 0),
            GroupId = 270,
        };

        var e17_p3_e022_gr3_62_11_session2 = new Session()
        {
            Id = 320, // Continuando la numeración de IDs
            Day = Enum.Day.Jueves,
            StartTime = new TimeSpan(9, 0, 0),
            EndTime = new TimeSpan(11, 0, 0),
            GroupId = 270,
        };
        #endregion

        #region e17_p3_e022_gr3_62_16
        var e17_p3_e022_gr3_62_16 = new Group()
        {
            Id = 271, // Continuando la numeración de IDs
            Name = "GR3",
            ClassroomId = 62,
            SubjectId = 16,
            CalendarId = 1,
        };

        var e17_p3_e022_gr3_62_16_session1 = new Session()
        {
            Id = 321, // Continuando la numeración de IDs
            Day = Enum.Day.Lunes,
            StartTime = new TimeSpan(7, 0, 0),
            EndTime = new TimeSpan(9, 0, 0),
            GroupId = 271,
        };

        var e17_p3_e022_gr3_62_16_session2 = new Session()
        {
            Id = 322, // Continuando la numeración de IDs
            Day = Enum.Day.Miercoles,
            StartTime = new TimeSpan(7, 0, 0),
            EndTime = new TimeSpan(8, 0, 0),
            GroupId = 271,
        };
        #endregion 
        //AULA E17/P3/E021
        #region e17_p3_e021_gr5_61_19
        var e17_p3_e021_gr5_61_19 = new Group()
        {
            Id = 283, // Continuando la numeración de IDs
            Name = "GR5",
            ClassroomId = 61,
            SubjectId = 19,
            CalendarId = 1,
        };

        var e17_p3_e021_gr5_61_19_session1 = new Session()
        {
            Id = 341, // Continuando la numeración de IDs
            Day = Enum.Day.Miercoles,
            StartTime = new TimeSpan(11, 0, 0),
            EndTime = new TimeSpan(13, 0, 0),
            GroupId = 283,
        };

        var e17_p3_e021_gr5_61_19_session2 = new Session()
        {
            Id = 342, // Continuando la numeración de IDs
            Day = Enum.Day.Viernes,
            StartTime = new TimeSpan(12, 0, 0),
            EndTime = new TimeSpan(13, 0, 0),
            GroupId = 283,
        };
        #endregion

        #region e17_p3_e021_gr1_61_22
        var e17_p3_e021_gr1_61_22 = new Group()
        {
            Id = 284, // Continuando la numeración de IDs
            Name = "GR1",
            ClassroomId = 61,
            SubjectId = 22,
            CalendarId = 1,
        };

        var e17_p3_e021_gr1_61_22_session1 = new Session()
        {
            Id = 343, // Continuando la numeración de IDs
            Day = Enum.Day.Lunes,
            StartTime = new TimeSpan(9, 0, 0),
            EndTime = new TimeSpan(11, 0, 0),
            GroupId = 284,
        };

        var e17_p3_e021_gr1_61_22_session2 = new Session()
        {
            Id = 344, // Continuando la numeración de IDs
            Day = Enum.Day.Miercoles,
            StartTime = new TimeSpan(8, 0, 0),
            EndTime = new TimeSpan(9, 0, 0),
            GroupId = 284,
        };
        #endregion

        #region e17_p3_e021_gr4_61_22
        var e17_p3_e021_gr4_61_22 = new Group()
        {
            Id = 285, // Continuando la numeración de IDs
            Name = "GR4",
            ClassroomId = 61,
            SubjectId = 22,
            CalendarId = 1,
        };

        var e17_p3_e021_gr4_61_22_session1 = new Session()
        {
            Id = 345, // Continuando la numeración de IDs
            Day = Enum.Day.Miercoles,
            StartTime = new TimeSpan(14, 0, 0),
            EndTime = new TimeSpan(15, 0, 0),
            GroupId = 285,
        };

        var e17_p3_e021_gr4_61_22_session2 = new Session()
        {
            Id = 346, // Continuando la numeración de IDs
            Day = Enum.Day.Viernes,
            StartTime = new TimeSpan(14, 0, 0),
            EndTime = new TimeSpan(16, 0, 0),
            GroupId = 285,
        };
        #endregion

        #region e17_p3_e021_gr4_61_11
        var e17_p3_e021_gr4_61_11 = new Group()
        {
            Id = 286, // Continuando la numeración de IDs
            Name = "GR4",
            ClassroomId = 61,
            SubjectId = 11,
            CalendarId = 1,
        };

        var e17_p3_e021_gr4_61_11_session1 = new Session()
        {
            Id = 347, // Continuando la numeración de IDs
            Day = Enum.Day.Jueves,
            StartTime = new TimeSpan(9, 0, 0),
            EndTime = new TimeSpan(11, 0, 0),
            GroupId = 286,
        };

        var e17_p3_e021_gr4_61_11_session2 = new Session()
        {
            Id = 348, // Continuando la numeración de IDs
            Day = Enum.Day.Viernes,
            StartTime = new TimeSpan(9, 0, 0),
            EndTime = new TimeSpan(11, 0, 0),
            GroupId = 286,
        };
        #endregion
        #region e17_p3_e021_gr2_61_16
        var e17_p3_e021_gr2_61_16 = new Group()
        {
            Id = 287, // Continuando la numeración de IDs
            Name = "GR2",
            ClassroomId = 61,
            SubjectId = 16,
            CalendarId = 1,
        };

        var e17_p3_e021_gr2_61_16_session1 = new Session()
        {
            Id = 349, // Continuando la numeración de IDs
            Day = Enum.Day.Lunes,
            StartTime = new TimeSpan(14, 0, 0),
            EndTime = new TimeSpan(16, 0, 0),
            GroupId = 287,
        };

        var e17_p3_e021_gr2_61_16_session2 = new Session()
        {
            Id = 350, // Continuando la numeración de IDs
            Day = Enum.Day.Miercoles,
            StartTime = new TimeSpan(15, 0, 0),
            EndTime = new TimeSpan(16, 0, 0),
            GroupId = 287,
        };
        #endregion

        #region e17_p3_e021_gr1_61_17
        var e17_p3_e021_gr1_61_17 = new Group()
        {
            Id = 288, // Continuando la numeración de IDs
            Name = "GR1",
            ClassroomId = 61,
            SubjectId = 17,
            CalendarId = 1,
        };

        var e17_p3_e021_gr1_61_17_session1 = new Session()
        {
            Id = 351, // Continuando la numeración de IDs
            Day = Enum.Day.Lunes,
            StartTime = new TimeSpan(11, 0, 0),
            EndTime = new TimeSpan(13, 0, 0),
            GroupId = 288,
        };

        var e17_p3_e021_gr1_61_17_session2 = new Session()
        {
            Id = 352, // Continuando la numeración de IDs
            Day = Enum.Day.Miercoles,
            StartTime = new TimeSpan(11, 0, 0),
            EndTime = new TimeSpan(12, 0, 0),
            GroupId = 288,
        };
        #endregion

        #region e17_p3_e021_gr3_61_17
        var e17_p3_e021_gr3_61_17 = new Group()
        {
            Id = 289, // Continuando la numeración de IDs
            Name = "GR3",
            ClassroomId = 61,
            SubjectId = 17,
            CalendarId = 1,
        };

        var e17_p3_e021_gr3_61_17_session1 = new Session()
        {
            Id = 353, // Continuando la numeración de IDs
            Day = Enum.Day.Martes,
            StartTime = new TimeSpan(11, 0, 0),
            EndTime = new TimeSpan(13, 0, 0),
            GroupId = 289,
        };

        var e17_p3_e021_gr3_61_17_session2 = new Session()
        {
            Id = 354, // Continuando la numeración de IDs
            Day = Enum.Day.Miercoles,
            StartTime = new TimeSpan(11, 0, 0),
            EndTime = new TimeSpan(12, 0, 0),
            GroupId = 289,
        };
        #endregion

        #region e17_p3_e021_gr1_61_29
        var e17_p3_e021_gr1_61_29 = new Group()
        {
            Id = 290, // Continuando la numeración de IDs
            Name = "GR1",
            ClassroomId = 61,
            SubjectId = 29,
            CalendarId = 1,
        };

        var e17_p3_e021_gr1_61_29_session1 = new Session()
        {
            Id = 355, // Continuando la numeración de IDs
            Day = Enum.Day.Martes,
            StartTime = new TimeSpan(9, 0, 0),
            EndTime = new TimeSpan(11, 0, 0),
            GroupId = 290,
        };

        var e17_p3_e021_gr1_61_29_session2 = new Session()
        {
            Id = 356, // Continuando la numeración de IDs
            Day = Enum.Day.Miercoles,
            StartTime = new TimeSpan(9, 0, 0),
            EndTime = new TimeSpan(10, 0, 0),
            GroupId = 290,
        };
        #endregion
        #region e17_p3_e021_gr2_61_182
        var e17_p3_e021_gr2_61_182 = new Group()
        {
            Id = 291, // Continuando la numeración de IDs
            Name = "GR2",
            ClassroomId = 61,
            SubjectId = 182,
            CalendarId = 1,
        };

        var e17_p3_e021_gr2_61_182_session1 = new Session()
        {
            Id = 357, // Continuando la numeración de IDs
            Day = Enum.Day.Martes,
            StartTime = new TimeSpan(14, 0, 0),
            EndTime = new TimeSpan(16, 0, 0),
            GroupId = 291,
        };
        #endregion

        #region e17_p3_e021_gr1_61_183
        var e17_p3_e021_gr1_61_183 = new Group()
        {
            Id = 292, // Continuando la numeración de IDs
            Name = "GR1",
            ClassroomId = 61,
            SubjectId = 183,
            CalendarId = 1,
        };

        var e17_p3_e021_gr1_61_183_session1 = new Session()
        {
            Id = 358, // Continuando la numeración de IDs
            Day = Enum.Day.Miercoles,
            StartTime = new TimeSpan(16, 0, 0),
            EndTime = new TimeSpan(18, 0, 0),
            GroupId = 292,
        };
        #endregion

        #region e17_p3_e021_gr3_61_183
        var e17_p3_e021_gr3_61_183 = new Group()
        {
            Id = 293, // Continuando la numeración de IDs
            Name = "GR3",
            ClassroomId = 61,
            SubjectId = 183,
            CalendarId = 1,
        };

        var e17_p3_e021_gr3_61_183_session1 = new Session()
        {
            Id = 359, // Continuando la numeración de IDs
            Day = Enum.Day.Jueves,
            StartTime = new TimeSpan(16, 0, 0),
            EndTime = new TimeSpan(18, 0, 0),
            GroupId = 293,
        };
        #endregion
        #region e17_p3_e021_gr4_61_47
        var e17_p3_e021_gr4_61_47 = new Group()
        {
            Id = 294, // Continuando la numeración de IDs
            Name = "GR4",
            ClassroomId = 61,
            SubjectId = 47,
            CalendarId = 1,
        };

        var e17_p3_e021_gr4_61_47_session1 = new Session()
        {
            Id = 360, // Continuando la numeración de IDs
            Day = Enum.Day.Miercoles,
            StartTime = new TimeSpan(17, 0, 0),
            EndTime = new TimeSpan(19, 0, 0),
            GroupId = 294,
        };
        #endregion

        #region e17_p3_e021_gr3_61_24
        var e17_p3_e021_gr3_61_24 = new Group()
        {
            Id = 295, // Continuando la numeración de IDs
            Name = "GR3",
            ClassroomId = 61,
            SubjectId = 24,
            CalendarId = 1,
        };

        var e17_p3_e021_gr3_61_24_session1 = new Session()
        {
            Id = 361, // Continuando la numeración de IDs
            Day = Enum.Day.Jueves,
            StartTime = new TimeSpan(14, 0, 0),
            EndTime = new TimeSpan(16, 0, 0),
            GroupId = 295,
        };
        #endregion

        #region e17_p3_e021_gr1_61_97
        var e17_p3_e021_gr1_61_97 = new Group()
        {
            Id = 296, // Continuando la numeración de IDs
            Name = "GR1",
            ClassroomId = 61,
            SubjectId = 97,
            CalendarId = 1,
        };

        var e17_p3_e021_gr1_61_97_session1 = new Session()
        {
            Id = 362, // Continuando la numeración de IDs
            Day = Enum.Day.Martes,
            StartTime = new TimeSpan(7, 0, 0),
            EndTime = new TimeSpan(9, 0, 0),
            GroupId = 296,
        };
        #endregion
        //aula E17/P3/E023
        #region e17_p3_e023_gr1_63_49
        var e17_p3_e023_gr1_63_49 = new Group()
        {
            Id = 297, // Continuando la numeración de IDs
            Name = "GR1",
            ClassroomId = 63,
            SubjectId = 49,
            CalendarId = 1,
        };

        var e17_p3_e023_gr1_63_49_session1 = new Session()
        {
            Id = 363, // Continuando la numeración de IDs
            Day = Enum.Day.Lunes,
            StartTime = new TimeSpan(11, 0, 0),
            EndTime = new TimeSpan(13, 0, 0),
            GroupId = 297,
        };
        #endregion

        #region e17_p3_e023_gr1_63_24
        var e17_p3_e023_gr1_63_24 = new Group()
        {
            Id = 298, // Continuando la numeración de IDs
            Name = "GR1",
            ClassroomId = 63,
            SubjectId = 24,
            CalendarId = 1,
        };

        var e17_p3_e023_gr1_63_24_session1 = new Session()
        {
            Id = 364, // Continuando la numeración de IDs
            Day = Enum.Day.Jueves,
            StartTime = new TimeSpan(7, 0, 0),
            EndTime = new TimeSpan(9, 0, 0),
            GroupId = 298,
        };
        #endregion

        #region e17_p3_e023_gr1_63_185
        var e17_p3_e023_gr1_63_185 = new Group()
        {
            Id = 299, // Continuando la numeración de IDs
            Name = "GR1",
            ClassroomId = 63,
            SubjectId = 185,
            CalendarId = 1,
        };

        var e17_p3_e023_gr1_63_185_session1 = new Session()
        {
            Id = 365, // Continuando la numeración de IDs
            Day = Enum.Day.Martes,
            StartTime = new TimeSpan(14, 0, 0),
            EndTime = new TimeSpan(16, 0, 0),
            GroupId = 299,
        };
        #endregion

        #region e17_p3_e023_gr1_63_128
        var e17_p3_e023_gr1_63_128 = new Group()
        {
            Id = 300, // Continuando la numeración de IDs
            Name = "GR1",
            ClassroomId = 63,
            SubjectId = 128,
            CalendarId = 1,
        };

        var e17_p3_e023_gr1_63_128_session1 = new Session()
        {
            Id = 366, // Continuando la numeración de IDs
            Day = Enum.Day.Miercoles,
            StartTime = new TimeSpan(14, 0, 0),
            EndTime = new TimeSpan(15, 0, 0),
            GroupId = 300,
        };
        #endregion
        #region e17_p3_e023_gr5_63_14
        var e17_p3_e023_gr5_63_14 = new Group()
        {
            Id = 301, // Continuando la numeración de IDs
            Name = "GR5",
            ClassroomId = 63,
            SubjectId = 14,
            CalendarId = 1,
        };

        var e17_p3_e023_gr5_63_14_session1 = new Session()
        {
            Id = 367, // Continuando la numeración de IDs
            Day = Enum.Day.Martes,
            StartTime = new TimeSpan(11, 0, 0),
            EndTime = new TimeSpan(13, 0, 0),
            GroupId = 301,
        };

        var e17_p3_e023_gr5_63_14_session2 = new Session()
        {
            Id = 368, // Continuando la numeración de IDs
            Day = Enum.Day.Viernes,
            StartTime = new TimeSpan(14, 0, 0),
            EndTime = new TimeSpan(15, 0, 0),
            GroupId = 301,
        };
        #endregion

        #region e17_p3_e023_gr3_63_184
        var e17_p3_e023_gr3_63_184 = new Group()
        {
            Id = 302, // Continuando la numeración de IDs
            Name = "GR3",
            ClassroomId = 63,
            SubjectId = 184,
            CalendarId = 1,
        };

        var e17_p3_e023_gr3_63_184_session1 = new Session()
        {
            Id = 369, // Continuando la numeración de IDs
            Day = Enum.Day.Miercoles,
            StartTime = new TimeSpan(17, 0, 0),
            EndTime = new TimeSpan(19, 0, 0),
            GroupId = 302,
        };
        #endregion

        #region e17_p3_e023_gr1_63_11
        var e17_p3_e023_gr1_63_11 = new Group()
        {
            Id = 303, // Continuando la numeración de IDs
            Name = "GR1",
            ClassroomId = 63,
            SubjectId = 11,
            CalendarId = 1,
        };

        var e17_p3_e023_gr1_63_11_session1 = new Session()
        {
            Id = 371, // Continuando la numeración de IDs
            Day = Enum.Day.Lunes,
            StartTime = new TimeSpan(14, 0, 0),
            EndTime = new TimeSpan(16, 0, 0),
            GroupId = 303,
        };

        var e17_p3_e023_gr1_63_11_session2 = new Session()
        {
            Id = 372, // Continuando la numeración de IDs
            Day = Enum.Day.Martes,
            StartTime = new TimeSpan(14, 0, 0),
            EndTime = new TimeSpan(16, 0, 0),
            GroupId = 303,
        };
        #endregion

        #region e17_p3_e023_gr1_63_16
        var e17_p3_e023_gr1_63_16 = new Group()
        {
            Id = 304, // Continuando la numeración de IDs
            Name = "GR1",
            ClassroomId = 63,
            SubjectId = 16,
            CalendarId = 1,
        };

        var e17_p3_e023_gr1_63_16_session1 = new Session()
        {
            Id = 373, // Continuando la numeración de IDs
            Day = Enum.Day.Lunes,
            StartTime = new TimeSpan(7, 0, 0),
            EndTime = new TimeSpan(9, 0, 0),
            GroupId = 304,
        };

        var e17_p3_e023_gr1_63_16_session2 = new Session()
        {
            Id = 374, // Continuando la numeración de IDs
            Day = Enum.Day.Miercoles,
            StartTime = new TimeSpan(7, 0, 0),
            EndTime = new TimeSpan(8, 0, 0),
            GroupId = 304,
        };
        #endregion
        #region e17_p3_e023_gr1_63_27
        var e17_p3_e023_gr1_63_27 = new Group()
        {
            Id = 305, // Continuando la numeración de IDs
            Name = "GR1",
            ClassroomId = 63,
            SubjectId = 27,
            CalendarId = 1,
        };

        var e17_p3_e023_gr1_63_27_session1 = new Session()
        {
            Id = 375, // Continuando la numeración de IDs
            Day = Enum.Day.Martes,
            StartTime = new TimeSpan(7, 0, 0),
            EndTime = new TimeSpan(9, 0, 0),
            GroupId = 305,
        };

        var e17_p3_e023_gr1_63_27_session2 = new Session()
        {
            Id = 376, // Continuando la numeración de IDs
            Day = Enum.Day.Viernes,
            StartTime = new TimeSpan(9, 0, 0),
            EndTime = new TimeSpan(10, 0, 0),
            GroupId = 305,
        };
        #endregion

        #region e17_p3_e023_gr3_63_27
        var e17_p3_e023_gr3_63_27 = new Group()
        {
            Id = 306, // Continuando la numeración de IDs
            Name = "GR3",
            ClassroomId = 63,
            SubjectId = 27,
            CalendarId = 1,
        };

        var e17_p3_e023_gr3_63_27_session1 = new Session()
        {
            Id = 377, // Continuando la numeración de IDs
            Day = Enum.Day.Miercoles,
            StartTime = new TimeSpan(11, 0, 0),
            EndTime = new TimeSpan(13, 0, 0),
            GroupId = 306,
        };

        var e17_p3_e023_gr3_63_27_session2 = new Session()
        {
            Id = 378, // Continuando la numeración de IDs
            Day = Enum.Day.Viernes,
            StartTime = new TimeSpan(12, 0, 0),
            EndTime = new TimeSpan(13, 0, 0),
            GroupId = 306,
        };
        #endregion

        #region e17_p3_e023_gr2_63_29
        var e17_p3_e023_gr2_63_29 = new Group()
        {
            Id = 307, // Continuando la numeración de IDs
            Name = "GR2",
            ClassroomId = 63,
            SubjectId = 29,
            CalendarId = 1,
        };

        var e17_p3_e023_gr2_63_29_session1 = new Session()
        {
            Id = 379, // Continuando la numeración de IDs
            Day = Enum.Day.Martes,
            StartTime = new TimeSpan(9, 0, 0),
            EndTime = new TimeSpan(11, 0, 0),
            GroupId = 307,
        };

        var e17_p3_e023_gr2_63_29_session2 = new Session()
        {
            Id = 380, // Continuando la numeración de IDs
            Day = Enum.Day.Miercoles,
            StartTime = new TimeSpan(9, 0, 0),
            EndTime = new TimeSpan(10, 0, 0),
            GroupId = 307,
        };
        #endregion

        #region e17_p3_e023_gr2_63_58
        var e17_p3_e023_gr2_63_58 = new Group()
        {
            Id = 308, // Continuando la numeración de IDs
            Name = "GR2",
            ClassroomId = 63,
            SubjectId = 58,
            CalendarId = 1,
        };

        var e17_p3_e023_gr2_63_58_session1 = new Session()
        {
            Id = 381, // Continuando la numeración de IDs
            Day = Enum.Day.Martes,
            StartTime = new TimeSpan(17, 0, 0),
            EndTime = new TimeSpan(19, 0, 0),
            GroupId = 308,
        };

        var e17_p3_e023_gr2_63_58_session2 = new Session()
        {
            Id = 382, // Continuando la numeración de IDs
            Day = Enum.Day.Jueves,
            StartTime = new TimeSpan(18, 0, 0),
            EndTime = new TimeSpan(19, 0, 0),
            GroupId = 308,
        };
        #endregion
        #region e17_p3_e023_gr1_63_188
        var e17_p3_e023_gr1_63_188 = new Group()
        {
            Id = 309, // Continuando la numeración de IDs
            Name = "GR1",
            ClassroomId = 63,
            SubjectId = 188,
            CalendarId = 1,
        };

        var e17_p3_e023_gr1_63_188_session1 = new Session()
        {
            Id = 383, // Continuando la numeración de IDs
            Day = Enum.Day.Jueves,
            StartTime = new TimeSpan(9, 0, 0),
            EndTime = new TimeSpan(11, 0, 0),
            GroupId = 309,
        };

        var e17_p3_e023_gr1_63_188_session2 = new Session()
        {
            Id = 384, // Continuando la numeración de IDs
            Day = Enum.Day.Viernes,
            StartTime = new TimeSpan(7, 0, 0),
            EndTime = new TimeSpan(8, 0, 0),
            GroupId = 309,
        };
        #endregion


        modelBuilder
        .Entity<Group>()
        .HasData(
            //grupos edificio 17
            e17_mz_e002_gr1_34_111,
            e17_mz_e002_gr2_34_111,
            e17_mz_e002_gr3_34_111,
            e17_mz_e004_gr1_35_109,
            e17_mz_e004_gr2_35_109,
            e17_mz_e004_gr3_35_109,
            e17_mz_e004_gr4_35_109,
            e17_p6_e023_gr1_85_151,
            e17_p6_e023_gr1_85_176,
            e17_p6_e023_gr1_85_12,
            e17_p6_e023_gr6_85_12,
            e17_p6_e023_gr2_85_186,
            e17_p6_e027_gr11_87_6,
            e17_p6_e027_gr2_87_6,
            e17_p6_e027_gr2_87_167,
            e17_p6_e027_gr11_87_12,
            e17_p6_e027_gr5_87_12,
            e17_p6_e027_gr1_87_177,
            e17_p6_e003_gr7_82_51,
            e17_p6_e002_gr1_1_83,
            e17_p6_e002_gr1_2_83,
            e17_p6_e002_gr1_3_83,
            e17_p6_e002_gr1_4_83,
            e17_p6_e002_gr1_5_83,
            e17_p6_e002_gr1_6_83,
            e17_p6_e002_gr1_7_83,
            e17_p5_e029_gr3_10,
            e17_p5_e029_gr1_8,
            e17_p5_e029_gr1_14,
            e17_p5_e029_gr5_22,
            e17_p5_e029_gr1_68,
            e17_p5_e029_gr1_68_4,
            e17_p5_e029_gr1_187_1,
            e17_p5_e029_gr1_10_2,
            e17_p5_e028_gr6_79,
            e17_p5_e028_gr1_GP_79,
            e17_p5_e028_gr6_79_2,
            e17_p5_e028_gr2_79_8,
            e17_p5_e028_gr2_79_14,
            e17_p5_e028_gr4_79_14,
            e17_p5_e028_gr6_79_3,
            e17_p5_e028_gr2_GP_79_9,
            e17_p5_e028_gr6_79_5,
            e17_p5_e028_gr2_79_27,
            e17_p5_e020_gr2_77_25,
            e17_p5_e020_gr1_77_44,
            e17_p5_e020_gr3_77_26,
            e17_p5_e020_gr1_77_90,
            e17_p5_e020_gr1_77_86,
            e17_p5_e020_gr2_77_49,
            e17_p5_e020_gr1_77_61,
            e17_p5_e020_gr1_77_69,
            e17_p4_e023_gr1_74_10,
            e17_p4_e023_gr1_74_182,
            e17_p4_e023_gr1_74_101,
            e17_p4_e023_gr1_74_19,
            e17_p4_e023_gr3_74_19,
            e17_p4_e023_gr2_74_22,
            e17_p4_e023_gr4_74_16,
            e17_p4_e023_gr4_74_17,
            e17_p4_e023_gr1_74_126,
            e17_p4_e023_gr1_74_130,
            e17_p4_e022_gr1_73_26,
            e17_p4_e022_gr1_73_33,
            e17_p4_e022_gr1_73_92,
            e17_p4_e022_gr1_73_21,
            e17_p4_e022_gr3_73_21,
            e17_p4_e022_gr2_73_19,
            e17_p4_e022_gr4_73_19,
            e17_p4_e022_gr1_73_47,
            e17_p4_e022_gr3_73_49,
            e17_p4_e022_gr1_73_31,
            e17_p4_e022_gr2_73_31,
            e17_p4_e022_gr1_73_72,
            e17_p4_e021_gr2_72_47,
            e17_p4_e021_gr3_72_185,
            e17_p4_e021_gr4_72_21,
            e17_p4_e021_gr2_72_26,
            e17_p4_e021_gr1_72_35,
            e17_p4_e021_gr2_72_37,
            e17_p4_e021_gr1_gp_72_1,
            e17_p4_e021_gr1_72_63,
            e17_p4_e020_gr2_71_33,
            e17_p4_e020_gr3_71_33,
            e17_p4_e020_gr2_71_35,
            e17_p4_e020_gr1_71_41,
            e17_p4_e020_gr1_71_25,
            e17_p4_e020_gr1_71_82,
            e17_p4_e020_gr1_71_117,
            e17_p4_e020_gr1_71_120,
            e17_p4_e020_gr1_71_84,
            e17_p4_e020_gr1_71_67,
            e17_p4_e020_gr1_71_152,
            e17_p4_e020_gr1_71_48,
            e17_p4_e020_gr3_71_48,
            e17_p4_e020_gr3_71_156,
            e17_p3_e022_gr2_62_183,
            e17_p3_e022_gr2_62_24,
            e17_p3_e022_gr1_62_61,
            e17_p3_e022_gr1_62_72,
            e17_p3_e022_gr1_62_155,
            e17_p3_e022_gr4_62_27,
            e17_p3_e022_gr1_62_77,
            e17_p3_e022_gr3_62_22,
            e17_p3_e022_gr2_62_11,
            e17_p3_e022_gr3_62_11,
            e17_p3_e022_gr3_62_16,
            e17_p3_e021_gr5_61_19,
            e17_p3_e021_gr1_61_22,
            e17_p3_e021_gr4_61_22,
            e17_p3_e021_gr4_61_11,
            e17_p3_e021_gr2_61_16,
            e17_p3_e021_gr1_61_17,
            e17_p3_e021_gr3_61_17,
            e17_p3_e021_gr1_61_29,
            e17_p3_e021_gr2_61_182,
            e17_p3_e021_gr1_61_183,
            e17_p3_e021_gr3_61_183,
            e17_p3_e021_gr4_61_47,
            e17_p3_e021_gr3_61_24,
            e17_p3_e021_gr1_61_97,
            e17_p3_e023_gr1_63_49,
            e17_p3_e023_gr1_63_24,
            e17_p3_e023_gr1_63_185,
            e17_p3_e023_gr1_63_128,
            e17_p3_e023_gr5_63_14,
            e17_p3_e023_gr3_63_184,
            e17_p3_e023_gr1_63_11,
            e17_p3_e023_gr1_63_16,
            e17_p3_e023_gr1_63_27,
            e17_p3_e023_gr3_63_27,
            e17_p3_e023_gr2_63_29,
            e17_p3_e023_gr2_63_58,
            e17_p3_e023_gr1_63_188
);


        modelBuilder
                     .Entity<Session>()
             .HasData(
                e17_mz_e002_gr1_34_111_session1,
                e17_mz_e002_gr2_34_111_session1,
                e17_mz_e002_gr3_34_111_session1,
                e17_mz_e004_gr1_35_109_session1,
                e17_mz_e004_gr2_35_109_session1,
                e17_mz_e004_gr3_35_109_session1,
                e17_mz_e004_gr4_35_109_session1,
                e17_p6_e023_gr1_85_151_session1,
                e17_p6_e023_gr1_85_176_session1,
                e17_p6_e023_gr1_85_176_session2,
                e17_p6_e023_gr1_85_12_session1,
                e17_p6_e023_gr1_85_12_session2,
                e17_p6_e023_gr6_85_12_session1,
                e17_p6_e023_gr6_85_12_session2,
                e17_p6_e023_gr2_85_186_session1,
                e17_p6_e023_gr2_85_186_session2,
                e17_p6_e027_gr11_87_6_session1,
                e17_p6_e027_gr2_87_6_session1,
                e17_p6_e027_gr2_87_167_session1,
                e17_p6_e027_gr11_87_12_session1,
                e17_p6_e027_gr11_87_12_session2,
                e17_p6_e027_gr5_87_12_session1,
                e17_p6_e027_gr5_87_12_session2,
                e17_p6_e027_gr1_87_177_session1,
                e17_p6_e027_gr1_87_177_session2,
                e17_p6_e027_gr1_87_177_session3,
                e17_p6_e003_gr7_82_51_session1,
                e17_p6_e003_gr7_82_51_session2,
                e17_p6_e002_gr1_1_83_session1,
                e17_p6_e002_gr1_2_83_session1,
                e17_p6_e002_gr1_3_83_session1,
                e17_p6_e002_gr1_4_83_session1,
                e17_p6_e002_gr1_5_83_session1,
                e17_p6_e002_gr1_6_83_session1,
                e17_p6_e002_gr1_7_83_session1,
                e17_p5_e029_gr3_10_session1,
                e17_p5_e029_gr3_10_session2,
                e17_p5_e029_gr1_8_session1,
                e17_p5_e029_gr1_8_session2,
                e17_p5_e029_gr1_14_session1,
                e17_p5_e029_gr1_14_session2,
                e17_p5_e029_gr5_22_session1,
                e17_p5_e029_gr5_22_session2,
                e17_p5_e029_gr1_68_session1,
                e17_p5_e029_gr1_68_4_session1,
                e17_p5_e029_gr1_187_1_session1,
                e17_p5_e029_gr1_10_2_session1,
                e17_p5_e028_gr6_79_session1,
                e17_p5_e028_gr6_79_session2,
                e17_p5_e028_gr1_GP_79_session1,
                e17_p5_e028_gr1_GP_79_session2,
                e17_p5_e028_gr6_79_2_session1,
                e17_p5_e028_gr6_79_2_session2,
                e17_p5_e028_gr2_79_8_session1,
                e17_p5_e028_gr2_79_8_session2,
                e17_p5_e028_gr2_79_14_session1,
                e17_p5_e028_gr2_79_14_session2,
                e17_p5_e028_gr4_79_14_session1,
                e17_p5_e028_gr4_79_14_session2,
                e17_p5_e028_gr6_79_3_session1,
                e17_p5_e028_gr6_79_3_session2,
                e17_p5_e028_gr2_GP_79_9_session1,
                e17_p5_e028_gr2_GP_79_9_session2,
                e17_p5_e028_gr6_79_5_session1,
                e17_p5_e028_gr6_79_5_session2,
                e17_p5_e028_gr2_79_27_session1,
                e17_p5_e028_gr2_79_27_session2,
                e17_p5_e020_gr2_77_25_session1,
                e17_p5_e020_gr2_77_25_session2,
                e17_p5_e020_gr1_77_44_session1,
                e17_p5_e020_gr1_77_44_session2,
                e17_p5_e020_gr3_77_26_session1,
                e17_p5_e020_gr3_77_26_session2,
                e17_p5_e020_gr1_77_90_session1,
                e17_p5_e020_gr1_77_90_session2,
                e17_p5_e020_gr1_77_86_session1,
                e17_p5_e020_gr1_77_86_session2,
                e17_p5_e020_gr2_77_49_session1,
                e17_p5_e020_gr1_77_61_session1,
                e17_p5_e020_gr1_77_69_session1,
                e17_p4_e023_gr1_74_10_session1,
                e17_p4_e023_gr1_74_182_session1,
                e17_p4_e023_gr1_74_101_session1,
                e17_p4_e023_gr1_74_19_session1,
                e17_p4_e023_gr1_74_19_session2,
                e17_p4_e023_gr3_74_19_session1,
                e17_p4_e023_gr3_74_19_session2,
                e17_p4_e023_gr2_74_22_session1,
                e17_p4_e023_gr2_74_22_session2,
                e17_p4_e023_gr4_74_16_session1,
                e17_p4_e023_gr4_74_16_session2,
                e17_p4_e023_gr4_74_17_session1,
                e17_p4_e023_gr4_74_17_session2,
                e17_p4_e023_gr1_74_126_session1,
                e17_p4_e023_gr1_74_126_session2,
                e17_p4_e023_gr1_74_130_session1,
                e17_p4_e023_gr1_74_130_session2,
                e17_p4_e022_gr1_73_26_session1,
                e17_p4_e022_gr1_73_26_session2,
                e17_p4_e022_gr1_73_33_session1,
                e17_p4_e022_gr1_73_33_session2,
                e17_p4_e022_gr1_73_92_session1,
                e17_p4_e022_gr1_73_92_session2,
                e17_p4_e022_gr1_73_21_session1,
                e17_p4_e022_gr1_73_21_session2,
                e17_p4_e022_gr3_73_21_session1,
                e17_p4_e022_gr3_73_21_session2,
                e17_p4_e022_gr2_73_19_session1,
                e17_p4_e022_gr2_73_19_session2,
                e17_p4_e022_gr4_73_19_session1,
                e17_p4_e022_gr4_73_19_session2,
                e17_p4_e022_gr1_73_47_session1,
                e17_p4_e022_gr3_73_49_session1,
                e17_p4_e022_gr1_73_31_session1,
                e17_p4_e022_gr2_73_31_session1,
                e17_p4_e022_gr1_73_72_session1,
                e17_p4_e021_gr2_72_47_session1,
                e17_p4_e021_gr3_72_185_session1,
                e17_p4_e021_gr4_72_21_session1,
                e17_p4_e021_gr4_72_21_session2,
                e17_p4_e021_gr2_72_26_session1,
                e17_p4_e021_gr2_72_26_session2,
                e17_p4_e021_gr1_72_35_session1,
                e17_p4_e021_gr1_72_35_session2,
                e17_p4_e021_gr2_72_37_session1,
                e17_p4_e021_gr2_72_37_session2,
                e17_p4_e021_gr1_gp_72_1_session1,
                e17_p4_e021_gr1_gp_72_1_session2,
                e17_p4_e021_gr1_72_63_session1,
                e17_p4_e021_gr1_72_63_session2,
                e17_p4_e020_gr2_71_33_session1,
                e17_p4_e020_gr2_71_33_session2,
                e17_p4_e020_gr3_71_33_session1,
                e17_p4_e020_gr3_71_33_session2,
                e17_p4_e020_gr2_71_35_session1,
                e17_p4_e020_gr2_71_35_session2,
                e17_p4_e020_gr1_71_41_session1,
                e17_p4_e020_gr1_71_41_session2,
                e17_p4_e020_gr1_71_25_session1,
                e17_p4_e020_gr1_71_82_session1,
                e17_p4_e020_gr1_71_117_session1,
                e17_p4_e020_gr1_71_120_session1,
                e17_p4_e020_gr1_71_84_session1,
                e17_p4_e020_gr1_71_67_session1,
                e17_p4_e020_gr1_71_152_session1,
                e17_p4_e020_gr1_71_48_session1,
                e17_p4_e020_gr3_71_48_session1,
                e17_p4_e020_gr3_71_156_session1,
                e17_p3_e022_gr2_62_183_session1,
                e17_p3_e022_gr2_62_24_session1,
                e17_p3_e022_gr1_62_61_session1,
                e17_p3_e022_gr1_62_72_session1,
                e17_p3_e022_gr1_62_155_session1,
                e17_p3_e022_gr1_62_155_session2,
                e17_p3_e022_gr4_62_27_session1,
                e17_p3_e022_gr4_62_27_session2,
                e17_p3_e022_gr1_62_77_session1,
                e17_p3_e022_gr1_62_77_session2,
                e17_p3_e022_gr3_62_22_session1,
                e17_p3_e022_gr3_62_22_session2,
                e17_p3_e022_gr2_62_11_session1,
                e17_p3_e022_gr2_62_11_session2,
                e17_p3_e022_gr3_62_11_session1,
                e17_p3_e022_gr3_62_11_session2,
                e17_p3_e022_gr3_62_16_session1,
                e17_p3_e022_gr3_62_16_session2,
                e17_p3_e021_gr5_61_19_session1,
                e17_p3_e021_gr5_61_19_session2,
                e17_p3_e021_gr1_61_22_session1,
                e17_p3_e021_gr1_61_22_session2,
                e17_p3_e021_gr4_61_22_session1,
                e17_p3_e021_gr4_61_22_session2,
                e17_p3_e021_gr4_61_11_session1,
                e17_p3_e021_gr4_61_11_session2,
                e17_p3_e021_gr2_61_16_session1,
                e17_p3_e021_gr2_61_16_session2,
                e17_p3_e021_gr1_61_17_session1,
                e17_p3_e021_gr1_61_17_session2,
                e17_p3_e021_gr3_61_17_session1,
                e17_p3_e021_gr3_61_17_session2,
                e17_p3_e021_gr1_61_29_session1,
                e17_p3_e021_gr1_61_29_session2,
                e17_p3_e021_gr2_61_182_session1,
                e17_p3_e021_gr1_61_183_session1,
                e17_p3_e021_gr3_61_183_session1,
                e17_p3_e021_gr4_61_47_session1,
                e17_p3_e021_gr3_61_24_session1,
                e17_p3_e021_gr1_61_97_session1,
                e17_p3_e023_gr1_63_49_session1,
                e17_p3_e023_gr1_63_24_session1,
                e17_p3_e023_gr1_63_185_session1,
                e17_p3_e023_gr1_63_128_session1,
                e17_p3_e023_gr5_63_14_session1,
                e17_p3_e023_gr5_63_14_session2,
                e17_p3_e023_gr3_63_184_session1,
                e17_p3_e023_gr1_63_11_session1,
                e17_p3_e023_gr1_63_11_session2,
                e17_p3_e023_gr1_63_16_session1,
                e17_p3_e023_gr1_63_16_session2,
                e17_p3_e023_gr1_63_27_session1,
                e17_p3_e023_gr1_63_27_session2,
                e17_p3_e023_gr3_63_27_session1,
                e17_p3_e023_gr3_63_27_session2,
                e17_p3_e023_gr2_63_29_session1,
                e17_p3_e023_gr2_63_29_session2,
                e17_p3_e023_gr2_63_58_session1,
                e17_p3_e023_gr2_63_58_session2,
                e17_p3_e023_gr1_63_188_session1,
                e17_p3_e023_gr1_63_188_session2

             );
            #endregion

        }
    }
}
