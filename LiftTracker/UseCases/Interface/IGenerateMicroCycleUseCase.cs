using LiftTracker.Data;

public interface IGenerateMicroCycleUseCase
{
    MicroCycle GenerateMicroCycle(TrainingBlockOptions options, int week);
}
