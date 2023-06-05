using OnlineExamSystem.DataServicesLayer.Model.Tests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace OnlineExamSystem.Presentation.UITest.UIStudentTest.Exam
{
    public partial class UCQuestionBox : UserControl
    {
        private int QIndex = 0;
        private int OptionsCount = 0;
        private Question Question;

        public UCQuestionBox(Question Ques, int QuestionIndex)
        {
            QIndex = QuestionIndex;
            Question = Ques;


            InitializeComponent();

            SetBackgroundColorBasedOnIndex();
            SetQuestionContent();
            AlignForm();
        }
        private void SetQuestionContent()
        {
            LbQuestionIndex.Text = "Câu " + (QIndex + 1).ToString();
            LbQuestionText.Text = Question.Title;

            bool IsMoreThanOneCorrectAnswer = false;
            int CorrectCount = 0;
            foreach (Answer A in Question.AnswerOptions)
            {
                if (A.IsCorrect)
                {
                    CorrectCount++;
                    if (CorrectCount > 1)
                    {
                        IsMoreThanOneCorrectAnswer = true;
                        break;
                    }
                }
            }
            if (IsMoreThanOneCorrectAnswer)
            {
                groupBox1.Text = "Chọn một hoặc nhiều phương án";
                // create checkbox
                foreach (Answer A in Question.AnswerOptions)
                {
                    CreateCheckboxOptions(A.Text);
                }
            }
            else
            {
                groupBox1.Text = "Chọn một phương án";
                // create radio
                foreach (Answer A in Question.AnswerOptions)
                {
                    CreateRadioOptions(A.Text);
                }
            }
        }
        private void CreateRadioOptions(string Text)
        {
            System.Windows.Forms.RadioButton NewRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.Controls.Add(NewRadioButton);

            NewRadioButton.AutoSize = true;
            NewRadioButton.Font = new System.Drawing.Font("Segoe UI", 13F, 
                System.Drawing.FontStyle.Regular, 
                System.Drawing.GraphicsUnit.Point
            );

            int Y_AXIS = 39 + OptionsCount * 45;

            NewRadioButton.Location = new System.Drawing.Point(15, Y_AXIS);
            NewRadioButton.Name = "radioButton1";
            NewRadioButton.Size = new System.Drawing.Size(190, 40);
            NewRadioButton.TabIndex = 0;
            NewRadioButton.TabStop = true;
            NewRadioButton.Text = Text;
            NewRadioButton.UseVisualStyleBackColor = true;

            OptionsCount++;
        }
        private void CreateCheckboxOptions(string Text)
        {
            System.Windows.Forms.CheckBox NewCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1.Controls.Add(NewCheckbox);

            NewCheckbox.AutoSize = true;
            NewCheckbox.Font = new System.Drawing.Font("Segoe UI", 13F,
                System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point
            );

            int Y_AXIS = 39 + OptionsCount * 45;

            NewCheckbox.Location = new System.Drawing.Point(15, Y_AXIS);
            NewCheckbox.Name = "Checkboxxx";
            NewCheckbox.Size = new System.Drawing.Size(190, 40);
            NewCheckbox.TabIndex = 0;
            NewCheckbox.TabStop = true;
            NewCheckbox.Text = Text;
            NewCheckbox.UseVisualStyleBackColor = true;

            OptionsCount++;
        }
        private void SetBackgroundColorBasedOnIndex()
        {
            if (QIndex % 2 == 0)
            {
                this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
                this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            }
            else
            {
                this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
                this.BackColor = System.Drawing.Color.WhiteSmoke;
            }
        }
        private void AlignForm()
        {
            Graphics gfx = LbQuestionText.CreateGraphics();
            SizeF textSize = gfx.MeasureString(LbQuestionText.Text,
                LbQuestionText.Font, LbQuestionText.Width);

            // Calculate the new Y position for the GroupBox
            int newY = LbQuestionText.Location.Y + (int)textSize.Height + 10; // Add 10 pixels as a margin between the Label and the GroupBox

            // Set the new location for the GroupBox
            groupBox1.Location = new Point(groupBox1.Location.X, newY);
            groupBox1.Size = new Size(groupBox1.Size.Width, OptionsCount * 57 + 15);
            this.Size = new Size(1880, 70 + (int)textSize.Height + (OptionsCount * 57) + 15 );


        }
    }
}
