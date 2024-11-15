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
            phoneNumberTB = new TextBox();
            streetNumberTB = new TextBox();
            streetNameTB = new TextBox();
            cityTB = new TextBox();
            provinceTB = new TextBox();
            zipCodeTB = new TextBox();
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
            premiumButton = new RadioButton();
            regularButton = new RadioButton();
            yearlyButton = new RadioButton();
            monthlyButton = new RadioButton();
            frequencyTypeGB = new GroupBox();
            membershipTypeGB.SuspendLayout();
            frequencyTypeGB.SuspendLayout();
            SuspendLayout();
            // 
            // signUpLabel
            // 
            signUpLabel.AutoSize = true;
            signUpLabel.Location = new Point(373, 36);
            signUpLabel.Name = "signUpLabel";
            signUpLabel.Size = new Size(61, 20);
            signUpLabel.TabIndex = 0;
            signUpLabel.Text = "Sign Up";
            // 
            // firstNameTB
            // 
            firstNameTB.Location = new Point(224, 104);
            firstNameTB.Name = "firstNameTB";
            firstNameTB.Size = new Size(168, 27);
            firstNameTB.TabIndex = 1;
            // 
            // lastNameTB
            // 
            lastNameTB.Location = new Point(224, 137);
            lastNameTB.Name = "lastNameTB";
            lastNameTB.Size = new Size(168, 27);
            lastNameTB.TabIndex = 2;
            // 
            // phoneNumberTB
            // 
            phoneNumberTB.Location = new Point(224, 336);
            phoneNumberTB.Name = "phoneNumberTB";
            phoneNumberTB.Size = new Size(170, 27);
            phoneNumberTB.TabIndex = 3;
            // 
            // streetNumberTB
            // 
            streetNumberTB.Location = new Point(224, 170);
            streetNumberTB.Name = "streetNumberTB";
            streetNumberTB.Size = new Size(170, 27);
            streetNumberTB.TabIndex = 4;
            // 
            // streetNameTB
            // 
            streetNameTB.Location = new Point(224, 237);
            streetNameTB.Name = "streetNameTB";
            streetNameTB.Size = new Size(170, 27);
            streetNameTB.TabIndex = 5;
            // 
            // cityTB
            // 
            cityTB.Location = new Point(224, 270);
            cityTB.Name = "cityTB";
            cityTB.Size = new Size(170, 27);
            cityTB.TabIndex = 6;
            // 
            // provinceTB
            // 
            provinceTB.Location = new Point(224, 204);
            provinceTB.Name = "provinceTB";
            provinceTB.Size = new Size(170, 27);
            provinceTB.TabIndex = 7;
            // 
            // zipCodeTB
            // 
            zipCodeTB.Location = new Point(224, 303);
            zipCodeTB.Name = "zipCodeTB";
            zipCodeTB.Size = new Size(170, 27);
            zipCodeTB.TabIndex = 8;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(64, 107);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(80, 20);
            firstNameLabel.TabIndex = 9;
            firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(64, 140);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(79, 20);
            lastNameLabel.TabIndex = 10;
            lastNameLabel.Text = "Last Name";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(64, 339);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(108, 20);
            phoneNumberLabel.TabIndex = 11;
            phoneNumberLabel.Text = "Phone Number";
            // 
            // streetNumberLabel
            // 
            streetNumberLabel.AutoSize = true;
            streetNumberLabel.Location = new Point(64, 173);
            streetNumberLabel.Name = "streetNumberLabel";
            streetNumberLabel.Size = new Size(106, 20);
            streetNumberLabel.TabIndex = 12;
            streetNumberLabel.Text = "Street Number";
            // 
            // streetNameLabel
            // 
            streetNameLabel.AutoSize = true;
            streetNameLabel.Location = new Point(64, 207);
            streetNameLabel.Name = "streetNameLabel";
            streetNameLabel.Size = new Size(92, 20);
            streetNameLabel.TabIndex = 13;
            streetNameLabel.Text = "Street Name";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(64, 240);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(34, 20);
            cityLabel.TabIndex = 14;
            cityLabel.Text = "City";
            // 
            // provinceLabel
            // 
            provinceLabel.AutoSize = true;
            provinceLabel.Location = new Point(64, 273);
            provinceLabel.Name = "provinceLabel";
            provinceLabel.Size = new Size(65, 20);
            provinceLabel.TabIndex = 15;
            provinceLabel.Text = "Province";
            // 
            // zipCodeLabel
            // 
            zipCodeLabel.AutoSize = true;
            zipCodeLabel.Location = new Point(64, 306);
            zipCodeLabel.Name = "zipCodeLabel";
            zipCodeLabel.Size = new Size(70, 20);
            zipCodeLabel.TabIndex = 16;
            zipCodeLabel.Text = "Zip Code";
            // 
            // submitButton
            // 
            submitButton.Location = new Point(694, 409);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(94, 29);
            submitButton.TabIndex = 17;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // membershipTypeGB
            // 
            membershipTypeGB.Controls.Add(premiumButton);
            membershipTypeGB.Controls.Add(regularButton);
            membershipTypeGB.Location = new Point(422, 170);
            membershipTypeGB.Name = "membershipTypeGB";
            membershipTypeGB.Size = new Size(164, 127);
            membershipTypeGB.TabIndex = 18;
            membershipTypeGB.TabStop = false;
            membershipTypeGB.Text = "Membership Type";
            // 
            // premiumButton
            // 
            premiumButton.AutoSize = true;
            premiumButton.Location = new Point(6, 70);
            premiumButton.Name = "premiumButton";
            premiumButton.Size = new Size(89, 24);
            premiumButton.TabIndex = 1;
            premiumButton.TabStop = true;
            premiumButton.Text = "Premium";
            premiumButton.UseVisualStyleBackColor = true;
            // 
            // regularButton
            // 
            regularButton.AutoSize = true;
            regularButton.Location = new Point(6, 35);
            regularButton.Name = "regularButton";
            regularButton.Size = new Size(81, 24);
            regularButton.TabIndex = 0;
            regularButton.TabStop = true;
            regularButton.Text = "Regular";
            regularButton.UseVisualStyleBackColor = true;
            // 
            // yearlyButton
            // 
            yearlyButton.AutoSize = true;
            yearlyButton.Location = new Point(6, 67);
            yearlyButton.Name = "yearlyButton";
            yearlyButton.Size = new Size(69, 24);
            yearlyButton.TabIndex = 3;
            yearlyButton.TabStop = true;
            yearlyButton.Text = "Yearly";
            yearlyButton.UseVisualStyleBackColor = true;
            // 
            // monthlyButton
            // 
            monthlyButton.AutoSize = true;
            monthlyButton.Location = new Point(6, 32);
            monthlyButton.Name = "monthlyButton";
            monthlyButton.Size = new Size(84, 24);
            monthlyButton.TabIndex = 2;
            monthlyButton.TabStop = true;
            monthlyButton.Text = "Monthly";
            monthlyButton.UseVisualStyleBackColor = true;
            // 
            // frequencyTypeGB
            // 
            frequencyTypeGB.Controls.Add(yearlyButton);
            frequencyTypeGB.Controls.Add(monthlyButton);
            frequencyTypeGB.Location = new Point(607, 170);
            frequencyTypeGB.Name = "frequencyTypeGB";
            frequencyTypeGB.Size = new Size(169, 127);
            frequencyTypeGB.TabIndex = 19;
            frequencyTypeGB.TabStop = false;
            frequencyTypeGB.Text = "Frequency Type";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Controls.Add(zipCodeTB);
            Controls.Add(provinceTB);
            Controls.Add(cityTB);
            Controls.Add(streetNameTB);
            Controls.Add(streetNumberTB);
            Controls.Add(phoneNumberTB);
            Controls.Add(lastNameTB);
            Controls.Add(firstNameTB);
            Controls.Add(signUpLabel);
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
            regularButton.Text = rm.GetString("regularButton");
            premiumButton.Text = rm.GetString("premiumButton");
            frequencyTypeGB.Text = rm.GetString("frequencyTypeGB");
            monthlyButton.Text = rm.GetString("monthlyButton");
            yearlyButton.Text = rm.GetString("yearlyButton");
        }

        private Label signUpLabel;
        private TextBox firstNameTB;
        private TextBox lastNameTB;
        private TextBox phoneNumberTB;
        private TextBox streetNumberTB;
        private TextBox streetNameTB;
        private TextBox cityTB;
        private TextBox provinceTB;
        private TextBox zipCodeTB;
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
        private RadioButton yearlyButton;
        private RadioButton monthlyButton;
        private RadioButton premiumButton;
        private RadioButton regularButton;
        private GroupBox frequencyTypeGB;
    }
}