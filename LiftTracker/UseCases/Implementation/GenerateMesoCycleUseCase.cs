using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using LiftTracker.Data;

namespace LiftTracker.UseCases.Implementation
{
    public class GenerateMesoCycleUseCase : IGenerateMesoCycleUseCase
    {
        private IConfiguration Configuration;
        private IGenerateMicroCycleUseCase MicroUseCase;

        public GenerateMesoCycleUseCase(IConfiguration configuration, IGenerateMicroCycleUseCase microUseCase)
        {
            Configuration = configuration;
            MicroUseCase = microUseCase;
        }

        public MesoCycle GenerateMesoCycle(TrainingBlockOptions? options)
        {
            var result = new MesoCycle { MicroCycles = new List<MicroCycle>() };
            for (int i = 1; i <= options?.MesoLength; i++)
            {
                var microCycle = MicroUseCase.GenerateMicroCycle(options, i);
                result.MicroCycles.ToList().Add(microCycle);
            }
            return result;
        }
    }
}
