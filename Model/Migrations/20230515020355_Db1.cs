using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class Db1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "createdDate",
                table: "User",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 5, 14, 21, 3, 55, 516, DateTimeKind.Local).AddTicks(2406),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 5, 14, 18, 54, 0, 683, DateTimeKind.Local).AddTicks(6610));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdDate",
                table: "Subject",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 5, 14, 21, 3, 55, 516, DateTimeKind.Local).AddTicks(1041),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 5, 14, 18, 54, 0, 683, DateTimeKind.Local).AddTicks(5159));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdDate",
                table: "Session",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(8642),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 5, 14, 18, 54, 0, 683, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdDate",
                table: "Group",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(6797),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 5, 14, 18, 54, 0, 683, DateTimeKind.Local).AddTicks(1401));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdDate",
                table: "Classroom",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(4839),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 5, 14, 18, 54, 0, 682, DateTimeKind.Local).AddTicks(9208));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdDate",
                table: "Building",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(3112),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 5, 14, 18, 54, 0, 682, DateTimeKind.Local).AddTicks(7385));

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "id",
                keyValue: 1,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(3112));

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "id",
                keyValue: 2,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(3112));

            migrationBuilder.UpdateData(
                table: "Classroom",
                keyColumn: "id",
                keyValue: 1,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "Classroom",
                keyColumn: "id",
                keyValue: 2,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "Classroom",
                keyColumn: "id",
                keyValue: 3,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "Classroom",
                keyColumn: "id",
                keyValue: 4,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "Classroom",
                keyColumn: "id",
                keyValue: 5,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "Classroom",
                keyColumn: "id",
                keyValue: 6,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "Classroom",
                keyColumn: "id",
                keyValue: 7,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "Classroom",
                keyColumn: "id",
                keyValue: 8,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "Classroom",
                keyColumn: "id",
                keyValue: 9,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "Classroom",
                keyColumn: "id",
                keyValue: 10,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "id",
                keyValue: 1,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "id",
                keyValue: 2,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "id",
                keyValue: 3,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(6797));

            migrationBuilder.InsertData(
                table: "Group",
                columns: new[] { "id", "classroomId", "name", "subjectId", "deletedById", "deletedDate", "updatedById", "updatedDate" },
                values: new object[,]
                {
                    { 4, 4, "GR1", 6, null, null, null, null },
                    { 5, 4, "GR1", 7, null, null, null, null },
                    { 6, 4, "GR1", 4, null, null, null, null },
                    { 7, 4, "GR1", 14, null, null, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "id",
                keyValue: 1,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "id",
                keyValue: 2,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "id",
                keyValue: 3,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "id",
                keyValue: 4,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "id",
                keyValue: 5,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "id",
                keyValue: 6,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 1,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 516, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 2,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 516, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 3,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 516, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 4,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 516, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 5,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 516, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 6,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 516, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 7,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 516, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 8,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 516, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 9,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 516, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 10,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 516, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 11,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 516, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 12,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 516, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 13,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 516, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 14,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 516, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 15,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 516, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "id",
                keyValue: 1,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 516, DateTimeKind.Local).AddTicks(2406));

            migrationBuilder.InsertData(
                table: "Session",
                columns: new[] { "id", "day", "endTime", "groupId", "startTime", "deletedById", "deletedDate", "updatedById", "updatedDate" },
                values: new object[,]
                {
                    { 7, "Lunes", new TimeSpan(0, 11, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0), null, null, null, null },
                    { 8, "Martes", new TimeSpan(0, 13, 0, 0, 0), 4, new TimeSpan(0, 12, 0, 0, 0), null, null, null, null },
                    { 9, "Jueves", new TimeSpan(0, 11, 0, 0, 0), 5, new TimeSpan(0, 9, 0, 0, 0), null, null, null, null },
                    { 10, "Viernes", new TimeSpan(0, 9, 0, 0, 0), 5, new TimeSpan(0, 7, 0, 0, 0), null, null, null, null },
                    { 11, "Viernes", new TimeSpan(0, 13, 0, 0, 0), 6, new TimeSpan(0, 11, 0, 0, 0), null, null, null, null },
                    { 12, "Lunes", new TimeSpan(0, 13, 0, 0, 0), 7, new TimeSpan(0, 11, 0, 0, 0), null, null, null, null },
                    { 13, "Miercoles", new TimeSpan(0, 9, 0, 0, 0), 7, new TimeSpan(0, 8, 0, 0, 0), null, null, null, null },
                    { 14, "Viernes", new TimeSpan(0, 11, 0, 0, 0), 7, new TimeSpan(0, 9, 0, 0, 0), null, null, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdDate",
                table: "User",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 5, 14, 18, 54, 0, 683, DateTimeKind.Local).AddTicks(6610),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 5, 14, 21, 3, 55, 516, DateTimeKind.Local).AddTicks(2406));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdDate",
                table: "Subject",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 5, 14, 18, 54, 0, 683, DateTimeKind.Local).AddTicks(5159),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 5, 14, 21, 3, 55, 516, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdDate",
                table: "Session",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 5, 14, 18, 54, 0, 683, DateTimeKind.Local).AddTicks(3492),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdDate",
                table: "Group",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 5, 14, 18, 54, 0, 683, DateTimeKind.Local).AddTicks(1401),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(6797));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdDate",
                table: "Classroom",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 5, 14, 18, 54, 0, 682, DateTimeKind.Local).AddTicks(9208),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(4839));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdDate",
                table: "Building",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 5, 14, 18, 54, 0, 682, DateTimeKind.Local).AddTicks(7385),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(3112));

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "id",
                keyValue: 1,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 18, 54, 0, 682, DateTimeKind.Local).AddTicks(7385));

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "id",
                keyValue: 2,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 18, 54, 0, 682, DateTimeKind.Local).AddTicks(7385));

            migrationBuilder.UpdateData(
                table: "Classroom",
                keyColumn: "id",
                keyValue: 1,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 18, 54, 0, 682, DateTimeKind.Local).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "Classroom",
                keyColumn: "id",
                keyValue: 2,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 18, 54, 0, 682, DateTimeKind.Local).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "Classroom",
                keyColumn: "id",
                keyValue: 3,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 18, 54, 0, 682, DateTimeKind.Local).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "Classroom",
                keyColumn: "id",
                keyValue: 4,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 18, 54, 0, 682, DateTimeKind.Local).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "Classroom",
                keyColumn: "id",
                keyValue: 5,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 18, 54, 0, 682, DateTimeKind.Local).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "Classroom",
                keyColumn: "id",
                keyValue: 6,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 18, 54, 0, 682, DateTimeKind.Local).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "Classroom",
                keyColumn: "id",
                keyValue: 7,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 18, 54, 0, 682, DateTimeKind.Local).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "Classroom",
                keyColumn: "id",
                keyValue: 8,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 18, 54, 0, 682, DateTimeKind.Local).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "Classroom",
                keyColumn: "id",
                keyValue: 9,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 18, 54, 0, 682, DateTimeKind.Local).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "Classroom",
                keyColumn: "id",
                keyValue: 10,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 18, 54, 0, 682, DateTimeKind.Local).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "id",
                keyValue: 1,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 18, 54, 0, 683, DateTimeKind.Local).AddTicks(1401));

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "id",
                keyValue: 2,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 18, 54, 0, 683, DateTimeKind.Local).AddTicks(1401));

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "id",
                keyValue: 3,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 18, 54, 0, 683, DateTimeKind.Local).AddTicks(1401));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "id",
                keyValue: 1,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 18, 54, 0, 683, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "id",
                keyValue: 2,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 18, 54, 0, 683, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "id",
                keyValue: 3,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 18, 54, 0, 683, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "id",
                keyValue: 4,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 18, 54, 0, 683, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "id",
                keyValue: 5,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 18, 54, 0, 683, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "id",
                keyValue: 6,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 18, 54, 0, 683, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 1,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 18, 54, 0, 683, DateTimeKind.Local).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 2,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 18, 54, 0, 683, DateTimeKind.Local).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 3,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 18, 54, 0, 683, DateTimeKind.Local).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 4,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 18, 54, 0, 683, DateTimeKind.Local).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 5,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 18, 54, 0, 683, DateTimeKind.Local).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 6,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 18, 54, 0, 683, DateTimeKind.Local).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 7,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 18, 54, 0, 683, DateTimeKind.Local).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 8,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 18, 54, 0, 683, DateTimeKind.Local).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 9,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 18, 54, 0, 683, DateTimeKind.Local).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 10,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 18, 54, 0, 683, DateTimeKind.Local).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 11,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 18, 54, 0, 683, DateTimeKind.Local).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 12,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 18, 54, 0, 683, DateTimeKind.Local).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 13,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 18, 54, 0, 683, DateTimeKind.Local).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 14,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 18, 54, 0, 683, DateTimeKind.Local).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 15,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 18, 54, 0, 683, DateTimeKind.Local).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "id",
                keyValue: 1,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 18, 54, 0, 683, DateTimeKind.Local).AddTicks(6610));
        }
    }
}
