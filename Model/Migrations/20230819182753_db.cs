using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class db : Migration
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 8, 19, 13, 27, 52, 949, DateTimeKind.Local).AddTicks(4025)),
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 8, 19, 13, 27, 52, 949, DateTimeKind.Local).AddTicks(8838)),
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 8, 19, 13, 27, 52, 951, DateTimeKind.Local).AddTicks(243)),
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 8, 19, 13, 27, 52, 951, DateTimeKind.Local).AddTicks(3273)),
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 8, 19, 13, 27, 52, 950, DateTimeKind.Local).AddTicks(1696)),
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 8, 19, 13, 27, 52, 950, DateTimeKind.Local).AddTicks(5801)),
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
                    { 181, null, "ITID903", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "APLICACIONES MÓVILES AVANZADAS", 2, 96, 9, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "id", "DeletedBy", "DeletedDate", "email", "name", "password", "role", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", "Admin", "$2a$11$VAKfEJ3RGGjAEKtloqyLlOLCqZhoHrxW86gZtIsd57vCtoQJohFg.", "Admin", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

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
                    { 6, 1, 20, "E008", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P1", true, "LAB. ALTA FRECUENCIA", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 1, 12, "E018", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P1", true, "LAB. DISPOSITIVOS ELECTRONICOS", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 1, 12, "E019", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P1", true, "LAB. DISPOSITIVOS ELECTRONICOS", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 1, 4, "E020", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P1", true, "LAB.COMUNICACION ANALOGICA", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 1, 50, "E021", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P1", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 1, 8, "E001", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P2", false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 1, 16, "E001", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P2", true, "LAB. REDES 2", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
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
