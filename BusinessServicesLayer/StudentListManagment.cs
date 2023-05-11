using OnlineExamSystem.DataServicesLayer;
using OnlineExamSystem.DataServicesLayer.Model.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamSystem.BusinessServicesLayer
{
    public class StudentListForDisplay
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NumericIdentification { get; set; }
        public DateTime Birthday { get; set; }

        public StudentListForDisplay()
        {
        }
    }
    public class StudentListManagment
    {
        private Class CurrentClasses;

        public StudentListManagment(int ClassID) 
        {
            CurrentClasses = ClassData.Instance.GetClassById(ClassID);
        }
        public List<StudentListForDisplay> GetStudentListInClass()
        {
            List<StudentListForDisplay> StudentListForDisplays = new List<StudentListForDisplay>();
            if (CurrentClasses.Students == null)
                return StudentListForDisplays;

            foreach (var classStudent in CurrentClasses.Students)
            {
                StudentListForDisplay Ens = new StudentListForDisplay();
                Ens.Name = classStudent.Student.FirstName + " " + classStudent.Student.LastName;
                Ens.Birthday = classStudent.Student.Birthday;
                Ens.NumericIdentification = classStudent.Student.NumericIdentification;

                StudentListForDisplays.Add(Ens);
            }
            return StudentListForDisplays;
        }
        public bool AddStudentToCurrentClass(string Name, string MSSV, DateTime Birthday)
        {
            // check if student already have an account

            User Student;
            bool NewAccountCreated = false;
            string NumericIdentification = "";
            string Password = "";

            Student = UserData.Instance.GetUserByUsername(MSSV);
            if (Student == null)
            { 
                // create an account first
                NumericIdentification = MSSV;
                Password = MSSV;
                Student = UserData.Instance.CreateNewStudentAccount(Name, NumericIdentification, Password, Birthday);
                if (Student == null)
                    throw new Exception("An error occured, at CreateNewStudentAccount.");

                // notify password
                NewAccountCreated = true;
            }

            // add to class

            ClassStudent classStudent = new ClassStudent
            {
                ClassId = CurrentClasses.ClassId,
                Class = CurrentClasses,
                UserId = Student.UserId,
                Student = Student
            };
            bool AddSuccess = ClassData.Instance.AddStudentToClass(CurrentClasses, classStudent);
            if (AddSuccess && NewAccountCreated) 
            {
                MessageBox.Show("Đã tạo mới tài khoản học sinh\nTên đăng nhập: " + NumericIdentification + "\nMật khẩu: " + Password);
            }
            return AddSuccess;
        }
        public string GetClassName()
        {
            return CurrentClasses.Name;
        }
        public string GetClassCourseName()
        {
            return CurrentClasses.CourseName;
        }
    }
}
