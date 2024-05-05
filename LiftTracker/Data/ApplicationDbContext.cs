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
				// Chest
                new Exercise(){
                    Id = 1,
                    MuscleGroup = MuscleGroup.Chest,
                    Name = "Bench Press",
                    IsCompound = true,
                    IsCompetition = true,
                    EquipmentType = EquipmentType.Barbell
                },
                new Exercise(){
                    Id = 2,
                    MuscleGroup = MuscleGroup.Chest,
                    Name = "Incline Bench Press",
                    IsCompound = true,
                    IsCompetition = false,
                    EquipmentType = EquipmentType.Barbell
                },
                new Exercise(){
                    Id = 3,
                    MuscleGroup = MuscleGroup.Chest,
                    Name = "Incline DB Bench Press",
                    IsCompound = true,
                    IsCompetition = false,
                    EquipmentType = EquipmentType.Dumbbell
                },
                new Exercise(){
                    Id = 4,
                    MuscleGroup = MuscleGroup.Chest,
                    Name = "Dips",
                    IsCompound = true,
                    IsCompetition = false,
                    EquipmentType = EquipmentType.Bodyweight
                },
                new Exercise(){
                    Id = 5,
                    MuscleGroup = MuscleGroup.Chest,
                    Name = "Pec Deck",
                    IsCompound = false,
                    IsCompetition = false,
                    EquipmentType= EquipmentType.MachineNautilus
                },
                new Exercise(){
                    Id = 6,
                    MuscleGroup = MuscleGroup.Chest,
                    Name = "Incline Fly",
                    IsCompound = false,
                    IsCompetition = false,
                    EquipmentType = EquipmentType.Dumbbell
                },

                // Triceps
                new Exercise(){
                    Id = 7,
                    MuscleGroup = MuscleGroup.Triceps,
                    Name = "Rope Pushdown",
                    IsCompound = false,
                    IsCompetition = false,
                    EquipmentType = EquipmentType.MachineCable
                },
                new Exercise(){
                    Id = 8,
                    MuscleGroup = MuscleGroup.Triceps,
                    Name = "Machine Tricep Extension",
                    IsCompound = false,
                    IsCompetition = false,
                    EquipmentType = EquipmentType.MachineNautilus
                },
                new Exercise(){
                    Id = 9,
                    MuscleGroup = MuscleGroup.Triceps,
                    Name = "Skullcrusher",
                    IsCompound = false,
                    IsCompetition = false,
                    EquipmentType = EquipmentType.Barbell
                },
                new Exercise(){
                    Id = 10,
                    MuscleGroup = MuscleGroup.Triceps,
                    Name = "DB Overhead Extension",
                    IsCompound = false,
                    IsCompetition = false,
                    EquipmentType = EquipmentType.Dumbbell
                },

                // Front Delts
                new Exercise(){
                    Id = 11,
                    MuscleGroup = MuscleGroup.Delts,
                    Name = "DB Shoulder Press",
                    IsCompound = true,
                    IsCompetition = false,
                    EquipmentType = EquipmentType.Dumbbell
                },
                new Exercise(){
                    Id = 12,
                    MuscleGroup = MuscleGroup.Delts,
                    Name = "Hammer Strength Shoulder Press",
                    IsCompound = true,
                    IsCompetition = false,
                    EquipmentType = EquipmentType.MachineHammerStrength
                },
                new Exercise(){
                    Id = 13,
                    MuscleGroup = MuscleGroup.Delts,
                    Name = "DB Lateral Raise",
                    IsCompound = false,
                    IsCompetition = false,
                    EquipmentType = EquipmentType.Dumbbell
                },
                new Exercise(){
                    Id = 14,
                    MuscleGroup = MuscleGroup.Delts,
                    Name = "Machine Lateral Raise",
                    IsCompound = false,
                    IsCompetition = false,
                    EquipmentType = EquipmentType.MachineNautilus
                },

                // Back
                new Exercise(){
                    Id = 15,
                    MuscleGroup = MuscleGroup.Lats,
                    Name = "DB Row",
                    IsCompound = true,
                    IsCompetition = false,
                    EquipmentType = EquipmentType.Dumbbell
                },
                new Exercise(){
                    Id = 16,
                    MuscleGroup = MuscleGroup.Lats,
                    Name = "Neutral Grip Pulldowns",
                    IsCompound = true,
                    IsCompetition = false,
                    EquipmentType = EquipmentType.MachineCable
                },
                new Exercise(){
                    Id = 17,
                    MuscleGroup = MuscleGroup.Lats,
                    Name = "Chin-Ups",
                    IsCompound = true,
                    IsCompetition = false,
                    EquipmentType = EquipmentType.Bodyweight
                },
                new Exercise(){
                    Id = 18,
                    MuscleGroup = MuscleGroup.Lats,
                    Name = "Hammer Strength Row",
                    IsCompound = true,
                    IsCompetition = false,
                    EquipmentType = EquipmentType.MachineHammerStrength
                },

                // Biceps
                new Exercise(){
                    Id = 19,
                    MuscleGroup = MuscleGroup.Biceps,
                    Name = "Hammer Curl",
                    IsCompound = false,
                    IsCompetition = false,
                    EquipmentType = EquipmentType.Dumbbell
                },
                new Exercise(){
                    Id = 20,
                    MuscleGroup = MuscleGroup.Biceps,
                    Name = "Preacher Curl",
                    IsCompound = false,
                    IsCompetition = false,
                    EquipmentType = EquipmentType.MachineHammerStrength
                },
                new Exercise(){
                    Id = 21,
                    MuscleGroup = MuscleGroup.Biceps,
                    Name = "Barbell Curl",
                    IsCompound = false,
                    IsCompetition = false,
                    EquipmentType = EquipmentType.Barbell
                },
                new Exercise(){
                    Id = 22,
                    MuscleGroup = MuscleGroup.Biceps,
                    Name = "Cable Curl",
                    IsCompound = false,
                    IsCompetition = false,
                    EquipmentType = EquipmentType.MachineCable
                },

                // Upper Back
                new Exercise(){
                    Id = 23,
                    MuscleGroup = MuscleGroup.UpperBack,
                    Name = "Reverse Pec Deck",
                    IsCompound = false,
                    IsCompetition = false,
                    EquipmentType = EquipmentType.MachineNautilus
                },
                new Exercise(){
                    Id = 24,
                    MuscleGroup = MuscleGroup.UpperBack,
                    Name = "DB Shrugs",
                    IsCompound = false,
                    IsCompetition = false,
                    EquipmentType = EquipmentType.Dumbbell
                },
                new Exercise(){
                    Id = 25,
                    MuscleGroup = MuscleGroup.UpperBack,
                    Name = "Face Pull",
                    IsCompound = false,
                    IsCompetition = false,
                    EquipmentType = EquipmentType.MachineCable
                },
                new Exercise(){
                    Id = 26,
                    MuscleGroup = MuscleGroup.UpperBack,
                    Name = "Barbell Shrugs",
                    IsCompound = false,
                    IsCompetition = false,
                    EquipmentType = EquipmentType.Barbell
                },

                // Quads
                new Exercise(){
                    Id = 27,
                    MuscleGroup = MuscleGroup.Quads,
                    Name = "Low Bar Squat",
                    IsCompound = true,
                    IsCompetition = true,
                    EquipmentType = EquipmentType.Barbell
                },
                new Exercise(){
                    Id = 28,
                    MuscleGroup = MuscleGroup.Quads,
                    Name = "High Bar Squat",
                    IsCompound = true,
                    IsCompetition = false,
                    EquipmentType = EquipmentType.Barbell
                },
                new Exercise(){
                    Id = 29,
                    MuscleGroup = MuscleGroup.Quads,
                    Name = "Hack Squat",
                    IsCompound = true,
                    IsCompetition = false,
                    EquipmentType = EquipmentType.MachineHammerStrength
                },
                new Exercise(){
                    Id = 30,
                    MuscleGroup = MuscleGroup.Quads,
                    Name = "Split Squat",
                    IsCompound = true,
                    IsCompetition = false,
                    EquipmentType = EquipmentType.Dumbbell
                },
                new Exercise(){
                    Id = 31,
                    MuscleGroup = MuscleGroup.Quads,
                    Name = "Single Leg Extension",
                    IsCompound = false,
                    IsCompetition = false,
                    EquipmentType = EquipmentType.MachineHammerStrength
                },
                new Exercise(){
                    Id = 32,
                    MuscleGroup = MuscleGroup.Quads,
                    Name = "Leg Extension",
                    IsCompound = false,
                    IsCompetition = false,
                    EquipmentType = EquipmentType.MachineNautilus
                },

                // Posterior Chain
                new Exercise(){
                    Id = 33,
                    MuscleGroup = MuscleGroup.PosteriorChain,
                    Name = "Sumo Deadlift",
                    IsCompound = true,
                    IsCompetition = true,
                    EquipmentType = EquipmentType.Barbell
                },
                new Exercise(){
                    Id = 34,
                    MuscleGroup = MuscleGroup.PosteriorChain,
                    Name = "Conventional Deadlift",
                    IsCompound = true,
                    IsCompetition = false,
                    EquipmentType = EquipmentType.Barbell
                },
                new Exercise(){
                    Id = 35,
                    MuscleGroup = MuscleGroup.PosteriorChain,
                    Name = "DB RDL",
                    IsCompound = true,
                    IsCompetition = false,
                    EquipmentType = EquipmentType.Dumbbell
                },
                new Exercise(){
                    Id = 36,
                    MuscleGroup = MuscleGroup.PosteriorChain,
                    Name = "Back Raise",
                    IsCompound = true,
                    IsCompetition = false,
                    EquipmentType = EquipmentType.Bodyweight
                },
                new Exercise(){
                    Id = 37,
                    MuscleGroup = MuscleGroup.PosteriorChain,
                    Name = "Leg Curl",
                    IsCompound = false,
                    IsCompetition = false,
                    EquipmentType = EquipmentType.MachineHammerStrength
                },
                new Exercise(){
                    Id = 38,
                    MuscleGroup = MuscleGroup.PosteriorChain,
                    Name = "Lying Leg Curl",
                    IsCompound = false,
                    IsCompetition = false,
                    EquipmentType = EquipmentType.MachineNautilus
                },

                // Calves
                new Exercise(){
                    Id = 39,
                    MuscleGroup = MuscleGroup.Calves,
                    Name = "Standing Calf Raise",
                    IsCompound = false,
                    IsCompetition = false,
                    EquipmentType = EquipmentType.MachineNautilus
                },
                new Exercise(){
                    Id = 40,
                    MuscleGroup = MuscleGroup.Calves,
                    Name = "Seated Calf Raise",
                    IsCompound = false,
                    IsCompetition = false,
                    EquipmentType = EquipmentType.MachineHammerStrength
                }
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
