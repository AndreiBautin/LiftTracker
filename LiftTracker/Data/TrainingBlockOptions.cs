﻿namespace LiftTracker.Data
{
    public class TrainingBlockOptions
    {
        public int MesoLength { get; set; }
        public int MesoCount { get; set; }
        public TrainingPhase TrainingPhase { get; set; }
        public TrainingSplit TrainingSplit { get; set; }
    }
}
