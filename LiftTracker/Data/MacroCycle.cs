using System.ComponentModel.DataAnnotations;

namespace LiftTracker.Data
{
    public class MacroCycle
    {
        [Key]
        public int Id { get; set; }
        public IEnumerable<TrainingBlock>? TrainingBlocks { get; set; }
        public bool IsComplete { get; set; }
    }
}
