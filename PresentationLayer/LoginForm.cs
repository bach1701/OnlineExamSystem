#define TEST_LOGIN

using OnlineExamSystem.BusinessServicesLayer;
using OnlineExamSystem.DataServicesLayer;
using OnlineExamSystem.DataServicesLayer.Model.School;


namespace OnlineExamSystem
{
    public partial class LoginForm : Form
    {
        public event EventHandler LoginSuccessful;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void OnLoginButtonClicked(object sender, EventArgs e)
        {
#if TEST_LOGIN
            // LoginSuccessful?.Invoke(this, EventArgs.Empty);
            //TxtUsername.Text = "joebiden@example.com";
            //TxtPassword.Text = "12345678";

            // teacher
            TxtUsername.Text = "jane.smith@example.com";
            TxtPassword.Text = "123456";
#endif
            var InMSSV = TxtUsername.Text;
            var InPassword = TxtPassword.Text;
            if (InMSSV.Length < 4 || InPassword.Length < 4)
            {
                MessageBox.Show("Thông tin không hợp lệ. Vui lòng kiểm tra lại.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (Session.Instance.Login(InMSSV, InPassword))
            {
                LoginSuccessful?.Invoke(this, EventArgs.Empty);
            }
            return;
        }
    }
}