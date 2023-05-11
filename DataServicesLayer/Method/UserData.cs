using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using OnlineExamSystem.BusinessServicesLayer;
using OnlineExamSystem.DataServicesLayer.Model.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
        public bool CreateNewUser(User user)
        {
            OEDB.Instance.GetDatabaseContext().Users.Add(user);
            return OEDB.Instance.GetDatabaseContext().SaveChanges() == 1;
        }
        public User CreateNewStudentAccount(string Name, string Identification, string Password, DateTime Birthday)
        {
            // new student object
            User NewStudent = new User();
            NewStudent.InfoUpdatedAt = DateTime.Now;
            NewStudent.CreatedAt = DateTime.Now;
            NewStudent.AccRole = (int)AccRole.Student;
            NewStudent.FirstName = Name;
            NewStudent.LastName = "";
            NewStudent.NumericIdentification = Identification;
            NewStudent.Email = "";
            NewStudent.AvatarURL = "";
            NewStudent.Gender = Gender.None;
            NewStudent.Birthday = Birthday;
            NewStudent.HashedPassword = Helper.HashPassword(Password);
            // call

            if (CreateNewUser(NewStudent))
                return NewStudent;

            return null;
        }
    }
}
