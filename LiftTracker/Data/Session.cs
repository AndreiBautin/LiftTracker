using System.ComponentModel.DataAnnotations;

namespace LiftTracker.Data
{
    public class Session
    {
        [Key]
        public int Id { get; set; }
        public MicroCycle? MicroCycle { get; set; }
        public IEnumerable<SessionExercise?>? SessionExercises { get; set; }
        public DayOfTheWeek? DayOfTheWeek { get; set;}
        public bool IsComplete { get; set; }
    }
}
