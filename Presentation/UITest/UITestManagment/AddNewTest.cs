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
        public AddNewTest()
        {
            InitializeComponent();
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
                LabelTestAllowTime.ForeColor = Color.White;

            return AllGood;
        }
        private void BtnSaveInformation_Click(object sender, EventArgs e)
        {
            ValidateFormInformation();
        }

        private void NewQuestionBtn(object sender, EventArgs e)
        {
            AddNewQuestion userControl = new AddNewQuestion();
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
