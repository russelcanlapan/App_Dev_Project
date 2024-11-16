using System.Resources;

namespace Project_AD
{
    partial class Form1
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
            languageButton = new Button();
            titleLabel = new Label();
            loginMemberButton = new Button();
            loginEmployeeButton = new Button();
            signupButton = new Button();
            exitButton = new Button();
            memberLoginGB = new GroupBox();
            submitButton = new Button();
            memberIdTB = new TextBox();
            memberIdLabel = new Label();
            memberLoginGB.SuspendLayout();
            SuspendLayout();
            // 
            // languageButton
            // 
            languageButton.Location = new Point(682, 12);
            languageButton.Name = "languageButton";
            languageButton.Size = new Size(106, 41);
            languageButton.TabIndex = 0;
            languageButton.Text = "French";
            languageButton.UseVisualStyleBackColor = true;
            languageButton.Click += languageButton_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(341, 98);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(67, 15);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Gym World";
            // 
            // loginMemberButton
            // 
            loginMemberButton.Location = new Point(333, 185);
            loginMemberButton.Name = "loginMemberButton";
            loginMemberButton.Size = new Size(88, 23);
            loginMemberButton.TabIndex = 3;
            loginMemberButton.Text = "Member Login";
            loginMemberButton.UseVisualStyleBackColor = true;
            loginMemberButton.Click += loginMemberButton_Click;
            // 
            // loginEmployeeButton
            // 
            loginEmployeeButton.Location = new Point(333, 232);
            loginEmployeeButton.Name = "loginEmployeeButton";
            loginEmployeeButton.Size = new Size(88, 23);
            loginEmployeeButton.TabIndex = 4;
            loginEmployeeButton.Text = "Employee Login";
            loginEmployeeButton.UseVisualStyleBackColor = true;
            // 
            // signupButton
            // 
            signupButton.Location = new Point(333, 280);
            signupButton.Name = "signupButton";
            signupButton.Size = new Size(88, 23);
            signupButton.TabIndex = 5;
            signupButton.Text = "Sign Up";
            signupButton.UseVisualStyleBackColor = true;
            signupButton.Click += signupButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(333, 327);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(88, 23);
            exitButton.TabIndex = 6;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // memberLoginGB
            // 
            memberLoginGB.Controls.Add(submitButton);
            memberLoginGB.Controls.Add(memberIdTB);
            memberLoginGB.Controls.Add(memberIdLabel);
            memberLoginGB.Location = new Point(453, 171);
            memberLoginGB.Name = "memberLoginGB";
            memberLoginGB.Size = new Size(293, 50);
            memberLoginGB.TabIndex = 7;
            memberLoginGB.TabStop = false;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(201, 16);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(75, 23);
            submitButton.TabIndex = 2;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // memberIdTB
            // 
            memberIdTB.Location = new Point(95, 16);
            memberIdTB.Name = "memberIdTB";
            memberIdTB.Size = new Size(100, 23);
            memberIdTB.TabIndex = 1;
            // 
            // memberIdLabel
            // 
            memberIdLabel.AutoSize = true;
            memberIdLabel.Location = new Point(6, 19);
            memberIdLabel.Name = "memberIdLabel";
            memberIdLabel.Size = new Size(69, 15);
            memberIdLabel.TabIndex = 0;
            memberIdLabel.Text = "Member ID:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(memberLoginGB);
            Controls.Add(exitButton);
            Controls.Add(signupButton);
            Controls.Add(loginEmployeeButton);
            Controls.Add(loginMemberButton);
            Controls.Add(titleLabel);
            Controls.Add(languageButton);
            Name = "Form1";
            Text = "Form1";
            memberLoginGB.ResumeLayout(false);
            memberLoginGB.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public void UpdateComponent()
        {
            ResourceManager rm = new ResourceManager("Project_AD.Resources.Resources", typeof(Program).Assembly);

            languageButton.Text = rm.GetString("languageButton");
            loginMemberButton.Text = rm.GetString("loginMemberButton");
            loginEmployeeButton.Text = rm.GetString("loginEmployeeButton");
            signupButton.Text = rm.GetString("signupButton");
            exitButton.Text = rm.GetString("exitButton");
            submitButton.Text = rm.GetString("submitButton");
            memberIdLabel.Text = rm.GetString("memberIdLabel");
        }

        public string GetMemberIdText()
        {
            return memberIdTB.Text;
        }

        private Button languageButton;

        private Label titleLabel;
        private Button loginMemberButton;
        private Button loginEmployeeButton;
        private Button signupButton;
        private Button exitButton;

        public GroupBox memberLoginGB;
        private Button submitButton;
        private TextBox memberIdTB;
        private Label memberIdLabel;
    }
}
