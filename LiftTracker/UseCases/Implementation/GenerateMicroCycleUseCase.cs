using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using LiftTracker.Data;
using System.Collections.Generic;
using LiftTracker.UseCases.Implementation;

namespace LiftTracker.UseCases.Implementation
{
    public class GenerateMicroCycleUseCase : IGenerateMicroCycleUseCase
    {
        private IConfiguration Configuration;
        private IGenerateSessionExerciseUseCase SessionExerciseUseCase;

        public GenerateMicroCycleUseCase(IConfiguration configuration, IGenerateSessionExerciseUseCase sessionExerciseUseCase)
        {
            Configuration = configuration;
            SessionExerciseUseCase = sessionExerciseUseCase;
        }

        public MicroCycle GenerateMicroCycle(TrainingBlockOptions options, int week)
        {
            var result = new MicroCycle() {
                Sessions = new List<Session>()
            };

            if (options == null) {
                return result;
            }

            var sessions = new List<Session>
            {
                new Session { MicroCycle = result, SessionExercises = new List<SessionExercise>(), DayOfTheWeek = DayOfTheWeek.Monday },
                new Session { MicroCycle = result, SessionExercises = new List<SessionExercise>(), DayOfTheWeek = DayOfTheWeek.Tuesday },
                new Session { MicroCycle = result, SessionExercises = new List<SessionExercise>(), DayOfTheWeek = DayOfTheWeek.Wednesday },
                new Session { MicroCycle = result, SessionExercises = new List<SessionExercise>(), DayOfTheWeek = DayOfTheWeek.Thursday },
                new Session { MicroCycle = result, SessionExercises = new List<SessionExercise>(), DayOfTheWeek = DayOfTheWeek.Friday },
                new Session { MicroCycle = result, SessionExercises = new List<SessionExercise>(), DayOfTheWeek = DayOfTheWeek.Saturday },
            };

            foreach (var session in sessions)
            {
                session.SessionExercises = SessionExerciseUseCase.Generate(session.DayOfTheWeek, options?.TrainingPhase, options?.MesoLength, week, options.TrainingSplit);
            }

            result.Sessions = sessions;
            return result;
        }
    }
}
