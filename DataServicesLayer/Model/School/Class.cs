using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamSystem.DataServicesLayer.Model.School
{
    public class Class
    {
        [Key]
        public int ClassId { get; set; }

        public string Name { get; set; }
        public string CourseName { get; set; }
        public int StudentCount { get; set; }


        public ICollection<ClassStudent> Students { get; set; }
    }
    public class ClassStudent
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User SUser { get; set; }

        [ForeignKey("Class")]
        public int ClassId { get; set; }
        public Class Class { get; set; }
    }
}
