using OnlineExamSystem.DataServicesLayer.Model.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamSystem.DataServicesLayer.Method
{
    public class StudentData
    {
        private static StudentData _obj = null;
        public static StudentData Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new StudentData();
                }
                return _obj;
            }
            private set
            {

            }
        }
    }
}
