using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LiftTracker.Migrations
{
    /// <inheritdoc />
    public partial class UpdateExerciseNames6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Comp Bench Press");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Touch-And-Go Bench Press");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
