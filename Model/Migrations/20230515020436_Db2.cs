using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class Db2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Group_name_subjectId",
                table: "Group");

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdDate",
                table: "User",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(8973),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 5, 14, 21, 3, 55, 516, DateTimeKind.Local).AddTicks(2406));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdDate",
                table: "Subject",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(7675),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 5, 14, 21, 3, 55, 516, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdDate",
                table: "Session",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(5996),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdDate",
                table: "Group",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(4136),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(6797));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdDate",
                table: "Classroom",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(2017),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(4839));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdDate",
                table: "Building",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(311),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(3112));

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "id",
                keyValue: 1,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "id",
                keyValue: 2,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "Classroom",
                keyColumn: "id",
                keyValue: 1,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "Classroom",
                keyColumn: "id",
                keyValue: 2,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "Classroom",
                keyColumn: "id",
                keyValue: 3,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "Classroom",
                keyColumn: "id",
                keyValue: 4,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "Classroom",
                keyColumn: "id",
                keyValue: 5,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "Classroom",
                keyColumn: "id",
                keyValue: 6,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "Classroom",
                keyColumn: "id",
                keyValue: 7,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "Classroom",
                keyColumn: "id",
                keyValue: 8,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "Classroom",
                keyColumn: "id",
                keyValue: 9,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "Classroom",
                keyColumn: "id",
                keyValue: 10,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "id",
                keyValue: 1,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "id",
                keyValue: 2,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "id",
                keyValue: 3,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "id",
                keyValue: 4,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "id",
                keyValue: 5,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "id",
                keyValue: 6,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "id",
                keyValue: 7,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "id",
                keyValue: 1,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "id",
                keyValue: 2,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "id",
                keyValue: 3,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "id",
                keyValue: 4,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "id",
                keyValue: 5,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "id",
                keyValue: 6,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "id",
                keyValue: 7,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "id",
                keyValue: 8,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "id",
                keyValue: 9,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "id",
                keyValue: 10,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "id",
                keyValue: 11,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "id",
                keyValue: 12,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "id",
                keyValue: 13,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "id",
                keyValue: 14,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 1,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 2,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 3,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 4,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 5,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 6,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 7,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 8,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 9,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 10,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 11,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 12,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 13,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 14,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "id",
                keyValue: 15,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "id",
                keyValue: 1,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(8973));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                oldDefaultValue: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(8973));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdDate",
                table: "Subject",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 5, 14, 21, 3, 55, 516, DateTimeKind.Local).AddTicks(1041),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdDate",
                table: "Session",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(8642),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(5996));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdDate",
                table: "Group",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(6797),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(4136));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdDate",
                table: "Classroom",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(4839),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(2017));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdDate",
                table: "Building",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(3112),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 5, 14, 21, 4, 36, 508, DateTimeKind.Local).AddTicks(311));

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

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "id",
                keyValue: 4,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "id",
                keyValue: 5,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "id",
                keyValue: 6,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "id",
                keyValue: 7,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(6797));

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
                table: "Session",
                keyColumn: "id",
                keyValue: 7,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "id",
                keyValue: 8,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "id",
                keyValue: 9,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "id",
                keyValue: 10,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "id",
                keyValue: 11,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "id",
                keyValue: 12,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "id",
                keyValue: 13,
                column: "createdDate",
                value: new DateTime(2023, 5, 14, 21, 3, 55, 515, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "id",
                keyValue: 14,
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

            migrationBuilder.CreateIndex(
                name: "IX_Group_name_subjectId",
                table: "Group",
                columns: new[] { "name", "subjectId" },
                unique: true,
                filter: "isDeleted = 'false'");
        }
    }
}
