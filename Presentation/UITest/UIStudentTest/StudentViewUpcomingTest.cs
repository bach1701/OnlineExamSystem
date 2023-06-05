using OnlineExamSystem.BusinessServices.TestManagment;
using OnlineExamSystem.BusinessServicesLayer;
using OnlineExamSystem.DataServicesLayer.Model.Tests;
using OnlineExamSystem.Presentation.UITest.UIStudentTest;
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
    public partial class StudentViewUpcomingTest : UserControl
    {
        private List<Test> TestAssigned;

        public StudentViewUpcomingTest()
        {
            InitializeComponent();
            InitTestListDGV();
            AssignDataGridView();
        }
        private void AssignDataGridView()
        {
            TestAssigned = StudentTest.Instance.GetAllTestAssigned();

            ListViewUpcomingTest.DataSource = TestAssigned;
        }

        private void InitTestListDGV()
        {
            ListViewUpcomingTest.AutoGenerateColumns = false;
            ListViewUpcomingTest.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "STT", DataPropertyName = "TestId", ReadOnly = true });
            ListViewUpcomingTest.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Tên", DataPropertyName = "Name", ReadOnly = true });
            
            ListViewUpcomingTest.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Số câu hỏi", Name = "QCount", DataPropertyName = "SubmissionCount", ReadOnly = true });
            
            ListViewUpcomingTest.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Mở đề lúc", DataPropertyName = "BeginTime", ReadOnly = true });
            ListViewUpcomingTest.Columns[ListViewUpcomingTest.Columns.Count - 1].DefaultCellStyle.Format = "HH:mm dd-MM-yyyy";
           
            ListViewUpcomingTest.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Đóng đề lúc", DataPropertyName = "EndTime", ReadOnly = true });
            ListViewUpcomingTest.Columns[ListViewUpcomingTest.Columns.Count - 1].DefaultCellStyle.Format = "HH:mm dd-MM-yyyy";

            ListViewUpcomingTest.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Thời gian làm bài", Name = "TestDuration", DataPropertyName = "DurationInMinutes", ReadOnly = true });

            DataGridViewButtonColumn JoinTestBtn = new DataGridViewButtonColumn();
            JoinTestBtn.HeaderText = "Hành động";
            JoinTestBtn.Name = "Action";
            JoinTestBtn.Text = "Làm bài";
            JoinTestBtn.UseColumnTextForButtonValue = true;
            ListViewUpcomingTest.Columns.Add(JoinTestBtn);

        }
        private void StudentTest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ListViewUpcomingTest.Columns["Action"].Index && e.RowIndex >= 0)
            {
                // xac dinh du lieu can truyen vao form Quan ly lop
                // ID lop
                //DataGridViewRow row = ListViewUpcomingTest.Rows[e.RowIndex];
                //string SelectedIndex = row.Cells[1].Value.ToString();
                Test SelectedTest = TestAssigned[e.RowIndex];

                ExamForm NewExamSess = new ExamForm(SelectedTest);
                NewExamSess.Show();
                /*
                EditStudentForm EditStudentForm = new EditStudentForm();
                EditStudentForm.Dock = DockStyle.Fill;
                EditStudentForm.EditStudentSuccessful += OnEditStudentSuccessful;
                EditStudentForm.SetStudentID(StudentID);
                Globals.MainForm.AddNewPanelToQueue(EditStudentForm);
                */
            }
        }
        private void ListViewUpcomingTest_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (ListViewUpcomingTest.Columns[e.ColumnIndex].Name == "TestDuration" && e.Value != null)
            {
                int minutes = (int)e.Value;
                e.Value = $"{minutes} phút";
            }
            if (ListViewUpcomingTest.Columns[e.ColumnIndex].Name == "QCount" && e.Value != null)
            {
                int question_count = (int)e.Value;
                e.Value = $"{question_count} câu";
            }
        }
    }
}
