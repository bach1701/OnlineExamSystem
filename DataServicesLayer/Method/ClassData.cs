using OnlineExamSystem.DataServicesLayer.Model.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamSystem.DataServicesLayer
{
    public class ClassData
    {
        private static ClassData _obj = null;
        public static ClassData Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new ClassData();
                }
                return _obj;
            }
            private set
            {

            }
        }
        public IEnumerable<Class> GetAllClassByCurrentTeacher()
        {
            User CurrentUser = UserData.Instance.GetCurrentUser();
            if (CurrentUser == null || (AccRole)CurrentUser.AccRole != AccRole.Teacher)
                return null;

            int RequestedTeacherId = CurrentUser.UserId;

            var classes = OEDB.Instance.GetDatabaseContext().Classes
                .Where(c => c.OwnedTeacherId == RequestedTeacherId)
                .ToList();

            return classes;
        }
        public bool AddNewClassByCurrentTeacher(Class NewClass)
        {
            User CurrentUser = UserData.Instance.GetCurrentUser();
            if (CurrentUser == null || (AccRole)CurrentUser.AccRole != AccRole.Teacher)
                return false;

            NewClass.OwnedTeacherId = CurrentUser.UserId;
            NewClass.OwnedTeacher = CurrentUser;
            NewClass.Students = new List<ClassStudent>();

            OEDB.Instance.GetDatabaseContext().Classes
                .Add(NewClass);

            return OEDB.Instance.GetDatabaseContext().SaveChanges() == 1;
        }
    }
}
