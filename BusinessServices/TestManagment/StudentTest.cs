using OnlineExamSystem.DataServices.Method.Tests;
using OnlineExamSystem.DataServicesLayer.Model.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamSystem.BusinessServices.TestManagment
{
    public class StudentTest
    {
        private static StudentTest _Instance = null;
        public static StudentTest Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new StudentTest();
                return _Instance;
            }
            private set
            {

            }
        }
        private List<Test> Tests = null;

        public List<Test> GetAllTestAssigned()
        {
            Tests = TestData.Instance.GetAllUpcomingTestFromTakerList();
            return Tests;
        }
        // section: test join + work
        private Test Exam;
      
        public void SetDoTest(Test test)
        {
            Exam = test;
        }
        public bool RequestDoTest(string Password, ref string ErrorMessage)
        {
            if (Exam.JoinPassword.Length > 0)
            {
                string EnteredPassword = Password;
                if (EnteredPassword.Length <= 0)
                {
                    ErrorMessage = "Vui lòng nhập mật khẩu.";
                    return false;
                }
                if (EnteredPassword != Exam.JoinPassword)
                {
                    ErrorMessage = "Mật khẩu làm bài không chính xác. Vui lòng thử lại.";
                    return false;
                }
            }
            return true;
        }

    }
}
