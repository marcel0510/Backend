using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class DB : Migration
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
                    createdById = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 5, 14, 18, 54, 0, 682, DateTimeKind.Local).AddTicks(7385)),
                    deletedById = table.Column<int>(type: "int", nullable: true),
                    deletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    updatedById = table.Column<int>(type: "int", nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Building", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    name = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: false),
                    NumHours = table.Column<int>(type: "int", nullable: false),
                    NumCredits = table.Column<int>(type: "int", nullable: false),
                    NumSemester = table.Column<int>(type: "int", nullable: false),
                    IsLab = table.Column<bool>(type: "bit", nullable: false),
                    createdById = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 5, 14, 18, 54, 0, 683, DateTimeKind.Local).AddTicks(5159)),
                    deletedById = table.Column<int>(type: "int", nullable: true),
                    deletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    updatedById = table.Column<int>(type: "int", nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    password = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    role = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    createdById = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 5, 14, 18, 54, 0, 683, DateTimeKind.Local).AddTicks(6610)),
                    deletedById = table.Column<int>(type: "int", nullable: true),
                    deletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    updatedById = table.Column<int>(type: "int", nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    createdById = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 5, 14, 18, 54, 0, 682, DateTimeKind.Local).AddTicks(9208)),
                    deletedById = table.Column<int>(type: "int", nullable: true),
                    deletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    updatedById = table.Column<int>(type: "int", nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                name: "Group",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    subjectId = table.Column<int>(type: "int", nullable: false),
                    classroomId = table.Column<int>(type: "int", nullable: false),
                    createdById = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 5, 14, 18, 54, 0, 683, DateTimeKind.Local).AddTicks(1401)),
                    deletedById = table.Column<int>(type: "int", nullable: true),
                    deletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    updatedById = table.Column<int>(type: "int", nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.id);
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
                    createdById = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 5, 14, 18, 54, 0, 683, DateTimeKind.Local).AddTicks(3492)),
                    deletedById = table.Column<int>(type: "int", nullable: true),
                    deletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    updatedById = table.Column<int>(type: "int", nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                columns: new[] { "id", "code", "name", "deletedById", "deletedDate", "updatedById", "updatedDate" },
                values: new object[,]
                {
                    { 1, "E16", "Edificio de Eléctrica", null, null, null, null },
                    { 2, "E17", "Edificio de Química/Eléctrica", null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "id", "code", "IsLab", "name", "NumCredits", "NumHours", "NumSemester", "deletedById", "deletedDate", "updatedById", "updatedDate" },
                values: new object[,]
                {
                    { 1, "ITID843", false, "ADMINISTRACION DE REDES", 3, 4, 8, null, null, null, null },
                    { 2, "ITID822", false, "EVALUACION DE REDES", 3, 4, 8, null, null, null, null },
                    { 3, "ITID801", false, "HACKING ETICO", 2, 3, 8, null, null, null, null },
                    { 4, "ITID832", false, "REDES DE AREA LOCAL INALAMBRICAS", 3, 3, 8, null, null, null, null },
                    { 5, "ITID753", false, "APLICACIONES WEB Y MOVILES", 3, 4, 7, null, null, null, null },
                    { 6, "ITID742", false, "REDES E INTRANETS", 3, 4, 7, null, null, null, null },
                    { 7, "ITID713", false, "APLICACIONES DISTRIBUIDAS", 2, 3, 7, null, null, null, null },
                    { 8, "ITID623", false, "REDES DE AREA LOCAL", 2, 3, 6, null, null, null, null },
                    { 9, "ITID623L", true, "LABORATORIO REDES DE AREA LOCAL", 2, 2, 6, null, null, null, null },
                    { 10, "ITID723", false, "REDES DE AREA EXTENDIDA", 2, 3, 6, null, null, null, null },
                    { 11, "ITID723L", true, "LABORATORIO REDES DE AREA LOCAL", 2, 2, 6, null, null, null, null },
                    { 12, "ITID524", false, "TRANSMISION DIGITAL", 2, 2, 5, null, null, null, null },
                    { 13, "ITID524L", true, "LABORATORIO TRANSMISION DIGITAL", 2, 2, 5, null, null, null, null },
                    { 14, "ITID452", false, "SISTEMAS OPERATIVOS", 3, 3, 4, null, null, null, null },
                    { 15, "ITID433", false, "PROGRAMACION AVANZADA", 2, 3, 4, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "id", "email", "name", "password", "role", "deletedById", "deletedDate", "updatedById", "updatedDate" },
                values: new object[] { 1, "admin@gmail.com", "Admin", "password", "Admin", null, null, null, null });

            migrationBuilder.InsertData(
                table: "Classroom",
                columns: new[] { "id", "buildingId", "Capacity", "code", "floor", "isLab", "name", "deletedById", "deletedDate", "updatedById", "updatedDate" },
                values: new object[,]
                {
                    { 1, 2, 25, "E023", "P6", true, "Laboratorioa FIEE CEC 1", null, null, null, null },
                    { 2, 2, 35, "E028", "P5", false, null, null, null, null, null },
                    { 3, 2, 25, "E026", "P6", true, "Laboratorio FIEE CEC 2", null, null, null, null },
                    { 4, 1, 20, "E002", "P2", false, null, null, null, null, null },
                    { 5, 2, 20, "LABINTC", "P7", true, "LABORATORIO DE INTERCONECTIVIDAD", null, null, null, null },
                    { 6, 1, 20, "E003", "P2", false, null, null, null, null, null },
                    { 7, 2, 20, "E022", "P6", false, null, null, null, null, null },
                    { 8, 2, 20, "E022", "P3", false, null, null, null, null, null },
                    { 9, 1, 20, "E001", "P2", false, null, null, null, null, null },
                    { 10, 2, 20, "E004", "P7", false, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Group",
                columns: new[] { "id", "classroomId", "name", "subjectId", "deletedById", "deletedDate", "updatedById", "updatedDate" },
                values: new object[,]
                {
                    { 1, 1, "GR1", 1, null, null, null, null },
                    { 2, 2, "GR1", 2, null, null, null, null },
                    { 3, 3, "GR1", 3, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Session",
                columns: new[] { "id", "day", "endTime", "groupId", "startTime", "deletedById", "deletedDate", "updatedById", "updatedDate" },
                values: new object[,]
                {
                    { 1, "Lunes", new TimeSpan(0, 11, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0), null, null, null, null },
                    { 2, "Martes", new TimeSpan(0, 13, 0, 0, 0), 1, new TimeSpan(0, 11, 0, 0, 0), null, null, null, null },
                    { 3, "Lunes", new TimeSpan(0, 13, 0, 0, 0), 2, new TimeSpan(0, 11, 0, 0, 0), null, null, null, null },
                    { 4, "Jueves", new TimeSpan(0, 9, 0, 0, 0), 2, new TimeSpan(0, 7, 0, 0, 0), null, null, null, null },
                    { 5, "Martes", new TimeSpan(0, 11, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0), null, null, null, null },
                    { 6, "Viernes", new TimeSpan(0, 11, 0, 0, 0), 3, new TimeSpan(0, 10, 0, 0, 0), null, null, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Building_code",
                table: "Building",
                column: "code",
                unique: true,
                filter: "isDeleted = 'false'");

            migrationBuilder.CreateIndex(
                name: "IX_Classroom_buildingId",
                table: "Classroom",
                column: "buildingId");

            migrationBuilder.CreateIndex(
                name: "IX_Classroom_code_floor",
                table: "Classroom",
                columns: new[] { "code", "floor" },
                filter: "isDeleted = 'false'");

            migrationBuilder.CreateIndex(
                name: "IX_Group_classroomId",
                table: "Group",
                column: "classroomId");

            migrationBuilder.CreateIndex(
                name: "IX_Group_name_subjectId",
                table: "Group",
                columns: new[] { "name", "subjectId" },
                unique: true,
                filter: "isDeleted = 'false'");

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
                name: "Session");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "Classroom");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DropTable(
                name: "Building");
        }
    }
}
