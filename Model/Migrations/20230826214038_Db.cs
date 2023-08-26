using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class Db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Building",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 8, 26, 16, 40, 37, 895, DateTimeKind.Local).AddTicks(5007)),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<int>(type: "int", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Building", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Calendar",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    period = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    periodInit = table.Column<DateTime>(type: "datetime2", nullable: false),
                    periodEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 8, 26, 16, 40, 37, 895, DateTimeKind.Local).AddTicks(8577)),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<int>(type: "int", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calendar", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    name = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: false),
                    alias = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NumHours = table.Column<int>(type: "int", nullable: false),
                    NumCredits = table.Column<int>(type: "int", nullable: false),
                    NumSemester = table.Column<int>(type: "int", nullable: false),
                    IsLab = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 8, 26, 16, 40, 37, 897, DateTimeKind.Local).AddTicks(307)),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<int>(type: "int", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    password = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    role = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    reset = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 8, 26, 16, 40, 37, 897, DateTimeKind.Local).AddTicks(3389)),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<int>(type: "int", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Classroom",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    isLab = table.Column<bool>(type: "bit", nullable: false),
                    name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    floor = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    buildingId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 8, 26, 16, 40, 37, 896, DateTimeKind.Local).AddTicks(1188)),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<int>(type: "int", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classroom", x => x.id);
                    table.ForeignKey(
                        name: "FK_Classroom_Building_buildingId",
                        column: x => x.buildingId,
                        principalTable: "Building",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Floor",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    BuildingId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Floor", x => x.id);
                    table.ForeignKey(
                        name: "FK_Floor_Building_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Building",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    subjectId = table.Column<int>(type: "int", nullable: false),
                    classroomId = table.Column<int>(type: "int", nullable: false),
                    calendarId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 8, 26, 16, 40, 37, 896, DateTimeKind.Local).AddTicks(5248)),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<int>(type: "int", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.id);
                    table.ForeignKey(
                        name: "FK_Group_Calendar_calendarId",
                        column: x => x.calendarId,
                        principalTable: "Calendar",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Group_Classroom_classroomId",
                        column: x => x.classroomId,
                        principalTable: "Classroom",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Group_Subject_subjectId",
                        column: x => x.subjectId,
                        principalTable: "Subject",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Session",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    day = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    startTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    endTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    groupId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Session", x => x.id);
                    table.ForeignKey(
                        name: "FK_Session_Group_groupId",
                        column: x => x.groupId,
                        principalTable: "Group",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Building",
                columns: new[] { "id", "code", "DeletedBy", "DeletedDate", "name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "E16", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Edificio de Eléctrica", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "E17", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Edificio de Química/Eléctrica", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Calendar",
                columns: new[] { "id", "DeletedBy", "DeletedDate", "period", "periodEnd", "periodInit", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2023A", new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, "MATD113", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ÁLGEBRA LINEAL", 3, 144, 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, null, "MATD123", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CÁLCULO EN UNA VARIABLE", 3, 144, 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, null, "FISD134", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MECÁNICA NEWTONIANA", 4, 192, 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 4, null, "FISD134L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LABORATORIO MECÁNICA NEWTONIANA", 4, 192, 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 5, null, "QUID143", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "QUÍMICA GENERAL", 3, 144, 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, null, "ICOD111", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HERRAMIENTAS INFORMÁTICAS", 1, 48, 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, null, "CSHD111", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "COMUNICACIÓN ORAL Y ESCRITA", 1, 48, 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, null, "MATD213", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ECUACIONES DIFERENCIALES ORDINARIAS", 3, 144, 2, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, null, "MATD223", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PROBABILIDAD Y ESTADÍSTICA BÁSICAS", 3, 144, 2, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, null, "IEED232", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CÁLCULO VECTORIAL", 2, 96, 2, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, null, "IEED242", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FUNDAMENTOS DE ELECTROMAGNETISMO", 2, 96, 2, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, null, "IEED252", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PROGRAMACIÓN", 2, 96, 2, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, null, "CSHD211", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ANÁLISIS SOCIOECONÓMICO Y POLÍTICO DEL ECUADOR", 1, 48, 2, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, null, "IEED272", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ELECTROTECNIA", 2, 96, 2, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 15, null, "IEED272L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LABORATORIO DE ELECTROTECNIA", 2, 96, 2, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 16, null, "IEED312", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MATEMÁTICA AVANZADA", 2, 96, 3, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, null, "IEED323", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SISTEMAS DIGITALES", 3, 144, 2, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 18, null, "IEED323L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LABORATORIO DE SISTEMAS DIGITALES", 3, 144, 2, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 19, null, "IEED333", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DISPOSITIVOS ELECTRÓNICOS", 3, 144, 3, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 20, null, "IEED333L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LABORATORIO DE DISPOSITIVOS ELECTRONICOS", 3, 144, 3, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 21, null, "IEED342", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TEORÍA ELECTROMAGNÉTICA", 2, 96, 3, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, null, "IEED353", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FUNDAMENTOS DE CIRCUITOS ELÉCTRICOS", 3, 144, 3, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 23, null, "IEED353L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LABORATORIO DE FUNDAMENTOS DE CIRCUITOS ELÉCTRICOS", 3, 144, 3, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 24, null, "IEED371", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MATEMÁTICA DISCRETA", 1, 48, 3, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, null, "IEED413", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "INSTALACIONES ELÉCTRICAS Y COMUNICACIONES", 3, 144, 4, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, null, "IEAD423", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ANÁLISIS DE SEÑALES Y SISTEMAS", 3, 144, 4, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, null, "IEED433", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CIRCUITOS ELECTRÓNICOS", 3, 144, 4, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 28, null, "IEED433L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LABORATORIO DE CIRCUITOS ELECTRÓNICOS", 3, 144, 4, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 29, null, "IELD443", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CONVERSIÓN ELECTROMECÁNICA DE ENERGÍA", 3, 144, 4, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 30, null, "IELD443L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LABORATORIO DE CONVERSIÓN ELECTROMECÁNICA DE ENERGÍA", 3, 144, 4, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 31, null, "IEED452", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ANÁLISIS DE CIRCUITOS ELÉCTRICOS", 2, 96, 4, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 32, null, "IEED452L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LABORATORIO DE ANÁLISIS DE CIRCUITOS ELÉCTRICOS", 2, 96, 4, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 33, null, "IEAD533", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ELECTRÓNICA DE POTENCIA", 3, 144, 5, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 34, null, "IEAD533L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LABORATORIO DE ELECTRÓNICA DE POTENCIA", 3, 144, 5, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 35, null, "IELD543", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MÁQUINAS ELÉCTRICAS", 3, 144, 5, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 36, null, "IELD543L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LABORATORIO DE MÁQUINAS ELÉCTRICAS", 3, 144, 5, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 37, null, "IEAD553", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SISTEMAS DE CONTROL AUTOMÁTICO", 3, 144, 5, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 38, null, "IEAD553L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LABORATORIO DE SISTEMAS DE CONTROL AUTOMÁTICO", 3, 144, 5, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 39, null, "IEAD642", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CONTROL INDUSTRIAL", 2, 96, 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 40, null, "IEAD642L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LABORATORIO DE CONTROL INDUSTRIAL", 2, 96, 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 41, null, "IELD761", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SEGURIDAD INDUSTRIAL Y PROTECCIÓN AMBIENTAL", 1, 48, 9, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42, null, "TELD423", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ANÁLISIS DE SEÑALES DISCRETAS PARA COMUNICACIONES", 3, 144, 4, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43, null, "TELD522", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TEORÍA DE LA INFORMACIÓN Y CODIFICACIÓN", 2, 96, 5, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44, null, "ITID553", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SISTEMAS EMBEBIDOS", 3, 144, 5, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 45, null, "ITID553L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LABORATORIO DE SISTEMAS EMBEBIDOS", 3, 144, 5, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 46, null, "ITID512", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SISTEMAS DE CABLEADO ESTRUCTURADO", 2, 96, 5, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47, null, "ADMD511", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GESTIÓN ORGANIZACIONAL", 1, 48, 5, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48, null, "ADMD611", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GESTIÓN DE PROCESOS Y CALIDAD", 1, 48, 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, null, "ADMD711", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "INGENIERÍA FINANCIERA", 1, 48, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, null, "TITD101", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DISEÑO DE TRABAJO DE INTEGRACIÓN CURRICULAR/ PREPARACIÓN EXAMEN DE CARÁCTER COMPLEXIVO", 1, 48, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 51, null, "TITD201", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TRABAJO DE INTEGRACIÓN CURRICULAR/EXAMEN DE CARÁCTER COMPLEXIVO", 5, 240, 9, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 52, null, "IELD512", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MODELACIÓN DE SISTEMAS ELÉCTRICOS DE POTENCIA", 2, 96, 5, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 53, null, "IELD512L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LAB. DE MODELACIÓN DE SISTEMAS ELÉCTRICOS DE POTENCIA", 2, 96, 5, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 54, null, "IELD523", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ALTO VOLTAJE", 3, 144, 5, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 55, null, "IELD523L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LAB. DE ALTO VOLTAJE", 3, 144, 5, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 56, null, "IELD613", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ESTUDIOS DE ESTADO ESTACIONARIO DE SISTEMAS ELÉCTRICOS DE POTENCIA", 3, 144, 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 57, null, "IELD613L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LAB. DE ESTUDIOS DE ESTADO ESTACIONARIO DE SISTEMAS ELÉCTRICOS DE POTENCIA", 3, 144, 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 58, null, "IELD622", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DISEÑO EN ALTO VOLTAJE", 2, 96, 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 59, null, "IELD633", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SISTEMAS ELÉCTRICOS DE DISTRIBUCIÓN", 3, 144, 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 60, null, "IELD633L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LAB. DE SISTEMAS ELÉCTRICOS DE DISTRIBUCIÓN", 3, 144, 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 61, null, "IELD643", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DINÁMICA DE MÁQUINAS ELÉCTRICAS", 3, 144, 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 62, null, "IELD643L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LAB. DE DINÁMICA DE MÁQUINAS ELÉCTRICAS", 3, 144, 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 63, null, "IELD652", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "INSTALACIONES ELÉCTRICAS DE MEDIO VOLTAJE", 2, 96, 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 64, null, "IELD713", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ESTABILIDAD DE SISTEMAS ELÉCTRICOS DE POTENCIA", 3, 144, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 65, null, "IELD713L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LAB. DE ESTABILIDAD DE SISTEMAS ELÉCTRICOS DE POTENCIA", 3, 144, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 66, null, "IELD722", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DISEÑO ELECTROMECÁNICO DE LÍNEAS DE TRANSMISIÓN", 2, 96, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 67, null, "IELD732", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CONSTRUCCIÓN DE REDES ELÉCTRICAS", 2, 96, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 68, null, "IELD742", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CENTRALES DE GENERACIÓN ELÉCTRICA", 2, 96, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 69, null, "IELD753", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "INTRODUCCIÓN A PROTECCIONES ELÉCTRICAS", 3, 144, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 70, null, "IELD753L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LAB. DE INTRODUCCIÓN A PROTECCIONES ELÉCTRICAS", 3, 144, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 71, null, "IELD772", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "OPTIMIZACIÓN DE SISTEMAS ELÉCTRICOS DE POTENCIA", 2, 96, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 72, null, "IELD813", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "OPERACIÓN Y CONTROL DE SISTEMAS ELÉCTRICOS DE POTENCIA", 2, 86, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 73, null, "IELD801", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ANÁLISIS DE SISTEMAS ELÉCTRICOS DE POTENCIA", 3, 144, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 74, null, "IELD802", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ACCIONAMIENTO DE MÁQUINAS ELÉCTRICAS", 3, 144, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 75, null, "ELD803", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "REDES ELÉCTRICAS INTELIGENTES Y GENERACIÓN DISTRIBUIDA", 3, 144, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 76, null, "IELD832", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CALIDAD DE ENERGÍA ELÉCTRICA", 2, 96, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 77, null, "IELD842", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CONFIABILIDAD DE SISTEMAS ELÉCTRICOS DE POTENCIA", 2, 96, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 78, null, "IELD852", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PLANIFICACIÓN DE SISTEMAS ELÉCTRICOS DE DISTRIBUCIÓN", 2, 96, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 79, null, "IELD901", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ANÁLISIS DE ESTABILIDAD DE PEQUEÑA SEÑAL DE SISTEMAS", 2, 96, 9, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 80, null, "ELD902", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "INTEGRACIÓN DE ENERGÍAS RENOVABLES A SISTEMAS ELÉCTRICOS DE POTENCIA", 2, 96, 9, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 81, null, "ELD903", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SISTEMA DE GESTIÓN DE REDES ELÉCTRICAS DE DISTRIBUCIÓN", 2, 96, 9, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 82, null, "IEAD513", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SENSORES Y TRANSDUCTORES", 3, 144, 5, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 83, null, "IEAD513L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LAB. DE SENSORES Y TRANSDUCTORES", 3, 144, 5, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 84, null, "IEAD522", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SISTEMAS MICROPROCESADOS", 2, 96, 5, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 85, null, "IEAD522L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LAB. DE SISTEMAS MICROPROCESADOS", 2, 96, 5, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 86, null, "IEAD613", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "INSTRUMENTACIÓN INDUSTRIAL", 3, 144, 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 87, null, "IEAD613L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LAB. DE INSTRUMENTACIÓN INDUSTRIAL", 3, 144, 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 88, null, "IEAD623", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CONTROL EMBEBIDO", 3, 144, 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 89, null, "IEAD623L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LAB. DE CONTROL EMBEBIDO", 3, 144, 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 90, null, "IEAD633", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CONVERSORES ESTÁTICOS", 3, 144, 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 91, null, "IEAD633L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LAB. DE CONVERSORES ESTÁTICOS", 3, 144, 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 92, null, "IEAD653", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SISTEMAS DE CONTROL DISCRETO", 3, 144, 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 93, null, "IEAD653L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LAB. DE SISTEMAS DE CONTROL DISCRETO", 3, 144, 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 94, null, "IEAD713", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "REDES INDUSTRIALES", 3, 144, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 95, null, "IEAD713L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LAB. DE REDES INDUSTRIALES", 3, 144, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 96, null, "IEAD722", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "INSTALACIONES ELÉCTRICAS INDUSTRIALES", 2, 96, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 97, null, "IEAD733", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ACCIONAMIENTOS ELECTRÓNICOS", 3, 144, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 98, null, "IEAD733L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LAB. DE ACCIONAMIENTOS ELECTRÓNICOS", 3, 144, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 99, null, "IEAD743", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AUTOMATIZACIÓN USANDO PLCs", 3, 144, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 100, null, "IEAD743L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LAB. DE AUTOMATIZACIÓN USANDO PLCs", 3, 144, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 101, null, "IEAD753", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CONTROL DE PROCESOS INDUSTRIALES", 3, 144, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 102, null, "IEAD753L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LAB. DE CONTROL DE PROCESOS INDUSTRIALES", 3, 144, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 103, null, "IEAD801", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SÍNTESIS DE PLANTAS INDUSTRIALES", 3, 144, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 104, null, "IEAD802", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "INSTRUMENTACIÓN BIOMÉDICA", 3, 144, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 105, null, "IEAD803", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FUNDAMENTOS DE SISTEMAS ELÉCTRICOS DE POTENCIA", 3, 144, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 106, null, "IEAD823", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SISTEMAS SCADA", 3, 144, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 107, null, "IEAD823L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LAB. DE SISTEMAS SCADA", 3, 144, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 108, null, "IEAD833", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MANDOS NEUMÁTICOS", 3, 144, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 109, null, "IEAD833L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LAB. DE MANDOS NEUMÁTICOS", 3, 144, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 110, null, "IEAD842", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ROBÓTICA", 2, 96, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 111, null, "IEAD842L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LAB. DE ROBÓTICA", 2, 96, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 112, null, "IEAD853", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "INTRODUCCIÓN A CONTROL MULTIVARIABLE", 3, 144, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 113, null, "IEAD901", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "INTRODUCCIÓN A INDUSTRIA 4.0", 2, 96, 9, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 114, null, "IEAD902", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VISIÓN ARTIFICIAL", 2, 96, 9, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 115, null, "IEAD903", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ENERGÍAS RENOVABLES Y REDES INTELIGENTES", 2, 96, 9, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 116, null, "TELD452", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SISTEMA OPERATIVO LINUX", 2, 96, 4, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 117, null, "TELD513", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FUNDAMENTOS DE COMUNICACIONES", 3, 144, 5, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 118, null, "TELD513L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LAB. DE FUNDAMENTOS DE COMUNICACIONES", 3, 144, 5, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 119, null, "TELD532", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PROCESAMIENTO DIGITAL DE SEÑALES", 2, 96, 5, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 120, null, "TELD553", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SISTEMAS DE TRANSMISIÓN", 3, 144, 5, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 121, null, "TELD553L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LAB. DE SISTEMAS DE TRANSMISIÓN", 3, 144, 5, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 122, null, "TELD613", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "COMUNICACIÓN DIGITAL", 3, 144, 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 123, null, "TELD613L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LAB. DE COMUNICACIÓN DIGITAL", 3, 144, 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 124, null, "TELD623", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TELEMÁTICA BÁSICA", 3, 144, 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 125, null, "TELD623L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LAB. DE TELEMÁTICA BÁSICA", 3, 144, 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 126, null, "TELD633", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ELECTRÓNICA DE RADIOFRECUENCIA", 3, 144, 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 127, null, "TELD633L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LAB. DE ELECTRÓNICA DE RADIOFRECUENCIA", 3, 144, 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 128, null, "TELD642", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "APLICACIONES CON SISTEMAS EMBEBIDOS", 2, 96, 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 129, null, "TELD642L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LAB. DE APLICACIONES CON SISTEMAS EMBEBIDOS", 2, 96, 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 130, null, "TELD654", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PROPAGACIÓN Y ANTENAS", 3, 144, 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 131, null, "TELD654L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LAB. DE PROPAGACIÓN Y ANTENAS", 3, 144, 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 132, null, "TELD713", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "COMUNICACIONES ÓPTICAS", 3, 144, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 133, null, "TELD713L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LAB. DE COMUNICACIONES ÓPTICAS", 3, 144, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 134, null, "TELD723", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TELEMÁTICA AVANZADA", 3, 144, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 135, null, "TELD723L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LAB. DE TELEMÁTICA AVANZADA", 3, 144, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 136, null, "TELD733", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "COMUNICACIONES INALÁMBRICAS", 3, 144, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 137, null, "TELD733L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LAB. DE COMUNICACIONES INALÁMBRICAS", 3, 144, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 138, null, "TELD743", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TELEFONÍA IP", 3, 144, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 139, null, "TELD752", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "INGENIERÍA DE MICROONDAS", 2, 96, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 140, null, "TELD801", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "COMPONENTES PASIVOS DE RADIOFRECUENCIA", 2, 96, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 141, null, "TELD802", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TÉCNICAS AVANZADAS DE PROCESAMIENTO DIGITAL DE SEÑALES", 2, 96, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 142, null, "TELD803", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CONMUTACIÓN Y ENRUTAMIENTO AVANZADO", 2, 96, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 143, null, "TELD823", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "REDES ÓPTICAS", 3, 144, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 144, null, "TELD823L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LAB. DE REDES ÓPTICAS", 3, 144, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 145, null, "TELD833", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "INTRODUCCIÓN A DISEÑO DE REDES", 3, 144, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 146, null, "TELD843", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SISTEMAS CELULARES", 3, 144, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 147, null, "TELD852", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FUNDAMENTOS DE SEGURIDAD", 2, 96, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 148, null, "TELD852L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LAB. DE FUNDAMENTOS DE SEGURIDAD", 2, 96, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 149, null, "TELD901", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "COMPONENTES ACTIVOS DE RADIOFRECUENCIA", 2, 96, 9, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 150, null, "TELD902", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TÉCNICAS AVANZADAS DE CLASIFICACIÓN DE SEÑALES", 2, 96, 9, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 151, null, "TELD903", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TECNOLOGÍAS AVANZADAS DE REDES DE DATOS", 2, 96, 9, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 152, null, "TELD941", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MARCO REGULATORIO DE LOS SERVICIOS DE TELECOMUNICACIONES", 1, 48, 9, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 153, null, "ITID443", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BASES DE DATOS", 3, 144, 4, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 154, null, "ITID452", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SISTEMAS OPERATIVOS", 2, 96, 4, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 155, null, "ITID524", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TRANSMISIÓN DIGITAL", 4, 192, 5, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 156, null, "ITID524L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LAB. DE TRANSMISIÓN DIGITAL", 4, 192, 5, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 157, null, "ITID543", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DISEÑO Y PROGRAMACIÓN DE SOFTWARE", 3, 144, 5, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 158, null, "ITID612", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CABLEADO ESTRUCTURADO AVANZADO", 2, 96, 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 159, null, "ITID623", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "REDES DE ÁREA LOCAL", 3, 144, 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 160, null, "ITID623L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LAB. DE REDES DE ÁREA LOCAL", 3, 144, 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 161, null, "ITID633", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ENRUTAMIENTO", 3, 144, 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 162, null, "ITID633L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LAB. DE ENRUTAMIENTO", 3, 144, 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 163, null, "ITID643", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SISTEMAS INALÁMBRICOS", 3, 144, 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 164, null, "ITID653", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ALMACENAMIENTO Y PROCESAMIENTO DE DATOS", 3, 144, 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 165, null, "ITID713", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "APLICACIONES DISTRIBUIDAS", 3, 144, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 166, null, "ITID723", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "REDES DE ÁREA EXTENDIDA", 3, 144, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 167, null, "ITID723L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LAB. DE REDES DE ÁREA EXTENDIDA", 3, 144, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 168, null, "ITID733", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SEGURIDAD EN REDES", 3, 144, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 169, null, "ITID742", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "REDES E INTRANETS", 2, 96, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 170, null, "ITID753", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "APLICACIONES WEB Y MÓVILES", 3, 144, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 171, null, "ITID801", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HACKING ÉTICO", 2, 96, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 172, null, "ITID802", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "COMUNICACIONES UNIFICADAS", 2, 96, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 173, null, "ITID803", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DISEÑO DE APLICACIONES Y SERVICIOS DE INTERNET", 2, 96, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 174, null, "ITID822", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EVALUACIÓN DE REDES", 2, 96, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 175, null, "ITID832", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "REDES DE ÁREA LOCAL INALÁMBRICAS", 2, 96, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 176, null, "ITID843", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ADMINISTRACIÓN DE REDES", 3, 144, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 177, null, "ITID853", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MINERÍA DE DATOS", 3, 144, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 178, null, "ITID862", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SISTEMAS IoT", 2, 96, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 179, null, "ITID901", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ADMINISTRACIÓN DE PROCESOS Y SERVICIOS DE TI", 2, 96, 9, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 180, null, "ITID902", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "REDES DEFINIDAS POR SOFTWARE", 2, 96, 9, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 181, null, "ITID903", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "APLICACIONES MÓVILES AVANZADAS", 2, 96, 9, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 182, null, "AMBD900", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ECOLOGIA Y AMBIENTE", 0, 0, 5, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 183, null, "ADMD700", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EMPRENDIMIENTO", 0, 0, 5, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 184, null, "ADMD800", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FORMULACION Y EVALUACION DE PROYECTOS", 0, 0, 5, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 185, null, "IEED210", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "METODOLOGIAS DE ESTUDIO", 0, 0, 5, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 186, null, "ITID433", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PROGRAMACION AVANZADA", 3, 144, 4, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 187, null, "IELD941", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PROTECCIONES ELÉCTRICAS", 1, 48, 9, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 188, null, "IELD903", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SISTEMAS DE GESTIÓN EN REDES ELÉCTRICAS DE DISTRIBUCIÓN", 2, 96, 9, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 189, null, "TELD752L", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "LAB. INGENIERIA DE MICROONDAS", 2, 96, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "alias", "code", "DeletedBy", "DeletedDate", "name", "NumCredits", "NumHours", "NumSemester", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 190, null, "ITID941", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "REGULACION DE LAS TECNOLOGIAS DE LA INFORMACION Y LA COMUNICACION", 1, 48, 9, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 191, null, "IELD803", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "REDES ELÉCTRICAS INTELIGENTES Y GENERACIÓN DISTRIBUIDA", 3, 144, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 192, null, "SOCD210", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLUBES", 0, 0, 5, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "id", "DeletedBy", "DeletedDate", "email", "name", "password", "role", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", "Admin", "$2a$11$Cw498tXYPwBDhMiXkUxWr.3ehk83i9Jev.sdLpvizAIZJQ.VKmApO", "Admin", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Classroom",
                columns: new[] { "id", "buildingId", "Capacity", "code", "DeletedBy", "DeletedDate", "floor", "isLab", "name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, 12, "E006A", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P1", true, "LAB. CIRCUITOS ELECTRICOS A", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, 12, "E006B", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P1", true, "LAB. CIRCUITOS ELECTRICOS B", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, 12, "E007A", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P1", true, "LAB. CIRCUITOS ELECTRICOS C", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, 12, "E007B", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P1", true, "LAB. CIRCUITOS ELECTRICOS D", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 1, 16, "E008", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P1", true, "LAB. CIRCUITOS ELECTRICOS", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 1, 20, "E013", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P1", true, "LAB. ALTA FRECUENCIA", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 1, 12, "E018", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P1", true, "LAB. DISPOSITIVOS ELECTRONICOS", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 1, 12, "E019", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P1", true, "LAB. DISPOSITIVOS ELECTRONICOS", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 1, 4, "E020", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P1", true, "LAB.COMUNICACION ANALOGICA", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 1, 50, "E021", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P1", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 1, 8, "E001", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P2", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 1, 16, "E002", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P2", true, "LAB. REDES 2", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 1, 18, "E002", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P2", true, "LAB. REDES 1", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 1, 10, "E004", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P2", true, "LAB. SISTEMAS DIGITALES A", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 1, 4, "E005", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P2", true, "LAB. SISTEMAS DIGITALES B", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 1, 25, "E006", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P2", true, "LAB. SISTEMAS DIGITALES", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 1, 20, "E012", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P2", true, "LAB. CONECTIVIDAD DE REDES", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 1, 30, "E013", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P2", true, "LAB. DE SISTEMAS DE CONTROL", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 1, 25, "E014", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P2", true, "LAB. DE SISTEMAS MICROPROCESADOS", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, 1, 6, "E015", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P2", true, "LAB. INVEST. EN CONTROL CON MICROPROCESADORES", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 1, 200, "E020", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P2", true, "AULA MAGNA ELECTRICA", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 1, 10, "E002", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB", true, "LAB. CONTROL INDUSTRIAL", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, 1, 6, "E003", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB", true, "LAB. AUTOMATIZACION USANDO PLCS", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, 1, 9, "E007", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB", true, "LAB. ELECTRONICA DE POTENCIA", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, 1, 12, "E008", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB", true, "LAB. CONTROL MAQUINAS", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, 1, 11, "E026", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB", true, "LAB. DE PROTECCIONES ELECTRICAS (LABPE)", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, 1, 20, "E001", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "S1", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, 1, 50, "E004", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "S1", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, 1, 42, "E005", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "S1", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, 1, 50, "E011", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "S1", true, "LAB. MAQUINAS ELECTRICAS", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, 1, 11, "E012A", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "S1", true, "LAB. DE SISTEMAS ELÉCTRICOS DE POTENCIA", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, 1, 9, "E012B", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "S1", true, "LAB. DE DISTRIBUCIÓN", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, 1, 25, "E017", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "S1", true, "LAB. ALTO VOLTAJE", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, 2, 22, "E002", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MZ", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, 2, 4, "E004", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MZ", true, "LAB. DE MANDOS NEUMATICOS", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, 2, 22, "E001", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P1", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, 2, 12, "E002", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P1", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, 2, 12, "E003", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P1", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, 2, 12, "E004", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P1", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, 2, 12, "E006", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P1", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41, 2, 12, "E007", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P1", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42, 2, 12, "E008", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P1", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43, 2, 12, "E009", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P1", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44, 2, 12, "E010", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P1", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45, 2, 12, "E011", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P1", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46, 2, 12, "E012", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P1", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47, 2, 12, "E013", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P1", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48, 2, 12, "E014", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P1", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, 2, 196, "E019", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P", true, "AULA MAGNA QUIMICA", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, 2, 15, "E004", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P2", true, "LAB. INVEST. PROCESOS", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 51, 2, 29, "E005", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P2", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 52, 2, 23, "E009", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P2", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 53, 2, 56, "E021", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P2", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 54, 2, 54, "E022", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P2", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 55, 2, 50, "E023", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P2", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 56, 2, 40, "E030", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P2", true, "LAB. DE COMPUTACION", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 57, 2, 41, "E001", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P3", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 58, 2, 50, "E002", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P3", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 59, 2, 29, "E014", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P3", true, "LAB. COMPUTACION QUIMICA", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 60, 2, 29, "E016", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P3", true, "LAB. CENTRO COMPUTO AGROIND", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 61, 2, 56, "E021", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P3", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 62, 2, 54, "E022", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P3", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 63, 2, 50, "E023", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P3", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 64, 2, 20, "E004", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P4", true, "LAB. TERMODINAMICA", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 65, 2, 20, "E005", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P4", true, "LAB. TERMODINAMICA", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 66, 2, 20, "E006", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P4", true, "LAB. TERMODINAMICA", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 67, 2, 20, "E007", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P4", true, "LAB. TERMODINAMICA", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 68, 2, 20, "E008", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P4", true, "LAB. TERMODINAMICA", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 69, 2, 19, "E009", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P4", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 70, 2, 25, "E013", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P4", true, "LAB. FISICO-QUIMICA", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 71, 2, 48, "E020", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P4", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 72, 2, 48, "E021", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P4", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 73, 2, 48, "E022", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P4", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 74, 2, 48, "E023", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P4", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 75, 2, 48, "E001", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P5", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 76, 2, 48, "E010", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P5", true, "Lab. Petroleos", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 77, 2, 48, "E020", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P5", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 78, 2, 50, "E027", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P5", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 79, 2, 48, "E028", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P5", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 80, 2, 48, "E029", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P5", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 81, 2, 8, "E002", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P6", true, "LAB. DE SENSORES Y TRANSDUCTORES", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 82, 2, 6, "E003", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P6", true, "LAB. INSTRUMENTACIÓN INDUSTRIAL", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 83, 2, 6, "E004", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P6", true, "LAB. DE SCADA", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 84, 2, 20, "E022", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P6", true, "LAB. SALA E", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 85, 2, 20, "E023", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P6", true, "LAB. SALA D", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 86, 2, 20, "E026", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P6", true, "LAB. SALA C", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 87, 2, 20, "E027", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P6", true, "LAB. SALA B", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 88, 2, 20, "E028", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P6", true, "LAB. SALA A", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 89, 2, 8, "E001", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P7", true, "LAB. COMUNICACIONES INALÁMBRICAS", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 90, 2, 6, "E002", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P7", true, "LAB. SISTEMAS DE TRANSMISIÓN", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 91, 2, 20, "E003", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P8", true, "LAB. SOFTWARE DEFINIDO POR RADIO", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 92, 2, 30, "E004", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P7", true, "LAB. INTERCONECTIVIDAD", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 93, 2, 18, "E005", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P7", true, "LAB. COMUNICACIONES UNIFICADAS", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 94, 2, 8, "E006", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P7", true, "LAB. REDES INDUSTRIALES Y SCADA", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 95, 2, 8, "E008", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P7", true, "LAB. DE INVEST. EN REDES Y SISTEMAS DISTRI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 96, 2, 6, "E014", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P7", true, "LAB. INVES. Y SIMULACION DE TELECOM", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 97, 2, 6, "E015", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P7", true, "LAB. COMUNICACIONES OPTICAS", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 98, 2, 30, "E024", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P7", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 99, 2, 32, "E025", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P7", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 100, 2, 38, "E026", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P7", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 101, 2, 6, "E002", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P8", true, "LABORATORIO DE ANTENAS", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 102, 2, 30, "E001", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 103, 2, 18, "E014", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 104, 2, 55, "E020", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 105, 2, 10, "E023", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB", true, "LAB. CONTROL DE PROCESOS", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Floor",
                columns: new[] { "id", "BuildingId", "code" },
                values: new object[,]
                {
                    { 1, 1, "S1" },
                    { 2, 1, "PB" },
                    { 3, 1, "P1" },
                    { 4, 1, "P2" },
                    { 5, 2, "PB" },
                    { 6, 2, "MZ" },
                    { 7, 2, "P3" },
                    { 8, 2, "P4" },
                    { 9, 2, "P5" },
                    { 10, 2, "P6" },
                    { 11, 2, "P7" },
                    { 12, 2, "P8" }
                });

            migrationBuilder.InsertData(
                table: "Group",
                columns: new[] { "id", "calendarId", "classroomId", "DeletedBy", "DeletedDate", "name", "subjectId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, 34, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 111, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, 34, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 111, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, 34, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3", 111, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, 35, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 109, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 1, 35, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 109, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 1, 35, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3", 109, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 1, 35, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR4", 109, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 1, 33, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 55, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 1, 33, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 55, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 1, 33, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3", 55, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 1, 32, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 65, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 1, 32, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 65, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 1, 32, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 60, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 1, 32, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 60, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 1, 32, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3", 60, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 1, 32, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR4", 60, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 1, 32, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR5", 60, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 1, 32, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR6", 60, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 1, 31, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 62, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, 1, 31, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 62, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 1, 31, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3", 62, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 1, 31, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR4", 62, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, 1, 31, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3", 65, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, 1, 31, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR4", 65, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, 1, 31, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR6", 65, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, 1, 31, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-1", 57, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, 1, 30, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-1", 30, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, 1, 30, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-2", 30, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, 1, 30, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-3", 30, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, 1, 30, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-4", 30, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, 1, 30, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2-1", 30, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, 1, 30, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2-2", 30, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, 1, 30, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2-3", 30, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, 1, 30, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2-4", 30, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, 1, 30, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-1", 36, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, 1, 30, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-2", 36, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, 1, 30, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-3", 36, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, 1, 30, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-4", 36, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, 1, 30, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2-1", 36, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, 1, 30, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2-2", 36, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41, 1, 30, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2-3", 36, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42, 1, 30, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2-4", 36, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43, 1, 29, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 184, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44, 1, 29, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 99, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48, 1, 29, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 37, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, 1, 29, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 56, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 52, 1, 29, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 59, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 54, 1, 29, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 146, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 56, 1, 28, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 10, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 58, 1, 28, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3", 14, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 60, 1, 28, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 46, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 62, 1, 28, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 66, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 64, 1, 28, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 64, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 66, 1, 27, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 136, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 68, 1, 26, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 70, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 69, 1, 26, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 70, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 70, 1, 26, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR4", 70, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 71, 1, 26, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR5", 70, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 72, 1, 25, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 98, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 73, 1, 25, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 98, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 74, 1, 25, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3", 98, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 75, 1, 25, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR4", 98, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 76, 1, 24, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-1", 91, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 77, 1, 24, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-2", 91, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 78, 1, 24, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-3", 91, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 79, 1, 24, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-4", 91, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 80, 1, 24, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2-1", 91, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 81, 1, 24, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2-2", 91, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 82, 1, 24, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2-3", 91, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 83, 1, 24, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-1", 34, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 84, 1, 24, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-2", 34, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 85, 1, 24, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-3", 34, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 86, 1, 24, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-5", 34, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 87, 1, 24, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2-1", 34, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 88, 1, 24, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2-2", 34, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 89, 1, 24, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2-3", 34, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 90, 1, 24, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2-4", 34, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 91, 1, 24, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2-5", 34, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 92, 1, 24, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3-1", 34, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 93, 1, 24, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3-2", 34, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 94, 1, 24, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3-3", 34, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 95, 1, 24, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3-4", 34, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 96, 1, 24, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3-5", 34, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 97, 1, 23, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 100, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 98, 1, 23, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3", 100, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 99, 1, 23, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR5", 100, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 100, 1, 23, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR6", 51, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 101, 1, 22, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-1", 40, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 102, 1, 22, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-2", 40, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 103, 1, 22, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-3", 40, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 104, 1, 22, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2-2", 40, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 105, 1, 22, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2-3", 40, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 106, 1, 22, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2-4", 40, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 107, 1, 21, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR4", 2, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 109, 1, 21, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-GP", 3, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 111, 1, 20, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3", 51, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 113, 1, 20, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR9", 51, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 115, 1, 19, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-1", 89, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 116, 1, 19, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-2", 89, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 117, 1, 19, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-3", 89, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 118, 1, 19, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2-1", 89, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 119, 1, 19, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2-2", 89, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 120, 1, 19, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2-3", 89, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 121, 1, 19, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-1", 85, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 122, 1, 19, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-2", 85, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 123, 1, 19, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-3", 85, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 124, 1, 19, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-4", 85, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 125, 1, 19, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-5", 85, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 126, 1, 19, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-6", 85, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 127, 1, 19, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 88, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 129, 1, 18, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-2", 38, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 130, 1, 18, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-3", 38, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 131, 1, 18, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-4", 38, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 132, 1, 18, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2-1", 38, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 133, 1, 18, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2-2", 38, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 134, 1, 18, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2-3", 38, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 135, 1, 18, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-1", 93, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 136, 1, 18, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-2", 93, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 137, 1, 18, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-3", 93, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 138, 1, 18, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-4", 93, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 139, 1, 18, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-5", 93, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 140, 1, 18, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 108, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 141, 1, 18, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 110, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 142, 1, 18, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 88, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 143, 1, 85, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 151, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 145, 1, 85, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 176, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 148, 1, 85, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 12, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 151, 1, 85, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR6", 12, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 154, 1, 85, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 186, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 157, 1, 87, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR11", 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 159, 1, 87, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 161, 1, 87, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 167, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 163, 1, 87, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR11", 12, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 166, 1, 87, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR5", 12, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 169, 1, 87, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 177, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 172, 1, 82, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR7", 51, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 175, 1, 81, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-1", 83, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 178, 1, 81, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-2", 83, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 179, 1, 81, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-3", 83, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 180, 1, 81, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-4", 83, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 181, 1, 81, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-5", 83, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 182, 1, 81, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-6", 83, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 183, 1, 81, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-7", 83, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 184, 1, 80, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3", 10, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 185, 1, 80, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 188, 1, 80, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 14, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 189, 1, 80, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR5", 22, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 190, 1, 80, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 68, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 191, 1, 80, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 68, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 192, 1, 80, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 187, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 193, 1, 80, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 10, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 194, 1, 79, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR6", 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 195, 1, 79, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-GP", 2, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 196, 1, 79, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR6", 2, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 197, 1, 79, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 198, 1, 79, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 14, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 199, 1, 79, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR4", 14, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 200, 1, 79, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR6", 3, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 201, 1, 79, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2-GP", 9, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 202, 1, 79, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR6", 5, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 203, 1, 79, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 27, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 204, 1, 77, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 25, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 205, 1, 77, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 44, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 206, 1, 77, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3", 26, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 207, 1, 77, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 90, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 208, 1, 77, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 86, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 209, 1, 77, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 49, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 210, 1, 77, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 61, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 211, 1, 77, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 69, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 212, 1, 74, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 10, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 213, 1, 74, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 182, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 214, 1, 74, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 101, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 215, 1, 74, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 19, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 216, 1, 74, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3", 19, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 217, 1, 74, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 22, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 218, 1, 74, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR4", 16, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 219, 1, 74, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR4", 17, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 220, 1, 74, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 126, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 221, 1, 74, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 130, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 222, 1, 73, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 26, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 223, 1, 73, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 33, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 224, 1, 73, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 92, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 225, 1, 73, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 21, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 226, 1, 73, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3", 21, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 227, 1, 73, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 19, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 228, 1, 73, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR4", 19, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 229, 1, 73, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 47, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 230, 1, 73, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3", 49, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 231, 1, 73, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 31, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 232, 1, 73, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 31, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 233, 1, 73, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 72, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 234, 1, 72, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 47, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 235, 1, 72, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3", 185, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 236, 1, 72, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR4", 21, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 237, 1, 72, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 26, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 238, 1, 72, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 35, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 239, 1, 72, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 37, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 240, 1, 72, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-GP", 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 241, 1, 72, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 63, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 243, 1, 71, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 33, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 244, 1, 71, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3", 33, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 245, 1, 71, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 35, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 246, 1, 71, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 41, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 247, 1, 71, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 25, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 248, 1, 71, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 82, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 249, 1, 71, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 117, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 250, 1, 71, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 120, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 255, 1, 71, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 84, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 256, 1, 71, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 67, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 257, 1, 71, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 152, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 258, 1, 71, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 48, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 259, 1, 71, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3", 48, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 260, 1, 71, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3", 156, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 261, 1, 62, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 183, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 262, 1, 62, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 24, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 263, 1, 62, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 61, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 264, 1, 62, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 72, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 265, 1, 62, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 155, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 266, 1, 62, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR4", 27, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 267, 1, 62, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 77, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 268, 1, 62, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3", 22, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 269, 1, 62, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 11, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 270, 1, 62, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3", 11, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 271, 1, 62, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3", 16, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 283, 1, 61, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR5", 19, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 284, 1, 61, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 22, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 285, 1, 61, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR4", 22, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 286, 1, 61, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR4", 11, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 287, 1, 61, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 16, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 288, 1, 61, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 17, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 289, 1, 61, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3", 17, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 290, 1, 61, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 29, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 291, 1, 61, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 182, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 292, 1, 61, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 183, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 293, 1, 61, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3", 183, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 294, 1, 61, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR4", 47, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 295, 1, 61, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3", 24, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 296, 1, 61, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 97, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 297, 1, 63, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 49, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 298, 1, 63, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 24, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 299, 1, 63, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 185, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 300, 1, 63, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 128, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 301, 1, 63, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR5", 14, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 302, 1, 63, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3", 184, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 303, 1, 63, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 11, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 304, 1, 63, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 16, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 305, 1, 63, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 27, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 306, 1, 63, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3", 27, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 307, 1, 63, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 29, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 308, 1, 63, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 58, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 309, 1, 63, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 188, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 501, 1, 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-1", 15, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 502, 1, 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-2", 15, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 503, 1, 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-3", 15, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 504, 1, 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-4", 15, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 505, 1, 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3-1", 15, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 506, 1, 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3-3", 15, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 507, 1, 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3-4", 15, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 508, 1, 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3-5", 15, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 509, 1, 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR5-2", 15, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 510, 1, 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR5-3", 15, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 511, 1, 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR5-4", 15, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 512, 1, 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR5-5", 15, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 513, 1, 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-5", 23, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 514, 1, 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR4-2", 23, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 515, 1, 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR4-4", 23, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 516, 1, 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR5-1", 23, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 517, 1, 2, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2-1", 15, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 518, 1, 2, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2-2", 15, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 519, 1, 2, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2-3", 15, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 520, 1, 2, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2-5", 15, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 521, 1, 2, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR4-5", 23, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 522, 1, 3, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-1", 23, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 523, 1, 3, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-4", 23, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 524, 1, 3, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2-3", 23, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 525, 1, 3, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3-1", 23, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 526, 1, 3, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3-2", 23, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 527, 1, 3, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3-3", 23, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 528, 1, 3, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR4-3", 23, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 529, 1, 3, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR5-2", 23, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 530, 1, 3, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR5-3", 23, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 531, 1, 3, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-1", 32, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 532, 1, 3, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-2", 32, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 533, 1, 3, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-3", 32, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 534, 1, 3, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-4", 32, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 535, 1, 3, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2-2", 32, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 536, 1, 3, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2-3", 32, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 537, 1, 3, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2-4", 32, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 538, 1, 4, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-3", 23, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 539, 1, 4, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2-2", 23, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 540, 1, 4, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2-4", 23, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 541, 1, 4, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3-4", 23, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 542, 1, 4, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR5-4", 23, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 543, 1, 4, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3", 50, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 544, 1, 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 127, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 545, 1, 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 127, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 546, 1, 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3", 127, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 547, 1, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-3", 20, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 548, 1, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-4", 20, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 549, 1, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-5", 20, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 550, 1, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3-1", 20, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 551, 1, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3-3", 20, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 552, 1, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3-4", 20, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 553, 1, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-2", 28, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 554, 1, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-3", 28, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 555, 1, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-4", 28, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 556, 1, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3-2", 28, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 557, 1, 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3-4", 28, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 558, 1, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2-1", 20, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 559, 1, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2-3", 20, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 560, 1, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2-4", 20, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 561, 1, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR4-1", 20, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 562, 1, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR4-2", 20, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 563, 1, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR4-3", 20, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 564, 1, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR5-1", 20, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 565, 1, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR5-2", 20, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 566, 1, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR5-3", 20, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 567, 1, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2-2", 28, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 568, 1, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2-4", 28, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 569, 1, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR4-1", 28, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 570, 1, 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR4-4", 28, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 571, 1, 9, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2-3", 28, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 572, 1, 9, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3-1", 28, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 573, 1, 9, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR4-2", 28, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 574, 1, 9, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR4-3", 28, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 575, 1, 10, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 179, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 576, 1, 10, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 158, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 577, 1, 10, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 161, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 578, 1, 10, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 190, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 579, 1, 10, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 21, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 580, 1, 10, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 39, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 581, 1, 10, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 54, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 582, 1, 10, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 73, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 583, 1, 10, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 147, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 584, 1, 10, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 124, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 585, 1, 11, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 156, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 586, 1, 11, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 156, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 587, 1, 11, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3", 156, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 588, 1, 11, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 123, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 589, 1, 11, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 123, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 590, 1, 11, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 118, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 591, 1, 11, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 118, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 592, 1, 11, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3", 118, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 593, 1, 12, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 165, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 594, 1, 12, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 153, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 595, 1, 12, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 160, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 596, 1, 12, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 175, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 597, 1, 12, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 169, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 598, 1, 12, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 168, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 599, 1, 12, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 154, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 600, 1, 13, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 159, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 601, 1, 13, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 175, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 602, 1, 13, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 168, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 603, 1, 13, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 163, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 604, 1, 14, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-1", 18, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 605, 1, 14, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-2", 18, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 606, 1, 14, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-3", 18, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 607, 1, 14, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-4", 18, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 608, 1, 14, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3-1", 18, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 609, 1, 14, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3-2", 18, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 610, 1, 14, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3-3", 18, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 611, 1, 14, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3-4", 18, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 612, 1, 14, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR4-1", 18, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 613, 1, 14, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR4-2", 18, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 614, 1, 14, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR4-3", 18, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 615, 1, 14, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR4-4", 18, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 616, 1, 78, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3", 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 617, 1, 78, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR4", 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 618, 1, 78, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3", 2, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 619, 1, 78, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 184, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 620, 1, 78, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR4", 48, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 621, 1, 78, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3", 3, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 622, 1, 78, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR4", 3, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 623, 1, 78, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 9, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 624, 1, 78, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3", 5, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 625, 1, 78, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR4", 5, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 626, 1, 78, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 39, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 627, 1, 89, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-2", 45, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 628, 1, 89, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-3", 45, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 629, 1, 89, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-4", 45, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 630, 1, 89, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-5", 45, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 631, 1, 89, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 129, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 632, 1, 89, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 129, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 633, 1, 89, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 137, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 634, 1, 89, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 137, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 635, 1, 89, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3", 137, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 636, 1, 90, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 140, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 637, 1, 90, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 189, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 638, 1, 90, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 189, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 639, 1, 90, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3", 189, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 640, 1, 90, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR4", 189, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 641, 1, 90, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 121, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 642, 1, 90, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 121, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 643, 1, 90, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3", 121, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 644, 1, 90, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR4", 121, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 645, 1, 90, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR5", 121, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 646, 1, 94, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 95, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 647, 1, 94, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3", 95, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 648, 1, 94, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR4", 95, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 649, 1, 94, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR5", 95, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 650, 1, 94, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR7", 95, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 651, 1, 94, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 107, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 652, 1, 94, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 107, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 653, 1, 94, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3", 107, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 654, 1, 94, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR4", 107, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 655, 1, 94, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR5", 107, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 656, 1, 104, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 657, 1, 104, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 658, 1, 104, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 2, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 659, 1, 104, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 2, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 660, 1, 104, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 3, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 661, 1, 104, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 3, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 662, 1, 104, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 5, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 663, 1, 104, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 5, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 664, 1, 83, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-1", 87, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 665, 1, 83, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-2", 87, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 666, 1, 83, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-3", 87, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 667, 1, 83, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-4", 87, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 668, 1, 83, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1-5", 87, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 669, 1, 83, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 51, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 670, 1, 84, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 42, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 677, 1, 84, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR10", 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 678, 1, 84, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR4", 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 679, 1, 84, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR7", 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 680, 1, 84, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 167, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 681, 1, 84, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR4", 12, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 682, 1, 84, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 119, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 683, 1, 84, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 125, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 684, 1, 84, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 125, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 685, 1, 86, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 171, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 686, 1, 86, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 687, 1, 86, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR8", 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 688, 1, 86, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR10", 12, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 689, 1, 86, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 112, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 690, 1, 86, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 142, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 691, 1, 86, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 116, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 692, 1, 86, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 116, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 693, 1, 92, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 164, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 694, 1, 92, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 170, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 695, 1, 92, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AY", 192, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 696, 1, 92, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 157, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 697, 1, 92, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 162, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 698, 1, 92, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 186, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 699, 1, 99, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 90, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 700, 1, 99, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 96, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 701, 1, 99, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 94, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 702, 1, 99, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 74, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 703, 1, 99, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 76, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 704, 1, 99, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 191, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 705, 1, 99, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 138, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 706, 1, 99, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 134, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 707, 1, 100, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 166, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 708, 1, 100, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 43, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 709, 1, 100, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 78, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 710, 1, 100, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 122, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 711, 1, 100, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 145, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 712, 1, 100, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 143, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 713, 1, 88, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 135, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 714, 1, 96, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 50, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 715, 1, 97, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 133, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 716, 1, 97, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3", 133, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 717, 1, 97, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 144, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 718, 1, 97, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3", 144, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 719, 1, 97, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR4", 144, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 720, 1, 98, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 174, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 721, 1, 98, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 106, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 722, 1, 98, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 191, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 723, 1, 98, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 132, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 724, 1, 98, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 139, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 725, 1, 101, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 131, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 726, 1, 101, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 131, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 727, 1, 101, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3", 131, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 728, 1, 101, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR4", 131, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 729, 1, 105, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR1", 102, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 730, 1, 105, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR2", 102, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 731, 1, 105, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR3", 102, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Session",
                columns: new[] { "id", "day", "endTime", "groupId", "startTime" },
                values: new object[,]
                {
                    { 1, "Viernes", new TimeSpan(0, 8, 0, 0, 0), 1, new TimeSpan(0, 7, 0, 0, 0) },
                    { 2, "Viernes", new TimeSpan(0, 10, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0) },
                    { 3, "Viernes", new TimeSpan(0, 15, 0, 0, 0), 3, new TimeSpan(0, 14, 0, 0, 0) },
                    { 4, "Lunes", new TimeSpan(0, 16, 0, 0, 0), 4, new TimeSpan(0, 14, 0, 0, 0) },
                    { 5, "Martes", new TimeSpan(0, 16, 0, 0, 0), 5, new TimeSpan(0, 14, 0, 0, 0) },
                    { 6, "Miercoles", new TimeSpan(0, 16, 0, 0, 0), 6, new TimeSpan(0, 14, 0, 0, 0) },
                    { 7, "Jueves", new TimeSpan(0, 16, 0, 0, 0), 7, new TimeSpan(0, 14, 0, 0, 0) },
                    { 8, "Jueves", new TimeSpan(0, 16, 0, 0, 0), 8, new TimeSpan(0, 14, 0, 0, 0) },
                    { 9, "Jueves", new TimeSpan(0, 13, 0, 0, 0), 9, new TimeSpan(0, 11, 0, 0, 0) },
                    { 10, "Miercoles", new TimeSpan(0, 16, 0, 0, 0), 10, new TimeSpan(0, 14, 0, 0, 0) },
                    { 11, "Lunes", new TimeSpan(0, 16, 0, 0, 0), 11, new TimeSpan(0, 14, 0, 0, 0) },
                    { 12, "Martes", new TimeSpan(0, 9, 0, 0, 0), 12, new TimeSpan(0, 7, 0, 0, 0) },
                    { 13, "Miercoles", new TimeSpan(0, 9, 0, 0, 0), 13, new TimeSpan(0, 7, 0, 0, 0) },
                    { 14, "Lunes", new TimeSpan(0, 9, 0, 0, 0), 14, new TimeSpan(0, 7, 0, 0, 0) },
                    { 15, "Miercoles", new TimeSpan(0, 16, 0, 0, 0), 15, new TimeSpan(0, 14, 0, 0, 0) },
                    { 16, "Viernes", new TimeSpan(0, 16, 0, 0, 0), 16, new TimeSpan(0, 14, 0, 0, 0) },
                    { 17, "Viernes", new TimeSpan(0, 11, 0, 0, 0), 17, new TimeSpan(0, 9, 0, 0, 0) },
                    { 18, "Viernes", new TimeSpan(0, 9, 0, 0, 0), 18, new TimeSpan(0, 7, 0, 0, 0) },
                    { 19, "Martes", new TimeSpan(0, 9, 0, 0, 0), 19, new TimeSpan(0, 7, 0, 0, 0) },
                    { 20, "Viernes", new TimeSpan(0, 16, 0, 0, 0), 20, new TimeSpan(0, 14, 0, 0, 0) },
                    { 21, "Lunes", new TimeSpan(0, 13, 0, 0, 0), 21, new TimeSpan(0, 11, 0, 0, 0) },
                    { 22, "Lunes", new TimeSpan(0, 16, 0, 0, 0), 22, new TimeSpan(0, 14, 0, 0, 0) },
                    { 23, "Miercoles", new TimeSpan(0, 9, 0, 0, 0), 23, new TimeSpan(0, 7, 0, 0, 0) },
                    { 24, "Jueves", new TimeSpan(0, 9, 0, 0, 0), 24, new TimeSpan(0, 7, 0, 0, 0) },
                    { 25, "Jueves", new TimeSpan(0, 16, 0, 0, 0), 25, new TimeSpan(0, 14, 0, 0, 0) },
                    { 26, "Viernes", new TimeSpan(0, 9, 0, 0, 0), 26, new TimeSpan(0, 7, 0, 0, 0) },
                    { 27, "Lunes", new TimeSpan(0, 16, 0, 0, 0), 27, new TimeSpan(0, 14, 0, 0, 0) },
                    { 28, "Viernes", new TimeSpan(0, 16, 0, 0, 0), 28, new TimeSpan(0, 14, 0, 0, 0) },
                    { 29, "Miercoles", new TimeSpan(0, 16, 0, 0, 0), 29, new TimeSpan(0, 14, 0, 0, 0) },
                    { 30, "Viernes", new TimeSpan(0, 13, 0, 0, 0), 30, new TimeSpan(0, 11, 0, 0, 0) },
                    { 31, "Lunes", new TimeSpan(0, 18, 0, 0, 0), 31, new TimeSpan(0, 16, 0, 0, 0) },
                    { 32, "Miercoles", new TimeSpan(0, 18, 0, 0, 0), 32, new TimeSpan(0, 16, 0, 0, 0) },
                    { 33, "Jueves", new TimeSpan(0, 9, 0, 0, 0), 33, new TimeSpan(0, 7, 0, 0, 0) },
                    { 34, "Viernes", new TimeSpan(0, 9, 0, 0, 0), 34, new TimeSpan(0, 7, 0, 0, 0) },
                    { 35, "Viernes", new TimeSpan(0, 11, 0, 0, 0), 35, new TimeSpan(0, 9, 0, 0, 0) },
                    { 36, "Miercoles", new TimeSpan(0, 11, 0, 0, 0), 36, new TimeSpan(0, 9, 0, 0, 0) },
                    { 37, "Martes", new TimeSpan(0, 11, 0, 0, 0), 37, new TimeSpan(0, 9, 0, 0, 0) },
                    { 38, "Lunes", new TimeSpan(0, 18, 0, 0, 0), 38, new TimeSpan(0, 16, 0, 0, 0) },
                    { 39, "Lunes", new TimeSpan(0, 13, 0, 0, 0), 39, new TimeSpan(0, 11, 0, 0, 0) },
                    { 40, "Lunes", new TimeSpan(0, 16, 0, 0, 0), 40, new TimeSpan(0, 14, 0, 0, 0) },
                    { 41, "Miercoles", new TimeSpan(0, 16, 0, 0, 0), 41, new TimeSpan(0, 14, 0, 0, 0) },
                    { 42, "Domingo", new TimeSpan(0, 9, 0, 0, 0), 42, new TimeSpan(0, 7, 0, 0, 0) },
                    { 43, "Lunes", new TimeSpan(0, 13, 0, 0, 0), 43, new TimeSpan(0, 11, 0, 0, 0) },
                    { 44, "Lunes", new TimeSpan(0, 16, 0, 0, 0), 44, new TimeSpan(0, 14, 0, 0, 0) },
                    { 48, "Lunes", new TimeSpan(0, 9, 0, 0, 0), 48, new TimeSpan(0, 7, 0, 0, 0) },
                    { 49, "Miercoles", new TimeSpan(0, 8, 0, 0, 0), 48, new TimeSpan(0, 7, 0, 0, 0) },
                    { 50, "Miercoles", new TimeSpan(0, 13, 0, 0, 0), 50, new TimeSpan(0, 12, 0, 0, 0) },
                    { 51, "Viernes", new TimeSpan(0, 13, 0, 0, 0), 50, new TimeSpan(0, 11, 0, 0, 0) },
                    { 52, "Martes", new TimeSpan(0, 13, 0, 0, 0), 52, new TimeSpan(0, 11, 0, 0, 0) },
                    { 53, "Jueves", new TimeSpan(0, 15, 0, 0, 0), 52, new TimeSpan(0, 14, 0, 0, 0) },
                    { 54, "Miercoles", new TimeSpan(0, 12, 0, 0, 0), 54, new TimeSpan(0, 11, 0, 0, 0) },
                    { 55, "Jueves", new TimeSpan(0, 11, 0, 0, 0), 54, new TimeSpan(0, 9, 0, 0, 0) },
                    { 56, "Lunes", new TimeSpan(0, 13, 0, 0, 0), 56, new TimeSpan(0, 11, 0, 0, 0) },
                    { 57, "Miercoles", new TimeSpan(0, 12, 0, 0, 0), 56, new TimeSpan(0, 11, 0, 0, 0) },
                    { 58, "Martes", new TimeSpan(0, 11, 0, 0, 0), 58, new TimeSpan(0, 9, 0, 0, 0) },
                    { 59, "Miercoles", new TimeSpan(0, 11, 0, 0, 0), 58, new TimeSpan(0, 10, 0, 0, 0) },
                    { 60, "Martes", new TimeSpan(0, 16, 0, 0, 0), 60, new TimeSpan(0, 14, 0, 0, 0) },
                    { 61, "Jueves", new TimeSpan(0, 15, 0, 0, 0), 60, new TimeSpan(0, 14, 0, 0, 0) },
                    { 62, "Miercoles", new TimeSpan(0, 13, 0, 0, 0), 62, new TimeSpan(0, 12, 0, 0, 0) },
                    { 63, "Viernes", new TimeSpan(0, 13, 0, 0, 0), 62, new TimeSpan(0, 11, 0, 0, 0) },
                    { 64, "Lunes", new TimeSpan(0, 11, 0, 0, 0), 64, new TimeSpan(0, 9, 0, 0, 0) },
                    { 65, "Miercoles", new TimeSpan(0, 10, 0, 0, 0), 64, new TimeSpan(0, 9, 0, 0, 0) },
                    { 66, "Miercoles", new TimeSpan(0, 13, 0, 0, 0), 66, new TimeSpan(0, 11, 0, 0, 0) },
                    { 67, "Viernes", new TimeSpan(0, 13, 0, 0, 0), 66, new TimeSpan(0, 11, 0, 0, 0) },
                    { 68, "Miercoles", new TimeSpan(0, 12, 0, 0, 0), 68, new TimeSpan(0, 10, 0, 0, 0) },
                    { 69, "Jueves", new TimeSpan(0, 11, 0, 0, 0), 69, new TimeSpan(0, 9, 0, 0, 0) },
                    { 70, "Miercoles", new TimeSpan(0, 18, 0, 0, 0), 70, new TimeSpan(0, 16, 0, 0, 0) },
                    { 71, "Martes", new TimeSpan(0, 11, 0, 0, 0), 71, new TimeSpan(0, 9, 0, 0, 0) },
                    { 72, "Viernes", new TimeSpan(0, 13, 0, 0, 0), 72, new TimeSpan(0, 11, 0, 0, 0) },
                    { 73, "Viernes", new TimeSpan(0, 16, 0, 0, 0), 73, new TimeSpan(0, 14, 0, 0, 0) },
                    { 74, "Miercoles", new TimeSpan(0, 16, 0, 0, 0), 74, new TimeSpan(0, 14, 0, 0, 0) },
                    { 75, "Martes", new TimeSpan(0, 11, 0, 0, 0), 75, new TimeSpan(0, 9, 0, 0, 0) },
                    { 76, "Miercoles", new TimeSpan(0, 9, 0, 0, 0), 76, new TimeSpan(0, 7, 0, 0, 0) },
                    { 77, "Lunes", new TimeSpan(0, 13, 0, 0, 0), 77, new TimeSpan(0, 11, 0, 0, 0) },
                    { 78, "Miercoles", new TimeSpan(0, 16, 0, 0, 0), 78, new TimeSpan(0, 14, 0, 0, 0) },
                    { 79, "Miercoles", new TimeSpan(0, 18, 0, 0, 0), 79, new TimeSpan(0, 16, 0, 0, 0) },
                    { 80, "Lunes", new TimeSpan(0, 11, 0, 0, 0), 80, new TimeSpan(0, 9, 0, 0, 0) },
                    { 81, "Martes", new TimeSpan(0, 11, 0, 0, 0), 81, new TimeSpan(0, 9, 0, 0, 0) },
                    { 82, "Miercoles", new TimeSpan(0, 11, 0, 0, 0), 82, new TimeSpan(0, 9, 0, 0, 0) },
                    { 83, "Martes", new TimeSpan(0, 16, 0, 0, 0), 83, new TimeSpan(0, 14, 0, 0, 0) },
                    { 84, "Viernes", new TimeSpan(0, 9, 0, 0, 0), 84, new TimeSpan(0, 7, 0, 0, 0) },
                    { 85, "Viernes", new TimeSpan(0, 11, 0, 0, 0), 85, new TimeSpan(0, 9, 0, 0, 0) },
                    { 86, "Viernes", new TimeSpan(0, 16, 0, 0, 0), 86, new TimeSpan(0, 14, 0, 0, 0) },
                    { 87, "Lunes", new TimeSpan(0, 9, 0, 0, 0), 87, new TimeSpan(0, 7, 0, 0, 0) },
                    { 88, "Miercoles", new TimeSpan(0, 9, 0, 0, 0), 88, new TimeSpan(0, 7, 0, 0, 0) },
                    { 89, "Lunes", new TimeSpan(0, 16, 0, 0, 0), 89, new TimeSpan(0, 14, 0, 0, 0) },
                    { 90, "Martes", new TimeSpan(0, 18, 0, 0, 0), 90, new TimeSpan(0, 16, 0, 0, 0) },
                    { 91, "Jueves", new TimeSpan(0, 18, 0, 0, 0), 91, new TimeSpan(0, 16, 0, 0, 0) },
                    { 92, "Martes", new TimeSpan(0, 9, 0, 0, 0), 92, new TimeSpan(0, 7, 0, 0, 0) },
                    { 93, "Martes", new TimeSpan(0, 13, 0, 0, 0), 93, new TimeSpan(0, 11, 0, 0, 0) },
                    { 94, "Jueves", new TimeSpan(0, 16, 0, 0, 0), 94, new TimeSpan(0, 14, 0, 0, 0) },
                    { 95, "Viernes", new TimeSpan(0, 18, 0, 0, 0), 95, new TimeSpan(0, 16, 0, 0, 0) },
                    { 96, "Lunes", new TimeSpan(0, 18, 0, 0, 0), 96, new TimeSpan(0, 16, 0, 0, 0) },
                    { 97, "Miercoles", new TimeSpan(0, 16, 0, 0, 0), 97, new TimeSpan(0, 14, 0, 0, 0) },
                    { 98, "Viernes", new TimeSpan(0, 16, 0, 0, 0), 98, new TimeSpan(0, 14, 0, 0, 0) },
                    { 99, "Lunes", new TimeSpan(0, 16, 0, 0, 0), 99, new TimeSpan(0, 14, 0, 0, 0) },
                    { 100, "Martes", new TimeSpan(0, 18, 0, 0, 0), 100, new TimeSpan(0, 16, 0, 0, 0) },
                    { 101, "Lunes", new TimeSpan(0, 9, 0, 0, 0), 101, new TimeSpan(0, 7, 0, 0, 0) },
                    { 102, "Miercoles", new TimeSpan(0, 9, 0, 0, 0), 102, new TimeSpan(0, 7, 0, 0, 0) },
                    { 103, "Viernes", new TimeSpan(0, 9, 0, 0, 0), 103, new TimeSpan(0, 7, 0, 0, 0) },
                    { 104, "Martes", new TimeSpan(0, 16, 0, 0, 0), 104, new TimeSpan(0, 14, 0, 0, 0) },
                    { 105, "Lunes", new TimeSpan(0, 16, 0, 0, 0), 105, new TimeSpan(0, 14, 0, 0, 0) },
                    { 106, "Viernes", new TimeSpan(0, 13, 0, 0, 0), 106, new TimeSpan(0, 11, 0, 0, 0) },
                    { 107, "Lunes", new TimeSpan(0, 13, 0, 0, 0), 107, new TimeSpan(0, 11, 0, 0, 0) },
                    { 108, "Miercoles", new TimeSpan(0, 13, 0, 0, 0), 107, new TimeSpan(0, 11, 0, 0, 0) },
                    { 109, "Miercoles", new TimeSpan(0, 11, 0, 0, 0), 109, new TimeSpan(0, 9, 0, 0, 0) },
                    { 110, "Viernes", new TimeSpan(0, 11, 0, 0, 0), 109, new TimeSpan(0, 9, 0, 0, 0) },
                    { 111, "Lunes", new TimeSpan(0, 12, 0, 0, 0), 111, new TimeSpan(0, 11, 0, 0, 0) },
                    { 112, "Miercoles", new TimeSpan(0, 13, 0, 0, 0), 111, new TimeSpan(0, 11, 0, 0, 0) },
                    { 113, "Lunes", new TimeSpan(0, 9, 0, 0, 0), 113, new TimeSpan(0, 7, 0, 0, 0) },
                    { 114, "Miercoles", new TimeSpan(0, 9, 0, 0, 0), 113, new TimeSpan(0, 8, 0, 0, 0) },
                    { 115, "Lunes", new TimeSpan(0, 13, 0, 0, 0), 115, new TimeSpan(0, 11, 0, 0, 0) },
                    { 116, "Viernes", new TimeSpan(0, 11, 0, 0, 0), 116, new TimeSpan(0, 9, 0, 0, 0) },
                    { 117, "Lunes", new TimeSpan(0, 16, 0, 0, 0), 117, new TimeSpan(0, 14, 0, 0, 0) },
                    { 118, "Miercoles", new TimeSpan(0, 16, 0, 0, 0), 118, new TimeSpan(0, 14, 0, 0, 0) },
                    { 119, "Martes", new TimeSpan(0, 16, 0, 0, 0), 119, new TimeSpan(0, 14, 0, 0, 0) },
                    { 120, "Lunes", new TimeSpan(0, 9, 0, 0, 0), 120, new TimeSpan(0, 7, 0, 0, 0) },
                    { 121, "Viernes", new TimeSpan(0, 9, 0, 0, 0), 121, new TimeSpan(0, 7, 0, 0, 0) },
                    { 122, "Lunes", new TimeSpan(0, 18, 0, 0, 0), 122, new TimeSpan(0, 16, 0, 0, 0) },
                    { 123, "Martes", new TimeSpan(0, 18, 0, 0, 0), 123, new TimeSpan(0, 16, 0, 0, 0) },
                    { 124, "Viernes", new TimeSpan(0, 13, 0, 0, 0), 124, new TimeSpan(0, 11, 0, 0, 0) },
                    { 125, "Jueves", new TimeSpan(0, 18, 0, 0, 0), 125, new TimeSpan(0, 16, 0, 0, 0) },
                    { 126, "Viernes", new TimeSpan(0, 16, 0, 0, 0), 126, new TimeSpan(0, 14, 0, 0, 0) },
                    { 127, "Lunes", new TimeSpan(0, 11, 0, 0, 0), 127, new TimeSpan(0, 9, 0, 0, 0) },
                    { 128, "Jueves", new TimeSpan(0, 11, 0, 0, 0), 127, new TimeSpan(0, 10, 0, 0, 0) },
                    { 129, "Miercoles", new TimeSpan(0, 16, 0, 0, 0), 129, new TimeSpan(0, 14, 0, 0, 0) },
                    { 130, "Jueves", new TimeSpan(0, 9, 0, 0, 0), 130, new TimeSpan(0, 7, 0, 0, 0) },
                    { 131, "Jueves", new TimeSpan(0, 11, 0, 0, 0), 131, new TimeSpan(0, 9, 0, 0, 0) },
                    { 132, "Lunes", new TimeSpan(0, 13, 0, 0, 0), 132, new TimeSpan(0, 11, 0, 0, 0) },
                    { 133, "Viernes", new TimeSpan(0, 18, 0, 0, 0), 133, new TimeSpan(0, 16, 0, 0, 0) },
                    { 134, "Martes", new TimeSpan(0, 9, 0, 0, 0), 134, new TimeSpan(0, 7, 0, 0, 0) },
                    { 135, "Lunes", new TimeSpan(0, 16, 0, 0, 0), 135, new TimeSpan(0, 14, 0, 0, 0) },
                    { 136, "Lunes", new TimeSpan(0, 18, 0, 0, 0), 136, new TimeSpan(0, 16, 0, 0, 0) },
                    { 137, "Martes", new TimeSpan(0, 18, 0, 0, 0), 137, new TimeSpan(0, 16, 0, 0, 0) },
                    { 138, "Miercoles", new TimeSpan(0, 16, 0, 0, 0), 138, new TimeSpan(0, 14, 0, 0, 0) },
                    { 139, "Miercoles", new TimeSpan(0, 18, 0, 0, 0), 139, new TimeSpan(0, 16, 0, 0, 0) },
                    { 140, "Martes", new TimeSpan(0, 13, 0, 0, 0), 140, new TimeSpan(0, 11, 0, 0, 0) },
                    { 141, "Viernes", new TimeSpan(0, 13, 0, 0, 0), 141, new TimeSpan(0, 11, 0, 0, 0) },
                    { 142, "Lunes", new TimeSpan(0, 11, 0, 0, 0), 142, new TimeSpan(0, 9, 0, 0, 0) },
                    { 143, "Miercoles", new TimeSpan(0, 11, 0, 0, 0), 142, new TimeSpan(0, 10, 0, 0, 0) },
                    { 144, "Lunes", new TimeSpan(0, 16, 0, 0, 0), 143, new TimeSpan(0, 14, 0, 0, 0) },
                    { 146, "Lunes", new TimeSpan(0, 11, 0, 0, 0), 145, new TimeSpan(0, 9, 0, 0, 0) },
                    { 147, "Martes", new TimeSpan(0, 13, 0, 0, 0), 145, new TimeSpan(0, 11, 0, 0, 0) },
                    { 149, "Domingo", new TimeSpan(0, 9, 0, 0, 0), 148, new TimeSpan(0, 7, 0, 0, 0) },
                    { 150, "Lunes", new TimeSpan(0, 10, 0, 0, 0), 148, new TimeSpan(0, 9, 0, 0, 0) },
                    { 152, "Miercoles", new TimeSpan(0, 13, 0, 0, 0), 151, new TimeSpan(0, 12, 0, 0, 0) },
                    { 153, "Miercoles", new TimeSpan(0, 11, 0, 0, 0), 151, new TimeSpan(0, 9, 0, 0, 0) },
                    { 155, "Martes", new TimeSpan(0, 11, 0, 0, 0), 154, new TimeSpan(0, 9, 0, 0, 0) },
                    { 156, "Miercoles", new TimeSpan(0, 13, 0, 0, 0), 154, new TimeSpan(0, 11, 0, 0, 0) },
                    { 158, "Lunes", new TimeSpan(0, 16, 0, 0, 0), 157, new TimeSpan(0, 14, 0, 0, 0) },
                    { 160, "Viernes", new TimeSpan(0, 9, 0, 0, 0), 159, new TimeSpan(0, 7, 0, 0, 0) },
                    { 162, "Miercoles", new TimeSpan(0, 16, 0, 0, 0), 161, new TimeSpan(0, 14, 0, 0, 0) },
                    { 164, "Martes", new TimeSpan(0, 16, 0, 0, 0), 163, new TimeSpan(0, 14, 0, 0, 0) },
                    { 165, "Viernes", new TimeSpan(0, 15, 0, 0, 0), 163, new TimeSpan(0, 14, 0, 0, 0) },
                    { 167, "Lunes", new TimeSpan(0, 11, 0, 0, 0), 166, new TimeSpan(0, 9, 0, 0, 0) },
                    { 168, "Miercoles", new TimeSpan(0, 11, 0, 0, 0), 166, new TimeSpan(0, 10, 0, 0, 0) },
                    { 170, "Martes", new TimeSpan(0, 9, 0, 0, 0), 169, new TimeSpan(0, 7, 0, 0, 0) },
                    { 171, "Jueves", new TimeSpan(0, 16, 0, 0, 0), 169, new TimeSpan(0, 14, 0, 0, 0) },
                    { 172, "Viernes", new TimeSpan(0, 10, 0, 0, 0), 169, new TimeSpan(0, 9, 0, 0, 0) },
                    { 173, "Martes", new TimeSpan(0, 15, 0, 0, 0), 172, new TimeSpan(0, 14, 0, 0, 0) },
                    { 174, "Viernes", new TimeSpan(0, 17, 0, 0, 0), 172, new TimeSpan(0, 15, 0, 0, 0) },
                    { 175, "Viernes", new TimeSpan(0, 9, 0, 0, 0), 175, new TimeSpan(0, 7, 0, 0, 0) },
                    { 178, "Viernes", new TimeSpan(0, 11, 0, 0, 0), 178, new TimeSpan(0, 9, 0, 0, 0) },
                    { 179, "Viernes", new TimeSpan(0, 13, 0, 0, 0), 179, new TimeSpan(0, 11, 0, 0, 0) },
                    { 180, "Miercoles", new TimeSpan(0, 16, 0, 0, 0), 180, new TimeSpan(0, 14, 0, 0, 0) },
                    { 181, "Lunes", new TimeSpan(0, 13, 0, 0, 0), 181, new TimeSpan(0, 11, 0, 0, 0) },
                    { 182, "Miercoles", new TimeSpan(0, 11, 0, 0, 0), 182, new TimeSpan(0, 9, 0, 0, 0) },
                    { 183, "Viernes", new TimeSpan(0, 16, 0, 0, 0), 183, new TimeSpan(0, 14, 0, 0, 0) },
                    { 184, "Martes", new TimeSpan(0, 11, 0, 0, 0), 184, new TimeSpan(0, 9, 0, 0, 0) },
                    { 185, "Miercoles", new TimeSpan(0, 13, 0, 0, 0), 184, new TimeSpan(0, 12, 0, 0, 0) },
                    { 186, "Lunes", new TimeSpan(0, 16, 0, 0, 0), 185, new TimeSpan(0, 14, 0, 0, 0) },
                    { 187, "Viernes", new TimeSpan(0, 18, 0, 0, 0), 185, new TimeSpan(0, 16, 0, 0, 0) },
                    { 188, "Martes", new TimeSpan(0, 11, 0, 0, 0), 188, new TimeSpan(0, 9, 0, 0, 0) },
                    { 189, "Miercoles", new TimeSpan(0, 10, 0, 0, 0), 188, new TimeSpan(0, 9, 0, 0, 0) },
                    { 190, "Miercoles", new TimeSpan(0, 15, 0, 0, 0), 189, new TimeSpan(0, 14, 0, 0, 0) },
                    { 191, "Viernes", new TimeSpan(0, 16, 0, 0, 0), 189, new TimeSpan(0, 14, 0, 0, 0) },
                    { 192, "Miercoles", new TimeSpan(0, 11, 0, 0, 0), 190, new TimeSpan(0, 10, 0, 0, 0) },
                    { 195, "Viernes", new TimeSpan(0, 11, 0, 0, 0), 191, new TimeSpan(0, 9, 0, 0, 0) },
                    { 196, "Martes", new TimeSpan(0, 9, 0, 0, 0), 192, new TimeSpan(0, 7, 0, 0, 0) },
                    { 197, "Miercoles", new TimeSpan(0, 12, 0, 0, 0), 193, new TimeSpan(0, 11, 0, 0, 0) },
                    { 198, "Lunes", new TimeSpan(0, 18, 0, 0, 0), 194, new TimeSpan(0, 16, 0, 0, 0) },
                    { 199, "Miercoles", new TimeSpan(0, 18, 0, 0, 0), 194, new TimeSpan(0, 16, 0, 0, 0) },
                    { 200, "Lunes", new TimeSpan(0, 9, 0, 0, 0), 195, new TimeSpan(0, 7, 0, 0, 0) },
                    { 201, "Miercoles", new TimeSpan(0, 9, 0, 0, 0), 195, new TimeSpan(0, 7, 0, 0, 0) },
                    { 202, "Martes", new TimeSpan(0, 13, 0, 0, 0), 196, new TimeSpan(0, 11, 0, 0, 0) },
                    { 203, "Jueves", new TimeSpan(0, 13, 0, 0, 0), 196, new TimeSpan(0, 11, 0, 0, 0) },
                    { 204, "Lunes", new TimeSpan(0, 16, 0, 0, 0), 197, new TimeSpan(0, 14, 0, 0, 0) },
                    { 205, "Viernes", new TimeSpan(0, 18, 0, 0, 0), 197, new TimeSpan(0, 16, 0, 0, 0) },
                    { 206, "Lunes", new TimeSpan(0, 11, 0, 0, 0), 198, new TimeSpan(0, 9, 0, 0, 0) },
                    { 207, "Miercoles", new TimeSpan(0, 9, 0, 0, 0), 198, new TimeSpan(0, 7, 0, 0, 0) },
                    { 208, "Martes", new TimeSpan(0, 11, 0, 0, 0), 199, new TimeSpan(0, 9, 0, 0, 0) },
                    { 209, "Jueves", new TimeSpan(0, 11, 0, 0, 0), 199, new TimeSpan(0, 10, 0, 0, 0) },
                    { 210, "Martes", new TimeSpan(0, 16, 0, 0, 0), 200, new TimeSpan(0, 14, 0, 0, 0) },
                    { 211, "Jueves", new TimeSpan(0, 16, 0, 0, 0), 200, new TimeSpan(0, 14, 0, 0, 0) },
                    { 212, "Martes", new TimeSpan(0, 18, 0, 0, 0), 201, new TimeSpan(0, 16, 0, 0, 0) },
                    { 213, "Miercoles", new TimeSpan(0, 18, 0, 0, 0), 201, new TimeSpan(0, 16, 0, 0, 0) },
                    { 214, "Miercoles", new TimeSpan(0, 16, 0, 0, 0), 202, new TimeSpan(0, 14, 0, 0, 0) },
                    { 215, "Jueves", new TimeSpan(0, 16, 0, 0, 0), 202, new TimeSpan(0, 14, 0, 0, 0) },
                    { 216, "Martes", new TimeSpan(0, 9, 0, 0, 0), 203, new TimeSpan(0, 7, 0, 0, 0) },
                    { 217, "Jueves", new TimeSpan(0, 10, 0, 0, 0), 203, new TimeSpan(0, 9, 0, 0, 0) },
                    { 218, "Miercoles", new TimeSpan(0, 16, 0, 0, 0), 204, new TimeSpan(0, 14, 0, 0, 0) },
                    { 219, "Viernes", new TimeSpan(0, 16, 0, 0, 0), 204, new TimeSpan(0, 14, 0, 0, 0) },
                    { 220, "Lunes", new TimeSpan(0, 11, 0, 0, 0), 205, new TimeSpan(0, 9, 0, 0, 0) },
                    { 221, "Martes", new TimeSpan(0, 9, 0, 0, 0), 205, new TimeSpan(0, 8, 0, 0, 0) },
                    { 222, "Lunes", new TimeSpan(0, 16, 0, 0, 0), 206, new TimeSpan(0, 14, 0, 0, 0) },
                    { 223, "Martes", new TimeSpan(0, 16, 0, 0, 0), 206, new TimeSpan(0, 14, 0, 0, 0) },
                    { 224, "Martes", new TimeSpan(0, 9, 0, 0, 0), 207, new TimeSpan(0, 7, 0, 0, 0) },
                    { 225, "Jueves", new TimeSpan(0, 10, 0, 0, 0), 207, new TimeSpan(0, 9, 0, 0, 0) },
                    { 226, "Miercoles", new TimeSpan(0, 11, 0, 0, 0), 208, new TimeSpan(0, 10, 0, 0, 0) },
                    { 227, "Jueves", new TimeSpan(0, 9, 0, 0, 0), 208, new TimeSpan(0, 7, 0, 0, 0) },
                    { 228, "Lunes", new TimeSpan(0, 13, 0, 0, 0), 209, new TimeSpan(0, 11, 0, 0, 0) },
                    { 229, "Miercoles", new TimeSpan(0, 12, 0, 0, 0), 210, new TimeSpan(0, 11, 0, 0, 0) },
                    { 230, "Martes", new TimeSpan(0, 13, 0, 0, 0), 211, new TimeSpan(0, 11, 0, 0, 0) },
                    { 231, "Lunes", new TimeSpan(0, 13, 0, 0, 0), 212, new TimeSpan(0, 11, 0, 0, 0) },
                    { 232, "Martes", new TimeSpan(0, 16, 0, 0, 0), 213, new TimeSpan(0, 14, 0, 0, 0) },
                    { 233, "Viernes", new TimeSpan(0, 11, 0, 0, 0), 214, new TimeSpan(0, 9, 0, 0, 0) },
                    { 234, "Martes", new TimeSpan(0, 9, 0, 0, 0), 215, new TimeSpan(0, 7, 0, 0, 0) },
                    { 235, "Viernes", new TimeSpan(0, 9, 0, 0, 0), 215, new TimeSpan(0, 8, 0, 0, 0) },
                    { 236, "Miercoles", new TimeSpan(0, 13, 0, 0, 0), 216, new TimeSpan(0, 11, 0, 0, 0) },
                    { 237, "Viernes", new TimeSpan(0, 13, 0, 0, 0), 216, new TimeSpan(0, 12, 0, 0, 0) },
                    { 238, "Lunes", new TimeSpan(0, 11, 0, 0, 0), 217, new TimeSpan(0, 9, 0, 0, 0) },
                    { 239, "Miercoles", new TimeSpan(0, 9, 0, 0, 0), 217, new TimeSpan(0, 8, 0, 0, 0) },
                    { 240, "Lunes", new TimeSpan(0, 16, 0, 0, 0), 218, new TimeSpan(0, 14, 0, 0, 0) },
                    { 241, "Miercoles", new TimeSpan(0, 16, 0, 0, 0), 218, new TimeSpan(0, 15, 0, 0, 0) },
                    { 242, "Martes", new TimeSpan(0, 13, 0, 0, 0), 219, new TimeSpan(0, 11, 0, 0, 0) },
                    { 243, "Viernes", new TimeSpan(0, 8, 0, 0, 0), 219, new TimeSpan(0, 7, 0, 0, 0) },
                    { 244, "Lunes", new TimeSpan(0, 8, 0, 0, 0), 220, new TimeSpan(0, 7, 0, 0, 0) },
                    { 245, "Miercoles", new TimeSpan(0, 11, 0, 0, 0), 220, new TimeSpan(0, 9, 0, 0, 0) },
                    { 246, "Miercoles", new TimeSpan(0, 8, 0, 0, 0), 221, new TimeSpan(0, 7, 0, 0, 0) },
                    { 247, "Viernes", new TimeSpan(0, 11, 0, 0, 0), 221, new TimeSpan(0, 9, 0, 0, 0) },
                    { 248, "Lunes", new TimeSpan(0, 9, 0, 0, 0), 222, new TimeSpan(0, 7, 0, 0, 0) },
                    { 249, "Miercoles", new TimeSpan(0, 9, 0, 0, 0), 222, new TimeSpan(0, 7, 0, 0, 0) },
                    { 250, "Martes", new TimeSpan(0, 13, 0, 0, 0), 223, new TimeSpan(0, 11, 0, 0, 0) },
                    { 251, "Viernes", new TimeSpan(0, 12, 0, 0, 0), 223, new TimeSpan(0, 11, 0, 0, 0) },
                    { 252, "Miercoles", new TimeSpan(0, 11, 0, 0, 0), 224, new TimeSpan(0, 9, 0, 0, 0) },
                    { 253, "Viernes", new TimeSpan(0, 11, 0, 0, 0), 224, new TimeSpan(0, 9, 0, 0, 0) },
                    { 254, "Lunes", new TimeSpan(0, 16, 0, 0, 0), 225, new TimeSpan(0, 14, 0, 0, 0) },
                    { 255, "Miercoles", new TimeSpan(0, 16, 0, 0, 0), 225, new TimeSpan(0, 14, 0, 0, 0) },
                    { 256, "Martes", new TimeSpan(0, 11, 0, 0, 0), 226, new TimeSpan(0, 9, 0, 0, 0) },
                    { 257, "Jueves", new TimeSpan(0, 11, 0, 0, 0), 226, new TimeSpan(0, 9, 0, 0, 0) },
                    { 258, "Martes", new TimeSpan(0, 9, 0, 0, 0), 227, new TimeSpan(0, 7, 0, 0, 0) },
                    { 259, "Viernes", new TimeSpan(0, 9, 0, 0, 0), 227, new TimeSpan(0, 8, 0, 0, 0) },
                    { 260, "Miercoles", new TimeSpan(0, 13, 0, 0, 0), 228, new TimeSpan(0, 11, 0, 0, 0) },
                    { 261, "Viernes", new TimeSpan(0, 13, 0, 0, 0), 228, new TimeSpan(0, 12, 0, 0, 0) },
                    { 262, "Lunes", new TimeSpan(0, 13, 0, 0, 0), 229, new TimeSpan(0, 11, 0, 0, 0) },
                    { 263, "Miercoles", new TimeSpan(0, 19, 0, 0, 0), 230, new TimeSpan(0, 17, 0, 0, 0) },
                    { 264, "Lunes", new TimeSpan(0, 11, 0, 0, 0), 231, new TimeSpan(0, 9, 0, 0, 0) },
                    { 265, "Viernes", new TimeSpan(0, 16, 0, 0, 0), 232, new TimeSpan(0, 14, 0, 0, 0) },
                    { 266, "Miercoles", new TimeSpan(0, 16, 0, 0, 0), 233, new TimeSpan(0, 14, 0, 0, 0) },
                    { 267, "Lunes", new TimeSpan(0, 13, 0, 0, 0), 234, new TimeSpan(0, 11, 0, 0, 0) },
                    { 268, "Viernes", new TimeSpan(0, 13, 0, 0, 0), 235, new TimeSpan(0, 11, 0, 0, 0) },
                    { 269, "Martes", new TimeSpan(0, 11, 0, 0, 0), 236, new TimeSpan(0, 9, 0, 0, 0) },
                    { 270, "Jueves", new TimeSpan(0, 13, 0, 0, 0), 236, new TimeSpan(0, 11, 0, 0, 0) },
                    { 271, "Lunes", new TimeSpan(0, 9, 0, 0, 0), 237, new TimeSpan(0, 7, 0, 0, 0) },
                    { 272, "Miercoles", new TimeSpan(0, 9, 0, 0, 0), 237, new TimeSpan(0, 7, 0, 0, 0) },
                    { 273, "Lunes", new TimeSpan(0, 11, 0, 0, 0), 238, new TimeSpan(0, 9, 0, 0, 0) },
                    { 274, "Miercoles", new TimeSpan(0, 12, 0, 0, 0), 238, new TimeSpan(0, 11, 0, 0, 0) },
                    { 275, "Lunes", new TimeSpan(0, 16, 0, 0, 0), 239, new TimeSpan(0, 14, 0, 0, 0) },
                    { 276, "Miercoles", new TimeSpan(0, 15, 0, 0, 0), 239, new TimeSpan(0, 14, 0, 0, 0) },
                    { 277, "Martes", new TimeSpan(0, 9, 0, 0, 0), 240, new TimeSpan(0, 7, 0, 0, 0) },
                    { 278, "Jueves", new TimeSpan(0, 9, 0, 0, 0), 240, new TimeSpan(0, 7, 0, 0, 0) },
                    { 279, "Miercoles", new TimeSpan(0, 9, 0, 0, 0), 241, new TimeSpan(0, 7, 0, 0, 0) },
                    { 280, "Miercoles", new TimeSpan(0, 18, 0, 0, 0), 241, new TimeSpan(0, 17, 0, 0, 0) },
                    { 283, "Martes", new TimeSpan(0, 13, 0, 0, 0), 243, new TimeSpan(0, 11, 0, 0, 0) },
                    { 284, "Viernes", new TimeSpan(0, 13, 0, 0, 0), 243, new TimeSpan(0, 12, 0, 0, 0) },
                    { 285, "Martes", new TimeSpan(0, 18, 0, 0, 0), 244, new TimeSpan(0, 16, 0, 0, 0) },
                    { 286, "Viernes", new TimeSpan(0, 14, 0, 0, 0), 244, new TimeSpan(0, 13, 0, 0, 0) },
                    { 287, "Lunes", new TimeSpan(0, 11, 0, 0, 0), 245, new TimeSpan(0, 9, 0, 0, 0) },
                    { 288, "Miercoles", new TimeSpan(0, 12, 0, 0, 0), 245, new TimeSpan(0, 11, 0, 0, 0) },
                    { 289, "Miercoles", new TimeSpan(0, 16, 0, 0, 0), 246, new TimeSpan(0, 14, 0, 0, 0) },
                    { 290, "Viernes", new TimeSpan(0, 15, 0, 0, 0), 246, new TimeSpan(0, 14, 0, 0, 0) },
                    { 291, "Martes", new TimeSpan(0, 16, 0, 0, 0), 247, new TimeSpan(0, 14, 0, 0, 0) },
                    { 292, "Martes", new TimeSpan(0, 11, 0, 0, 0), 248, new TimeSpan(0, 9, 0, 0, 0) },
                    { 293, "Martes", new TimeSpan(0, 9, 0, 0, 0), 249, new TimeSpan(0, 7, 0, 0, 0) },
                    { 294, "Miercoles", new TimeSpan(0, 8, 0, 0, 0), 250, new TimeSpan(0, 7, 0, 0, 0) },
                    { 299, "Jueves", new TimeSpan(0, 11, 0, 0, 0), 255, new TimeSpan(0, 9, 0, 0, 0) },
                    { 300, "Jueves", new TimeSpan(0, 19, 0, 0, 0), 256, new TimeSpan(0, 17, 0, 0, 0) },
                    { 301, "Lunes", new TimeSpan(0, 18, 0, 0, 0), 257, new TimeSpan(0, 16, 0, 0, 0) },
                    { 302, "Lunes", new TimeSpan(0, 13, 0, 0, 0), 258, new TimeSpan(0, 11, 0, 0, 0) },
                    { 303, "Lunes", new TimeSpan(0, 16, 0, 0, 0), 259, new TimeSpan(0, 14, 0, 0, 0) },
                    { 304, "Viernes", new TimeSpan(0, 8, 0, 0, 0), 260, new TimeSpan(0, 7, 0, 0, 0) },
                    { 305, "Lunes", new TimeSpan(0, 18, 0, 0, 0), 261, new TimeSpan(0, 16, 0, 0, 0) },
                    { 306, "Jueves", new TimeSpan(0, 9, 0, 0, 0), 262, new TimeSpan(0, 7, 0, 0, 0) },
                    { 307, "Lunes", new TimeSpan(0, 11, 0, 0, 0), 263, new TimeSpan(0, 9, 0, 0, 0) },
                    { 308, "Martes", new TimeSpan(0, 16, 0, 0, 0), 264, new TimeSpan(0, 14, 0, 0, 0) },
                    { 309, "Martes", new TimeSpan(0, 11, 0, 0, 0), 265, new TimeSpan(0, 9, 0, 0, 0) },
                    { 310, "Jueves", new TimeSpan(0, 11, 0, 0, 0), 265, new TimeSpan(0, 9, 0, 0, 0) },
                    { 311, "Miercoles", new TimeSpan(0, 13, 0, 0, 0), 266, new TimeSpan(0, 11, 0, 0, 0) },
                    { 312, "Viernes", new TimeSpan(0, 13, 0, 0, 0), 266, new TimeSpan(0, 12, 0, 0, 0) },
                    { 313, "Martes", new TimeSpan(0, 19, 0, 0, 0), 267, new TimeSpan(0, 17, 0, 0, 0) },
                    { 314, "Jueves", new TimeSpan(0, 18, 0, 0, 0), 267, new TimeSpan(0, 17, 0, 0, 0) },
                    { 315, "Miercoles", new TimeSpan(0, 15, 0, 0, 0), 268, new TimeSpan(0, 14, 0, 0, 0) },
                    { 316, "Viernes", new TimeSpan(0, 16, 0, 0, 0), 268, new TimeSpan(0, 14, 0, 0, 0) },
                    { 317, "Lunes", new TimeSpan(0, 16, 0, 0, 0), 269, new TimeSpan(0, 14, 0, 0, 0) },
                    { 318, "Miercoles", new TimeSpan(0, 16, 0, 0, 0), 269, new TimeSpan(0, 14, 0, 0, 0) },
                    { 319, "Martes", new TimeSpan(0, 13, 0, 0, 0), 270, new TimeSpan(0, 11, 0, 0, 0) },
                    { 320, "Jueves", new TimeSpan(0, 11, 0, 0, 0), 270, new TimeSpan(0, 9, 0, 0, 0) },
                    { 321, "Lunes", new TimeSpan(0, 9, 0, 0, 0), 271, new TimeSpan(0, 7, 0, 0, 0) },
                    { 322, "Miercoles", new TimeSpan(0, 8, 0, 0, 0), 271, new TimeSpan(0, 7, 0, 0, 0) },
                    { 341, "Miercoles", new TimeSpan(0, 13, 0, 0, 0), 283, new TimeSpan(0, 11, 0, 0, 0) },
                    { 342, "Viernes", new TimeSpan(0, 13, 0, 0, 0), 283, new TimeSpan(0, 12, 0, 0, 0) },
                    { 343, "Lunes", new TimeSpan(0, 11, 0, 0, 0), 284, new TimeSpan(0, 9, 0, 0, 0) },
                    { 344, "Miercoles", new TimeSpan(0, 9, 0, 0, 0), 284, new TimeSpan(0, 8, 0, 0, 0) },
                    { 345, "Miercoles", new TimeSpan(0, 15, 0, 0, 0), 285, new TimeSpan(0, 14, 0, 0, 0) },
                    { 346, "Viernes", new TimeSpan(0, 16, 0, 0, 0), 285, new TimeSpan(0, 14, 0, 0, 0) },
                    { 347, "Jueves", new TimeSpan(0, 11, 0, 0, 0), 286, new TimeSpan(0, 9, 0, 0, 0) },
                    { 348, "Viernes", new TimeSpan(0, 11, 0, 0, 0), 286, new TimeSpan(0, 9, 0, 0, 0) },
                    { 349, "Lunes", new TimeSpan(0, 16, 0, 0, 0), 287, new TimeSpan(0, 14, 0, 0, 0) },
                    { 350, "Miercoles", new TimeSpan(0, 16, 0, 0, 0), 287, new TimeSpan(0, 15, 0, 0, 0) },
                    { 351, "Lunes", new TimeSpan(0, 13, 0, 0, 0), 288, new TimeSpan(0, 11, 0, 0, 0) },
                    { 352, "Miercoles", new TimeSpan(0, 12, 0, 0, 0), 288, new TimeSpan(0, 11, 0, 0, 0) },
                    { 353, "Martes", new TimeSpan(0, 13, 0, 0, 0), 289, new TimeSpan(0, 11, 0, 0, 0) },
                    { 354, "Miercoles", new TimeSpan(0, 12, 0, 0, 0), 289, new TimeSpan(0, 11, 0, 0, 0) },
                    { 355, "Martes", new TimeSpan(0, 11, 0, 0, 0), 290, new TimeSpan(0, 9, 0, 0, 0) },
                    { 356, "Miercoles", new TimeSpan(0, 10, 0, 0, 0), 290, new TimeSpan(0, 9, 0, 0, 0) },
                    { 357, "Martes", new TimeSpan(0, 16, 0, 0, 0), 291, new TimeSpan(0, 14, 0, 0, 0) },
                    { 358, "Miercoles", new TimeSpan(0, 18, 0, 0, 0), 292, new TimeSpan(0, 16, 0, 0, 0) },
                    { 359, "Jueves", new TimeSpan(0, 18, 0, 0, 0), 293, new TimeSpan(0, 16, 0, 0, 0) },
                    { 360, "Miercoles", new TimeSpan(0, 19, 0, 0, 0), 294, new TimeSpan(0, 17, 0, 0, 0) },
                    { 361, "Jueves", new TimeSpan(0, 16, 0, 0, 0), 295, new TimeSpan(0, 14, 0, 0, 0) },
                    { 362, "Martes", new TimeSpan(0, 9, 0, 0, 0), 296, new TimeSpan(0, 7, 0, 0, 0) },
                    { 363, "Lunes", new TimeSpan(0, 13, 0, 0, 0), 297, new TimeSpan(0, 11, 0, 0, 0) },
                    { 364, "Jueves", new TimeSpan(0, 9, 0, 0, 0), 298, new TimeSpan(0, 7, 0, 0, 0) },
                    { 365, "Martes", new TimeSpan(0, 16, 0, 0, 0), 299, new TimeSpan(0, 14, 0, 0, 0) },
                    { 366, "Miercoles", new TimeSpan(0, 15, 0, 0, 0), 300, new TimeSpan(0, 14, 0, 0, 0) },
                    { 367, "Martes", new TimeSpan(0, 13, 0, 0, 0), 301, new TimeSpan(0, 11, 0, 0, 0) },
                    { 368, "Viernes", new TimeSpan(0, 15, 0, 0, 0), 301, new TimeSpan(0, 14, 0, 0, 0) },
                    { 369, "Miercoles", new TimeSpan(0, 19, 0, 0, 0), 302, new TimeSpan(0, 17, 0, 0, 0) },
                    { 371, "Lunes", new TimeSpan(0, 16, 0, 0, 0), 303, new TimeSpan(0, 14, 0, 0, 0) },
                    { 372, "Martes", new TimeSpan(0, 16, 0, 0, 0), 303, new TimeSpan(0, 14, 0, 0, 0) },
                    { 373, "Lunes", new TimeSpan(0, 9, 0, 0, 0), 304, new TimeSpan(0, 7, 0, 0, 0) },
                    { 374, "Miercoles", new TimeSpan(0, 8, 0, 0, 0), 304, new TimeSpan(0, 7, 0, 0, 0) },
                    { 375, "Martes", new TimeSpan(0, 9, 0, 0, 0), 305, new TimeSpan(0, 7, 0, 0, 0) },
                    { 376, "Viernes", new TimeSpan(0, 10, 0, 0, 0), 305, new TimeSpan(0, 9, 0, 0, 0) },
                    { 377, "Miercoles", new TimeSpan(0, 13, 0, 0, 0), 306, new TimeSpan(0, 11, 0, 0, 0) },
                    { 378, "Viernes", new TimeSpan(0, 13, 0, 0, 0), 306, new TimeSpan(0, 12, 0, 0, 0) },
                    { 379, "Martes", new TimeSpan(0, 11, 0, 0, 0), 307, new TimeSpan(0, 9, 0, 0, 0) },
                    { 380, "Miercoles", new TimeSpan(0, 10, 0, 0, 0), 307, new TimeSpan(0, 9, 0, 0, 0) },
                    { 381, "Martes", new TimeSpan(0, 19, 0, 0, 0), 308, new TimeSpan(0, 17, 0, 0, 0) },
                    { 382, "Jueves", new TimeSpan(0, 19, 0, 0, 0), 308, new TimeSpan(0, 18, 0, 0, 0) },
                    { 383, "Jueves", new TimeSpan(0, 11, 0, 0, 0), 309, new TimeSpan(0, 9, 0, 0, 0) },
                    { 384, "Viernes", new TimeSpan(0, 8, 0, 0, 0), 309, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1001, "Martes", new TimeSpan(0, 11, 0, 0, 0), 501, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1002, "Lunes", new TimeSpan(0, 16, 0, 0, 0), 502, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1003, "Miercoles", new TimeSpan(0, 16, 0, 0, 0), 503, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1004, "Lunes", new TimeSpan(0, 18, 0, 0, 0), 504, new TimeSpan(0, 16, 0, 0, 0) },
                    { 1005, "Lunes", new TimeSpan(0, 11, 0, 0, 0), 505, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1006, "Martes", new TimeSpan(0, 16, 0, 0, 0), 506, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1007, "Jueves", new TimeSpan(0, 16, 0, 0, 0), 507, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1008, "Viernes", new TimeSpan(0, 9, 0, 0, 0), 508, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1009, "Martes", new TimeSpan(0, 9, 0, 0, 0), 509, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1010, "Miercoles", new TimeSpan(0, 9, 0, 0, 0), 510, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1011, "Jueves", new TimeSpan(0, 9, 0, 0, 0), 511, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1012, "Lunes", new TimeSpan(0, 13, 0, 0, 0), 512, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1013, "Viernes", new TimeSpan(0, 11, 0, 0, 0), 513, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1014, "Viernes", new TimeSpan(0, 18, 0, 0, 0), 514, new TimeSpan(0, 16, 0, 0, 0) },
                    { 1015, "Miercoles", new TimeSpan(0, 13, 0, 0, 0), 515, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1016, "Viernes", new TimeSpan(0, 13, 0, 0, 0), 516, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1017, "Martes", new TimeSpan(0, 11, 0, 0, 0), 517, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1018, "Lunes", new TimeSpan(0, 16, 0, 0, 0), 518, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1019, "Miercoles", new TimeSpan(0, 16, 0, 0, 0), 519, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1020, "Miercoles", new TimeSpan(0, 18, 0, 0, 0), 520, new TimeSpan(0, 16, 0, 0, 0) },
                    { 1021, "Miercoles", new TimeSpan(0, 13, 0, 0, 0), 521, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1022, "Jueves", new TimeSpan(0, 16, 0, 0, 0), 522, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1023, "Jueves", new TimeSpan(0, 11, 0, 0, 0), 523, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1024, "Viernes", new TimeSpan(0, 16, 0, 0, 0), 524, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1025, "Jueves", new TimeSpan(0, 18, 0, 0, 0), 525, new TimeSpan(0, 16, 0, 0, 0) },
                    { 1026, "Viernes", new TimeSpan(0, 18, 0, 0, 0), 526, new TimeSpan(0, 16, 0, 0, 0) },
                    { 1027, "Jueves", new TimeSpan(0, 9, 0, 0, 0), 527, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1028, "Miercoles", new TimeSpan(0, 18, 0, 0, 0), 528, new TimeSpan(0, 16, 0, 0, 0) },
                    { 1029, "Miercoles", new TimeSpan(0, 11, 0, 0, 0), 529, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1030, "Viernes", new TimeSpan(0, 9, 0, 0, 0), 530, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1031, "Lunes", new TimeSpan(0, 13, 0, 0, 0), 531, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1032, "Martes", new TimeSpan(0, 13, 0, 0, 0), 532, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1033, "Lunes", new TimeSpan(0, 16, 0, 0, 0), 533, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1034, "Martes", new TimeSpan(0, 16, 0, 0, 0), 534, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1035, "Martes", new TimeSpan(0, 9, 0, 0, 0), 535, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1036, "Miercoles", new TimeSpan(0, 9, 0, 0, 0), 536, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1037, "Lunes", new TimeSpan(0, 11, 0, 0, 0), 537, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1038, "Viernes", new TimeSpan(0, 16, 0, 0, 0), 538, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1039, "Viernes", new TimeSpan(0, 13, 0, 0, 0), 539, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1040, "Jueves", new TimeSpan(0, 11, 0, 0, 0), 540, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1041, "Miercoles", new TimeSpan(0, 11, 0, 0, 0), 541, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1042, "Jueves", new TimeSpan(0, 18, 0, 0, 0), 542, new TimeSpan(0, 16, 0, 0, 0) },
                    { 1043, "Martes", new TimeSpan(0, 17, 0, 0, 0), 543, new TimeSpan(0, 16, 0, 0, 0) },
                    { 1044, "Lunes", new TimeSpan(0, 16, 0, 0, 0), 544, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1045, "Martes", new TimeSpan(0, 13, 0, 0, 0), 545, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1046, "Jueves", new TimeSpan(0, 16, 0, 0, 0), 546, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1047, "Miercoles", new TimeSpan(0, 16, 0, 0, 0), 547, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1048, "Martes", new TimeSpan(0, 11, 0, 0, 0), 548, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1049, "Martes", new TimeSpan(0, 18, 0, 0, 0), 549, new TimeSpan(0, 16, 0, 0, 0) },
                    { 1050, "Miercoles", new TimeSpan(0, 11, 0, 0, 0), 550, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1051, "Martes", new TimeSpan(0, 9, 0, 0, 0), 551, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1052, "Jueves", new TimeSpan(0, 9, 0, 0, 0), 552, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1053, "Martes", new TimeSpan(0, 13, 0, 0, 0), 553, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1054, "Miercoles", new TimeSpan(0, 13, 0, 0, 0), 554, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1055, "Jueves", new TimeSpan(0, 18, 0, 0, 0), 555, new TimeSpan(0, 16, 0, 0, 0) },
                    { 1056, "Lunes", new TimeSpan(0, 13, 0, 0, 0), 556, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1057, "Jueves", new TimeSpan(0, 11, 0, 0, 0), 557, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1058, "Lunes", new TimeSpan(0, 18, 0, 0, 0), 558, new TimeSpan(0, 16, 0, 0, 0) },
                    { 1059, "Miercoles", new TimeSpan(0, 16, 0, 0, 0), 559, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1060, "Martes", new TimeSpan(0, 11, 0, 0, 0), 560, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1061, "Miercoles", new TimeSpan(0, 11, 0, 0, 0), 561, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1062, "Miercoles", new TimeSpan(0, 18, 0, 0, 0), 562, new TimeSpan(0, 16, 0, 0, 0) },
                    { 1063, "Martes", new TimeSpan(0, 9, 0, 0, 0), 563, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1064, "Lunes", new TimeSpan(0, 11, 0, 0, 0), 564, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1065, "Miercoles", new TimeSpan(0, 9, 0, 0, 0), 565, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1066, "Martes", new TimeSpan(0, 16, 0, 0, 0), 566, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1067, "Martes", new TimeSpan(0, 13, 0, 0, 0), 567, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1068, "Miercoles", new TimeSpan(0, 13, 0, 0, 0), 568, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1069, "Lunes", new TimeSpan(0, 13, 0, 0, 0), 569, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1070, "Jueves", new TimeSpan(0, 11, 0, 0, 0), 570, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1071, "Lunes", new TimeSpan(0, 18, 0, 0, 0), 571, new TimeSpan(0, 16, 0, 0, 0) },
                    { 1072, "Martes", new TimeSpan(0, 9, 0, 0, 0), 572, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1073, "Miercoles", new TimeSpan(0, 9, 0, 0, 0), 573, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1074, "Lunes", new TimeSpan(0, 16, 0, 0, 0), 574, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1075, "Martes", new TimeSpan(0, 19, 0, 0, 0), 575, new TimeSpan(0, 17, 0, 0, 0) },
                    { 1076, "Miercoles", new TimeSpan(0, 19, 0, 0, 0), 575, new TimeSpan(0, 18, 0, 0, 0) },
                    { 1077, "Martes", new TimeSpan(0, 17, 0, 0, 0), 576, new TimeSpan(0, 16, 0, 0, 0) },
                    { 1078, "Miercoles", new TimeSpan(0, 18, 0, 0, 0), 576, new TimeSpan(0, 16, 0, 0, 0) },
                    { 1079, "Viernes", new TimeSpan(0, 13, 0, 0, 0), 577, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1080, "Jueves", new TimeSpan(0, 20, 0, 0, 0), 578, new TimeSpan(0, 18, 0, 0, 0) },
                    { 1081, "Lunes", new TimeSpan(0, 16, 0, 0, 0), 579, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1082, "Jueves", new TimeSpan(0, 16, 0, 0, 0), 579, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1083, "Miercoles", new TimeSpan(0, 13, 0, 0, 0), 580, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1084, "Martes", new TimeSpan(0, 11, 0, 0, 0), 581, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1085, "Miercoles", new TimeSpan(0, 9, 0, 0, 0), 581, new TimeSpan(0, 8, 0, 0, 0) },
                    { 1086, "Jueves", new TimeSpan(0, 11, 0, 0, 0), 582, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1087, "Viernes", new TimeSpan(0, 9, 0, 0, 0), 582, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1088, "Lunes", new TimeSpan(0, 11, 0, 0, 0), 583, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1089, "Martes", new TimeSpan(0, 13, 0, 0, 0), 583, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1090, "Martes", new TimeSpan(0, 9, 0, 0, 0), 584, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1091, "Viernes", new TimeSpan(0, 10, 0, 0, 0), 584, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1092, "Jueves", new TimeSpan(0, 8, 0, 0, 0), 585, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1093, "Viernes", new TimeSpan(0, 13, 0, 0, 0), 585, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1094, "Lunes", new TimeSpan(0, 9, 0, 0, 0), 586, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1095, "Jueves", new TimeSpan(0, 9, 0, 0, 0), 586, new TimeSpan(0, 8, 0, 0, 0) },
                    { 1096, "Miercoles", new TimeSpan(0, 11, 0, 0, 0), 587, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1097, "Martes", new TimeSpan(0, 12, 0, 0, 0), 588, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1098, "Miercoles", new TimeSpan(0, 12, 0, 0, 0), 589, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1099, "Lunes", new TimeSpan(0, 16, 0, 0, 0), 590, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1100, "Martes", new TimeSpan(0, 11, 0, 0, 0), 591, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1101, "Viernes", new TimeSpan(0, 9, 0, 0, 0), 592, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1102, "Jueves", new TimeSpan(0, 11, 0, 0, 0), 593, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1103, "Viernes", new TimeSpan(0, 9, 0, 0, 0), 593, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1104, "Martes", new TimeSpan(0, 18, 0, 0, 0), 594, new TimeSpan(0, 16, 0, 0, 0) },
                    { 1105, "Viernes", new TimeSpan(0, 13, 0, 0, 0), 594, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1106, "Miercoles", new TimeSpan(0, 13, 0, 0, 0), 595, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1107, "Viernes", new TimeSpan(0, 15, 0, 0, 0), 593, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1108, "Lunes", new TimeSpan(0, 11, 0, 0, 0), 597, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1109, "Martes", new TimeSpan(0, 13, 0, 0, 0), 597, new TimeSpan(0, 12, 0, 0, 0) },
                    { 1110, "Martes", new TimeSpan(0, 11, 0, 0, 0), 598, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1111, "Lunes", new TimeSpan(0, 13, 0, 0, 0), 599, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1112, "Miercoles", new TimeSpan(0, 9, 0, 0, 0), 599, new TimeSpan(0, 8, 0, 0, 0) },
                    { 1113, "Viernes", new TimeSpan(0, 11, 0, 0, 0), 599, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1114, "Martes", new TimeSpan(0, 11, 0, 0, 0), 600, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1115, "Viernes", new TimeSpan(0, 15, 0, 0, 0), 600, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1116, "Miercoles", new TimeSpan(0, 16, 0, 0, 0), 601, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1117, "Miercoles", new TimeSpan(0, 13, 0, 0, 0), 602, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1118, "Martes", new TimeSpan(0, 9, 0, 0, 0), 603, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1119, "Viernes", new TimeSpan(0, 11, 0, 0, 0), 603, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1120, "Martes", new TimeSpan(0, 13, 0, 0, 0), 604, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1121, "Jueves", new TimeSpan(0, 11, 0, 0, 0), 605, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1122, "Miercoles", new TimeSpan(0, 16, 0, 0, 0), 606, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1123, "Jueves", new TimeSpan(0, 18, 0, 0, 0), 607, new TimeSpan(0, 16, 0, 0, 0) },
                    { 1124, "Lunes", new TimeSpan(0, 13, 0, 0, 0), 608, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1125, "Martes", new TimeSpan(0, 18, 0, 0, 0), 609, new TimeSpan(0, 16, 0, 0, 0) },
                    { 1126, "Martes", new TimeSpan(0, 11, 0, 0, 0), 610, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1127, "Miercoles", new TimeSpan(0, 11, 0, 0, 0), 611, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1128, "Lunes", new TimeSpan(0, 16, 0, 0, 0), 612, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1129, "Miercoles", new TimeSpan(0, 9, 0, 0, 0), 613, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1130, "Lunes", new TimeSpan(0, 11, 0, 0, 0), 614, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1131, "Lunes", new TimeSpan(0, 18, 0, 0, 0), 615, new TimeSpan(0, 16, 0, 0, 0) },
                    { 1132, "Martes", new TimeSpan(0, 9, 0, 0, 0), 616, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1133, "Jueves", new TimeSpan(0, 9, 0, 0, 0), 616, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1134, "Martes", new TimeSpan(0, 13, 0, 0, 0), 617, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1135, "Viernes", new TimeSpan(0, 13, 0, 0, 0), 617, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1136, "Lunes", new TimeSpan(0, 9, 0, 0, 0), 618, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1137, "Miercoles", new TimeSpan(0, 9, 0, 0, 0), 618, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1138, "Lunes", new TimeSpan(0, 13, 0, 0, 0), 619, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1139, "Lunes", new TimeSpan(0, 16, 0, 0, 0), 620, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1140, "Lunes", new TimeSpan(0, 11, 0, 0, 0), 621, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1141, "Jueves", new TimeSpan(0, 11, 0, 0, 0), 621, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1142, "Miercoles", new TimeSpan(0, 16, 0, 0, 0), 622, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1143, "Viernes", new TimeSpan(0, 16, 0, 0, 0), 622, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1144, "Martes", new TimeSpan(0, 16, 0, 0, 0), 623, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1145, "Jueves", new TimeSpan(0, 16, 0, 0, 0), 623, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1146, "Martes", new TimeSpan(0, 11, 0, 0, 0), 624, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1147, "Viernes", new TimeSpan(0, 11, 0, 0, 0), 624, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1148, "Miercoles", new TimeSpan(0, 18, 0, 0, 0), 625, new TimeSpan(0, 16, 0, 0, 0) },
                    { 1149, "Viernes", new TimeSpan(0, 18, 0, 0, 0), 625, new TimeSpan(0, 16, 0, 0, 0) },
                    { 1150, "Miercoles", new TimeSpan(0, 13, 0, 0, 0), 626, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1151, "Martes", new TimeSpan(0, 11, 0, 0, 0), 627, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1152, "Lunes", new TimeSpan(0, 13, 0, 0, 0), 628, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1153, "Miercoles", new TimeSpan(0, 18, 0, 0, 0), 629, new TimeSpan(0, 16, 0, 0, 0) },
                    { 1154, "Viernes", new TimeSpan(0, 13, 0, 0, 0), 630, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1155, "Viernes", new TimeSpan(0, 16, 0, 0, 0), 631, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1156, "Martes", new TimeSpan(0, 13, 0, 0, 0), 632, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1157, "Jueves", new TimeSpan(0, 8, 0, 0, 0), 633, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1158, "Viernes", new TimeSpan(0, 10, 0, 0, 0), 634, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1159, "Miercoles", new TimeSpan(0, 15, 0, 0, 0), 635, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1160, "Lunes", new TimeSpan(0, 9, 0, 0, 0), 636, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1161, "Lunes", new TimeSpan(0, 16, 0, 0, 0), 637, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1162, "Viernes", new TimeSpan(0, 18, 0, 0, 0), 638, new TimeSpan(0, 16, 0, 0, 0) },
                    { 1163, "Martes", new TimeSpan(0, 16, 0, 0, 0), 639, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1164, "Jueves", new TimeSpan(0, 16, 0, 0, 0), 640, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1165, "Lunes", new TimeSpan(0, 18, 0, 0, 0), 641, new TimeSpan(0, 16, 0, 0, 0) },
                    { 1166, "Martes", new TimeSpan(0, 11, 0, 0, 0), 642, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1167, "Lunes", new TimeSpan(0, 13, 0, 0, 0), 643, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1168, "Miercoles", new TimeSpan(0, 18, 0, 0, 0), 644, new TimeSpan(0, 16, 0, 0, 0) },
                    { 1169, "Miercoles", new TimeSpan(0, 16, 0, 0, 0), 645, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1170, "Miercoles", new TimeSpan(0, 9, 0, 0, 0), 646, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1171, "Jueves", new TimeSpan(0, 9, 0, 0, 0), 647, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1172, "Viernes", new TimeSpan(0, 9, 0, 0, 0), 648, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1173, "Jueves", new TimeSpan(0, 16, 0, 0, 0), 649, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1174, "Lunes", new TimeSpan(0, 13, 0, 0, 0), 650, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1175, "Martes", new TimeSpan(0, 10, 0, 0, 0), 651, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1176, "Miercoles", new TimeSpan(0, 10, 0, 0, 0), 652, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1177, "Jueves", new TimeSpan(0, 10, 0, 0, 0), 653, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1178, "Martes", new TimeSpan(0, 8, 0, 0, 0), 654, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1179, "Miercoles", new TimeSpan(0, 15, 0, 0, 0), 655, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1180, "Martes", new TimeSpan(0, 9, 0, 0, 0), 656, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1181, "Jueves", new TimeSpan(0, 9, 0, 0, 0), 656, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1182, "Martes", new TimeSpan(0, 13, 0, 0, 0), 657, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1183, "Viernes", new TimeSpan(0, 13, 0, 0, 0), 657, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1184, "Lunes", new TimeSpan(0, 9, 0, 0, 0), 658, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1185, "Miercoles", new TimeSpan(0, 9, 0, 0, 0), 658, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1186, "Lunes", new TimeSpan(0, 13, 0, 0, 0), 659, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1187, "Miercoles", new TimeSpan(0, 13, 0, 0, 0), 659, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1188, "Lunes", new TimeSpan(0, 11, 0, 0, 0), 660, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1189, "Jueves", new TimeSpan(0, 11, 0, 0, 0), 660, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1190, "Lunes", new TimeSpan(0, 16, 0, 0, 0), 661, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1191, "Viernes", new TimeSpan(0, 18, 0, 0, 0), 661, new TimeSpan(0, 16, 0, 0, 0) },
                    { 1192, "Martes", new TimeSpan(0, 11, 0, 0, 0), 662, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1193, "Viernes", new TimeSpan(0, 11, 0, 0, 0), 662, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1194, "Martes", new TimeSpan(0, 16, 0, 0, 0), 663, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1195, "Miercoles", new TimeSpan(0, 16, 0, 0, 0), 663, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1196, "Jueves", new TimeSpan(0, 18, 0, 0, 0), 664, new TimeSpan(0, 16, 0, 0, 0) },
                    { 1197, "Viernes", new TimeSpan(0, 13, 0, 0, 0), 665, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1198, "Viernes", new TimeSpan(0, 16, 0, 0, 0), 666, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1199, "Miercoles", new TimeSpan(0, 16, 0, 0, 0), 667, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1200, "Martes", new TimeSpan(0, 13, 0, 0, 0), 668, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1201, "Lunes", new TimeSpan(0, 11, 0, 0, 0), 669, new TimeSpan(0, 8, 0, 0, 0) },
                    { 1202, "Lunes", new TimeSpan(0, 9, 0, 0, 0), 670, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1203, "Miercoles", new TimeSpan(0, 8, 0, 0, 0), 670, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1204, "Lunes", new TimeSpan(0, 16, 0, 0, 0), 677, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1205, "Jueves", new TimeSpan(0, 11, 0, 0, 0), 678, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1206, "Martes", new TimeSpan(0, 13, 0, 0, 0), 679, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1207, "Viernes", new TimeSpan(0, 13, 0, 0, 0), 680, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1208, "Lunes", new TimeSpan(0, 11, 0, 0, 0), 681, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1209, "Miercoles", new TimeSpan(0, 11, 0, 0, 0), 681, new TimeSpan(0, 10, 0, 0, 0) },
                    { 1210, "Miercoles", new TimeSpan(0, 16, 0, 0, 0), 682, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1211, "Viernes", new TimeSpan(0, 15, 0, 0, 0), 682, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1212, "Miercoles", new TimeSpan(0, 13, 0, 0, 0), 683, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1213, "Martes", new TimeSpan(0, 11, 0, 0, 0), 684, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1214, "Martes", new TimeSpan(0, 11, 0, 0, 0), 685, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1215, "Viernes", new TimeSpan(0, 11, 0, 0, 0), 685, new TimeSpan(0, 10, 0, 0, 0) },
                    { 1216, "Viernes", new TimeSpan(0, 9, 0, 0, 0), 686, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1217, "Martes", new TimeSpan(0, 13, 0, 0, 0), 687, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1218, "Miercoles", new TimeSpan(0, 16, 0, 0, 0), 688, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1219, "Viernes", new TimeSpan(0, 15, 0, 0, 0), 688, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1220, "Lunes", new TimeSpan(0, 11, 0, 0, 0), 689, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1221, "Miercoles", new TimeSpan(0, 9, 0, 0, 0), 689, new TimeSpan(0, 8, 0, 0, 0) },
                    { 1222, "Lunes", new TimeSpan(0, 16, 0, 0, 0), 690, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1223, "Lunes", new TimeSpan(0, 13, 0, 0, 0), 691, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1224, "Miercoles", new TimeSpan(0, 10, 0, 0, 0), 691, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1225, "Miercoles", new TimeSpan(0, 11, 0, 0, 0), 692, new TimeSpan(0, 10, 0, 0, 0) },
                    { 1226, "Viernes", new TimeSpan(0, 13, 0, 0, 0), 692, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1227, "Lunes", new TimeSpan(0, 16, 0, 0, 0), 693, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1228, "Miercoles", new TimeSpan(0, 16, 0, 0, 0), 693, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1229, "Lunes", new TimeSpan(0, 9, 0, 0, 0), 694, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1230, "Martes", new TimeSpan(0, 16, 0, 0, 0), 694, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1231, "Miercoles", new TimeSpan(0, 10, 0, 0, 0), 694, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1232, "Viernes", new TimeSpan(0, 13, 0, 0, 0), 695, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1233, "Martes", new TimeSpan(0, 9, 0, 0, 0), 696, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1234, "Viernes", new TimeSpan(0, 11, 0, 0, 0), 696, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1235, "Lunes", new TimeSpan(0, 11, 0, 0, 0), 697, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1236, "Martes", new TimeSpan(0, 11, 0, 0, 0), 698, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1237, "Jueves", new TimeSpan(0, 11, 0, 0, 0), 698, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1238, "Martes", new TimeSpan(0, 9, 0, 0, 0), 699, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1239, "Jueves", new TimeSpan(0, 10, 0, 0, 0), 699, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1240, "Martes", new TimeSpan(0, 13, 0, 0, 0), 700, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1241, "Miercoles", new TimeSpan(0, 13, 0, 0, 0), 701, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1242, "Miercoles", new TimeSpan(0, 9, 0, 0, 0), 702, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1243, "Jueves", new TimeSpan(0, 16, 0, 0, 0), 702, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1244, "Lunes", new TimeSpan(0, 13, 0, 0, 0), 703, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1245, "Martes", new TimeSpan(0, 10, 0, 0, 0), 703, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1246, "Viernes", new TimeSpan(0, 9, 0, 0, 0), 704, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1247, "Miercoles", new TimeSpan(0, 15, 0, 0, 0), 705, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1248, "Viernes", new TimeSpan(0, 16, 0, 0, 0), 705, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1249, "Lunes", new TimeSpan(0, 11, 0, 0, 0), 706, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1250, "Miercoles", new TimeSpan(0, 10, 0, 0, 0), 706, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1251, "Martes", new TimeSpan(0, 12, 0, 0, 0), 707, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1252, "Jueves", new TimeSpan(0, 9, 0, 0, 0), 707, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1253, "Martes", new TimeSpan(0, 13, 0, 0, 0), 708, new TimeSpan(0, 12, 0, 0, 0) },
                    { 1254, "Miercoles", new TimeSpan(0, 13, 0, 0, 0), 708, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1255, "Martes", new TimeSpan(0, 11, 0, 0, 0), 709, new TimeSpan(0, 10, 0, 0, 0) },
                    { 1256, "Jueves", new TimeSpan(0, 9, 0, 0, 0), 709, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1257, "Lunes", new TimeSpan(0, 11, 0, 0, 0), 710, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1258, "Miercoles", new TimeSpan(0, 10, 30, 0, 0), 710, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1259, "Miercoles", new TimeSpan(0, 11, 30, 0, 0), 711, new TimeSpan(0, 10, 0, 0, 0) },
                    { 1260, "Viernes", new TimeSpan(0, 11, 0, 0, 0), 711, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1261, "Martes", new TimeSpan(0, 16, 0, 0, 0), 712, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1262, "Jueves", new TimeSpan(0, 15, 0, 0, 0), 712, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1263, "Lunes", new TimeSpan(0, 16, 0, 0, 0), 713, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1264, "Lunes", new TimeSpan(0, 12, 0, 0, 0), 714, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1265, "Jueves", new TimeSpan(0, 11, 0, 0, 0), 715, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1267, "Martes", new TimeSpan(0, 16, 0, 0, 0), 716, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1268, "Martes", new TimeSpan(0, 10, 0, 0, 0), 717, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1269, "Miercoles", new TimeSpan(0, 15, 0, 0, 0), 718, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1270, "Miercoles", new TimeSpan(0, 8, 0, 0, 0), 719, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1271, "Lunes", new TimeSpan(0, 13, 0, 0, 0), 720, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1272, "Jueves", new TimeSpan(0, 9, 0, 0, 0), 720, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1273, "Miercoles", new TimeSpan(0, 13, 0, 0, 0), 721, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1274, "Jueves", new TimeSpan(0, 11, 0, 0, 0), 722, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1275, "Martes", new TimeSpan(0, 9, 0, 0, 0), 722, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1276, "Miercoles", new TimeSpan(0, 9, 0, 0, 0), 722, new TimeSpan(0, 8, 0, 0, 0) },
                    { 1277, "Martes", new TimeSpan(0, 10, 0, 0, 0), 723, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1278, "Viernes", new TimeSpan(0, 9, 0, 0, 0), 723, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1279, "Jueves", new TimeSpan(0, 16, 0, 0, 0), 723, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1280, "Jueves", new TimeSpan(0, 18, 0, 0, 0), 724, new TimeSpan(0, 16, 0, 0, 0) },
                    { 1281, "Viernes", new TimeSpan(0, 13, 0, 0, 0), 725, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1282, "Viernes", new TimeSpan(0, 9, 0, 0, 0), 726, new TimeSpan(0, 7, 0, 0, 0) },
                    { 1283, "Jueves", new TimeSpan(0, 16, 0, 0, 0), 726, new TimeSpan(0, 14, 0, 0, 0) },
                    { 1284, "Lunes", new TimeSpan(0, 13, 0, 0, 0), 727, new TimeSpan(0, 11, 0, 0, 0) },
                    { 1285, "Martes", new TimeSpan(0, 11, 0, 0, 0), 728, new TimeSpan(0, 9, 0, 0, 0) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Building_code",
                table: "Building",
                column: "code",
                filter: "isDeleted = 'false'");

            migrationBuilder.CreateIndex(
                name: "IX_Calendar_period",
                table: "Calendar",
                column: "period",
                filter: "isDeleted = 'false'");

            migrationBuilder.CreateIndex(
                name: "IX_Classroom_buildingId",
                table: "Classroom",
                column: "buildingId");

            migrationBuilder.CreateIndex(
                name: "IX_Floor_BuildingId",
                table: "Floor",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_Group_calendarId",
                table: "Group",
                column: "calendarId");

            migrationBuilder.CreateIndex(
                name: "IX_Group_classroomId",
                table: "Group",
                column: "classroomId");

            migrationBuilder.CreateIndex(
                name: "IX_Group_subjectId",
                table: "Group",
                column: "subjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Session_groupId",
                table: "Session",
                column: "groupId");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_code",
                table: "Subject",
                column: "code",
                unique: true,
                filter: "isDeleted = 'false'");

            migrationBuilder.CreateIndex(
                name: "IX_User_email",
                table: "User",
                column: "email",
                unique: true,
                filter: "isDeleted = 'false'");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Floor");

            migrationBuilder.DropTable(
                name: "Session");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "Calendar");

            migrationBuilder.DropTable(
                name: "Classroom");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DropTable(
                name: "Building");
        }
    }
}
