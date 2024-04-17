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
			var sideDeltExercise = new SessionExercise();
			var tricepExercise2 = new SessionExercise();

			if (sessionNumber == 1) {
                if (phase == TrainingPhase.Hypertrophy) {
                    chestExercise = GenerateSessionExercise(MuscleGroupEnum.Chest, ExerciseType.Supplemental, 1, phase, mesoLength, mesoWeek, 1, sessionNumber);
                }
                else if (phase == TrainingPhase.Strength) { 
                    chestExercise = GenerateSessionExercise(MuscleGroupEnum.Chest, ExerciseType.Supplemental, 2, phase, mesoLength, mesoWeek, 1, sessionNumber);
				}
				else { 
                    chestExercise = GenerateSessionExercise(MuscleGroupEnum.Chest, ExerciseType.Primary, 1, phase, mesoLength, mesoWeek, 1, sessionNumber);
                }
                frontDeltExercise = GenerateSessionExercise(MuscleGroupEnum.FrontDelts, ExerciseType.Accessory, 1, phase, mesoLength, mesoWeek, 1, sessionNumber);
				sideDeltExercise = GenerateSessionExercise(MuscleGroupEnum.SideDelts, ExerciseType.Accessory, 1, phase, mesoLength, mesoWeek, 2, sessionNumber);
				tricepExercise2 = GenerateSessionExercise(MuscleGroupEnum.Triceps, ExerciseType.Accessory, 1, phase, mesoLength, mesoWeek, 1, sessionNumber);
				return new List<SessionExercise?>() {
                    chestExercise,
					frontDeltExercise,
					tricepExercise2,
                    sideDeltExercise,
				};
            }
            else
            {
                if (phase == TrainingPhase.Hypertrophy)
                {
                    frontDeltExercise = GenerateSessionExercise(MuscleGroupEnum.FrontDelts, ExerciseType.Supplemental, 2, phase, mesoLength, mesoWeek, 1, sessionNumber);
                }
                else if (phase == TrainingPhase.Strength) { 
                    frontDeltExercise = GenerateSessionExercise(MuscleGroupEnum.FrontDelts, ExerciseType.Supplemental, 1, phase, mesoLength, mesoWeek, 1, sessionNumber);
				}
				else {
                    frontDeltExercise = GenerateSessionExercise(MuscleGroupEnum.FrontDelts, ExerciseType.Primary, 1, phase, mesoLength, mesoWeek, 1, sessionNumber);
                }
                if (phase == TrainingPhase.Peaking)
                {
                    chestExercise = GenerateSessionExercise(MuscleGroupEnum.Chest, ExerciseType.Accessory, 2, phase, mesoLength, mesoWeek, 1, sessionNumber);
                }
                else { 
                    chestExercise = GenerateSessionExercise(MuscleGroupEnum.Chest, ExerciseType.Accessory, 1, phase, mesoLength, mesoWeek, 1, sessionNumber);
                }
                sideDeltExercise = GenerateSessionExercise(MuscleGroupEnum.SideDelts, ExerciseType.Accessory, 2, phase, mesoLength, mesoWeek, 2, sessionNumber);
				tricepExercise2 = GenerateSessionExercise(MuscleGroupEnum.Triceps, ExerciseType.Accessory, 2, phase, mesoLength, mesoWeek, 1, sessionNumber);
				return new List<SessionExercise?>() {
					frontDeltExercise,
					chestExercise,
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
			var trapExercise = GenerateSessionExercise(MuscleGroupEnum.Traps, ExerciseType.Accessory, sessionNumber, phase, mesoLength, mesoWeek, 2, sessionNumber);
			var forearmExercise = GenerateSessionExercise(MuscleGroupEnum.Forearms, ExerciseType.Accessory, sessionNumber, phase, mesoLength, mesoWeek, 1, sessionNumber);
            if (sessionNumber == 1) { 
			    return new List<SessionExercise?>()
                {
                    backExercise,
                    bicepExercise,
                    rearDeltExercise,
				    trapExercise,
					forearmExercise,
				};
            }
			return new List<SessionExercise?>()
				{
					backExercise,
					bicepExercise,
					rearDeltExercise,
				    trapExercise,
    				forearmExercise,
				};
		}

        public IEnumerable<SessionExercise?> GenerateLegs(int sessionNumber, TrainingPhase? phase, int? mesoLength, int? mesoWeek)
        {
            var quadExercise = new SessionExercise();
            var posteriorChainExercise = new SessionExercise();
            var coreExercise = new SessionExercise();
			var calfExercise = new SessionExercise();
			if (sessionNumber == 1)
            {
                if (phase == TrainingPhase.Hypertrophy) {
                    quadExercise = GenerateSessionExercise(MuscleGroupEnum.Quads, ExerciseType.Supplemental, 1, phase, mesoLength, mesoWeek, 1, sessionNumber);
                }
                else if (phase == TrainingPhase.Strength) { 
                    quadExercise = GenerateSessionExercise(MuscleGroupEnum.Quads, ExerciseType.Supplemental, 2, phase, mesoLength, mesoWeek, 1, sessionNumber);
				}
				else {
                    quadExercise = GenerateSessionExercise(MuscleGroupEnum.Quads, ExerciseType.Primary, 1, phase, mesoLength, mesoWeek, 1, sessionNumber);
                }
                posteriorChainExercise = GenerateSessionExercise(MuscleGroupEnum.PosteriorChain, ExerciseType.Accessory, 1, phase, mesoLength, mesoWeek, 1, sessionNumber);
				coreExercise = GenerateSessionExercise(MuscleGroupEnum.Core, ExerciseType.Accessory, 1, phase, mesoLength, mesoWeek, 1, sessionNumber);
				calfExercise = GenerateSessionExercise(MuscleGroupEnum.Calves, ExerciseType.Accessory, 1, phase, mesoLength, mesoWeek, 2, sessionNumber);
                return new List<SessionExercise?>() {
                    quadExercise,
                    posteriorChainExercise,
                    coreExercise,
                    calfExercise
                };
            }
            else
            {
				if (phase == TrainingPhase.Hypertrophy)
				{
					posteriorChainExercise = GenerateSessionExercise(MuscleGroupEnum.PosteriorChain, ExerciseType.Supplemental, 1, phase, mesoLength, mesoWeek, 1, sessionNumber);
				}
				else if (phase == TrainingPhase.Strength)
				{
					posteriorChainExercise = GenerateSessionExercise(MuscleGroupEnum.PosteriorChain, ExerciseType.Supplemental, 2, phase, mesoLength, mesoWeek, 1, sessionNumber);
				}
				else
				{
    				posteriorChainExercise = GenerateSessionExercise(MuscleGroupEnum.PosteriorChain, ExerciseType.Primary, 1, phase, mesoLength, mesoWeek, 1, sessionNumber);
				}
				quadExercise = GenerateSessionExercise(MuscleGroupEnum.Quads, ExerciseType.Accessory, 1, phase, mesoLength, mesoWeek, 1, sessionNumber);
				coreExercise = GenerateSessionExercise(MuscleGroupEnum.Core, ExerciseType.Accessory, 2, phase, mesoLength, mesoWeek, 1, sessionNumber);
				calfExercise = GenerateSessionExercise(MuscleGroupEnum.Calves, ExerciseType.Accessory, 2, phase, mesoLength, mesoWeek, 2, sessionNumber);
				return new List<SessionExercise?>() {
					posteriorChainExercise,
					quadExercise,
					coreExercise,
				    calfExercise
				};
			}

        }

        public SessionExercise? GenerateSessionExercise(MuscleGroupEnum? muscleGroupEnum, ExerciseType? exerciseType, int? exerciseTypeOccurence, TrainingPhase? phase, int? mesoLength, int? mesoWeek, int? muscleGroupOccurence, int? sessionNumber) {
            using var context = new LiftTrackerContextBuilder(Configuration).Build();
            var result = new SessionExercise();

            result.ExerciseId = context
                                    .Exercises?
                                    .Where(x => x.MuscleGroup == muscleGroupEnum && exerciseType == x.ExerciseType)?
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
                    repRange = context.RepRanges.FirstOrDefault(x => x.RepRangeType == RepRangeType.AccessoryHypertrophyIsolation);
                }
                result.RepRangeId = repRange?.Id;
            }
            else {
                RepRange? repRange = null;
                if (phase == TrainingPhase.Hypertrophy) {
                    repRange = context.RepRanges.FirstOrDefault(x => x.RepRangeType == RepRangeType.MainLiftHypertrophy);
                }
				if (phase == TrainingPhase.Strength)
				{
					repRange = context.RepRanges.FirstOrDefault(x => x.RepRangeType == RepRangeType.StrengthBuilding);
				}
				if (phase == TrainingPhase.Peaking)
				{
					repRange = context.RepRanges.FirstOrDefault(x => x.RepRangeType == RepRangeType.Peaking);
				}
				result.RepRangeId = repRange?.Id;
            }

            var totalVolumeChange = 4;
            var weeklyChangeRate = totalVolumeChange / (mesoLength - 2);
            int? weeklyVolume;
            if (mesoWeek == mesoLength)
            {
                weeklyVolume = 4;
            }
            else if (phase == TrainingPhase.Peaking)
            {
                if (exerciseType == ExerciseType.Primary)
                {
                    weeklyVolume = 6 - (weeklyChangeRate * (mesoWeek - 1));
                }
                else { 
                    weeklyVolume = 6;
				}
			}
			else if (phase == TrainingPhase.Strength)
			{
				weeklyVolume = 6;
			}
			else
            {
                weeklyVolume = 6 + (weeklyChangeRate * (mesoWeek - 1));
            }
            var sessionVolume = weeklyVolume / 2;
            if (sessionNumber % 2 == 1 && weeklyVolume % 2 == 1) {
                sessionVolume = sessionVolume + 1;
            }
			var volume = sessionVolume;

            var rpe = 9 - ((mesoLength - mesoWeek)-1);
            if (mesoWeek == mesoLength) {
                rpe = 5;
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
