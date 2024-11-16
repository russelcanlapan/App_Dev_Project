using System.Resources;

namespace Project_AD
{
    partial class SignUp
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            signUpLabel = new Label();
            firstNameTB = new TextBox();
            lastNameTB = new TextBox();
            streetNumberTB = new TextBox();
            streetNameTB = new TextBox();
            cityTB = new TextBox();
            provinceTB = new TextBox();
            zipcodeTB = new TextBox();
            phoneNumberTB = new TextBox();
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            phoneNumberLabel = new Label();
            streetNumberLabel = new Label();
            streetNameLabel = new Label();
            cityLabel = new Label();
            provinceLabel = new Label();
            zipCodeLabel = new Label();
            submitButton = new Button();
            membershipTypeGB = new GroupBox();
            premiumRB = new RadioButton();
            regularRB = new RadioButton();
            yearlyRB = new RadioButton();
            monthlyRB = new RadioButton();
            frequencyTypeGB = new GroupBox();
            backButton = new Button();
            membershipTypeGB.SuspendLayout();
            frequencyTypeGB.SuspendLayout();
            SuspendLayout();
            // 
            // signUpLabel
            // 
            signUpLabel.AutoSize = true;
            signUpLabel.Location = new Point(326, 27);
            signUpLabel.Name = "signUpLabel";
            signUpLabel.Size = new Size(48, 15);
            signUpLabel.TabIndex = 0;
            signUpLabel.Text = "Sign Up";
            // 
            // firstNameTB
            // 
            firstNameTB.Location = new Point(196, 78);
            firstNameTB.Margin = new Padding(3, 2, 3, 2);
            firstNameTB.Name = "firstNameTB";
            firstNameTB.Size = new Size(148, 23);
            firstNameTB.TabIndex = 1;
            // 
            // lastNameTB
            // 
            lastNameTB.Location = new Point(196, 103);
            lastNameTB.Margin = new Padding(3, 2, 3, 2);
            lastNameTB.Name = "lastNameTB";
            lastNameTB.Size = new Size(148, 23);
            lastNameTB.TabIndex = 2;
            // 
            // streetNumberTB
            // 
            streetNumberTB.Location = new Point(196, 155);
            streetNumberTB.Margin = new Padding(3, 2, 3, 2);
            streetNumberTB.Name = "streetNumberTB";
            streetNumberTB.Size = new Size(149, 23);
            streetNumberTB.TabIndex = 4;
            // 
            // streetNameTB
            // 
            streetNameTB.Location = new Point(196, 180);
            streetNameTB.Margin = new Padding(3, 2, 3, 2);
            streetNameTB.Name = "streetNameTB";
            streetNameTB.Size = new Size(149, 23);
            streetNameTB.TabIndex = 5;
            // 
            // cityTB
            // 
            cityTB.Location = new Point(196, 205);
            cityTB.Margin = new Padding(3, 2, 3, 2);
            cityTB.Name = "cityTB";
            cityTB.Size = new Size(149, 23);
            cityTB.TabIndex = 6;
            // 
            // provinceTB
            // 
            provinceTB.Location = new Point(196, 229);
            provinceTB.Margin = new Padding(3, 2, 3, 2);
            provinceTB.Name = "provinceTB";
            provinceTB.Size = new Size(149, 23);
            provinceTB.TabIndex = 7;
            // 
            // zipcodeTB
            // 
            zipcodeTB.Location = new Point(196, 254);
            zipcodeTB.Margin = new Padding(3, 2, 3, 2);
            zipcodeTB.Name = "zipcodeTB";
            zipcodeTB.Size = new Size(149, 23);
            zipcodeTB.TabIndex = 8;
            // 
            // phoneNumberTB
            // 
            phoneNumberTB.Location = new Point(196, 130);
            phoneNumberTB.Margin = new Padding(3, 2, 3, 2);
            phoneNumberTB.Name = "phoneNumberTB";
            phoneNumberTB.Size = new Size(149, 23);
            phoneNumberTB.TabIndex = 3;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(56, 80);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(64, 15);
            firstNameLabel.TabIndex = 9;
            firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(56, 105);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(63, 15);
            lastNameLabel.TabIndex = 10;
            lastNameLabel.Text = "Last Name";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(56, 133);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(88, 15);
            phoneNumberLabel.TabIndex = 11;
            phoneNumberLabel.Text = "Phone Number";
            // 
            // streetNumberLabel
            // 
            streetNumberLabel.AutoSize = true;
            streetNumberLabel.Location = new Point(56, 157);
            streetNumberLabel.Name = "streetNumberLabel";
            streetNumberLabel.Size = new Size(84, 15);
            streetNumberLabel.TabIndex = 12;
            streetNumberLabel.Text = "Street Number";
            // 
            // streetNameLabel
            // 
            streetNameLabel.AutoSize = true;
            streetNameLabel.Location = new Point(56, 182);
            streetNameLabel.Name = "streetNameLabel";
            streetNameLabel.Size = new Size(72, 15);
            streetNameLabel.TabIndex = 13;
            streetNameLabel.Text = "Street Name";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(56, 207);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(28, 15);
            cityLabel.TabIndex = 14;
            cityLabel.Text = "City";
            // 
            // provinceLabel
            // 
            provinceLabel.AutoSize = true;
            provinceLabel.Location = new Point(56, 232);
            provinceLabel.Name = "provinceLabel";
            provinceLabel.Size = new Size(53, 15);
            provinceLabel.TabIndex = 15;
            provinceLabel.Text = "Province";
            // 
            // zipCodeLabel
            // 
            zipCodeLabel.AutoSize = true;
            zipCodeLabel.Location = new Point(56, 257);
            zipCodeLabel.Name = "zipCodeLabel";
            zipCodeLabel.Size = new Size(55, 15);
            zipCodeLabel.TabIndex = 16;
            zipCodeLabel.Text = "Zip Code";
            // 
            // submitButton
            // 
            submitButton.Location = new Point(607, 307);
            submitButton.Margin = new Padding(3, 2, 3, 2);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(82, 22);
            submitButton.TabIndex = 17;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // membershipTypeGB
            // 
            membershipTypeGB.Controls.Add(premiumRB);
            membershipTypeGB.Controls.Add(regularRB);
            membershipTypeGB.Location = new Point(369, 128);
            membershipTypeGB.Margin = new Padding(3, 2, 3, 2);
            membershipTypeGB.Name = "membershipTypeGB";
            membershipTypeGB.Padding = new Padding(3, 2, 3, 2);
            membershipTypeGB.Size = new Size(144, 92);
            membershipTypeGB.TabIndex = 18;
            membershipTypeGB.TabStop = false;
            membershipTypeGB.Text = "Membership Type";
            // 
            // premiumRB
            // 
            premiumRB.AutoSize = true;
            premiumRB.Location = new Point(5, 52);
            premiumRB.Margin = new Padding(3, 2, 3, 2);
            premiumRB.Name = "premiumRB";
            premiumRB.Size = new Size(74, 19);
            premiumRB.TabIndex = 1;
            premiumRB.TabStop = true;
            premiumRB.Text = "Premium";
            premiumRB.UseVisualStyleBackColor = true;
            // 
            // regularRB
            // 
            regularRB.AutoSize = true;
            regularRB.Location = new Point(5, 26);
            regularRB.Margin = new Padding(3, 2, 3, 2);
            regularRB.Name = "regularRB";
            regularRB.Size = new Size(65, 19);
            regularRB.TabIndex = 0;
            regularRB.TabStop = true;
            regularRB.Text = "Regular";
            regularRB.UseVisualStyleBackColor = true;
            // 
            // yearlyRB
            // 
            yearlyRB.AutoSize = true;
            yearlyRB.Location = new Point(5, 50);
            yearlyRB.Margin = new Padding(3, 2, 3, 2);
            yearlyRB.Name = "yearlyRB";
            yearlyRB.Size = new Size(56, 19);
            yearlyRB.TabIndex = 3;
            yearlyRB.TabStop = true;
            yearlyRB.Text = "Yearly";
            yearlyRB.UseVisualStyleBackColor = true;
            // 
            // monthlyRB
            // 
            monthlyRB.AutoSize = true;
            monthlyRB.Location = new Point(5, 24);
            monthlyRB.Margin = new Padding(3, 2, 3, 2);
            monthlyRB.Name = "monthlyRB";
            monthlyRB.Size = new Size(70, 19);
            monthlyRB.TabIndex = 2;
            monthlyRB.TabStop = true;
            monthlyRB.Text = "Monthly";
            monthlyRB.UseVisualStyleBackColor = true;
            // 
            // frequencyTypeGB
            // 
            frequencyTypeGB.Controls.Add(yearlyRB);
            frequencyTypeGB.Controls.Add(monthlyRB);
            frequencyTypeGB.Location = new Point(531, 128);
            frequencyTypeGB.Margin = new Padding(3, 2, 3, 2);
            frequencyTypeGB.Name = "frequencyTypeGB";
            frequencyTypeGB.Padding = new Padding(3, 2, 3, 2);
            frequencyTypeGB.Size = new Size(148, 92);
            frequencyTypeGB.TabIndex = 19;
            frequencyTypeGB.TabStop = false;
            frequencyTypeGB.Text = "Frequency Type";
            // 
            // backButton
            // 
            backButton.Location = new Point(10, 307);
            backButton.Margin = new Padding(3, 2, 3, 2);
            backButton.Name = "backButton";
            backButton.Size = new Size(82, 22);
            backButton.TabIndex = 20;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(backButton);
            Controls.Add(frequencyTypeGB);
            Controls.Add(membershipTypeGB);
            Controls.Add(submitButton);
            Controls.Add(zipCodeLabel);
            Controls.Add(provinceLabel);
            Controls.Add(cityLabel);
            Controls.Add(streetNameLabel);
            Controls.Add(streetNumberLabel);
            Controls.Add(phoneNumberLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Controls.Add(phoneNumberTB);
            Controls.Add(zipcodeTB);
            Controls.Add(provinceTB);
            Controls.Add(cityTB);
            Controls.Add(streetNameTB);
            Controls.Add(streetNumberTB);
            Controls.Add(lastNameTB);
            Controls.Add(firstNameTB);
            Controls.Add(signUpLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SignUp";
            Text = "SignUp";
            membershipTypeGB.ResumeLayout(false);
            membershipTypeGB.PerformLayout();
            frequencyTypeGB.ResumeLayout(false);
            frequencyTypeGB.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public void UpdateComponent()
        {
            ResourceManager rm = new ResourceManager("Project_AD.Resources.Resources", typeof(Program).Assembly);

            signUpLabel.Text = rm.GetString("signupButton");
            firstNameLabel.Text = rm.GetString("firstNameLabel");
            lastNameLabel.Text = rm.GetString("lastNameLabel");
            phoneNumberLabel.Text = rm.GetString("phoneNumberLabel");
            streetNumberLabel.Text = rm.GetString("streetNumberLabel");
            streetNameLabel.Text = rm.GetString("streetNameLabel");
            cityLabel.Text = rm.GetString("cityLabel");
            provinceLabel.Text = rm.GetString("provinceLabel");
            zipCodeLabel.Text = rm.GetString("zipCodeLabel");
            submitButton.Text = rm.GetString("submitButton");
            membershipTypeGB.Text = rm.GetString("membershipTypeGB");
            regularRB.Text = rm.GetString("regularRB");
            premiumRB.Text = rm.GetString("premiumRB");
            frequencyTypeGB.Text = rm.GetString("frequencyTypeGB");
            monthlyRB.Text = rm.GetString("monthlyRB");
            yearlyRB.Text = rm.GetString("yearlyRB");
            backButton.Text = rm.GetString("backButton");
        }

        private Label signUpLabel;
        private TextBox firstNameTB;
        private TextBox lastNameTB;
        private TextBox streetNumberTB;
        private TextBox streetNameTB;
        private TextBox cityTB;
        private TextBox provinceTB;
        private TextBox zipcodeTB;
        private TextBox phoneNumberTB;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label phoneNumberLabel;
        private Label streetNumberLabel;
        private Label streetNameLabel;
        private Label cityLabel;
        private Label provinceLabel;
        private Label zipCodeLabel;
        private Button submitButton;
        private GroupBox membershipTypeGB;
        private RadioButton yearlyRB;
        private RadioButton monthlyRB;
        private RadioButton premiumRB;
        private RadioButton regularRB;
        private GroupBox frequencyTypeGB;
        private Button backButton;
    }
}