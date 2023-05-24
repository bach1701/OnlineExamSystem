using OnlineExamSystem.Presentation.Components;

namespace OnlineExamSystem.Presentation.UITest.UITestManagment
{
    partial class AddNewTest
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtTestDurationInMinutes = new OnlineExamSystem.Presentation.Components.CustomTextBox();
            this.LabelDuration = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CheckBoxAllowSeeFinalScore = new System.Windows.Forms.CheckBox();
            this.CheckBoxAllowSeeQandA = new System.Windows.Forms.CheckBox();
            this.CheckBoxSwapQandA = new System.Windows.Forms.CheckBox();
            this.CheckboxCanOnlyTakeOneTime = new System.Windows.Forms.CheckBox();
            this.TxtJoinPassword = new OnlineExamSystem.Presentation.Components.CustomTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnAddClassToLV = new System.Windows.Forms.Button();
            this.CbClassSelection = new System.Windows.Forms.ComboBox();
            this.ListViewCanDoExamClass = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.DTPEndTime = new System.Windows.Forms.DateTimePicker();
            this.DTPBeginTime = new System.Windows.Forms.DateTimePicker();
            this.LabelTestAllowTime = new System.Windows.Forms.Label();
            this.TxtTestName = new OnlineExamSystem.Presentation.Components.CustomTextBox();
            this.LabelTestName = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtTestDurationInMinutes);
            this.groupBox1.Controls.Add(this.LabelDuration);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.BtnAddClassToLV);
            this.groupBox1.Controls.Add(this.CbClassSelection);
            this.groupBox1.Controls.Add(this.ListViewCanDoExamClass);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DTPEndTime);
            this.groupBox1.Controls.Add(this.DTPBeginTime);
            this.groupBox1.Controls.Add(this.LabelTestAllowTime);
            this.groupBox1.Controls.Add(this.TxtTestName);
            this.groupBox1.Controls.Add(this.LabelTestName);
            this.groupBox1.Location = new System.Drawing.Point(0, -13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(395, 1234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox3.Size = new System.Drawing.Size(395, 85);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(53, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(289, 54);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tạo bài thi mới";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(8, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 41);
            this.label9.TabIndex = 18;
            this.label9.Text = "<";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(53, 1019);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(285, 118);
            this.button3.TabIndex = 17;
            this.button3.Text = "Lưu thông tin";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BtnSaveInformation_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(164, 374);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 28);
            this.label8.TabIndex = 16;
            this.label8.Text = "đến";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(66, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(257, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nhập 0 để không giới hạn thời gian";
            // 
            // TxtTestDurationInMinutes
            // 
            this.TxtTestDurationInMinutes.BorderColor = System.Drawing.Color.Empty;
            this.TxtTestDurationInMinutes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtTestDurationInMinutes.Location = new System.Drawing.Point(26, 214);
            this.TxtTestDurationInMinutes.Name = "TxtTestDurationInMinutes";
            this.TxtTestDurationInMinutes.Size = new System.Drawing.Size(342, 39);
            this.TxtTestDurationInMinutes.TabIndex = 14;
            // 
            // LabelDuration
            // 
            this.LabelDuration.AutoSize = true;
            this.LabelDuration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelDuration.Location = new System.Drawing.Point(20, 176);
            this.LabelDuration.Name = "LabelDuration";
            this.LabelDuration.Size = new System.Drawing.Size(275, 32);
            this.LabelDuration.TabIndex = 13;
            this.LabelDuration.Text = "Thời gian làm bài (phút):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CheckBoxAllowSeeFinalScore);
            this.groupBox2.Controls.Add(this.CheckBoxAllowSeeQandA);
            this.groupBox2.Controls.Add(this.CheckBoxSwapQandA);
            this.groupBox2.Controls.Add(this.CheckboxCanOnlyTakeOneTime);
            this.groupBox2.Controls.Add(this.TxtJoinPassword);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(19, 667);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 308);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cài đặt nâng cao";
            // 
            // CheckBoxAllowSeeFinalScore
            // 
            this.CheckBoxAllowSeeFinalScore.AutoSize = true;
            this.CheckBoxAllowSeeFinalScore.Location = new System.Drawing.Point(18, 237);
            this.CheckBoxAllowSeeFinalScore.Name = "CheckBoxAllowSeeFinalScore";
            this.CheckBoxAllowSeeFinalScore.Size = new System.Drawing.Size(180, 34);
            this.CheckBoxAllowSeeFinalScore.TabIndex = 14;
            this.CheckBoxAllowSeeFinalScore.Text = "Cho xem điểm";
            this.CheckBoxAllowSeeFinalScore.UseVisualStyleBackColor = true;
            // 
            // CheckBoxAllowSeeQandA
            // 
            this.CheckBoxAllowSeeQandA.AutoSize = true;
            this.CheckBoxAllowSeeQandA.Location = new System.Drawing.Point(18, 202);
            this.CheckBoxAllowSeeQandA.Name = "CheckBoxAllowSeeQandA";
            this.CheckBoxAllowSeeQandA.Size = new System.Drawing.Size(286, 34);
            this.CheckBoxAllowSeeQandA.TabIndex = 13;
            this.CheckBoxAllowSeeQandA.Text = "Cho xem đề thi và đáp án";
            this.CheckBoxAllowSeeQandA.UseVisualStyleBackColor = true;
            // 
            // CheckBoxSwapQandA
            // 
            this.CheckBoxSwapQandA.AutoSize = true;
            this.CheckBoxSwapQandA.Location = new System.Drawing.Point(18, 167);
            this.CheckBoxSwapQandA.Name = "CheckBoxSwapQandA";
            this.CheckBoxSwapQandA.Size = new System.Drawing.Size(253, 34);
            this.CheckBoxSwapQandA.TabIndex = 12;
            this.CheckBoxSwapQandA.Text = "Đảo câu hỏi và đáp án";
            this.CheckBoxSwapQandA.UseVisualStyleBackColor = true;
            // 
            // CheckboxCanOnlyTakeOneTime
            // 
            this.CheckboxCanOnlyTakeOneTime.AutoSize = true;
            this.CheckboxCanOnlyTakeOneTime.Location = new System.Drawing.Point(18, 132);
            this.CheckboxCanOnlyTakeOneTime.Name = "CheckboxCanOnlyTakeOneTime";
            this.CheckboxCanOnlyTakeOneTime.Size = new System.Drawing.Size(276, 34);
            this.CheckboxCanOnlyTakeOneTime.TabIndex = 11;
            this.CheckboxCanOnlyTakeOneTime.Text = "Chỉ cho phép thi một lần";
            this.CheckboxCanOnlyTakeOneTime.UseVisualStyleBackColor = true;
            // 
            // TxtJoinPassword
            // 
            this.TxtJoinPassword.BorderColor = System.Drawing.Color.Empty;
            this.TxtJoinPassword.Location = new System.Drawing.Point(7, 72);
            this.TxtJoinPassword.Name = "TxtJoinPassword";
            this.TxtJoinPassword.Size = new System.Drawing.Size(336, 37);
            this.TxtJoinPassword.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(7, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mật khẩu làm bài:";
            // 
            // BtnAddClassToLV
            // 
            this.BtnAddClassToLV.Location = new System.Drawing.Point(230, 590);
            this.BtnAddClassToLV.Name = "BtnAddClassToLV";
            this.BtnAddClassToLV.Size = new System.Drawing.Size(138, 34);
            this.BtnAddClassToLV.TabIndex = 8;
            this.BtnAddClassToLV.Text = "Thêm lớp";
            this.BtnAddClassToLV.UseVisualStyleBackColor = true;
            // 
            // CbClassSelection
            // 
            this.CbClassSelection.FormattingEnabled = true;
            this.CbClassSelection.Location = new System.Drawing.Point(26, 590);
            this.CbClassSelection.Name = "CbClassSelection";
            this.CbClassSelection.Size = new System.Drawing.Size(182, 33);
            this.CbClassSelection.TabIndex = 7;
            // 
            // ListViewCanDoExamClass
            // 
            this.ListViewCanDoExamClass.Location = new System.Drawing.Point(26, 500);
            this.ListViewCanDoExamClass.Name = "ListViewCanDoExamClass";
            this.ListViewCanDoExamClass.Size = new System.Drawing.Size(342, 71);
            this.ListViewCanDoExamClass.TabIndex = 6;
            this.ListViewCanDoExamClass.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(20, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ai được phép thi:";
            // 
            // DTPEndTime
            // 
            this.DTPEndTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DTPEndTime.Location = new System.Drawing.Point(26, 406);
            this.DTPEndTime.Name = "DTPEndTime";
            this.DTPEndTime.Size = new System.Drawing.Size(342, 39);
            this.DTPEndTime.TabIndex = 4;
            // 
            // DTPBeginTime
            // 
            this.DTPBeginTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DTPBeginTime.Location = new System.Drawing.Point(26, 335);
            this.DTPBeginTime.Name = "DTPBeginTime";
            this.DTPBeginTime.Size = new System.Drawing.Size(342, 39);
            this.DTPBeginTime.TabIndex = 3;
            // 
            // LabelTestAllowTime
            // 
            this.LabelTestAllowTime.AutoSize = true;
            this.LabelTestAllowTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelTestAllowTime.Location = new System.Drawing.Point(20, 297);
            this.LabelTestAllowTime.Name = "LabelTestAllowTime";
            this.LabelTestAllowTime.Size = new System.Drawing.Size(127, 32);
            this.LabelTestAllowTime.TabIndex = 2;
            this.LabelTestAllowTime.Text = "Mở đề lúc:";
            // 
            // TxtTestName
            // 
            this.TxtTestName.BorderColor = System.Drawing.Color.Empty;
            this.TxtTestName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtTestName.ForeColor = System.Drawing.Color.Black;
            this.TxtTestName.Location = new System.Drawing.Point(26, 133);
            this.TxtTestName.Name = "TxtTestName";
            this.TxtTestName.Size = new System.Drawing.Size(342, 39);
            this.TxtTestName.TabIndex = 1;
            // 
            // LabelTestName
            // 
            this.LabelTestName.AutoSize = true;
            this.LabelTestName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelTestName.Location = new System.Drawing.Point(20, 95);
            this.LabelTestName.Name = "LabelTestName";
            this.LabelTestName.Size = new System.Drawing.Size(131, 32);
            this.LabelTestName.TabIndex = 0;
            this.LabelTestName.Text = "Tên bài thi:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(398, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(931, 1221);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(896, 69);
            this.button4.TabIndex = 1;
            this.button4.Text = "Câu hỏi mới";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.NewQuestionBtn);
            // 
            // AddNewTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddNewTest";
            this.Size = new System.Drawing.Size(1352, 1221);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckBox CheckBoxAllowSeeFinalScore;
        private CheckBox CheckBoxAllowSeeQandA;
        private CheckBox CheckBoxSwapQandA;
        private CheckBox CheckboxCanOnlyTakeOneTime;
        private CustomTextBox TxtJoinPassword;
        private Label label4;
        private Button BtnAddClassToLV;
        private ComboBox CbClassSelection;
        private ListView ListViewCanDoExamClass;
        private Label label3;
        private DateTimePicker DTPEndTime;
        private DateTimePicker DTPBeginTime;
        private Label LabelTestAllowTime;
        private CustomTextBox TxtTestName;
        private Label LabelTestName;
        private CustomTextBox TxtTestDurationInMinutes;
        private Label LabelDuration;
        private Label label8;
        private Label label7;
        private Button button3;
        private Label label5;
        private Label label9;
        private GroupBox groupBox3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button4;
    }
}
