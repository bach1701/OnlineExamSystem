
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamSystem.DataServicesLayer.Model.Tests
{
    public class Test
    {
        [Key]
        public int TestId { get; set; }

        public string Name { get; set; }

        public string Subject { get; set; }

        public DateTime CreateTime { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public int DurationInMinutes { get; set; }

        public string JoinPassword { get; set; }

        public virtual IEnumerable<Question> Questions { get; set; }
    }
}
