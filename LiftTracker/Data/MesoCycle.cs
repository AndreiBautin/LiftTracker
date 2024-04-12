using System.ComponentModel.DataAnnotations;

namespace LiftTracker.Data
{
    public class MesoCycle
    {
        [Key]
        public int Id { get; set; }
        public TrainingBlock? TrainingBlock { get; set; }
        public IEnumerable<MicroCycle>? MicroCycles { get; set; }
        public bool IsComplete { get; set; }
    }
}
