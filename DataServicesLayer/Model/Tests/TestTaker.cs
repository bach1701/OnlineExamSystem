using OnlineExamSystem.DataServicesLayer.Model.School;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public virtual User Student { get; set; }
        public virtual Test Test { get; set; }
        public AccRole Role { get; set; }

    }
}
