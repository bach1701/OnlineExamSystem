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
            ClassMgr = ClassManagment.Instance;
            InitializeComponent();
        }


        private void ClassManagment_Load(object sender, EventArgs e)
        {
            InitClassListDGV();
            SetClassListSource();
        }
        private void InitClassListDGV()
        {
            ClassListview.AutoGenerateColumns = false;
            ClassListview.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "ID", DataPropertyName = "ClassId", ReadOnly = true });
            ClassListview.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Lớp", DataPropertyName = "Name", ReadOnly = true });
            ClassListview.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Môn học", DataPropertyName = "CourseName", ReadOnly = true });
            ClassListview.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Sĩ số", DataPropertyName = "StudentsCount", ReadOnly = true });

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
            PopupAddNewClass AddClassForm = new PopupAddNewClass();
            AddClassForm.Dock = DockStyle.Fill;
            AddClassForm.CreateClassSuccessful += OnAddClassSuccessful;
            Globals.MainForm.AddNewPanelToQueue(AddClassForm);
        }

        private void OnAddClassSuccessful(object sender, EventArgs e)
        {
            SetClassListSource();
            Globals.MainForm.GoBack();
        }
        private void ClassListview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ClassListview.Columns["ManageStudents"].Index && e.RowIndex >= 0)
            {
                // xac dinh du lieu can truyen vao form Quan ly lop
                // ID lop
                DataGridViewRow row = ClassListview.Rows[e.RowIndex];
                string ClassID = row.Cells[0].Value.ToString();

                StudentClassManagment MenuStudentMgr = new StudentClassManagment();
                MenuStudentMgr.Dock = DockStyle.Fill;
                MenuStudentMgr.SetClassId(Convert.ToInt32(ClassID));
                Globals.MainForm.AddNewPanelToQueue(MenuStudentMgr);
                // Button clicked in row e.RowIndex
            }
            if (e.ColumnIndex == ClassListview.Columns["DeleteClass"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = ClassListview.Rows[e.RowIndex];
                string ClassID = row.Cells[0].Value.ToString();

                string Message = String.Format("Xóa lớp {0} ({1}) khỏi hệ thống?", row.Cells[2].Value.ToString(), row.Cells[1].Value.ToString());

                DialogResult result = MessageBox.Show(Message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (ClassManagment.Instance.RemoveClassByIndex(Convert.ToInt32(ClassID)) == true)
                    {
                        SetClassListSource();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thực hiện xóa lớp " + ClassID);
                        SetClassListSource();
                    }
                }              
            }
        }
    }
}
