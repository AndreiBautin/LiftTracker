using Moq;
using LiftTracker.Data;
using Microsoft.Extensions.Configuration;
using LiftTracker.UseCases.Implementation;

namespace LiftTracker.Tests.Unit.UseCases
{
    [TestClass]
    public class GenerateMesoCycleUseCaseTests
    {
        private Mock<IConfiguration> _mockConfiguration;
        private Mock<IGenerateMicroCycleUseCase> _mockMicroCycleUseCase;
        private GenerateMesoCycleUseCase _useCase;

        [TestInitialize]
        public void Initialize()
        {
            _mockConfiguration = new Mock<IConfiguration>();
            _mockMicroCycleUseCase = new Mock<IGenerateMicroCycleUseCase>();
            _useCase = new GenerateMesoCycleUseCase(_mockConfiguration.Object, _mockMicroCycleUseCase.Object);
        }

        [TestMethod]
        public void GenerateMesoCycle_WithNullOptions_ReturnsEmptyMesoCycle()
        {
            var result = _useCase.GenerateMesoCycle(null);

            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.MicroCycles.Count());
        }

        [TestMethod]
        public void GenerateMesoCycle_WithZeroMesoLength_ReturnsEmptyMesoCycle()
        {
            var options = new TrainingBlockOptions { MesoLength = 0 };
            var result = _useCase.GenerateMesoCycle(options);

            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.MicroCycles.Count());
        }

        [TestMethod]
        public void GenerateMesoCycle_CallsMicroCycleUseCaseCorrectNumberOfTimes()
        {
            var options = new TrainingBlockOptions { MesoLength = 2 };
            _mockMicroCycleUseCase.Setup(x => x.GenerateMicroCycle(It.IsAny<TrainingBlockOptions>(), It.IsAny<int>()))
                                  .Returns(new MicroCycle());

            _useCase.GenerateMesoCycle(options);

            _mockMicroCycleUseCase.Verify(x => x.GenerateMicroCycle(It.IsAny<TrainingBlockOptions>(), It.IsAny<int>()), Times.Exactly(2));
        }
    }
}
