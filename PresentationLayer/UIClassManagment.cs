using OnlineExamSystem.BusinessServicesLayer;
using OnlineExamSystem.DataServicesLayer.Model.School;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineExamSystem.PresentationLayer
{
    public partial class UIClassManagment : UserControl
    {
        private ClassManagment ClassMgr;

        public UIClassManagment()
        {
            InitializeComponent();
        }


        private void ClassManagment_Load(object sender, EventArgs e)
        {
            ClassMgr = ClassManagment.Instance;
            InitClassListDGV();
            SetClassListSource();


        }
        private void InitClassListDGV()
        {
            ClassListview.AutoGenerateColumns = false;
            ClassListview.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "ID", DataPropertyName = "ClassId" });
            ClassListview.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Lớp", DataPropertyName = "Name" });
            ClassListview.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Môn học", DataPropertyName = "CourseName" });
            ClassListview.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Sĩ số", DataPropertyName = "StudentsCount" });

            DataGridViewButtonColumn ManagmentStudentBtn = new DataGridViewButtonColumn();
            ManagmentStudentBtn.HeaderText = "Quản lý";
            ManagmentStudentBtn.Name = "ManageStudents";
            ManagmentStudentBtn.Text = "Học sinh";
            ManagmentStudentBtn.UseColumnTextForButtonValue = true;
            ClassListview.Columns.Add(ManagmentStudentBtn);

            DataGridViewButtonColumn DeleteClass = new DataGridViewButtonColumn();
            DeleteClass.HeaderText = "Xóa";
            DeleteClass.Name = "DeleteClass";
            DeleteClass.Text = "Xóa";
            DeleteClass.UseColumnTextForButtonValue = true;
            ClassListview.Columns.Add(DeleteClass);
           

        }
        private void SetClassListSource()
        {
            ClassListview.DataSource = ClassMgr.GetAllClassByCurrentTeacher();
        }
        private void NewClassBtn_Click(object sender, EventArgs e)
        {
            Class NewClass = new Class();
            NewClass.Name = "21TCLC_DT2";
            NewClass.CourseName = "PBL 4";
           

            bool success = ClassMgr.AddNewClass(NewClass);
            if (success)
            {
                SetClassListSource();
            }
        }

        private void ClassListview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ClassListview.Columns["ManageStudents"].Index && e.RowIndex >= 0)
            {
                MessageBox.Show("Request manage class " + e.RowIndex);
                // Button clicked in row e.RowIndex
            }
            if (e.ColumnIndex == ClassListview.Columns["DeleteClass"].Index && e.RowIndex >= 0)
            {
                MessageBox.Show("Request delete class " + e.RowIndex);
                // Button clicked in row e.RowIndex
            }
        }
    }
}
