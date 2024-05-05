using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LiftTracker.Migrations
{
    /// <inheritdoc />
    public partial class UpdateExercisesAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DropColumn(
                name: "ExerciseNumber",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "ExerciseType",
                table: "Exercises");

            migrationBuilder.RenameColumn(
                name: "SessionNumber",
                table: "Exercises",
                newName: "EquipmentType");

            migrationBuilder.AddColumn<int>(
                name: "RepRange",
                table: "SessionExercises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsCompetition",
                table: "Exercises",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "ApplicationUserId", "EquipmentType", "IsCompetition", "IsCompound", "MuscleGroup", "Name" },
                values: new object[,]
                {
                    { 1, null, 0, true, true, 0, "Bench Press" },
                    { 2, null, 0, false, true, 0, "Incline Bench Press" },
                    { 3, null, 1, false, true, 0, "Incline DB Bench Press" },
                    { 4, null, 2, false, true, 0, "Dips" },
                    { 5, null, 4, false, false, 0, "Pec Deck" },
                    { 6, null, 1, false, false, 0, "Incline Fly" },
                    { 7, null, 3, false, false, 2, "Rope Pushdown" },
                    { 8, null, 4, false, false, 2, "Machine Tricep Extension" },
                    { 9, null, 0, false, false, 2, "Skullcrusher" },
                    { 10, null, 1, false, false, 2, "DB Overhead Extension" },
                    { 11, null, 1, false, true, 1, "DB Shoulder Press" },
                    { 12, null, 5, false, true, 1, "Hammer Strength Shoulder Press" },
                    { 13, null, 1, false, false, 1, "DB Lateral Raise" },
                    { 14, null, 4, false, false, 1, "Machine Lateral Raise" },
                    { 15, null, 1, false, true, 3, "DB Row" },
                    { 16, null, 3, false, true, 3, "Neutral Grip Pulldowns" },
                    { 17, null, 2, false, true, 3, "Chin-Ups" },
                    { 18, null, 5, false, true, 3, "Hammer Strength Row" },
                    { 19, null, 1, false, false, 4, "Hammer Curl" },
                    { 20, null, 5, false, false, 4, "Preacher Curl" },
                    { 21, null, 0, false, false, 4, "Barbell Curl" },
                    { 22, null, 3, false, false, 4, "Cable Curl" },
                    { 23, null, 4, false, false, 5, "Reverse Pec Deck" },
                    { 24, null, 1, false, false, 5, "DB Shrugs" },
                    { 25, null, 3, false, false, 5, "Face Pull" },
                    { 26, null, 0, false, false, 5, "Barbell Shrugs" },
                    { 27, null, 0, true, true, 6, "Low Bar Squat" },
                    { 28, null, 0, false, true, 6, "High Bar Squat" },
                    { 29, null, 5, false, true, 6, "Hack Squat" },
                    { 30, null, 1, false, true, 6, "Split Squat" },
                    { 31, null, 5, false, false, 6, "Single Leg Extension" },
                    { 32, null, 4, false, false, 6, "Leg Extension" },
                    { 33, null, 0, true, true, 7, "Sumo Deadlift" },
                    { 34, null, 0, false, true, 7, "Conventional Deadlift" },
                    { 35, null, 1, false, true, 7, "DB RDL" },
                    { 36, null, 2, false, true, 7, "Back Raise" },
                    { 37, null, 5, false, false, 7, "Leg Curl" },
                    { 38, null, 4, false, false, 7, "Lying Leg Curl" },
                    { 39, null, 4, false, false, 8, "Standing Calf Raise" },
                    { 40, null, 5, false, false, 8, "Seated Calf Raise" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SessionExercises_ExerciseId",
                table: "SessionExercises",
                column: "ExerciseId");

            migrationBuilder.AddForeignKey(
                name: "FK_SessionExercises_Exercises_ExerciseId",
                table: "SessionExercises",
                column: "ExerciseId",
                principalTable: "Exercises",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SessionExercises_Exercises_ExerciseId",
                table: "SessionExercises");

            migrationBuilder.DropIndex(
                name: "IX_SessionExercises_ExerciseId",
                table: "SessionExercises");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DropColumn(
                name: "RepRange",
                table: "SessionExercises");

            migrationBuilder.DropColumn(
                name: "IsCompetition",
                table: "Exercises");

            migrationBuilder.RenameColumn(
                name: "EquipmentType",
                table: "Exercises",
                newName: "SessionNumber");

            migrationBuilder.AddColumn<int>(
                name: "ExerciseNumber",
                table: "Exercises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExerciseType",
                table: "Exercises",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "ApplicationUserId", "ExerciseNumber", "ExerciseType", "IsCompound", "MuscleGroup", "Name", "SessionNumber" },
                values: new object[,]
                {
                    { 101, null, 1, 0, true, 0, "Paused Bench Press", 1 },
                    { 102, null, 1, 3, true, 0, "Technique Sets Paused Bench Press", 2 },
                    { 103, null, 1, 1, true, 0, "Incline Bench Press", 1 },
                    { 104, null, 1, 1, true, 0, "Touch-and-Go Bench Press", 2 },
                    { 105, null, 1, 2, true, 0, "Incline DB Bench Press", 1 },
                    { 106, null, 1, 2, true, 0, "DB Bench Press", 2 },
                    { 107, null, 2, 2, false, 0, "Pec Deck", 1 },
                    { 108, null, 2, 2, false, 0, "Incline Fly", 2 },
                    { 109, null, 1, 2, false, 2, "Rope Pushdown", 1 },
                    { 110, null, 2, 2, false, 2, "Overhead Rope Extension", 1 },
                    { 111, null, 1, 2, false, 2, "Skullcrusher", 2 },
                    { 112, null, 2, 2, false, 2, "DB Overhead Extension", 2 },
                    { 113, null, 1, 0, true, 1, "Paused Military Press", 2 },
                    { 114, null, 1, 3, true, 1, "Technique Sets Paused Military Press", 1 },
                    { 115, null, 1, 1, true, 1, "Seated Military Press", 1 },
                    { 116, null, 1, 1, true, 1, "Touch-And-Go Military Press", 2 },
                    { 117, null, 1, 2, true, 1, "DB Shoulder Press", 1 },
                    { 118, null, 1, 2, true, 1, "Hammer Strength Shoulder Press", 2 },
                    { 119, null, 2, 2, false, 1, "DB Lateral Raise", 1 },
                    { 120, null, 2, 2, false, 1, "Machine Lateral Raise", 2 },
                    { 121, null, 1, 2, true, 3, "DB Row", 1 },
                    { 122, null, 2, 2, true, 3, "Neutral Grip Pulldowns", 1 },
                    { 123, null, 1, 2, true, 3, "Chin-Ups", 2 },
                    { 124, null, 2, 2, true, 3, "Hammer Strength Row", 2 },
                    { 125, null, 1, 2, false, 4, "Hammer Curl", 1 },
                    { 126, null, 2, 2, false, 4, "Preacher Curl", 1 },
                    { 127, null, 1, 2, false, 4, "Barbell Curl", 2 },
                    { 128, null, 2, 2, false, 4, "Cable Curl", 2 },
                    { 129, null, 1, 2, false, 5, "Reverse Pec Deck", 1 },
                    { 130, null, 2, 2, false, 5, "DB Shrugs", 1 },
                    { 131, null, 1, 2, false, 5, "Face Pull", 2 },
                    { 132, null, 2, 2, false, 5, "Smith Machine Shrugs", 2 },
                    { 133, null, 1, 0, true, 6, "Low Bar Squat", 1 },
                    { 134, null, 1, 3, true, 6, "Technique Low Bar Squat", 2 },
                    { 135, null, 1, 2, true, 6, "Hack Squat", 1 },
                    { 140, null, 1, 2, true, 6, "Leg Press", 2 },
                    { 141, null, 1, 1, true, 6, "High Bar Squat", 1 },
                    { 142, null, 1, 1, true, 6, "Front Squat", 2 },
                    { 143, null, 2, 2, false, 6, "Single Leg Extension", 1 },
                    { 144, null, 2, 2, false, 6, "Leg Extension", 2 },
                    { 145, null, 1, 3, true, 7, "Technique Sumo Deadlift", 1 },
                    { 146, null, 1, 0, true, 7, "Sumo Deadlift", 2 },
                    { 147, null, 1, 1, true, 7, "RDL", 1 },
                    { 148, null, 1, 1, true, 7, "Conventional Deadlift", 2 },
                    { 149, null, 1, 2, true, 7, "Hip Thurst", 2 },
                    { 150, null, 1, 2, true, 7, "Back Raise", 1 },
                    { 151, null, 2, 2, false, 7, "Leg Curl", 1 },
                    { 152, null, 2, 2, false, 7, "Lying Leg Curl", 2 },
                    { 153, null, 1, 2, false, 8, "Standing Calf Raise", 1 },
                    { 154, null, 2, 2, false, 8, "Seated Calf Raise", 1 },
                    { 155, null, 1, 2, false, 8, "Hammer Strength Calf Raise", 2 },
                    { 156, null, 2, 2, false, 8, "Seated Calf Extension", 2 }
                });
        }
    }
}
