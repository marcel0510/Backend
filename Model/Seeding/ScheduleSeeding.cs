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
                Password = "password",
                Name = "Admin",
                Role = Enum.Role.Admin
            };

            modelBuilder.Entity<User>().HasData(admin);

            //Celenadario
            var calendar2022b = new Calendar()
            {
                Id = 1,
                Period = "2022B",
                PeridoInit = new DateTime(2022, 8, 23),
                PeriodEnd = new DateTime(2023, 3, 31)
            };

            modelBuilder.Entity<Calendar>().HasData(calendar2022b);

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

            //Materias
            var adminRedes = new Subject()
            {
                Id = 1,
                Code = "ITID843",
                Name = "ADMINISTRACION DE REDES",
                NumHours = 4,
                NumCredits = 3,
                NumSemester = 8,
                IsLab = false
            };
            var evalRedes = new Subject()
            {
                Id = 2,
                Code = "ITID822",
                Name = "EVALUACION DE REDES",
                NumHours = 4,
                NumCredits = 3,
                NumSemester = 8,
                IsLab = false
            };
            var hacking = new Subject()
            {
                Id = 3,
                Code = "ITID801",
                Name = "HACKING ETICO",
                NumHours = 3,
                NumCredits = 2,
                NumSemester = 8,
                IsLab = false
            };
            var wlan = new Subject()
            {
                Id = 4,
                Code = "ITID832",
                Name = "REDES DE AREA LOCAL INALAMBRICAS",
                NumHours = 3,
                NumCredits = 3,
                NumSemester = 8,
                IsLab = false
            };
            var web = new Subject()
            {
                Id = 5,
                Code = "ITID753",
                Name = "APLICACIONES WEB Y MOVILES",
                NumHours = 4,
                NumCredits = 3,
                NumSemester = 7,
                IsLab = false
            };
            var redesIntra = new Subject()
            {
                Id = 6,
                Code = "ITID742",
                Name = "REDES E INTRANETS",
                NumHours = 4,
                NumCredits = 3,
                NumSemester = 7,
                IsLab = false
            };
            var appsDistr = new Subject()
            {
                Id = 7,
                Code = "ITID713",
                Name = "APLICACIONES DISTRIBUIDAS",
                NumHours = 3,
                NumCredits = 2,
                NumSemester = 7,
                IsLab = false
            };
            var lan = new Subject()
            {
                Id = 8,
                Code = "ITID623",
                Name = "REDES DE AREA LOCAL",
                NumHours = 3,
                NumCredits = 2,
                NumSemester = 6,
                IsLab = false
            };
            var lanLab = new Subject()
            {
                Id = 9,
                Code = "ITID623L",
                Name = "LABORATORIO REDES DE AREA LOCAL",
                NumHours = 2,
                NumCredits = 2,
                NumSemester = 6,
                IsLab = true
            };
            var wan = new Subject()
            {
                Id = 10,
                Code = "ITID723",
                Name = "REDES DE AREA EXTENDIDA",
                NumHours = 3,
                NumCredits = 2,
                NumSemester = 6,
                IsLab = false
            };
            var wanLab = new Subject()
            {
                Id = 11,
                Code = "ITID723L",
                Name = "LABORATORIO REDES DE AREA LOCAL",
                NumHours = 2,
                NumCredits = 2,
                NumSemester = 6,
                IsLab = true
            };
            var trxDigital = new Subject()
            {
                Id = 12,
                Code = "ITID524",
                Name = "TRANSMISION DIGITAL",
                NumHours = 2,
                NumCredits = 2,
                NumSemester = 5,
                IsLab = false
            };
            var trxDigitalLab = new Subject()
            {
                Id = 13,
                Code = "ITID524L",
                Name = "LABORATORIO TRANSMISION DIGITAL",
                NumHours = 2,
                NumCredits = 2,
                NumSemester = 5,
                IsLab = true
            };
            var sisOp = new Subject()
            {
                Id = 14,
                Code = "ITID452",
                Name = "SISTEMAS OPERATIVOS",
                NumHours = 3,
                NumCredits = 3,
                NumSemester = 4,
                IsLab = false
            };
            var prograAva = new Subject()
            {
                Id = 15,
                Code = "ITID433",
                Name = "PROGRAMACION AVANZADA",
                NumHours = 3,
                NumCredits = 2,
                NumSemester = 4,
                IsLab = false
            };

            modelBuilder.Entity<Subject>().HasData(adminRedes, evalRedes, hacking, wlan, web, redesIntra, appsDistr, lan, lanLab, wan, wanLab, trxDigital, trxDigitalLab, sisOp, prograAva);

            //Aulas
            var aula1 = new Classroom()
            {
                Id= 1,
                Code = "E023",
                IsLab= true,
                Name = "Laboratorioa FIEE CEC 1",
                Capacity = 25,
                Floor = "P6",
                BuildingId = 2,
                CalendarId = 1
            };
            var aula2 = new Classroom()
            {
                Id = 2,
                Code = "E028",
                IsLab = false,
                Name = null,
                Capacity = 35,
                Floor = "P5",
                BuildingId = 2,
                CalendarId = 1
            };
            var aula3 = new Classroom()
            {
                Id = 3,
                Code = "E026",
                IsLab = true,
                Name = "Laboratorio FIEE CEC 2",
                Capacity = 25,
                Floor = "P6",
                BuildingId = 2,
                CalendarId = 1
            };
            var aula4 = new Classroom()
            {
                Id = 4,
                Code = "E002",
                IsLab = false,
                Name = null,
                Capacity = 20,
                Floor = "P2",
                BuildingId = 1,
                CalendarId = 1
            };
            var aula5 = new Classroom()
            {
                Id = 5,
                Code = "LABINTC",
                IsLab = true,
                Name = "LABORATORIO DE INTERCONECTIVIDAD",
                Capacity = 20,
                Floor = "P7",
                BuildingId = 2,
                CalendarId = 1
            };
            var aula6 = new Classroom()
            {
                Id = 6,
                Code = "E003",
                IsLab = false,
                Name = null,
                Capacity = 20,
                Floor = "P2",
                BuildingId = 1,
                CalendarId = 1
            };
            var aula7 = new Classroom()
            {
                Id = 7,
                Code = "E022",
                IsLab = false,
                Name = null,
                Capacity = 20,
                Floor = "P6",
                BuildingId = 2,
                CalendarId = 1
            };
            var aula8 = new Classroom()
            {
                Id = 8,
                Code = "E022",
                IsLab = false,
                Name = null,
                Capacity = 20,
                Floor = "P3",
                BuildingId = 2,
                CalendarId = 1
            };
            var aula9 = new Classroom()
            {
                Id = 9,
                Code = "E001",
                IsLab = false,
                Name = null,
                Capacity = 20,
                Floor = "P2",
                BuildingId = 1,
                CalendarId = 1
            };
            var aula10 = new Classroom()
            {
                Id = 10,
                Code = "E004",
                IsLab = false,
                Name = null,
                Capacity = 20,
                Floor = "P7",
                BuildingId = 2,
                CalendarId = 1
            };

            modelBuilder.Entity<Classroom>().HasData(aula1, aula2, aula3, aula4, aula5, aula6, aula7, aula8, aula9, aula10);

            //Grupos
            var grAdmin = new Group() { 
                Id = 1,
                Name = "GR1",
                SubjectId = 1,
                ClassroomId = 1,
            };
            var grEvalRedes = new Group()
            {
                Id = 2,
                Name = "GR1",
                SubjectId = 2,
                ClassroomId = 2,
            };
            var grHacking = new Group()
            {
                Id = 3,
                Name = "GR1",
                SubjectId = 3,
                ClassroomId = 3,
            };

            //Llenado aula4
            var grIntranets = new Group()
            {
                Id = 4,
                Name = "GR1",
                SubjectId = 6,
                ClassroomId = 4,
            };
            var grDistr = new Group()
            {
                Id = 5,
                Name = "GR1",
                SubjectId = 7,
                ClassroomId = 4,
            };
            var grwlan = new Group()
            {
                Id = 6,
                Name = "GR1",
                SubjectId = 4,
                ClassroomId = 4,
            };
            var grSisOp = new Group()
            {
                Id = 7,
                Name = "GR1",
                SubjectId = 14,
                ClassroomId = 4,
            };

            modelBuilder.Entity<Group>().HasData(grAdmin, grEvalRedes, grHacking, grIntranets, grDistr, grwlan, grSisOp);

            //Sesiones
            //Grupo Admin
            var sessionAdmin1 = new Session() {
                Id = 1,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 1,
            };
            var sessionAdmin2 = new Session()
            {
                Id = 2,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 1,
            };
            //Grupo Eval
            var sessionEval1 = new Session()
            {
                Id = 3,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan (13, 0, 0),
                GroupId = 2
            };
            var sessionEval2 = new Session()
            {
                Id = 4,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 2
            };
            //Grupo Hacking
            var sessionHacking1 = new Session()
            {
                Id = 5,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 3
            };
            var sessionHacking2 = new Session()
            {
                Id = 6,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(10, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 3
            };

            //Llenado aula4
            //Sesiones Intranets
            var sessionHIntra1 = new Session()
            {
                Id = 7,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 4
            };
            var sessionHIntra2 = new Session()
            {
                Id = 8,
                Day = Enum.Day.Martes,
                StartTime = new TimeSpan(12, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 4
            };
            //Sesiones Ditri
            var sessionDistri1 = new Session()
            {
                Id = 9,
                Day = Enum.Day.Jueves,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 5
            };
            var sessionDistri2 = new Session()
            {
                Id = 10,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(7, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 5
            };
            //Sesiones WLAN
            var sessionwlan = new Session() 
            {
                Id = 11,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 6
            };
            //Sesiones de Sistemas Op
            var sessionsysOp1 = new Session()
            {
                Id = 12,
                Day = Enum.Day.Lunes,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(13, 0, 0),
                GroupId = 7
            };
            var sessionsysOp2 = new Session()
            {
                Id = 13,
                Day = Enum.Day.Miercoles,
                StartTime = new TimeSpan(8, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                GroupId = 7
            };
            var sessionsysOp3 = new Session()
            {
                Id = 14,
                Day = Enum.Day.Viernes,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0),
                GroupId = 7
            };


            modelBuilder.Entity<Session>().HasData(
                sessionAdmin1, sessionAdmin2,
                sessionEval1, sessionEval2,
                sessionHacking1, sessionHacking2,
                sessionHIntra1, sessionHIntra2,
                sessionDistri1, sessionDistri2,
                sessionwlan,
                sessionsysOp1, sessionsysOp2, sessionsysOp3);
        }


    }
}
