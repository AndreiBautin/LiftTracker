using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LiftTracker.Migrations
{
    /// <inheritdoc />
    public partial class UpdateExerciseNames7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11,
                column: "Frequency",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12,
                column: "Frequency",
                value: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11,
                column: "Frequency",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12,
                column: "Frequency",
                value: 1);
        }
    }
}
