using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LiftTracker.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDb4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "ExerciseNumber", "SessionNumber" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "ExerciseNumber", "SessionNumber" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "ExerciseNumber", "SessionNumber" },
                values: new object[] { 1, 2 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "ExerciseNumber", "SessionNumber" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "ExerciseNumber", "SessionNumber" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "ExerciseNumber", "SessionNumber" },
                values: new object[] { 2, 1 });
        }
    }
}
