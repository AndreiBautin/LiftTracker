using System.ComponentModel.DataAnnotations;

namespace LiftTracker.Data
{
    public class TrainingBlock
    {
        [Key]
        public int Id { get; set; }
        public MacroCycle? MacroCycle { get; set; }
        public IEnumerable<MesoCycle>? MesoCycles { get; set; }
        public TrainingPhase TrainingPhase { get; set; }
        public bool IsComplete { get; set; }
    }
}
