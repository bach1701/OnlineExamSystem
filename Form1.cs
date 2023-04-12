using OnlineExamSystem.DataServicesLayer.Model;

namespace OnlineExamSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            using (var context = new ExamDbContext())
            {
                MessageBox.Show(context == null ? "true" : "false"); 
            }
        }
    }
}