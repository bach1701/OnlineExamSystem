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
            ListViewUpcomingTest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

            DataGridViewButtonColumn ViewTestResultBtn = new DataGridViewButtonColumn();
            ViewTestResultBtn.HeaderText = "Kết quả";
            ViewTestResultBtn.Name = "ViewResult";
            ViewTestResultBtn.Text = "Kết quả";
            ViewTestResultBtn.UseColumnTextForButtonValue = true;
            ListViewUpcomingTest.Columns.Add(ViewTestResultBtn);

        }
        private void StudentTest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ListViewUpcomingTest.Columns["Action"].Index && e.RowIndex >= 0)
            {
                Test SelectedTest = TestAssigned[e.RowIndex];

                ExamForm NewExamSess = new ExamForm(SelectedTest);
                NewExamSess.Show();            
            }
            if (e.ColumnIndex == ListViewUpcomingTest.Columns["ViewResult"].Index && e.RowIndex >= 0)
            {
                Test SelectedTest = TestAssigned[e.RowIndex];

                ExamForm ViewExamResult = new ExamForm(SelectedTest);
                if (!ViewExamResult.SetShowResultOnly())
                    MessageBox.Show("Không có bài làm nào của bạn.");
                else
                    ViewExamResult.Show();
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
