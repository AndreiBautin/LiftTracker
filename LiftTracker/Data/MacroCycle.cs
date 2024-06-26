﻿using System.ComponentModel.DataAnnotations;

namespace LiftTracker.Data
{
    public class MacroCycle
    {
        [Key]
        public int Id { get; set; }
		public string? ApplicationUserId { get; set; }
		public IEnumerable<TrainingBlock>? TrainingBlocks { get; set; }
    }
}
