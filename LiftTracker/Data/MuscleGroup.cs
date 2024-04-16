using System.ComponentModel.DataAnnotations;

namespace LiftTracker.Data
{
    public class MuscleGroup
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public MuscleGroupEnum MuscleGroupEnum { get; set; }
	}
}
