using OnlineExamSystem.DataServicesLayer;
using OnlineExamSystem.DataServicesLayer.Model.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamSystem.BusinessServicesLayer
{
    public class ClassManagment
    {
        // lay ds toan bo lop hoc
        // lay ds lop hoc giao vien dang dang nhap co tham gia giang day
        private static ClassManagment _Instance = null;
        public static ClassManagment Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new ClassManagment();
                return _Instance;
            }
            private set
            {

            }
        }


        public IEnumerable<Class> GetAllClassByCurrentTeacher()
        {
            return ClassData.Instance.GetAllClassByCurrentTeacher();
        }
        public bool AddNewClass(Class c)
        {
            // sang loc du lieu trc khi call
            return ClassData.Instance.AddNewClassByCurrentTeacher(c);
        }
        //  
    }
}
