using System.ComponentModel.DataAnnotations;

namespace LiftTracker.Data
{
    public class Exercise
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public MuscleGroup? MuscleGroup { get; set; }
        public EquipmentType? EquipmentType { get; set; }
        public bool IsCompound { get; set; }
        public bool IsCompetition { get; set; }
        public string? ApplicationUserId { get; set; }
    }
}
