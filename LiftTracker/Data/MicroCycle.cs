using System.ComponentModel.DataAnnotations;

namespace LiftTracker.Data
{
    public class MicroCycle
    {
        [Key]
        public int Id { get; set; }
        public MesoCycle? MesoCycle { get; set; }
        public IEnumerable<Session>? Sessions { get; set; }
    }
}
