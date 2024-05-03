using LiftTracker.Data;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace LiftTracker.UseCases.Implementation
{
    public class GenerateSessionExercisesUseCase : IGenerateSessionExerciseUseCase
    {
        private IConfiguration Configuration;
        public GenerateSessionExercisesUseCase(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IEnumerable<SessionExercise?> Generate(DayOfTheWeek? dayOfTheWeek, TrainingPhase? phase, int? mesoLength, int? mesoWeek, TrainingSplit trainingSplit)
        {
            switch (dayOfTheWeek)
            {
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

        public IEnumerable<SessionExercise?> GeneratePush(int sessionNumber, TrainingPhase? phase, int? mesoLength, int? mesoWeek)
        {
            using var context = new LiftTrackerContextBuilder(Configuration).Build();

            var chestExerciseType = ExerciseType.Accessory;
            var deltExerciseType = ExerciseType.Accessory;
            if (phase == TrainingPhase.Strength)
            {
                chestExerciseType = ExerciseType.Supplemental;
                deltExerciseType = ExerciseType.Supplemental;
            }
            if (phase == TrainingPhase.Peaking)
            {
                if (sessionNumber == 1)
                {
                    chestExerciseType = ExerciseType.Primary;
                    deltExerciseType = ExerciseType.Technique;
                }
                else
                {
                    chestExerciseType = ExerciseType.Technique;
                    deltExerciseType = ExerciseType.Primary;
                }
            }

            var chestExercise1 = GenerateSessionExercise(MuscleGroupEnum.Chest, phase, chestExerciseType, mesoLength, mesoWeek, sessionNumber, 1);
            var chestExercise2 = GenerateSessionExercise(MuscleGroupEnum.Chest, phase, ExerciseType.Accessory, mesoLength, mesoWeek, sessionNumber, 2);
            var deltExercise1 = GenerateSessionExercise(MuscleGroupEnum.Delts, phase, deltExerciseType, mesoLength, mesoWeek, sessionNumber, 1);
            var deltExercise2 = GenerateSessionExercise(MuscleGroupEnum.Delts, phase, ExerciseType.Accessory, mesoLength, mesoWeek, sessionNumber, 2);
            var tricepExercise1 = GenerateSessionExercise(MuscleGroupEnum.Triceps, phase, ExerciseType.Accessory, mesoLength, mesoWeek, sessionNumber, 1);
            var tricepExercise2 = GenerateSessionExercise(MuscleGroupEnum.Triceps, phase, ExerciseType.Accessory, mesoLength, mesoWeek, sessionNumber, 2);

            if (sessionNumber == 1) {
                return new List<SessionExercise?>() {
                chestExercise1,
                deltExercise1,
                chestExercise2,
                deltExercise2,
                tricepExercise1,
                tricepExercise2
            };
            }

            return new List<SessionExercise?>() { 
                deltExercise1,
                chestExercise1,
                deltExercise2,
                chestExercise2,
                tricepExercise1,
                tricepExercise2
            };
        }

        public IEnumerable<SessionExercise?> GeneratePull(int sessionNumber, TrainingPhase? phase, int? mesoLength, int? mesoWeek)
        {
            using var context = new LiftTrackerContextBuilder(Configuration).Build();

            var latExercise1 = GenerateSessionExercise(MuscleGroupEnum.Lats, phase, ExerciseType.Accessory, mesoLength, mesoWeek, sessionNumber, 1);
            var latExercise2 = GenerateSessionExercise(MuscleGroupEnum.Lats, phase, ExerciseType.Accessory, mesoLength, mesoWeek, sessionNumber, 2);
            var bicepExercise1 = GenerateSessionExercise(MuscleGroupEnum.Biceps, phase, ExerciseType.Accessory, mesoLength, mesoWeek, sessionNumber, 1);
            var bicepExercise2 = GenerateSessionExercise(MuscleGroupEnum.Biceps, phase, ExerciseType.Accessory, mesoLength, mesoWeek, sessionNumber, 2);
            var upperBackExercise1 = GenerateSessionExercise(MuscleGroupEnum.UpperBack, phase, ExerciseType.Accessory, mesoLength, mesoWeek, sessionNumber, 1);
            var upperBackExercise2 = GenerateSessionExercise(MuscleGroupEnum.UpperBack, phase, ExerciseType.Accessory, mesoLength, mesoWeek, sessionNumber, 2);

            return new List<SessionExercise?>() {
                latExercise1,
                latExercise2,
                bicepExercise1,
                bicepExercise2,
                upperBackExercise1,
                upperBackExercise2
            };
        }

        public IEnumerable<SessionExercise?> GenerateLegs(int sessionNumber, TrainingPhase? phase, int? mesoLength, int? mesoWeek)
        {
            using var context = new LiftTrackerContextBuilder(Configuration).Build();

            var quadExerciseType = ExerciseType.Accessory;
            var posteriorChainExerciseType = ExerciseType.Accessory;
            if (phase == TrainingPhase.Strength) {
                quadExerciseType = ExerciseType.Supplemental;
                posteriorChainExerciseType = ExerciseType.Supplemental;
            }
            if (phase == TrainingPhase.Peaking) {
                if (sessionNumber == 1)
                {
                    quadExerciseType = ExerciseType.Primary;
                    posteriorChainExerciseType = ExerciseType.Technique;
                }
                else { 
                    quadExerciseType = ExerciseType.Technique;
                    posteriorChainExerciseType = ExerciseType.Primary;                
                }
            }

            var quadExercise1 = GenerateSessionExercise(MuscleGroupEnum.Quads, phase, quadExerciseType, mesoLength, mesoWeek, sessionNumber, 1);
            var quadExercise2 = GenerateSessionExercise(MuscleGroupEnum.Quads, phase, ExerciseType.Accessory, mesoLength, mesoWeek, sessionNumber, 2);
            var posteriorChainExercise1 = GenerateSessionExercise(MuscleGroupEnum.PosteriorChain, phase, posteriorChainExerciseType, mesoLength, mesoWeek, sessionNumber, 1);
            var posteriorChainExercise2 = GenerateSessionExercise(MuscleGroupEnum.PosteriorChain, phase, ExerciseType.Accessory, mesoLength, mesoWeek, sessionNumber, 2);
            var calfExercise1 = GenerateSessionExercise(MuscleGroupEnum.Calves, phase, ExerciseType.Accessory, mesoLength, mesoWeek, sessionNumber, 1);
            var calfExercise2 = GenerateSessionExercise(MuscleGroupEnum.Calves, phase, ExerciseType.Accessory, mesoLength, mesoWeek, sessionNumber, 2);

            if (sessionNumber == 1)
            {
                return new List<SessionExercise?>() {
                    quadExercise1,
                    posteriorChainExercise1,
                    quadExercise2,
                    posteriorChainExercise2,
                    calfExercise1,
                    calfExercise2
                };
            }

            return new List<SessionExercise?>() {
                posteriorChainExercise1,
                quadExercise1,
                posteriorChainExercise2,
                quadExercise2,
                calfExercise1,
                calfExercise2
            };
        }

		public SessionExercise? GenerateSessionExercise(MuscleGroupEnum? muscleGroupEnum, TrainingPhase? phase, ExerciseType exerciseType, int? mesoLength, int? mesoWeek, int? sessionNumber, int? exerciseNumber)
        {
            using var context = new LiftTrackerContextBuilder(Configuration).Build();
            var result = new SessionExercise();

            result.ExerciseId = context
                                    .Exercises?
                                    .SingleOrDefault(x => x.MuscleGroup == muscleGroupEnum && x.SessionNumber == sessionNumber && x.ExerciseNumber == exerciseNumber && x.ExerciseType == exerciseType)?
                                    .Id;
            var exercise = context.Exercises?.FirstOrDefault(x => x.Id == result.ExerciseId);
            if (exercise?.ExerciseType == ExerciseType.Accessory)
            {
                RepRange? repRange;
                if (exercise.IsCompound)
                {
                    repRange = context.RepRanges.FirstOrDefault(x => x.RepRangeType == RepRangeType.AccessoryHypertrophyCompound);
                }
                else
                {
					repRange = context.RepRanges.FirstOrDefault(x => x.RepRangeType == RepRangeType.AccessoryHypertrophyIsolation);
                }
                result.RepRangeId = repRange?.Id;
            }
            else
            {
                RepRange? repRange = null;
                if (phase == TrainingPhase.Hypertrophy)
                {
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

            int volume = 3;
            
            if (phase == TrainingPhase.Hypertrophy)
            {
                if (mesoWeek == 1) {
                    volume = 3;
                }
                if (mesoWeek == 2)
                {
                    volume = 4;
                }
                if (mesoWeek == 3)
                {
                    volume = 5;
                }
                if (mesoWeek == 4)
                {
                    volume = 2;
                }
            }
            else if (phase == TrainingPhase.Strength)
            {
                if (mesoWeek == 1)
                {
                    volume = 3;
                }
                if (mesoWeek == 2)
                {
                    volume = 3;
                }
                if (mesoWeek == 3)
                {
                    volume = 3;
                }
                if (mesoWeek == 4)
                {
                    volume = 2;
                }
            }
            else {
                if (exercise.ExerciseType == ExerciseType.Accessory) {
                    volume = 2;
                }
                else if (mesoWeek == 1)
                {
                    volume = 3;
                }
                if (mesoWeek == 2)
                {
                    volume = 2;
                }
                if (mesoWeek == 3)
                {
                    volume = 1;
                }
                if (mesoWeek == 4)
                {
                    volume = 2;
                }
            }

            var rpe = 9 - (mesoLength - mesoWeek - 1);
            if (mesoWeek == mesoLength || exercise.ExerciseType == ExerciseType.Technique)
            {
                rpe = 5;
            }
            var sets = new List<Set>();
            for (var i = 0; i < volume; i++)
            {
                var set = new Set()
                {
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
