using OnlineExamSystem.DataServicesLayer.Model.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineExamSystem.DataServicesLayer;

namespace OnlineExamSystem.BusinessServicesLayer
{
    public class Session
    {
        private static Session _Instance = null;
        public static Session Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new Session();
                return _Instance;
            }
            private set
            {

            }
        }

        public bool Login(string username, string password)
        {
            if (!UserData.Instance.IsLoggedIn())
            {
                var Account = UserData.Instance.GetUserByUsername(username);
                if (Account == null)
                {
                    MessageBox.Show("Tài khoản không tồn tại trên hệ thống.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else
                {
                    if (Helper.VerifyPassword(password, Account.HashedPassword))
                    {
                        UserData.Instance.SetUser(Account);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Sai mật khẩu. Vui lòng kiểm tra lại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return false;
        }
        public bool ChangePassword(string OldPassword, string NewPassword) 
        {
            if (!UserData.Instance.IsLoggedIn())
                return false;

            if (!Helper.VerifyPassword(OldPassword, UserData.Instance.GetUser().HashedPassword))
                return false;

            string NewPasswordHash = Helper.HashPassword(NewPassword);
            UserData.Instance.ChangePasswordHash(NewPasswordHash);
            return true;
        }
    }
}
