using LiftTracker.Data;
using System.Collections.Generic;

public interface IGenerateSessionExerciseUseCase
{
	/// <summary>
	/// Generates session exercises based on the day of the week, training phase, mesocycle length, and week number.
	/// </summary>
	/// <param name="dayOfTheWeek">Day of the week for which to generate exercises.</param>
	/// <param name="phase">Training phase (e.g., Hypertrophy, Strength, Peaking).</param>
	/// <param name="mesoLength">Length of the mesocycle in weeks.</param>
	/// <param name="mesoWeek">Current week number within the mesocycle.</param>
	/// <returns>An enumerable of session exercises.</returns>
	IEnumerable<SessionExercise?> Generate(DayOfTheWeek? dayOfTheWeek, TrainingPhase? phase, int? mesoLength, int? mesoWeek);

	/// <summary>
	/// Generates "push" session exercises based on provided criteria.
	/// </summary>
	/// <param name="sessionNumber">Session number (1 or 2).</param>
	/// <param name="phase">Training phase.</param>
	/// <param name="mesoLength">Mesocycle length.</param>
	/// <param name="mesoWeek">Week number in the mesocycle.</param>
	/// <returns>An enumerable of session exercises for push workouts.</returns>
	IEnumerable<SessionExercise?> GeneratePush(int sessionNumber, TrainingPhase? phase, int? mesoLength, int? mesoWeek);

	/// <summary>
	/// Generates "pull" session exercises based on provided criteria.
	/// </summary>
	/// <param name="sessionNumber">Session number (1 or 2).</param>
	/// <param name="phase">Training phase.</param>
	/// <param name="mesoLength">Mesocycle length.</param>
	/// <param name="mesoWeek">Week number in the mesocycle.</param>
	/// <returns>An enumerable of session exercises for pull workouts.</returns>
	IEnumerable<SessionExercise?> GeneratePull(int sessionNumber, TrainingPhase? phase, int? mesoLength, int? mesoWeek);

	/// <summary>
	/// Generates "legs" session exercises based on provided criteria.
	/// </summary>
	/// <param name="sessionNumber">Session number (1 or 2).</param>
	/// <param name="phase">Training phase.</param>
	/// <param name="mesoLength">Mesocycle length.</param>
	/// <param name="mesoWeek">Week number in the mesocycle.</param>
	/// <returns>An enumerable of session exercises for leg workouts.</returns>
	IEnumerable<SessionExercise?> GenerateLegs(int sessionNumber, TrainingPhase? phase, int? mesoLength, int? mesoWeek);
}
