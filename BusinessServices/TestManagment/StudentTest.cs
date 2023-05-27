using OnlineExamSystem.DataServices.Method.Tests;
using OnlineExamSystem.DataServicesLayer.Model.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
