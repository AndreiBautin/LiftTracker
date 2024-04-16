using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LiftTracker.Migrations
{
    /// <inheritdoc />
    public partial class RemoveVolumeLandmarks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExercisesPerSession",
                table: "MuscleGroups");

            migrationBuilder.DropColumn(
                name: "Frequency",
                table: "MuscleGroups");

            migrationBuilder.DropColumn(
                name: "MEV",
                table: "MuscleGroups");

            migrationBuilder.DropColumn(
                name: "MRV",
                table: "MuscleGroups");

            migrationBuilder.DropColumn(
                name: "MV",
                table: "MuscleGroups");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExercisesPerSession",
                table: "MuscleGroups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Frequency",
                table: "MuscleGroups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MEV",
                table: "MuscleGroups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MRV",
                table: "MuscleGroups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MV",
                table: "MuscleGroups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExercisesPerSession", "Frequency", "MEV", "MRV", "MV" },
                values: new object[] { 1, 2, 10, 20, 5 });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExercisesPerSession", "Frequency", "MEV", "MRV", "MV" },
                values: new object[] { 1, 2, 10, 20, 5 });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ExercisesPerSession", "Frequency", "MEV", "MRV", "MV" },
                values: new object[] { 1, 2, 10, 20, 5 });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ExercisesPerSession", "Frequency", "MEV", "MRV", "MV" },
                values: new object[] { 1, 2, 10, 20, 5 });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ExercisesPerSession", "Frequency", "MEV", "MRV", "MV" },
                values: new object[] { 1, 2, 10, 20, 5 });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ExercisesPerSession", "Frequency", "MEV", "MRV", "MV" },
                values: new object[] { 1, 2, 10, 20, 5 });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ExercisesPerSession", "Frequency", "MEV", "MRV", "MV" },
                values: new object[] { 1, 2, 10, 20, 5 });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ExercisesPerSession", "Frequency", "MEV", "MRV", "MV" },
                values: new object[] { 1, 2, 10, 20, 5 });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ExercisesPerSession", "Frequency", "MEV", "MRV", "MV" },
                values: new object[] { 1, 2, 10, 20, 5 });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ExercisesPerSession", "Frequency", "MEV", "MRV", "MV" },
                values: new object[] { 1, 2, 10, 20, 5 });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ExercisesPerSession", "Frequency", "MEV", "MRV", "MV" },
                values: new object[] { 1, 2, 10, 20, 5 });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ExercisesPerSession", "Frequency", "MEV", "MRV", "MV" },
                values: new object[] { 1, 2, 10, 20, 5 });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ExercisesPerSession", "Frequency", "MEV", "MRV", "MV" },
                values: new object[] { 1, 2, 10, 20, 5 });
        }
    }
}
