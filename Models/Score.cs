using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JSON_Student_App.Models
{
    public class Score
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int GameID { get; set; }
        public int StudentID { get; set; }
        public int NumberQuestions { get; set; }
        public int NumberCorrect { get; set; }
        public DateTime Time {get; set;}  
        public int TeacherID { get; set; }
    }
}
