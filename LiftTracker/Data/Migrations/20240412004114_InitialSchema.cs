using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LiftTracker.Migrations
{
    /// <inheritdoc />
    public partial class InitialSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MuscleGroupId = table.Column<int>(type: "int", nullable: true),
                    ExerciseType = table.Column<int>(type: "int", nullable: true),
                    IsCompound = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MacroCycles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsComplete = table.Column<bool>(type: "bit", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MacroCycles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MacroCycles_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MuscleGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MV = table.Column<int>(type: "int", nullable: false),
                    MEV = table.Column<int>(type: "int", nullable: false),
                    MRV = table.Column<int>(type: "int", nullable: false),
                    MuscleGroupEnum = table.Column<int>(type: "int", nullable: false),
                    Frequency = table.Column<int>(type: "int", nullable: false),
                    ExercisesPerSession = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MuscleGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RepRanges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RepRangeType = table.Column<int>(type: "int", nullable: false),
                    Low = table.Column<int>(type: "int", nullable: false),
                    High = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepRanges", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrainingBlocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MacroCycleId = table.Column<int>(type: "int", nullable: true),
                    TrainingPhase = table.Column<int>(type: "int", nullable: false),
                    IsComplete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingBlocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingBlocks_MacroCycles_MacroCycleId",
                        column: x => x.MacroCycleId,
                        principalTable: "MacroCycles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MesoCycles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainingBlockId = table.Column<int>(type: "int", nullable: true),
                    IsComplete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MesoCycles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MesoCycles_TrainingBlocks_TrainingBlockId",
                        column: x => x.TrainingBlockId,
                        principalTable: "TrainingBlocks",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MicroCycles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MesoCycleId = table.Column<int>(type: "int", nullable: true),
                    IsComplete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MicroCycles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MicroCycles_MesoCycles_MesoCycleId",
                        column: x => x.MesoCycleId,
                        principalTable: "MesoCycles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MicroCycleId = table.Column<int>(type: "int", nullable: true),
                    DayOfTheWeek = table.Column<int>(type: "int", nullable: true),
                    IsComplete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sessions_MicroCycles_MicroCycleId",
                        column: x => x.MicroCycleId,
                        principalTable: "MicroCycles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SessionExercises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SessionId = table.Column<int>(type: "int", nullable: true),
                    ExerciseId = table.Column<int>(type: "int", nullable: true),
                    RepRangeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SessionExercises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SessionExercises_Sessions_SessionId",
                        column: x => x.SessionId,
                        principalTable: "Sessions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Sets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SessionExerciseId = table.Column<int>(type: "int", nullable: true),
                    Load = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Reps = table.Column<int>(type: "int", nullable: true),
                    TargetRpe = table.Column<int>(type: "int", nullable: true),
                    Rpe = table.Column<int>(type: "int", nullable: true),
                    IsComplete = table.Column<bool>(type: "bit", nullable: false),
                    IsSkipped = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sets_SessionExercises_SessionExerciseId",
                        column: x => x.SessionExerciseId,
                        principalTable: "SessionExercises",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "ExerciseType", "IsCompound", "MuscleGroupId", "Name" },
                values: new object[,]
                {
                    { 1, 0, true, 1, "Flat Bench" },
                    { 2, 1, true, 1, "Incline Bench Press" },
                    { 3, 2, false, 1, "Incline Fly" },
                    { 4, 2, false, 1, "Pec Deck" },
                    { 5, 1, true, 2, "Close Grip Bench Press" },
                    { 6, 1, true, 2, "Board Press" },
                    { 7, 2, false, 2, "Rope Pushdown" },
                    { 8, 2, false, 2, "Rope Extension" },
                    { 9, 1, true, 10, "Overhead Press" },
                    { 10, 2, true, 10, "DB Shoulder Press" },
                    { 11, 2, false, 3, "DB Lateral Raise" },
                    { 12, 2, false, 3, "Machine Lateral Raise" },
                    { 13, 2, true, 4, "DB Row" },
                    { 14, 2, true, 4, "Chin-Ups" },
                    { 15, 2, true, 4, "Neutral Grip Pulldown" },
                    { 16, 2, true, 4, "Seated Row" },
                    { 17, 2, false, 5, "Hammer Curl" },
                    { 18, 2, false, 5, "DB Curl" },
                    { 19, 2, false, 5, "Preacher Curl" },
                    { 20, 2, false, 5, "Cable Curl" },
                    { 21, 2, false, 6, "Reverse Pec Deck" },
                    { 22, 2, false, 6, "Face Pull" },
                    { 23, 2, false, 11, "DB Shrugs" },
                    { 24, 2, false, 12, "DB Wrist Curl" },
                    { 25, 0, true, 7, "Low Bar Squat" },
                    { 26, 1, true, 7, "High Bar Pause Squat" },
                    { 27, 2, true, 7, "Split Squat" },
                    { 28, 2, false, 7, "Leg Extension" },
                    { 29, 0, true, 8, "Sumo Deadlift" },
                    { 30, 1, true, 8, "Paused Conventional Deadlift" },
                    { 31, 2, true, 8, "Good Morning" },
                    { 32, 2, false, 8, "Leg Curl" },
                    { 33, 2, false, 13, "Standing Calf Raise" },
                    { 34, 2, false, 13, "Seated Calf Raise" },
                    { 35, 2, false, 9, "Ab Wheel" },
                    { 36, 2, false, 9, "Weighted Decline Situp" }
                });

            migrationBuilder.InsertData(
                table: "MuscleGroups",
                columns: new[] { "Id", "ExercisesPerSession", "Frequency", "MEV", "MRV", "MV", "MuscleGroupEnum", "Name" },
                values: new object[,]
                {
                    { 1, 2, 2, 10, 20, 5, 0, "Chest" },
                    { 2, 2, 2, 10, 20, 5, 1, "Triceps" },
                    { 3, 1, 2, 10, 20, 5, 2, "Side Delts" },
                    { 4, 2, 2, 10, 20, 5, 3, "Back" },
                    { 5, 2, 2, 10, 20, 5, 4, "Biceps" },
                    { 6, 1, 2, 10, 20, 5, 5, "Rear Delts" },
                    { 7, 2, 2, 10, 20, 5, 6, "Quads" },
                    { 8, 2, 2, 10, 20, 5, 7, "Hamstrings" },
                    { 9, 1, 2, 10, 20, 5, 8, "Core" },
                    { 10, 1, 2, 10, 20, 5, 9, "Front Delts" },
                    { 11, 1, 1, 10, 20, 5, 10, "Traps" },
                    { 12, 1, 1, 10, 20, 5, 11, "Forearms" },
                    { 13, 1, 2, 10, 20, 5, 12, "Calves" }
                });

            migrationBuilder.InsertData(
                table: "RepRanges",
                columns: new[] { "Id", "High", "Low", "RepRangeType" },
                values: new object[,]
                {
                    { 1, 3, 1, 0 },
                    { 2, 6, 3, 1 },
                    { 3, 8, 6, 2 },
                    { 4, 12, 8, 3 },
                    { 5, 15, 12, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MacroCycles_ApplicationUserId",
                table: "MacroCycles",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MesoCycles_TrainingBlockId",
                table: "MesoCycles",
                column: "TrainingBlockId");

            migrationBuilder.CreateIndex(
                name: "IX_MicroCycles_MesoCycleId",
                table: "MicroCycles",
                column: "MesoCycleId");

            migrationBuilder.CreateIndex(
                name: "IX_SessionExercises_SessionId",
                table: "SessionExercises",
                column: "SessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_MicroCycleId",
                table: "Sessions",
                column: "MicroCycleId");

            migrationBuilder.CreateIndex(
                name: "IX_Sets_SessionExerciseId",
                table: "Sets",
                column: "SessionExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingBlocks_MacroCycleId",
                table: "TrainingBlocks",
                column: "MacroCycleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "MuscleGroups");

            migrationBuilder.DropTable(
                name: "RepRanges");

            migrationBuilder.DropTable(
                name: "Sets");

            migrationBuilder.DropTable(
                name: "SessionExercises");

            migrationBuilder.DropTable(
                name: "Sessions");

            migrationBuilder.DropTable(
                name: "MicroCycles");

            migrationBuilder.DropTable(
                name: "MesoCycles");

            migrationBuilder.DropTable(
                name: "TrainingBlocks");

            migrationBuilder.DropTable(
                name: "MacroCycles");
        }
    }
}
