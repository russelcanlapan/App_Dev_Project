﻿using System.Resources;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            languageButton.Location = new Point(779, 16);
            languageButton.Margin = new Padding(3, 4, 3, 4);
            languageButton.Name = "languageButton";
            languageButton.Size = new Size(121, 55);
            languageButton.TabIndex = 0;
            languageButton.Text = "French";
            languageButton.UseVisualStyleBackColor = true;
            languageButton.Click += languageButton_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(390, 131);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(83, 20);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Gym World";
            // 
            // loginMemberButton
            // 
            loginMemberButton.Location = new Point(381, 247);
            loginMemberButton.Margin = new Padding(3, 4, 3, 4);
            loginMemberButton.Name = "loginMemberButton";
            loginMemberButton.Size = new Size(101, 31);
            loginMemberButton.TabIndex = 3;
            loginMemberButton.Text = "Member Login";
            loginMemberButton.UseVisualStyleBackColor = true;
            loginMemberButton.Click += loginMemberButton_Click;
            // 
            // loginEmployeeButton
            // 
            loginEmployeeButton.Location = new Point(381, 309);
            loginEmployeeButton.Margin = new Padding(3, 4, 3, 4);
            loginEmployeeButton.Name = "loginEmployeeButton";
            loginEmployeeButton.Size = new Size(101, 31);
            loginEmployeeButton.TabIndex = 4;
            loginEmployeeButton.Text = "Employee Login";
            loginEmployeeButton.UseVisualStyleBackColor = true;
            loginEmployeeButton.Click += loginEmployeeButton_Click;
            // 
            // signupButton
            // 
            signupButton.Location = new Point(381, 373);
            signupButton.Margin = new Padding(3, 4, 3, 4);
            signupButton.Name = "signupButton";
            signupButton.Size = new Size(101, 31);
            signupButton.TabIndex = 5;
            signupButton.Text = "Sign Up";
            signupButton.UseVisualStyleBackColor = true;
            signupButton.Click += signupButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(381, 436);
            exitButton.Margin = new Padding(3, 4, 3, 4);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(101, 31);
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
            memberLoginGB.Location = new Point(518, 228);
            memberLoginGB.Margin = new Padding(3, 4, 3, 4);
            memberLoginGB.Name = "memberLoginGB";
            memberLoginGB.Padding = new Padding(3, 4, 3, 4);
            memberLoginGB.Size = new Size(335, 67);
            memberLoginGB.TabIndex = 7;
            memberLoginGB.TabStop = false;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(230, 21);
            submitButton.Margin = new Padding(3, 4, 3, 4);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(86, 31);
            submitButton.TabIndex = 2;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // memberIdTB
            // 
            memberIdTB.Location = new Point(109, 21);
            memberIdTB.Margin = new Padding(3, 4, 3, 4);
            memberIdTB.Name = "memberIdTB";
            memberIdTB.Size = new Size(114, 27);
            memberIdTB.TabIndex = 1;
            // 
            // memberIdLabel
            // 
            memberIdLabel.AutoSize = true;
            memberIdLabel.Location = new Point(7, 25);
            memberIdLabel.Name = "memberIdLabel";
            memberIdLabel.Size = new Size(87, 20);
            memberIdLabel.TabIndex = 0;
            memberIdLabel.Text = "Member ID:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(memberLoginGB);
            Controls.Add(exitButton);
            Controls.Add(signupButton);
            Controls.Add(loginEmployeeButton);
            Controls.Add(loginMemberButton);
            Controls.Add(titleLabel);
            Controls.Add(languageButton);
            Margin = new Padding(3, 4, 3, 4);
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
