using OnlineExamSystem.DataServicesLayer.Model.School;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamSystem.DataServicesLayer.Model.Tests
{
    public class TestTaker
    {
        [Key]
        public int TestTakerId { get; set; }


        [ForeignKey("Test")]
        public int TestId;
        public virtual Test Test { get; set; }

        [ForeignKey("User")]
        public int UserId;
        public virtual User Student { get; set; }


        public float FinalScore { get; set; }

        public int TimeTakenSeconds { get; set; }

        // total question answered
        public int SubmitedAnswerCount { get; set; }

        public int CorrectAnswerCount { get; set; }
    }

}
