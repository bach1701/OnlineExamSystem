using OnlineExamSystem.BusinessServices.ClassManagment;
using OnlineExamSystem.BusinessServices.TestManagment;
using OnlineExamSystem.BusinessServicesLayer;
using OnlineExamSystem.DataServicesLayer.Model.Tests;
using OnlineExamSystem.Presentation.UITest.UITestManagment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OnlineExamSystem.PresentationLayer
{
    public partial class UITestManagmentList : UserControl
    {
        public UITestManagmentList()
        {
            InitializeComponent();
            InitTestListDGV();
            BindDataToGridView();
        }
        private void BindDataToGridView()
        {
            dataGridView1.DataSource = TestManagment.Instance.GetAllTestCreatedByCurrentTeacher();
        }
        private void UpdateDataGV()
        {
            BindDataToGridView();
        }
        private void InitTestListDGV()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "ID", DataPropertyName = "TestId", ReadOnly = true });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Tên", DataPropertyName = "Name", ReadOnly = true });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Số bài đã nộp", DataPropertyName = "SubmissionCount", ReadOnly = true });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Sửa lần cuối", DataPropertyName = "LastModifyTime", ReadOnly = true });

            dataGridView1.Columns[dataGridView1.Columns.Count - 1].DefaultCellStyle.Format = "dd-MM-yyyy HH:mm:ss";

            DataGridViewButtonColumn ViewResultBtn = new DataGridViewButtonColumn();
            ViewResultBtn.HeaderText = "Kết quả";
            ViewResultBtn.Name = "TestSubmissionResult";
            ViewResultBtn.Text = "Kết quả";
            ViewResultBtn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(ViewResultBtn);

            DataGridViewButtonColumn EditTestBtn = new DataGridViewButtonColumn();
            EditTestBtn.HeaderText = "Quản lý";
            EditTestBtn.Name = "ModifyTest";
            EditTestBtn.Text = "Chỉnh sửa";
            EditTestBtn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(EditTestBtn);

            DataGridViewButtonColumn DeleteTestBtn = new DataGridViewButtonColumn();
            DeleteTestBtn.HeaderText = "";
            DeleteTestBtn.Name = "RemoveTest";
            DeleteTestBtn.Text = "Xóa";
            DeleteTestBtn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(DeleteTestBtn);
        }
        private void BtnAddNewTest_Click(object sender, EventArgs e)
        {
            AddNewTest NewTestForm = new AddNewTest();
            NewTestForm.OnFormLeave += OnNewTestFormLeaved;
            Globals.MainForm.AddNewPanelToQueue(NewTestForm);
        }
        private void OnNewTestFormLeaved(object sender, EventArgs e)
        {
            UpdateDataGV();
            Globals.MainForm.GoBack();
        }

        private void TestListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataGridView1.Columns["TestSubmissionResult"].Index && e.RowIndex >= 0)
            {
                /*
                // xac dinh du lieu can truyen vao form Quan ly lop
                // ID lop
                DataGridViewRow row = ClassListview.Rows[e.RowIndex];
                string ClassID = row.Cells[0].Value.ToString();

                StudentClassManagment MenuStudentMgr = new StudentClassManagment();
                MenuStudentMgr.Dock = DockStyle.Fill;
                MenuStudentMgr.SetClassId(Convert.ToInt32(ClassID));
                Globals.MainForm.AddNewPanelToQueue(MenuStudentMgr);
                // Button clicked in row e.RowIndex
                */
            }
            if (e.ColumnIndex == dataGridView1.Columns["ModifyTest"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                string TestID = row.Cells[0].Value.ToString();

                Test TestObject = TestManagment.Instance.GetTestByTestID(Convert.ToInt32(TestID));

                AddNewTest ModifyForm = new AddNewTest();
                ModifyForm.OnFormLeave += OnNewTestFormLeaved;
                ModifyForm.SetModifyingTest(TestObject);
                Globals.MainForm.AddNewPanelToQueue(ModifyForm);              
            }
            if (e.ColumnIndex == dataGridView1.Columns["RemoveTest"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                string TestID = row.Cells[0].Value.ToString();

                string Message = String.Format("Xóa bài kiểm tra {0} khỏi hệ thống?", row.Cells[1].Value.ToString());

                DialogResult result = MessageBox.Show(Message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    
                    if (TestManagment.Instance.DeleteTest(Convert.ToInt32(TestID)) == true)
                    {
                        BindDataToGridView();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thực hiện xóa lớp " + TestID);
                        BindDataToGridView();
                    }
                }
            }
        }
    }
}
