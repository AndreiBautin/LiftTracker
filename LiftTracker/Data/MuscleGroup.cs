using System.ComponentModel.DataAnnotations;

namespace LiftTracker.Data
{
    public class MuscleGroup
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int MV { get; set; }
        public int MEV { get; set; }
        public int MRV { get; set; }
        public MuscleGroupEnum MuscleGroupEnum { get; set; }
		public int Frequency { get; set; }
		public int ExercisesPerSession { get; set; }
	}
}
