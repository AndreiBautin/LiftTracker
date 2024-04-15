using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LiftTracker.Migrations
{
    /// <inheritdoc />
    public partial class UpdateExerciseNames3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Comp Bench");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Touch-And-Go Bench");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "DB Front Raise");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 25,
                column: "Name",
                value: "Low Bar Squat");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 26,
                column: "Name",
                value: "High Bar Squat");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 29,
                column: "Name",
                value: "Dead Stop Sumo Deadlift");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 30,
                column: "Name",
                value: "Touch-And-Go Conventional Deadlift");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Paused Comp Flat Bench");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Touch-And-Go Raw Flat Bench Press");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "DB Shoulder Press");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 25,
                column: "Name",
                value: "Comp Low Bar Squat");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 26,
                column: "Name",
                value: "Raw High Bar Squat");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 29,
                column: "Name",
                value: "Comp Sumo Deadlift");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 30,
                column: "Name",
                value: "Touch-And-Go Raw Conventional Deadlift");
        }
    }
}
