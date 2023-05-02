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

            // test data
#if TEST_LOGIN
            LoginSuccessful?.Invoke(this, EventArgs.Empty);
#else
            var InMSSV = TxtUsername.Text;
            var InPassword = TxtPassword.Text;
            if (InMSSV.Length < 4 || InPassword.Length < 4)
            {
                MessageBox.Show("Thong tin khong hop le. Vui long kiem tra lai", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (Session.Instance.Login(InMSSV, InPassword))
            {
                LoginSuccessful?.Invoke(this, EventArgs.Empty);
            }
#endif
            return;
        }
    }
}