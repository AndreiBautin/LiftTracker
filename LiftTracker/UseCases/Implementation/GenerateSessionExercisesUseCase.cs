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

        public IEnumerable<SessionExercise?> Generate(DayOfTheWeek? dayOfTheWeek, TrainingPhase? phase, int mesoWeek)
        {
            switch (dayOfTheWeek)
            {
                case DayOfTheWeek.Monday:
                    return GeneratePush(1, phase, mesoWeek);
                case DayOfTheWeek.Tuesday:
                    return GeneratePull(1, phase, mesoWeek);
                case DayOfTheWeek.Wednesday:
                    return GenerateLegs(1, phase, mesoWeek);
                case DayOfTheWeek.Thursday:
                    return GeneratePush(2, phase, mesoWeek);
                case DayOfTheWeek.Friday:
                    return GeneratePull(2, phase, mesoWeek);
                case DayOfTheWeek.Saturday:
                    return GenerateLegs(2, phase, mesoWeek);
                case DayOfTheWeek.Sunday:
                default:
                    return new List<SessionExercise>();
            }
        }

        public IEnumerable<SessionExercise?> GeneratePush(int sessionNumber, TrainingPhase? phase, int mesoWeek)
        {
            if (sessionNumber == 1) {
                var primaryChestExercise = new SessionExercise();
                if (phase == TrainingPhase.Hypertrophy) {
                    primaryChestExercise = GenerateSessionExercise(MuscleGroup.Chest, phase, EquipmentType.Dumbbell, RepRangeType.MainLiftHypertrophy, true, mesoWeek);
                }
                else if (phase == TrainingPhase.Strength)
                {
                    primaryChestExercise = GenerateSessionExercise(MuscleGroup.Chest, phase, EquipmentType.Barbell, RepRangeType.StrengthBuilding, true, mesoWeek);
                }
                if (phase == TrainingPhase.Peaking)
                {
                    primaryChestExercise = GenerateSessionExercise(MuscleGroup.Chest, phase, EquipmentType.Barbell, RepRangeType.Peaking, true, mesoWeek, true);
                }
                return new List<SessionExercise?>() {
                    primaryChestExercise,
                    GenerateSessionExercise(MuscleGroup.Delts, phase, EquipmentType.MachineHammerStrength, RepRangeType.AccessoryHypertrophyCompound, true, mesoWeek),
                    GenerateSessionExercise(MuscleGroup.Chest, phase, EquipmentType.MachineNautilus, RepRangeType.AccessoryHypertrophyIsolation, false, mesoWeek),
                    GenerateSessionExercise(MuscleGroup.Delts, phase, EquipmentType.MachineNautilus, RepRangeType.AccessoryHypertrophyIsolation, false, mesoWeek),
                    GenerateSessionExercise(MuscleGroup.Triceps, phase, EquipmentType.Dumbbell, RepRangeType.AccessoryHypertrophyIsolation, false, mesoWeek),
                    GenerateSessionExercise(MuscleGroup.Triceps, phase, EquipmentType.MachineCable, RepRangeType.AccessoryHypertrophyIsolation, false, mesoWeek),
                };
            }
            return new List<SessionExercise?>() {
                GenerateSessionExercise(MuscleGroup.Delts, phase, EquipmentType.Dumbbell, RepRangeType.MainLiftHypertrophy, true, mesoWeek),
                GenerateSessionExercise(MuscleGroup.Chest, phase, EquipmentType.Bodyweight, RepRangeType.AccessoryHypertrophyCompound, true, mesoWeek),
                GenerateSessionExercise(MuscleGroup.Delts, phase, EquipmentType.Dumbbell, RepRangeType.AccessoryHypertrophyIsolation, false, mesoWeek),
                GenerateSessionExercise(MuscleGroup.Chest, phase, EquipmentType.Dumbbell, RepRangeType.AccessoryHypertrophyIsolation, false, mesoWeek),
                GenerateSessionExercise(MuscleGroup.Triceps, phase, EquipmentType.Barbell, RepRangeType.AccessoryHypertrophyIsolation, false, mesoWeek),
                GenerateSessionExercise(MuscleGroup.Triceps, phase, EquipmentType.MachineNautilus, RepRangeType.AccessoryHypertrophyIsolation, false, mesoWeek),
            };
        }

        public IEnumerable<SessionExercise?> GeneratePull(int sessionNumber, TrainingPhase? phase, int mesoWeek)
        {
            if (sessionNumber == 1)
            {
                return new List<SessionExercise?>() {
                    GenerateSessionExercise(MuscleGroup.Lats, phase, EquipmentType.Dumbbell, RepRangeType.MainLiftHypertrophy, true, mesoWeek),
                    GenerateSessionExercise(MuscleGroup.Lats, phase, EquipmentType.MachineCable, RepRangeType.AccessoryHypertrophyCompound, true, mesoWeek),
                    GenerateSessionExercise(MuscleGroup.Biceps, phase, EquipmentType.Dumbbell, RepRangeType.AccessoryHypertrophyIsolation, false, mesoWeek),
                    GenerateSessionExercise(MuscleGroup.Biceps, phase, EquipmentType.MachineCable, RepRangeType.AccessoryHypertrophyIsolation, false, mesoWeek),
                    GenerateSessionExercise(MuscleGroup.UpperBack, phase, EquipmentType.MachineNautilus, RepRangeType.AccessoryHypertrophyIsolation, false, mesoWeek),
                    GenerateSessionExercise(MuscleGroup.UpperBack, phase, EquipmentType.Dumbbell, RepRangeType.AccessoryHypertrophyIsolation, false,mesoWeek),
                };
            }

            return new List<SessionExercise?>() {
                GenerateSessionExercise(MuscleGroup.Lats, phase, EquipmentType.Bodyweight, RepRangeType.MainLiftHypertrophy, true, mesoWeek),
                GenerateSessionExercise(MuscleGroup.Lats, phase, EquipmentType.MachineHammerStrength, RepRangeType.AccessoryHypertrophyCompound, true, mesoWeek),
                GenerateSessionExercise(MuscleGroup.Biceps, phase, EquipmentType.Barbell, RepRangeType.AccessoryHypertrophyIsolation, false, mesoWeek),
                GenerateSessionExercise(MuscleGroup.Biceps, phase, EquipmentType.MachineHammerStrength, RepRangeType.AccessoryHypertrophyIsolation, false, mesoWeek),
                GenerateSessionExercise(MuscleGroup.UpperBack, phase, EquipmentType.MachineCable, RepRangeType.AccessoryHypertrophyIsolation, false, mesoWeek),
                GenerateSessionExercise(MuscleGroup.UpperBack, phase, EquipmentType.Barbell, RepRangeType.AccessoryHypertrophyIsolation, false, mesoWeek),
            };
        }

        public IEnumerable<SessionExercise?> GenerateLegs(int sessionNumber, TrainingPhase? phase, int mesoWeek)
        {
            if (sessionNumber == 1)
            {
                var primaryQuadExercise = new SessionExercise();
                if (phase == TrainingPhase.Hypertrophy)
                {
                    primaryQuadExercise = GenerateSessionExercise(MuscleGroup.Quads, phase, EquipmentType.MachineHammerStrength, RepRangeType.MainLiftHypertrophy, true, mesoWeek);
                }
                else if (phase == TrainingPhase.Strength)
                {
                    primaryQuadExercise = GenerateSessionExercise(MuscleGroup.Quads, phase, EquipmentType.Barbell, RepRangeType.StrengthBuilding, true, mesoWeek);
                }
                if (phase == TrainingPhase.Peaking)
                {
                    primaryQuadExercise = GenerateSessionExercise(MuscleGroup.Quads, phase, EquipmentType.Barbell, RepRangeType.MainLiftHypertrophy, true, mesoWeek, true);
                }
                return new List<SessionExercise?>() {
                    primaryQuadExercise,
                    GenerateSessionExercise(MuscleGroup.PosteriorChain, phase, EquipmentType.Bodyweight, RepRangeType.AccessoryHypertrophyCompound, true, mesoWeek),
                    GenerateSessionExercise(MuscleGroup.Quads, phase, EquipmentType.MachineHammerStrength, RepRangeType.AccessoryHypertrophyIsolation, false, mesoWeek),
                    GenerateSessionExercise(MuscleGroup.PosteriorChain, phase, EquipmentType.MachineHammerStrength, RepRangeType.AccessoryHypertrophyIsolation, false, mesoWeek),
                    GenerateSessionExercise(MuscleGroup.Calves, phase, EquipmentType.MachineNautilus, RepRangeType.AccessoryHypertrophyIsolation, false, mesoWeek),
                    GenerateSessionExercise(MuscleGroup.Calves, phase, EquipmentType.MachineHammerStrength, RepRangeType.AccessoryHypertrophyIsolation, false, mesoWeek),
                };
            }

            var primaryPosteriorChainExercise = new SessionExercise();
            if (phase == TrainingPhase.Hypertrophy)
            {
                primaryPosteriorChainExercise = GenerateSessionExercise(MuscleGroup.PosteriorChain, phase, EquipmentType.Dumbbell, RepRangeType.MainLiftHypertrophy, true, mesoWeek);
            }
            else if (phase == TrainingPhase.Strength)
            {
                primaryPosteriorChainExercise = GenerateSessionExercise(MuscleGroup.PosteriorChain, phase, EquipmentType.Barbell, RepRangeType.StrengthBuilding, true, mesoWeek);
            }
            if (phase == TrainingPhase.Peaking)
            {
                primaryPosteriorChainExercise = GenerateSessionExercise(MuscleGroup.PosteriorChain, phase, EquipmentType.Barbell, RepRangeType.MainLiftHypertrophy, true, mesoWeek, true);
            }
            return new List<SessionExercise?>() {
                primaryPosteriorChainExercise,
                GenerateSessionExercise(MuscleGroup.Quads, phase, EquipmentType.Dumbbell, RepRangeType.AccessoryHypertrophyCompound, true, mesoWeek),
                GenerateSessionExercise(MuscleGroup.PosteriorChain, phase, EquipmentType.MachineNautilus, RepRangeType.AccessoryHypertrophyIsolation, false, mesoWeek),
                GenerateSessionExercise(MuscleGroup.Quads, phase, EquipmentType.MachineNautilus, RepRangeType.AccessoryHypertrophyIsolation, false, mesoWeek),
                GenerateSessionExercise(MuscleGroup.Calves, phase, EquipmentType.MachineNautilus, RepRangeType.AccessoryHypertrophyIsolation, false, mesoWeek),
                GenerateSessionExercise(MuscleGroup.Calves, phase, EquipmentType.MachineHammerStrength, RepRangeType.AccessoryHypertrophyIsolation, false, mesoWeek),
            };
        }

        public SessionExercise? GenerateSessionExercise(MuscleGroup? muscleGroup, TrainingPhase? phase, EquipmentType? equipmentType, RepRangeType? repRange, bool isCompound, int mesoWeek, bool isCompetition = false)
        {
            using var context = new LiftTrackerContextBuilder(Configuration).Build();
            var result = new SessionExercise();

            result.ExerciseId = context
                                    .Exercises?
                                    .FirstOrDefault(x => x.MuscleGroup == muscleGroup && x.EquipmentType == equipmentType && x.IsCompetition == isCompetition && x.IsCompound == isCompound)?
                                    .Id;
            result.RepRangeId = context
                                    .RepRanges
                                    .SingleOrDefault(x => x.RepRangeType == repRange)?
                                    .Id;

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
                if (!isCompetition) {
                    volume = 2;
                }
                else if (mesoWeek == 1)
                {
                    volume = 3;
                }
                else if (mesoWeek == 2)
                {
                    volume = 2;
                }
                else if (mesoWeek == 3)
                {
                    volume = 1;
                }
                else if (mesoWeek == 4)
                {
                    volume = 2;
                }
            }

            var rpe = 9 - (3 - mesoWeek);
            if (mesoWeek == 4)
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
