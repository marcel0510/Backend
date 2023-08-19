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
            //AULA E16/P1/E006A - LAB. ELECTROTECNIA
            var e16_p1_e006a_gr1_1_15 = new Group()
            {
                Id = 501,
                Name = "GR1-1",
                SubjectId = 15,
                ClassroomId = 1,
                CalendarId = 1,
                Sessions = new List<Session>() {
                    new Session() {
                        Id = 1001,
                        Day = Enum.Day.Martes,
                        StartTime = new TimeSpan(9, 0, 0),
                        EndTime = new TimeSpan(11, 0, 0)
                    }
                }
            };
            var e16_p1_e006a_gr1_2_15 = new Group()
            {
                Id = 502,
                Name = "GR1-2",
                SubjectId = 15,
                ClassroomId = 1,
                CalendarId = 1,
                Sessions = new List<Session>() {
                    new Session() {
                        Id = 1002,
                        Day = Enum.Day.Lunes,
                        StartTime = new TimeSpan(14, 0, 0),
                        EndTime = new TimeSpan(16, 0, 0)
                    }
                }
            };
            var e16_p1_e006a_gr1_3_15 = new Group()
            {
                Id = 503,
                Name = "GR1-3",
                SubjectId = 15,
                ClassroomId = 1,
                CalendarId = 1,
                Sessions = new List<Session>() {
                    new Session() {
                        Id = 1003,
                        Day = Enum.Day.Miercoles,
                        StartTime = new TimeSpan(14, 0, 0),
                        EndTime = new TimeSpan(16, 0, 0)
                    }
                }
            };
            var e16_p1_e006a_gr1_4_15 = new Group()
            {
                Id = 504,
                Name = "GR1-4",
                SubjectId = 15,
                ClassroomId = 1,
                CalendarId = 1,
                Sessions = new List<Session>() {
                    new Session() {
                        Id = 1004,
                        Day = Enum.Day.Lunes,
                        StartTime = new TimeSpan(16, 0, 0),
                        EndTime = new TimeSpan(18, 0, 0)
                    }
                }
            };
            var e16_p1_e006a_gr3_1_15 = new Group()
            {
                Id = 505,
                Name = "GR3-1",
                SubjectId = 15,
                ClassroomId = 1,
                CalendarId = 1,
                Sessions = new List<Session>() {
                    new Session() {
                        Id = 1005,
                        Day = Enum.Day.Lunes,
                        StartTime = new TimeSpan(9, 0, 0),
                        EndTime = new TimeSpan(11, 0, 0)
                    }
                }
            };
            var e16_p1_e006a_gr3_3_15 = new Group()
            {
                Id = 506,
                Name = "GR3-3",
                SubjectId = 15,
                ClassroomId = 1,
                CalendarId = 1,
                Sessions = new List<Session>() {
                    new Session() {
                        Id = 1006,
                        Day = Enum.Day.Martes,
                        StartTime = new TimeSpan(14, 0, 0),
                        EndTime = new TimeSpan(16, 0, 0)
                    }
                }
            };
            var e16_p1_e006a_gr3_4_15 = new Group()
            {
                Id = 507,
                Name = "GR3-4",
                SubjectId = 15,
                ClassroomId = 1,
                CalendarId = 1,
                Sessions = new List<Session>() {
                    new Session() {
                        Id = 1007,
                        Day = Enum.Day.Jueves,
                        StartTime = new TimeSpan(14, 0, 0),
                        EndTime = new TimeSpan(16, 0, 0)
                    }
                }
            };
            var e16_p1_e006a_gr3_5_15 = new Group()
            {
                Id = 508,
                Name = "GR3-5",
                SubjectId = 15,
                ClassroomId = 1,
                CalendarId = 1,
                Sessions = new List<Session>() {
                    new Session() {
                        Id = 1008,
                        Day = Enum.Day.Viernes,
                        StartTime = new TimeSpan(7, 0, 0),
                        EndTime = new TimeSpan(9, 0, 0)
                    }
                }
            };
            var e16_p1_e006a_gr5_2_15 = new Group()
            {
                Id = 509,
                Name = "GR5-2",
                SubjectId = 15,
                ClassroomId = 1,
                CalendarId = 1,
                Sessions = new List<Session>() {
                    new Session() {
                        Id = 1009,
                        Day = Enum.Day.Martes,
                        StartTime = new TimeSpan(7, 0, 0),
                        EndTime = new TimeSpan(9, 0, 0)
                    }
                }
            };
            var e16_p1_e006a_gr5_3_15 = new Group()
            {
                Id = 510,
                Name = "GR5-3",
                SubjectId = 15,
                ClassroomId = 1,
                CalendarId = 1,
                Sessions = new List<Session>() {
                    new Session() {
                        Id = 1010,
                        Day = Enum.Day.Miercoles,
                        StartTime = new TimeSpan(7, 0, 0),
                        EndTime = new TimeSpan(9, 0, 0)
                    }
                }
            };
            var e16_p1_e006a_gr5_4_15 = new Group()
            {
                Id = 511,
                Name = "GR5-4",
                SubjectId = 15,
                ClassroomId = 1,
                CalendarId = 1,
                Sessions = new List<Session>() {
                    new Session() {
                        Id = 1011,
                        Day = Enum.Day.Jueves,
                        StartTime = new TimeSpan(7, 0, 0),
                        EndTime = new TimeSpan(9, 0, 0)
                    }
                }
            };
            var e16_p1_e006a_gr5_5_15 = new Group()
            {
                Id = 512,
                Name = "GR5-5",
                SubjectId = 15,
                ClassroomId = 1,
                CalendarId = 1,
                Sessions = new List<Session>() {
                    new Session() {
                        Id = 1012,
                        Day = Enum.Day.Lunes,
                        StartTime = new TimeSpan(11, 0, 0),
                        EndTime = new TimeSpan(13, 0, 0)
                    }
                }
            };
















        }
    }
}
