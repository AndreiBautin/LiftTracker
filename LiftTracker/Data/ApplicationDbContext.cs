using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LiftTracker.Data
{
	public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
	{
		public DbSet<Exercise> Exercises { get; set; }
		public DbSet<MuscleGroup> MuscleGroups { get; set; }
		public DbSet<RepRange> RepRanges { get; set; }
		public DbSet<TrainingBlock> TrainingBlocks { get; set; }
		public DbSet<MacroCycle> MacroCycles { get; set; }
		public DbSet<MesoCycle> MesoCycles { get; set; }
		public DbSet<MicroCycle> MicroCycles { get; set; }
		public DbSet<Session> Sessions { get; set; }
		public DbSet<SessionExercise> SessionExercises { get; set; }
		public DbSet<Set> Sets { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder) {
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<MuscleGroup>().HasData(new List<MuscleGroup>() {
				new MuscleGroup(){
					Id = 1,
					Name = "Chest",
					MuscleGroupEnum = MuscleGroupEnum.Chest,
					MV = 5,
					MEV = 10,
					MRV = 20,
					Frequency = 2,
					ExercisesPerSession = 2
				},
				new MuscleGroup(){
					Id = 2,
					Name = "Triceps",
					MuscleGroupEnum= MuscleGroupEnum.Triceps,
					MV = 5,
					MEV = 10,
					MRV = 20,
					Frequency = 2,
					ExercisesPerSession = 2
				},
				new MuscleGroup(){
					Id = 3,
					Name = "Side Delts",
					MuscleGroupEnum= MuscleGroupEnum.SideDelts,
					MV = 5,
					MEV = 10,
					MRV = 20,
					Frequency = 2,
					ExercisesPerSession = 1
				},
				new MuscleGroup(){
					Id = 4,
					Name = "Back",
					MuscleGroupEnum= MuscleGroupEnum.Back,
					MV = 5,
					MEV = 10,
					MRV = 20,
					Frequency = 2,
					ExercisesPerSession = 2
				},
				new MuscleGroup(){
					Id = 5,
					Name = "Biceps",
					MuscleGroupEnum= MuscleGroupEnum.Biceps,
					MV = 5,
					MEV = 10,
					MRV = 20,
					Frequency = 2,
					ExercisesPerSession = 2
				},
				new MuscleGroup(){
					Id = 6,
					Name = "Rear Delts",
					MuscleGroupEnum= MuscleGroupEnum.RearDelts,
					MV = 5,
					MEV = 10,
					MRV = 20,
					Frequency = 2,
					ExercisesPerSession = 1
				},
				new MuscleGroup(){
					Id = 7,
					Name = "Quads",
					MuscleGroupEnum= MuscleGroupEnum.Quads,
					MV = 5,
					MEV = 10,
					MRV = 20,
					Frequency = 2,
					ExercisesPerSession = 2
				},
				new MuscleGroup(){
					Id = 8,
					Name = "Hamstrings",
					MuscleGroupEnum= MuscleGroupEnum.PosteriorChain,
					MV = 5,
					MEV = 10,
					MRV = 20,
					Frequency = 2,
					ExercisesPerSession = 2
				},
				new MuscleGroup(){
					Id = 9,
					Name = "Core",
					MuscleGroupEnum= MuscleGroupEnum.Core,
					MV = 5,
					MEV = 10,
					MRV = 20,
					Frequency = 2,
					ExercisesPerSession = 1
				},
				new MuscleGroup(){
					Id = 10,
					Name = "Front Delts",
					MuscleGroupEnum= MuscleGroupEnum.FrontDelts,
					MV = 5,
					MEV = 10,
					MRV = 20,
					Frequency = 2,
					ExercisesPerSession = 1
				},
				new MuscleGroup(){
					Id = 11,
					Name = "Traps",
					MuscleGroupEnum= MuscleGroupEnum.Traps,
					MV = 5,
					MEV = 10,
					MRV = 20,
					Frequency = 1,
					ExercisesPerSession = 1
				},
				new MuscleGroup(){
					Id = 12,
					Name = "Forearms",
					MuscleGroupEnum= MuscleGroupEnum.Forearms,
					MV = 5,
					MEV = 10,
					MRV = 20,
					Frequency = 1,
					ExercisesPerSession = 1
				},
				new MuscleGroup(){
					Id = 13,
					Name = "Calves",
					MuscleGroupEnum= MuscleGroupEnum.Calves,
					MV = 5,
					MEV = 10,
					MRV = 20,
					Frequency = 2,
					ExercisesPerSession = 1
				},
			});

			modelBuilder.Entity<Exercise>().HasData(new List<Exercise>() {
                //Chest
                new Exercise(){
					Id = 1,
					MuscleGroupId = 1,
					ExerciseType = ExerciseType.Primary,
					Name = "Flat Bench",
					IsCompound = true,
				},
				new Exercise(){
					Id = 2,
					MuscleGroupId = 1,
					ExerciseType = ExerciseType.Supplemental,
					Name = "Incline Bench Press",
					IsCompound = true,
				},
				new Exercise(){
					Id = 3,
					MuscleGroupId = 1,
					ExerciseType = ExerciseType.Accessory,
					Name = "Incline Fly",
					IsCompound = false,
				},
				new Exercise(){
					Id = 4,
					MuscleGroupId = 1,
					ExerciseType = ExerciseType.Accessory,
					Name = "Pec Deck",
					IsCompound = false,
				},

                //Triceps
                new Exercise(){
					Id = 5,
					MuscleGroupId = 2,
					ExerciseType = ExerciseType.Supplemental,
					Name = "Close Grip Bench Press",
					IsCompound = true,
				},
				new Exercise(){
					Id = 6,
					MuscleGroupId = 2,
					ExerciseType = ExerciseType.Supplemental,
					Name = "Board Press",
					IsCompound = true,
				},
				new Exercise(){
					Id = 7,
					MuscleGroupId = 2,
					ExerciseType = ExerciseType.Accessory,
					Name = "Rope Pushdown",
					IsCompound = false,
				},
				new Exercise(){
					Id = 8,
					MuscleGroupId = 2,
					ExerciseType = ExerciseType.Accessory,
					Name = "Rope Extension",
					IsCompound = false,
				},

                //Front Delts
                new Exercise(){
					Id = 9,
					MuscleGroupId = 10,
					ExerciseType = ExerciseType.Supplemental,
					Name = "Overhead Press",
					IsCompound= true,
				},
				new Exercise(){
					Id = 10,
					MuscleGroupId = 10,
					ExerciseType = ExerciseType.Accessory,
					Name = "DB Shoulder Press",
					IsCompound= true,
				},

                //Side Delts
				new Exercise(){
					Id = 11,
					MuscleGroupId = 3,
					ExerciseType = ExerciseType.Accessory,
					Name = "DB Lateral Raise",
					IsCompound = false,
				},
				new Exercise(){
					Id = 12,
					MuscleGroupId = 3,
					ExerciseType = ExerciseType.Accessory,
					Name = "Machine Lateral Raise",
					IsCompound = false,
				},

                //Back
                new Exercise(){
					Id = 13,
					MuscleGroupId = 4,
					ExerciseType = ExerciseType.Accessory,
					Name = "DB Row",
					IsCompound = true,
				},
				new Exercise(){
					Id = 14,
					MuscleGroupId = 4,
					ExerciseType = ExerciseType.Accessory,
					Name = "Chin-Ups",
					IsCompound = true,
				},
				new Exercise(){
					Id = 15,
					MuscleGroupId = 4,
					ExerciseType = ExerciseType.Accessory,
					Name = "Neutral Grip Pulldown",
					IsCompound = true,
				},
				new Exercise(){
					Id = 16,
					MuscleGroupId = 4,
					ExerciseType = ExerciseType.Accessory,
					Name = "Seated Row",
					IsCompound = true,
				},

                //Biceps
                new Exercise(){
					Id = 17,
					MuscleGroupId = 5,
					ExerciseType = ExerciseType.Accessory,
					Name = "Hammer Curl",
					IsCompound = false,
				},
				new Exercise(){
					Id = 18,
					MuscleGroupId = 5,
					ExerciseType = ExerciseType.Accessory,
					Name = "DB Curl",
					IsCompound = false,
				},
				new Exercise(){
					Id = 19,
					MuscleGroupId = 5,
					ExerciseType = ExerciseType.Accessory,
					Name = "Preacher Curl",
					IsCompound = false,
				},
				new Exercise(){
					Id = 20,
					MuscleGroupId = 5,
					ExerciseType = ExerciseType.Accessory,
					Name = "Cable Curl",
					IsCompound = false,
				},

                //Rear Delts
                new Exercise(){
					Id = 21,
					MuscleGroupId = 6,
					ExerciseType = ExerciseType.Accessory,
					Name = "Reverse Pec Deck",
					IsCompound = false,
				},
				new Exercise(){
					Id = 22,
					MuscleGroupId = 6,
					ExerciseType = ExerciseType.Accessory,
					Name = "Face Pull",
					IsCompound = false,
				},

				//Traps
				new Exercise(){
					Id = 23,
					MuscleGroupId = 11,
					ExerciseType = ExerciseType.Accessory,
					Name = "DB Shrugs",
					IsCompound = false,
				},

				//Forearms
				new Exercise(){
					Id = 24,
					MuscleGroupId = 12,
					ExerciseType = ExerciseType.Accessory,
					Name = "DB Wrist Curl",
					IsCompound = false,
				},

                //Quads
                new Exercise(){
					Id = 25,
					MuscleGroupId = 7,
					ExerciseType = ExerciseType.Primary,
					Name = "Low Bar Squat",
					IsCompound = true,
				},
				new Exercise(){
					Id = 26,
					MuscleGroupId = 7,
					ExerciseType = ExerciseType.Supplemental,
					Name = "High Bar Pause Squat",
					IsCompound = true,
				},
				new Exercise(){
					Id = 27,
					MuscleGroupId = 7,
					ExerciseType = ExerciseType.Accessory,
					Name = "Split Squat",
					IsCompound = true,
				},
				new Exercise(){
					Id = 28,
					MuscleGroupId = 7,
					ExerciseType = ExerciseType.Accessory,
					Name = "Leg Extension",
					IsCompound = false,
				},

                //Posterior Chain
                new Exercise(){
					Id = 29,
					MuscleGroupId = 8,
					ExerciseType = ExerciseType.Primary,
					Name = "Sumo Deadlift",
					IsCompound = true,
					
				},
				new Exercise(){
					Id = 30,
					MuscleGroupId = 8,
					ExerciseType = ExerciseType.Supplemental,
					Name = "Paused Conventional Deadlift",
					IsCompound = true,
				},
				new Exercise(){
					Id = 31,
					MuscleGroupId = 8,
					ExerciseType = ExerciseType.Accessory,
					Name = "Good Morning",
					IsCompound = true,
				},
				new Exercise(){
					Id = 32,
					MuscleGroupId = 8,
					ExerciseType = ExerciseType.Accessory,
					Name = "Leg Curl",
					IsCompound = false,
				},

                //Calves
                new Exercise(){
					Id = 33,
					MuscleGroupId = 13,
					ExerciseType = ExerciseType.Accessory,
					Name = "Standing Calf Raise",
					IsCompound = false,
				},
				new Exercise(){
					Id = 34,
					MuscleGroupId = 13,
					ExerciseType = ExerciseType.Accessory,
					Name = "Seated Calf Raise",
					IsCompound = false,
				},

				//Core
				new Exercise(){
					Id = 35,
					MuscleGroupId = 9,
					ExerciseType = ExerciseType.Accessory,
					Name = "Ab Wheel",
					IsCompound = false,
				},
				new Exercise(){
					Id = 36,
					MuscleGroupId = 9,
					ExerciseType = ExerciseType.Accessory,
					Name = "Weighted Decline Situp",
					IsCompound = false,
				},

			});

			modelBuilder.Entity<RepRange>().HasData(new List<RepRange>() {
				new RepRange(){
					Id = 1,
					RepRangeType = RepRangeType.Peaking,
					Low = 1,
					High = 3,
				},
				new RepRange(){
					Id = 2,
					RepRangeType = RepRangeType.StrengthBuilding,
					Low = 3,
					High = 6,
				},
				new RepRange(){
					Id = 3,
					RepRangeType = RepRangeType.MainLiftHypertrophy,
					Low = 6,
					High = 8,
				},
				new RepRange(){
					Id = 4,
					RepRangeType = RepRangeType.AccessoryHypertrophyCompound,
					Low = 8,
					High = 12,
				},
				new RepRange(){
					Id = 5,
					RepRangeType = RepRangeType.AccessoryHypertrophyIsolation,
					Low = 12,
					High = 15,
				},
			});

			var decimalProps = modelBuilder.Model
				.GetEntityTypes()
				.SelectMany(t => t.GetProperties())
				.Where(p => (System.Nullable.GetUnderlyingType(p.ClrType) ?? p.ClrType) == typeof(decimal));

			foreach (var property in decimalProps)
			{
				property.SetPrecision(18);
				property.SetScale(2);
			}
		}
	}
}
