using System.ComponentModel.DataAnnotations;

namespace LiftTracker.Data
{
    public class RepRange
    {
        [Key]
        public int Id { get; set; }
        public RepRangeType RepRangeType { get; set; }
        public int Low { get; set; }
        public int High { get; set; }
    }
}
