using LiftTracker.Data;

public interface IGenerateMesoCycleUseCase
{
    MesoCycle GenerateMesoCycle(TrainingBlockOptions? options);
}
