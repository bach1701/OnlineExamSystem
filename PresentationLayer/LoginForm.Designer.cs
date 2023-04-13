namespace OnlineExamSystem
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoginButton = new Button();
            groupBox1 = new GroupBox();
            TxtPassword = new TextBox();
            label3 = new Label();
            TxtUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(225, 208);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(150, 46);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "Dang nhap";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += OnLoginButtonClicked;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtPassword);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TxtUsername);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(LoginButton);
            groupBox1.Location = new Point(34, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(619, 326);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(201, 99);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '*';
            TxtPassword.Size = new Size(342, 39);
            TxtPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 102);
            label3.Name = "label3";
            label3.Size = new Size(120, 32);
            label3.TabIndex = 3;
            label3.Text = "Mat khau:";
            // 
            // TxtUsername
            // 
            TxtUsername.Location = new Point(201, 32);
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(342, 39);
            TxtUsername.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 35);
            label2.Name = "label2";
            label2.Size = new Size(179, 32);
            label2.TabIndex = 1;
            label2.Text = "Ten dang nhap:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(50, 8);
            label1.Name = "label1";
            label1.Size = new Size(261, 55);
            label1.TabIndex = 2;
            label1.Text = "Dang nhap";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 408);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "LoginForm";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginButton;
        private GroupBox groupBox1;
        private TextBox TxtPassword;
        private Label label3;
        private TextBox TxtUsername;
        private Label label2;
        private Label label1;
    }
}