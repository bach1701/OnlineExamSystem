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
    public partial class StudentClassManagment : UserControl
    {
        private StudentListManagment StudentMgr;

        public void SetClassId(int ClassId)
        {
            StudentMgr = new StudentListManagment(ClassId);
        }
        public StudentClassManagment()
        {
            InitializeComponent();
        }
        public void SetStudentListSource()
        {
            StudentListView.DataSource = StudentMgr.GetStudentListInClass();
        }

        private void StudentClassManagment_Load(object sender, EventArgs e)
        {
            SetStudentListSource();
            lbClassName.Text = StudentMgr.GetClassName();
        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm AddStudentForm = new AddStudentForm();
            AddStudentForm.Dock = DockStyle.Fill;
            AddStudentForm.CreateStudentSuccessful += OnAddStudentSuccessful;
            AddStudentForm.SetStudentMgr(StudentMgr);
            Globals.MainForm.AddNewPanelToQueue(AddStudentForm);
        }

        private void OnAddStudentSuccessful(object sender, EventArgs e)
        {
            SetStudentListSource();
            Globals.MainForm.GoBack();
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            Globals.MainForm.GoBack();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbClassName_Click(object sender, EventArgs e)
        {

        }
    }
}
