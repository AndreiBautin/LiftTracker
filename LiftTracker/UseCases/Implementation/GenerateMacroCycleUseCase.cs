using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;
using LiftTracker.Data;

namespace LiftTracker.UseCases.Implementation
{
    public class GenerateMacroCycleUseCase : IGenerateMacroCycleUseCase
    {
        private IConfiguration Configuration;
        private IGenerateMesoCycleUseCase MesoUseCase;

		public GenerateMacroCycleUseCase(IConfiguration configuration, IGenerateMesoCycleUseCase mesoUseCase)
        {
            Configuration = configuration;
            MesoUseCase = mesoUseCase;
        }

        public MacroCycle Generate(MacroCycleOptions options)
        {
            var result = new MacroCycle { TrainingBlocks = new List<TrainingBlock>() };
            var trainingPhases = ((IEnumerable<TrainingPhase>)Enum.GetValues(typeof(TrainingPhase))).OrderBy(x => x).ToList();

            foreach (var trainingPhase in trainingPhases)
            {
                var trainingBlockOptions = options.TrainingBlockOptions.FirstOrDefault(x => x.Phase == trainingPhase);
                if (trainingBlockOptions != null)
                {
                    var trainingBlock = new TrainingBlock
                    {
                        TrainingPhase = trainingPhase,
                        MesoCycles = new List<MesoCycle>()
                    };

                    for (int i = 0; i < trainingBlockOptions.MesoCount; i++)
                    {
                        var mesoCycle = MesoUseCase.GenerateMesoCycle(trainingBlockOptions);
                        trainingBlock.MesoCycles = trainingBlock.MesoCycles.Append(mesoCycle).ToList();
                    }
                    result.TrainingBlocks = result.TrainingBlocks.Append(trainingBlock).ToList();
                }
            }

            return result;
        }
    }
}
