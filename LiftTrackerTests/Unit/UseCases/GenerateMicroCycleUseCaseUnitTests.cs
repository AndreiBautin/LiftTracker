using Moq;
using LiftTracker.Data;
using Microsoft.Extensions.Configuration;
using LiftTracker.UseCases.Implementation;

namespace LiftTracker.Tests.Unit.UseCases
{
    [TestClass]
    public class GenerateMicroCycleUseCaseTests
    {
        private Mock<IConfiguration> _mockConfiguration;
        private Mock<IGenerateSessionExerciseUseCase> _mockSessionExerciseUseCase;
        private GenerateMicroCycleUseCase _useCase;

        [TestInitialize]
        public void Initialize()
        {
            _mockConfiguration = new Mock<IConfiguration>();
            _mockSessionExerciseUseCase = new Mock<IGenerateSessionExerciseUseCase>();
            _useCase = new GenerateMicroCycleUseCase(_mockConfiguration.Object, _mockSessionExerciseUseCase.Object);
        }

        [TestMethod]
        public void GenerateMicroCycle_WithValidOptions_ReturnsCompleteMicroCycle()
        {
            var options = new TrainingBlockOptions { TrainingPhase = TrainingPhase.Hypertrophy, MesoLength = 4, MesoCount = 4 };
            var result = _useCase.GenerateMicroCycle(options, 1);

            Assert.IsNotNull(result);
            Assert.AreEqual(6, result.Sessions?.Count());
            foreach (var session in result.Sessions)
            {
                Assert.IsNotNull(session.SessionExercises);
            }
        }

        [TestMethod]
        public void GenerateMicroCycle_WithNullOptions_ReturnsEmptyMicroCycle()
        {
            var result = _useCase.GenerateMicroCycle(null, 1);
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Sessions?.Count());
        }

        [TestMethod]
        public void GenerateMicroCycle_WithMaxWeekNumber_ReturnsExpectedMicroCycle()
        {
            var options = new TrainingBlockOptions { TrainingPhase = TrainingPhase.Peaking, MesoLength = 5 };
            var result = _useCase.GenerateMicroCycle(options, 5);

            Assert.IsNotNull(result);
            Assert.AreEqual(6, result.Sessions.Count());
        }
    }
}
