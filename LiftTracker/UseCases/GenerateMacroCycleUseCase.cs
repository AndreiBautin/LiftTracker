using LiftTracker.Data;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System.Linq.Expressions;

namespace LiftTracker.UseCases
{
    public class GenerateMacroCycleUseCase
    {
        private IConfiguration Configuration;

        public GenerateMacroCycleUseCase(IConfiguration configuration) {
            Configuration = configuration;
        }

        public MacroCycle Generate(MacroCycleOptions options) { 
            var result = new MacroCycle();
            result.TrainingBlocks = new List<TrainingBlock>();

            var mesoUseCase = new GenerateMesoCycleUseCase(Configuration);
            var trainingPhases = ((IEnumerable<TrainingPhase>)Enum.GetValues(typeof(TrainingPhase))).ToList().OrderBy(x => x).ToList();

            if (trainingPhases != null) { 
                foreach (var trainingPhase in trainingPhases) {
                    var trainingBlockOptions = options?.TrainingBlockOptions?.Where(x => x.Phase == trainingPhase).SingleOrDefault();
                    if (trainingBlockOptions != null) {
                        var trainingBlock = new TrainingBlock() { 
                            TrainingPhase = trainingPhase,
                        };
                        trainingBlock.MesoCycles = new List<MesoCycle>();
                        for (var i = 0; i < trainingBlockOptions.MesoCount; i++) { 
                            var mesoCycle = mesoUseCase.GenerateMesoCycle(trainingBlockOptions);
                            trainingBlock.MesoCycles = trainingBlock.MesoCycles.Append(mesoCycle).ToList();
                        }
                        result.TrainingBlocks = result.TrainingBlocks.Append(trainingBlock).ToList();
					}
				}            
            }

            return result;
        }
    }
}
