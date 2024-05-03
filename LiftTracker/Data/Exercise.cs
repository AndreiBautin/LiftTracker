using System.ComponentModel.DataAnnotations;

namespace LiftTracker.Data
{
    public class Exercise
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public MuscleGroupEnum? MuscleGroup { get; set; }
        public ExerciseType? ExerciseType { get; set; }
        public bool IsCompound { get; set; }
        public string? ApplicationUserId { get; set; }
        public int? SessionNumber { get; set; }
        public int? ExerciseNumber { get; set; }
    }
}
