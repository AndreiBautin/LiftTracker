using LiftTracker.Data;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace LiftTracker.UseCases
{
    public class GenerateSessionExercisesUseCase
    {
        private IConfiguration Configuration;
        public GenerateSessionExercisesUseCase(IConfiguration configuration) {
            Configuration = configuration;   
        }

        public IEnumerable<SessionExercise?> Generate(DayOfTheWeek? dayOfTheWeek, TrainingPhase? phase, int? mesoLength, int? mesoWeek) { 
            switch (dayOfTheWeek) {
                case DayOfTheWeek.Monday:
                    return GeneratePush(1, phase, mesoLength, mesoWeek);
                case DayOfTheWeek.Tuesday:
                    return GeneratePull(1, phase, mesoLength, mesoWeek);
                case DayOfTheWeek.Wednesday:
                    return GenerateLegs(1, phase, mesoLength, mesoWeek);
                case DayOfTheWeek.Thursday:
                    return GeneratePush(2, phase, mesoLength, mesoWeek);
                case DayOfTheWeek.Friday:
                    return GeneratePull(2, phase, mesoLength, mesoWeek);
                case DayOfTheWeek.Saturday:
                    return GenerateLegs(2, phase, mesoLength, mesoWeek);
                case DayOfTheWeek.Sunday:
                default:
                    return new List<SessionExercise>();
            }
        }

        public IEnumerable<SessionExercise?> GeneratePush(int sessionNumber, TrainingPhase? phase, int? mesoLength, int? mesoWeek) {
            using var context = new LiftTrackerContextBuilder(Configuration).Build();

            var chestExercise = new SessionExercise();
            var frontDeltExercise = new SessionExercise();
            var tricepExercise = new SessionExercise();
			var chestExercise2 = new SessionExercise();
			var sideDeltExercise = new SessionExercise();
			var tricepExercise2 = new SessionExercise();

			if (sessionNumber == 1) { 
                chestExercise = GenerateSessionExercise(MuscleGroupEnum.Chest, ExerciseType.Primary, 1, phase, mesoLength, mesoWeek, 1, sessionNumber);
                frontDeltExercise = GenerateSessionExercise(MuscleGroupEnum.FrontDelts, ExerciseType.Supplemental, 1, phase, mesoLength, mesoWeek, 1, sessionNumber);
                tricepExercise = GenerateSessionExercise(MuscleGroupEnum.Triceps, ExerciseType.Supplemental, 2, phase, mesoLength, mesoWeek, 1, sessionNumber);
				chestExercise2 = GenerateSessionExercise(MuscleGroupEnum.Chest, ExerciseType.Accessory, 1, phase, mesoLength, mesoWeek, 2, sessionNumber);
				sideDeltExercise = GenerateSessionExercise(MuscleGroupEnum.SideDelts, ExerciseType.Accessory, 1, phase, mesoLength, mesoWeek, 2, sessionNumber);
				tricepExercise2 = GenerateSessionExercise(MuscleGroupEnum.Triceps, ExerciseType.Accessory, 1, phase, mesoLength, mesoWeek, 2, sessionNumber);
				return new List<SessionExercise?>() {
                    chestExercise,
                    tricepExercise,
					frontDeltExercise,
					chestExercise2,
					tricepExercise2,
                    sideDeltExercise,
				};
            }
            else
            {
                chestExercise = GenerateSessionExercise(MuscleGroupEnum.Chest, ExerciseType.Supplemental, 1, phase, mesoLength, mesoWeek, 1,sessionNumber);
                tricepExercise = GenerateSessionExercise(MuscleGroupEnum.Triceps, ExerciseType.Supplemental, 1, phase, mesoLength, mesoWeek, 1, sessionNumber);
                frontDeltExercise = GenerateSessionExercise(MuscleGroupEnum.FrontDelts, ExerciseType.Accessory, 1, phase, mesoLength, mesoWeek, 1, sessionNumber);
				chestExercise2 = GenerateSessionExercise(MuscleGroupEnum.Chest, ExerciseType.Accessory, 2, phase, mesoLength, mesoWeek, 2, sessionNumber);
				sideDeltExercise = GenerateSessionExercise(MuscleGroupEnum.SideDelts, ExerciseType.Accessory, 2, phase, mesoLength, mesoWeek, 2, sessionNumber);
				tricepExercise2 = GenerateSessionExercise(MuscleGroupEnum.Triceps, ExerciseType.Accessory, 2, phase, mesoLength, mesoWeek, 2, sessionNumber);
				return new List<SessionExercise?>() {
					chestExercise,
					tricepExercise,
					frontDeltExercise,
					chestExercise2,
					tricepExercise2,
					sideDeltExercise,
				};
			}
        }

        public IEnumerable<SessionExercise?> GeneratePull(int sessionNumber, TrainingPhase? phase, int? mesoLength, int? mesoWeek)
        {
            var backExercise = GenerateSessionExercise(MuscleGroupEnum.Back, ExerciseType.Accessory, sessionNumber, phase, mesoLength, mesoWeek, 1, sessionNumber);
            var rearDeltExercise = GenerateSessionExercise(MuscleGroupEnum.RearDelts, ExerciseType.Accessory, sessionNumber, phase, mesoLength, mesoWeek, 1, sessionNumber);
            var bicepExercise = GenerateSessionExercise(MuscleGroupEnum.Biceps, ExerciseType.Accessory, sessionNumber, phase, mesoLength, mesoWeek, 1, sessionNumber);
			var backExercise2 = GenerateSessionExercise(MuscleGroupEnum.Back, ExerciseType.Accessory, sessionNumber+2, phase, mesoLength, mesoWeek, 2, sessionNumber);
			var trapExercise = GenerateSessionExercise(MuscleGroupEnum.Traps, ExerciseType.Accessory, 1, phase, mesoLength, mesoWeek, 2, sessionNumber);
			var forearmExercise = GenerateSessionExercise(MuscleGroupEnum.Forearms, ExerciseType.Accessory, 1, phase, mesoLength, mesoWeek, 2, sessionNumber);
			var bicepExercise2 = GenerateSessionExercise(MuscleGroupEnum.Biceps, ExerciseType.Accessory, sessionNumber+2, phase, mesoLength, mesoWeek, 2, sessionNumber);
            if (sessionNumber == 1) { 
			    return new List<SessionExercise?>()
                {
                    backExercise,
				    backExercise2,
                    bicepExercise,
				    bicepExercise2,
                    rearDeltExercise,
				    trapExercise,
			    };
            }
			return new List<SessionExercise?>()
				{
					backExercise,
					backExercise2,
					bicepExercise,
					bicepExercise2,
					rearDeltExercise,
					forearmExercise,
				};
		}

        public IEnumerable<SessionExercise?> GenerateLegs(int sessionNumber, TrainingPhase? phase, int? mesoLength, int? mesoWeek)
        {
            var quadExercise = new SessionExercise();
            var posteriorChainExercise = new SessionExercise();
            var coreExercise = new SessionExercise();
			var quadExercise2 = new SessionExercise();
			var posteriorChainExercise2 = new SessionExercise();
			var calfExercise = new SessionExercise();
			if (sessionNumber == 1)
            {
                quadExercise = GenerateSessionExercise(MuscleGroupEnum.Quads, ExerciseType.Primary, 1, phase, mesoLength, mesoWeek, 1, sessionNumber);
                posteriorChainExercise = GenerateSessionExercise(MuscleGroupEnum.PosteriorChain, ExerciseType.Supplemental, 1, phase, mesoLength, mesoWeek, 1, sessionNumber);
				quadExercise2 = GenerateSessionExercise(MuscleGroupEnum.Quads, ExerciseType.Accessory, 2, phase, mesoLength, mesoWeek, 2, sessionNumber);
				posteriorChainExercise2 = GenerateSessionExercise(MuscleGroupEnum.PosteriorChain, ExerciseType.Accessory, 1, phase, mesoLength, mesoWeek, 2, sessionNumber);
				coreExercise = GenerateSessionExercise(MuscleGroupEnum.Core, ExerciseType.Accessory, 1, phase, mesoLength, mesoWeek, 1, sessionNumber);
				calfExercise = GenerateSessionExercise(MuscleGroupEnum.Calves, ExerciseType.Accessory, 1, phase, mesoLength, mesoWeek, 2, sessionNumber);
                return new List<SessionExercise?>() {
                    quadExercise,
                    posteriorChainExercise,
                    quadExercise2,
                    posteriorChainExercise2,
                    coreExercise,
                    calfExercise
                };
            }
            else
            {
				posteriorChainExercise = GenerateSessionExercise(MuscleGroupEnum.PosteriorChain, ExerciseType.Primary, 1, phase, mesoLength, mesoWeek, 1, sessionNumber);
				quadExercise = GenerateSessionExercise(MuscleGroupEnum.Quads, ExerciseType.Supplemental, 1, phase, mesoLength, mesoWeek, 1, sessionNumber);
				posteriorChainExercise2 = GenerateSessionExercise(MuscleGroupEnum.PosteriorChain, ExerciseType.Accessory, 2, phase, mesoLength, mesoWeek, 2, sessionNumber);
				quadExercise2 = GenerateSessionExercise(MuscleGroupEnum.Quads, ExerciseType.Accessory, 1, phase, mesoLength, mesoWeek, 2, sessionNumber);
				coreExercise = GenerateSessionExercise(MuscleGroupEnum.Core, ExerciseType.Accessory, 2, phase, mesoLength, mesoWeek, 1, sessionNumber);
				calfExercise = GenerateSessionExercise(MuscleGroupEnum.Calves, ExerciseType.Accessory, 2, phase, mesoLength, mesoWeek, 2, sessionNumber);
				return new List<SessionExercise?>() {
					posteriorChainExercise,
					quadExercise,
					posteriorChainExercise2,
					quadExercise2,
					coreExercise,
				    calfExercise
				};
			}

        }

        public SessionExercise? GenerateSessionExercise(MuscleGroupEnum? muscleGroupEnum, ExerciseType? exerciseType, int? exerciseTypeOccurence, TrainingPhase? phase, int? mesoLength, int? mesoWeek, int? muscleGroupOccurence, int? sessionNumber) {
            using var context = new LiftTrackerContextBuilder(Configuration).Build();
            var result = new SessionExercise();

            var muscleGroupId = context.MuscleGroups.FirstOrDefault(x => x.MuscleGroupEnum == muscleGroupEnum)?.Id;
            var muscleGroup = context.MuscleGroups.FirstOrDefault(x => x.MuscleGroupEnum == muscleGroupEnum);

            result.ExerciseId = context
                                    .Exercises?
                                    .Where(x => x.MuscleGroupId == muscleGroupId && exerciseType == x.ExerciseType)?
                                    .ElementAtOrDefault((exerciseTypeOccurence ?? 1) - 1)?
                                    .Id;
            var exercise = context.Exercises?.FirstOrDefault(x => x.Id == result.ExerciseId);
            if (exercise?.ExerciseType == ExerciseType.Accessory)
            {
                RepRange? repRange;
                if (exercise.IsCompound)
                {
                    repRange = context.RepRanges.FirstOrDefault(x => x.RepRangeType == RepRangeType.AccessoryHypertrophyCompound);
                }
                else {
                    if (muscleGroup?.MuscleGroupEnum == MuscleGroupEnum.Core)
                    {
						repRange = context.RepRanges.FirstOrDefault(x => x.RepRangeType == RepRangeType.MetaboliteTraining);
					}
					else { 
                        repRange = context.RepRanges.FirstOrDefault(x => x.RepRangeType == RepRangeType.AccessoryHypertrophyIsolation);
                    }
                }
                result.RepRangeId = repRange?.Id;
            }
            else {
                var repRange = context.RepRanges.FirstOrDefault(x => x.RepRangeType == RepRangeType.StrengthBuilding);
				result.RepRangeId = repRange?.Id;
            }

            var totalVolumeChange = muscleGroup?.MRV - muscleGroup?.MEV;
            var weeklyChangeRate = totalVolumeChange / (mesoLength - 2);
            int? weeklyVolume;
            if (phase == TrainingPhase.Peaking)
            {
                weeklyVolume = (muscleGroup?.MRV - (weeklyChangeRate * (mesoWeek - 1))) / 2;
            }
            else
            {
                weeklyVolume = muscleGroup?.MEV + (weeklyChangeRate * (mesoWeek - 1));
            }
            if (mesoWeek == mesoLength)
            {
                weeklyVolume = muscleGroup?.MV;
            }
            if (mesoWeek == mesoLength - 1) {
                weeklyVolume = muscleGroup?.MRV;
            }
            var sessionVolume = weeklyVolume / muscleGroup?.Frequency;
            if (sessionNumber % 2 == 1 && weeklyVolume % 2 == 1 && muscleGroup?.Frequency > 1) {
                sessionVolume = sessionVolume + 1;
            }
			var volume = sessionVolume / muscleGroup?.ExercisesPerSession;
            if (muscleGroupOccurence % 2 == 1 && sessionVolume % 2 == 1 && muscleGroup?.ExercisesPerSession > 1) {
                volume = volume + 1;
            }

            var rpe = 9 - ((mesoLength - mesoWeek)-1);
            if (mesoWeek == mesoLength) {
                rpe = 6;
            }
            var sets = new List<Set>();
            for (var i = 0; i < volume; i++) {
                var set = new Set() {
                    IsComplete = false,
                    TargetRpe = rpe,
                    
                };
                sets.Add(set);
            }

            result.Sets = sets;

            return result;
        }
    }
}
