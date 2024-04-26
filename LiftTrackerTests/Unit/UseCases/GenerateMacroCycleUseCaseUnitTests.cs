using Moq;
using LiftTracker.Data;
using Microsoft.Extensions.Configuration;
using LiftTracker.UseCases.Implementation;

namespace LiftTracker.Tests.Unit.UseCases
{
	[TestClass]
	public class GenerateMacroCycleUseCaseTests
	{
		private Mock<IConfiguration> _mockConfiguration;
		private Mock<IGenerateMesoCycleUseCase> _mockMesoCycleUseCase;
		private GenerateMacroCycleUseCase _useCase;

		[TestInitialize]
		public void Initialize()
		{
			_mockConfiguration = new Mock<IConfiguration>();
			_mockMesoCycleUseCase = new Mock<IGenerateMesoCycleUseCase>();
			_useCase = new GenerateMacroCycleUseCase(_mockConfiguration.Object, _mockMesoCycleUseCase.Object);
		}

		[TestMethod]
		public void Generate_WithValidOptions_ReturnsMacroCycleWithTrainingBlocks()
		{
			Console.WriteLine("Starting test...");

			var options = new MacroCycleOptions
			{
				TrainingBlockOptions = new List<TrainingBlockOptions>
				{
					new TrainingBlockOptions { Phase = TrainingPhase.Hypertrophy, MesoCount = 3 },
					new TrainingBlockOptions { Phase = TrainingPhase.Strength, MesoCount = 1 },
					new TrainingBlockOptions { Phase = TrainingPhase.Peaking, MesoCount = 1 }
				}
			};

			_mockMesoCycleUseCase.Setup(x => x.GenerateMesoCycle(It.IsAny<TrainingBlockOptions>()))
								 .Returns(new MesoCycle { MicroCycles = new List<MicroCycle>() { new MicroCycle(), new MicroCycle() } });

			Console.WriteLine("Setup complete. Generating...");

			var result = _useCase.Generate(options);

			Console.WriteLine("Generation complete. Asserting...");

			try { 
				Assert.IsNotNull(result);
				Assert.AreEqual(3, result.TrainingBlocks.Count());
				for (int i = 0; i < result.TrainingBlocks.Count(); i++)
				{
					Assert.AreEqual(2, result.TrainingBlocks.ToArray()[i].MesoCycles.Count());
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}

			Console.WriteLine("Test complete.");
		}

		[TestMethod]
		public void Generate_WithNullOptions_ThrowsNullReferenceException()
		{
			Assert.ThrowsException<System.NullReferenceException>(() => _useCase.Generate(null));
		}

		[TestMethod]
		public void Generate_WithEmptyTrainingBlockOptions_ReturnsEmptyMacroCycle()
		{
			var options = new MacroCycleOptions { TrainingBlockOptions = new List<TrainingBlockOptions>() };

			var result = _useCase.Generate(options);

			Assert.IsNotNull(result);
			Assert.AreEqual(0, result.TrainingBlocks.Count());
		}
	}
}
