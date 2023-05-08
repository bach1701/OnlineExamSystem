using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using OnlineExamSystem.BusinessServicesLayer;
using OnlineExamSystem.DataServicesLayer.Model.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamSystem.DataServicesLayer
{
    public class UserData
    {
        private static UserData _obj = null;
        public static UserData Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new UserData();
                }
                return _obj;
            }
            private set
            {

            }
        }
        private User? CurrentUser;

        public void SetUser(User user) 
        {
            CurrentUser = user;
        }
        public User GetCurrentUser() 
        { 
            return CurrentUser; 
        }
        public bool IsLoggedIn()
        {
            return CurrentUser != null;
        }
        public User GetUserByUsername(string username)
        {
            return OEDB.Instance.GetDatabaseContext()
                .Users.FirstOrDefault(x => x.NumericIdentification == username || x.Email == username);
        }
        public int GetUserId()
        { 
            return CurrentUser.UserId;
        }
        public bool ChangePasswordHash(string NewHash)
        {
            CurrentUser.HashedPassword = NewHash;
            return OEDB.Instance.GetDatabaseContext().SaveChanges() == 1;
        }
    }
}
