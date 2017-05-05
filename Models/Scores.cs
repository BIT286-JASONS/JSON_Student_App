using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JSON_Student_App.Models
{
    public class Scores
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int GameID { get; set; }
        public int studentID { get; set; }
        public int numQuestions { get; set; }
        public int numWrong { get; set; }
        public DateTime data {get; set;}        
    }
}
