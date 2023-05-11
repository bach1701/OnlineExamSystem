using OnlineExamSystem.BusinessServicesLayer;
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
    public partial class AddStudentForm : UserControl 
    {
        private StudentListManagment StudentMgr;

        public AddStudentForm()
        {
            InitializeComponent();
        }
        public void SetStudentMgr(StudentListManagment studentMgr)
        {
            StudentMgr = studentMgr;
        }
        public event EventHandler CreateStudentSuccessful;


        private void CancelAddStudent_Click(object sender, EventArgs e)
        {
            Globals.MainForm.GoBack();
        }

        private void SaveNewStudent_Click(object sender, EventArgs e)
        {
            DateTime StudentBirthday = TxtStudentBirthday.Value;

            if (TxtStudentName.Text.Length <= 0 ||
                StudentBirthday.CompareTo(DateTime.Now) > 0 ||
                TxtStudentMSSV.Text.Length <= 0)
            {
                MessageBox.Show("Vui lòng nhập đủ các trường dữ liệu.");
                return;
            }

            int num;
            if (int.TryParse(TxtStudentMSSV.Text, out num) == false)
            {
                MessageBox.Show("Vui lòng nhập đúng MSSV.");
                return;
            }
            // code here
            bool success = StudentMgr.AddStudentToCurrentClass(TxtStudentName.Text, TxtStudentMSSV.Text, StudentBirthday);
            if (success)
            {
                CreateStudentSuccessful?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
