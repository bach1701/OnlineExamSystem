using OnlineExamSystem.BusinessServicesLayer;
using OnlineExamSystem.DataServicesLayer;
using OnlineExamSystem.DataServicesLayer.Model.School;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineExamSystem.PresentationLayer
{
    public partial class UserInformation : UserControl
    {
        public UserInformation()
        {
            InitializeComponent();
        }

        private void UserInformation_Load(object sender, EventArgs e)
        {
            if (UserData.Instance.IsLoggedIn()) 
            { 
                User CurrentLoggedUserInfo = UserData.Instance.GetCurrentUser(); 

                txtName.Text = CurrentLoggedUserInfo.FirstName + " " + CurrentLoggedUserInfo.LastName;
                txtBirthday.Text = CurrentLoggedUserInfo.Birthday.ToShortDateString();
                txtNumericUserID.Text = CurrentLoggedUserInfo.NumericIdentification;
                txtEmail.Text = CurrentLoggedUserInfo.Email;
                txtClassname.Text = CurrentLoggedUserInfo.GetFirstClassName();
                txtPhoneNumber.Text = "";
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void ChangePasswordOK_Click(object sender, EventArgs e)
        {
            if (InputOldPassword.Text.Length < 4 ||
                InputNewPassword.Text.Length < 4 ||
                InputRetypeNewPassword.Text.Length < 4
                )
            {
                MessageBox.Show("Mật khẩu nhập không hợp lệ.");
                return;
            }
            if ( InputNewPassword.Text != InputRetypeNewPassword.Text)
            {
                MessageBox.Show("Nhập lại mật khẩu không khớp.");
                return;
            }
            if (!UserManagment.Instance.ChangePassword(InputOldPassword.Text, InputNewPassword.Text))
            {
                MessageBox.Show("Mật khẩu cũ không đúng.");
                return;
            }
            MessageBox.Show("Đổi mật khẩu thành công.");
        }

        private void ChangePasswordResetAll_Click(object sender, EventArgs e)
        {
            InputOldPassword.Text = "";
            InputNewPassword.Text = "";
            InputRetypeNewPassword.Text = "";
        }
    }
}
