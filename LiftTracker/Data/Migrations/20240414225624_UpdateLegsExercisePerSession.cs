using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LiftTracker.Migrations
{
    /// <inheritdoc />
    public partial class UpdateLegsExercisePerSession : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7,
                column: "ExercisesPerSession",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8,
                column: "ExercisesPerSession",
                value: 1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7,
                column: "ExercisesPerSession",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8,
                column: "ExercisesPerSession",
                value: 2);
        }
    }
}
