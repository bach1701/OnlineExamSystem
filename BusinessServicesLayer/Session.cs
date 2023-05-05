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

        private User? CurrentUser;

        public bool Login(string username, string password)
        {
            if (CurrentUser == null)
            {
                var Account = OEDB.Instance.GetUserByUsername(username);
                if (Account == null)
                {
                    MessageBox.Show("Tài khoản không tồn tại trên hệ thống.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else
                {
                    if (Helper.VerifyPassword(password, Account.HashedPassword))
                    {
                        CurrentUser = Account;
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
        public User GetCurrentUser()
        {
            return CurrentUser;
        }

    }
}
