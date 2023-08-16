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
            var e17_s1_e023 = new Classroom()
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
            var e17_p5_e010 = new Classroom()
            {
                Id = 75,
                Code = "E010",
                IsLab = true,
                Name = "Lab. Petroleos",
                Capacity = 48,
                Floor = "P5",
                BuildingId = 2,
            };
            var e17_p5_e020 = new Classroom()
            {
                Id = 76,
                Code = "E020",
                IsLab = false,
                Name = null,
                Capacity = 48,
                Floor = "P5",
                BuildingId = 2,
            };
            var e17_p5_e027 = new Classroom()
            {
                Id = 77,
                Code = "E027",
                IsLab = false,
                Name = null,
                Capacity = 50,
                Floor = "P5",
                BuildingId = 2,
            };
            var e17_p5_e028 = new Classroom()
            {
                Id = 78,
                Code = "E028",
                IsLab = false,
                Name = null,
                Capacity = 48,
                Floor = "P5",
                BuildingId = 2,
            };
            var e17_p5_e029 = new Classroom()
            {
                Id = 79,
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
                Id = 80,
                Code = "E002",
                IsLab = true,
                Name = "LAB. DE SENSORES Y TRANSDUCTORES",
                Capacity = 8,
                Floor = "P6",
                BuildingId = 2,
            };
            var e17_p6_e003 = new Classroom()
            {
                Id = 81,
                Code = "E003",
                IsLab = true,
                Name = "LAB. INSTRUMENTACIÓN INDUSTRIAL",
                Capacity = 6,
                Floor = "P6",
                BuildingId = 2,
            };
            var e17_p6_e004 = new Classroom()
            {
                Id = 82,
                Code = "E004",
                IsLab = true,
                Name = "LAB. DE SCADA",
                Capacity = 6,
                Floor = "P6",
                BuildingId = 2,
            };
            var e17_p6_e022 = new Classroom()
            {
                Id = 83,
                Code = "E022",
                IsLab = true,
                Name = "LAB. SALA E",
                Capacity = 20,
                Floor = "P6",
                BuildingId = 2,
            };
            var e17_p6_e023 = new Classroom()
            {
                Id = 84,
                Code = "E023",
                IsLab = true,
                Name = "LAB. SALA D",
                Capacity = 20,
                Floor = "P6",
                BuildingId = 2,
            };
            var e17_p6_e026 = new Classroom()
            {
                Id = 85,
                Code = "E026",
                IsLab = true,
                Name = "LAB. SALA C",
                Capacity = 20,
                Floor = "P6",
                BuildingId = 2,
            };
            var e17_p6_e027 = new Classroom()
            {
                Id = 86,
                Code = "E027",
                IsLab = true,
                Name = "LAB. SALA B",
                Capacity = 20,
                Floor = "P6",
                BuildingId = 2,
            };
            var e17_p6_e028 = new Classroom()
            {
                Id = 87,
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
                Id = 88,
                Code = "E001",
                IsLab = true,
                Name = "LAB. COMUNICACIONES INALÁMBRICAS",
                Capacity = 8,
                Floor = "P7",
                BuildingId = 2,
            };
            var e17_p7_e002 = new Classroom()
            {
                Id = 89,
                Code = "E002",
                IsLab = true,
                Name = "LAB. SISTEMAS DE TRANSMISIÓN",
                Capacity = 6,
                Floor = "P7",
                BuildingId = 2,
            };
            var e17_p7_e003 = new Classroom()
            {
                Id = 90,
                Code = "E003",
                IsLab = true,
                Name = "LAB. SOFTWARE DEFINIDO POR RADIO",
                Capacity = 20,
                Floor = "P8",
                BuildingId = 2,
            };
            var e17_p7_e004 = new Classroom()
            {
                Id = 91,
                Code = "E004",
                IsLab = true,
                Name = "LAB. INTERCONECTIVIDAD",
                Capacity = 30,
                Floor = "P7",
                BuildingId = 2,
            };
            var e17_p7_e005 = new Classroom()
            {
                Id = 92,
                Code = "E005",
                IsLab = true,
                Name = "LAB. COMUNICACIONES UNIFICADAS",
                Capacity = 18,
                Floor = "P7",
                BuildingId = 2,
            };
            var e17_p7_e006 = new Classroom()
            {
                Id = 93,
                Code = "E006",
                IsLab = true,
                Name = "LAB. REDES INDUSTRIALES Y SCADA",
                Capacity = 8,
                Floor = "P7",
                BuildingId = 2,
            };
            var e17_p7_e008 = new Classroom()
            {
                Id = 94,
                Code = "E008",
                IsLab = true,
                Name = "LAB. DE INVEST. EN REDES Y SISTEMAS DISTRI",
                Capacity = 8,
                Floor = "P7",
                BuildingId = 2,
            };
            var e17_p7_e014 = new Classroom()
            {
                Id = 95,
                Code = "E014",
                IsLab = true,
                Name = "LAB. INVES. Y SIMULACION DE TELECOM",
                Capacity = 6,
                Floor = "P7",
                BuildingId = 2,
            };
            var e17_p7_e015 = new Classroom()
            {
                Id = 96,
                Code = "E015",
                IsLab = true,
                Name = "LAB. COMUNICACIONES OPTICAS",
                Capacity = 6,
                Floor = "P7",
                BuildingId = 2,
            };
            var e17_p7_e024 = new Classroom()
            {
                Id = 97,
                Code = "E024",
                IsLab = false,
                Name = null,
                Capacity = 30,
                Floor = "P7",
                BuildingId = 2,
            };
            var e17_p7_e025 = new Classroom()
            {
                Id = 98,
                Code = "E025",
                IsLab = false,
                Name = null,
                Capacity = 32,
                Floor = "P7",
                BuildingId = 2,
            };
            var e17_p7_e026 = new Classroom()
            {
                Id = 99,
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
                Id = 100,
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
                Id = 101,
                Code = "E001",
                IsLab = false,
                Name = null,
                Capacity = 30,
                Floor = "PB",
                BuildingId = 2,
            };
            var e17_pb_e014 = new Classroom()
            {
                Id = 102,
                Code = "E014",
                IsLab = false,
                Name = null,
                Capacity = 18,
                Floor = "PB",
                BuildingId = 2,
            };
            var e17_pb_e020 = new Classroom()
            {
                Id = 103,
                Code = "E020",
                IsLab = false,
                Name = null,
                Capacity = 55,
                Floor = "PB",
                BuildingId = 2,
            };
            var e17_pb_e023 = new Classroom()
            {
                Id = 104,
                Code = "E023",
                IsLab = true,
                Name = "LAB. CONTROL DE PROCESOS",
                Capacity = 10,
                Floor = "PB",
                BuildingId = 2,
            };

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
                e17_p4_e004, e17_p4_e005, e17_p4_e006, e17_p4_e007, e17_p4_e008, e17_p4_e009, e17_p4_e013, e17_p4_e020, e17_p4_e021, e17_p4_e022, e17_s1_e023,
                e17_p5_e010, e17_p5_e020, e17_p5_e027, e17_p5_e028, e17_p5_e029,
                e17_p6_e002, e17_p6_e003, e17_p6_e004, e17_p6_e022, e17_p6_e023, e17_p6_e026, e17_p6_e027, e17_p6_e028,
                e17_p7_e001, e17_p7_e002, e17_p7_e003, e17_p7_e004, e17_p7_e005, e17_p7_e006, e17_p7_e008, e17_p7_e014, e17_p7_e015, e17_p7_e024, e17_p7_e025, e17_p7_e026,
                e17_P8_e002,
                e17_pb_e001, e17_pb_e014, e17_pb_e020, e17_pb_e023
                );

            //**************************** MATERIAS ***************************
            //Electrotecnia
            var electrotecnia = new Subject() { 
                Id = 1,
                Code = "IEED272L",
                IsLab = true,
                Name = "LABORATORIO ELECTROTECNIA",
                Alias = null,
                NumHours = 2,
                NumCredits = 2,
                NumSemester = 2,
            };
            var fundamentoscircuitos = new Subject() {
                Id = 2,
                Code = "IEED353L",
                IsLab = true,
                Name = "LABORATORIO FUNDAMENTOS DE CIRCUITOS ELECTRICOS",
                Alias = null,
                NumHours = 2,
                NumCredits = 2,
                NumSemester = 3,
            };

            //GRUPO GR1-1
            var gr1_1 = new Group() {
                Id = 1,
                Name = "GR1-1",
                SubjectId = 1,
                ClassroomId = 1,
                CalendarId = 1,
            };

            //Sesion 1
            var session1GR1_1_electrotecnica = new Session() { 
                Id = 1,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11,0, 0),
                GroupId = 1,
            };
         

            modelBuilder.Entity<Subject>().HasData(electrotecnia, fundamentoscircuitos);
            modelBuilder.Entity<Group>().HasData(gr1_1);
            modelBuilder.Entity<Session>().HasData(session1GR1_1_electrotecnica);

            //Materias
            //var adminRedes = new Subject()
            //{
            //    Id = 1,
            //    Code = "ITID843",
            //    Name = "ADMINISTRACION DE REDES",
            //    NumHours = 4,
            //    NumCredits = 3,
            //    NumSemester = 8,
            //    IsLab = false
            //};
            //var evalRedes = new Subject()
            //{
            //    Id = 2,
            //    Code = "ITID822",
            //    Name = "EVALUACION DE REDES",
            //    NumHours = 4,
            //    NumCredits = 3,
            //    NumSemester = 8,
            //    IsLab = false
            //};
            //var hacking = new Subject()
            //{
            //    Id = 3,
            //    Code = "ITID801",
            //    Name = "HACKING ETICO",
            //    NumHours = 3,
            //    NumCredits = 2,
            //    NumSemester = 8,
            //    IsLab = false
            //};
            //var wlan = new Subject()
            //{
            //    Id = 4,
            //    Code = "ITID832",
            //    Name = "REDES DE AREA LOCAL INALAMBRICAS",
            //    Alias = "WLAN",
            //    NumHours = 3,
            //    NumCredits = 3,
            //    NumSemester = 8,
            //    IsLab = false
            //};
            //var web = new Subject()
            //{
            //    Id = 5,
            //    Code = "ITID753",
            //    Name = "APLICACIONES WEB Y MOVILES",
            //    NumHours = 4,
            //    NumCredits = 3,
            //    NumSemester = 7,
            //    IsLab = false
            //};
            //var redesIntra = new Subject()
            //{
            //    Id = 6,
            //    Code = "ITID742",
            //    Name = "REDES E INTRANETS",
            //    NumHours = 4,
            //    NumCredits = 3,
            //    NumSemester = 7,
            //    IsLab = false
            //};
            //var appsDistr = new Subject()
            //{
            //    Id = 7,
            //    Code = "ITID713",
            //    Name = "APLICACIONES DISTRIBUIDAS",
            //    NumHours = 3,
            //    NumCredits = 2,
            //    NumSemester = 7,
            //    IsLab = false
            //};
            //var lan = new Subject()
            //{
            //    Id = 8,
            //    Code = "ITID623",
            //    Name = "REDES DE AREA LOCAL",
            //    NumHours = 3,
            //    NumCredits = 2,
            //    NumSemester = 6,
            //    IsLab = false
            //};
            //var lanLab = new Subject()
            //{
            //    Id = 9,
            //    Code = "ITID623L",
            //    Name = "LABORATORIO REDES DE AREA LOCAL",
            //    NumHours = 2,
            //    NumCredits = 2,
            //    NumSemester = 6,
            //    IsLab = true
            //};
            //var wan = new Subject()
            //{
            //    Id = 10,
            //    Code = "ITID723",
            //    Name = "REDES DE AREA EXTENDIDA",
            //    NumHours = 3,
            //    NumCredits = 2,
            //    NumSemester = 6,
            //    IsLab = false
            //};
            //var wanLab = new Subject()
            //{
            //    Id = 11,
            //    Code = "ITID723L",
            //    Name = "LABORATORIO REDES DE AREA LOCAL",
            //    NumHours = 2,
            //    NumCredits = 2,
            //    NumSemester = 6,
            //    IsLab = true
            //};
            //var trxDigital = new Subject()
            //{
            //    Id = 12,
            //    Code = "ITID524",
            //    Name = "TRANSMISION DIGITAL",
            //    NumHours = 2,
            //    NumCredits = 2,
            //    NumSemester = 5,
            //    IsLab = false
            //};
            //var trxDigitalLab = new Subject()
            //{
            //    Id = 13,
            //    Code = "ITID524L",
            //    Name = "LABORATORIO TRANSMISION DIGITAL",
            //    NumHours = 2,
            //    NumCredits = 2,
            //    NumSemester = 5,
            //    IsLab = true
            //};
            //var sisOp = new Subject()
            //{
            //    Id = 14,
            //    Code = "ITID452",
            //    Name = "SISTEMAS OPERATIVOS",
            //    NumHours = 3,
            //    NumCredits = 3,
            //    NumSemester = 4,
            //    IsLab = false
            //};
            //var prograAva = new Subject()
            //{
            //    Id = 15,
            //    Code = "ITID433",
            //    Name = "PROGRAMACION AVANZADA",
            //    NumHours = 3,
            //    NumCredits = 2,
            //    NumSemester = 4,
            //    IsLab = false
            //};

            //modelBuilder.Entity<Subject>().HasData(adminRedes, evalRedes, hacking, wlan, web, redesIntra, appsDistr, lan, lanLab, wan, wanLab, trxDigital, trxDigitalLab, sisOp, prograAva);

            //Aulas
            //var aula1 = new Classroom()
            //{
            //    Id = 1,
            //    Code = "E023",
            //    IsLab = true,
            //    Name = "Laboratorioa FIEE CEC 1",
            //    Capacity = 25,
            //    Floor = "P6",
            //    BuildingId = 2,
            //};
            //var aula2 = new Classroom()
            //{
            //    Id = 2,
            //    Code = "E028",
            //    IsLab = false,
            //    Name = null,
            //    Capacity = 35,
            //    Floor = "P5",
            //    BuildingId = 2,
            //};
            //var aula3 = new Classroom()
            //{
            //    Id = 3,
            //    Code = "E026",
            //    IsLab = true,
            //    Name = "Laboratorio FIEE CEC 2",
            //    Capacity = 25,
            //    Floor = "P6",
            //    BuildingId = 2,
            //};
            //var aula4 = new Classroom()
            //{
            //    Id = 4,
            //    Code = "E002",
            //    IsLab = false,
            //    Name = null,
            //    Capacity = 20,
            //    Floor = "P2",
            //    BuildingId = 1,
            //};
            //var aula5 = new Classroom()
            //{
            //    Id = 5,
            //    Code = "LABINTC",
            //    IsLab = true,
            //    Name = "LABORATORIO DE INTERCONECTIVIDAD",
            //    Capacity = 20,
            //    Floor = "P7",
            //    BuildingId = 2
            //};
            //var aula6 = new Classroom()
            //{
            //    Id = 6,
            //    Code = "E003",
            //    IsLab = false,
            //    Name = null,
            //    Capacity = 20,
            //    Floor = "P2",
            //    BuildingId = 1
            //};
            //var aula7 = new Classroom()
            //{
            //    Id = 7,
            //    Code = "E022",
            //    IsLab = false,
            //    Name = null,
            //    Capacity = 20,
            //    Floor = "P6",
            //    BuildingId = 2
            //};
            //var aula8 = new Classroom()
            //{
            //    Id = 8,
            //    Code = "E022",
            //    IsLab = false,
            //    Name = null,
            //    Capacity = 20,
            //    Floor = "P3",
            //    BuildingId = 2
            //};
            //var aula9 = new Classroom()
            //{
            //    Id = 9,
            //    Code = "E001",
            //    IsLab = false,
            //    Name = null,
            //    Capacity = 20,
            //    Floor = "P2",
            //    BuildingId = 1
            //};
            //var aula10 = new Classroom()
            //{
            //    Id = 10,
            //    Code = "E004",
            //    IsLab = false,
            //    Name = null,
            //    Capacity = 20,
            //    Floor = "P7",
            //    BuildingId = 2,

            //};

            //modelBuilder.Entity<Classroom>().HasData(aula1, aula2, aula3, aula4, aula5, aula6, aula7, aula8, aula9, aula10);

            //Grupos
            //var grAdmin = new Group()
            //{
            //    Id = 1,
            //    Name = "GR1",
            //    SubjectId = 1,
            //    ClassroomId = 1,
            //    CalendarId = 1,
            //};
            //var grEvalRedes = new Group()
            //{
            //    Id = 2,
            //    Name = "GR1",
            //    SubjectId = 2,
            //    ClassroomId = 2,
            //    CalendarId = 1,

            //};
            //var grHacking = new Group()
            //{
            //    Id = 3,
            //    Name = "GR1",
            //    SubjectId = 3,
            //    ClassroomId = 3,
            //    CalendarId = 1,

            //};

            //Llenado aula4
            //var grIntranets = new Group()
            //{
            //    Id = 4,
            //    Name = "GR1",
            //    SubjectId = 6,
            //    ClassroomId = 4,
            //    CalendarId = 1,

            //};
            //var grDistr = new Group()
            //{
            //    Id = 5,
            //    Name = "GR1",
            //    SubjectId = 7,
            //    ClassroomId = 4,
            //    CalendarId = 1,

            //};
            //var grwlan = new Group()
            //{
            //    Id = 6,
            //    Name = "GR1",
            //    SubjectId = 4,
            //    ClassroomId = 4,
            //    CalendarId = 1,

            //};
            //var grSisOp = new Group()
            //{
            //    Id = 7,
            //    Name = "GR1",
            //    SubjectId = 14,
            //    ClassroomId = 4,
            //    CalendarId = 1,

            //};

            //modelBuilder.Entity<Group>().HasData(grAdmin, grEvalRedes, grHacking, grIntranets, grDistr, grwlan, grSisOp);

            //Sesiones
            //Grupo Admin
            //var sessionAdmin1 = new Session()
            //{
            //    Id = 1,
            //    Day = Enum.Day.Lunes,
            //    StartTime = new TimeSpan(9, 0, 0),
            //    EndTime = new TimeSpan(11, 0, 0),
            //    GroupId = 1,
            //};
            //var sessionAdmin2 = new Session()
            //{
            //    Id = 2,
            //    Day = Enum.Day.Martes,
            //    StartTime = new TimeSpan(11, 0, 0),
            //    EndTime = new TimeSpan(13, 0, 0),
            //    GroupId = 1,
            //};
            //Grupo Eval
            //var sessionEval1 = new Session()
            //{
            //    Id = 3,
            //    Day = Enum.Day.Lunes,
            //    StartTime = new TimeSpan(11, 0, 0),
            //    EndTime = new TimeSpan(13, 0, 0),
            //    GroupId = 2
            //};
            //var sessionEval2 = new Session()
            //{
            //    Id = 4,
            //    Day = Enum.Day.Jueves,
            //    StartTime = new TimeSpan(7, 0, 0),
            //    EndTime = new TimeSpan(9, 0, 0),
            //    GroupId = 2
            //};
            //Grupo Hacking
            //var sessionHacking1 = new Session()
            //{
            //    Id = 5,
            //    Day = Enum.Day.Martes,
            //    StartTime = new TimeSpan(9, 0, 0),
            //    EndTime = new TimeSpan(11, 0, 0),
            //    GroupId = 3
            //};
            //var sessionHacking2 = new Session()
            //{
            //    Id = 6,
            //    Day = Enum.Day.Viernes,
            //    StartTime = new TimeSpan(10, 0, 0),
            //    EndTime = new TimeSpan(11, 0, 0),
            //    GroupId = 3
            //};

            //Llenado aula4
            //Sesiones Intranets
            //var sessionHIntra1 = new Session()
            //{
            //    Id = 7,
            //    Day = Enum.Day.Lunes,
            //    StartTime = new TimeSpan(9, 0, 0),
            //    EndTime = new TimeSpan(11, 0, 0),
            //    GroupId = 4
            //};
            //var sessionHIntra2 = new Session()
            //{
            //    Id = 8,
            //    Day = Enum.Day.Martes,
            //    StartTime = new TimeSpan(12, 0, 0),
            //    EndTime = new TimeSpan(13, 0, 0),
            //    GroupId = 4
            //};
            //Sesiones Ditri
            //var sessionDistri1 = new Session()
            //{
            //    Id = 9,
            //    Day = Enum.Day.Jueves,
            //    StartTime = new TimeSpan(9, 0, 0),
            //    EndTime = new TimeSpan(11, 0, 0),
            //    GroupId = 5
            //};
            //var sessionDistri2 = new Session()
            //{
            //    Id = 10,
            //    Day = Enum.Day.Viernes,
            //    StartTime = new TimeSpan(7, 0, 0),
            //    EndTime = new TimeSpan(9, 0, 0),
            //    GroupId = 5
            //};
            //Sesiones WLAN
            //var sessionwlan = new Session()
            //{
            //    Id = 11,
            //    Day = Enum.Day.Viernes,
            //    StartTime = new TimeSpan(11, 0, 0),
            //    EndTime = new TimeSpan(13, 0, 0),
            //    GroupId = 6
            //};
            //Sesiones de Sistemas Op
            //var sessionsysOp1 = new Session()
            //{
            //    Id = 12,
            //    Day = Enum.Day.Lunes,
            //    StartTime = new TimeSpan(11, 0, 0),
            //    EndTime = new TimeSpan(13, 0, 0),
            //    GroupId = 7
            //};
            //var sessionsysOp2 = new Session()
            //{
            //    Id = 13,
            //    Day = Enum.Day.Miercoles,
            //    StartTime = new TimeSpan(8, 0, 0),
            //    EndTime = new TimeSpan(9, 0, 0),
            //    GroupId = 7
            //};
            //var sessionsysOp3 = new Session()
            //{
            //    Id = 14,
            //    Day = Enum.Day.Viernes,
            //    StartTime = new TimeSpan(9, 0, 0),
            //    EndTime = new TimeSpan(11, 0, 0),
            //    GroupId = 7
            //};


            //modelBuilder.Entity<Session>().HasData(
            //    sessionAdmin1, sessionAdmin2,
            //    sessionEval1, sessionEval2,
            //    sessionHacking1, sessionHacking2,
            //    sessionHIntra1, sessionHIntra2,
            //    sessionDistri1, sessionDistri2,
            //    sessionwlan,
            //    sessionsysOp1, sessionsysOp2, sessionsysOp3);

        }


    }
}
