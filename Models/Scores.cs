using System;
using System.Collections.Generic;

namespace JSON_Student_App.Models
{
    public partial class Scores
    {
        public int ScoresId { get; set; }
        public int GameId { get; set; }
        public int StudentId { get; set; }
        public int TeacherId { get; set; }
        public DateTime AttemptTime { get; set; }
        public int NumberQuestions { get; set; }
        public int NumberCorrect { get; set; }
        public int Difficulty { get; set; }

        public virtual Students Student { get; set; }
        public virtual Teachers Teacher { get; set; }
    }
}
