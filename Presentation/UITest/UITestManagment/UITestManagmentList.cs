using OnlineExamSystem.BusinessServices.TestManagment;
using OnlineExamSystem.BusinessServicesLayer;
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
            Globals.MainForm.AddNewPanelToQueue(NewTestForm);
        }
    }
}
