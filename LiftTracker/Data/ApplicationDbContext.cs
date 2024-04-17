using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LiftTracker.Data
{
	public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
	{
		public DbSet<Exercise> Exercises { get; set; }
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
			modelBuilder.Entity<Exercise>().HasData(new List<Exercise>() {
                //Chest
                new Exercise(){
					Id = 1,
					MuscleGroup = MuscleGroupEnum.Chest,
					ExerciseType = ExerciseType.Primary,
					Name = "Flat Bench Press",
					IsCompound = true,
				},
				new Exercise(){
					Id = 2,
					MuscleGroup = MuscleGroupEnum.Chest,
					ExerciseType = ExerciseType.Supplemental,
					Name = "Incline DB Bench Press",
					IsCompound = true,
				},
				new Exercise(){
					Id = 3,
					MuscleGroup = MuscleGroupEnum.Chest,
					ExerciseType = ExerciseType.Supplemental,
					Name = "Incline Bench Press",
					IsCompound = true,
				},
                new Exercise(){
                    Id = 4,
                    MuscleGroup = MuscleGroupEnum.Chest,
                    ExerciseType = ExerciseType.Accessory,
                    Name = "Pec Deck",
                    IsCompound = false,
                },
				new Exercise(){
					Id = 5,
					MuscleGroup = MuscleGroupEnum.Chest,
					ExerciseType = ExerciseType.Accessory,
					Name = "Incline Fly",
					IsCompound = false,
				},

                //Triceps
				new Exercise(){
					Id = 6,
					MuscleGroup = MuscleGroupEnum.Triceps,
					ExerciseType = ExerciseType.Accessory,
					Name = "Rope Pushdown",
					IsCompound = false,
				},
				new Exercise(){
					Id = 7,
					MuscleGroup = MuscleGroupEnum.Triceps,
					ExerciseType = ExerciseType.Accessory,
					Name = "Overhead Rope Extension",
					IsCompound = false,
				},

                //Front Delts
                new Exercise(){
					Id = 8,
					MuscleGroup = MuscleGroupEnum.FrontDelts,
					ExerciseType = ExerciseType.Primary,
					Name = "Military Press",
					IsCompound= true,
				},
				new Exercise(){
					Id = 9,
					MuscleGroup = MuscleGroupEnum.FrontDelts,
					ExerciseType = ExerciseType.Supplemental,
					Name = "Seated Military Press",
					IsCompound= true,
				},
				new Exercise(){
					Id = 10,
					MuscleGroup = MuscleGroupEnum.FrontDelts,
					ExerciseType = ExerciseType.Supplemental,
					Name = "DB Shoulder Press",
					IsCompound= true,
				},
				new Exercise(){
					Id = 11,
					MuscleGroup = MuscleGroupEnum.FrontDelts,
					ExerciseType = ExerciseType.Accessory,
					Name = "DB Front Raise",
					IsCompound= false,
				},

                //Side Delts
				new Exercise(){
					Id = 12,
					MuscleGroup = MuscleGroupEnum.SideDelts,
					ExerciseType = ExerciseType.Accessory,
					Name = "DB Lateral Raise",
					IsCompound = false,
				},
				new Exercise(){
					Id = 13,
					MuscleGroup = MuscleGroupEnum.SideDelts,
					ExerciseType = ExerciseType.Accessory,
					Name = "Upright Row",
					IsCompound = false,
				},

                //Back
                new Exercise(){
					Id = 14,
					MuscleGroup = MuscleGroupEnum.Back,
					ExerciseType = ExerciseType.Accessory,
					Name = "DB Row",
					IsCompound = true,
				},
				new Exercise(){
					Id = 15,
					MuscleGroup = MuscleGroupEnum.Back,
					ExerciseType = ExerciseType.Accessory,
					Name = "Chin-Ups",
					IsCompound = true,
				},

                //Biceps
                new Exercise(){
					Id = 16,
					MuscleGroup = MuscleGroupEnum.Biceps,
					ExerciseType = ExerciseType.Accessory,
					Name = "Hammer Curl",
					IsCompound = false,
				},
				new Exercise(){
					Id = 17,
					MuscleGroup = MuscleGroupEnum.Biceps,
					ExerciseType = ExerciseType.Accessory,
					Name = "Preacher Curl",
					IsCompound = false,
				},

                //Rear Delts
                new Exercise(){
					Id = 18,
					MuscleGroup = MuscleGroupEnum.RearDelts,
					ExerciseType = ExerciseType.Accessory,
					Name = "Reverse Pec Deck",
					IsCompound = false,
				},
				new Exercise(){
					Id = 19,
					MuscleGroup = MuscleGroupEnum.RearDelts,
					ExerciseType = ExerciseType.Accessory,
					Name = "Face Pull",
					IsCompound = false,
				},

				//Traps
				new Exercise(){
					Id = 20,
					MuscleGroup = MuscleGroupEnum.Traps,
					ExerciseType = ExerciseType.Accessory,
					Name = "DB Shrugs",
					IsCompound = false,
				},
				new Exercise(){
					Id = 21,
					MuscleGroup = MuscleGroupEnum.Traps,
					ExerciseType = ExerciseType.Accessory,
					Name = "Barbell Shrugs",
					IsCompound = false,
				},

				//Forearms
				new Exercise(){
					Id = 22,
					MuscleGroup = MuscleGroupEnum.Forearms,
					ExerciseType = ExerciseType.Accessory,
					Name = "DB Wrist Curl",
					IsCompound = false,
				},
				new Exercise(){
					Id = 23,
					MuscleGroup = MuscleGroupEnum.Forearms,
					ExerciseType = ExerciseType.Accessory,
					Name = "Barbell Wrist Curl",
					IsCompound = false,
				},

                //Quads
                new Exercise(){
					Id = 24,
					MuscleGroup = MuscleGroupEnum.Quads,
					ExerciseType = ExerciseType.Primary,
					Name = "Low Bar Squat",
					IsCompound = true,
				},
				new Exercise(){
					Id = 25,
					MuscleGroup = MuscleGroupEnum.Quads,
					ExerciseType = ExerciseType.Supplemental,
					Name = "Hack Squat",
					IsCompound = true,
				},
				new Exercise(){
					Id = 26,
					MuscleGroup = MuscleGroupEnum.Quads,
					ExerciseType = ExerciseType.Supplemental,
					Name = "High Bar Squat",
					IsCompound = true,
				},
				new Exercise(){
					Id = 27,
					MuscleGroup = MuscleGroupEnum.Quads,
					ExerciseType = ExerciseType.Accessory,
					Name = "Leg Extension",
					IsCompound = false,
				},

                //Posterior Chain
                new Exercise(){
					Id = 28,
					MuscleGroup = MuscleGroupEnum.PosteriorChain,
					ExerciseType = ExerciseType.Primary,
					Name = "Sumo Deadlift",
					IsCompound = true,
					
				},
				new Exercise(){
					Id = 29,
					MuscleGroup = MuscleGroupEnum.PosteriorChain,
					ExerciseType = ExerciseType.Supplemental,
					Name = "RDL",
					IsCompound = true,
				},
				new Exercise(){
					Id = 30,
					MuscleGroup = MuscleGroupEnum.PosteriorChain,
					ExerciseType = ExerciseType.Supplemental,
					Name = "Conventional Deadlift",
					IsCompound = true,
				},
				new Exercise(){
					Id = 31,
					MuscleGroup = MuscleGroupEnum.PosteriorChain,
					ExerciseType = ExerciseType.Accessory,
					Name = "Leg Curl",
					IsCompound = false,
				},

                //Calves
                new Exercise(){
					Id = 32,
					MuscleGroup = MuscleGroupEnum.Calves,
					ExerciseType = ExerciseType.Accessory,
					Name = "Standing Calf Raise",
					IsCompound = false,
				},
				new Exercise(){
					Id = 33,
					MuscleGroup = MuscleGroupEnum.Calves,
					ExerciseType = ExerciseType.Accessory,
					Name = "Seated Calf Raise",
					IsCompound = false,
				},

				//Core
				new Exercise(){
					Id = 34,
					MuscleGroup = MuscleGroupEnum.Core,
					ExerciseType = ExerciseType.Accessory,
					Name = "Hanging Leg Raise",
					IsCompound = false,
				},
				new Exercise(){
					Id = 35,
					MuscleGroup = MuscleGroupEnum.Core,
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
