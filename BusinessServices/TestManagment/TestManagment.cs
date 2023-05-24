using OnlineExamSystem.DataServicesLayer.Model.School;
using OnlineExamSystem.DataServicesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineExamSystem.DataServicesLayer.Model.Tests;

namespace OnlineExamSystem.BusinessServices.TestManagment
{
    class TestManagment
    {
        private static TestManagment _Instance = null;
        public static TestManagment Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new TestManagment();
                return _Instance;
            }
            private set
            {

            }
        }


        public IEnumerable<Test> GetAllTestCreatedByCurrentTeacher()
        {
            return null;
        }
        public void CreateNewTest()
        {

        }
    }
}

