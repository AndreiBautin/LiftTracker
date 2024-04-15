using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LiftTracker.Migrations
{
    /// <inheritdoc />
    public partial class UpdateExerciseNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 26,
                column: "Name",
                value: "High Bar Squat");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 30,
                column: "Name",
                value: "Conventional Deadlift");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 26,
                column: "Name",
                value: "High Bar Pause Squat");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 30,
                column: "Name",
                value: "Paused Conventional Deadlift");
        }
    }
}
