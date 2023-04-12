using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamSystem.DataServicesLayer.Model.Tests
{
    public class Question
    {
        [Key]
        public int QuestionId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public decimal Mark { get; set; }
        [Required]
        public string Hint { get; set; }


        public ICollection<Answer> AnswerOptions { get; set; }
    }
    public class Answer
    {
        [Key]
        public int AnswerId { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public bool IsCorrect { get; set; }
    }
}
