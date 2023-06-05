using OnlineExamSystem.BusinessServicesLayer;
using OnlineExamSystem.DataServicesLayer.Model.Tests;
using OnlineExamSystem.Presentation.UITest.UIStudentTest.Exam;
using OnlineExamSystem.PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineExamSystem.Presentation.UITest.UIStudentTest
{
    public partial class ExamForm : Form
    {
        Test Exam;
        public ExamForm(Test RequestedTest)
        {
            Exam = RequestedTest;

            InitializeComponent();
            ShowEnterExamUC();
        }
        public void ShowEnterExamUC()
        {
            UCEnterExam enter_dialog = new UCEnterExam(Exam);
            enter_dialog.RequestSpawnTestUI += OnRequestSpawnTestUI;
            BringUp(enter_dialog);
        }

        private void OnRequestSpawnTestUI(object sender, EventArgs e)
        {
            UCDoingExam exam_uc = new UCDoingExam(Exam);
            BringUp(exam_uc);
        }
        public void BringUp(object sender)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add((Control)sender);
        }
    }
}
