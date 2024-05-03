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
					Id = 101,
					MuscleGroup = MuscleGroupEnum.Chest,
					ExerciseType = ExerciseType.Primary,
					Name = "Paused Bench Press",
					IsCompound = true,
					SessionNumber = 1,
					ExerciseNumber = 1,
				},
                new Exercise(){
                    Id = 102,
                    MuscleGroup = MuscleGroupEnum.Chest,
                    ExerciseType = ExerciseType.Technique,
                    Name = "Technique Sets Paused Bench Press",
                    IsCompound = true,
                    SessionNumber = 2,
                    ExerciseNumber = 1,
                },
                new Exercise(){
					Id = 103,
					MuscleGroup = MuscleGroupEnum.Chest,
					ExerciseType = ExerciseType.Supplemental,
					Name = "Incline Bench Press",
					IsCompound = true,
                    SessionNumber = 1,
                    ExerciseNumber = 1,
                },
                new Exercise(){
                    Id = 104,
                    MuscleGroup = MuscleGroupEnum.Chest,
                    ExerciseType = ExerciseType.Supplemental,
                    Name = "Touch-and-Go Bench Press",
                    IsCompound = true,
                    SessionNumber = 2,
                    ExerciseNumber = 1,
                },
                new Exercise(){
					Id = 105,
					MuscleGroup = MuscleGroupEnum.Chest,
					ExerciseType = ExerciseType.Accessory,
					Name = "Incline DB Bench Press",
					IsCompound = true,
                    SessionNumber = 1,
                    ExerciseNumber = 1,
                },
                new Exercise(){
                    Id = 106,
                    MuscleGroup = MuscleGroupEnum.Chest,
                    ExerciseType = ExerciseType.Accessory,
                    Name = "DB Bench Press",
                    IsCompound = true,
                    SessionNumber = 2,
                    ExerciseNumber = 1,
                },
                new Exercise(){
                    Id = 107,
                    MuscleGroup = MuscleGroupEnum.Chest,
                    ExerciseType = ExerciseType.Accessory,
                    Name = "Pec Deck",
                    IsCompound = false,
                    SessionNumber = 1,
                    ExerciseNumber = 2,
                },
				new Exercise(){
					Id = 108,
					MuscleGroup = MuscleGroupEnum.Chest,
					ExerciseType = ExerciseType.Accessory,
					Name = "Incline Fly",
					IsCompound = false,
                    SessionNumber = 2,
                    ExerciseNumber = 2,
                },

                //Triceps
				new Exercise(){
					Id = 109,
					MuscleGroup = MuscleGroupEnum.Triceps,
					ExerciseType = ExerciseType.Accessory,
					Name = "Rope Pushdown",
					IsCompound = false,
                    SessionNumber = 1,
                    ExerciseNumber = 1,
                },
				new Exercise(){
					Id = 110,
					MuscleGroup = MuscleGroupEnum.Triceps,
					ExerciseType = ExerciseType.Accessory,
					Name = "Overhead Rope Extension",
					IsCompound = false,
                    SessionNumber = 1,
                    ExerciseNumber = 2,
                },
                new Exercise(){
                    Id = 111,
                    MuscleGroup = MuscleGroupEnum.Triceps,
                    ExerciseType = ExerciseType.Accessory,
                    Name = "Skullcrusher",
                    IsCompound = false,
                    SessionNumber = 2,
                    ExerciseNumber = 1,
                },
                new Exercise(){
                    Id = 112,
                    MuscleGroup = MuscleGroupEnum.Triceps,
                    ExerciseType = ExerciseType.Accessory,
                    Name = "DB Overhead Extension",
                    IsCompound = false,
                    SessionNumber = 2,
                    ExerciseNumber = 2,
                },

                //Front Delts
                new Exercise(){
					Id = 113,
					MuscleGroup = MuscleGroupEnum.Delts,
					ExerciseType = ExerciseType.Primary,
					Name = "Paused Military Press",
					IsCompound= true,
                    SessionNumber = 2,
                    ExerciseNumber = 1,
                },
                new Exercise(){
                    Id = 114,
                    MuscleGroup = MuscleGroupEnum.Delts,
                    ExerciseType = ExerciseType.Technique,
                    Name = "Technique Sets Paused Military Press",
                    IsCompound= true,
                    SessionNumber = 1,
                    ExerciseNumber = 1,
                },
                new Exercise(){
					Id = 115,
					MuscleGroup = MuscleGroupEnum.Delts,
					ExerciseType = ExerciseType.Supplemental,
					Name = "Seated Military Press",
					IsCompound= true,
                    SessionNumber = 1,
                    ExerciseNumber = 1,
                },
                new Exercise(){
                    Id = 116,
                    MuscleGroup = MuscleGroupEnum.Delts,
                    ExerciseType = ExerciseType.Supplemental,
                    Name = "Touch-And-Go Military Press",
                    IsCompound= true,
                    SessionNumber = 2,
                    ExerciseNumber = 1,
                },
                new Exercise(){
					Id = 117,
					MuscleGroup = MuscleGroupEnum.Delts,
					ExerciseType = ExerciseType.Accessory,
					Name = "DB Shoulder Press",
					IsCompound= true,
                    SessionNumber = 1,
                    ExerciseNumber = 1,
                },
                new Exercise(){
                    Id = 118,
                    MuscleGroup = MuscleGroupEnum.Delts,
                    ExerciseType = ExerciseType.Accessory,
                    Name = "Hammer Strength Shoulder Press",
                    IsCompound= true,
                    SessionNumber = 2,
                    ExerciseNumber = 1,
                },
                new Exercise(){
					Id = 119,
					MuscleGroup = MuscleGroupEnum.Delts,
					ExerciseType = ExerciseType.Accessory,
					Name = "DB Lateral Raise",
					IsCompound= false,
					SessionNumber = 1,
                    ExerciseNumber = 2,
                },
                new Exercise(){
                    Id = 120,
                    MuscleGroup = MuscleGroupEnum.Delts,
                    ExerciseType = ExerciseType.Accessory,
                    Name = "Machine Lateral Raise",
                    IsCompound= false,
                    SessionNumber = 2,
                    ExerciseNumber = 2,
                },

                //Back
                new Exercise(){
					Id = 121,
					MuscleGroup = MuscleGroupEnum.Lats,
					ExerciseType = ExerciseType.Accessory,
					Name = "DB Row",
					IsCompound = true,
					SessionNumber = 1,
					ExerciseNumber = 1,
				},
                new Exercise(){
                    Id = 122,
                    MuscleGroup = MuscleGroupEnum.Lats,
                    ExerciseType = ExerciseType.Accessory,
                    Name = "Neutral Grip Pulldowns",
                    IsCompound = true,
                    SessionNumber = 1,
                    ExerciseNumber = 2,
                },
				new Exercise(){
					Id = 123,
					MuscleGroup = MuscleGroupEnum.Lats,
					ExerciseType = ExerciseType.Accessory,
					Name = "Chin-Ups",
					IsCompound = true,
					SessionNumber = 2,
					ExerciseNumber = 1,
				},
                new Exercise(){
                    Id = 124,
                    MuscleGroup = MuscleGroupEnum.Lats,
                    ExerciseType = ExerciseType.Accessory,
                    Name = "Hammer Strength Row",
                    IsCompound = true,
                    SessionNumber = 2,
                    ExerciseNumber = 2,
                },

                //Biceps
                new Exercise(){
					Id = 125,
					MuscleGroup = MuscleGroupEnum.Biceps,
					ExerciseType = ExerciseType.Accessory,
					Name = "Hammer Curl",
					IsCompound = false,
					SessionNumber = 1,
					ExerciseNumber = 1,
				},
				new Exercise(){
					Id = 126,
					MuscleGroup = MuscleGroupEnum.Biceps,
					ExerciseType = ExerciseType.Accessory,
					Name = "Preacher Curl",
					IsCompound = false,
					SessionNumber = 1,
					ExerciseNumber = 2,
				},
                new Exercise(){
                    Id = 127,
                    MuscleGroup = MuscleGroupEnum.Biceps,
                    ExerciseType = ExerciseType.Accessory,
                    Name = "Barbell Curl",
                    IsCompound = false,
					SessionNumber = 2,
					ExerciseNumber = 1,
                },
                new Exercise(){
                    Id = 128,
                    MuscleGroup = MuscleGroupEnum.Biceps,
                    ExerciseType = ExerciseType.Accessory,
                    Name = "Cable Curl",
                    IsCompound = false,
					SessionNumber = 2,
					ExerciseNumber = 2

                },

                //Upper Back
                new Exercise(){
					Id = 129,
					MuscleGroup = MuscleGroupEnum.UpperBack,
					ExerciseType = ExerciseType.Accessory,
					Name = "Reverse Pec Deck",
					IsCompound = false,
					SessionNumber = 1,
					ExerciseNumber = 1
				},
				new Exercise(){
					Id = 130,
					MuscleGroup = MuscleGroupEnum.UpperBack,
					ExerciseType = ExerciseType.Accessory,
					Name = "DB Shrugs",
					IsCompound = false,
					SessionNumber = 1,
					ExerciseNumber = 2
				},
				new Exercise(){
					Id = 131,
					MuscleGroup = MuscleGroupEnum.UpperBack,
					ExerciseType = ExerciseType.Accessory,
					Name = "Face Pull",
					IsCompound = false,
					SessionNumber = 2,
					ExerciseNumber = 1
				},
				new Exercise(){
					Id = 132,
					MuscleGroup = MuscleGroupEnum.UpperBack,
					ExerciseType = ExerciseType.Accessory,
					Name = "Smith Machine Shrugs",
					IsCompound = false,
					SessionNumber = 2,
					ExerciseNumber = 2
				},

                //Quads
                new Exercise(){
					Id = 133,
					MuscleGroup = MuscleGroupEnum.Quads,
					ExerciseType = ExerciseType.Primary,
					Name = "Low Bar Squat",
					IsCompound = true,
                    SessionNumber = 1,
                    ExerciseNumber = 1
                },
                new Exercise(){
                    Id = 134,
                    MuscleGroup = MuscleGroupEnum.Quads,
                    ExerciseType = ExerciseType.Technique,
                    Name = "Technique Low Bar Squat",
                    IsCompound = true,
                    SessionNumber = 2,
                    ExerciseNumber = 1
                },
                new Exercise(){
					Id = 135,
					MuscleGroup = MuscleGroupEnum.Quads,
					ExerciseType = ExerciseType.Accessory,
					Name = "Hack Squat",
					IsCompound = true,
                    SessionNumber = 1,
                    ExerciseNumber = 1
                },
                new Exercise(){
                    Id = 140,
                    MuscleGroup = MuscleGroupEnum.Quads,
                    ExerciseType = ExerciseType.Accessory,
                    Name = "Leg Press",
                    IsCompound = true,
                    SessionNumber = 2,
                    ExerciseNumber = 1
                },
                new Exercise(){
					Id = 141,
					MuscleGroup = MuscleGroupEnum.Quads,
					ExerciseType = ExerciseType.Supplemental,
					Name = "High Bar Squat",
					IsCompound = true,
                    SessionNumber = 1,
                    ExerciseNumber = 1
                },
                new Exercise(){
                    Id = 142,
                    MuscleGroup = MuscleGroupEnum.Quads,
                    ExerciseType = ExerciseType.Supplemental,
                    Name = "Front Squat",
                    IsCompound = true,
                    SessionNumber = 2,
                    ExerciseNumber = 1
                },
                new Exercise(){
                    Id = 143,
                    MuscleGroup = MuscleGroupEnum.Quads,
                    ExerciseType = ExerciseType.Accessory,
                    Name = "Single Leg Extension",
                    IsCompound = false,
                    SessionNumber = 1,
                    ExerciseNumber = 2
                },
                new Exercise(){
					Id = 144,
					MuscleGroup = MuscleGroupEnum.Quads,
					ExerciseType = ExerciseType.Accessory,
					Name = "Leg Extension",
					IsCompound = false,
                    SessionNumber = 2,
                    ExerciseNumber = 2
                },

                //Posterior Chain
                new Exercise(){
                    Id = 145,
                    MuscleGroup = MuscleGroupEnum.PosteriorChain,
                    ExerciseType = ExerciseType.Technique,
                    Name = "Technique Sumo Deadlift",
                    IsCompound = true,
					SessionNumber = 1,
					ExerciseNumber = 1
                },
                new Exercise(){
					Id = 146,
					MuscleGroup = MuscleGroupEnum.PosteriorChain,
					ExerciseType = ExerciseType.Primary,
					Name = "Sumo Deadlift",
					IsCompound = true,
					SessionNumber = 2,
					ExerciseNumber = 1
				},
                new Exercise(){
					Id = 147,
					MuscleGroup = MuscleGroupEnum.PosteriorChain,
					ExerciseType = ExerciseType.Supplemental,
					Name = "RDL",
					IsCompound = true,
					SessionNumber = 1,
					ExerciseNumber = 1
				},
				new Exercise(){
					Id = 148,
					MuscleGroup = MuscleGroupEnum.PosteriorChain,
					ExerciseType = ExerciseType.Supplemental,
					Name = "Conventional Deadlift",
					IsCompound = true,
					SessionNumber = 2,
					ExerciseNumber = 1
				},
                new Exercise(){
                    Id = 149,
                    MuscleGroup = MuscleGroupEnum.PosteriorChain,
                    ExerciseType = ExerciseType.Accessory,
                    Name = "Hip Thurst",
                    IsCompound = true,
					SessionNumber = 2,
					ExerciseNumber = 1
                },
                new Exercise(){
                    Id = 150,
                    MuscleGroup = MuscleGroupEnum.PosteriorChain,
                    ExerciseType = ExerciseType.Accessory,
                    Name = "Back Raise",
                    IsCompound = true,
					SessionNumber = 1,
					ExerciseNumber = 1
                },
                new Exercise(){
					Id = 151,
					MuscleGroup = MuscleGroupEnum.PosteriorChain,
					ExerciseType = ExerciseType.Accessory,
					Name = "Leg Curl",
					IsCompound = false,
					SessionNumber = 1,
					ExerciseNumber = 2
				},
                new Exercise(){
                    Id = 152,
                    MuscleGroup = MuscleGroupEnum.PosteriorChain,
                    ExerciseType = ExerciseType.Accessory,
                    Name = "Lying Leg Curl",
                    IsCompound = false,
					SessionNumber = 2,
					ExerciseNumber = 2
                },

                //Calves
                new Exercise(){
					Id = 153,
					MuscleGroup = MuscleGroupEnum.Calves,
					ExerciseType = ExerciseType.Accessory,
					Name = "Standing Calf Raise",
					IsCompound = false,
					SessionNumber = 1,
					ExerciseNumber = 1
				},
				new Exercise(){
					Id = 154,
					MuscleGroup = MuscleGroupEnum.Calves,
					ExerciseType = ExerciseType.Accessory,
					Name = "Seated Calf Raise",
					IsCompound = false,
					SessionNumber = 1,
					ExerciseNumber = 2
				},
				new Exercise(){
					Id = 155,
					MuscleGroup = MuscleGroupEnum.Calves,
					ExerciseType = ExerciseType.Accessory,
					Name = "Hammer Strength Calf Raise",
					IsCompound = false,
					SessionNumber = 2,
					ExerciseNumber = 1
				},
				new Exercise(){
					Id = 156,
					MuscleGroup = MuscleGroupEnum.Calves,
					ExerciseType = ExerciseType.Accessory,
					Name = "Seated Calf Extension",
					IsCompound = false,
					SessionNumber = 2,
					ExerciseNumber = 2
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
