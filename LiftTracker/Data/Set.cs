using System.ComponentModel.DataAnnotations;

namespace LiftTracker.Data
{
	public class Set
	{
        [Key]
        public int Id { get; set; }
		public SessionExercise? SessionExercise { get; set; }
		public decimal? Load { get; set; }
        public int? Reps { get; set; }
		public int? TargetRpe { get; set; }
        public int? Rpe{ get; set; }
		public bool IsComplete { get; set; }
		public bool IsSkipped { get; set; }
	}
}
