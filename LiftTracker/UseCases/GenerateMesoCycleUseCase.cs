using LiftTracker.Data;
using System.Linq.Expressions;

namespace LiftTracker.UseCases
{
    public class GenerateMesoCycleUseCase
    {
        private IConfiguration Configuration;
        public GenerateMesoCycleUseCase(IConfiguration configuration) {
            Configuration = configuration;
        }

        public MesoCycle GenerateMesoCycle(TrainingBlockOptions? options)
        {
            var result = new MesoCycle();
            result.MicroCycles = new List<MicroCycle>();
            var useCase = new GenerateMicroCycleUseCase(Configuration);

            for (int i = 1; i <= options?.MesoLength; i++)
            {
                var microCycle = useCase.GenerateMicroCycle(options, i);
                result.MicroCycles = result.MicroCycles.ToList().Append(microCycle).ToList();
            }

            return result;
        }
    }
}
