using OnlineExamSystem.BusinessServices.TestManagment;
using OnlineExamSystem.DataServicesLayer;
using OnlineExamSystem.DataServicesLayer.Model.School;
using OnlineExamSystem.DataServicesLayer.Model.Tests;
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

namespace OnlineExamSystem.Presentation.UITest.UITestManagment
{
    public partial class AddNewTest : UserControl
    {
        private User CurrentTeacher;
        private List<Class> TeachingClasses;


        public AddNewTest()
        {
            InitializeComponent();
            SetDateTimeFormat();
            LoadFormInformation();
        }
        private void SetDateTimeFormat()
        {
            DTPBeginTime.Format = DateTimePickerFormat.Custom;
            DTPBeginTime.CustomFormat = "dd-MM-yyyy HH:mm";

            DTPEndTime.Format = DateTimePickerFormat.Custom;
            DTPEndTime.CustomFormat = "dd-MM-yyyy HH:mm";
        }
        private void LoadFormInformation()
        {
            if (UserData.Instance.GetCurrentUser() == null)
                return;

            CurrentTeacher = UserData.Instance.GetCurrentUser();
            TeachingClasses = ClassData.Instance.GetAllClassByCurrentTeacher().ToList();

            CbClassSelection.Items.Clear();
            if (TeachingClasses.Count() > 0)
            {
                foreach (Class c in TeachingClasses)
                {
                    CbClassSelection.Items.Add(c.Name);
                }
                CbClassSelection.SelectedIndex = 0;
            }
            
        }

        private void BtnAddClassToLV_Click(object sender, EventArgs e)
        {
            int index = CbClassSelection.SelectedIndex;
            if (index != -1) 
            {
                Class SelectedClass = TeachingClasses[index];
                ListViewCanDoExamClass.Items.Add(new ListViewItem(SelectedClass.Name));
                CbClassSelection.Items.RemoveAt(CbClassSelection.SelectedIndex);

                if (CbClassSelection.Items.Count > 0)
                    CbClassSelection.SelectedIndex = 0;
                else
                    CbClassSelection.SelectedIndex = -1;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool ValidateFormInformation()
        {
            bool AllGood = true;
            if (TxtTestName.Text.Length <= 0)
            {
                LabelTestName.ForeColor = Color.Red;
                AllGood = false;
            }
            else
                LabelTestName.ForeColor = Color.Black;

            int requiredDurationInMinutes = 0;

            if (TxtTestDurationInMinutes.Text.Length <= 0)
            {
                LabelDuration.ForeColor = Color.Red;
                AllGood = false;
            }
            else
            {
                if (!int.TryParse(TxtTestDurationInMinutes.Text, out requiredDurationInMinutes) || requiredDurationInMinutes <= 0)
                {
                    LabelDuration.ForeColor = Color.Red;
                    AllGood = false;
                }
                else
                    LabelDuration.ForeColor = Color.Black;
            }

            DateTime beginTime = DTPBeginTime.Value;
            DateTime endTime = DTPEndTime.Value;


            // Check that BeginTime is less than EndTime
            if (beginTime >= endTime)
            {
                LabelTestAllowTime.ForeColor = Color.Red;
                AllGood = false;
            }

            TimeSpan duration = endTime - beginTime;
            if (duration.TotalMinutes <= requiredDurationInMinutes)
            {
                LabelTestAllowTime.ForeColor = Color.Red;
                AllGood = false;
            }
            else
                LabelTestAllowTime.ForeColor = Color.Black;

            if (ListViewCanDoExamClass.Items.Count == 0)
            {
                AllGood = false;
                LbWhoCanTakeEx.ForeColor = Color.Red;
            }
            else
                LbWhoCanTakeEx.ForeColor = Color.Black;

            if (flowLayoutPanel1.Controls.Count <= 1)
            {
                MessageBox.Show("Vui long tao it nhat 1 cau hoi");
                return false;
            }
            foreach (Control item in flowLayoutPanel1.Controls) 
            {
                UCAddNewQuestion QuestionForm = item as UCAddNewQuestion;
                if (QuestionForm != null)
                {
                    if (!QuestionForm.IsValidQuestion())
                        return false;
                }
            }
            return AllGood;
        }
        private void BtnSaveInformation_Click(object sender, EventArgs e)
        {
            if (ValidateFormInformation())
            {
                Test NewTest = new Test();
                NewTest.Name = TxtTestName.Text;

                int requiredDurationInMinutes = 0;
                int.TryParse(TxtTestDurationInMinutes.Text, out requiredDurationInMinutes);
                NewTest.DurationInMinutes = requiredDurationInMinutes;

                NewTest.BeginTime = DTPBeginTime.Value;
                NewTest.EndTime = DTPEndTime.Value;
                NewTest.LastModifyTime = DateTime.Now;

                NewTest.JoinPassword = TxtJoinPassword.Text;
                NewTest.AllowOnlyOneTry = CheckboxCanOnlyTakeOneTime.Checked;
                NewTest.SwapQuestionAndAnswersOrder = CheckBoxSwapQandA.Checked;
                NewTest.StudentCanSeeAnswersAfterDone = CheckBoxAllowSeeQandA.Checked;
                NewTest.StudentCanSeeFinalScore = CheckBoxAllowSeeFinalScore.Checked;
                NewTest.Subject = "";

                foreach (Control item in flowLayoutPanel1.Controls)
                {
                    UCAddNewQuestion QuestionForm = item as UCAddNewQuestion;
                    if (QuestionForm != null)
                    {
                        NewTest.Questions.Add(QuestionForm.BuildQuestion());
                    }
                }
                if (TestManagment.Instance.CreateNewTestFromUI(NewTest))
                {
                    MessageBox.Show("Tao bai kiem tra ok");
                }
                else
                {
                    MessageBox.Show("Co loi xay ra.");
                }
            }
        }

        private void NewQuestionBtn(object sender, EventArgs e)
        {
            UCAddNewQuestion userControl = new UCAddNewQuestion();
            flowLayoutPanel1.Controls.Add(userControl);
            
            // dem button len cuoi ds
            SwapLastTwoControls(flowLayoutPanel1);
        }
        private void SwapLastTwoControls(FlowLayoutPanel flowLayoutPanel)
        {
            // Get the last two controls
            int lastIndex = flowLayoutPanel.Controls.Count - 1;
            int secondLastIndex = flowLayoutPanel.Controls.Count - 2;
            Control lastControl = flowLayoutPanel.Controls[lastIndex];
            Control secondLastControl = flowLayoutPanel.Controls[secondLastIndex];

            // Temporarily remove the controls from the FlowLayoutPanel
            flowLayoutPanel.Controls.RemoveAt(lastIndex);
            flowLayoutPanel.Controls.RemoveAt(secondLastIndex);

            // Re-add the controls in the swapped order
            flowLayoutPanel.Controls.Add(lastControl);
            flowLayoutPanel.Controls.Add(secondLastControl);

            flowLayoutPanel.AutoScrollPosition = new Point(0, flowLayoutPanel.DisplayRectangle.Height);

        }
    }
}
