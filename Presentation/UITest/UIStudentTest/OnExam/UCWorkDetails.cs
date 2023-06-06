using OnlineExamSystem.BusinessServices.TestManagment;
using OnlineExamSystem.DataServicesLayer;
using OnlineExamSystem.DataServicesLayer.Model.School;
using OnlineExamSystem.DataServicesLayer.Model.Tests;
using OnlineExamSystem.Migrations;
using OnlineExamSystem.Presentation.UITest.UITestManagment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace OnlineExamSystem.Presentation.UITest.UIStudentTest.Exam
{
    public partial class UCWorkDetails : UserControl
    {
        public event EventHandler? EventShowResultUC;

        private Test Exam;
        private User Examinee;
        private TestTakerResult TakerResult;

        private StudentTest ExamManager;

        private int test_index = 0;

        public UCWorkDetails(TestTakerResult RequestedTest)
        {
            InitializeComponent();
            Exam = RequestedTest.TestTaker.Test;
            Examinee = RequestedTest.TestTaker.Student;
            TakerResult = RequestedTest;

            SetAvatar();
            LoadTestInfoOntoUI();
            AlignCenterLabel();
            LoadTestQuestion();
        }
        public void LoadTestInfoOntoUI()
        {
            LbNameOfTest.Text = Exam.Name;
            LbStudentID.Text = Examinee.NumericIdentification;
            LbStudentName.Text = Examinee.FirstName + " " + Examinee.LastName;
            LbScore.Text = TakerResult.FinalScore.ToString();
        }
        public void LoadTestQuestion()
        {
            List<Question> QuestionList = Exam.Questions.ToList();

            foreach (Question Q in QuestionList) 
            {
                UCQuestionBox NewBox = new UCQuestionBox(Q, 
                    Q.IsMoreThanOneCorrectAnswer,
                    false,
                    test_index++);

                NewBox.SetSelectedOptionsAndAnswer(TakerResult.AnswerResponses.FirstOrDefault(R => R.Question == Q));
                FlowPanelQuestionBox.Controls.Add(NewBox);
            }
        }
    
        public void AlignCenterLabel()
        {
            LbNameOfTest.Left = (this.Width - LbNameOfTest.Width) / 2;
            label1.Left = (this.Width - label1.Width) / 2;
            //LbScore.Left = (this.Width - LbScore.Width) / 2;
        }
        private void SetAvatar()
        {
            pictureBox1.NameInitials = Examinee.FirstName.Substring(0, 1) + Examinee.LastName.Substring(0, 1);
            pictureBox1.BackgroundColor = Color.Green;
            pictureBox1.Refresh();
        }   
    }
}
