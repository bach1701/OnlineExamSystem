using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineExamSystem.Presentation.UITest.UITestManagment
{
    public partial class AddNewQuestion : UserControl
    {
        private int CurrentOptionsCount = 1;
        public AddNewQuestion()
        {
            InitializeComponent();
        }
        public void SetSize(int width, int height)
        {
            this.Size = new System.Drawing.Size(width, height);
        }
        private void AddNewOptions()
        {
            // base: 58, 107
            // size = 35;
            CurrentOptionsCount += 1;

            int index = CurrentOptionsCount - 1;

            int padding = 50;

            TextBox NewTxtOptions = new TextBox();
            NewTxtOptions.Location = new System.Drawing.Point(58, 107 + 47 * index);
            NewTxtOptions.Name = "TxtOptions" + CurrentOptionsCount.ToString();
            NewTxtOptions.Size = new System.Drawing.Size(783, 31);
            NewTxtOptions.TabIndex = 1;

            // 
            // checkBox1
            // 
            CheckBox NewIsCorrectCheckbox = new CheckBox();
            NewIsCorrectCheckbox.AutoSize = true;
            NewIsCorrectCheckbox.Location = new System.Drawing.Point(23, 113 + 47*index);
            NewIsCorrectCheckbox.Name = "checkBoxx" + CurrentOptionsCount.ToString();
            NewIsCorrectCheckbox.Size = new System.Drawing.Size(22, 21);
            NewIsCorrectCheckbox.TabIndex = 7;
            NewIsCorrectCheckbox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            Label LB = new Label();
            LB.AutoSize = true;
            LB.Location = new System.Drawing.Point(847, 109 + 47 * index);
            LB.Name = "label4x" + CurrentOptionsCount.ToString();
            LB.Size = new System.Drawing.Size(23, 25);
            LB.TabIndex = 13;
            LB.Text = "X";

            this.Controls.Add(NewTxtOptions);
            this.Controls.Add(NewIsCorrectCheckbox);
            this.Controls.Add(LB);

            // move the AddNewOption text, and Del button
            label1.Location = new System.Drawing.Point(58, 153 + 47 * index);
            button1.Location = new System.Drawing.Point(740, 153 + 47 * index);
            SetSize(this.Size.Width, this.Size.Height + 47);

            // 
            // resize the panel

        }
        private void label1_Click(object sender, EventArgs e)
        {
            AddNewOptions();
        }

        private void AddNewQuestion_Load(object sender, EventArgs e)
        {

        }
    }
}
