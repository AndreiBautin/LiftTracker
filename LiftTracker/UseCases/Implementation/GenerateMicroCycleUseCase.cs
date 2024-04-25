using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using LiftTracker.Data;
using System.Collections.Generic;
using LiftTracker.UseCases.Implementation;

namespace LiftTracker.UseCases
{
    public class GenerateMicroCycleUseCase : IGenerateMicroCycleUseCase
    {
        private IConfiguration Configuration;

        public GenerateMicroCycleUseCase(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public MicroCycle GenerateMicroCycle(TrainingBlockOptions options, int week)
        {
            using var context = new LiftTrackerContextBuilder(Configuration).Build();
            var result = new MicroCycle();
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
                session.SessionExercises = new GenerateSessionExercisesUseCase(Configuration).Generate(session.DayOfTheWeek, options?.Phase, options?.MesoLength, week);
            }

            result.Sessions = sessions;
            return result;
        }
    }
}
