using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamSystem.DataServicesLayer.Model.School
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public ICollection<Class> OwnedClasses { get; set; }
       
        public ICollection<ClassStudent> Classes { get; set; }

        [Required]
        public string MSSV { get; set; }

        [Required]
        public string HashedPassword { get; set; }


        public string Email { get; set; }

        [Required]
        public int AccRole { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }


        public Gender Gender { get; set; }
        public DateTime Birthday { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime InfoUpdatedAt { get; set; }

        public User()
        {

        }
        public User(int id, string mSSV, string hashedPassword, string email, int accRole, string firstName, string lastName, Gender gender, DateTime birthday, DateTime createdAt, DateTime infoUpdatedAt)
        {
            UserId = id;
            MSSV = mSSV;
            HashedPassword = hashedPassword;
            Email = email;
            AccRole = accRole;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Birthday = birthday;
            CreatedAt = createdAt;
            InfoUpdatedAt = infoUpdatedAt;
        }
    }
    public enum AccRole
    {
        Student,
        Teacher,
        Administrator
    }
    public enum Gender
    {
        None,
        Male,
        Female
    }
}
