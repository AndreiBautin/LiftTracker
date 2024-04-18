using System.ComponentModel.DataAnnotations;

namespace LiftTracker.Data
{
    public class SessionExercise
    {
        [Key]
        public int Id { get; set; }
        public Session? Session { get; set; }
        public int? SessionId { get; set; }
        public int? ExerciseId { get; set; }
        public IEnumerable<Set>? Sets { get; set; }
        public int? RepRangeId { get; set; }
    }
}
